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
                connection.Open();
                string queryMostrar = "SELECT * FROM Productos WHERE " + filtro + " LIKE '%" + busqueda + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(queryMostrar, connection);
                SqlCommand command = new SqlCommand(queryMostrar, connection);
                command.ExecuteNonQuery();
                DataTable dtBusqueda = new DataTable();
                adapter.Fill(dtBusqueda);
                connection.Close();
                return dtBusqueda;
            }
        }

    }
}
