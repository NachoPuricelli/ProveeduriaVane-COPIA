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

         public void AgregarPromo(string tipoPromo, string descripcion, decimal precioEspecial, DateTime fechaInicio, DateTime fechaFin)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryPromo = @"INSERT INTO dbo.Promociones (descripcion, tipoPromo, precioEspecial,fechaInicio,fechaFin)
                VALUES (@descripcion, @tipoPromo, @precioEspecial,@fechaInicio,@fechaFin)";

                SqlDataAdapter adapter = new SqlDataAdapter(queryPromo, connection);
                SqlCommand command = new SqlCommand(queryPromo, connection);
                command.Parameters.AddWithValue("@descripcion", descripcion);
                command.Parameters.AddWithValue("@tipoPromo", tipoPromo);
                command.Parameters.AddWithValue("@precioEspecial", precioEspecial);
                command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                command.Parameters.AddWithValue("@fechaFin", fechaFin);
                command.ExecuteNonQuery();
                connection.Close();
            }

        }

        public DataTable MostrarPromo()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string queryMostrar = @"SELECT tipoPromo AS 'TIPO',descripcion AS 'DESCRIPCIÓN',precioEspecial AS 'PRECIO ESPECIAL',fechaInicio AS 'FECHA INICIO',fechaFin AS 'FECHA FIN' FROM Promociones";
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
