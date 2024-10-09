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
        private string connectionString = "Server=PATRICIAB;Database=ProveeDesk;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";

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

    }
}
