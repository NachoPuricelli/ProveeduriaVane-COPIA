﻿using System;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using ProveeduriaVane;

namespace ProveeDesk
{
    internal class ProcesarCodigoVentas
    {
        private string connectionString;
        private DataTable dataTable;
        private StringBuilder codigoBarraBuilder = new StringBuilder();
        private System.Windows.Forms.Timer timer;
        private const int tiempoMaximoEntreCaracteres = 100;
        private Form2 formularioPrincipal;
        private bool modoDevolucion;
        private bool modoDisminuir;

        public ProcesarCodigoVentas(string connectionString, DataTable dataTable, Form2 formularioPrincipal)
        {
            this.connectionString = connectionString;
            this.dataTable = dataTable;
            this.formularioPrincipal = formularioPrincipal;
            this.timer = new System.Windows.Forms.Timer();
            this.timer.Interval = tiempoMaximoEntreCaracteres;
            this.timer.Tick += Timer_Tick;
            this.modoDevolucion = false;
            this.modoDisminuir = false;
            this.codigoBarraBuilder = new StringBuilder();
        }

        public bool ModoDevolucion
        {
            get { return modoDevolucion; }
            set
            {
                modoDevolucion = value;
                Debug.WriteLine($"Modo devolución cambiado a: {value}");
            }
        }

        public bool ModoDisminuir
        {
            get { return modoDisminuir; }
            set { modoDisminuir = value; }
        }

        public class PromocionInfo
        {
            public string TipoPromo { get; set; }
            public decimal PrecioEspecial { get; set; }
            public int CantidadPromocion { get; set; }
            public string Descripcion { get; set; }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ProcesarCodigoBarraFinalizado();
        }

        public void AgregarCaracter(char caracter)
        {
            codigoBarraBuilder.Append(caracter);
            timer.Stop();
            timer.Start();
        }

        public void ProcesarCodigoBarraFinalizado()
        {
            timer.Stop();
            string codigoBarra = codigoBarraBuilder.ToString();

            try
            {
                if (string.IsNullOrEmpty(codigoBarra))
                    return;

                Debug.WriteLine($"Procesando código: {codigoBarra}, Modo devolución: {modoDevolucion}");

                if (modoDevolucion)
                {
                    ProcesarDevolucion(codigoBarra);
                }
                else
                {
                    Procesar(codigoBarra);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar el código: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                codigoBarraBuilder.Clear();
            }
        }

        public StringBuilder CodigoBarraBuilder
        {
            get { return codigoBarraBuilder; }
        }

        private async Task<PromocionInfo> VerificarPromociones(string codigoBarra)
        {
            DateTime fechaActual = DateTime.Now;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                string consultaPromociones = @"
                SELECT TOP 1
                    P.tipoPromo, 
                    P.descripcion,
                    PP.precioEspecial, 
                    PP.cantidad as cantidadPromocion
                FROM Promocion_Productos PP
                JOIN Promociones P ON PP.idPromo = P.idPromo
                JOIN Productos Prod ON PP.idProducto = Prod.idProducto
                WHERE Prod.codigoBarras = @codigoBarra
                AND P.fechaInicio <= @fechaActual 
                AND P.fechaFin >= @fechaActual;";

                using (SqlCommand command = new SqlCommand(consultaPromociones, connection))
                {
                    command.Parameters.AddWithValue("@codigoBarra", codigoBarra);
                    command.Parameters.AddWithValue("@fechaActual", fechaActual);

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            return new PromocionInfo
                            {
                                TipoPromo = reader["tipoPromo"].ToString(),
                                Descripcion = reader["descripcion"].ToString(),
                                PrecioEspecial = reader.IsDBNull(reader.GetOrdinal("precioEspecial"))
                                    ? 0m : reader.GetDecimal(reader.GetOrdinal("precioEspecial")),
                                CantidadPromocion = reader.GetInt32(reader.GetOrdinal("cantidadPromocion"))
                            };
                        }
                    }
                }
            }

