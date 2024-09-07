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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            interfazPrincipal = new MaterialSkin.Controls.MaterialTabControl();
            tabVentas = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            mbtnReiniciar = new MaterialSkin.Controls.MaterialButton();
            mbtnDevoluciones = new MaterialSkin.Controls.MaterialButton();
            mbtnAjustarCaja = new MaterialSkin.Controls.MaterialButton();
            tableLayoutPanel4 = new TableLayoutPanel();
            mrbEfectivo = new MaterialSkin.Controls.MaterialRadioButton();
            mrbDebito = new MaterialSkin.Controls.MaterialRadioButton();
            mrbCredito = new MaterialSkin.Controls.MaterialRadioButton();
            mrbTransferencia = new MaterialSkin.Controls.MaterialRadioButton();
            tableLayoutPanel6 = new TableLayoutPanel();
            label7 = new Label();
            label8 = new Label();
            panel1 = new Panel();
            dgvVentas = new DataGridView();
            tabProductos = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            dgvProductos = new DataGridView();
            tableLayoutPanel7 = new TableLayoutPanel();
            materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            panel2 = new Panel();
            tlpDesbloquearEdicion = new TableLayoutPanel();
            btnDesbloquearEdicion = new MaterialSkin.Controls.MaterialButton();
            tlpBotonesProductos = new TableLayoutPanel();
            btnAgregarProducto = new MaterialSkin.Controls.MaterialButton();
            btnBorrarProducto = new MaterialSkin.Controls.MaterialButton();
            btnEditarProducto = new MaterialSkin.Controls.MaterialButton();
            btnAumentarProducto = new MaterialSkin.Controls.MaterialButton();
            tabArqueo = new TabPage();
            tlpPrincipal = new TableLayoutPanel();
            tlpBotonesArriba = new TableLayoutPanel();
            materialComboBox3 = new MaterialSkin.Controls.MaterialComboBox();
            mbtnFechaInicio = new MaterialSkin.Controls.MaterialButton();
            mbtnFechaFin = new MaterialSkin.Controls.MaterialButton();
            tlpDescarga = new TableLayoutPanel();
            btnDescargarPDF = new Button();
            dgvArqueo = new DataGridView();
            tabPromos = new TabPage();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            label6 = new Label();
            mcbTipo = new MaterialSkin.Controls.MaterialComboBox();
            mtxtPrecioEspecial = new MaterialSkin.Controls.MaterialTextBox();
            dtpInicioPromo = new DateTimePicker();
            dtpFinPromo = new DateTimePicker();
            tableLayoutPanel9 = new TableLayoutPanel();
            mtxtDescripcion = new MaterialSkin.Controls.MaterialTextBox2();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            mbtnAgregarPromo = new MaterialSkin.Controls.MaterialButton();
            dgvPromos = new DataGridView();
            interfazPrincipal.SuspendLayout();
            tabVentas.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            tabProductos.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            tableLayoutPanel7.SuspendLayout();
            panel2.SuspendLayout();
            tlpDesbloquearEdicion.SuspendLayout();
            tlpBotonesProductos.SuspendLayout();
            tabArqueo.SuspendLayout();
            tlpPrincipal.SuspendLayout();
            tlpBotonesArriba.SuspendLayout();
            tlpDescarga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArqueo).BeginInit();
            tabPromos.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPromos).BeginInit();
            SuspendLayout();
            // 
            // interfazPrincipal
            // 
            interfazPrincipal.Controls.Add(tabVentas);
            interfazPrincipal.Controls.Add(tabProductos);
            interfazPrincipal.Controls.Add(tabArqueo);
            interfazPrincipal.Controls.Add(tabPromos);
            interfazPrincipal.Depth = 0;
            interfazPrincipal.Dock = DockStyle.Fill;
            interfazPrincipal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            interfazPrincipal.ItemSize = new Size(48, 35);
            interfazPrincipal.Location = new Point(3, 64);
            interfazPrincipal.Margin = new Padding(15);
            interfazPrincipal.MouseState = MaterialSkin.MouseState.HOVER;
            interfazPrincipal.Multiline = true;
            interfazPrincipal.Name = "interfazPrincipal";
            interfazPrincipal.SelectedIndex = 0;
            interfazPrincipal.Size = new Size(1380, 721);
            interfazPrincipal.TabIndex = 0;
            // 
            // tabVentas
            // 
            tabVentas.Controls.Add(tableLayoutPanel1);
            tabVentas.Location = new Point(4, 39);
            tabVentas.Name = "tabVentas";
            tabVentas.Padding = new Padding(3);
            tabVentas.Size = new Size(1372, 678);
            tabVentas.TabIndex = 0;
            tabVentas.Text = "VENTAS";
            tabVentas.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 3);
            tableLayoutPanel1.Controls.Add(dgvVentas, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Size = new Size(1366, 672);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Controls.Add(mbtnReiniciar, 0, 0);
            tableLayoutPanel3.Controls.Add(mbtnDevoluciones, 2, 0);
            tableLayoutPanel3.Controls.Add(mbtnAjustarCaja, 3, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(71, 36);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1223, 61);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // mbtnReiniciar
            // 
            mbtnReiniciar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnReiniciar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnReiniciar.Depth = 0;
            mbtnReiniciar.Dock = DockStyle.Fill;
            mbtnReiniciar.HighEmphasis = true;
            mbtnReiniciar.Icon = null;
            mbtnReiniciar.Location = new Point(4, 6);
            mbtnReiniciar.Margin = new Padding(4, 6, 4, 6);
            mbtnReiniciar.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnReiniciar.Name = "mbtnReiniciar";
            mbtnReiniciar.NoAccentTextColor = Color.Empty;
            mbtnReiniciar.Size = new Size(236, 49);
            mbtnReiniciar.TabIndex = 0;
            mbtnReiniciar.Text = "REINICIAR LISTA";
            mbtnReiniciar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnReiniciar.UseAccentColor = false;
            mbtnReiniciar.UseVisualStyleBackColor = true;
            mbtnReiniciar.Click += mbtnReiniciar_Click;
            // 
            // mbtnDevoluciones
            // 
            mbtnDevoluciones.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnDevoluciones.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnDevoluciones.Depth = 0;
            mbtnDevoluciones.Dock = DockStyle.Fill;
            mbtnDevoluciones.HighEmphasis = true;
            mbtnDevoluciones.Icon = null;
            mbtnDevoluciones.Location = new Point(737, 6);
            mbtnDevoluciones.Margin = new Padding(4, 6, 4, 6);
            mbtnDevoluciones.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnDevoluciones.Name = "mbtnDevoluciones";
            mbtnDevoluciones.NoAccentTextColor = Color.Empty;
            mbtnDevoluciones.Size = new Size(236, 49);
            mbtnDevoluciones.TabIndex = 1;
            mbtnDevoluciones.Text = "DEVOLUCIONES";
            mbtnDevoluciones.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnDevoluciones.UseAccentColor = false;
            mbtnDevoluciones.UseVisualStyleBackColor = true;
            // 
            // mbtnAjustarCaja
            // 
            mbtnAjustarCaja.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnAjustarCaja.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnAjustarCaja.Depth = 0;
            mbtnAjustarCaja.Dock = DockStyle.Fill;
            mbtnAjustarCaja.HighEmphasis = true;
            mbtnAjustarCaja.Icon = null;
            mbtnAjustarCaja.Location = new Point(981, 6);
            mbtnAjustarCaja.Margin = new Padding(4, 6, 4, 6);
            mbtnAjustarCaja.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnAjustarCaja.Name = "mbtnAjustarCaja";
            mbtnAjustarCaja.NoAccentTextColor = Color.Empty;
            mbtnAjustarCaja.Size = new Size(238, 49);
            mbtnAjustarCaja.TabIndex = 2;
            mbtnAjustarCaja.Text = "AJUSTAR CAJA";
            mbtnAjustarCaja.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnAjustarCaja.UseAccentColor = false;
            mbtnAjustarCaja.UseVisualStyleBackColor = true;
            mbtnAjustarCaja.Click += mbtnAjustarCaja_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 6;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.Controls.Add(mrbEfectivo, 1, 0);
            tableLayoutPanel4.Controls.Add(mrbDebito, 2, 0);
            tableLayoutPanel4.Controls.Add(mrbCredito, 3, 0);
            tableLayoutPanel4.Controls.Add(mrbTransferencia, 4, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel4.Controls.Add(panel1, 5, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(71, 573);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1223, 61);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // mrbEfectivo
            // 
            mrbEfectivo.AutoSize = true;
            mrbEfectivo.Depth = 0;
            mrbEfectivo.Dock = DockStyle.Fill;
            mrbEfectivo.Location = new Point(366, 0);
            mrbEfectivo.Margin = new Padding(0);
            mrbEfectivo.MouseLocation = new Point(-1, -1);
            mrbEfectivo.MouseState = MaterialSkin.MouseState.HOVER;
            mrbEfectivo.Name = "mrbEfectivo";
            mrbEfectivo.Ripple = true;
            mrbEfectivo.Size = new Size(183, 61);
            mrbEfectivo.TabIndex = 0;
            mrbEfectivo.TabStop = true;
            mrbEfectivo.Text = "EFECTIVO";
            mrbEfectivo.UseVisualStyleBackColor = true;
            // 
            // mrbDebito
            // 
            mrbDebito.AutoSize = true;
            mrbDebito.Depth = 0;
            mrbDebito.Dock = DockStyle.Fill;
            mrbDebito.Location = new Point(549, 0);
            mrbDebito.Margin = new Padding(0);
            mrbDebito.MouseLocation = new Point(-1, -1);
            mrbDebito.MouseState = MaterialSkin.MouseState.HOVER;
            mrbDebito.Name = "mrbDebito";
            mrbDebito.Ripple = true;
            mrbDebito.Size = new Size(183, 61);
            mrbDebito.TabIndex = 1;
            mrbDebito.TabStop = true;
            mrbDebito.Text = "DÉBITO";
            mrbDebito.UseVisualStyleBackColor = true;
            // 
            // mrbCredito
            // 
            mrbCredito.AutoSize = true;
            mrbCredito.Depth = 0;
            mrbCredito.Dock = DockStyle.Fill;
            mrbCredito.Location = new Point(732, 0);
            mrbCredito.Margin = new Padding(0);
            mrbCredito.MouseLocation = new Point(-1, -1);
            mrbCredito.MouseState = MaterialSkin.MouseState.HOVER;
            mrbCredito.Name = "mrbCredito";
            mrbCredito.Ripple = true;
            mrbCredito.Size = new Size(183, 61);
            mrbCredito.TabIndex = 2;
            mrbCredito.TabStop = true;
            mrbCredito.Text = "CRÉDITO";
            mrbCredito.UseVisualStyleBackColor = true;
            // 
            // mrbTransferencia
            // 
            mrbTransferencia.AutoSize = true;
            mrbTransferencia.Depth = 0;
            mrbTransferencia.Dock = DockStyle.Fill;
            mrbTransferencia.Location = new Point(915, 0);
            mrbTransferencia.Margin = new Padding(0);
            mrbTransferencia.MouseLocation = new Point(-1, -1);
            mrbTransferencia.MouseState = MaterialSkin.MouseState.HOVER;
            mrbTransferencia.Name = "mrbTransferencia";
            mrbTransferencia.Ripple = true;
            mrbTransferencia.Size = new Size(183, 61);
            mrbTransferencia.TabIndex = 3;
            mrbTransferencia.TabStop = true;
            mrbTransferencia.Text = "TRANSFERENCIA";
            mrbTransferencia.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel6.Controls.Add(label7, 0, 0);
            tableLayoutPanel6.Controls.Add(label8, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(360, 55);
            tableLayoutPanel6.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(102, 55);
            label7.TabIndex = 0;
            label7.Text = "TOTAL:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(111, 0);
            label8.Name = "label8";
            label8.Size = new Size(246, 55);
            label8.TabIndex = 1;
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(1101, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(119, 55);
            panel1.TabIndex = 5;
            // 
            // dgvVentas
            // 
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Dock = DockStyle.Fill;
            dgvVentas.Location = new Point(73, 120);
            dgvVentas.Margin = new Padding(5, 20, 5, 20);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(1219, 430);
            dgvVentas.TabIndex = 2;
            // 
            // tabProductos
            // 
            tabProductos.Controls.Add(tableLayoutPanel2);
            tabProductos.Location = new Point(4, 39);
            tabProductos.Name = "tabProductos";
            tabProductos.Padding = new Padding(3);
            tabProductos.Size = new Size(1372, 678);
            tabProductos.TabIndex = 1;
            tabProductos.Text = "PRODUCTOS";
            tabProductos.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.Controls.Add(dgvProductos, 1, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel7, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.Size = new Size(1366, 672);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // dgvProductos
            // 
            dgvProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(73, 120);
            dgvProductos.Margin = new Padding(5, 20, 5, 20);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(1219, 430);
            dgvProductos.TabIndex = 30;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 3;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.2526569F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.2207689F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.52657F));
            tableLayoutPanel7.Controls.Add(materialTextBox1, 0, 0);
            tableLayoutPanel7.Controls.Add(materialComboBox1, 1, 0);
            tableLayoutPanel7.Controls.Add(panel2, 2, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(71, 36);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(1223, 61);
            tableLayoutPanel7.TabIndex = 31;
            // 
            // materialTextBox1
            // 
            materialTextBox1.AnimateReadOnly = false;
            materialTextBox1.BorderStyle = BorderStyle.None;
            materialTextBox1.Depth = 0;
            materialTextBox1.Dock = DockStyle.Fill;
            materialTextBox1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox1.LeadingIcon = null;
            materialTextBox1.Location = new Point(3, 3);
            materialTextBox1.MaxLength = 50;
            materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox1.Multiline = false;
            materialTextBox1.Name = "materialTextBox1";
            materialTextBox1.Size = new Size(205, 50);
            materialTextBox1.TabIndex = 0;
            materialTextBox1.Text = "";
            materialTextBox1.TrailingIcon = null;
            // 
            // materialComboBox1
            // 
            materialComboBox1.AutoResize = false;
            materialComboBox1.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBox1.Depth = 0;
            materialComboBox1.Dock = DockStyle.Fill;
            materialComboBox1.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBox1.DropDownHeight = 174;
            materialComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox1.DropDownWidth = 121;
            materialComboBox1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBox1.FormattingEnabled = true;
            materialComboBox1.IntegralHeight = false;
            materialComboBox1.ItemHeight = 43;
            materialComboBox1.Location = new Point(214, 3);
            materialComboBox1.MaxDropDownItems = 4;
            materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBox1.Name = "materialComboBox1";
            materialComboBox1.Size = new Size(119, 49);
            materialComboBox1.StartIndex = 0;
            materialComboBox1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(tlpDesbloquearEdicion);
            panel2.Controls.Add(tlpBotonesProductos);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(339, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(881, 55);
            panel2.TabIndex = 2;
            // 
            // tlpDesbloquearEdicion
            // 
            tlpDesbloquearEdicion.ColumnCount = 1;
            tlpDesbloquearEdicion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpDesbloquearEdicion.Controls.Add(btnDesbloquearEdicion, 0, 0);
            tlpDesbloquearEdicion.Dock = DockStyle.Fill;
            tlpDesbloquearEdicion.Location = new Point(0, 0);
            tlpDesbloquearEdicion.Name = "tlpDesbloquearEdicion";
            tlpDesbloquearEdicion.RowCount = 1;
            tlpDesbloquearEdicion.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpDesbloquearEdicion.Size = new Size(881, 55);
            tlpDesbloquearEdicion.TabIndex = 1;
            // 
            // btnDesbloquearEdicion
            // 
            btnDesbloquearEdicion.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDesbloquearEdicion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDesbloquearEdicion.Depth = 0;
            btnDesbloquearEdicion.Dock = DockStyle.Fill;
            btnDesbloquearEdicion.HighEmphasis = true;
            btnDesbloquearEdicion.Icon = null;
            btnDesbloquearEdicion.Location = new Point(4, 6);
            btnDesbloquearEdicion.Margin = new Padding(4, 6, 4, 6);
            btnDesbloquearEdicion.MouseState = MaterialSkin.MouseState.HOVER;
            btnDesbloquearEdicion.Name = "btnDesbloquearEdicion";
            btnDesbloquearEdicion.NoAccentTextColor = Color.Empty;
            btnDesbloquearEdicion.Size = new Size(873, 43);
            btnDesbloquearEdicion.TabIndex = 0;
            btnDesbloquearEdicion.Text = "Desbloquear Edicion";
            btnDesbloquearEdicion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDesbloquearEdicion.UseAccentColor = false;
            btnDesbloquearEdicion.UseVisualStyleBackColor = true;
            btnDesbloquearEdicion.Click += btnDesbloquearEdicion_Click;
            // 
            // tlpBotonesProductos
            // 
            tlpBotonesProductos.ColumnCount = 4;
            tlpBotonesProductos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpBotonesProductos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpBotonesProductos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpBotonesProductos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpBotonesProductos.Controls.Add(btnAgregarProducto, 0, 0);
            tlpBotonesProductos.Controls.Add(btnBorrarProducto, 1, 0);
            tlpBotonesProductos.Controls.Add(btnEditarProducto, 2, 0);
            tlpBotonesProductos.Controls.Add(btnAumentarProducto, 3, 0);
            tlpBotonesProductos.Dock = DockStyle.Fill;
            tlpBotonesProductos.Location = new Point(0, 0);
            tlpBotonesProductos.Name = "tlpBotonesProductos";
            tlpBotonesProductos.RowCount = 1;
            tlpBotonesProductos.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBotonesProductos.Size = new Size(881, 55);
            tlpBotonesProductos.TabIndex = 0;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAgregarProducto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAgregarProducto.Depth = 0;
            btnAgregarProducto.Dock = DockStyle.Fill;
            btnAgregarProducto.HighEmphasis = true;
            btnAgregarProducto.Icon = null;
            btnAgregarProducto.Location = new Point(4, 6);
            btnAgregarProducto.Margin = new Padding(4, 6, 4, 6);
            btnAgregarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.NoAccentTextColor = Color.Empty;
            btnAgregarProducto.Size = new Size(212, 43);
            btnAgregarProducto.TabIndex = 0;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAgregarProducto.UseAccentColor = false;
            btnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // btnBorrarProducto
            // 
            btnBorrarProducto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBorrarProducto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnBorrarProducto.Depth = 0;
            btnBorrarProducto.Dock = DockStyle.Fill;
            btnBorrarProducto.HighEmphasis = true;
            btnBorrarProducto.Icon = null;
            btnBorrarProducto.Location = new Point(224, 6);
            btnBorrarProducto.Margin = new Padding(4, 6, 4, 6);
            btnBorrarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            btnBorrarProducto.Name = "btnBorrarProducto";
            btnBorrarProducto.NoAccentTextColor = Color.Empty;
            btnBorrarProducto.Size = new Size(212, 43);
            btnBorrarProducto.TabIndex = 1;
            btnBorrarProducto.Text = "Borrar Producto";
            btnBorrarProducto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnBorrarProducto.UseAccentColor = false;
            btnBorrarProducto.UseVisualStyleBackColor = true;
            // 
            // btnEditarProducto
            // 
            btnEditarProducto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditarProducto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditarProducto.Depth = 0;
            btnEditarProducto.Dock = DockStyle.Fill;
            btnEditarProducto.HighEmphasis = true;
            btnEditarProducto.Icon = null;
            btnEditarProducto.Location = new Point(444, 6);
            btnEditarProducto.Margin = new Padding(4, 6, 4, 6);
            btnEditarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.NoAccentTextColor = Color.Empty;
            btnEditarProducto.Size = new Size(212, 43);
            btnEditarProducto.TabIndex = 2;
            btnEditarProducto.Text = "Editar Producto";
            btnEditarProducto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditarProducto.UseAccentColor = false;
            btnEditarProducto.UseVisualStyleBackColor = true;
            // 
            // btnAumentarProducto
            // 
            btnAumentarProducto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAumentarProducto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAumentarProducto.Depth = 0;
            btnAumentarProducto.Dock = DockStyle.Fill;
            btnAumentarProducto.HighEmphasis = true;
            btnAumentarProducto.Icon = null;
            btnAumentarProducto.Location = new Point(664, 6);
            btnAumentarProducto.Margin = new Padding(4, 6, 4, 6);
            btnAumentarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            btnAumentarProducto.Name = "btnAumentarProducto";
            btnAumentarProducto.NoAccentTextColor = Color.Empty;
            btnAumentarProducto.Size = new Size(213, 43);
            btnAumentarProducto.TabIndex = 3;
            btnAumentarProducto.Text = "Aumentar Producto";
            btnAumentarProducto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAumentarProducto.UseAccentColor = false;
            btnAumentarProducto.UseVisualStyleBackColor = true;
            // 
            // tabArqueo
            // 
            tabArqueo.Controls.Add(tlpPrincipal);
            tabArqueo.Location = new Point(4, 39);
            tabArqueo.Name = "tabArqueo";
            tabArqueo.Padding = new Padding(3);
            tabArqueo.Size = new Size(1372, 678);
            tabArqueo.TabIndex = 4;
            tabArqueo.Text = "ARQUEO DE CAJA";
            tabArqueo.UseVisualStyleBackColor = true;
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.ColumnCount = 3;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tlpPrincipal.Controls.Add(tlpBotonesArriba, 1, 1);
            tlpPrincipal.Controls.Add(tlpDescarga, 1, 3);
            tlpPrincipal.Controls.Add(dgvArqueo, 1, 2);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Location = new Point(3, 3);
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.RowCount = 5;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlpPrincipal.Size = new Size(1366, 672);
            tlpPrincipal.TabIndex = 0;
            // 
            // tlpBotonesArriba
            // 
            tlpBotonesArriba.ColumnCount = 4;
            tlpBotonesArriba.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpBotonesArriba.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpBotonesArriba.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpBotonesArriba.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpBotonesArriba.Controls.Add(materialComboBox3, 3, 0);
            tlpBotonesArriba.Controls.Add(mbtnFechaInicio, 0, 0);
            tlpBotonesArriba.Controls.Add(mbtnFechaFin, 1, 0);
            tlpBotonesArriba.Dock = DockStyle.Fill;
            tlpBotonesArriba.Location = new Point(71, 36);
            tlpBotonesArriba.Margin = new Padding(3, 3, 3, 15);
            tlpBotonesArriba.Name = "tlpBotonesArriba";
            tlpBotonesArriba.RowCount = 1;
            tlpBotonesArriba.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBotonesArriba.Size = new Size(1223, 49);
            tlpBotonesArriba.TabIndex = 0;
            // 
            // materialComboBox3
            // 
            materialComboBox3.AutoResize = false;
            materialComboBox3.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBox3.Depth = 0;
            materialComboBox3.Dock = DockStyle.Fill;
            materialComboBox3.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBox3.DropDownHeight = 174;
            materialComboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox3.DropDownWidth = 121;
            materialComboBox3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBox3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBox3.FormattingEnabled = true;
            materialComboBox3.IntegralHeight = false;
            materialComboBox3.ItemHeight = 43;
            materialComboBox3.Location = new Point(980, 3);
            materialComboBox3.MaxDropDownItems = 4;
            materialComboBox3.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBox3.Name = "materialComboBox3";
            materialComboBox3.Size = new Size(240, 49);
            materialComboBox3.StartIndex = 0;
            materialComboBox3.TabIndex = 2;
            // 
            // mbtnFechaInicio
            // 
            mbtnFechaInicio.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnFechaInicio.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnFechaInicio.Depth = 0;
            mbtnFechaInicio.Dock = DockStyle.Fill;
            mbtnFechaInicio.HighEmphasis = true;
            mbtnFechaInicio.Icon = null;
            mbtnFechaInicio.Location = new Point(7, 7);
            mbtnFechaInicio.Margin = new Padding(7);
            mbtnFechaInicio.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnFechaInicio.Name = "mbtnFechaInicio";
            mbtnFechaInicio.NoAccentTextColor = Color.Empty;
            mbtnFechaInicio.Size = new Size(230, 35);
            mbtnFechaInicio.TabIndex = 3;
            mbtnFechaInicio.Text = "Fecha de Inicio";
            mbtnFechaInicio.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnFechaInicio.UseAccentColor = false;
            mbtnFechaInicio.UseVisualStyleBackColor = true;
            // 
            // mbtnFechaFin
            // 
            mbtnFechaFin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnFechaFin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnFechaFin.Depth = 0;
            mbtnFechaFin.Dock = DockStyle.Fill;
            mbtnFechaFin.HighEmphasis = true;
            mbtnFechaFin.Icon = null;
            mbtnFechaFin.Location = new Point(251, 7);
            mbtnFechaFin.Margin = new Padding(7);
            mbtnFechaFin.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnFechaFin.Name = "mbtnFechaFin";
            mbtnFechaFin.NoAccentTextColor = Color.Empty;
            mbtnFechaFin.Size = new Size(230, 35);
            mbtnFechaFin.TabIndex = 4;
            mbtnFechaFin.Text = "fecha de fin";
            mbtnFechaFin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnFechaFin.UseAccentColor = false;
            mbtnFechaFin.UseVisualStyleBackColor = true;
            // 
            // tlpDescarga
            // 
            tlpDescarga.ColumnCount = 2;
            tlpDescarga.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlpDescarga.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpDescarga.Controls.Add(btnDescargarPDF, 1, 0);
            tlpDescarga.Dock = DockStyle.Fill;
            tlpDescarga.Location = new Point(71, 573);
            tlpDescarga.Name = "tlpDescarga";
            tlpDescarga.RowCount = 1;
            tlpDescarga.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDescarga.Size = new Size(1223, 61);
            tlpDescarga.TabIndex = 1;
            // 
            // btnDescargarPDF
            // 
            btnDescargarPDF.BackColor = Color.RoyalBlue;
            btnDescargarPDF.Dock = DockStyle.Fill;
            btnDescargarPDF.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            btnDescargarPDF.ForeColor = SystemColors.Control;
            btnDescargarPDF.Location = new Point(981, 3);
            btnDescargarPDF.Name = "btnDescargarPDF";
            btnDescargarPDF.Size = new Size(239, 55);
            btnDescargarPDF.TabIndex = 0;
            btnDescargarPDF.Text = "DESCARGAR PDF";
            btnDescargarPDF.UseVisualStyleBackColor = false;
            // 
            // dgvArqueo
            // 
            dgvArqueo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvArqueo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvArqueo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArqueo.Dock = DockStyle.Fill;
            dgvArqueo.Location = new Point(71, 103);
            dgvArqueo.Margin = new Padding(3, 3, 3, 30);
            dgvArqueo.Name = "dgvArqueo";
            dgvArqueo.Size = new Size(1223, 437);
            dgvArqueo.TabIndex = 2;
            // 
            // tabPromos
            // 
            tabPromos.Controls.Add(tableLayoutPanel5);
            tabPromos.Location = new Point(4, 39);
            tabPromos.Name = "tabPromos";
            tabPromos.Padding = new Padding(3);
            tabPromos.Size = new Size(1372, 678);
            tabPromos.TabIndex = 3;
            tabPromos.Text = "PROMOCIONES";
            tabPromos.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.ColumnCount = 5;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel8, 1, 1);
            tableLayoutPanel5.Controls.Add(dgvPromos, 3, 1);
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel5.Size = new Size(1366, 672);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel8.Controls.Add(label6, 0, 0);
            tableLayoutPanel8.Controls.Add(mcbTipo, 1, 1);
            tableLayoutPanel8.Controls.Add(mtxtPrecioEspecial, 1, 3);
            tableLayoutPanel8.Controls.Add(dtpInicioPromo, 1, 4);
            tableLayoutPanel8.Controls.Add(dtpFinPromo, 1, 5);
            tableLayoutPanel8.Controls.Add(tableLayoutPanel9, 1, 2);
            tableLayoutPanel8.Controls.Add(label1, 0, 1);
            tableLayoutPanel8.Controls.Add(label2, 0, 2);
            tableLayoutPanel8.Controls.Add(label3, 0, 3);
            tableLayoutPanel8.Controls.Add(label4, 0, 4);
            tableLayoutPanel8.Controls.Add(label5, 0, 5);
            tableLayoutPanel8.Controls.Add(mbtnAgregarPromo, 0, 6);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(88, 36);
            tableLayoutPanel8.Margin = new Padding(20, 3, 20, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 7;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.Size = new Size(506, 598);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.RoyalBlue;
            label6.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel8.SetColumnSpan(label6, 2);
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(10, 30);
            label6.Margin = new Padding(10, 30, 10, 30);
            label6.Name = "label6";
            label6.Size = new Size(486, 29);
            label6.TabIndex = 15;
            label6.Text = "INGRESE UNA NUEVA PROMOCION COMPLETANDO LOS CAMPOS: ";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mcbTipo
            // 
            mcbTipo.AutoResize = false;
            mcbTipo.BackColor = Color.FromArgb(255, 255, 255);
            mcbTipo.Depth = 0;
            mcbTipo.Dock = DockStyle.Fill;
            mcbTipo.DrawMode = DrawMode.OwnerDrawVariable;
            mcbTipo.DropDownHeight = 174;
            mcbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            mcbTipo.DropDownWidth = 121;
            mcbTipo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            mcbTipo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcbTipo.FormattingEnabled = true;
            mcbTipo.IntegralHeight = false;
            mcbTipo.ItemHeight = 43;
            mcbTipo.Items.AddRange(new object[] { "COMBO", "DESCUENTO", "3X2", "2X1", "3X1" });
            mcbTipo.Location = new Point(161, 119);
            mcbTipo.Margin = new Padding(10, 30, 10, 30);
            mcbTipo.MaxDropDownItems = 4;
            mcbTipo.MouseState = MaterialSkin.MouseState.OUT;
            mcbTipo.Name = "mcbTipo";
            mcbTipo.Size = new Size(335, 49);
            mcbTipo.StartIndex = 0;
            mcbTipo.TabIndex = 5;
            // 
            // mtxtPrecioEspecial
            // 
            mtxtPrecioEspecial.AnimateReadOnly = false;
            mtxtPrecioEspecial.BorderStyle = BorderStyle.None;
            mtxtPrecioEspecial.Depth = 0;
            mtxtPrecioEspecial.Dock = DockStyle.Fill;
            mtxtPrecioEspecial.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtxtPrecioEspecial.LeadingIcon = null;
            mtxtPrecioEspecial.Location = new Point(161, 285);
            mtxtPrecioEspecial.Margin = new Padding(10, 30, 10, 30);
            mtxtPrecioEspecial.MaxLength = 50;
            mtxtPrecioEspecial.MouseState = MaterialSkin.MouseState.OUT;
            mtxtPrecioEspecial.Multiline = false;
            mtxtPrecioEspecial.Name = "mtxtPrecioEspecial";
            mtxtPrecioEspecial.Size = new Size(335, 50);
            mtxtPrecioEspecial.TabIndex = 6;
            mtxtPrecioEspecial.Text = "";
            mtxtPrecioEspecial.TrailingIcon = null;
            // 
            // dtpInicioPromo
            // 
            dtpInicioPromo.Dock = DockStyle.Fill;
            dtpInicioPromo.Location = new Point(161, 380);
            dtpInicioPromo.Margin = new Padding(10, 42, 10, 30);
            dtpInicioPromo.Name = "dtpInicioPromo";
            dtpInicioPromo.Size = new Size(335, 23);
            dtpInicioPromo.TabIndex = 7;
            // 
            // dtpFinPromo
            // 
            dtpFinPromo.Dock = DockStyle.Fill;
            dtpFinPromo.Location = new Point(161, 463);
            dtpFinPromo.Margin = new Padding(10, 42, 10, 30);
            dtpFinPromo.Name = "dtpFinPromo";
            dtpFinPromo.Size = new Size(335, 23);
            dtpFinPromo.TabIndex = 8;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel9.Controls.Add(mtxtDescripcion, 0, 0);
            tableLayoutPanel9.Controls.Add(button1, 1, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(154, 175);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Size = new Size(349, 77);
            tableLayoutPanel9.TabIndex = 9;
            // 
            // mtxtDescripcion
            // 
            mtxtDescripcion.AnimateReadOnly = false;
            mtxtDescripcion.BackgroundImageLayout = ImageLayout.None;
            mtxtDescripcion.CharacterCasing = CharacterCasing.Normal;
            mtxtDescripcion.Depth = 0;
            mtxtDescripcion.Dock = DockStyle.Fill;
            mtxtDescripcion.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtxtDescripcion.HideSelection = true;
            mtxtDescripcion.LeadingIcon = null;
            mtxtDescripcion.Location = new Point(10, 30);
            mtxtDescripcion.Margin = new Padding(10, 30, 10, 30);
            mtxtDescripcion.MaxLength = 32767;
            mtxtDescripcion.MouseState = MaterialSkin.MouseState.OUT;
            mtxtDescripcion.Name = "mtxtDescripcion";
            mtxtDescripcion.PasswordChar = '\0';
            mtxtDescripcion.PrefixSuffixText = null;
            mtxtDescripcion.ReadOnly = false;
            mtxtDescripcion.RightToLeft = RightToLeft.No;
            mtxtDescripcion.SelectedText = "";
            mtxtDescripcion.SelectionLength = 0;
            mtxtDescripcion.SelectionStart = 0;
            mtxtDescripcion.ShortcutsEnabled = true;
            mtxtDescripcion.Size = new Size(224, 48);
            mtxtDescripcion.TabIndex = 1;
            mtxtDescripcion.TabStop = false;
            mtxtDescripcion.TextAlign = HorizontalAlignment.Left;
            mtxtDescripcion.TrailingIcon = null;
            mtxtDescripcion.UseSystemPasswordChar = false;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(247, 3);
            button1.Name = "button1";
            button1.Size = new Size(99, 71);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RoyalBlue;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(10, 119);
            label1.Margin = new Padding(10, 30, 10, 30);
            label1.Name = "label1";
            label1.Size = new Size(131, 23);
            label1.TabIndex = 10;
            label1.Text = "TIPO:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.RoyalBlue;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(10, 202);
            label2.Margin = new Padding(10, 30, 10, 30);
            label2.Name = "label2";
            label2.Size = new Size(131, 23);
            label2.TabIndex = 11;
            label2.Text = "DESCRIPCIÓN:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.RoyalBlue;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(10, 285);
            label3.Margin = new Padding(10, 30, 10, 30);
            label3.Name = "label3";
            label3.Size = new Size(131, 23);
            label3.TabIndex = 12;
            label3.Text = "PRECIO ESPECIAL:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.RoyalBlue;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(10, 368);
            label4.Margin = new Padding(10, 30, 10, 30);
            label4.Name = "label4";
            label4.Size = new Size(131, 23);
            label4.TabIndex = 13;
            label4.Text = "FECHA DE INICIO:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.RoyalBlue;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(10, 451);
            label5.Margin = new Padding(10, 30, 10, 30);
            label5.Name = "label5";
            label5.Size = new Size(131, 23);
            label5.TabIndex = 14;
            label5.Text = "FECHA DE FIN:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mbtnAgregarPromo
            // 
            mbtnAgregarPromo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel8.SetColumnSpan(mbtnAgregarPromo, 2);
            mbtnAgregarPromo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnAgregarPromo.Depth = 0;
            mbtnAgregarPromo.Dock = DockStyle.Fill;
            mbtnAgregarPromo.HighEmphasis = true;
            mbtnAgregarPromo.Icon = null;
            mbtnAgregarPromo.Location = new Point(10, 534);
            mbtnAgregarPromo.Margin = new Padding(10, 30, 10, 30);
            mbtnAgregarPromo.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnAgregarPromo.Name = "mbtnAgregarPromo";
            mbtnAgregarPromo.NoAccentTextColor = Color.Empty;
            mbtnAgregarPromo.Size = new Size(486, 34);
            mbtnAgregarPromo.TabIndex = 16;
            mbtnAgregarPromo.Text = "AGREGAR PROMOCIÓN";
            mbtnAgregarPromo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnAgregarPromo.UseAccentColor = false;
            mbtnAgregarPromo.UseVisualStyleBackColor = true;
            // 
            // dgvPromos
            // 
            dgvPromos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPromos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPromos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPromos.Dock = DockStyle.Fill;
            dgvPromos.Location = new Point(685, 36);
            dgvPromos.Name = "dgvPromos";
            dgvPromos.Size = new Size(608, 598);
            dgvPromos.TabIndex = 1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1386, 788);
            Controls.Add(interfazPrincipal);
            DrawerTabControl = interfazPrincipal;
            FormBorderStyle = FormBorderStyle.Sizable;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            interfazPrincipal.ResumeLayout(false);
            tabVentas.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            tabProductos.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            tableLayoutPanel7.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tlpDesbloquearEdicion.ResumeLayout(false);
            tlpDesbloquearEdicion.PerformLayout();
            tlpBotonesProductos.ResumeLayout(false);
            tlpBotonesProductos.PerformLayout();
            tabArqueo.ResumeLayout(false);
            tlpPrincipal.ResumeLayout(false);
            tlpBotonesArriba.ResumeLayout(false);
            tlpBotonesArriba.PerformLayout();
            tlpDescarga.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvArqueo).EndInit();
            tabPromos.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPromos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl interfazPrincipal;
        private TabPage tabVentas;
        private TabPage tabProductos;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPromos;
        private TabPage tabArqueo;
        private TableLayoutPanel tlpPrincipal;
        private TableLayoutPanel tlpBotonesArriba;
        private TableLayoutPanel tlpDescarga;
        private Button btnDescargarPDF;
        private DataGridView dgvArqueo;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox3;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private MaterialSkin.Controls.MaterialRadioButton mrbEfectivo;
        private MaterialSkin.Controls.MaterialRadioButton mrbDebito;
        private MaterialSkin.Controls.MaterialRadioButton mrbCredito;
        private MaterialSkin.Controls.MaterialRadioButton mrbTransferencia;
        private TableLayoutPanel tableLayoutPanel6;
        private DataGridView dgvVentas;
        private MaterialSkin.Controls.MaterialButton mbtnReiniciar;
        private MaterialSkin.Controls.MaterialButton mbtnDevoluciones;
        private MaterialSkin.Controls.MaterialButton mbtnAjustarCaja;
        private MaterialSkin.Controls.MaterialButton mbtnFechaInicio;
        private MaterialSkin.Controls.MaterialButton mbtnFechaFin;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dgvProductos;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel8;
        private MaterialSkin.Controls.MaterialComboBox mcbTipo;
        private MaterialSkin.Controls.MaterialTextBox mtxtPrecioEspecial;
        private DateTimePicker dtpInicioPromo;
        private DateTimePicker dtpFinPromo;
        private TableLayoutPanel tableLayoutPanel9;
        private MaterialSkin.Controls.MaterialTextBox2 mtxtDescripcion;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dgvPromos;
        private Label label6;
        private MaterialSkin.Controls.MaterialButton mbtnAgregarPromo;
        private Panel panel1;
        private ProveeDesk.RoundButton roundButton1;
        private Label label7;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel7;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private Panel panel2;
        private TableLayoutPanel tlpDesbloquearEdicion;
        private MaterialSkin.Controls.MaterialButton btnDesbloquearEdicion;
        private TableLayoutPanel tlpBotonesProductos;
        private MaterialSkin.Controls.MaterialButton btnAgregarProducto;
        private MaterialSkin.Controls.MaterialButton btnBorrarProducto;
        private MaterialSkin.Controls.MaterialButton btnEditarProducto;
        private MaterialSkin.Controls.MaterialButton btnAumentarProducto;
    }
}