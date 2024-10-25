using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProveeduriaVane
{
    public class Promociones
    {
        private string connectionString = StringConexion.ConnectionString;

        public void AgregarPromo(string tipoPromo, string descripcion, decimal precioEspecial, DateTime fechaInicio, DateTime fechaFin, List<int> productosSeleccionados)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction(); // Iniciar transacción

                try
                {
                    // Insertar promoción en la tabla Promociones
                    string queryPromo = @"INSERT INTO dbo.Promociones (descripcion, tipoPromo, precioEspecial, fechaInicio, fechaFin)
                                  VALUES (@descripcion, @tipoPromo, @precioEspecial, @fechaInicio, @fechaFin);
                                  SELECT SCOPE_IDENTITY();";  // Obtener el ID generado (idPromo)
                    SqlCommand commandPromo = new SqlCommand(queryPromo, connection, transaction);
                    commandPromo.Parameters.AddWithValue("@descripcion", descripcion);
                    commandPromo.Parameters.AddWithValue("@tipoPromo", tipoPromo);
                    commandPromo.Parameters.AddWithValue("@precioEspecial", precioEspecial);
                    commandPromo.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                    commandPromo.Parameters.AddWithValue("@fechaFin", fechaFin);

                    int idPromo = Convert.ToInt32(commandPromo.ExecuteScalar());  // Obtener el idPromo generado

                    // Insertar productos en la tabla Promocion_Productos
                    foreach (int idProducto in productosSeleccionados)
                    {
                        string queryPromoProducto = @"INSERT INTO dbo.Promocion_Productos (idPromo, idProducto)
                                              VALUES (@idPromo, @idProducto)";
                        SqlCommand commandProducto = new SqlCommand(queryPromoProducto, connection, transaction);
                        commandProducto.Parameters.AddWithValue("@idPromo", idPromo);
                        commandProducto.Parameters.AddWithValue("@idProducto", idProducto);
                        commandProducto.ExecuteNonQuery();
                    }

                    transaction.Commit(); // Confirmar transacción
                }
                catch (Exception)
                {
                    transaction.Rollback(); // Revertir en caso de error
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
        }


        public DataTable MostrarPromo()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Consulta con JOIN para mostrar promociones y productos asociados
                string queryMostrar = @"SELECT p.tipoPromo AS 'TIPO', p.descripcion AS 'DESCRIPCIÓN', 
                                       p.precioEspecial AS 'PRECIO ESPECIAL', p.fechaInicio AS 'FECHA INICIO', 
                                       p.fechaFin AS 'FECHA FIN', 
                                       STRING_AGG(pr.descripcion, ', ') AS 'PRODUCTOS ASOCIADOS'
                                FROM Promociones p
                                JOIN Promocion_Productos pp ON p.idPromo = pp.idPromo
                                JOIN Productos pr ON pp.idProducto = pr.idProducto
                                GROUP BY p.tipoPromo, p.descripcion, p.precioEspecial, p.fechaInicio, p.fechaFin";

                SqlDataAdapter adapter = new SqlDataAdapter(queryMostrar, connection);
                DataTable dtPromo = new DataTable();
                adapter.Fill(dtPromo);
                connection.Close();
                return dtPromo;
            }
        }

        public DataTable ElegirPromo()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string queryMostrar = @"SELECT tipoPromo,descripcion ,precioEspecial FROM Promociones";
                SqlDataAdapter adapter = new SqlDataAdapter(queryMostrar, connection);
                SqlCommand command = new SqlCommand(queryMostrar, connection);
                command.ExecuteNonQuery();
                DataTable dtPromo = new DataTable();
                adapter.Fill(dtPromo);
                connection.Close();
                return dtPromo;
            }
        }

    }
   
}
