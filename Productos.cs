using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProveeduriaVane
{
    public class Productos
    {
        private string connectionString = "Server=Elias_Cano;Database=ProveeDesk;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";

        public DataTable Busqueda(string busqueda, string filtro)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryMostrar = "";
                DataTable dtBusqueda = new DataTable();

                // Consulta cuando el filtro es "tipo"
                if (filtro == "tipo")
                {
                    queryMostrar = @"SELECT p.codigoBarras, p.id_Tipo, tp.nombreTipo, p.descripcion, p.marca, p.precioUnitario
                     FROM Productos p
                     INNER JOIN TipoProducto tp ON p.id_Tipo = tp.idTipo
                     WHERE tp.nombreTipo LIKE @busqueda";
                }
                else
                {
                    queryMostrar = @"SELECT p.codigoBarras, p.id_Tipo, tp.nombreTipo, p.descripcion, p.marca, p.precioUnitario
                     FROM Productos p
                     INNER JOIN TipoProducto tp ON p.id_Tipo = tp.idTipo
                     WHERE p." + filtro + " LIKE @busqueda";
                }

                connection.Open();

                using (SqlCommand command = new SqlCommand(queryMostrar, connection))
                {
                    command.Parameters.AddWithValue("@busqueda", "%" + busqueda + "%");
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dtBusqueda); // Llenar el DataTable con los resultados
                    }
                }

                connection.Close();
                return dtBusqueda;
            }
        }

        // Método para insertar un producto  
        public void AgregarProducto(string codigoBarras, string descripcion, string marca, decimal precioUnitario, int idTipo)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Verificar si el código de barras ya existe
                    string queryVerificar = @"SELECT COUNT(1) FROM dbo.Productos WHERE codigoBarras = @codigoBarras";
                    using (SqlCommand verificarCommand = new SqlCommand(queryVerificar, connection))
                    {
                        verificarCommand.Parameters.AddWithValue("@codigoBarras", codigoBarras);
                        int count = (int)verificarCommand.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("El producto ya existe en la base de datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; 
                        }
                    }

                    // Insertar el nuevo producto
                    string queryInsertar = @"INSERT INTO dbo.Productos (codigoBarras, descripcion, marca, precioUnitario, id_Tipo)
                                     VALUES (@codigoBarras, @descripcion, @marca, @precioUnitario, @idTipo)";
                    using (SqlCommand command = new SqlCommand(queryInsertar, connection))
                    {
                        command.Parameters.AddWithValue("@codigoBarras", codigoBarras);
                        command.Parameters.AddWithValue("@descripcion", descripcion);
                        command.Parameters.AddWithValue("@marca", marca);
                        command.Parameters.AddWithValue("@precioUnitario", precioUnitario);
                        command.Parameters.AddWithValue("@idTipo", idTipo);

                        command.ExecuteNonQuery();

                        MessageBox.Show("¡Producto agregado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al agregar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
               