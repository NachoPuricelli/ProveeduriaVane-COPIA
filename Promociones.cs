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
            // Validación básica
            if (productosSeleccionados == null || productosSeleccionados.Count == 0)
            {
                throw new ArgumentException("Se debe seleccionar al menos un producto para la promoción.");
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Paso 1: Insertar en la tabla Promociones
                    int idPromo;
                    string insertPromoQuery = @"
            INSERT INTO Promociones (tipoPromo, descripcion, fechaInicio, fechaFin)
            VALUES (@tipoPromo, @descripcion, @fechaInicio, @fechaFin);
            SELECT SCOPE_IDENTITY();";

                    using (SqlCommand cmd = new SqlCommand(insertPromoQuery, connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@tipoPromo", tipoPromo);
                        cmd.Parameters.AddWithValue("@descripcion", descripcion);
                        cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@fechaFin", fechaFin);

                        // Obtener el ID de la promoción recién insertada
                        idPromo = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Paso 2: Insertar en la tabla Promocion_Productos con cantidades específicas para cada tipo
                    string insertPromocionProductoQuery = @"
            INSERT INTO Promocion_Productos (idPromo, idProducto, precioEspecial, cantidad)
            VALUES (@idPromo, @idProducto, @precioEspecial, @cantidad);";

                    foreach (int idProducto in productosSeleccionados)
                    {
                        using (SqlCommand cmd = new SqlCommand(insertPromocionProductoQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@idPromo", idPromo);
                            cmd.Parameters.AddWithValue("@idProducto", idProducto);

                            // Asignar precioEspecial solo si el tipo de promoción es COMBO o DESCUENTO
                            if (tipoPromo == "COMBO" || tipoPromo == "DESCUENTO")
                            {
                                cmd.Parameters.AddWithValue("@precioEspecial", precioEspecial);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@precioEspecial", precioEspecial);
                            }

                            // Configurar cantidad según el tipo de promoción
                            int cantidad;
                            switch (tipoPromo)
                            {
                                case "2X1":
                                    cantidad = 2; // Dos productos en promoción, pagando uno
                                    break;
                                case "3X2":
                                    cantidad = 3; // Tres productos en promoción, pagando dos
                                    break;
                                case "3X1":
                                    cantidad = 3; // Tres productos en promoción, pagando uno
                                    break;
                                case "COMBO":
                                case "DESCUENTO":
                                    cantidad = 1; // Solo uno para COMBO o DESCUENTO
                                    break;
                                default:
                                    throw new ArgumentException("Tipo de promoción no reconocido");
                            }

                            cmd.Parameters.AddWithValue("@cantidad", cantidad);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Confirmar transacción
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // Revertir transacción en caso de error
                    transaction.Rollback();
                    throw new Exception("Error al agregar la promoción: " + ex.Message);
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
                                       pp.precioEspecial AS 'PRECIO', p.fechaInicio AS 'INICIO', 
                                       p.fechaFin AS 'FIN', 
                                       STRING_AGG(pr.descripcion, ', ') AS 'PRODUCTOS ASOCIADOS'
                                FROM Promociones p
                                JOIN Promocion_Productos pp ON p.idPromo = pp.idPromo
                                JOIN Productos pr ON pp.idProducto = pr.idProducto
                                GROUP BY p.tipoPromo, p.descripcion, pp.precioEspecial, p.fechaInicio, p.fechaFin";

                SqlDataAdapter adapter = new SqlDataAdapter(queryMostrar, connection);
                DataTable dtPromo = new DataTable();
                adapter.Fill(dtPromo);
                connection.Close();
                return dtPromo;
            }
        }
    }
}
