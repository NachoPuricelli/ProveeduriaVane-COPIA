using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public class ArqueoDeCajaCalculador
{
    private string connectionString = "Server=Elias_Cano;Database=ProveeDesk;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;"; // Ajusta tu cadena de conexión
    public void CalcularYGuardarArqueo(DateTime fecha, decimal totalInicial)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlTransaction transaction = connection.BeginTransaction())
            {
                try
                {
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

                    // Insertar o actualizar el arqueo de caja
                    string queryArqueo = @"
                        IF EXISTS (SELECT 1 FROM ArqueoDeCaja WHERE fecha = @fecha)
                        BEGIN
                            UPDATE ArqueoDeCaja
                            SET totalEfectivo = @totalEfectivo,
                                totalDebito = @totalDebito,
                                totalCredito = @totalCredito,
                                totalTransferencia = @totalTransferencia,
                                totalFinal = @totalFinalCalculado,
                                diferencia = @diferencia
                            WHERE fecha = @fecha
                        END
                        ELSE
                        BEGIN
                            INSERT INTO ArqueoDeCaja (fecha, totalInicial, totalEfectivo, totalDebito, totalCredito, totalTransferencia, totalFinal, diferencia)
                            VALUES (@fecha, @totalInicial, @totalEfectivo, @totalDebito, @totalCredito, @totalTransferencia, @totalFinalCalculado, @diferencia)
                        END";

                    SqlCommand command = new SqlCommand(queryArqueo, connection, transaction);
                    command.Parameters.AddWithValue("@fecha", fecha);
                    command.Parameters.AddWithValue("@totalEfectivo", totalEfectivo);
                    command.Parameters.AddWithValue("@totalDebito", totalDebito);
                    command.Parameters.AddWithValue("@totalCredito", totalCredito);
                    command.Parameters.AddWithValue("@totalTransferencia", totalTransferencia);
                    command.Parameters.AddWithValue("@totalFinalCalculado", totalFinalCalculado);
                    command.Parameters.AddWithValue("@totalInicial", totalInicial);
                    command.Parameters.AddWithValue("@diferencia", diferencia);

                    command.ExecuteNonQuery();
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

    private decimal ObtenerTotalPorMedioPago(DateTime fecha, string medioPago, SqlConnection connection, SqlTransaction transaction)
    {
        decimal total = 0;
        string query = @"
            SELECT ISNULL(SUM(montoFinal), 0) 
            FROM Ventas 
            WHERE CONVERT(date, fechaYhora) = @fecha
            AND medioPago = @medioPago";

        SqlCommand command = new SqlCommand(query, connection, transaction);
        command.Parameters.AddWithValue("@fecha", fecha);
        command.Parameters.AddWithValue("@medioPago", medioPago);

        total = (decimal)command.ExecuteScalar();
        return total;
    }

    private decimal ObtenerIngresos(DateTime fecha, SqlConnection connection, SqlTransaction transaction)
    {
        decimal total = 0;
        string query = @"
            SELECT ISNULL(SUM(ingreso), 0)
            FROM Ingresos
            WHERE CONVERT(date, fecha) = @fecha";

        SqlCommand command = new SqlCommand(query, connection, transaction);
        command.Parameters.AddWithValue("@fecha", fecha);

        total = (decimal)command.ExecuteScalar();
        return total;
    }

    private decimal ObtenerEgresos(DateTime fecha, SqlConnection connection, SqlTransaction transaction)
    {
        decimal total = 0;
        string query = @"
            SELECT ISNULL(SUM(egreso), 0)
            FROM Egresos
            WHERE CONVERT(date, fecha) = @fecha";

        SqlCommand command = new SqlCommand(query, connection, transaction);
        command.Parameters.AddWithValue("@fecha", fecha);

        total = (decimal)command.ExecuteScalar();
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

                    decimal totalInicial = (decimal)command.ExecuteScalar();
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
		using (SqlConnection connection = new SqlConnection(connectionString))
		{
			connection.Open();
			using (SqlTransaction transaction = connection.BeginTransaction())
			{
				try
				{
					string query = @"
						SELECT medioPago, SUM(montoFinal) AS total
						FROM Ventas
						WHERE CONVERT(date, fechaYhora) BETWEEN @fechaInicio AND @fechaFin
						GROUP BY medioPago";

					SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
					adapter.SelectCommand.Parameters.AddWithValue("@fechaInicio", fechaInicio);
					adapter.SelectCommand.Parameters.AddWithValue("@fechaFin", fechaFin);
					
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
						SELECT fecha, totalInicial, totalEfectivo, totalDebito, totalCredito, totalTransferencia, totalFinal, diferencia
						FROM ArqueoDeCaja
						WHERE fecha BETWEEN @fechaInicio AND @fechaFin";

					SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
					adapter.SelectCommand.Parameters.AddWithValue("@fechaInicio", fechaInicio);
					adapter.SelectCommand.Parameters.AddWithValue("@fechaFin", fechaFin);

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

    public DataTable resultadoManual(DateTime fechaInicio, DateTime fechaFin)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlTransaction transaction = connection.BeginTransaction())
            {
                try
                {
                    string query = @"select fecha, observacion, medioDiscrepancia, diferencia from ResultadoArqueo
                    where fecha between @fechaInicio and @fechaFin";

                    SqlDataAdapter adapter = new SqlDataAdapter(query,connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                    adapter.SelectCommand.Parameters.AddWithValue("@fechaFin", fechaFin);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    transaction .Commit();
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

                    decimal diferencia = (decimal)command.ExecuteScalar();
                    transaction.Commit();
                    return diferencia;
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }

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

        // Verificar si hay discrepancias y mostrar el mensaje
        if (diferenciaEfectivo != 0 || diferenciaDebito != 0 || diferenciaCredito != 0 || diferenciaTransferencia != 0 || diferenciaTotalFinal != 0)
        {
            string observaciones = "Discrepancias encontradas:\n";

            if (diferenciaEfectivo != 0)
                observaciones += $"Efectivo: {diferenciaEfectivo:C}\n";
            if (diferenciaDebito != 0)
                observaciones += $"Débito: {diferenciaDebito:C}\n";
            if (diferenciaCredito != 0)
                observaciones += $"Crédito: {diferenciaCredito:C}\n";
            if (diferenciaTransferencia != 0)
                observaciones += $"Transferencia: {diferenciaTransferencia:C}\n";
            if (diferenciaTotalFinal != 0)
                observaciones += $"Total Final: {diferenciaTotalFinal:C}\n";

            // Mostrar el MessageBox con las observaciones
            DialogResult result = MessageBox.Show(observaciones + "\n¿Desea guardar estos resultados?", "Discrepancias en Arqueo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Guardar resultado si el usuario lo confirma
                GuardarResultado(fecha, observaciones, GetMedioDiscrepancia(diferenciaEfectivo, diferenciaDebito, diferenciaCredito, diferenciaTransferencia), diferenciaTotalFinal);
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

        // Usamos una conexión y transacción
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            using (SqlTransaction transaction = connection.BeginTransaction())
            {
                try
                {
                    // Llamamos a las funciones, pasando la conexión y transacción
                    totalEfectivo = ObtenerTotalPorMedioPago(fecha, "Efectivo", connection, transaction);
                    totalDebito = ObtenerTotalPorMedioPago(fecha, "Débito", connection, transaction);
                    totalCredito = ObtenerTotalPorMedioPago(fecha, "Crédito", connection, transaction);
                    totalTransferencia = ObtenerTotalPorMedioPago(fecha, "Transferencia", connection, transaction);
                    totalFinal = ObtenerTotalFinal(fecha, connection, transaction);

                    // Si todo sale bien, confirmamos la transacción
                    transaction.Commit();
                }
                catch
                {
                    // Si ocurre algún error, revertimos la transacción
                    transaction.Rollback();
                    throw;
                }
            }
        }

        // Devolvemos los totales
        return new Tuple<decimal, decimal, decimal, decimal, decimal>(
            totalEfectivo, totalDebito, totalCredito, totalTransferencia, totalFinal
        );
    }



    private string GetMedioDiscrepancia(decimal diferenciaEfectivo, decimal diferenciaDebito, decimal diferenciaCredito, decimal diferenciaTransferencia)
    {
        string medioDiscrepancia = "";

        if (diferenciaEfectivo != 0) medioDiscrepancia += "Efectivo ";
        if (diferenciaDebito != 0) medioDiscrepancia += "Débito ";
        if (diferenciaCredito != 0) medioDiscrepancia += "Crédito ";
        if (diferenciaTransferencia != 0) medioDiscrepancia += "Transferencia ";

        return medioDiscrepancia.Trim();
    }

    private void GuardarResultado(DateTime fecha, string observacion, string medioDiscrepancia, decimal diferencia)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = @"
                INSERT INTO Resultados (fecha, observacion, medioDiscrepancia, diferencia)
                VALUES (@fecha, @observacion, @medioDiscrepancia, @diferencia)";

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@fecha", fecha);
                command.Parameters.AddWithValue("@observacion", observacion);
                command.Parameters.AddWithValue("@medioDiscrepancia", medioDiscrepancia);
                command.Parameters.AddWithValue("@diferencia", diferencia);

                command.ExecuteNonQuery();
            }
        }
    }
}
