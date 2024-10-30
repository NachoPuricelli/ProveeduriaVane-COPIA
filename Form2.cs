using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using ProveeDesk;
using MaterialSkin.Properties;
using MaterialSkin.Animations;
using System.Data.SqlClient;
using System.Drawing.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProveeduriaVane
{
    public partial class Form2 : MaterialForm
    {
        private string connectionString = StringConexion.ConnectionString;
        private ArqueoDeCajaCalculador calculador = new ArqueoDeCajaCalculador();
        private ProcesarCodigoVentas procesadorVentas;
        private DataTable tablaVentas;
        private Promociones promociones = new Promociones();
        private Productos productos = new Productos();
        private Productos nuevos = new Productos();
        public decimal cajaInicial = 0;
        private decimal totalVenta = 0;
        private string filtro = "";
        private string medioPago = "";
        private System.Windows.Forms.CheckBox chkHeader = new System.Windows.Forms.CheckBox();

        //Para las promociones:
        private List<int> productosSeleccionados = new List<int>(); // Almacena los IDs de productos seleccionados
        private List<string> descripcionesProductos = new List<string>(); // Almacena las descripciones de los productos seleccionados

        public Form2()
        {
            InitializeComponent();

            //Tabla de Ventas y llamado a la clase.
            tablaVentas = DataTableVentas();
            procesadorVentas = new ProcesarCodigoVentas(connectionString, tablaVentas, this);
            dgvVentas.DataSource = tablaVentas;

            //Tabla productos
            ConfigurarDataGridProductos();

            // Selecciona el TabPage de Ventas al iniciar
            interfazPrincipal.SelectedTab = tabVentas;

            // Asegurarte de que el formulario tenga el foco al mostrarlo
            this.Shown += new EventHandler(Form2_Shown);

            //Para la lectura del código y eventos de teclado.
            this.KeyPreview = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;

            // Tema de Material Skin
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue100, Accent.Pink700, TextShade.WHITE);

            //Timer estilos
            timer1.Interval = 100; // Intervalo en milisegundos
            timer1.Tick += Timer1_Tick;
            timer1.Start();

            //Recargo al checkear los RadioButtons
            mrbCredito.CheckedChanged += MedioPago_CheckedChanged;
            mrbDebito.CheckedChanged += MedioPago_CheckedChanged;

            //Mostrar promociones al inicio
            dgvPromos.DataSource = promociones.MostrarPromo();
        }

        //Función para focusear el TabVentas
        private void Form2_Shown(object sender, EventArgs e)
        {
            this.Activate();  // Asegurarse de que el formulario está activo
            this.Focus();     // Darle foco al formulario para que capture los eventos KeyPress
        }

        //Estilo a todos los DataTable
        private void ConfigurarEstiloDataGridViews(System.Windows.Forms.Control parent)
        {
            foreach (System.Windows.Forms.Control control in parent.Controls)
            {
                if (control is DataGridView dgv)
                {
                    dgv.EnableHeadersVisualStyles = false;
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 15.2f, FontStyle.Bold);
                    dgv.DefaultCellStyle.Font = new Font("Roboto", 14.5f);
                }

                if (control.HasChildren)
                {
                    ConfigurarEstiloDataGridViews(control);
                }
            }
        }

        //Estilo a todos los labels
        private void ConfigurarEstiloLabels(System.Windows.Forms.Control parent)
        {
            foreach (System.Windows.Forms.Control control in parent.Controls)
            {
                if (control is System.Windows.Forms.Label lbl)
                {
                    lbl.ForeColor = Color.White;
                    lbl.BackColor = Color.RoyalBlue;
                    lbl.Font = new Font("Roboto", 13f, FontStyle.Bold);
                }
                else if (control is MaterialSkin.Controls.MaterialLabel materialLbl)
                {
                    materialLbl.ForeColor = Color.White;
                    materialLbl.BackColor = Color.RoyalBlue;
                    materialLbl.Font = new Font("Roboto", 13f, FontStyle.Bold);
                }

                if (control.HasChildren)
                {
                    ConfigurarEstiloLabels(control);
                }
            }
        }

        //Estilo a todos los botones
        private void ConfigurarEstiloBotones(System.Windows.Forms.Control parent)
        {
            foreach (System.Windows.Forms.Control control in parent.Controls)
            {
                if (control is System.Windows.Forms.Button boton)
                {
                    boton.BackColor = Color.MediumBlue;
                    boton.ForeColor = Color.White;
                    boton.Font = new Font("Roboto", 13.5f, FontStyle.Bold);
                }

                if (control.HasChildren)
                {
                    ConfigurarEstiloBotones(control);
                }
            }
        }

        //Funcion aplicar estilos
        private void AplicarEstilos()
        {
            ConfigurarEstiloLabels(this);
            ConfigurarEstiloDataGridViews(this);
            ConfigurarEstiloBotones(this);
        }

        //Estilos cuando el formulario está activo
        private void Form2_Activated(object sender, EventArgs e)
        {
            AplicarEstilos();
        }

        //Estilos en todo momento.
        private void Timer1_Tick(object sender, EventArgs e)
        {
            AplicarEstilos();
        }

        //Muestra formulario de ingreso de caja inicial y guarda el valor
        private void Form2_Load(object sender, EventArgs e)
        {
            CajaInicial caja = new CajaInicial();
            caja.ShowDialog();
            cajaInicial = caja.valorCajaInicial();
        }
        
        //Función que captura el código de barras en Ventas
        private void interfazPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (interfazPrincipal.SelectedTab != tabVentas)
            {
                return;
            }

            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                procesadorVentas.AgregarCaracter(e.KeyChar);
            }
            else if (e.KeyChar == (char)Keys.Insert && procesadorVentas.CodigoBarraBuilder.Length > 0)
            {
                procesadorVentas.ProcesarCodigoBarraFinalizado();
            }
        }

        //Capturar teclas y disparar eventos
        private void interfazPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (interfazPrincipal.SelectedTab != tabVentas)
            {
                return;
            }
            else
            {
                if (e.KeyCode == Keys.F1)
                {
                    mbtnReiniciar.PerformClick();
                }

                if (e.KeyCode == Keys.E)
                {
                    mrbEfectivo.Checked = true;
                }

                if (e.KeyCode == Keys.D)
                {
                    mrbDebito.Checked = true;
                }

                if (e.KeyCode == Keys.C)
                {
                    mrbCredito.Checked = true;
                }

                if (e.KeyCode == Keys.T)
                {
                    mrbTransferencia.Checked = true;
                }

                if (e.KeyCode == Keys.Enter)
                {
                    roundButton2_Click(sender, e);
                }
            }

            if (interfazPrincipal.SelectedTab == tabPromos)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    mbtnAgregarPromo_Click(sender, e);
                }
            }
            
        }

        //Define el medio de pago elegido
        private void definirMedioPago(System.Windows.Forms.Control parent)
        {
            foreach (System.Windows.Forms.Control control in parent.Controls)
            {
                if (control is MaterialSkin.Controls.MaterialRadioButton radioButton)
                {
                    if (radioButton.Checked)
                    {
                        medioPago = radioButton.Text;
                    }
                }

                if (control.HasChildren)
                {
                    definirMedioPago(control);
                }
            }
        }

        //Crea DataTableVentas
        private DataTable DataTableVentas()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("CÓDIGO", typeof(string));
            dt.Columns.Add("DESCRIPCIÓN", typeof(string));
            dt.Columns.Add("MARCA", typeof(string));
            dt.Columns.Add("CANTIDAD", typeof(int));
            dt.Columns.Add("PRECIO UNITARIO", typeof(decimal));
            dt.Columns.Add("PRECIO TOTAL", typeof(decimal));
            return dt;
        }

        private void MedioPago_CheckedChanged(object sender, EventArgs e)
        {
            CalcularTotalVenta();
        }

        //Calcular total venta
        public void CalcularTotalVenta()
        {
            totalVenta = 0;

            foreach (DataRow row in tablaVentas.Rows)
            {
                totalVenta += Convert.ToDecimal(row["PRECIO TOTAL"]);
            }

            if (mrbCredito.Checked || mrbDebito.Checked)
            {
                totalVenta = totalVenta + (totalVenta * 0.10m);
            }

            lblTotal.Text = totalVenta.ToString("C", new System.Globalization.CultureInfo("es-AR"));
        }

        // Guardar venta en base de datos
        public void guardarVenta(string medioPago)
        {
            try
            {
                CalcularTotalVenta();
                int idVenta;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string consultaVenta = @"INSERT INTO Ventas (fecha, medioPago, montoFinal) 
                    OUTPUT INSERTED.idVenta 
                    VALUES (GETDATE(), @medioPago, @totalVenta);";

                    using (SqlCommand commandVenta = new SqlCommand(consultaVenta, connection))
                    {
                        commandVenta.Parameters.AddWithValue("@medioPago", medioPago);
                        commandVenta.Parameters.AddWithValue("@totalVenta", totalVenta);
                        idVenta = (int)commandVenta.ExecuteScalar();
                    }

                    DateTime fechaActual = DateTime.Now;

                    foreach (DataRow row in tablaVentas.Rows)
                    {
                        string codigoBarra = row["CÓDIGO"]?.ToString();
                        MessageBox.Show($"Código de barras consultado: {codigoBarra}");

                        if (string.IsNullOrEmpty(codigoBarra))
                        {
                            MessageBox.Show("El código de barras del producto es nulo. Revisar los datos de tablaVentas.");
                            continue;
                        }

                        int cantidadOriginal = (int)row["CANTIDAD"];
                        decimal precioUnitario = (decimal)row["PRECIO UNITARIO"];
                        decimal precioFinal = precioUnitario;

                        // Variables para almacenar la información de la promoción
                        string tipoPromo = null;
                        decimal precioEspecial = precioUnitario;
                        bool tienePromocion = false;
                        int cantidadPromocion = 0;

                        string consultaPromociones = @"
                        SELECT TOP 1 
                            P.tipoPromo, 
                            PP.precioEspecial, 
                            PP.cantidad as cantidadPromocion,
                            PP.idPromo
                        FROM Promocion_Productos PP
                        JOIN Promociones P ON PP.idPromo = P.idPromo
                        WHERE PP.idProducto = (SELECT idProducto FROM Productos WHERE codigoBarras = @codigoBarra)
                        AND P.fechaInicio <= @fechaActual 
                        AND P.fechaFin >= @fechaActual;";

                        using (SqlCommand commandPromociones = new SqlCommand(consultaPromociones, connection))
                        {
                            commandPromociones.Parameters.AddWithValue("@codigoBarra", codigoBarra);
                            commandPromociones.Parameters.AddWithValue("@fechaActual", fechaActual);

                            try
                            {
                                using (SqlDataReader reader = commandPromociones.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        tipoPromo = reader["tipoPromo"].ToString();
                                        precioEspecial = reader.IsDBNull(reader.GetOrdinal("precioEspecial"))
                                                    ? precioUnitario : reader.GetDecimal(reader.GetOrdinal("precioEspecial"));
                                        cantidadPromocion = reader.GetInt32(reader.GetOrdinal("cantidadPromocion"));
                                        tienePromocion = true;

                                        // Debug para ver los valores
                                        MessageBox.Show($"Promoción encontrada: Tipo={tipoPromo}, CantidadPromo={cantidadPromocion}, IdPromo={reader["idPromo"]}");
                                    }
                                }

                                if (tienePromocion)
                                {
                                    MessageBox.Show($"Aplicando promoción: {tipoPromo} para '{codigoBarra}' con cantidad original {cantidadOriginal}");

                                    if (tipoPromo == "DESCUENTO")
                                    {
                                        precioFinal = precioEspecial;
                                        InsertarDetalleVenta(connection, idVenta, codigoBarra, cantidadOriginal, precioFinal);
                                    }
                                    else if (tipoPromo == "2X1")
                                    {
                                        // Si es 2x1, aseguramos que se guarde la cantidad correcta
                                        int cantidadAjustada = cantidadOriginal * cantidadPromocion;
                                        InsertarDetalleVenta(connection, idVenta, codigoBarra, cantidadAjustada, precioFinal);
                                    }
                                    else if (tipoPromo == "3X2")
                                    {
                                        int cantidadAjustada = cantidadOriginal * 3;
                                        InsertarDetalleVenta(connection, idVenta, codigoBarra, cantidadAjustada, precioFinal);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show($"No se encontraron promociones para el producto '{codigoBarra}'.");
                                    InsertarDetalleVenta(connection, idVenta, codigoBarra, cantidadOriginal, precioFinal);
                                }
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show($"Error al consultar promociones: {ex.Message}");
                                InsertarDetalleVenta(connection, idVenta, codigoBarra, cantidadOriginal, precioUnitario);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error inesperado al procesar promociones: {ex.Message}");
                                InsertarDetalleVenta(connection, idVenta, codigoBarra, cantidadOriginal, precioUnitario);
                            }
                        }
                    }
                }

                tablaVentas.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error en la base de datos: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}");
            }
        }

        // Método para insertar en Detalle_Ventas
        private void InsertarDetalleVenta(SqlConnection connection, int idVenta, string codigoBarra, int cantidad, decimal precio)
        {
            if (connection == null)
            {
                throw new ArgumentNullException(nameof(connection), "La conexión no puede ser nula");
            }

            // Verificar que la conexión esté abierta
            if (connection.State != System.Data.ConnectionState.Open)
            {
                throw new InvalidOperationException("La conexión debe estar abierta");
            }

            try
            {
                string consultaDetalle = @"INSERT INTO Detalle_Ventas (id_Venta, codigoBarra, cantidad, precio_Unitario) 
                    VALUES (@idVenta, @codigoBarra, @cantidad, @precioUnitario)";

                using (SqlCommand commandDetalle = new SqlCommand(consultaDetalle, connection))
                {
                    commandDetalle.Parameters.AddWithValue("@idVenta", idVenta);
                    commandDetalle.Parameters.AddWithValue("@codigoBarra", codigoBarra);
                    commandDetalle.Parameters.AddWithValue("@cantidad", cantidad);
                    commandDetalle.Parameters.AddWithValue("@precioUnitario", precio);

                    commandDetalle.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error al insertar detalle de venta para código de barras {codigoBarra}: {ex.Message}", ex);
            }
        }



        //Finalizar venta
        private void roundButton2_Click(object sender, EventArgs e)
        {
            definirMedioPago(this);

            // Verificar que medioPago no sea nulo o vacío
            if (string.IsNullOrEmpty(medioPago))
            {
                MessageBox.Show("Por favor, seleccione un medio de pago.");
                return;
            }

            // Verificar que tablaVentas contenga datos
            if (tablaVentas.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en la venta.");
                return; // Salir si no hay productos para vender
            }

            // Guardar la venta
            try
            {
                guardarVenta(medioPago);
                MessageBox.Show("Venta guardada exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la venta: {ex.Message}");
            }

            // Limpiar tabla y total
            tablaVentas.Clear();
            lblTotal.Text = "";
            totalVenta = 0;
            mrbCredito.Checked = false;
            mrbDebito.Checked = false;
            mrbEfectivo.Checked = false;
            mrbTransferencia.Checked = false;

        }


        //Reinicia el DGV Ventas
        private void mbtnReiniciar_Click(object sender, EventArgs e)
        {
            if (tablaVentas != null)
            {
                tablaVentas.Clear();
                lblTotal.Text = "";
                totalVenta = 0;
            }
        }

        //Mostrar formulario de ajustar caja
        private void mbtnAjustarCaja_Click(object sender, EventArgs e)
        {
            AjustarCaja formulario = new AjustarCaja();
            formulario.Show();
            formulario.Focus();
        }

        private void btnDesbloquearEdicion_Click(object sender, EventArgs e)
        {
            IngresoPin formularioIngreso = new IngresoPin();
            formularioIngreso.ShowDialog();

            if (formularioIngreso.PinValido)
            {
                tlpBotonesProductos.BringToFront();
                btnDesbloquearEdicion.Visible = false;
            }
            else
            {
                MessageBox.Show("No se pudo desbloquear la edición. PIN incorrecto.");
            }
        }

        //Cambia el DGV en la sección de arqueo de caja para mostrar información diferente
        private void mcbSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatosEnDataGrid();
        }

        // Método para cargar datos en el DataGrid según los DateTimePicker
        private void CargarDatosEnDataGrid()
        {
            DateTime fechaInicio = dtpInicioPeriodoArqueo.Value.Date;
            DateTime fechaFin = dtpFinPeriodoArqueo.Value.Date;

            if (fechaFin < fechaInicio)
            {
                MessageBox.Show("La fecha de fin no debe ser menor a la fecha de inicio. Inténtelo nuevamente");
                return;
            }

            // Mostrar datos en el DataGridView según la selección del ComboBox
            switch (mcbSeccion.SelectedItem.ToString())
            {
                case "Ventas":
                    dgvArqueo.DataSource = calculador.ObtenerVentas(fechaInicio, fechaFin);
                    break;
                case "Total según medio de pago":
                    dgvArqueo.DataSource = calculador.ObtenerTotalesPorMedioPago(fechaInicio, fechaFin);
                    break;

                case "Resumen final":
                    dgvArqueo.DataSource = calculador.ObtenerArqueos(fechaInicio, fechaFin);
                    break;

                case "Resultados manuales":
                    dgvArqueo.DataSource = calculador.resultadoManual(fechaInicio, fechaFin);
                    break;

                default:
                    MessageBox.Show("Seleccione una sección válida.");
                    break;
            }
        }

        //Guardar arqueo manual
        private void btnGuardarArqueoManual_Click(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Now.Date;  // Fecha actual automáticamente

            decimal efectivo = decimal.Parse(txtEfectivo.Text);
            decimal debito = decimal.Parse(txtDebito.Text);
            decimal credito = decimal.Parse(txtCredito.Text);
            decimal transferencia = decimal.Parse(txtTransferencia.Text);
            decimal totalFinal = decimal.Parse(txtTotalFinal.Text);

            calculador.CompararTotales(efectivo, debito, credito, transferencia, totalFinal, fechaActual);

            // Cargar los resultados en el DataGrid
            CargarDatosEnDataGrid();
        }

        //Finalizar dia para el arqueo de caja automático
        private void btnFinalizarDia_Click(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Now.Date; // Fecha actual para guardar el arqueo

            //Calcular y guardar arqueo con la fecha actual
            calculador.CalcularYGuardarArqueo(fechaActual, cajaInicial);

            //Cargar los resultados en el DataGrid
            CargarDatosEnDataGrid();
        }
        private void borrarPromos()
        {
            mtxtPrecioEspecial.Clear();
        }

        public void ConfigurarDataGridProductos()
        {
            // Limpiar las columnas actuales si ya están definidas
            dgvProductos.Columns.Clear();

            // Agregar columna de checkboxes
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Name = "Seleccionar";
            dgvProductos.Columns.Add(checkBoxColumn);

            // Configurar el CheckBox en el encabezado
            chkHeader.Size = new Size(15, 15); // Tamaño del CheckBox
            chkHeader.BackColor = Color.Transparent;

            // Evento para seleccionar/deseleccionar todas las filas
            chkHeader.CheckedChanged += new EventHandler(chkHeader_CheckedChanged);

            // Agregar el CheckBox al control del DataGridView
            dgvProductos.Controls.Add(chkHeader);

            // Ajustar la posición del CheckBox en el encabezado
            dgvProductos.Paint += new PaintEventHandler(dgvProductos_Paint);

            // Agregar columna de código de barras (textbox)
            dgvProductos.Columns.Add("codigoBarras", "CÓDIGO DE BARRAS");

            // Agregar columna de combobox para el tipo de producto
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.HeaderText = "TIPO";
            comboBoxColumn.Name = "Tipo";
            comboBoxColumn.DataSource = ObtenerTiposProducto().Tables[0];  // Usar el DataSet para cargar los tipos
            comboBoxColumn.DisplayMember = "nombreTipo";
            comboBoxColumn.ValueMember = "idTipo";
            comboBoxColumn.DataPropertyName = "id_Tipo";  // Relacionar con la columna id_Tipo en la tabla Productos
            dgvProductos.Columns.Add(comboBoxColumn);

            // Agregar columnas de texto para marca, descripción y precio unitario
            dgvProductos.Columns.Add("marca", "MARCA");
            dgvProductos.Columns.Add("descripcion", "DESCRIPCIÓN");
            dgvProductos.Columns.Add("precioUnitario", "PRECIO UNITARIO");
        }

        //DataSet correspondiente a los tipos de productos para su búsqueda
        public DataSet ObtenerTiposProducto()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataSet dsTipos = new DataSet();
                string query = "SELECT idTipo, nombreTipo FROM TipoProducto ORDER BY nombreTipo asc";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.Fill(dsTipos);
                }
                return dsTipos;
            }
        }


        //Método para llenar el data grid con los productos buscados
        public void LlenarDataGridProductos(string busqueda, string filtro)
        {
            Productos productos = new Productos(); // Instancia de la clase Productos
            DataTable dtResultados = productos.Busqueda(busqueda, filtro);

            // Limpiar filas actuales
            dgvProductos.Rows.Clear();

            // Llenar el DataGridView con los resultados
            foreach (DataRow row in dtResultados.Rows)
            {
                dgvProductos.Rows.Add(false, row["codigoBarras"], row["id_Tipo"], row["marca"], row["descripcion"], row["precioUnitario"]);
            }
        }

        //Método para buscar productos
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (txtBusqueda.Text.Length >= 3)
            {
                filtro = cbFiltros.SelectedItem.ToString().ToLower().Replace("ó", "o");
                LlenarDataGridProductos(txtBusqueda.Text, filtro);
            }
            else
            {
                dgvProductos.Rows.Clear();
            }
        }

        //Obtener ID del tipo de producto
        private int ObtenerIdTipoPorNombre(string nombreTipo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT idTipo FROM TipoProducto WHERE nombreTipo = @nombreTipo";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombreTipo", nombreTipo);
                    return (int)command.ExecuteScalar();
                }
            }
        }

        //Agregar producto
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            // Iterar sobre las filas del DataGridView
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                // Verificar si la fila no es la nueva fila vacía
                if (row.IsNewRow) continue;

                // Obtener los valores de las celdas de la fila
                string codigoBarrasProducto = Convert.ToString(row.Cells["codigoBarras"].Value);
                string descripcionProducto = Convert.ToString(row.Cells["descripcion"].Value);
                string marcaProducto = Convert.ToString(row.Cells["marca"].Value);
                decimal precioUnitarioProducto = Convert.ToDecimal(row.Cells["precioUnitario"].Value);

                // Obtener el valor seleccionado en la columna de tipo (nombreTipo)
                if (row.Cells["Tipo"].Value != null)
                {
                    // Obtener el nombre del tipo seleccionado en el ComboBox
                    string nombreTipo = row.Cells["Tipo"].FormattedValue.ToString(); // Obtiene el valor mostrado del ComboBox

                    // Usar la función para obtener el idTipo a partir del nombreTipo
                    int idTipo = ObtenerIdTipoPorNombre(nombreTipo);

                    // Llamar al método para agregar el producto con los valores obtenidos
                    nuevos.AgregarProducto(codigoBarrasProducto, descripcionProducto, marcaProducto, precioUnitarioProducto, idTipo);
                }
                else
                {
                    // Manejar el caso en que no se haya seleccionado un tipo
                    MessageBox.Show("Por favor selecciona un tipo de producto para la fila con el código de barras: " + codigoBarrasProducto);
                }
            }

            dgvProductos.Rows.Clear();
        }

        private void btnBorrarProducto_Click(object sender, EventArgs e)
        {
            // Lista temporal para almacenar los códigos de barras de los productos seleccionados para eliminar
            List<string> productosSeleccionados = new List<string>();

            // Recorrer todas las filas del DataGridView
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                // Verificar si el CheckBox de la columna "Seleccionar" está marcado
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)row.Cells["Seleccionar"];
                if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value) == true)
                {
                    // Obtener el código de barras del producto seleccionado
                    string codigoBarrasProducto = row.Cells["codigoBarras"].Value.ToString();

                    // Agregar el producto a la lista para eliminar
                    productosSeleccionados.Add(codigoBarrasProducto);
                }
            }

            // Si hay productos seleccionados
            if (productosSeleccionados.Count > 0)
            {
                // Confirmar la eliminación con el usuario
                if (MessageBox.Show("¿Estás seguro de que deseas eliminar los productos seleccionados?", "Confirmar eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Eliminar productos de la base de datos y del DataGridView
                    foreach (string codigoBarrasProducto in productosSeleccionados)
                    {
                        // Llamar al método para eliminar el producto de la base de datos
                        nuevos.EliminarProducto(codigoBarrasProducto);

                        // Buscar la fila correspondiente y eliminarla del DataGridView
                        foreach (DataGridViewRow row in dgvProductos.Rows)
                        {
                            if (row.Cells["codigoBarras"].Value.ToString() == codigoBarrasProducto)
                            {
                                dgvProductos.Rows.Remove(row);
                                break;  // Romper el ciclo una vez que se encuentra y elimina la fila
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No se seleccionó ningún producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                if (row.IsNewRow || !row.Selected) continue; // Solo procesamos la fila seleccionada

                // Obtener los valores de la fila
                string codigoBarras = Convert.ToString(row.Cells["codigoBarras"].Value);
                string descripcion = Convert.ToString(row.Cells["descripcion"].Value);
                string marca = Convert.ToString(row.Cells["marca"].Value);
                decimal precioUnitario = Convert.ToDecimal(row.Cells["precioUnitario"].Value);
                int idTipo = ObtenerIdTipoPorNombre(row.Cells["Tipo"].FormattedValue.ToString());

                // Llamar al método para actualizar el producto
                nuevos.ActualizarProducto(codigoBarras, descripcion, marca, precioUnitario, idTipo);
            }

            dgvProductos.Refresh(); // Refrescar el DataGridView para mostrar los cambios
        }

        //Verificación instantánea de la selección de checkboxes en dgvProductos 
        private void DgvProductos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            // Verifica si la celda actual es un CheckBox
            if (dgvProductos.CurrentCell is DataGridViewCheckBoxCell && dgvProductos.IsCurrentCellDirty)
            {
                // Confirma el cambio inmediatamente
                dgvProductos.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        //Seleccionar todos los checkboxes
        private void chkHeader_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.CheckBox headerBox = (System.Windows.Forms.CheckBox)sender;

            // Recorre todas las filas del DataGridView
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                // Marca o desmarca las celdas de tipo CheckBox de acuerdo al estado del CheckBox del header
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)row.Cells["Seleccionar"];
                checkBoxCell.Value = headerBox.Checked;
            }

            // Refrescar la visualización del DataGridView
            dgvProductos.RefreshEdit();
        }

        // Evento para ajustar la posición del CheckBox en el encabezado cuando se redibuja el DataGridView
        private void dgvProductos_Paint(object sender, PaintEventArgs e)
        {
            // Obtener la ubicación del encabezado de la columna "Seleccionar"
            Rectangle rect = dgvProductos.GetCellDisplayRectangle(dgvProductos.Columns["Seleccionar"].Index, -1, true);

            // Ajustar la posición del CheckBox dentro del encabezado
            chkHeader.Location = new Point(rect.Location.X + (rect.Width / 2) - (chkHeader.Width / 2), rect.Location.Y + (rect.Height / 2) - (chkHeader.Height / 2));
        }

        private void btnAjustePorcentual_Click(object sender, EventArgs e)
        {
            using (AumentoProducto formAumento = new AumentoProducto())
            {
                if (formAumento.ShowDialog() == DialogResult.OK)
                {
                    decimal porcentaje = formAumento.porcentaje;
                    bool productoSeleccionado = false; // Bandera para verificar si algún producto está seleccionado

                    // Recorre todas las filas del DataGridView
                    foreach (DataGridViewRow row in dgvProductos.Rows)
                    {
                        // Verifica si el checkbox de la fila está marcado
                        DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)row.Cells["Seleccionar"];
                        if (Convert.ToBoolean(checkBoxCell.Value))
                        {
                            // Cambia la bandera a true si al menos un producto está seleccionado
                            productoSeleccionado = true;

                            // Obtener el precio actual del producto
                            decimal precioActual = Convert.ToDecimal(row.Cells["precioUnitario"].Value);

                            // Calcular el nuevo precio (ya sea aumento o disminución)
                            decimal nuevoPrecio = precioActual + (precioActual * porcentaje / 100);

                            // Asignar el nuevo precio en la celda correspondiente
                            row.Cells["precioUnitario"].Value = nuevoPrecio;

                            // Actualizar la base de datos con el nuevo precio
                            string codigoBarrasProducto = row.Cells["codigoBarras"].Value.ToString();
                            productos.AumentarDisminuirProducto(codigoBarrasProducto, nuevoPrecio);

                        }
                    }

                    // Si no se seleccionó ningún producto, mostrar un mensaje de advertencia
                    if (productoSeleccionado)
                    {
                        MessageBox.Show("Se aumentaron los productos seleccionados por un " + porcentaje + "%", "Operación Correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se ha seleccionado ningún producto para ajustar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private decimal ObtenerPrecioUnitarioDesdeOtraTabla(string descripcion)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT precioUnitario FROM Productos WHERE descripcion = @descripcion";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@descripcion", descripcion);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return Convert.ToDecimal(reader["precioUnitario"]);
                            }
                            else
                            {
                                MessageBox.Show("Producto no encontrado en la base de datos.");
                                return 0;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el precio unitario: " + ex.Message);
                return 0;
            }
        }



        //Agregar promociones
        private void mbtnAgregarPromo_Click(object sender, EventArgs e)
        {
            string tipo = Convert.ToString(mcbTipo.SelectedItem);
            string descripcion = string.Join(", ", descripcionesProductos);
            DateTime inicioPromo = dtpInicioPromo.Value;
            DateTime finalPromo = dtpFinPromo.Value;
            decimal precioEspecial = 0.0m;

            if (finalPromo < inicioPromo)
            {
                MessageBox.Show("La fecha de fin de la promo no debe ser menor a la fecha de inicio. Inténtelo nuevamente");
                return;
            }

            if (productosSeleccionados.Count == 0)
            {
                MessageBox.Show("Debe escanear al menos un producto antes de agregar la promoción.");
                return;
            }

            // Si la promo es de tipo COMBO o DESCUENTO, se debe proporcionar un precio especial
            if (tipo == "COMBO" || tipo == "DESCUENTO")
            {
                if (string.IsNullOrEmpty(mtxtPrecioEspecial.Text) || !decimal.TryParse(mtxtPrecioEspecial.Text, out precioEspecial))
                {
                    MessageBox.Show("Debe agregar un precio especial válido para este tipo de promoción.");
                    return;
                }
            }
            else
            {
                // Para las promociones de tipo 3X2, 3X1, 2X1, calculamos el precio en base al precio unitario
                decimal precioUnitario = ObtenerPrecioUnitarioDesdeOtraTabla(descripcion);

                if (tipo == "3X2")
                {
                    precioEspecial = precioUnitario * 2; // 3 al precio de 2
                }
                else if (tipo == "3X1" || tipo == "2X1")
                {
                    precioEspecial = precioUnitario; // 3 o 2 al precio de 1
                }
            }

            try
            {
                // Agregar la promoción
                promociones.AgregarPromo(tipo, descripcion, precioEspecial, inicioPromo, finalPromo, productosSeleccionados);
                dgvPromos.DataSource = promociones.MostrarPromo();

                // Limpiar el formulario
                borrarPromos();
                productosSeleccionados.Clear();
                descripcionesProductos.Clear();
                mtxtPrecioEspecial.Text = "";
                txtProductosPromocion.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la promoción: " + ex.Message);
            }
        }

        private void mcbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valorSeleccionado = mcbTipo.SelectedItem.ToString();

            // Activar precio especial solo para COMBO y DESCUENTO
            mtxtPrecioEspecial.Enabled = (valorSeleccionado == "COMBO" || valorSeleccionado == "DESCUENTO");
        }

        private void txtProductosPromocion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (interfazPrincipal.SelectedTab != tabPromos)
            {
                return;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                string codigoBarras = txtProductosPromocion.Text;

                // Lógica para buscar el producto en la base de datos
                using (SqlConnection connection = new SqlConnection(StringConexion.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT idProducto, descripcion FROM Productos WHERE codigoBarras = @codigoBarras"; // Asegúrate de que `descripcion` es el campo correcto
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@codigoBarras", codigoBarras);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idProducto = reader.GetInt32(0);
                            string nombreProducto = reader.GetString(1);

                            // Verificar si el producto ya está en la lista de seleccionados
                            if (!productosSeleccionados.Contains(idProducto))
                            {
                                productosSeleccionados.Add(idProducto);
                                descripcionesProductos.Add(nombreProducto); // Agregar la descripción del producto
                                MessageBox.Show(string.Join(", ", descripcionesProductos), "Contenido de descripcionesProductos");
                                MessageBox.Show($"Producto escaneado: {nombreProducto} agregado a la promoción.");
                            }
                            else
                            {
                                MessageBox.Show("Este producto ya ha sido agregado a la promoción.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Producto no encontrado.");
                        }
                    }
                }

                // Limpiar el TextBox para el próximo escaneo
                txtProductosPromocion.Clear();
                txtProductosPromocion.Focus(); // Mantener el foco en el TextBox
            }
        }

        private void btnDescargarPDF_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpInicioPeriodoArqueo.Value.Date;
            DateTime fechaFin = dtpFinPeriodoArqueo.Value.Date;

            sfdGuardarPDFArqueo.Filter = "PDF files (*.pdf)|*.pdf";
            sfdGuardarPDFArqueo.Title = "Guardar Reporte PDF";
            sfdGuardarPDFArqueo.DefaultExt = "pdf";

            // Sugerir un nombre predeterminado basado en las fechas
            string nombreArchivo = $"Arqueo_{fechaInicio.ToString("yyyy-MM-dd")}_{fechaFin.ToString("yyyy-MM-dd")}.pdf";
            sfdGuardarPDFArqueo.FileName = nombreArchivo;

            if (sfdGuardarPDFArqueo.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = sfdGuardarPDFArqueo.FileName;

                // Crear instancias de las clases
                GenerarPDF generadorPdf = new GenerarPDF();

                // Obtener datos en DataTables
                DataTable tablaVentas = calculador.ObtenerVentas(fechaInicio, fechaFin);
                DataTable tablaTotales = calculador.ObtenerTotalesPorMedioPago(fechaInicio, fechaFin);
                DataTable tablaArqueos = calculador.ObtenerArqueos(fechaInicio, fechaFin);
                DataTable tablaManual = calculador.resultadoManual(fechaInicio, fechaFin);

                // Generar el PDF
                generadorPdf.GenerarReporteCompletoPdf(fechaInicio, fechaFin, rutaArchivo, tablaVentas, tablaTotales, tablaArqueos, tablaManual);

                MessageBox.Show("PDF generado exitosamente en " + rutaArchivo);
            }
        }
    }
}
