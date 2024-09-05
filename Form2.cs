using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ProveeduriaVane
{
    public partial class Form2 : MaterialForm
    {
        //Atributos clase Productos/Arqueo
        private string busqueda = "";
        private string filtros = "";
        private Button desbloqueo;
        private Button agregar;
        private Button borrar;
        private Button editar;
        private Button aumentar;
        private string dataGrid = "";
        private string mensajeAumento;
        Productos elementos = new Productos();
        Arqueo componentes = new Arqueo();
        private DateTimePicker inicial;
        private DateTimePicker final;

        private StringBuilder codigoBarraBuilder = new StringBuilder();
        private System.Windows.Forms.Timer timer;
        private const int tiempoMaximoEntreCaracteres = 100; // 100 milisegundos
        private const int longitudEsperadaCodigo = 13; // Ajusta según la longitud esperada de tu código de barras

        string connectionString = "Server=ELIAS_CANO\\SQLEXPRESS;Database=ProveeDesk;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
        private DataTable dataTable;

        public Form2()
        {
            InitializeComponent();

            // Inicializa el Timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = tiempoMaximoEntreCaracteres;
            timer.Tick += Timer_Tick;


            // Para capturar el código de barras
            this.KeyPreview = true;
            this.KeyPress += Form2_KeyPress;

            // Para el DataGridView
            dataTable = new DataTable();
            dataTable.Columns.Add("CÓDIGO", typeof(string));
            dataTable.Columns.Add("DESCRIPCIÓN", typeof(string));
            dataTable.Columns.Add("MARCA", typeof(string));
            dataTable.Columns.Add("CANTIDAD", typeof(string));
            dataTable.Columns.Add("PRECIO UNITARIO", typeof(string));
            dgvVentas.DataSource = dataTable;
            dgvVentas.ReadOnly = true;

            // Tema de Material Skin
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue100, Accent.Pink700, TextShade.WHITE);
        }

        //private void cbSeccion_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Seccion();
        //}

        //private void Seccion()
        //{
        //    string Opciones = cbSeccion.SelectedItem.ToString();

        //    switch (Opciones)
        //    {
        //        case "Ventas":
        //            dgvMedioPago.Visible = false;
        //            pbMedioPago.Visible = false;
        //            dgvResumenFinal.Visible = false;
        //            pbResumenFinal.Visible = false;
        //            break;
        //        case "Totales según medio de pago":
        //            dgvArqueo.Visible = false;
        //            pbResumenFinal.Visible = false;
        //            dgvResumenFinal.Visible = false;
        //            dgvMedioPago.Visible = true;
        //            pbMedioPago.Visible = true;
        //            break;
        //        case "Resumen final":
        //            dgvMedioPago.Visible = false;
        //            pbMedioPago.Visible = false;
        //            dgvArqueo.Visible = false;
        //            dgvResumenFinal.Visible = true;
        //            pbResumenFinal.Visible = true;
        //            break;
        //    }
        //}

        private void btnDesbloquearEdicion_Click_1(object sender, EventArgs e)
        {

            elementos.desbloquear(btnAgregarProducto, btnEditarProductos, btnBorrarProducto, btnAumentarProducto);
            elementos.bloqueo(btnDesbloquearEdicion);

        }

        private void btnAjustarCaja_Click(object sender, EventArgs e)
        {

        }

        private void btnReiniciarLista_Click(object sender, EventArgs e)
        {

        }

        private void btnAumentarProducto_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAjustarCaja_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAgregarDevolucion_Click(object sender, EventArgs e)
        {

        }


        // Captura del código de barras usando KeyPress
        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Inicia o reinicia el temporizador cada vez que se presiona una tecla
            timer.Stop();
            timer.Start();

            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                codigoBarraBuilder.Append(e.KeyChar);

                // Si la longitud esperada se alcanza, detenemos el temporizador y procesamos el código
                if (codigoBarraBuilder.Length == longitudEsperadaCodigo)
                {
                    ProcesarCodigoBarraFinalizado();
                }
            }
            else if (e.KeyChar == (char)Keys.Enter && codigoBarraBuilder.Length > 0)
            {
                ProcesarCodigoBarraFinalizado();
            }
        }

        private void ProcesarCodigoBarraFinalizado()
        {
            timer.Stop();
            string codigoBarra = codigoBarraBuilder.ToString();

            MessageBox.Show($"Código de barras capturado: {codigoBarra}", "Código de Barras", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Llama a tu método para procesar el código de barras
            ProcesarCodigoBarra(codigoBarra);
            codigoBarraBuilder.Clear(); // Limpiar para el próximo código de barras
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Si el temporizador se dispara, significa que el usuario dejó de ingresar datos, por lo que procesamos el código de barras
            ProcesarCodigoBarraFinalizado();
        }

        // Llamado a la clase ProcesarCodigoDeBarra
        private void ProcesarCodigoBarra(string codigoBarra)
        {
            ProcesarCodigoDeBarra procesador = new ProcesarCodigoDeBarra(connectionString, dataTable);
            procesador.Procesar(codigoBarra);
        }

        private void btnDesbloquearEdicion_Click(object sender, EventArgs e)
        {

        }
    }
}
