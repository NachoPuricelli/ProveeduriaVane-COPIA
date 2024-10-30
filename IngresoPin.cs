using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace ProveeduriaVane
{
    public partial class IngresoPin : MaterialForm
    {
        private string conexionBase = StringConexion.ConnectionString;
        public bool PinValido { get; private set; }

        public IngresoPin()
        {
            InitializeComponent();
            PinValido = false; // Inicialmente el PIN no es válido
        }

        private void mbtnAceptar_Click(object sender, EventArgs e)
        {
            string pinIngresado = mtxtPIN.Text; // Obtener el texto ingresado por el usuario

            // Validar el PIN usando la función
            if (ValidarPin(pinIngresado, conexionBase))
            {
                PinValido = true;
                MessageBox.Show("PIN válido.");
                this.Close(); // Cerrar el formulario si el PIN es correcto
            }
            else
            {
                MessageBox.Show("PIN incorrecto.");
                mtxtPIN.Clear(); // Limpiar el TextBox si el PIN es incorrecto
                PinValido = false;
            }
        }

        static bool ValidarPin(string pinIngresado, string connectionString)
        {
            string query = "SELECT COUNT(*) FROM PIN WHERE PinCode = @PinCode";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PinCode", pinIngresado);
                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0; // Si cuenta es mayor que 0, el PIN es válido
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message); // Mostrar error si hay problemas con la conexión
                    return false;
                }
            }
        }

        private void mbtnCancelar_Click(object sender, EventArgs e)
        {
            mtxtPIN.Text = "";
            this.Close(); // Cerrar el formulario si se presiona "Cancelar"
        }

        private void IngresoPin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mbtnAceptar_Click(sender, e);
            }
        }
    }
}
