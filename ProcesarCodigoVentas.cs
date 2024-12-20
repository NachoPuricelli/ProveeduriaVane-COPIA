﻿using System;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using ProveeduriaVane;
using iText.Kernel.Pdf.Canvas.Wmf;
using static iText.IO.Util.IntHashtable;

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
            // Inicializa los modos de operación en falso. Estos modos son usados para cambiar el comportamiento de la clase en distintas situaciones.
            this.codigoBarraBuilder = new StringBuilder();
        }

        // Propiedad que expone el modo devolución, permitiendo verificar o modificar si el sistema está en este estado.
        // Al cambiar su valor, se escribe en el registro de depuración un mensaje indicando el nuevo estado.
        public bool ModoDevolucion
        {
            get { return modoDevolucion; }
            set
            {
                modoDevolucion = value;
                Debug.WriteLine($"Modo devolución cambiado a: {value}");
            }
        }

        // Propiedad que expone el modo disminuir, para verificar o cambiar si el sistema debe operar en este estado.
        public bool ModoDisminuir
        {
            get { return modoDisminuir; }
            set { modoDisminuir = value; }
        }

        //Clase que estructura la información de la promoción
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

        // Método para agregar un carácter al codigoBarraBuilder.
        // Detiene y reinicia el temporizador para reiniciar el conteo, permitiendo que se acumulen más caracteres antes de procesar el código.
        public void AgregarCaracter(char caracter)
        {
            codigoBarraBuilder.Append(caracter);
            timer.Stop();
            timer.Start();
        }

        // Detiene el temporizador, convierte el contenido acumulado en una cadena, y determina si se procesará como devolución o venta.
        // En caso de error, muestra un mensaje al usuario y, finalmente, limpia el acumulador.
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

        // Propiedad que permite acceder al objeto `codigoBarraBuilder`, utilizado para acumular los caracteres del código de barras.
        public StringBuilder CodigoBarraBuilder
        {
            get { return codigoBarraBuilder; }
        }

        // Método asíncrono que verifica si el código de barras tiene promociones asociadas dentro de las fechas válidas.
        // Consulta la base de datos y devuelve un objeto `PromocionInfo` con los detalles de la promoción si existe, o `null` si no hay promociones aplicables.
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
                MessageBox.Show("El código de barras no puede estar vacío.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Verificar si el código es una promoción (combo) o un producto individual
                var promocion = await VerificarPromociones(codigoBarra);
                bool aplicarPromocion = false;

                if (promocion != null)
                {
                    string mensajePromocion = "";
                    switch (promocion.TipoPromo)
                    {
                        case "COMBO":
                            mensajePromocion = $"Se ha encontrado un combo:\n\n{promocion.Descripcion}\n" +
                                               $"Precio especial: ${promocion.PrecioEspecial}\n\n¿Desea agregar este combo?";
                            break;
                        case "DESCUENTO":
                            mensajePromocion = $"Descuento disponible:\n\n{promocion.Descripcion}\n" +
                                               $"Precio con descuento: ${promocion.PrecioEspecial}\n\n¿Desea aplicar este descuento?";
                            break;
                        case "2X1":
                            mensajePromocion = $"Promoción 2x1:\n\n{promocion.Descripcion}\n" +
                                               $"Lleve 2 productos y pague solo 1\n\n¿Desea aplicar esta promoción?";
                            break;
                        case "3X2":
                            mensajePromocion = $"Promoción 3x2:\n\n{promocion.Descripcion}\n" +
                                               $"Lleve 3 productos y pague solo 2\n\n¿Desea aplicar esta promoción?";
                            break;
                    }

                    var result = MessageBox.Show(mensajePromocion, "Promoción Disponible",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    aplicarPromocion = (result == DialogResult.Yes);
                }

                // Procesar el producto
                string consulta = "SELECT codigoBarras, descripcion, marca, precioUnitario FROM Productos " +
                                 "WHERE codigoBarras = @codigoBarra";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand comando = new SqlCommand(consulta, connection))
                    {
                        comando.Parameters.AddWithValue("@codigoBarra", codigoBarra);
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
                        DataTable productoDataTable = new DataTable();

                        await connection.OpenAsync();
                        dataAdapter.Fill(productoDataTable);

                        foreach (DataRow row in productoDataTable.Rows)
                        {
                            DataRow[] existingRows = dataTable.Select($"CÓDIGO = '{row["codigoBarras"]}'");

                            if (existingRows.Length > 0 && !aplicarPromocion)
                            {
                                ActualizarProductoExistente(existingRows[0], row);
                            }
                            else
                            {
                                AgregarNuevoProducto(row, promocion, aplicarPromocion);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error de base de datos: {ex.Message}\nPor favor, contacte al administrador del sistema.",
                    "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine($"SQL Error: {ex}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar el código de barras: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine($"Error General: {ex}");
            }

            formularioPrincipal.CalcularTotalVenta();
        }

        public async Task ProcesarCellEdit(DataGridViewRow row, string codigoBarra)
        {
            if (string.IsNullOrEmpty(codigoBarra))
                return;

            try
            {
                // Verificar si existe una promoción para el producto
                var promocion = await VerificarPromociones(codigoBarra);
                bool aplicarPromocion = false;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string consulta = "SELECT codigoBarras, descripcion, marca, precioUnitario FROM Productos WHERE codigoBarras = @codigoBarra";
                    using (SqlCommand comando = new SqlCommand(consulta, connection))
                    {
                        comando.Parameters.AddWithValue("@codigoBarra", codigoBarra);
                        await connection.OpenAsync();

                        using (var reader = await comando.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                decimal precioUnitario = reader.GetDecimal(reader.GetOrdinal("precioUnitario"));
                                string descripcion = reader["descripcion"].ToString();
                                string marca = reader["marca"].ToString();

                                // Si hay una promoción, mostrar mensaje de confirmación
                                if (promocion != null)
                                {
                                    string mensajePromocion = "";
                                    switch (promocion.TipoPromo)
                                    {
                                        case "COMBO":
                                            mensajePromocion = $"Se ha encontrado un combo:\n\n" +
                                                             $"Descripción: {promocion.Descripcion}\n" +
                                                             $"Precio especial: ${promocion.PrecioEspecial}\n\n" +
                                                             $"¿Desea aplicar esta promoción?";
                                            break;
                                        case "DESCUENTO":
                                            mensajePromocion = $"Hay un descuento disponible para {descripcion}:\n\n" +
                                                             $"Precio normal: ${precioUnitario}\n" +
                                                             $"Precio con descuento: ${promocion.PrecioEspecial}\n\n" +
                                                             $"¿Desea aplicar este descuento?";
                                            break;
                                        case "2X1":
                                            mensajePromocion = $"Hay una promoción 2x1 para {descripcion}:\n\n" +
                                                             $"Lleve 2 productos y pague solo 1\n" +
                                                             $"Precio: ${precioUnitario}\n\n" +
                                                             $"¿Desea aplicar esta promoción?";
                                            break;
                                        case "3X2":
                                            mensajePromocion = $"Hay una promoción 3x2 para {descripcion}:\n\n" +
                                                             $"Lleve 3 productos y pague solo 2\n" +
                                                             $"Precio: ${precioUnitario}\n\n" +
                                                             $"¿Desea aplicar esta promoción?";
                                            break;
                                    }

                                    if (!string.IsNullOrEmpty(mensajePromocion))
                                    {
                                        var result = MessageBox.Show(mensajePromocion, "Promoción Disponible",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                        aplicarPromocion = (result == DialogResult.Yes);
                                    }
                                }

                                // Aplicar valores según la promoción confirmada o producto normal
                                if (promocion != null && aplicarPromocion)
                                {
                                    switch (promocion.TipoPromo)
                                    {
                                        case "COMBO":
                                            row.Cells["CÓDIGO"].Value = "";
                                            row.Cells["DESCRIPCIÓN"].Value = promocion.Descripcion;
                                            row.Cells["MARCA"].Value = "";
                                            row.Cells["CANTIDAD"].Value = promocion.CantidadPromocion;
                                            row.Cells["PRECIO UNITARIO"].Value = promocion.PrecioEspecial;
                                            row.Cells["PRECIO TOTAL"].Value = promocion.PrecioEspecial * promocion.CantidadPromocion;
                                            break;

                                        case "DESCUENTO":
                                            row.Cells["CÓDIGO"].Value = codigoBarra;
                                            row.Cells["DESCRIPCIÓN"].Value = descripcion;
                                            row.Cells["MARCA"].Value = marca;
                                            row.Cells["CANTIDAD"].Value = 1;
                                            row.Cells["PRECIO UNITARIO"].Value = promocion.PrecioEspecial;
                                            row.Cells["PRECIO TOTAL"].Value = promocion.PrecioEspecial;
                                            break;

                                        case "2X1":
                                            row.Cells["CÓDIGO"].Value = codigoBarra;
                                            row.Cells["DESCRIPCIÓN"].Value = descripcion;
                                            row.Cells["MARCA"].Value = marca;
                                            row.Cells["CANTIDAD"].Value = 2;
                                            row.Cells["PRECIO UNITARIO"].Value = precioUnitario;
                                            row.Cells["PRECIO TOTAL"].Value = precioUnitario;
                                            break;

                                        case "3X2":
                                            row.Cells["CÓDIGO"].Value = codigoBarra;
                                            row.Cells["DESCRIPCIÓN"].Value = descripcion;
                                            row.Cells["MARCA"].Value = marca;
                                            row.Cells["CANTIDAD"].Value = 3;
                                            row.Cells["PRECIO UNITARIO"].Value = precioUnitario;
                                            row.Cells["PRECIO TOTAL"].Value = precioUnitario * 2;
                                            break;
                                    }
                                }
                                else
                                {
                                    // Sin promoción o promoción no aplicada
                                    row.Cells["CÓDIGO"].Value = codigoBarra;
                                    row.Cells["DESCRIPCIÓN"].Value = descripcion;
                                    row.Cells["MARCA"].Value = marca;
                                    row.Cells["CANTIDAD"].Value = 1;
                                    row.Cells["PRECIO UNITARIO"].Value = precioUnitario;
                                    row.Cells["PRECIO TOTAL"].Value = precioUnitario;
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se encontró ningún producto con ese código", "Producto no encontrado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                row.Cells["CÓDIGO"].Value = "";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar el código de barras: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                row.Cells["CÓDIGO"].Value = "";
            }
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
