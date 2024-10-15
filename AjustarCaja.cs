using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ProveeduriaVane
{
    public partial class AjustarCaja : MaterialForm
    {
        private string connectionString = StringConexion.ConnectionString;
        private DateTime fecha = DateTime.Now;
        public AjustarCaja()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue100, Accent.Pink700, TextShade.WHITE);
        }

        private void mbtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Definir si se ingresa o saca dinero de la caja
        private void insertarEnDatabase()
        {
            string motivo = mtxtMotivo.Text;
            int monto = Convert.ToInt32(mtxtMonto.Text);

            if (mrbResta.Checked)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string queryEgreso = @"insert into dbo.Egresos (fecha, monto, descripcion) values (@fecha, @monto, @descripcion)";
                    using (SqlCommand insertarDatos = new SqlCommand(queryEgreso, connection))
                    {
                        insertarDatos.Parameters.AddWithValue("@fecha", fecha);
                        insertarDatos.Parameters.AddWithValue("@monto", monto);
                        insertarDatos.Parameters.AddWithValue("@descripcion", motivo);
                        insertarDatos.ExecuteNonQuery();
                    }
                    connection.Close();
                }

                MessageBox.Show("¡El egreso se guardó correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (mrbSuma.Checked)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string queryIngreso = @"insert into dbo.Ingresos (fecha, monto, descripcion) values (@fecha, @monto, @descripcion)";
                    using (SqlCommand insertarDatos = new SqlCommand(queryIngreso, connection))
                    {
                        insertarDatos.Parameters.AddWithValue("@fecha", fecha);
                        insertarDatos.Parameters.AddWithValue("@monto", monto);
                        insertarDatos.Parameters.AddWithValue("@descripcion", motivo);
                        insertarDatos.ExecuteNonQuery();
                    }
                    connection.Close();
                }

                MessageBox.Show("¡El ingreso se guardó correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Limpiar controles
                mtxtMonto.Text = "";
                mtxtMotivo.Text = "";
                mrbResta.Checked = false;
                mrbSuma.Checked = false;
            }
        }

        private void mbtnAceptar_Click(object sender, EventArgs e)
        {
            insertarEnDatabase();
        }
    }
}
