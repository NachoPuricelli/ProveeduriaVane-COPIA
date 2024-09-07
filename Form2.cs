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

namespace ProveeduriaVane
{
    public partial class Form2 : MaterialForm
    {
        //Atributos clase Productos
        //Productos elementos = new Productos();
        //private string busqueda = "";
        //private string filtros = "";
        //private string dataGrid = "";
        //private string mensajeAumento;

        private ProcesarCodigoVentas procesadorVentas;
        private DataTable tablaVentas;

        public Form2()
        {
            InitializeComponent();

            //String de Conexion
            string connectionString = "Server=PatriciaB;Database=ProveeDesk;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";

            //Tabla de Ventas y llamado a la clase.
            tablaVentas = DataTableVentas();
            procesadorVentas = new ProcesarCodigoVentas(connectionString, tablaVentas);
            dgvVentas.DataSource = tablaVentas;

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

            //Llamado a la clase que muestra los MonthCalendar
            SeleccionFechaArqueo seleccionFecha = new SeleccionFechaArqueo(mbtnFechaInicio, mbtnFechaFin, this);

            //Cambiar apariencia de labels de total en Tabventas
            label7.BackColor = Color.RoyalBlue;
            label8.BackColor = Color.RoyalBlue;
            label7.ForeColor = Color.White;
            label8.ForeColor = Color.White;
            label7.Font = new Font("Roboto", 14f, FontStyle.Bold);
            label8.Font = new Font("Roboto", 14f, FontStyle.Bold);

        }


        //Función para focusear el TabVentas
        private void Form2_Shown(object sender, EventArgs e)
        {
            this.Activate();  // Asegurarse de que el formulario está activo
            this.Focus();     // Darle foco al formulario para que capture los eventos KeyPress
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
        }

        //Crea DataTableVentas
        private DataTable DataTableVentas()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("CÓDIGO", typeof(string));
            dt.Columns.Add("DESCRIPCIÓN", typeof(string));
            dt.Columns.Add("MARCA", typeof(string));
            dt.Columns.Add("CANTIDAD", typeof(string));
            dt.Columns.Add("PRECIO UNITARIO", typeof(string));
            return dt;
        }

        private void mbtnReiniciar_Click(object sender, EventArgs e)
        {
            if (tablaVentas != null)
            {
                tablaVentas.Clear();
            }
        }

        private void mbtnAjustarCaja_Click(object sender, EventArgs e)
        {
            AjustarCaja formulario = new AjustarCaja();
            formulario.Show();
        }

        private void btnDesbloquearEdicion_Click(object sender, EventArgs e)
        {
            tlpBotonesProductos.BringToFront();
            btnDesbloquearEdicion.Visible = false;
            IngresoPin formularioIngreso = new IngresoPin();
            formularioIngreso.Show();
        }
    }
}
