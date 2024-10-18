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
    public partial class AumentoProducto : MaterialForm
    {
        public decimal porcentaje = 0.0m;
        public bool aumentar = true; // Bandera para saber si es aumento o disminución
        public bool disminuir = true;

        public AumentoProducto()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue100, Accent.Pink700, TextShade.WHITE);
        }

        private void mbtnAceptar_Click(object sender, EventArgs e)
        {
            // Verifica si el valor ingresado es un número decimal válido
            if (decimal.TryParse(mtxtPorcentaje.Text, out decimal porcentajeAumento))
            {
                porcentaje = porcentajeAumento;

                // Verifica si está seleccionado Aumentar o Disminuir
                if (rbAumentar.Checked)
                {
                    DialogResult = DialogResult.OK; // Señala que es un aumento
                }
                else if (rbDisminuir.Checked)
                {
                    porcentaje = -porcentaje; // Invierte el valor para representar una disminución
                    DialogResult = DialogResult.OK; // Señala que es una disminución
                }
                else
                {
                    MessageBox.Show("Por favor selecciona si deseas aumentar o disminuir el precio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor ingresa un valor válido para el porcentaje.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void mbtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