            return null;
        }

        // Método para procesar el código de barras
        public async void Procesar(string codigoBarra)
        {
            if (string.IsNullOrEmpty(codigoBarra))
            {
                MessageBox.Show("El código de barras no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Verificar si el código es una promoción (combo) o un producto individual
                var promocion = await VerificarPromociones(codigoBarra);
                bool aplicarPromocion = false;

                if (promocion != null && promocion.TipoPromo == "COMBO")
                {
                    // Si es un combo, mostrar mensaje y agregar solo el combo sin los productos individuales
                    string mensaje = $"Se ha encontrado un combo:\n\n{promocion.Descripcion}\n\nPrecio especial: ${promocion.PrecioEspecial}\n\n¿Desea agregar este combo?";
                    var result = MessageBox.Show(mensaje, "Combo Disponible", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    aplicarPromocion = (result == DialogResult.Yes);

                    if (aplicarPromocion)
                    {
                        // Agregar solo el combo al `DataGridView`
                        AgregarCombo(promocion);
                        return; // Evitar procesamiento adicional para productos individuales
                    }
                }

                // Si no es un combo, procesar como producto individual
                string consulta = "SELECT codigoBarras, descripcion, marca, precioUnitario FROM Productos WHERE codigoBarras = @codigoBarra";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand comando = new SqlCommand(consulta, connection))
                    {
                        comando.Parameters.AddWithValue("@codigoBarra", codigoBarra);
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
                        DataTable productoDataTable = new DataTable();

                        connection.Open();
                        dataAdapter.Fill(productoDataTable);

                        if (productoDataTable.Rows.Count > 0)
                        {
                            foreach (DataRow row in productoDataTable.Rows)
                            {
                                DataRow[] existingRows = dataTable.Select($"CÓDIGO = '{row["codigoBarras"]}'");

                                if (existingRows.Length > 0 && !aplicarPromocion)
                                {
                                    // Actualizar producto existente
                                    ActualizarProductoExistente(existingRows[0], row);
                                }
                                else
                                {
                                    // Agregar nuevo producto si no es promoción de combo
                                    AgregarNuevoProducto(row, promocion, aplicarPromocion);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar el código de barras: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            formularioPrincipal.CalcularTotalVenta();
        }

        // Método para agregar solo el combo al DataTable
        private void AgregarCombo(PromocionInfo promocion)
        {
            DataRow nuevaFila = dataTable.NewRow();
            nuevaFila["CÓDIGO"] = "";
            nuevaFila["DESCRIPCIÓN"] = promocion.Descripcion;
            nuevaFila["CANTIDAD"] = promocion.CantidadPromocion;
            nuevaFila["PRECIO UNITARIO"] = promocion.PrecioEspecial;
            nuevaFila["PRECIO TOTAL"] = promocion.PrecioEspecial * promocion.CantidadPromocion;
            dataTable.Rows.Add(nuevaFila);
        }


        private async Task ProcesarDevolucion(string codigoBarra)
        {
            try
            {
                // Primero verificamos si el producto existe
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    string consulta = "SELECT codigoBarras, descripcion, marca, precioUnitario FROM Productos WHERE codigoBarras = @codigoBarra";

                    using (SqlCommand comando = new SqlCommand(consulta, connection))
                    {
                        comando.Parameters.AddWithValue("@codigoBarra", codigoBarra);
                        using (var reader = await comando.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                string mensaje = $"¿Confirma la devolución del siguiente producto?\n\n" +
                                               $"Descripción: {reader["descripcion"]}\n" +
                                               $"Marca: {reader["marca"]}\n" +
                                               $"Precio: ${reader.GetDecimal(reader.GetOrdinal("precioUnitario"))}";

                                var result = MessageBox.Show(mensaje, "Confirmar Devolución",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                if (result == DialogResult.Yes)
                                {
                                    // Procesar la devolución
                                    await RegistrarDevolucion(
                                        reader["codigoBarras"].ToString(),
                                        reader.GetDecimal(reader.GetOrdinal("precioUnitario")));

                                    MessageBox.Show("Devolución procesada exitosamente", "Éxito",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                              
                                    formularioPrincipal.CalcularTotalVenta();
                                    formularioPrincipal.reiniciarDgvVentas();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Producto no encontrado", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar la devolución: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task RegistrarDevolucion(string codigoBarra, decimal precioUnitario)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Registrar la venta negativa
                        string insertVenta = @"
                        INSERT INTO Ventas (fecha, medioPago, montoFinal)
                        VALUES (@fecha, @medioPago, @montoFinal);
                        SELECT SCOPE_IDENTITY();";

                        using (SqlCommand cmd = new SqlCommand(insertVenta, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                            cmd.Parameters.AddWithValue("@medioPago", "DEVOLUCION");
                            cmd.Parameters.AddWithValue("@montoFinal", -precioUnitario);

                            decimal idVenta = Convert.ToDecimal(await cmd.ExecuteScalarAsync());

                            // Registrar el detalle de la devolución
                            string insertDetalle = @"
                            INSERT INTO Detalle_Ventas (id_Venta, codigoBarra, cantidad, precio_Unitario)
                            VALUES (@idVenta, @codigoBarra, @cantidad, @precioUnitario)";

                            using (SqlCommand cmdDetalle = new SqlCommand(insertDetalle, connection, transaction))
                            {
                                cmdDetalle.Parameters.AddWithValue("@idVenta", idVenta);
                                cmdDetalle.Parameters.AddWithValue("@codigoBarra", codigoBarra);
                                cmdDetalle.Parameters.AddWithValue("@cantidad", -1);
                                cmdDetalle.Parameters.AddWithValue("@precioUnitario", precioUnitario);

                                await cmdDetalle.ExecuteNonQueryAsync();
                            }
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        private void ActualizarProductoExistente(DataRow existingRow, DataRow productRow)
        {
            int cantidadActual = Convert.ToInt32(existingRow["CANTIDAD"]);
            decimal precioUnitario = Convert.ToDecimal(existingRow["PRECIO UNITARIO"]);

            if (modoDisminuir)
            {
                if (cantidadActual > 1)
                {
                    cantidadActual--;
                    existingRow["CANTIDAD"] = cantidadActual;
                    existingRow["PRECIO TOTAL"] = cantidadActual * precioUnitario;
                }
                else
                {
                    dataTable.Rows.Remove(existingRow);
                }
            }
            else
            {
                cantidadActual++;
                existingRow["CANTIDAD"] = cantidadActual;
                existingRow["PRECIO TOTAL"] = cantidadActual * precioUnitario;
            }
        }

        private void AgregarNuevoProducto(DataRow productRow, PromocionInfo promocion, bool aplicarPromocion)
        {
            DataRow newRow = dataTable.NewRow();
            newRow["CÓDIGO"] = productRow["codigoBarras"];
            newRow["DESCRIPCIÓN"] = productRow["descripcion"];
            newRow["MARCA"] = productRow["marca"];

            decimal precioUnitarioOriginal = Convert.ToDecimal(productRow["precioUnitario"]);

            if (aplicarPromocion && promocion != null)
            {
                switch (promocion.TipoPromo)
                {
                    case "DESCUENTO":
                        newRow["CANTIDAD"] = 1;
                        newRow["PRECIO UNITARIO"] = promocion.PrecioEspecial;
                        newRow["PRECIO TOTAL"] = promocion.PrecioEspecial;
                        break;

                    case "2X1":
                        newRow["CANTIDAD"] = 2;
                        newRow["PRECIO UNITARIO"] = precioUnitarioOriginal;
                        newRow["PRECIO TOTAL"] = precioUnitarioOriginal;
                        break;

                    case "3X2":
                        newRow["CANTIDAD"] = 3;
                        newRow["PRECIO UNITARIO"] = precioUnitarioOriginal;
                        newRow["PRECIO TOTAL"] = precioUnitarioOriginal * 2;
                        break;

                    default:
                        newRow["CANTIDAD"] = 1;
                        newRow["PRECIO UNITARIO"] = precioUnitarioOriginal;
                        newRow["PRECIO TOTAL"] = precioUnitarioOriginal;
                        break;
                }
            }
            else
            {
                newRow["CANTIDAD"] = 1;
                newRow["PRECIO UNITARIO"] = precioUnitarioOriginal;
                newRow["PRECIO TOTAL"] = precioUnitarioOriginal;
            }

            dataTable.Rows.Add(newRow);
        }
    }
}
