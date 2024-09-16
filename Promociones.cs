using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProveeduriaVane
{
    public class Promociones
    {
        private string tipo;
        private string descripción;
        private float precio;
        private DateTimePicker inicioPromo;
        private DateTimePicker finalPromo;
        private Button agregarPromocion;
        private DataGridView promocionesPromo;

        public string Tipo { get => tipo; set => tipo = value; }
        public string Descripción { get => descripción; set => descripción = value; }
        public float Precio { get => precio; set => precio = value; }
        public DateTimePicker InicioPromo { get => inicioPromo; set => inicioPromo = value; }
        public DateTimePicker FinalPromo { get => finalPromo; set => finalPromo = value; }
        public Button AgregarPromocion { get => agregarPromocion; set => agregarPromocion = value; }
        public DataGridView PromocionesPromo { get => promocionesPromo; set => promocionesPromo = value; }
    }
}
