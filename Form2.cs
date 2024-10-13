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

namespace ProveeduriaVane
{
    public partial class Form2 : MaterialForm
    {
        private ArqueoDeCajaCalculador calculador = new ArqueoDeCajaCalculador();
        private ProcesarCodigoVentas procesadorVentas;
        private DataTable tablaVentas;
        private decimal cajaInicial = 0;
        private Promociones promociones = new Promociones();
        private decimal totalVenta = 0;
        private string filtro;
        private string medioPago;
        private Productos productos = new Productos();
        string connectionString = "Server=Elias_Cano;Database=ProveeDesk;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
        private Productos nuevos = new Productos();

        public Form2()
        {
            InitializeComponent();

            //String de Conexion

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
            this.KeyPress += Form2_KeyPress;
            this.KeyDown += new KeyEventHandler(Form2_KeyDown);

            // Tema de Material Skin
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue100, Accent.Pink700, TextShade.WHITE);

            //Timer estilos
            timer1.Interval = 100; // Intervalo en milisegundos
            timer1.Tick += Timer1_Tick;
            timer1.Start();
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
                    dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 18f, FontStyle.Bold);
                    dgv.DefaultCellStyle.Font = new Font("Roboto", 16f);
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
                    lbl.Font = new Font("Roboto", 14f, FontStyle.Bold);
                }
                else if (control is MaterialSkin.Controls.MaterialLabel materialLbl)
                {
                    materialLbl.ForeColor = Color.White;
                    materialLbl.BackColor = Color.RoyalBlue;
                    materialLbl.Font = new Font("Roboto", 14f, FontStyle.Bold);
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
                    boton.Font = new Font("Roboto", 15f, FontStyle.Bold);
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

        //Función que captura el código de barras
        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
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
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                mbtnReiniciar.PerformClick();
            }
            if (e.KeyCode == Keys.F2)
            {
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

        //Calcular total venta
        public void CalcularTotalVenta()
        {
            decimal total = 0;

            foreach (DataRow row in tablaVentas.Rows)
            {
                total += Convert.ToDecimal(row["PRECIO TOTAL"]);
            }
            lblTotal.Text = total.ToString("C", new System.Globalization.CultureInfo("es-AR"));

        }

        //Guardar venta en base de datos
        private void guardarVenta(string medioPago, decimal totalVenta)
        {
            try
            {
                definirMedioPago(this);
                string consulta = "insert into dbo.Ventas";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertVenta = "INSERT INTO Ventas (fechaYhora, medioPago, montoFinal) VALUES (@fechaYhora, @medioPago, @montoFinal); SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(insertVenta, connection))
                    {
                        command.Parameters.AddWithValue("@fechaYhora", DateTime.Now);
                        command.Parameters.AddWithValue("@medioPago", medioPago);
                        command.Parameters.AddWithValue("@montoFinal", totalVenta);

                        int idVenta = Convert.ToInt32(command.ExecuteScalar());

                        string insertDetalle = "INSERT INTO Detalle_Ventas (id_Venta, codigoBarra, cantidad, precio_Unitario) VALUES (@id_Venta, @codigoBarra, @cantidad, @precio_Unitario);";

                        foreach (DataGridViewRow row in dgvVentas.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                string codigoBarra = Convert.ToString(row.Cells["CÓDIGO"].Value);
                                int cantidad = Convert.ToInt32(row.Cells["CANTIDAD"].Value);
                                decimal precioUnitario = Convert.ToDecimal(row.Cells["PRECIO UNITARIO"].Value);

                                using (SqlCommand detalleCommand = new SqlCommand(insertDetalle, connection))
                                {
                                    detalleCommand.Parameters.AddWithValue("@id_Venta", idVenta);
                                    detalleCommand.Parameters.AddWithValue("@codigoBarra", codigoBarra);
                                    detalleCommand.Parameters.AddWithValue("@cantidad", cantidad);
                                    detalleCommand.Parameters.AddWithValue("@precio_Unitario", precioUnitario);

                                    detalleCommand.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    connection.Close();
                    MessageBox.Show("Venta realizada con éxito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //Finalizar venta
        private void roundButton2_Click(object sender, EventArgs e)
        {
            definirMedioPago(this); // Asegúrate de que medioPago se asigne correctamente.
            if (string.IsNullOrEmpty(medioPago))
            {
                MessageBox.Show("Por favor, seleccione un medio de pago.");
                return; // Salir si no hay medio de pago seleccionado
            }
            guardarVenta(medioPago, totalVenta);
            tablaVentas.Clear();
        }

        //Reinicia el DGV Ventas
        private void mbtnReiniciar_Click(object sender, EventArgs e)
        {
            if (tablaVentas != null)
            {
                tablaVentas.Clear();
            }
        }

        //Mostrar formulario de ajustar caja
        private void mbtnAjustarCaja_Click(object sender, EventArgs e)
        {
            AjustarCaja formulario = new AjustarCaja();
            formulario.Show();
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
            DateTime fechaInicio = dtpInicio.Value.Date;
            DateTime fechaFin = dtpFin.Value.Date;

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

                case "Resumen manual":
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

        //Agregar promociones
        private void mbtnAgregarPromo_Click(object sender, EventArgs e)
        {
            string tipo = Convert.ToString(mcbTipo.SelectedItem);
            string descripcion = mtxtDescripcion.Text;
            decimal precio = decimal.Parse(mtxtPrecioEspecial.Text);
            DateTime inicioPromo = dtpInicioPromo.Value;
            DateTime finalPromo = dtpFinPromo.Value;

            promociones.AgregarPromo(tipo, descripcion, precio, inicioPromo, finalPromo);
            dgvPromos.DataSource = promociones.MostrarPromo();
            borrarPromos();
        }

        private void borrarPromos()
        {
            mtxtDescripcion.Clear();
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
                string query = "SELECT idTipo, nombreTipo FROM TipoProducto";
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
    }
}