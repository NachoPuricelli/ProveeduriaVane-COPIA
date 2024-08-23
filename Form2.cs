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
        public Form2()
        {
            InitializeComponent();
            cbSeccion.SelectedIndexChanged += cbSeccion_SelectedIndexChanged;
            dgvMedioPago.Visible = false;
            pbMedioPago.Visible = false;
            dgvResumenFinal.Visible = false;
            pbResumenFinal.Visible = false;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dgvResumenFinal.Rows.Add("FECHA");
            dgvResumenFinal.Rows.Add("TOTAL INICIAL");
            dgvResumenFinal.Rows.Add("DESCUENTOS");
            dgvResumenFinal.Rows.Add("DEVOLUCIONES");
            dgvResumenFinal.Rows.Add("TOTAL FINAL");
            dgvResumenFinal.Rows.Add("DIFERENCIA");

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


        private void interfazPrincipal_Resize(object sender, EventArgs e)
        {
            //MessageBox.Show("El resize funciona");
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
