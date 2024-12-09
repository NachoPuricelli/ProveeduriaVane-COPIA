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

                        idPromo = Convert.ToInt32(cmd.ExecuteScalar());
                    }

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
                    transaction.Commit();
                }
                catch (Exception ex)
                {
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
                // Mantenemos el ID en la consulta pero no lo mostramos como 'ID'
                string queryMostrar = @"SELECT p.idPromo, p.tipoPromo AS 'TIPO', p.descripcion AS 'DESCRIPCIÓN', 
                pp.precioEspecial AS 'PRECIO', p.fechaInicio AS 'INICIO', 
                p.fechaFin AS 'FIN', 
                STRING_AGG(pr.descripcion, ', ') AS 'PRODUCTOS ASOCIADOS'
                FROM Promociones p
                JOIN Promocion_Productos pp ON p.idPromo = pp.idPromo
                JOIN Productos pr ON pp.idProducto = pr.idProducto
                GROUP BY p.idPromo, p.tipoPromo, p.descripcion, pp.precioEspecial, p.fechaInicio, p.fechaFin";

                SqlDataAdapter adapter = new SqlDataAdapter(queryMostrar, connection);
                DataTable dtPromo = new DataTable();
                adapter.Fill(dtPromo);
                return dtPromo;
            }
        }
        public void ConfigurarDataGridView(DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();
            dataGridView.DataSource = null;

            // Establecemos el nuevo origen de datos
            DataTable dtPromo = MostrarPromo();
            dataGridView.DataSource = dtPromo;

            // Ocultar la columna del ID
            dataGridView.Columns["idPromo"].Visible = false;

            // Configurar la columna de eliminación
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn
            {
                Name = "ELIMINAR",
                HeaderText = "",
                Text = "🗑️",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Popup,
            };

            // Insertar la columna de botones al inicio
            dataGridView.Columns.Insert(0, btnEliminar);

            // Configurar el aspecto del DataGridView
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ReadOnly = true;

            // Asegurarse de que solo agregamos el evento una vez
            dataGridView.CellContentClick -= DataGridView_CellContentClick;
            dataGridView.CellContentClick += DataGridView_CellContentClick;

            // Colorear filas en función de la fecha y hora
            DateTime ahora = DateTime.Now;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                DateTime fechaInicio = Convert.ToDateTime(row.Cells["INICIO"].Value);
                DateTime fechaFin = Convert.ToDateTime(row.Cells["FIN"].Value);
                TimeSpan tiempoHastaFin = fechaFin - ahora;

                // Rojo para promociones que ya han vencido
                if (fechaFin < ahora)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193); // Rojo claro
                }
                // Naranja para promociones que están en sus últimas 4 horas
                else if (tiempoHastaFin.TotalHours <= 4)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 223, 186); // Naranja claro
                }
                // Verde desde su creación hasta las últimas 4 horas
                else
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(144, 238, 144); // Verde claro
                }
            }
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridView = (DataGridView)sender;

            // Verificar si el click fue en la columna de eliminar
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                if (MessageBox.Show("¿Está seguro de eliminar esta promoción?", "Confirmar eliminación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Obtener el ID de la promoción a eliminar de la columna oculta
                    int idPromo = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["idPromo"].Value);

                    if (EliminarPromocion(idPromo))
                    {
                        ActualizarDataGridView(dataGridView);
                    }
                }
            }
        }

        public void ActualizarDataGridView(DataGridView dataGridView)
        {
            int selectedRow = dataGridView.CurrentRow?.Index ?? -1;
            ConfigurarDataGridView(dataGridView);
            if (selectedRow >= 0 && selectedRow < dataGridView.Rows.Count)
            {
                dataGridView.CurrentCell = dataGridView.Rows[selectedRow].Cells[0];
            }
        }

        private bool EliminarPromocion(int idPromo)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Primero eliminar registros en Promocion_Productos
                            string deletePromoProductos = "DELETE FROM Promocion_Productos WHERE idPromo = @idPromo";
                            using (SqlCommand cmd = new SqlCommand(deletePromoProductos, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@idPromo", idPromo);
                                cmd.ExecuteNonQuery();
                            }

                            // Luego eliminar la promoción
                            string deletePromocion = "DELETE FROM Promociones WHERE idPromo = @idPromo";
                            using (SqlCommand cmd = new SqlCommand(deletePromocion, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@idPromo", idPromo);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            return true;
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la promoción: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
