using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProveeduriaVane
{
    public class Arqueo
    {
        //Atributos
        private ComboBox fechaInicial;
        private ComboBox fechaFinal;
        private DateTimePicker inicial;
        private DateTimePicker final;
        private ComboBox seccion;
        private MaterialCard pin;

        public ComboBox FechaInicial { get => fechaInicial; set => fechaInicial = value; }
        public ComboBox FechaFinal { get => fechaFinal; set => fechaFinal = value; }
        public DateTimePicker Inicial { get => inicial; set => inicial = value; }
        public DateTimePicker Final { get => final; set => final = value; }
        public ComboBox Seccion { get => seccion; set => seccion = value; }
        public MaterialCard Pin { get => pin; set => pin = value; }

        public Arqueo() {}
    //Métodos
    public Arqueo(ComboBox fechaDeInicio, ComboBox fechaDeFin, DateTimePicker inicio, DateTimePicker fin, ComboBox secciones, MaterialCard pines) 
        {
            FechaInicial = fechaDeInicio;
            FechaFinal = fechaDeFin;
            Inicial = inicio;
            final = fin;
            Seccion = secciones;
            Pin = pines;
        }

        public void visibles(DateTimePicker primerFecha, DateTimePicker segundaFecha)
        {
            primerFecha.Visible = true;
            segundaFecha.Visible = false;
        }

       

        



    }
}
//VENTAS: dgvArqueo, Calendario 1y2
//Totales: dgvMedioPago, pbMedioPago
//Resumen: dgvResumen, pbResumenFinal