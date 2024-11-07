using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProveeduriaVane
{
    internal class VerificacionDePin
    {
        private int intentosPin;
        private int intentosClaveEmergencia;
        private readonly string connectionString;

        public VerificacionDePin(string connectionString)
        {
            this.connectionString = connectionString;
            intentosPin = 5;
            intentosClaveEmergencia = 5;
        }

        public bool ValidarPin(string pinIngresado)
        {
            if (intentosPin <= 0)
            {
                MessageBox.Show("Límite de intentos de PIN alcanzado.");
                return false;
            }

            string query = "SELECT COUNT(*) FROM PIN WHERE PinCode = @PinCode";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PinCode", pinIngresado);

                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        intentosPin = 5; // Reiniciar intentos si el PIN es correcto
                        return true;
                    }
                    else
                    {
                        intentosPin--; // Reducir intentos si el PIN es incorrecto
                        MessageBox.Show($"PIN incorrecto. Intentos restantes: {intentosPin}");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public bool ValidarClaveEmergencia(string claveIngresada)
        {
            if (intentosClaveEmergencia <= 0)
            {
                MessageBox.Show("Límite de intentos de claves de emergencia alcanzado.");
                return false;
            }

            string query = "SELECT COUNT(*) FROM ClavesEmergencia WHERE clave = @Clave AND usada = 0";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Clave", claveIngresada);

                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        // Marcar la clave como usada
                        MarcarClaveComoUsada(claveIngresada, connection);
                        intentosClaveEmergencia = 5; // Reiniciar intentos si la clave es correcta
                        return true;
                    }
                    else
                    {
                        intentosClaveEmergencia--; // Reducir intentos si la clave es incorrecta
                        MessageBox.Show($"Clave de emergencia incorrecta. Intentos restantes: {intentosClaveEmergencia}");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        private void MarcarClaveComoUsada(string clave, SqlConnection connection)
        {
            string updateQuery = "UPDATE ClavesEmergencia SET usada = 1 WHERE clave = @Clave";
            SqlCommand command = new SqlCommand(updateQuery, connection);
            command.Parameters.AddWithValue("@Clave", clave);
            command.ExecuteNonQuery();
        }
    }
}



