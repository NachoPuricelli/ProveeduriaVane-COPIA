namespace ProveeduriaVane
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            interfazPrincipal = new MaterialSkin.Controls.MaterialTabControl();
            tabVentas = new TabPage();
            tlVentas = new TableLayoutPanel();
            btnAgregarDevolucion = new MaterialSkin.Controls.MaterialButton();
            dgvVentas = new DataGridView();
            btnAjustarCaja = new MaterialSkin.Controls.MaterialButton();
            btnReiniciarLista = new MaterialSkin.Controls.MaterialButton();
            tlMediosPago = new TableLayoutPanel();
            rbCredito = new RadioButton();
            rbTrasferencia = new RadioButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTotal = new Label();
            lblSaldo = new Label();
            rbEfectivo = new RadioButton();
            rbDebito = new RadioButton();
            tabProductos = new TabPage();
            tlProductos = new TableLayoutPanel();
            dgvProductos = new DataGridView();
            dataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnBorrarProducto = new MaterialSkin.Controls.MaterialButton();
            btnAgregarProducto = new MaterialSkin.Controls.MaterialButton();
            cbFiltros = new ComboBox();
            txtFiltros = new TextBox();
            panel1 = new Panel();
            btnEditarProductos = new MaterialSkin.Controls.MaterialButton();
            btnAumentarProducto = new MaterialSkin.Controls.MaterialButton();
            btnDesbloquearEdicion = new MaterialSkin.Controls.MaterialButton();
            tabArqueo = new TabPage();
            calendarioFechaFinal = new DateTimePicker();
            calendarioFechaInicial = new DateTimePicker();
            dgvArqueo = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            MediosDePago = new DataGridViewTextBoxColumn();
            Productos = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            tableLayoutPanel4 = new TableLayoutPanel();
            dgvMedioPago = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            dgvResumenFinal = new DataGridView();
            Column1ResumenFinal = new DataGridViewTextBoxColumn();
            pbMedioPago = new PictureBox();
            pbResumenFinal = new PictureBox();
            tlDescargarPDF = new TableLayoutPanel();
            btnDescargarPDF = new MaterialSkin.Controls.MaterialButton();
            tlFechas = new TableLayoutPanel();
            cbFechaInicial = new ComboBox();
            cbSeccion = new ComboBox();
            cbFechaFinal = new ComboBox();
            tabPromociones = new TabPage();
            tlPromociones = new TableLayoutPanel();
            gbPromociones = new GroupBox();
            dtpFechaFin = new DateTimePicker();
            dtpFechaInicio = new DateTimePicker();
            textBox3 = new TextBox();
            btnEscanearPromocion = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lblFechaFin = new Label();
            lblFechaInicio = new Label();
            lblPrecioEspecial = new Label();
            lblDescripcionPromo = new Label();
            lblTipo = new Label();
            dgvPromociones = new DataGridView();
            interfazPrincipal.SuspendLayout();
            tabVentas.SuspendLayout();
            tlVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            tlMediosPago.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabProductos.SuspendLayout();
            tlProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            tabArqueo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArqueo).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMedioPago).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResumenFinal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMedioPago).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbResumenFinal).BeginInit();
            tlDescargarPDF.SuspendLayout();
            tlFechas.SuspendLayout();
            tabPromociones.SuspendLayout();
            tlPromociones.SuspendLayout();
            gbPromociones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPromociones).BeginInit();
            SuspendLayout();
            // 
            // interfazPrincipal
            // 
            interfazPrincipal.Controls.Add(tabVentas);
            interfazPrincipal.Controls.Add(tabProductos);
            interfazPrincipal.Controls.Add(tabArqueo);
            interfazPrincipal.Controls.Add(tabPromociones);
            interfazPrincipal.Depth = 0;
            interfazPrincipal.Dock = DockStyle.Fill;
            interfazPrincipal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            interfazPrincipal.ItemSize = new Size(48, 35);
            interfazPrincipal.Location = new Point(3, 64);
            interfazPrincipal.MouseState = MaterialSkin.MouseState.HOVER;
            interfazPrincipal.Multiline = true;
            interfazPrincipal.Name = "interfazPrincipal";
            interfazPrincipal.SelectedIndex = 0;
            interfazPrincipal.Size = new Size(938, 584);
            interfazPrincipal.TabIndex = 0;
            // 
            // tabVentas
            // 
            tabVentas.Controls.Add(tlVentas);
            tabVentas.Location = new Point(4, 39);
            tabVentas.Name = "tabVentas";
            tabVentas.Padding = new Padding(3);
            tabVentas.Size = new Size(930, 541);
            tabVentas.TabIndex = 0;
            tabVentas.Text = "Ventas";
            tabVentas.UseVisualStyleBackColor = true;
            // 
            // tlVentas
            // 
            tlVentas.ColumnCount = 5;
            tlVentas.ColumnStyles.Add(new ColumnStyle());
            tlVentas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0348663F));
            tlVentas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.5495129F));
            tlVentas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.3807545F));
            tlVentas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0348663F));
            tlVentas.Controls.Add(btnAgregarDevolucion, 3, 0);
            tlVentas.Controls.Add(dgvVentas, 0, 1);
            tlVentas.Controls.Add(btnAjustarCaja, 4, 0);
            tlVentas.Controls.Add(btnReiniciarLista, 0, 0);
            tlVentas.Controls.Add(tlMediosPago, 0, 2);
            tlVentas.Dock = DockStyle.Fill;
            tlVentas.Location = new Point(3, 3);
            tlVentas.Name = "tlVentas";
            tlVentas.RowCount = 3;
            tlVentas.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tlVentas.RowStyles.Add(new RowStyle(SizeType.Percent, 84F));
            tlVentas.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tlVentas.Size = new Size(924, 535);
            tlVentas.TabIndex = 0;
            // 
            // btnAgregarDevolucion
            // 
            btnAgregarDevolucion.AutoSize = false;
            btnAgregarDevolucion.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAgregarDevolucion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAgregarDevolucion.Depth = 0;
            btnAgregarDevolucion.Dock = DockStyle.Fill;
            btnAgregarDevolucion.HighEmphasis = true;
            btnAgregarDevolucion.Icon = null;
            btnAgregarDevolucion.Location = new Point(522, 6);
            btnAgregarDevolucion.Margin = new Padding(4, 6, 4, 6);
            btnAgregarDevolucion.MouseState = MaterialSkin.MouseState.HOVER;
            btnAgregarDevolucion.Name = "btnAgregarDevolucion";
            btnAgregarDevolucion.NoAccentTextColor = Color.Empty;
            btnAgregarDevolucion.Size = new Size(217, 30);
            btnAgregarDevolucion.TabIndex = 15;
            btnAgregarDevolucion.Text = "Agregar una devolución";
            btnAgregarDevolucion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAgregarDevolucion.UseAccentColor = false;
            btnAgregarDevolucion.UseVisualStyleBackColor = true;
            btnAgregarDevolucion.Click += btnAgregarDevolucion_Click;
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToOrderColumns = true;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tlVentas.SetColumnSpan(dgvVentas, 5);
            dgvVentas.Dock = DockStyle.Fill;
            dgvVentas.Location = new Point(3, 45);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.Size = new Size(918, 443);
            dgvVentas.TabIndex = 17;
            // 
            // btnAjustarCaja
            // 
            btnAjustarCaja.AutoSize = false;
            btnAjustarCaja.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAjustarCaja.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAjustarCaja.Depth = 0;
            btnAjustarCaja.Dock = DockStyle.Fill;
            btnAjustarCaja.HighEmphasis = true;
            btnAjustarCaja.Icon = null;
            btnAjustarCaja.Location = new Point(747, 6);
            btnAjustarCaja.Margin = new Padding(4, 6, 4, 6);
            btnAjustarCaja.MouseState = MaterialSkin.MouseState.HOVER;
            btnAjustarCaja.Name = "btnAjustarCaja";
            btnAjustarCaja.NoAccentTextColor = Color.Empty;
            btnAjustarCaja.Size = new Size(173, 30);
            btnAjustarCaja.TabIndex = 16;
            btnAjustarCaja.Text = "Ajustar caja";
            btnAjustarCaja.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAjustarCaja.UseAccentColor = false;
            btnAjustarCaja.UseVisualStyleBackColor = true;
            btnAjustarCaja.Click += btnAjustarCaja_Click_1;
            // 
            // btnReiniciarLista
            // 
            btnReiniciarLista.AutoSize = false;
            btnReiniciarLista.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnReiniciarLista.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnReiniciarLista.Depth = 0;
            btnReiniciarLista.Dock = DockStyle.Fill;
            btnReiniciarLista.HighEmphasis = true;
            btnReiniciarLista.Icon = null;
            btnReiniciarLista.Location = new Point(4, 6);
            btnReiniciarLista.Margin = new Padding(4, 6, 4, 6);
            btnReiniciarLista.MouseState = MaterialSkin.MouseState.HOVER;
            btnReiniciarLista.Name = "btnReiniciarLista";
            btnReiniciarLista.NoAccentTextColor = Color.Empty;
            btnReiniciarLista.Size = new Size(198, 30);
            btnReiniciarLista.TabIndex = 4;
            btnReiniciarLista.Text = "Reiniciar lista";
            btnReiniciarLista.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnReiniciarLista.UseAccentColor = false;
            btnReiniciarLista.UseVisualStyleBackColor = true;
            // 
            // tlMediosPago
            // 
            tlMediosPago.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlMediosPago.AutoSize = true;
            tlMediosPago.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlMediosPago.ColumnCount = 6;
            tlVentas.SetColumnSpan(tlMediosPago, 5);
            tlMediosPago.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.4793F));
            tlMediosPago.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.6361666F));
            tlMediosPago.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.4575176F));
            tlMediosPago.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.3289766F));
            tlMediosPago.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.9738579F));
            tlMediosPago.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.1241875F));
            tlMediosPago.Controls.Add(rbCredito, 3, 0);
            tlMediosPago.Controls.Add(rbTrasferencia, 4, 0);
            tlMediosPago.Controls.Add(tableLayoutPanel1, 0, 0);
            tlMediosPago.Controls.Add(rbEfectivo, 1, 0);
            tlMediosPago.Controls.Add(rbDebito, 2, 0);
            tlMediosPago.Location = new Point(3, 494);
            tlMediosPago.Name = "tlMediosPago";
            tlMediosPago.RowCount = 1;
            tlMediosPago.RowStyles.Add(new RowStyle());
            tlMediosPago.Size = new Size(918, 38);
            tlMediosPago.TabIndex = 18;
            // 
            // rbCredito
            // 
            rbCredito.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rbCredito.AutoSize = true;
            rbCredito.BackColor = Color.Blue;
            rbCredito.CheckAlign = ContentAlignment.MiddleRight;
            rbCredito.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbCredito.ForeColor = Color.White;
            rbCredito.Location = new Point(402, 3);
            rbCredito.Name = "rbCredito";
            rbCredito.Padding = new Padding(0, 0, 4, 4);
            rbCredito.Size = new Size(98, 53);
            rbCredito.TabIndex = 33;
            rbCredito.TabStop = true;
            rbCredito.Text = "CRÉDITO";
            rbCredito.TextAlign = ContentAlignment.MiddleCenter;
            rbCredito.UseVisualStyleBackColor = false;
            // 
            // rbTrasferencia
            // 
            rbTrasferencia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rbTrasferencia.AutoSize = true;
            rbTrasferencia.BackColor = Color.Blue;
            rbTrasferencia.CheckAlign = ContentAlignment.MiddleRight;
            rbTrasferencia.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbTrasferencia.ForeColor = Color.White;
            rbTrasferencia.Location = new Point(506, 3);
            rbTrasferencia.Name = "rbTrasferencia";
            rbTrasferencia.Padding = new Padding(0, 0, 4, 4);
            rbTrasferencia.Size = new Size(159, 53);
            rbTrasferencia.TabIndex = 35;
            rbTrasferencia.TabStop = true;
            rbTrasferencia.Text = "TRANSFERENCIA";
            rbTrasferencia.TextAlign = ContentAlignment.MiddleCenter;
            rbTrasferencia.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63F));
            tableLayoutPanel1.Controls.Add(lblTotal, 0, 0);
            tableLayoutPanel1.Controls.Add(lblSaldo, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(181, 53);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Blue;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(3, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Padding = new Padding(0, 0, 0, 4);
            lblTotal.Size = new Size(60, 53);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "TOTAL:";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSaldo
            // 
            lblSaldo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSaldo.AutoSize = true;
            lblSaldo.BackColor = Color.Blue;
            lblSaldo.BorderStyle = BorderStyle.FixedSingle;
            lblSaldo.ForeColor = Color.White;
            lblSaldo.Location = new Point(69, 0);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Padding = new Padding(0, 0, 0, 4);
            lblSaldo.Size = new Size(109, 53);
            lblSaldo.TabIndex = 14;
            lblSaldo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rbEfectivo
            // 
            rbEfectivo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rbEfectivo.AutoSize = true;
            rbEfectivo.BackColor = Color.Blue;
            rbEfectivo.CheckAlign = ContentAlignment.MiddleRight;
            rbEfectivo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbEfectivo.ForeColor = Color.White;
            rbEfectivo.Location = new Point(190, 3);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Padding = new Padding(0, 0, 4, 4);
            rbEfectivo.Size = new Size(110, 53);
            rbEfectivo.TabIndex = 32;
            rbEfectivo.TabStop = true;
            rbEfectivo.Text = "EFECTIVO";
            rbEfectivo.TextAlign = ContentAlignment.MiddleCenter;
            rbEfectivo.UseVisualStyleBackColor = false;
            // 
            // rbDebito
            // 
            rbDebito.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rbDebito.AutoSize = true;
            rbDebito.BackColor = Color.Blue;
            rbDebito.CheckAlign = ContentAlignment.MiddleRight;
            rbDebito.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbDebito.ForeColor = Color.White;
            rbDebito.Location = new Point(306, 3);
            rbDebito.Name = "rbDebito";
            rbDebito.Padding = new Padding(0, 0, 4, 4);
            rbDebito.Size = new Size(90, 53);
            rbDebito.TabIndex = 34;
            rbDebito.TabStop = true;
            rbDebito.Text = "DÉBITO";
            rbDebito.TextAlign = ContentAlignment.MiddleCenter;
            rbDebito.UseVisualStyleBackColor = false;
            // 
            // tabProductos
            // 
            tabProductos.Controls.Add(tlProductos);
            tabProductos.Location = new Point(4, 39);
            tabProductos.Name = "tabProductos";
            tabProductos.Padding = new Padding(3);
            tabProductos.Size = new Size(930, 541);
            tabProductos.TabIndex = 1;
            tabProductos.Text = "Productos";
            tabProductos.UseVisualStyleBackColor = true;
            // 
            // tlProductos
            // 
            tlProductos.ColumnCount = 7;
            tlProductos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857113F));
            tlProductos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tlProductos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tlProductos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tlProductos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tlProductos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tlProductos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tlProductos.Controls.Add(dgvProductos, 0, 1);
            tlProductos.Controls.Add(tableLayoutPanel2, 0, 0);
            tlProductos.Dock = DockStyle.Fill;
            tlProductos.Location = new Point(3, 3);
            tlProductos.Name = "tlProductos";
            tlProductos.RowCount = 1;
            tlProductos.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tlProductos.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tlProductos.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tlProductos.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tlProductos.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tlProductos.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tlProductos.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tlProductos.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tlProductos.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tlProductos.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tlProductos.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tlProductos.Size = new Size(924, 535);
            tlProductos.TabIndex = 0;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewCheckBoxColumn1, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, Tipo, Marca, dataGridViewTextBoxColumn4 });
            tlProductos.SetColumnSpan(dgvProductos, 7);
            dgvProductos.Dock = DockStyle.Fill;
            dgvProductos.Location = new Point(3, 51);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            tlProductos.SetRowSpan(dgvProductos, 10);
            dgvProductos.Size = new Size(918, 481);
            dgvProductos.TabIndex = 27;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            dataGridViewCheckBoxColumn1.FillWeight = 45.68528F;
            dataGridViewCheckBoxColumn1.HeaderText = "";
            dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            dataGridViewCheckBoxColumn1.Resizable = DataGridViewTriState.True;
            dataGridViewCheckBoxColumn1.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewTextBoxColumn1.FillWeight = 110.862938F;
            dataGridViewTextBoxColumn1.HeaderText = "CÓDIGO";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewTextBoxColumn2.FillWeight = 110.862938F;
            dataGridViewTextBoxColumn2.HeaderText = "DESCRIPCIÓN";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Tipo
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Tipo.DefaultCellStyle = dataGridViewCellStyle6;
            Tipo.FillWeight = 110.862938F;
            Tipo.HeaderText = "TIPO";
            Tipo.MinimumWidth = 6;
            Tipo.Name = "Tipo";
            // 
            // Marca
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Marca.DefaultCellStyle = dataGridViewCellStyle7;
            Marca.FillWeight = 110.862938F;
            Marca.HeaderText = "MARCA";
            Marca.MinimumWidth = 6;
            Marca.Name = "Marca";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewTextBoxColumn4.FillWeight = 110.862938F;
            dataGridViewTextBoxColumn4.HeaderText = "PRECIO UNITARIO";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tlProductos.SetColumnSpan(tableLayoutPanel2, 7);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel2.Controls.Add(btnBorrarProducto, 3, 0);
            tableLayoutPanel2.Controls.Add(btnAgregarProducto, 2, 0);
            tableLayoutPanel2.Controls.Add(cbFiltros, 1, 0);
            tableLayoutPanel2.Controls.Add(txtFiltros, 0, 0);
            tableLayoutPanel2.Controls.Add(panel1, 4, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(918, 42);
            tableLayoutPanel2.TabIndex = 28;
            // 
            // btnBorrarProducto
            // 
            btnBorrarProducto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBorrarProducto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnBorrarProducto.Depth = 0;
            btnBorrarProducto.Dock = DockStyle.Fill;
            btnBorrarProducto.HighEmphasis = true;
            btnBorrarProducto.Icon = null;
            btnBorrarProducto.Location = new Point(463, 6);
            btnBorrarProducto.Margin = new Padding(4, 6, 4, 6);
            btnBorrarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            btnBorrarProducto.Name = "btnBorrarProducto";
            btnBorrarProducto.NoAccentTextColor = Color.Empty;
            btnBorrarProducto.Size = new Size(145, 30);
            btnBorrarProducto.TabIndex = 31;
            btnBorrarProducto.Text = "Borrar";
            btnBorrarProducto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnBorrarProducto.UseAccentColor = false;
            btnBorrarProducto.UseVisualStyleBackColor = true;
            btnBorrarProducto.Visible = false;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAgregarProducto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAgregarProducto.Depth = 0;
            btnAgregarProducto.Dock = DockStyle.Fill;
            btnAgregarProducto.HighEmphasis = true;
            btnAgregarProducto.Icon = null;
            btnAgregarProducto.Location = new Point(310, 6);
            btnAgregarProducto.Margin = new Padding(4, 6, 4, 6);
            btnAgregarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.NoAccentTextColor = Color.Empty;
            btnAgregarProducto.Size = new Size(145, 30);
            btnAgregarProducto.TabIndex = 30;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAgregarProducto.UseAccentColor = false;
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Visible = false;
            // 
            // cbFiltros
            // 
            cbFiltros.BackColor = Color.Blue;
            cbFiltros.FlatStyle = FlatStyle.Popup;
            cbFiltros.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbFiltros.ForeColor = SystemColors.Info;
            cbFiltros.FormattingEnabled = true;
            cbFiltros.Items.AddRange(new object[] { "Tipo", "Marca", "Descripción" });
            cbFiltros.Location = new Point(156, 7);
            cbFiltros.Margin = new Padding(3, 7, 3, 3);
            cbFiltros.Name = "cbFiltros";
            cbFiltros.Size = new Size(116, 28);
            cbFiltros.TabIndex = 29;
            cbFiltros.Text = "Filtros";
            // 
            // txtFiltros
            // 
            txtFiltros.BackColor = Color.Blue;
            txtFiltros.BorderStyle = BorderStyle.FixedSingle;
            txtFiltros.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFiltros.ForeColor = SystemColors.Info;
            txtFiltros.Location = new Point(3, 7);
            txtFiltros.Margin = new Padding(3, 7, 3, 3);
            txtFiltros.Multiline = true;
            txtFiltros.Name = "txtFiltros";
            txtFiltros.Size = new Size(147, 28);
            txtFiltros.TabIndex = 28;
            txtFiltros.Text = "Búsqueda";
            // 
            // panel1
            // 
            tableLayoutPanel2.SetColumnSpan(panel1, 2);
            panel1.Controls.Add(btnEditarProductos);
            panel1.Controls.Add(btnAumentarProducto);
            panel1.Controls.Add(btnDesbloquearEdicion);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(615, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 36);
            panel1.TabIndex = 32;
            // 
            // btnEditarProductos
            // 
            btnEditarProductos.AutoSize = false;
            btnEditarProductos.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditarProductos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditarProductos.Depth = 0;
            btnEditarProductos.HighEmphasis = true;
            btnEditarProductos.Icon = null;
            btnEditarProductos.Location = new Point(1, 4);
            btnEditarProductos.Margin = new Padding(4, 6, 4, 6);
            btnEditarProductos.MouseState = MaterialSkin.MouseState.HOVER;
            btnEditarProductos.Name = "btnEditarProductos";
            btnEditarProductos.NoAccentTextColor = Color.Empty;
            btnEditarProductos.Size = new Size(140, 30);
            btnEditarProductos.TabIndex = 32;
            btnEditarProductos.Text = "Editar";
            btnEditarProductos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditarProductos.UseAccentColor = false;
            btnEditarProductos.UseVisualStyleBackColor = true;
            btnEditarProductos.Visible = false;
            // 
            // btnAumentarProducto
            // 
            btnAumentarProducto.AutoSize = false;
            btnAumentarProducto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAumentarProducto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAumentarProducto.Depth = 0;
            btnAumentarProducto.HighEmphasis = true;
            btnAumentarProducto.Icon = null;
            btnAumentarProducto.Location = new Point(148, 4);
            btnAumentarProducto.Margin = new Padding(4, 6, 4, 6);
            btnAumentarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            btnAumentarProducto.Name = "btnAumentarProducto";
            btnAumentarProducto.NoAccentTextColor = Color.Empty;
            btnAumentarProducto.Size = new Size(152, 30);
            btnAumentarProducto.TabIndex = 33;
            btnAumentarProducto.Text = "Aumentar";
            btnAumentarProducto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAumentarProducto.UseAccentColor = false;
            btnAumentarProducto.UseVisualStyleBackColor = true;
            btnAumentarProducto.Visible = false;
            // 
            // btnDesbloquearEdicion
            // 
            btnDesbloquearEdicion.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDesbloquearEdicion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDesbloquearEdicion.Depth = 0;
            btnDesbloquearEdicion.Dock = DockStyle.Right;
            btnDesbloquearEdicion.HighEmphasis = true;
            btnDesbloquearEdicion.Icon = null;
            btnDesbloquearEdicion.Location = new Point(70, 0);
            btnDesbloquearEdicion.Margin = new Padding(4, 6, 4, 6);
            btnDesbloquearEdicion.MouseState = MaterialSkin.MouseState.HOVER;
            btnDesbloquearEdicion.Name = "btnDesbloquearEdicion";
            btnDesbloquearEdicion.NoAccentTextColor = Color.Empty;
            btnDesbloquearEdicion.Size = new Size(230, 36);
            btnDesbloquearEdicion.TabIndex = 26;
            btnDesbloquearEdicion.Text = "Desbloquear modo edición";
            btnDesbloquearEdicion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDesbloquearEdicion.UseAccentColor = false;
            btnDesbloquearEdicion.UseVisualStyleBackColor = true;
            // 
            // tabArqueo
            // 
            tabArqueo.Controls.Add(calendarioFechaFinal);
            tabArqueo.Controls.Add(calendarioFechaInicial);
            tabArqueo.Controls.Add(dgvArqueo);
            tabArqueo.Controls.Add(tableLayoutPanel4);
            tabArqueo.Controls.Add(tableLayoutPanel3);
            tabArqueo.Controls.Add(pbMedioPago);
            tabArqueo.Controls.Add(pbResumenFinal);
            tabArqueo.Controls.Add(tlDescargarPDF);
            tabArqueo.Controls.Add(tlFechas);
            tabArqueo.Location = new Point(4, 39);
            tabArqueo.Name = "tabArqueo";
            tabArqueo.Padding = new Padding(3);
            tabArqueo.Size = new Size(930, 541);
            tabArqueo.TabIndex = 2;
            tabArqueo.Text = "Arqueo de Caja";
            tabArqueo.UseVisualStyleBackColor = true;
            // 
            // calendarioFechaFinal
            // 
            calendarioFechaFinal.Location = new Point(133, 38);
            calendarioFechaFinal.Name = "calendarioFechaFinal";
            calendarioFechaFinal.Size = new Size(200, 23);
            calendarioFechaFinal.TabIndex = 31;
            // 
            // calendarioFechaInicial
            // 
            calendarioFechaInicial.Location = new Point(6, 38);
            calendarioFechaInicial.Name = "calendarioFechaInicial";
            calendarioFechaInicial.Size = new Size(200, 23);
            calendarioFechaInicial.TabIndex = 30;
            // 
            // dgvArqueo
            // 
            dgvArqueo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvArqueo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvArqueo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvArqueo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArqueo.Columns.AddRange(new DataGridViewColumn[] { Fecha, MediosDePago, Productos, Total });
            dgvArqueo.Dock = DockStyle.Fill;
            dgvArqueo.Location = new Point(3, 38);
            dgvArqueo.Name = "dgvArqueo";
            dgvArqueo.RowHeadersWidth = 51;
            dgvArqueo.Size = new Size(924, 456);
            dgvArqueo.TabIndex = 18;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "FECHA";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            // 
            // MediosDePago
            // 
            MediosDePago.HeaderText = "MEDIOS DE PAGO";
            MediosDePago.MinimumWidth = 6;
            MediosDePago.Name = "MediosDePago";
            // 
            // Productos
            // 
            Productos.HeaderText = "PRODUCTOS";
            Productos.MinimumWidth = 6;
            Productos.Name = "Productos";
            // 
            // Total
            // 
            Total.HeaderText = "TOTAL";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(dgvMedioPago, 0, 0);
            tableLayoutPanel4.Location = new Point(28, 181);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(393, 208);
            tableLayoutPanel4.TabIndex = 27;
            // 
            // dgvMedioPago
            // 
            dgvMedioPago.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedioPago.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMedioPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedioPago.Dock = DockStyle.Fill;
            dgvMedioPago.Location = new Point(3, 3);
            dgvMedioPago.Name = "dgvMedioPago";
            dgvMedioPago.RowHeadersWidth = 51;
            dgvMedioPago.Size = new Size(387, 202);
            dgvMedioPago.TabIndex = 22;
            dgvMedioPago.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(dgvResumenFinal, 0, 0);
            tableLayoutPanel3.Location = new Point(74, 135);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(309, 222);
            tableLayoutPanel3.TabIndex = 26;
            // 
            // dgvResumenFinal
            // 
            dgvResumenFinal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResumenFinal.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvResumenFinal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResumenFinal.Columns.AddRange(new DataGridViewColumn[] { Column1ResumenFinal });
            dgvResumenFinal.Dock = DockStyle.Fill;
            dgvResumenFinal.Location = new Point(3, 3);
            dgvResumenFinal.Name = "dgvResumenFinal";
            dgvResumenFinal.RowHeadersWidth = 51;
            dgvResumenFinal.Size = new Size(303, 216);
            dgvResumenFinal.TabIndex = 25;
            dgvResumenFinal.Visible = false;
            // 
            // Column1ResumenFinal
            // 
            Column1ResumenFinal.HeaderText = "";
            Column1ResumenFinal.MinimumWidth = 6;
            Column1ResumenFinal.Name = "Column1ResumenFinal";
            // 
            // pbMedioPago
            // 
            pbMedioPago.Location = new Point(533, 158);
            pbMedioPago.Name = "pbMedioPago";
            pbMedioPago.Size = new Size(202, 180);
            pbMedioPago.TabIndex = 24;
            pbMedioPago.TabStop = false;
            pbMedioPago.Visible = false;
            // 
            // pbResumenFinal
            // 
            pbResumenFinal.Location = new Point(510, 145);
            pbResumenFinal.Name = "pbResumenFinal";
            pbResumenFinal.Size = new Size(253, 202);
            pbResumenFinal.TabIndex = 23;
            pbResumenFinal.TabStop = false;
            pbResumenFinal.Visible = false;
            // 
            // tlDescargarPDF
            // 
            tlDescargarPDF.ColumnCount = 2;
            tlDescargarPDF.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlDescargarPDF.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlDescargarPDF.Controls.Add(btnDescargarPDF, 1, 0);
            tlDescargarPDF.Dock = DockStyle.Bottom;
            tlDescargarPDF.Location = new Point(3, 494);
            tlDescargarPDF.Name = "tlDescargarPDF";
            tlDescargarPDF.RowCount = 1;
            tlDescargarPDF.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlDescargarPDF.Size = new Size(924, 44);
            tlDescargarPDF.TabIndex = 19;
            // 
            // btnDescargarPDF
            // 
            btnDescargarPDF.AutoSize = false;
            btnDescargarPDF.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDescargarPDF.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDescargarPDF.Depth = 0;
            btnDescargarPDF.Dock = DockStyle.Right;
            btnDescargarPDF.HighEmphasis = true;
            btnDescargarPDF.Icon = null;
            btnDescargarPDF.Location = new Point(660, 6);
            btnDescargarPDF.Margin = new Padding(4, 6, 4, 6);
            btnDescargarPDF.MouseState = MaterialSkin.MouseState.HOVER;
            btnDescargarPDF.Name = "btnDescargarPDF";
            btnDescargarPDF.NoAccentTextColor = Color.Empty;
            btnDescargarPDF.Size = new Size(260, 32);
            btnDescargarPDF.TabIndex = 0;
            btnDescargarPDF.Text = "DESCARGAR PDF";
            btnDescargarPDF.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDescargarPDF.UseAccentColor = false;
            btnDescargarPDF.UseVisualStyleBackColor = true;
            // 
            // tlFechas
            // 
            tlFechas.ColumnCount = 3;
            tlFechas.ColumnStyles.Add(new ColumnStyle());
            tlFechas.ColumnStyles.Add(new ColumnStyle());
            tlFechas.ColumnStyles.Add(new ColumnStyle());
            tlFechas.Controls.Add(cbFechaInicial, 0, 0);
            tlFechas.Controls.Add(cbSeccion, 2, 0);
            tlFechas.Controls.Add(cbFechaFinal, 1, 0);
            tlFechas.Dock = DockStyle.Top;
            tlFechas.Location = new Point(3, 3);
            tlFechas.Name = "tlFechas";
            tlFechas.RowCount = 2;
            tlFechas.RowStyles.Add(new RowStyle());
            tlFechas.RowStyles.Add(new RowStyle());
            tlFechas.Size = new Size(924, 35);
            tlFechas.TabIndex = 0;
            // 
            // cbFechaInicial
            // 
            cbFechaInicial.BackColor = SystemColors.HotTrack;
            cbFechaInicial.FlatStyle = FlatStyle.Popup;
            cbFechaInicial.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            cbFechaInicial.ForeColor = SystemColors.Info;
            cbFechaInicial.FormattingEnabled = true;
            cbFechaInicial.Location = new Point(3, 7);
            cbFechaInicial.Margin = new Padding(3, 7, 3, 3);
            cbFechaInicial.Name = "cbFechaInicial";
            cbFechaInicial.Size = new Size(121, 28);
            cbFechaInicial.TabIndex = 14;
            cbFechaInicial.Text = "Fecha inicial";
            cbFechaInicial.MouseClick += cbFechaInicial_MouseClick;
            // 
            // cbSeccion
            // 
            cbSeccion.BackColor = SystemColors.HotTrack;
            cbSeccion.Dock = DockStyle.Right;
            cbSeccion.FlatStyle = FlatStyle.Popup;
            cbSeccion.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            cbSeccion.ForeColor = SystemColors.Info;
            cbSeccion.FormattingEnabled = true;
            cbSeccion.Items.AddRange(new object[] { "Ventas", "Totales según medio de pago", "Resumen final" });
            cbSeccion.Location = new Point(696, 7);
            cbSeccion.Margin = new Padding(3, 7, 6, 3);
            cbSeccion.Name = "cbSeccion";
            cbSeccion.Size = new Size(222, 28);
            cbSeccion.TabIndex = 16;
            cbSeccion.Text = "Sección";
            // 
            // cbFechaFinal
            // 
            cbFechaFinal.BackColor = SystemColors.HotTrack;
            cbFechaFinal.FlatStyle = FlatStyle.Popup;
            cbFechaFinal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            cbFechaFinal.ForeColor = SystemColors.Info;
            cbFechaFinal.FormattingEnabled = true;
            cbFechaFinal.Location = new Point(130, 7);
            cbFechaFinal.Margin = new Padding(3, 7, 3, 3);
            cbFechaFinal.Name = "cbFechaFinal";
            cbFechaFinal.Size = new Size(121, 28);
            cbFechaFinal.TabIndex = 15;
            cbFechaFinal.Text = "Fecha final";
            cbFechaFinal.MouseClick += cbFechaFinal_MouseClick;
            // 
            // tabPromociones
            // 
            tabPromociones.Controls.Add(tlPromociones);
            tabPromociones.Location = new Point(4, 39);
            tabPromociones.Name = "tabPromociones";
            tabPromociones.Padding = new Padding(3);
            tabPromociones.Size = new Size(930, 541);
            tabPromociones.TabIndex = 3;
            tabPromociones.Text = "Promociones";
            tabPromociones.UseVisualStyleBackColor = true;
            // 
            // tlPromociones
            // 
            tlPromociones.ColumnCount = 2;
            tlPromociones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5268822F));
            tlPromociones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.4731178F));
            tlPromociones.Controls.Add(gbPromociones, 0, 0);
            tlPromociones.Controls.Add(dgvPromociones, 1, 0);
            tlPromociones.Location = new Point(0, 0);
            tlPromociones.Name = "tlPromociones";
            tlPromociones.RowCount = 1;
            tlPromociones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlPromociones.RowStyles.Add(new RowStyle(SizeType.Absolute, 645F));
            tlPromociones.Size = new Size(930, 645);
            tlPromociones.TabIndex = 0;
            // 
            // gbPromociones
            // 
            gbPromociones.BackColor = Color.LightGray;
            gbPromociones.Controls.Add(dtpFechaFin);
            gbPromociones.Controls.Add(dtpFechaInicio);
            gbPromociones.Controls.Add(textBox3);
            gbPromociones.Controls.Add(btnEscanearPromocion);
            gbPromociones.Controls.Add(textBox2);
            gbPromociones.Controls.Add(textBox1);
            gbPromociones.Controls.Add(lblFechaFin);
            gbPromociones.Controls.Add(lblFechaInicio);
            gbPromociones.Controls.Add(lblPrecioEspecial);
            gbPromociones.Controls.Add(lblDescripcionPromo);
            gbPromociones.Controls.Add(lblTipo);
            gbPromociones.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbPromociones.Location = new Point(3, 3);
            gbPromociones.Name = "gbPromociones";
            gbPromociones.Size = new Size(343, 357);
            gbPromociones.TabIndex = 2;
            gbPromociones.TabStop = false;
            gbPromociones.Text = "Promociones";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Location = new Point(114, 185);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(200, 25);
            dtpFechaFin.TabIndex = 10;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(114, 151);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(200, 25);
            dtpFechaInicio.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(114, 115);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 25);
            textBox3.TabIndex = 8;
            // 
            // btnEscanearPromocion
            // 
            btnEscanearPromocion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnEscanearPromocion.Location = new Point(220, 79);
            btnEscanearPromocion.Name = "btnEscanearPromocion";
            btnEscanearPromocion.Size = new Size(76, 23);
            btnEscanearPromocion.TabIndex = 7;
            btnEscanearPromocion.Text = "Escanear";
            btnEscanearPromocion.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(114, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 25);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(114, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 25);
            textBox1.TabIndex = 5;
            // 
            // lblFechaFin
            // 
            lblFechaFin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblFechaFin.Location = new Point(16, 189);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(100, 23);
            lblFechaFin.TabIndex = 4;
            lblFechaFin.Text = "Fecha Fin";
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblFechaInicio.Location = new Point(16, 155);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(100, 23);
            lblFechaInicio.TabIndex = 3;
            lblFechaInicio.Text = "Fecha Inicio";
            // 
            // lblPrecioEspecial
            // 
            lblPrecioEspecial.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblPrecioEspecial.Location = new Point(16, 116);
            lblPrecioEspecial.Name = "lblPrecioEspecial";
            lblPrecioEspecial.Size = new Size(100, 23);
            lblPrecioEspecial.TabIndex = 2;
            lblPrecioEspecial.Text = "Precio Especial";
            // 
            // lblDescripcionPromo
            // 
            lblDescripcionPromo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblDescripcionPromo.Location = new Point(16, 82);
            lblDescripcionPromo.Name = "lblDescripcionPromo";
            lblDescripcionPromo.Size = new Size(74, 23);
            lblDescripcionPromo.TabIndex = 1;
            lblDescripcionPromo.Text = "Descripción";
            // 
            // lblTipo
            // 
            lblTipo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblTipo.Location = new Point(16, 44);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(39, 23);
            lblTipo.TabIndex = 0;
            lblTipo.Text = "Tipo";
            // 
            // dgvPromociones
            // 
            dgvPromociones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPromociones.Dock = DockStyle.Fill;
            dgvPromociones.Location = new Point(352, 3);
            dgvPromociones.Name = "dgvPromociones";
            dgvPromociones.RowHeadersWidth = 51;
            dgvPromociones.Size = new Size(575, 639);
            dgvPromociones.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(944, 651);
            Controls.Add(interfazPrincipal);
            DrawerTabControl = interfazPrincipal;
            Name = "Form2";
            WindowState = FormWindowState.Maximized;
            interfazPrincipal.ResumeLayout(false);
            tabVentas.ResumeLayout(false);
            tlVentas.ResumeLayout(false);
            tlVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            tlMediosPago.ResumeLayout(false);
            tlMediosPago.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tabProductos.ResumeLayout(false);
            tlProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabArqueo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvArqueo).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMedioPago).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResumenFinal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMedioPago).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbResumenFinal).EndInit();
            tlDescargarPDF.ResumeLayout(false);
            tlFechas.ResumeLayout(false);
            tabPromociones.ResumeLayout(false);
            tlPromociones.ResumeLayout(false);
            gbPromociones.ResumeLayout(false);
            gbPromociones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPromociones).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabArqueo;
        private MaterialSkin.Controls.MaterialTabControl interfazPrincipal;
        private TabPage tabVentas;
        private TabPage tabProductos;
        private TabPage tabPromociones;
        private TableLayoutPanel tlVentas;
        private MaterialSkin.Controls.MaterialButton btnReiniciarLista;
        private MaterialSkin.Controls.MaterialButton btnAgregarDevolucion;
        private MaterialSkin.Controls.MaterialButton btnAjustarCaja;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TableLayoutPanel tlProductos;
        private DataGridView dgvProductos;
        private DataGridView dgvVentas;
        private TableLayoutPanel tlFechas;
        private ComboBox cbFechaInicial;
        private ComboBox cbSeccion;
        private ComboBox cbFechaFinal;
        private DataGridView dgvArqueo;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn MediosDePago;
        private DataGridViewTextBoxColumn Productos;
        private DataGridViewTextBoxColumn Total;
        private TableLayoutPanel tlDescargarPDF;
        private MaterialSkin.Controls.MaterialButton btnDescargarPDF;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridView dgvMedioPago;
        private DataGridView dgvResumenFinal;
        private DataGridViewTextBoxColumn Column1ResumenFinal;
        private PictureBox pbMedioPago;
        private PictureBox pbResumenFinal;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tlPromociones;
        private DataGridView dgvPromociones;
        private GroupBox gbPromociones;
        private DateTimePicker dtpFechaFin;
        private DateTimePicker dtpFechaInicio;
        private TextBox textBox3;
        private Button btnEscanearPromocion;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lblFechaFin;
        private Label lblFechaInicio;
        private Label lblPrecioEspecial;
        private Label lblDescripcionPromo;
        private Label lblTipo;
        private DateTimePicker calendarioFechaInicial;
        private DateTimePicker calendarioFechaFinal;
        private TableLayoutPanel tlMediosPago;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblSaldo;
        private Label lblTotal;
        private RadioButton rbDebito;
        private RadioButton rbEfectivo;
        private RadioButton rbCredito;
        private RadioButton rbTrasferencia;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtFiltros;
        private ComboBox cbFiltros;
        private MaterialSkin.Controls.MaterialButton btnAgregarProducto;
        private MaterialSkin.Controls.MaterialButton btnBorrarProducto;
        private MaterialSkin.Controls.MaterialButton btnEditarProductos;
        private MaterialSkin.Controls.MaterialButton btnAumentarProducto;
        private MaterialSkin.Controls.MaterialButton btnDesbloquearEdicion;
        private Panel panel1;
    }
}