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
        }
        private void mbtnAceptar_Click(object sender, EventArgs e)
        {
            cajaInicial = decimal.Parse(mtxtCajaInicial.Text);
            this.Close();
        }
        public decimal valorCajaInicial()
        {
            return cajaInicial;
        }
    }
}
