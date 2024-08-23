using System.Globalization;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;

// Cadena de conexión (reemplaza con tus datos)


namespace ProveeduriaVane
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            cbSeccion.SelectedIndexChanged += cbSeccion_SelectedIndexChanged;
            dgvMedioPago.Visible = false;
            pbMedioPago.Visible = false;
            dgvResumenFinal.Visible = false;
            pbResumenFinal.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void btnAumentarProducto_Click(object sender, EventArgs e)
        {
            mcMensajeAumento.Visible = true;
        }

        private void btnAjustarCaja_Click(object sender, EventArgs e)
        {
            mcAjusteCaja.Visible = true;
            mcDevolucion.Visible = false;
        }

        private void btnAgregarDevolucion_Click(object sender, EventArgs e)
        {
            mcDevolucion.Visible = true;
            mcAjusteCaja.Visible = false;
        }
    }
}
