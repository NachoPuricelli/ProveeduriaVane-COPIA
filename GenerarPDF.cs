using System;
using System.Data;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ProveeduriaVane
{
    internal class GenerarPDF
    {
        public void GenerarReporteCompletoPdf(DateTime fechaInicio, DateTime fechaFin, string rutaArchivo, DataTable tablaVentas, DataTable tablaTotales, DataTable tablaArqueos, DataTable tablaManual)
        {
            using (FileStream fs = new FileStream(rutaArchivo, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                Document documento = new Document();
                PdfWriter writer = PdfWriter.GetInstance(documento, fs);
                documento.Open();

                // Agregar contenido del PDF
                documento.Add(new Paragraph("Reporte de Arqueo de Caja", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16)));
                documento.Add(new Paragraph($"Fechas: {fechaInicio.ToShortDateString()} - {fechaFin.ToShortDateString()}", FontFactory.GetFont(FontFactory.HELVETICA, 12)));
                documento.Add(new Paragraph("\n")); // Espacio entre el encabezado y las tablas

                // Agregar tablas desde los DataTables
                AgregarTablaDesdeDataTable(documento, tablaVentas, "Ventas");
                documento.Add(new Paragraph("\n")); 
                AgregarTablaDesdeDataTable(documento, tablaTotales, "Totales por Medio de Pago");
                documento.Add(new Paragraph("\n")); 
                AgregarTablaDesdeDataTable(documento, tablaArqueos, "Resultados Automáticos");
                documento.Add(new Paragraph("\n")); 
                AgregarTablaDesdeDataTable(documento, tablaManual, "Resultados Manuales");

                documento.Close();
            }
        }

        private void AgregarTablaDesdeDataTable(Document documento, DataTable tabla, string titulo)
        {
            PdfPTable pdfTable = new PdfPTable(tabla.Columns.Count);
            pdfTable.WidthPercentage = 100;

            PdfPCell tituloCelda = new PdfPCell(new Phrase(titulo, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14)))
            {
                Colspan = tabla.Columns.Count,
                HorizontalAlignment = Element.ALIGN_CENTER,
                BackgroundColor = BaseColor.LIGHT_GRAY
            };
            pdfTable.AddCell(tituloCelda);

            // Agregar encabezados de columna
            foreach (DataColumn columna in tabla.Columns)
            {
                pdfTable.AddCell(columna.ColumnName);
            }

            // Agregar filas
            foreach (DataRow fila in tabla.Rows)
            {
                foreach (var item in fila.ItemArray)
                {
                    pdfTable.AddCell(item.ToString());
                }
            }

            documento.Add(pdfTable);
        }
    }
}
