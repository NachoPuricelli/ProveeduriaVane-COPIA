using System;
using System.Data;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Font;
using iText.Kernel.Colors;

namespace ProveeduriaVane
{
    internal class GenerarPDF
    {
        public void GenerarReporteCompletoPdf(DateTime fechaInicio, DateTime fechaFin, string rutaArchivo,
            DataTable tablaVentas, DataTable tablaTotales, DataTable tablaArqueos, DataTable tablaManual)
        {
            using (PdfWriter writer = new PdfWriter(rutaArchivo))
            using (PdfDocument pdf = new PdfDocument(writer))
            using (Document documento = new Document(pdf))
            {
                // Agregar encabezado
                documento.Add(new Paragraph("Reporte de Arqueo de Caja")
                    .SetFont(PdfFontFactory.CreateFont())
                    .SetFontSize(16)
                    .SimulateBold());

                documento.Add(new Paragraph($"Fechas: {fechaInicio} - {fechaFin}")
                    .SetFontSize(12));

                documento.Add(new Paragraph("\n")); // Espacio

                // Agregar tablas
                AgregarTablaDesdeDataTable(documento, tablaVentas, "Ventas");
                AgregarTablaDesdeDataTable(documento, tablaTotales, "Totales por Medio de Pago");
                AgregarTablaDesdeDataTable(documento, tablaArqueos, "Resultados Automáticos");
                AgregarTablaDesdeDataTable(documento, tablaManual, "Resultados Manuales");
            }
        }

        private void AgregarTablaDesdeDataTable(Document documento, DataTable tabla, string titulo)
        {
            // Crear tabla
            Table pdfTable = new Table(tabla.Columns.Count).UseAllAvailableWidth();

            // Título de la tabla
            Cell tituloCell = new Cell(1, tabla.Columns.Count)
                .Add(new Paragraph(titulo))
                .SetTextAlignment(TextAlignment.CENTER)
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY);
            pdfTable.AddHeaderCell(tituloCell);

            // Encabezados de columna
            foreach (DataColumn columna in tabla.Columns)
            {
                pdfTable.AddHeaderCell(columna.ColumnName);
            }

            // Filas de datos
            foreach (DataRow fila in tabla.Rows)
            {
                foreach (var item in fila.ItemArray)
                {
                    pdfTable.AddCell(item.ToString());
                }
            }

            documento.Add(pdfTable);
            documento.Add(new Paragraph("\n")); // Espacio entre tablas
        }
    }
}