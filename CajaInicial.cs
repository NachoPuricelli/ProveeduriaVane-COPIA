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
    public partial class CajaInicial : MaterialForm
    {
        public decimal cajaInicial;
        public CajaInicial()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        private void mbtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                cajaInicial = decimal.Parse(mtxtCajaInicial.Text);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Por favor, ingrese un valor para continuar");
            }
        }
        public decimal valorCajaInicial()
        {
            return cajaInicial;
        }

        private void CajaInicial_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                mbtnAceptar_Click(sender, e);
            }
        }
    }
}
