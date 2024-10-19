using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace ProveeduriaVane
{
    public partial class ElegirPromociones : MaterialForm
    {
        Promociones verPromo = new Promociones();

        private System.Windows.Forms.CheckBox chkHeader = new System.Windows.Forms.CheckBox();
        public ElegirPromociones()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue100, Accent.Pink700, TextShade.WHITE);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void configurarPromociones()
        {
            // Limpiar las columnas actuales si ya están definidas
            dgvElegirPromo.Columns.Clear();

            // Agregar columna de checkboxes
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Name = "Seleccionar";
            dgvElegirPromo.Columns.Add(checkBoxColumn);

            // Configurar el CheckBox en el encabezado
            chkHeader.Size = new System.Drawing.Size(15, 15); // Tamaño del CheckBox
            chkHeader.BackColor = Color.Transparent;

            // Evento para seleccionar/deseleccionar todas las filas
            chkHeader.CheckedChanged += new EventHandler(chkHeader_CheckedChanged);

            // Agregar el CheckBox al control del DataGridView
            dgvElegirPromo.Controls.Add(chkHeader);

            // Ajustar la posición del CheckBox en el encabezado
            dgvElegirPromo.Paint += new PaintEventHandler(dgvElegirPromo_Paint);
            dgvElegirPromo.Columns.Add("descripcion", "DESCRIPCIÓN");
            dgvElegirPromo.Columns.Add("tipoPromo", "TIPO PROMO");
            dgvElegirPromo.Columns.Add("precioEspecial", "PRECIO ESPECIAL");
        }

        private void ElegirPromociones_Load(object sender, EventArgs e)
        {
            configurarPromociones();
            llenarDataPromos();
        }
        private void chkHeader_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.CheckBox headerBox = (System.Windows.Forms.CheckBox)sender;

            // Recorre todas las filas del DataGridView
            foreach (DataGridViewRow row in dgvElegirPromo.Rows)
            {
                // Marca o desmarca las celdas de tipo CheckBox de acuerdo al estado del CheckBox del header
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)row.Cells["Seleccionar"];
                checkBoxCell.Value = headerBox.Checked;
            }

            // Refrescar la visualización del DataGridView
            dgvElegirPromo.RefreshEdit();
        }

        // Evento para ajustar la posición del CheckBox en el encabezado cuando se redibuja el DataGridView
        private void dgvElegirPromo_Paint(object sender, PaintEventArgs e)
        {
            // Obtener la ubicación del encabezado de la columna "Seleccionar"
            Rectangle rect = dgvElegirPromo.GetCellDisplayRectangle(dgvElegirPromo.Columns["Seleccionar"].Index, -1, true);

            // Ajustar la posición del CheckBox dentro del encabezado
            chkHeader.Location = new System.Drawing.Point(rect.Location.X + (rect.Width / 2) - (chkHeader.Width / 2), rect.Location.Y + (rect.Height / 2) - (chkHeader.Height / 2));
        }

        private void llenarDataPromos()
        {
            DataTable dtPromos = verPromo.ElegirPromo();

            foreach (DataRow row in dtPromos.Rows)
            {
                dgvElegirPromo.Rows.Add(false, row["descripcion"], row["tipoPromo"], row["precioEspecial"]);
            }
        }

        public void insertarPromo()
        {

        }
    }
}
