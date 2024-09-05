using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProveeDesk
{
    internal class ProcesarCodigoVentas
    {
        private string connectionString;
        private DataTable dataTable;
        private StringBuilder codigoBarraBuilder = new StringBuilder();
        private System.Windows.Forms.Timer timer;
        private const int tiempoMaximoEntreCaracteres = 100;
        private const int longitudEsperadaCodigo = 13;

        public ProcesarCodigoVentas(string connectionString, DataTable dataTable)
        {
            this.connectionString = connectionString;
            this.dataTable = dataTable;
            this.timer = new System.Windows.Forms.Timer();
            this.timer.Interval = tiempoMaximoEntreCaracteres;
            this.timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ProcesarCodigoBarraFinalizado();
        }

        public void AgregarCaracter(char caracter)
        {
            codigoBarraBuilder.Append(caracter);
            timer.Stop();
            timer.Start();
        }

        public void ProcesarCodigoBarraFinalizado()
        {
            timer.Stop();
            string codigoBarra = codigoBarraBuilder.ToString();

            Procesar(codigoBarra);
            codigoBarraBuilder.Clear();
        }

        public StringBuilder CodigoBarraBuilder
        {
            get { return codigoBarraBuilder; }
        }

        // Método para procesar el código de barras
        public void Procesar(string codigoBarra)
        {
            if (string.IsNullOrEmpty(codigoBarra))
            {
                MessageBox.Show("El código de barras no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string consulta = "SELECT codigoBarras, descripcion, marca, precioUnitario FROM Productos WHERE codigoBarras = @codigoBarra";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand comando = new SqlCommand(consulta, connection))
                {
                    comando.Parameters.AddWithValue("@codigoBarra", codigoBarra);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
                    DataTable productoDataTable = new DataTable();

                    try
                    {
                        connection.Open();
                        dataAdapter.Fill(productoDataTable);

                        // Verificar y agregar productos al DataGridView
                        if (productoDataTable.Rows.Count > 0)
                        {
                            StringBuilder mensaje = new StringBuilder();

                            foreach (DataRow row in productoDataTable.Rows)
                            {
                                DataRow[] existingRows = dataTable.Select($"CÓDIGO = '{row["codigoBarras"]}'");
                                if (existingRows.Length == 0)
                                {
                                    DataRow newRow = dataTable.NewRow();
                                    newRow["CÓDIGO"] = row["codigoBarras"];
                                    newRow["DESCRIPCIÓN"] = row["descripcion"];
                                    newRow["MARCA"] = row["marca"];
                                    newRow["CANTIDAD"] = "1";
                                    newRow["PRECIO UNITARIO"] = row["precioUnitario"];
                                    dataTable.Rows.Add(newRow);
                                }
                            }

                            if (mensaje.Length > 0)
                            {
                                MessageBox.Show(mensaje.ToString(), "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al procesar el código de barras: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}




