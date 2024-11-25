using ProveeduriaVane;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Transactions;
using System.Windows.Forms;
using System.Globalization;

public class ArqueoDeCajaCalculador
{
    private string connectionString = StringConexion.ConnectionString;

    public void CalcularYGuardarArqueo(DateTime fecha, decimal totalInicial)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlTransaction transaction = connection.BeginTransaction())
            {
                try
                {
                    // Verificación estricta de arqueo existente
                    if (ExisteArqueoEnFecha(fecha, connection, transaction))
                    {
                        MessageBox.Show($"Ya existe un arqueo de caja registrado para la fecha {fecha:dd/MM/yyyy}. No se permiten registros duplicados.",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        return; // Opción para evitar que se siga ejecutando el código posterior
                    }
                    else
                    {
                        MessageBox.Show("¡El arqueo de caja automático del día de hoy (" + DateTime.Now + ")" + " se guardó correctamente!", "Día Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Obtener los totales calculados con manejo explícito de métodos de pago
                    decimal totalEfectivo = ObtenerTotalPorMedioPago(fecha, "EFECTIVO", connection, transaction);
                    decimal totalDebito = ObtenerTotalPorMedioPago(fecha, "DÉBITO", connection, transaction);
                    decimal totalCredito = ObtenerTotalPorMedioPago(fecha, "CRÉDITO", connection, transaction);
                    decimal totalTransferencia = ObtenerTotalPorMedioPago(fecha, "TRANSFERENCIA", connection, transaction);

                    // Obtener ingresos y egresos manuales
                    decimal totalIngresosManuales = ObtenerIngresos(fecha, connection, transaction);
                    decimal totalEgresosManuales = ObtenerEgresos(fecha, connection, transaction);

                    // Calcular el total final con signo correcto
                    decimal totalFinalCalculado = totalInicial + totalEfectivo + totalDebito +
                                                  totalCredito + totalTransferencia +
                                                  totalIngresosManuales - totalEgresosManuales;

                    // Calcular diferencia con signo correcto
                    decimal diferencia = totalFinalCalculado - totalInicial;

                    // Insertar el arqueo de caja con todos los detalles
                    InsertarArqueoDeCaja(fecha, totalInicial, totalEfectivo, totalDebito,
                                         totalCredito, totalTransferencia,
                                         totalFinalCalculado, diferencia,
                                         connection, transaction);

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

    private bool ExisteArqueoEnFecha(DateTime fecha, SqlConnection connection, SqlTransaction transaction)
    {
        string queryArqueo = @"
        SELECT COUNT(*)
        FROM ArqueoDeCaja
        WHERE CAST(fecha AS date) = @fecha"; // Se asegura que solo se compare la fecha
        using (SqlCommand commandArqueo = new SqlCommand(queryArqueo, connection, transaction))
        {
            commandArqueo.Parameters.AddWithValue("@fecha", fecha.Date); // Solo la parte de la fecha
            int count = (int)commandArqueo.ExecuteScalar();
            return count > 0; // Devuelve true si hay registros
        }
    }

    private bool ExisteResultadoEnFecha(DateTime fecha, SqlConnection connection, SqlTransaction transaction)
    {
        string queryResultado = @"
    SELECT COUNT(*)
    FROM ResultadoArqueo
    WHERE CAST(fecha AS date) = @fecha"; // Comparar solo la fecha

        using (SqlCommand commandResultado = new SqlCommand(queryResultado, connection))
        {
            commandResultado.Parameters.AddWithValue("@fecha", fecha.Date); // Pasar solo la fecha
            commandResultado.Transaction = transaction; // Asociar el comando con la transacción

            int count = (int)commandResultado.ExecuteScalar();
            return count > 0; // Devuelve true si hay registros
        }
    }



    private void InsertarArqueoDeCaja(DateTime fecha, decimal totalInicial, decimal totalEfectivo, decimal totalDebito, decimal totalCredito, decimal totalTransferencia, decimal totalFinalCalculado, decimal diferencia, SqlConnection connection, SqlTransaction transaction)
    {
        string queryArqueo = @"
        INSERT INTO ArqueoDeCaja (fecha, totalInicial, totalEfectivo, totalDebito, totalCredito, totalTransferencia, totalFinal, diferencia)
        VALUES (@fecha, @totalInicial, @totalEfectivo, @totalDebito, @totalCredito, @totalTransferencia, @totalFinalCalculado, @diferencia)";
        SqlCommand commandArqueo = new SqlCommand(queryArqueo, connection, transaction);
        commandArqueo.Parameters.AddWithValue("@fecha", fecha);
        commandArqueo.Parameters.AddWithValue("@totalInicial", totalInicial);
        commandArqueo.Parameters.AddWithValue("@totalEfectivo", totalEfectivo);
        commandArqueo.Parameters.AddWithValue("@totalDebito", totalDebito);
        commandArqueo.Parameters.AddWithValue("@totalCredito", totalCredito);
        commandArqueo.Parameters.AddWithValue("@totalTransferencia", totalTransferencia);
        commandArqueo.Parameters.AddWithValue("@totalFinalCalculado", totalFinalCalculado);
        commandArqueo.Parameters.AddWithValue("@diferencia", diferencia);
        commandArqueo.ExecuteNonQuery();
    }

    private decimal ObtenerTotalPorMedioPago(DateTime fecha, string medioPago, SqlConnection connection, SqlTransaction transaction)
    {
        decimal total = 0;
        string query = @"
    SELECT ISNULL(SUM(montoFinal), 0) AS Total
    FROM Ventas
    WHERE fecha >= @fechaInicio AND fecha < @fechaFin
    AND medioPago = @medioPago";

        using (SqlCommand command = new SqlCommand(query, connection, transaction))
        {
            command.Parameters.AddWithValue("@fechaInicio", fecha.Date);
            command.Parameters.AddWithValue("@fechaFin", fecha.Date.AddDays(1));
            command.Parameters.AddWithValue("@medioPago", medioPago.Trim()); // Elimina espacios innecesarios
            total = (decimal)command.ExecuteScalar();
        }

        return total;
    }


    private decimal ObtenerIngresos(DateTime fecha, SqlConnection connection, SqlTransaction transaction)
    {
        decimal total = 0;
        string query = @"
            SELECT ISNULL(SUM(monto), 0)
            FROM Ingresos
            WHERE CONVERT(date, fecha) = @fecha";

        SqlCommand command = new SqlCommand(query, connection, transaction);
        command.Parameters.AddWithValue("@fecha", fecha);

        // Manejo de datos nulos
        object result = command.ExecuteScalar();
        total = result != DBNull.Value ? (decimal)result : 0; // Verificación para nulos
        return total;
    }

    private decimal ObtenerEgresos(DateTime fecha, SqlConnection connection, SqlTransaction transaction)
    {
        decimal total = 0;
        string query = @"
            SELECT ISNULL(SUM(monto), 0)
            FROM Egresos
            WHERE CONVERT(date, fecha) = @fecha";

        SqlCommand command = new SqlCommand(query, connection, transaction);
        command.Parameters.AddWithValue("@fecha", fecha);

        // Manejo de datos nulos
        object result = command.ExecuteScalar();
        total = result != DBNull.Value ? (decimal)result : 0; // Verificación para nulos
        return total;
    }

    public decimal ObtenerTotalInicial(DateTime fecha)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlTransaction transaction = connection.BeginTransaction())
            {
                try
                {
                    string query = @"
                        SELECT ISNULL(totalInicial, 0)
                        FROM ArqueoDeCaja
                        WHERE fecha = @fecha";

                    SqlCommand command = new SqlCommand(query, connection, transaction);
                    command.Parameters.AddWithValue("@fecha", fecha);

                    // Manejo de datos nulos
                    object result = command.ExecuteScalar();
                    decimal totalInicial = result != DBNull.Value ? (decimal)result : 0; // Verificación para nulos
                    transaction.Commit();
                    return totalInicial;
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }

    public DataTable ObtenerTotalesPorMedioPago(DateTime fechaInicio, DateTime fechaFin)
    {
        DataTable resultados = new DataTable();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlTransaction transaction = connection.BeginTransaction())
            {
                try
                {
                    string query = @"
                        SELECT medioPago as 'Medio de Pago', SUM(montoFinal) AS Total
                        FROM Ventas
                        WHERE fecha BETWEEN @fechaInicio AND @fechaFin
                        GROUP BY medioPago";

                    using (SqlCommand command = new SqlCommand(query, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                        command.Parameters.AddWithValue("@fechaFin", fechaFin);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(resultados);
                        }
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    // Manejar el error, por ejemplo, logueándolo o lanzándolo
                    throw new Exception("Error al obtener totales por medio de pago", ex);
                }
            }
        }

        return resultados;
    }

    public DataTable ObtenerVentas(DateTime fechaInicio, DateTime fechaFin)
    {
        DataTable dt = new DataTable();
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string consulta = @"SELECT 
            V.fecha AS Fecha,
            DV.codigoBarra AS Producto, 
            DV.cantidad AS Cantidad, 
            DV.precio_Unitario AS 'Precio unitario', 
            ISNULL((DV.cantidad * DV.precio_Unitario), 0) AS 'Precio total'
            FROM 
            Ventas V
            INNER JOIN 
            Detalle_Ventas DV ON V.idVenta = DV.id_Venta
            WHERE V.fecha BETWEEN @fechaInicio AND @fechaFin
            ORDER BY
            V.fecha DESC;";

            SqlDataAdapter adapter = new SqlDataAdapter(consulta, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@fechaInicio", fechaInicio);
            adapter.SelectCommand.Parameters.AddWithValue("@fechaFin", fechaFin);
            adapter.Fill(dt);
            connection.Close();
        }

        return dt;
    }

    public DataTable ObtenerArqueos(DateTime fechaInicio, DateTime fechaFin)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = @"
        SELECT 
            fecha AS Fecha,
            totalInicial AS 'Total inicial',
            totalEfectivo AS 'Efectivo',
            totalDebito AS 'Débito',
            totalCredito AS 'Crédito',
            totalTransferencia AS 'Transferencia',
            totalFinal AS 'Total final',
            diferencia AS Diferencia
        FROM ArqueoDeCaja
        WHERE fecha BETWEEN @fechaInicio AND @fechaFin
        ORDER BY fecha DESC";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                command.Parameters.AddWithValue("@fechaFin", fechaFin);

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
    }




    public DataTable resultadoManual(DateTime? fechaInicio, DateTime? fechaFin)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlTransaction transaction = connection.BeginTransaction())
            {
                try
                {
                    // Construye la consulta SQL considerando los valores nulos
                    string query = @"select fecha as Fecha, observacion as Observacion, medioDiscrepancia as 'Medio discrepancia', diferencia as Diferencia 
                                 from ResultadoArqueo
                                 where (@fechaInicio IS NULL OR fecha >= @fechaInicio)
                                 and (@fechaFin IS NULL OR fecha <= @fechaFin)";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    // Asigna la transacción al comando
                    adapter.SelectCommand.Transaction = transaction;

                    // Agrega los parámetros y maneja posibles valores nulos
                    adapter.SelectCommand.Parameters.AddWithValue("@fechaInicio", fechaInicio.HasValue ? (object)fechaInicio.Value : DBNull.Value);
                    adapter.SelectCommand.Parameters.AddWithValue("@fechaFin", fechaFin.HasValue ? (object)fechaFin.Value : DBNull.Value);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    transaction.Commit();
                    return dt;
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }

    private decimal ObtenerTotalFinal(DateTime fecha, SqlConnection connection, SqlTransaction transaction)
    {
        decimal total = 0;
        string query = @"
        SELECT ISNULL(SUM(totalFinal), 0) 
        FROM ArqueoDeCaja
        WHERE fecha = @fecha";

        SqlCommand command = new SqlCommand(query, connection, transaction);
        command.Parameters.AddWithValue("@fecha", fecha);

        total = (decimal)command.ExecuteScalar();
        return total;
    }

    public decimal ObtenerDiferencia(DateTime fecha)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlTransaction transaction = connection.BeginTransaction())
            {
                try
                {
                    string query = @"
                    SELECT ISNULL(diferencia, 0)
                    FROM ArqueoDeCaja
                    WHERE fecha = @fecha";

                    SqlCommand command = new SqlCommand(query, connection, transaction);
                    command.Parameters.AddWithValue("@fecha", fecha);

                    object result = command.ExecuteScalar();
                    transaction.Commit();

                    // Verifica si el resultado es DBNull antes de convertir
                    return result != DBNull.Value ? (decimal)result : 0;
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }

    private Tuple<decimal, decimal, decimal, decimal, decimal> ObtenerTotalesAutomaticos(DateTime fecha)
    {
        // Inicializamos los valores de los totales
        decimal totalEfectivo = 0;
        decimal totalDebito = 0;
        decimal totalCredito = 0;
        decimal totalTransferencia = 0;
        decimal totalFinal = 0;

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlTransaction transaction = connection.BeginTransaction())
            {
                try
                {
                    totalEfectivo = ObtenerTotalPorMedioPago(fecha, "Efectivo", connection, transaction);
                    totalDebito = ObtenerTotalPorMedioPago(fecha, "Débito", connection, transaction);
                    totalCredito = ObtenerTotalPorMedioPago(fecha, "Crédito", connection, transaction);
                    totalTransferencia = ObtenerTotalPorMedioPago(fecha, "Transferencia", connection, transaction);
                    totalFinal = ObtenerTotalFinal(fecha, connection, transaction);

                    // Confirmar la transacción
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        // Devolvemos los totales asegurándonos de que no sean nulos
        return new Tuple<decimal, decimal, decimal, decimal, decimal>(
            totalEfectivo, totalDebito, totalCredito, totalTransferencia, totalFinal
        );
    }

    //Codigo nuevo para el manejo de los medios con discrepancias
    public void CompararTotales(decimal efectivoManual, decimal debitoManual, decimal creditoManual, decimal transferenciaManual, decimal totalFinalManual, DateTime fecha)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (var transaction = connection.BeginTransaction()) // Comienza la transacción
            {
                try
                {
                    // Verificar si ya existe un resultado para la fecha
                    if (ExisteResultadoEnFecha(fecha, connection, transaction))
                    {
                        MessageBox.Show($"Ya existe un arqueo de caja registrado para la fecha {fecha:dd/MM/yyyy}. No se permiten registros duplicados.",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        return; // Detener la ejecución si ya existe un arqueo registrado
                    }

                    // Obtener totales automáticos desde la base de datos
                    var totalesAutomaticos = ObtenerTotalesAutomaticos(fecha);
                    decimal efectivoAuto = totalesAutomaticos.Item1;
                    decimal debitoAuto = totalesAutomaticos.Item2;
                    decimal creditoAuto = totalesAutomaticos.Item3;
                    decimal transferenciaAuto = totalesAutomaticos.Item4;
                    decimal totalFinalAuto = totalesAutomaticos.Item5;

                    // Calcular diferencias
                    decimal diferenciaEfectivo = efectivoManual - efectivoAuto;
                    decimal diferenciaDebito = debitoManual - debitoAuto;
                    decimal diferenciaCredito = creditoManual - creditoAuto;
                    decimal diferenciaTransferencia = transferenciaManual - transferenciaAuto;
                    decimal diferenciaTotalFinal = totalFinalManual - totalFinalAuto;

                    // Crear lista de discrepancias
                    var discrepancias = new List<(string medio, decimal diferencia)>();
                    if (diferenciaEfectivo != 0)
                        discrepancias.Add(("Efectivo", diferenciaEfectivo));
                    if (diferenciaDebito != 0)
                        discrepancias.Add(("Débito", diferenciaDebito));
                    if (diferenciaCredito != 0)
                        discrepancias.Add(("Crédito", diferenciaCredito));
                    if (diferenciaTransferencia != 0)
                        discrepancias.Add(("Transferencia", diferenciaTransferencia));

                    // Verificar si hay discrepancias y mostrar el mensaje
                    CultureInfo culturaArgentina = new CultureInfo("es-AR");

                    if (discrepancias.Any())
                    {
                        string observaciones = "Discrepancias encontradas:\n";
                        foreach (var disc in discrepancias)
                        {
                            observaciones += $"{disc.medio}: {disc.diferencia.ToString("C", culturaArgentina)}\n";  // Usar formato de moneda en pesos argentinos
                        }
                        if (diferenciaTotalFinal != 0)
                            observaciones += $"Total Final: {diferenciaTotalFinal.ToString("C", culturaArgentina)}\n";  // Usar formato de moneda en pesos argentinos

                        // Mostrar el MessageBox con las observaciones
                        DialogResult result = MessageBox.Show(observaciones + "\n¿Desea guardar estos resultados?",
                            "Discrepancias en Arqueo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            // Guardar cada discrepancia mediante la función unificada
                            GuardarResultadoManual(fecha, observaciones, discrepancias, connection, transaction);

                            // Aquí commit se hace una vez que todo se guarda correctamente
                            transaction.Commit(); // Confirmar la transacción
                        }
                    }
                }
                catch (Exception)
                {
                    // Si ocurre algún error, hacemos rollback y lanzamos la excepción
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }


    private void GuardarResultadoManual(DateTime fecha, string observacion, List<(string medio, decimal diferencia)> discrepancias, SqlConnection connection, SqlTransaction transaction)
    {
        try
        {
            // Verificar si ya existe un resultado en la fecha solicitada
            if (ExisteResultadoEnFecha(fecha, connection, transaction))
            {
                return; // Opción para evitar que se siga ejecutando el código posterior
            }
            else
            {
                MessageBox.Show("¡El arqueo de caja manual del día de hoy (" + DateTime.Now + ")" + " se guardó correctamente!", "Comprobación Manual Finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            string query = @"
        INSERT INTO ResultadoArqueo (fecha, observacion, medioDiscrepancia, diferencia)
        VALUES (@fecha, @observacion, @medioDiscrepancia, @diferencia)";

            foreach (var disc in discrepancias)
            {
                using (var command = new SqlCommand(query, connection, transaction))
                {
                    command.Parameters.AddWithValue("@fecha", fecha);
                    command.Parameters.AddWithValue("@observacion", observacion);
                    command.Parameters.AddWithValue("@medioDiscrepancia", disc.medio);
                    command.Parameters.AddWithValue("@diferencia", disc.diferencia);
                    command.ExecuteNonQuery();
                }
            }

            // Commit la transacción
            transaction.Commit();
        }
        catch (Exception ex)
        {
            // Si ocurre un error, deshacer la transacción
            transaction.Rollback();
            MessageBox.Show("Error al guardar los resultados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw;
        }
    }
}

