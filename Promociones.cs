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
        private string connectionString = "Server=PATRICIAB/patry;Database=ProveeDesk;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";

        private ComboBox tipo;
        private string descripción;
        private float precio;
        private DateTime inicioPromo;
        private DateTime finalPromo;
        private Button agregarPromocion;
        private DataGridView promocionesPromo;

        public ComboBox Tipo { get => tipo; set => tipo = value; }
        public string Descripción { get => descripción; set => descripción = value; }
        public float Precio { get => precio; set => precio = value; }
        public DateTime InicioPromo { get => inicioPromo; set => inicioPromo = value; }
        public DateTime FinalPromo { get => finalPromo; set => finalPromo = value; }
        public Button AgregarPromocion { get => agregarPromocion; set => agregarPromocion = value; }
        public DataGridView PromocionesPromo { get => promocionesPromo; set => promocionesPromo = value; }

 public DataTable AgregarPromo(string tipo, string descripcion, decimal precio, DateTime inicioPromo, DateTime finalPromo)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlTransaction transaction = connection.BeginTransaction())
            {
                    try
                    {
                        string queryPromo = @" INSERT INTO dbo.Promociones (tipo,descripcion,precioEspecial,fechaInicio,fechaFin) VALUES (@tipo,@descripcion,@precio,@inicioPromo,@finalPromo) ";
                        SqlDataAdapter adapter = new SqlDataAdapter(queryPromo, connection);
                        SqlCommand command = new SqlCommand(queryPromo, connection, transaction);
                        command.Parameters.AddWithValue("@tipo", tipo);
                        command.Parameters.AddWithValue("@descripcion", descripción);
                        command.Parameters.AddWithValue("@precioEspecial", precio);
                        command.Parameters.AddWithValue("@fechaInicio", inicioPromo);
                        command.Parameters.AddWithValue("@fechaFin", finalPromo);

                        DataTable dtPromo = new DataTable();
                        adapter.Fill(dtPromo);
                        transaction.Commit();
                        return dtPromo;
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
        }

    }
        public DataTable MostrarPromo()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string queryMostrar = @"SELECT tipo,descripcion,precioEspecial,fechaInicio,fechaFin FROM Promociones WHERE fechaInicio = @inicioPromo";
                        SqlDataAdapter adapter = new SqlDataAdapter(queryMostrar, connection);
                        SqlCommand command = new SqlCommand(queryMostrar, connection, transaction);
                        DataTable dtPromo = new DataTable();
                        adapter.Fill(dtPromo);
                        transaction.Commit();
                        return dtPromo;
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }

        }

    }
   
}
