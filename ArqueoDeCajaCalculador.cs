using ProveeduriaVane;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
                    // Verificar si ya existe un arqueo en la fecha solicitada
                    if (ExisteArqueoEnFecha(fecha, connection, transaction))
                    {
                        throw new Exception($"Ya existe un arqueo registrado para la fecha {fecha.ToString("dd/MM/yyyy")}.");
                    }

                    // Obtener los totales calculados
                    decimal totalEfectivo = ObtenerTotalPorMedioPago(fecha, "Efectivo", connection, transaction);
                    decimal totalDebito = ObtenerTotalPorMedioPago(fecha, "Débito", connection, transaction);
                    decimal totalCredito = ObtenerTotalPorMedioPago(fecha, "Crédito", connection, transaction);
                    decimal totalTransferencia = ObtenerTotalPorMedioPago(fecha, "Transferencia", connection, transaction);
                    // Obtener ingresos y egresos manuales
                    decimal totalIngresosManuales = ObtenerIngresos(fecha, connection, transaction);
                    decimal totalEgresosManuales = ObtenerEgresos(fecha, connection, transaction);
                    // Calcular el total final basado en ingresos y egresos
                    decimal totalFinalCalculado = totalEfectivo + totalDebito + totalCredito + totalTransferencia - totalEgresosManuales + totalIngresosManuales;
                    decimal diferencia = totalFinalCalculado - totalInicial;
                    // Insertar el arqueo de caja
                    InsertarArqueoDeCaja(fecha, totalInicial, totalEfectivo, totalDebito, totalCredito, totalTransferencia, totalFinalCalculado, diferencia, connection, transaction);
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

    private void GuardarResultado(DateTime fecha, string observacion, string medioDiscrepancia, decimal diferencia)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            // Verificar si ya existe un resultado en la fecha solicitada
            if (ExisteResultadoEnFecha(fecha, connection))
            {
                throw new Exception($"Ya existe un resultado registrado para la fecha {fecha.ToString("dd/MM/yyyy")}.");
            }
            InsertarResultadoArqueo(fecha, observacion, medioDiscrepancia, diferencia, connection);
        }
    }

    private bool ExisteArqueoEnFecha(DateTime fecha, SqlConnection connection, SqlTransaction transaction)
    {
        string queryArqueo = @"SELECT COUNT(*) FROM ArqueoDeCaja WHERE fecha = @fecha";
        SqlCommand commandArqueo = new SqlCommand(queryArqueo, connection, transaction);
        commandArqueo.Parameters.AddWithValue("@fecha", fecha);
        int count = (int)commandArqueo.ExecuteScalar();
        return count > 0;
    }

    private bool ExisteResultadoEnFecha(DateTime fecha, SqlConnection connection)
    {
        string queryResultado = @"SELECT COUNT(*) FROM ResultadoArqueo WHERE fecha = @fecha";
        SqlCommand commandResultado = new SqlCommand(queryResultado, connection);
        commandResultado.Parameters.AddWithValue("@fecha", fecha);
        int count = (int)commandResultado.ExecuteScalar();
        return count > 0;
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

    private void InsertarResultadoArqueo(DateTime fecha, string observacion, string medioDiscrepancia, decimal diferencia, SqlConnection connection)
    {
        string queryResultado = @"
        INSERT INTO ResultadoArqueo (fecha, observacion, medioDiscrepancia, diferencia)
        VALUES (@fecha, @observacion, @medioDiscrepancia, @diferencia)";
        using (var commandResultado = new SqlCommand(queryResultado, connection))
        {
            commandResultado.Parameters.AddWithValue("@fecha", fecha);
            commandResultado.Parameters.AddWithValue("@observacion", observacion);
            commandResultado.Parameters.AddWithValue("@medioDiscrepancia", medioDiscrepancia);
            commandResultado.Parameters.AddWithValue("@diferencia", diferencia);
            commandResultado.ExecuteNonQuery();
        }
    }

    private decimal ObtenerTotalPorMedioPago(DateTime fecha, string medioPago, SqlConnection connection, SqlTransaction transaction)
    {
        decimal total = 0;
        string query = @"
            SELECT ISNULL(SUM(montoFinal), 0) 
            FROM Ventas 
            WHERE CONVERT(date, fecha) = @fecha
            AND medioPago = @medioPago";

        SqlCommand command = new SqlCommand(query, connection, transaction);
        command.Parameters.AddWithValue("@fecha", fecha);
        command.Parameters.AddWithValue("@medioPago", medioPago);

        // Manejo de datos nulos
        object result = command.ExecuteScalar();
        total = result != DBNull.Value ? (decimal)result : 0; // Verificación para nulos
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
            using (SqlTransaction transaction = connection.BeginTransaction())
            {
                try
                {
                    string query = @"
                    SELECT fecha as Fecha, 
                           ISNULL(totalInicial, 0) AS 'Total inicial', 
                           ISNULL(totalEfectivo, 0) AS 'Efectivo', 
                           ISNULL(totalDebito, 0) AS 'Débito', 
                           ISNULL(totalCredito, 0) AS 'Crédito', 
                           ISNULL(totalTransferencia, 0) AS 'Transferencias', 
                           ISNULL(totalFinal, 0) AS 'Total final', 
                           ISNULL(diferencia, 0) AS Diferencia
                    FROM ArqueoDeCaja
                    WHERE fecha BETWEEN @fechaInicio AND @fechaFin";

                    using (SqlCommand command = new SqlCommand(query, connection, transaction))
                    {
                        // Añadir parámetros al comando
                        command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                        command.Parameters.AddWithValue("@fechaFin", fechaFin);

                        // Usar SqlDataAdapter para llenar el DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            transaction.Commit(); // Confirmar la transacción
                            return dt;
                        }
                    }
                }
                catch
                {
                    transaction.Rollback(); // Revertir la transacción en caso de error
                    throw;
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
        if (discrepancias.Any())
        {
            string observaciones = "Discrepancias encontradas:\n";
            foreach (var disc in discrepancias)
            {
                observaciones += $"{disc.medio}: {disc.diferencia:C}\n";
            }
            if (diferenciaTotalFinal != 0)
                observaciones += $"Total Final: {diferenciaTotalFinal:C}\n";

            // Mostrar el MessageBox con las observaciones
            DialogResult result = MessageBox.Show(observaciones + "\n¿Desea guardar estos resultados?",
                "Discrepancias en Arqueo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Guardar cada discrepancia mediante la función unificada
                GuardarResultado(fecha, observaciones, discrepancias);
            }
        }
    }

    private void GuardarResultado(DateTime fecha, string observacion, List<(string medio, decimal diferencia)> discrepancias)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (var transaction = connection.BeginTransaction())
            {
                try
                {
                    // Verificar si ya existe un resultado en la fecha solicitada
                    if (ExisteResultadoEnFecha(fecha, connection))
                    {
                        throw new Exception($"Ya existe un resultado registrado para la fecha {fecha.ToString("dd/MM/yyyy")}.");
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
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }

    //Codigo antiguo para el manejo de las discrepancias:
    //public void CompararTotales(decimal efectivoManual, decimal debitoManual, decimal creditoManual, decimal transferenciaManual, decimal totalFinalManual, DateTime fecha)
    //{
    //    // Obtener totales automáticos desde la base de datos
    //    var totalesAutomaticos = ObtenerTotalesAutomaticos(fecha);

    //    decimal efectivoAuto = totalesAutomaticos.Item1;
    //    decimal debitoAuto = totalesAutomaticos.Item2;
    //    decimal creditoAuto = totalesAutomaticos.Item3;
    //    decimal transferenciaAuto = totalesAutomaticos.Item4;
    //    decimal totalFinalAuto = totalesAutomaticos.Item5;

    //    // Calcular diferencias
    //    decimal diferenciaEfectivo = efectivoManual - efectivoAuto;
    //    decimal diferenciaDebito = debitoManual - debitoAuto;
    //    decimal diferenciaCredito = creditoManual - creditoAuto;
    //    decimal diferenciaTransferencia = transferenciaManual - transferenciaAuto;
    //    decimal diferenciaTotalFinal = totalFinalManual - totalFinalAuto;

    //    // Verificar si hay discrepancias y mostrar el mensaje
    //    if (diferenciaEfectivo != 0 || diferenciaDebito != 0 || diferenciaCredito != 0 || diferenciaTransferencia != 0 || diferenciaTotalFinal != 0)
    //    {
    //        string observaciones = "Discrepancias encontradas:\n";

    //        if (diferenciaEfectivo != 0)
    //            observaciones += $"Efectivo: {diferenciaEfectivo:C}\n";
    //        if (diferenciaDebito != 0)
    //            observaciones += $"Débito: {diferenciaDebito:C}\n";
    //        if (diferenciaCredito != 0)
    //            observaciones += $"Crédito: {diferenciaCredito:C}\n";
    //        if (diferenciaTransferencia != 0)
    //            observaciones += $"Transferencia: {diferenciaTransferencia:C}\n";
    //        if (diferenciaTotalFinal != 0)
    //            observaciones += $"Total Final: {diferenciaTotalFinal:C}\n";

    //        // Mostrar el MessageBox con las observaciones
    //        DialogResult result = MessageBox.Show(observaciones + "\n¿Desea guardar estos resultados?", "Discrepancias en Arqueo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

    //        if (result == DialogResult.Yes)
    //        {
    //            // Guardar resultado si el usuario lo confirma
    //            GuardarResultado(fecha, observaciones, GetMedioDiscrepancia(diferenciaEfectivo, diferenciaDebito, diferenciaCredito, diferenciaTransferencia), diferenciaTotalFinal);
    //        }
    //    }
    //}

    //private string GetMedioDiscrepancia(decimal diferenciaEfectivo, decimal diferenciaDebito, decimal diferenciaCredito, decimal diferenciaTransferencia)
    //{
    //    string medioDiscrepancia = "";

    //    if (diferenciaEfectivo != 0) medioDiscrepancia += "Efectivo ";
    //    if (diferenciaDebito != 0) medioDiscrepancia += "Débito ";
    //    if (diferenciaCredito != 0) medioDiscrepancia += "Crédito ";
    //    if (diferenciaTransferencia != 0) medioDiscrepancia += "Transferencia ";

    //    return medioDiscrepancia.Trim();
    //}

    //private void GuardarResultado(DateTime fecha, string observacion, string medioDiscrepancia, decimal diferencia)
    //{
    //    using (var connection = new SqlConnection(connectionString))
    //    {
    //        connection.Open();
    //        string query = @"
    //        INSERT INTO ResultadoArqueo (fecha, observacion, medioDiscrepancia, diferencia)
    //        VALUES (@fecha, @observacion, @medioDiscrepancia, @diferencia)";

    //        using (var command = new SqlCommand(query, connection))
    //        {
    //            command.Parameters.AddWithValue("@fecha", fecha);
    //            command.Parameters.AddWithValue("@observacion", observacion);
    //            command.Parameters.AddWithValue("@medioDiscrepancia", medioDiscrepancia);
    //            command.Parameters.AddWithValue("@diferencia", diferencia);

    //            command.ExecuteNonQuery();
    //        }
    //    }
    //}
}
