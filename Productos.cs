using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProveeduriaVane
{
    public class Productos
    {
        ////Atributos
        private String busqueda = "";
        private String filtros = "";
        private Button desbloqueo;
        private Button agregar;
        private Button borrar;
        private Button editar;
        private Button aumentar;
        private String dataGrid = "";
        private String mensajeAumento;

        public string Busqueda { get => busqueda; set => busqueda = value; }
        public string Filtros { get => filtros; set => filtros = value; }
        public Button Desbloqueo { get => desbloqueo; set => desbloqueo = value; }
        public Button Agregar { get => agregar; set => agregar = value; }
        public Button Borrar { get => borrar; set => borrar = value; }
        public Button Editar { get => editar; set => editar = value; }
        public Button Aumentar { get => aumentar; set => aumentar = value; }
        public string DataGrid { get => dataGrid; set => dataGrid = value; }

        public string MensajeAumento { get => mensajeAumento; set => mensajeAumento = value; }



        public Productos() { }
        ////Métodos
        public Productos(String busquedaProductos, String filtrosProductos, Button desbloqueoProductos, Button agregarProductos,
            Button borrarProductos, Button editarProductos, Button aumentarProductos, String dataGridProductos)
        {
            Busqueda = busquedaProductos;
            Filtros = filtrosProductos;
            Agregar = agregarProductos;
            Borrar = borrarProductos;
            Editar = editarProductos;
            Aumentar = aumentarProductos;
            DataGrid = dataGridProductos;
        }
        public void desbloquear(Button agregarProductos, Button borrarProductos, Button editarProductos, Button aumentarProductos) 
        {
            agregarProductos.Visible = true;
            borrarProductos.Visible = true;
            editarProductos.Visible = true;
            aumentarProductos.Visible = true;

        }

        public void bloqueo(Button botones)
        {
            botones.Visible = false;
        }

        public void mostrar(MaterialCard card)
        {
            if (!card.Visible)
            {
                card.Visible = true;
            }
            card.BringToFront();
            
        }

    }
}
