using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace ProveeduriaVane
{
    public partial class IngresoPin : MaterialForm
    {
        private string conexionBase = StringConexion.ConnectionString;
        private VerificacionDePin verificarPin;

        public bool PinValido { get; private set; }

        public IngresoPin()
        {
            InitializeComponent();
            verificarPin = new VerificacionDePin(conexionBase);
        }

        private int intentosClaveEmergencia = 0; // Contador de intentos

        private void mbtnGestionar_Click(object sender, EventArgs e)
        {
            // Limite de intentos
            if (intentosClaveEmergencia >= 5)
            {
                MessageBox.Show("Ha alcanzado el límite de intentos para ingresar la clave de emergencia.");
                return;
            }

            // Mostrar un cuadro de diálogo para ingresar la clave de emergencia
            string claveIngresada = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese la clave de emergencia de 10 dígitos:",
                "Clave de Emergencia"
            );

            if (string.IsNullOrEmpty(claveIngresada))
            {
                MessageBox.Show("Operación cancelada.");
                return;
            }

            // Validar la clave de emergencia
            if (verificarPin.ValidarClaveEmergencia(claveIngresada))
            {
                MessageBox.Show("Clave de emergencia válida. Puede restablecer el PIN.");
                intentosClaveEmergencia = 0; // Reiniciar contador si es válida
                                             // Aquí puedes agregar la lógica para restablecer el PIN
            }
            else
            {
                intentosClaveEmergencia++;
                MessageBox.Show($"Clave incorrecta. Intentos restantes: {5 - intentosClaveEmergencia}");
            }
        }


        private void mbtnCancelar_Click(object sender, EventArgs e)
        {
            mtxtPIN.Text = "";
            this.Close();
        }

        private void mtxtPIN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mbtnAceptar_Click(sender, e);
            }
        }

        private void mbtnAceptar_Click(object sender, EventArgs e)
        {
            string pinIngresado = mtxtPIN.Text;

            if (verificarPin.ValidarPin(pinIngresado))
            {
                PinValido = true;
                MessageBox.Show("PIN válido.");
                this.Close();
            }
            else
            {
                mtxtPIN.Clear();
                PinValido = false;
            }
        }
    }
}