﻿using MaterialSkin.Controls;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProveeduriaVane
{
    public class Productos
    {
        private string connectionString = StringConexion.ConnectionString;

        public bool ExisteProducto(string codigoBarras)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(1) FROM dbo.Productos WHERE codigoBarras = @codigoBarras";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@codigoBarras", codigoBarras);
                    return (int)command.ExecuteScalar() > 0;
                }
            }
        }

        public DataTable Busqueda(string busqueda, string filtro)
        {
            if (string.IsNullOrEmpty(busqueda) || string.IsNullOrEmpty(filtro))
            {
                throw new ArgumentException("La búsqueda y el filtro no pueden estar vacíos");
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryMostrar;
                DataTable dtBusqueda = new DataTable();

                // Lista de filtros permitidos para prevenir SQL Injection
                var filtrosPermitidos = new[] { "codigoBarras", "descripcion", "marca", "tipo" };
                if (!filtrosPermitidos.Contains(filtro.ToLower()))
                {
                    throw new ArgumentException("Filtro no válido");
                }

                queryMostrar = filtro == "tipo"
                    ? @"SELECT p.codigoBarras, p.id_Tipo, tp.nombreTipo, p.descripcion, p.marca, p.precioUnitario
                       FROM Productos p
                       INNER JOIN TipoProducto tp ON p.id_Tipo = tp.idTipo
                       WHERE tp.nombreTipo LIKE @busqueda"
                    : @"SELECT p.codigoBarras, p.id_Tipo, tp.nombreTipo, p.descripcion, p.marca, p.precioUnitario
                       FROM Productos p
                       INNER JOIN TipoProducto tp ON p.id_Tipo = tp.idTipo
                       WHERE p." + filtro + " LIKE @busqueda";

                connection.Open();
                using (SqlCommand command = new SqlCommand(queryMostrar, connection))
                {
                    command.Parameters.AddWithValue("@busqueda", "%" + busqueda + "%");
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dtBusqueda);
                    }
                }

                return dtBusqueda;
            }
        }

        // Método para insertar un producto  
        public void AgregarProducto(string codigoBarras, string descripcion, string marca, decimal precioUnitario, int idTipo)
        {
            // Validaciones
            if (string.IsNullOrEmpty(codigoBarras) || string.IsNullOrEmpty(descripcion) || string.IsNullOrEmpty(marca))
            {
                throw new ArgumentException("Todos los campos son obligatorios");
            }

            if (precioUnitario <= 0)
            {
                throw new ArgumentException("El precio debe ser mayor a 0");
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    if (ExisteProducto(codigoBarras))
                    {
                        MessageBox.Show("El producto ya existe en la base de datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

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
            catch (SqlException ex)
            {
                MessageBox.Show($"Error de base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error general: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EliminarProducto(string codigoBarras)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string queryEliminar = @"DELETE FROM dbo.Productos WHERE codigoBarras = @codigoBarras";
                    using (SqlCommand command = new SqlCommand(queryEliminar, connection))
                    {
                        command.Parameters.AddWithValue("@codigoBarras", codigoBarras);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún producto con el código de barras indicado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ActualizarProducto(string codigoBarras, string descripcion, string marca, decimal precioUnitario, int idTipo)
        {
            // Validaciones
            if (string.IsNullOrEmpty(codigoBarras) || string.IsNullOrEmpty(descripcion) || string.IsNullOrEmpty(marca))
            {
                throw new ArgumentException("Todos los campos son obligatorios");
            }

            if (precioUnitario <= 0)
            {
                throw new ArgumentException("El precio debe ser mayor a 0");
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    if (!ExisteProducto(codigoBarras))
                    {
                        MessageBox.Show("El producto no existe en la base de datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string queryActualizar = @"UPDATE dbo.Productos 
                                             SET descripcion = @descripcion,
                                                 marca = @marca,
                                                 precioUnitario = @precioUnitario,
                                                 id_Tipo = @idTipo
                                             WHERE codigoBarras = @codigoBarras";

                    using (SqlCommand command = new SqlCommand(queryActualizar, connection))
                    {
                        command.Parameters.AddWithValue("@codigoBarras", codigoBarras);
                        command.Parameters.AddWithValue("@descripcion", descripcion);
                        command.Parameters.AddWithValue("@marca", marca);
                        command.Parameters.AddWithValue("@precioUnitario", precioUnitario);
                        command.Parameters.AddWithValue("@idTipo", idTipo);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error de base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error general: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AumentarDisminuirProducto(string codigoBarras, decimal nuevoPrecio)
        {
            string consulta = "UPDATE Productos SET precioUnitario = @nuevoPrecio WHERE codigoBarras = @codigoBarras";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@nuevoPrecio", nuevoPrecio);
                        comando.Parameters.AddWithValue("@codigoBarras", codigoBarras);


                        comando.ExecuteNonQuery();
                        conexion.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cambiar el precio del producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataSet ObtenerTiposProducto()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataSet dsTipos = new DataSet();
                string query = "SELECT idTipo, nombreTipo FROM TipoProducto ORDER BY nombreTipo ASC";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.Fill(dsTipos);
                }
                return dsTipos;
            }
        }

        public int ObtenerIdTipoPorNombre(string nombreTipo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT idTipo FROM TipoProducto WHERE nombreTipo = @nombreTipo";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombreTipo", nombreTipo);
                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
        }
    }
}
               