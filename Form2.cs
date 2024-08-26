using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProveeduriaVane
{
    public partial class Form2 : MaterialSkin.Controls.MaterialForm
    {
        private string codigoBarra = string.Empty;
        private string connectionString = "Server=ELIAS_CANO\\SQLEXPRESS;Database=productos; Integrated Security=True;";
        private DataTable dataTable;
        public Form2()
        {
            InitializeComponent();
            //Lineas para tarjetas de MaterialSkin
            cbSeccion.SelectedIndexChanged += cbSeccion_SelectedIndexChanged;
            dgvMedioPago.Visible = false;
            pbMedioPago.Visible = false;
            dgvResumenFinal.Visible = false;
            pbResumenFinal.Visible = false;

            //Para capturar el código
            this.KeyPreview = true; 
            this.KeyDown += Form2_KeyDown;

            //Para el DGV
            dataTable = new DataTable();
            dataTable.Columns.Add("CÓDIGO", typeof(string));
            dataTable.Columns.Add("DESCRIPCIÓN", typeof(string));
            dataTable.Columns.Add("CANTIDAD", typeof(string));
            dataTable.Columns.Add("PRECIO UNITARIO", typeof(string));
            dgvVentas.DataSource = dataTable;
            dgvVentas.ReadOnly = true; 
        }

        private void cbSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Seccion();
        }

        private void Seccion()
        {

            string Opciones = cbSeccion.SelectedItem.ToString();

            switch (Opciones)
            {
                case "Ventas":
                    dgvMedioPago.Visible = false;
                    pbMedioPago.Visible = false;
                    dgvResumenFinal.Visible = false;
                    pbResumenFinal.Visible = false;
                    break;
                case "Totales según medio de pago":
                    dgvArqueo.Visible = false;
                    pbResumenFinal.Visible = false;
                    dgvResumenFinal.Visible = false;
                    dgvMedioPago.Visible = true;
                    pbMedioPago.Visible = true;
                    break;
                case "Resumen final":
                    dgvMedioPago.Visible = false;
                    pbMedioPago.Visible = false;
                    dgvArqueo.Visible = false;
                    dgvResumenFinal.Visible = true;
                    pbResumenFinal.Visible = true;
                    break;
            }
        }

        private void btnDesbloquearEdicion_Click(object sender, EventArgs e)
        {
            btnAgregarProducto.Visible = true;
            btnBorrarProducto.Visible = true;
            btnEditarProductos.Visible = true;
            btnAumentarProducto.Visible = true;
            btnDesbloquearEdicion.Visible = false;
        }

        private void btnAjustarCaja_Click(object sender, EventArgs e)
        {
            mcAjusteCaja.Visible = true;
            mcDevolucion.Visible = false;
        }

        private void btnReiniciarLista_Click(object sender, EventArgs e)
        {

        }

        private void btnDesbloquearEdicion_Click_1(object sender, EventArgs e)
        {
            btnAgregarProducto.Visible = true;
            btnBorrarProducto.Visible = true;
            btnEditarProductos.Visible = true;
            btnAumentarProducto.Visible = true;
            btnDesbloquearEdicion.Visible = false;
        }

        private void btnAumentarProducto_Click_1(object sender, EventArgs e)
        {
            mcMensajeAumento.Visible = true;
        }

        private void btnAjustarCaja_Click_1(object sender, EventArgs e)
        {
            mcAjusteCaja.Visible = true;
        }

        private void btnAgregarDevolucion_Click(object sender, EventArgs e)
        {
            mcDevolucion.Visible = true;
        }

        private void cbFechaInicial_MouseClick(object sender, MouseEventArgs e)
        {
            calendarioFechaInicial.Visible = true;
            calendarioFechaFinal.Visible = false;
        }

        private void cbFechaFinal_MouseClick(object sender, MouseEventArgs e)
        {
            calendarioFechaFinal.Visible = true;
            calendarioFechaInicial.Visible = false;
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(codigoBarra))
                {
                    MessageBox.Show($"Código de barras capturado: {codigoBarra}", "Código de Barras", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ProcesarCodigoBarra(codigoBarra);
                    codigoBarra = string.Empty;
                }
            }
            else if (char.IsLetterOrDigit((char)e.KeyValue))
            {
                codigoBarra += (char)e.KeyValue;
            }
        }

        private void ProcesarCodigoBarra(string codigoBarra)
        {
            string connectionString = "tu cadena de conexión aquí";
            ProcesarCódigoDeBarra procesador = new ProcesarCódigoDeBarra (connectionString, dataTable);
            procesador.Procesar(codigoBarra);
        }


    }
}
