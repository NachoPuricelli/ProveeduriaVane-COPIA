using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        Productos elementos = new Productos();
        private string busqueda = "";
        private string filtros = "";
        private string dataGrid = "";
        private string mensajeAumento;

        private ProcesarCodigoVentas procesadorVentas;
        private DataTable tablaVentas;

        public Form2()
        {
            InitializeComponent();

            //Tabla Ventas y String de Conexion
            string connectionString = "Server=ELIAS_CANO\\SQLEXPRESS;Database=ProveeDesk;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
            tablaVentas = DataTableVentas();
            procesadorVentas = new ProcesarCodigoVentas(connectionString, tablaVentas);
            dgvVentas.DataSource = tablaVentas;

            // Selecciona el TabPage de Ventas al iniciar
            interfazPrincipal.SelectedTab = tabVentas;

            // Asegurarte de que el formulario tenga el foco al mostrarlo
            this.Shown += new EventHandler(Form2_Shown);

            //Para la lectura del código
            this.KeyPreview = true;
            this.KeyPress += Form2_KeyPress;

            // Tema de Material Skin
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue100, Accent.Pink700, TextShade.WHITE);

            //Llamado a la clase que muestra los MonthCalendar
            SeleccionFechaArqueo seleccionFecha = new SeleccionFechaArqueo(mbtnFechaInicio, mbtnFechaFin, this);
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
                tablaVentas.Clear();  // Esto eliminará las filas del DataTable y actualizará el DataGridView
            }
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

        //private void btnDesbloquearEdicion_Click_1(object sender, EventArgs e)
        //{

        //    elementos.desbloquear(btnAgregarProducto, btnEditarProductos, btnBorrarProducto, btnAumentarProducto);
        //    elementos.bloqueo(btnDesbloquearEdicion);

        //}

        // Captura del código de barras usando KeyPress

    }
}
