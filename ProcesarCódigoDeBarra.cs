using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ProveeduriaVane
{
    internal class ProcesarCodigoDeBarra
    {
        private string connectionString;
        private DataTable dataTable;

        public ProcesarCodigoDeBarra(string connectionString, DataTable dataTable)
        {
            this.connectionString = connectionString;
            this.dataTable = dataTable;
        }

        //Método para procesar el código de barras
        public void Procesar(string codigoBarra)
        {
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

                        // Mostrar la cantidad de filas recuperadas para depuración
                        MessageBox.Show($"Filas recuperadas: {productoDataTable.Rows.Count}", "Depuración", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Verificar y agregar productos al DataGridView
                        if (productoDataTable.Rows.Count > 0)
                        {
                            foreach (DataRow row in productoDataTable.Rows)
                            {
                                bool existe = false;
                                foreach (DataRow existingRow in dataTable.Rows)
                                {
                                    if (existingRow["CÓDIGO"].ToString() == row["codigoBarras"].ToString())
                                    {
                                        existe = true;
                                        break;
                                    }
                                }

                                if (!existe)
                                {
                                    DataRow newRow = dataTable.NewRow();
                                    newRow["CÓDIGO"] = row["codigoBarras"];
                                    newRow["DESCRIPCIÓN"] = row["descripcion"]; // Coincide con el nombre en el DataTable
                                    newRow["MARCA"] = row["marca"];
                                    newRow["CANTIDAD"] = "1"; // O el valor que corresponda
                                    newRow["PRECIO UNITARIO"] = row["precioUnitario"];
                                    dataTable.Rows.Add(newRow);
                                }
                            }

                            MessageBox.Show("Producto añadido correctamente al DataGridView.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

