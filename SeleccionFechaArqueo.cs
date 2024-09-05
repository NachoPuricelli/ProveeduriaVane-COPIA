using System;
using System.Windows.Forms;

namespace ProveeduriaVane
{
    public class SeleccionFechaArqueo
    {
        private MonthCalendar monthCalendar;
        private Button mbtnFechaInicio;
        private Button mbtnFechaFin;
        private Form parentForm;

        // Constructor que recibe dos botones y el formulario
        public SeleccionFechaArqueo(Button botonFechaInicio, Button botonFechaFin, Form form)
        {
            mbtnFechaInicio = botonFechaInicio;
            mbtnFechaFin = botonFechaFin;
            parentForm = form;

            // Inicializar el MonthCalendar con un solo mes
            monthCalendar = new MonthCalendar
            {
                MaxSelectionCount = 1 // Solo se selecciona una fecha
            };
            monthCalendar.DateSelected += new DateRangeEventHandler(Calendar_DateSelected);

            // Asignar eventos de clic a los botones
            mbtnFechaInicio.Click += new EventHandler(Button_Click);
            mbtnFechaFin.Click += new EventHandler(Button_Click);
        }

        // Mostrar el calendario al hacer clic en los botones
        private void Button_Click(object sender, EventArgs e)
        {
            var button = sender as Button;

            // Posicionar el MonthCalendar justo debajo del botón
            var buttonLocation = button.PointToScreen(new System.Drawing.Point(0, 0));
            var calendarLocation = parentForm.PointToClient(new System.Drawing.Point(buttonLocation.X, buttonLocation.Y + button.Height));

            // Ajustar el tamaño del MonthCalendar
            monthCalendar.Size = new System.Drawing.Size(button.Width, 180); // Ajusta la altura si es necesario

            // Ajustar la ubicación del MonthCalendar
            monthCalendar.Location = new System.Drawing.Point(calendarLocation.X  + 35, calendarLocation.Y + 2); // Ajustar la posición vertical si es necesario

            // Asegúrate de que el MonthCalendar esté visible
            if (!parentForm.Controls.Contains(monthCalendar))
            {
                parentForm.Controls.Add(monthCalendar);
            }
            monthCalendar.BringToFront();
        }

        // Selección de la fecha y ocultar el calendario
        private void Calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            var button = mbtnFechaInicio.Focused ? mbtnFechaInicio : mbtnFechaFin;
            button.Text = e.Start.ToShortDateString();
            monthCalendar.Visible = false;
        }
    }
}
