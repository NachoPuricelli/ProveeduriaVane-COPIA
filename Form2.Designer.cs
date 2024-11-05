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
            components = new System.ComponentModel.Container();
            interfazPrincipal = new MaterialSkin.Controls.MaterialTabControl();
            tabVentas = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            mbtnReiniciar = new Button();
            mbtnDevolucion = new Button();
            mbtnAjustarCaja = new Button();
            lblEstadosModos = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            mrbEfectivo = new MaterialSkin.Controls.MaterialRadioButton();
            mrbDebito = new MaterialSkin.Controls.MaterialRadioButton();
            mrbCredito = new MaterialSkin.Controls.MaterialRadioButton();
            mrbTransferencia = new MaterialSkin.Controls.MaterialRadioButton();
            tableLayoutPanel6 = new TableLayoutPanel();
            label7 = new Label();
            lblTotal = new Label();
            dgvVentas = new DataGridView();
            tabProductos = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            dgvProductos = new DataGridView();
            tableLayoutPanel7 = new TableLayoutPanel();
            txtBusqueda = new MaterialSkin.Controls.MaterialTextBox();
            cbFiltros = new MaterialSkin.Controls.MaterialComboBox();
            panel2 = new Panel();
            tlpDesbloquearEdicion = new TableLayoutPanel();
            btnDesbloquearEdicion = new MaterialSkin.Controls.MaterialButton();
            tlpBotonesProductos = new TableLayoutPanel();
            btnAgregarProducto = new MaterialSkin.Controls.MaterialButton();
            btnEditarProducto = new MaterialSkin.Controls.MaterialButton();
            btnAjustePorcentual = new MaterialSkin.Controls.MaterialButton();
            btnBorrarProducto = new MaterialSkin.Controls.MaterialButton();
            tabArqueo = new TabPage();
            tlpPrincipal = new TableLayoutPanel();
            dgvArqueo = new DataGridView();
            tableLayoutPanel10 = new TableLayoutPanel();
            tableLayoutPanel16 = new TableLayoutPanel();
            label9 = new Label();
            dtpFinPeriodoArqueo = new DateTimePicker();
            mcbSeccion = new MaterialSkin.Controls.MaterialComboBox();
            tableLayoutPanel15 = new TableLayoutPanel();
            label8 = new Label();
            dtpInicioPeriodoArqueo = new DateTimePicker();
            tableLayoutPanel11 = new TableLayoutPanel();
            btnDescargarPDF = new Button();
            tableLayoutPanel12 = new TableLayoutPanel();
            btnFinalizarDia = new Button();
            tableLayoutPanel13 = new TableLayoutPanel();
            btnGuardarArqueoManual = new Button();
            tableLayoutPanel14 = new TableLayoutPanel();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            txtEfectivo = new MaterialSkin.Controls.MaterialTextBox();
            txtDebito = new MaterialSkin.Controls.MaterialTextBox();
            txtCredito = new MaterialSkin.Controls.MaterialTextBox();
            txtTransferencia = new MaterialSkin.Controls.MaterialTextBox();
            txtTotalFinal = new MaterialSkin.Controls.MaterialTextBox();
            label16 = new Label();
            tabPromos = new TabPage();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            label6 = new Label();
            mcbTipo = new MaterialSkin.Controls.MaterialComboBox();
            mtxtPrecioEspecial = new MaterialSkin.Controls.MaterialTextBox();
            dtpInicioPromo = new DateTimePicker();
            dtpFinPromo = new DateTimePicker();
            tableLayoutPanel9 = new TableLayoutPanel();
            txtProductosPromocion = new TextBox();
            listBoxProductos = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            mbtnAgregarPromo = new MaterialSkin.Controls.MaterialButton();
            dgvPromos = new DataGridView();
            timer1 = new System.Windows.Forms.Timer(components);
            sfdGuardarPDFArqueo = new SaveFileDialog();
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
            ((System.ComponentModel.ISupportInitialize)dgvArqueo).BeginInit();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel16.SuspendLayout();
            tableLayoutPanel15.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            tableLayoutPanel14.SuspendLayout();
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
            interfazPrincipal.Size = new Size(1550, 913);
            interfazPrincipal.SizeMode = TabSizeMode.FillToRight;
            interfazPrincipal.TabIndex = 0;
            interfazPrincipal.KeyDown += interfazPrincipal_KeyDown;
            interfazPrincipal.KeyPress += interfazPrincipal_KeyPress;
            // 
            // tabVentas
            // 
            tabVentas.Controls.Add(tableLayoutPanel1);
            tabVentas.Location = new Point(4, 39);
            tabVentas.Name = "tabVentas";
            tabVentas.Padding = new Padding(3);
            tabVentas.Size = new Size(1542, 870);
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
            tableLayoutPanel1.Size = new Size(1536, 864);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Controls.Add(mbtnReiniciar, 0, 0);
            tableLayoutPanel3.Controls.Add(mbtnDevolucion, 2, 0);
            tableLayoutPanel3.Controls.Add(mbtnAjustarCaja, 3, 0);
            tableLayoutPanel3.Controls.Add(lblEstadosModos, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(79, 46);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1376, 80);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // mbtnReiniciar
            // 
            mbtnReiniciar.BackColor = Color.RoyalBlue;
            mbtnReiniciar.Dock = DockStyle.Fill;
            mbtnReiniciar.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mbtnReiniciar.ForeColor = SystemColors.ControlLightLight;
            mbtnReiniciar.Location = new Point(3, 3);
            mbtnReiniciar.Name = "mbtnReiniciar";
            mbtnReiniciar.Size = new Size(338, 74);
            mbtnReiniciar.TabIndex = 3;
            mbtnReiniciar.Text = "REINICIAR";
            mbtnReiniciar.UseVisualStyleBackColor = false;
            mbtnReiniciar.Click += mbtnReiniciar_Click;
            // 
            // mbtnDevolucion
            // 
            mbtnDevolucion.BackColor = Color.RoyalBlue;
            mbtnDevolucion.Dock = DockStyle.Fill;
            mbtnDevolucion.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            mbtnDevolucion.ForeColor = SystemColors.ControlLightLight;
            mbtnDevolucion.Location = new Point(691, 3);
            mbtnDevolucion.Name = "mbtnDevolucion";
            mbtnDevolucion.Size = new Size(338, 74);
            mbtnDevolucion.TabIndex = 4;
            mbtnDevolucion.Text = "DEVOLUCIONES";
            mbtnDevolucion.UseVisualStyleBackColor = false;
            mbtnDevolucion.Click += mbtnDevolucion_Click;
            // 
            // mbtnAjustarCaja
            // 
            mbtnAjustarCaja.BackColor = Color.RoyalBlue;
            mbtnAjustarCaja.Dock = DockStyle.Fill;
            mbtnAjustarCaja.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            mbtnAjustarCaja.ForeColor = SystemColors.ControlLightLight;
            mbtnAjustarCaja.Location = new Point(1035, 3);
            mbtnAjustarCaja.Name = "mbtnAjustarCaja";
            mbtnAjustarCaja.Size = new Size(338, 74);
            mbtnAjustarCaja.TabIndex = 5;
            mbtnAjustarCaja.Text = "AJUSTAR CAJA";
            mbtnAjustarCaja.UseVisualStyleBackColor = false;
            mbtnAjustarCaja.Click += mbtnAjustarCaja_Click;
            // 
            // lblEstadosModos
            // 
            lblEstadosModos.AutoSize = true;
            lblEstadosModos.Dock = DockStyle.Fill;
            lblEstadosModos.Location = new Point(359, 15);
            lblEstadosModos.Margin = new Padding(15);
            lblEstadosModos.Name = "lblEstadosModos";
            lblEstadosModos.Size = new Size(314, 50);
            lblEstadosModos.TabIndex = 6;
            lblEstadosModos.TextAlign = ContentAlignment.MiddleCenter;
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
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(79, 736);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1376, 80);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // mrbEfectivo
            // 
            mrbEfectivo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mrbEfectivo.AutoSize = true;
            mrbEfectivo.Depth = 0;
            mrbEfectivo.Font = new Font("Microsoft Sans Serif", 12F);
            mrbEfectivo.Location = new Point(412, 0);
            mrbEfectivo.Margin = new Padding(0);
            mrbEfectivo.MouseLocation = new Point(-1, -1);
            mrbEfectivo.MouseState = MaterialSkin.MouseState.HOVER;
            mrbEfectivo.Name = "mrbEfectivo";
            mrbEfectivo.Ripple = true;
            mrbEfectivo.Size = new Size(206, 80);
            mrbEfectivo.TabIndex = 0;
            mrbEfectivo.TabStop = true;
            mrbEfectivo.Text = "EFECTIVO";
            mrbEfectivo.UseVisualStyleBackColor = true;
            // 
            // mrbDebito
            // 
            mrbDebito.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mrbDebito.AutoSize = true;
            mrbDebito.Depth = 0;
            mrbDebito.Font = new Font("Microsoft Sans Serif", 12F);
            mrbDebito.Location = new Point(618, 0);
            mrbDebito.Margin = new Padding(0);
            mrbDebito.MouseLocation = new Point(-1, -1);
            mrbDebito.MouseState = MaterialSkin.MouseState.HOVER;
            mrbDebito.Name = "mrbDebito";
            mrbDebito.Ripple = true;
            mrbDebito.Size = new Size(206, 80);
            mrbDebito.TabIndex = 1;
            mrbDebito.TabStop = true;
            mrbDebito.Text = "DÉBITO";
            mrbDebito.UseVisualStyleBackColor = true;
            // 
            // mrbCredito
            // 
            mrbCredito.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mrbCredito.AutoSize = true;
            mrbCredito.Depth = 0;
            mrbCredito.Font = new Font("Microsoft Sans Serif", 12F);
            mrbCredito.Location = new Point(824, 0);
            mrbCredito.Margin = new Padding(0);
            mrbCredito.MouseLocation = new Point(-1, -1);
            mrbCredito.MouseState = MaterialSkin.MouseState.HOVER;
            mrbCredito.Name = "mrbCredito";
            mrbCredito.Ripple = true;
            mrbCredito.Size = new Size(206, 80);
            mrbCredito.TabIndex = 2;
            mrbCredito.TabStop = true;
            mrbCredito.Text = "CRÉDITO";
            mrbCredito.UseVisualStyleBackColor = true;
            // 
            // mrbTransferencia
            // 
            mrbTransferencia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mrbTransferencia.AutoSize = true;
            mrbTransferencia.Depth = 0;
            mrbTransferencia.Font = new Font("Microsoft Sans Serif", 12F);
            mrbTransferencia.Location = new Point(1030, 0);
            mrbTransferencia.Margin = new Padding(0);
            mrbTransferencia.MouseLocation = new Point(-1, -1);
            mrbTransferencia.MouseState = MaterialSkin.MouseState.HOVER;
            mrbTransferencia.Name = "mrbTransferencia";
            mrbTransferencia.Ripple = true;
            mrbTransferencia.Size = new Size(206, 80);
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
            tableLayoutPanel6.Controls.Add(lblTotal, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(406, 74);
            tableLayoutPanel6.TabIndex = 4;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(115, 74);
            label7.TabIndex = 0;
            label7.Text = "TOTAL:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(124, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(279, 74);
            lblTotal.TabIndex = 1;
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvVentas
            // 
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Dock = DockStyle.Fill;
            dgvVentas.Location = new Point(81, 149);
            dgvVentas.Margin = new Padding(5, 20, 5, 20);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(1372, 564);
            dgvVentas.TabIndex = 2;
            dgvVentas.CellValueChanged += dgvVentas_CellValueChanged;
            // 
            // tabProductos
            // 
            tabProductos.Controls.Add(tableLayoutPanel2);
            tabProductos.Location = new Point(4, 39);
            tabProductos.Name = "tabProductos";
            tabProductos.Padding = new Padding(3);
            tabProductos.Size = new Size(1542, 870);
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
            tableLayoutPanel2.Size = new Size(1536, 864);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // dgvProductos
            // 
            dgvProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(81, 154);
            dgvProductos.Margin = new Padding(5, 25, 5, 20);
            dgvProductos.Name = "dgvProductos";
            tableLayoutPanel2.SetRowSpan(dgvProductos, 2);
            dgvProductos.Size = new Size(1372, 645);
            dgvProductos.TabIndex = 30;
            dgvProductos.CurrentCellDirtyStateChanged += DgvProductos_CurrentCellDirtyStateChanged;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 3;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel7.Controls.Add(txtBusqueda, 0, 0);
            tableLayoutPanel7.Controls.Add(cbFiltros, 1, 0);
            tableLayoutPanel7.Controls.Add(panel2, 2, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(79, 46);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(1376, 80);
            tableLayoutPanel7.TabIndex = 31;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBusqueda.AnimateReadOnly = false;
            txtBusqueda.BorderStyle = BorderStyle.None;
            txtBusqueda.Depth = 0;
            txtBusqueda.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBusqueda.LeadingIcon = null;
            txtBusqueda.Location = new Point(3, 16);
            txtBusqueda.Margin = new Padding(3, 16, 3, 3);
            txtBusqueda.MaxLength = 50;
            txtBusqueda.MouseState = MaterialSkin.MouseState.OUT;
            txtBusqueda.Multiline = false;
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(338, 50);
            txtBusqueda.TabIndex = 0;
            txtBusqueda.Text = "";
            txtBusqueda.TrailingIcon = null;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // cbFiltros
            // 
            cbFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbFiltros.AutoResize = false;
            cbFiltros.BackColor = Color.FromArgb(255, 255, 255);
            cbFiltros.Depth = 0;
            cbFiltros.DrawMode = DrawMode.OwnerDrawVariable;
            cbFiltros.DropDownHeight = 174;
            cbFiltros.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFiltros.DropDownWidth = 121;
            cbFiltros.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbFiltros.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbFiltros.FormattingEnabled = true;
            cbFiltros.IntegralHeight = false;
            cbFiltros.ItemHeight = 43;
            cbFiltros.Items.AddRange(new object[] { "TIPO", "MARCA", "DESCRIPCIÓN" });
            cbFiltros.Location = new Point(347, 16);
            cbFiltros.Margin = new Padding(3, 16, 3, 3);
            cbFiltros.MaxDropDownItems = 4;
            cbFiltros.MouseState = MaterialSkin.MouseState.OUT;
            cbFiltros.Name = "cbFiltros";
            cbFiltros.Size = new Size(269, 49);
            cbFiltros.StartIndex = 0;
            cbFiltros.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(tlpDesbloquearEdicion);
            panel2.Controls.Add(tlpBotonesProductos);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(629, 3);
            panel2.Margin = new Padding(10, 3, 10, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(737, 74);
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
            tlpDesbloquearEdicion.Size = new Size(737, 74);
            tlpDesbloquearEdicion.TabIndex = 1;
            // 
            // btnDesbloquearEdicion
            // 
            btnDesbloquearEdicion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDesbloquearEdicion.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDesbloquearEdicion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDesbloquearEdicion.Depth = 0;
            btnDesbloquearEdicion.HighEmphasis = true;
            btnDesbloquearEdicion.Icon = null;
            btnDesbloquearEdicion.Location = new Point(40, 6);
            btnDesbloquearEdicion.Margin = new Padding(40, 6, 40, 6);
            btnDesbloquearEdicion.MouseState = MaterialSkin.MouseState.HOVER;
            btnDesbloquearEdicion.Name = "btnDesbloquearEdicion";
            btnDesbloquearEdicion.NoAccentTextColor = Color.Empty;
            btnDesbloquearEdicion.Size = new Size(657, 62);
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
            tlpBotonesProductos.Controls.Add(btnEditarProducto, 2, 0);
            tlpBotonesProductos.Controls.Add(btnAjustePorcentual, 3, 0);
            tlpBotonesProductos.Controls.Add(btnBorrarProducto, 1, 0);
            tlpBotonesProductos.Dock = DockStyle.Fill;
            tlpBotonesProductos.Location = new Point(0, 0);
            tlpBotonesProductos.Name = "tlpBotonesProductos";
            tlpBotonesProductos.RowCount = 1;
            tlpBotonesProductos.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBotonesProductos.Size = new Size(737, 74);
            tlpBotonesProductos.TabIndex = 0;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAgregarProducto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAgregarProducto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAgregarProducto.Depth = 0;
            btnAgregarProducto.HighEmphasis = true;
            btnAgregarProducto.Icon = null;
            btnAgregarProducto.Location = new Point(4, 6);
            btnAgregarProducto.Margin = new Padding(4, 6, 4, 6);
            btnAgregarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.NoAccentTextColor = Color.Empty;
            btnAgregarProducto.Size = new Size(176, 62);
            btnAgregarProducto.TabIndex = 0;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAgregarProducto.UseAccentColor = false;
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnEditarProducto
            // 
            btnEditarProducto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEditarProducto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditarProducto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditarProducto.Depth = 0;
            btnEditarProducto.HighEmphasis = true;
            btnEditarProducto.Icon = null;
            btnEditarProducto.Location = new Point(372, 6);
            btnEditarProducto.Margin = new Padding(4, 6, 4, 6);
            btnEditarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.NoAccentTextColor = Color.Empty;
            btnEditarProducto.Size = new Size(176, 62);
            btnEditarProducto.TabIndex = 2;
            btnEditarProducto.Text = "Editar Producto";
            btnEditarProducto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditarProducto.UseAccentColor = false;
            btnEditarProducto.UseVisualStyleBackColor = true;
            btnEditarProducto.Click += btnEditarProducto_Click;
            // 
            // btnAjustePorcentual
            // 
            btnAjustePorcentual.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAjustePorcentual.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAjustePorcentual.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAjustePorcentual.Depth = 0;
            btnAjustePorcentual.HighEmphasis = true;
            btnAjustePorcentual.Icon = null;
            btnAjustePorcentual.Location = new Point(556, 6);
            btnAjustePorcentual.Margin = new Padding(4, 6, 4, 6);
            btnAjustePorcentual.MouseState = MaterialSkin.MouseState.HOVER;
            btnAjustePorcentual.Name = "btnAjustePorcentual";
            btnAjustePorcentual.NoAccentTextColor = Color.Empty;
            btnAjustePorcentual.Size = new Size(177, 62);
            btnAjustePorcentual.TabIndex = 3;
            btnAjustePorcentual.Text = "AJUSTE PORCENTUAL";
            btnAjustePorcentual.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAjustePorcentual.UseAccentColor = false;
            btnAjustePorcentual.UseVisualStyleBackColor = true;
            btnAjustePorcentual.Click += btnAjustePorcentual_Click;
            // 
            // btnBorrarProducto
            // 
            btnBorrarProducto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnBorrarProducto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBorrarProducto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnBorrarProducto.Depth = 0;
            btnBorrarProducto.HighEmphasis = true;
            btnBorrarProducto.Icon = null;
            btnBorrarProducto.Location = new Point(188, 6);
            btnBorrarProducto.Margin = new Padding(4, 6, 4, 6);
            btnBorrarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            btnBorrarProducto.Name = "btnBorrarProducto";
            btnBorrarProducto.NoAccentTextColor = Color.Empty;
            btnBorrarProducto.Size = new Size(176, 62);
            btnBorrarProducto.TabIndex = 1;
            btnBorrarProducto.Text = "Borrar Producto";
            btnBorrarProducto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnBorrarProducto.UseAccentColor = false;
            btnBorrarProducto.UseVisualStyleBackColor = true;
            btnBorrarProducto.Click += btnBorrarProducto_Click;
            // 
            // tabArqueo
            // 
            tabArqueo.Controls.Add(tlpPrincipal);
            tabArqueo.Location = new Point(4, 39);
            tabArqueo.Name = "tabArqueo";
            tabArqueo.Padding = new Padding(3);
            tabArqueo.Size = new Size(1542, 870);
            tabArqueo.TabIndex = 4;
            tabArqueo.Text = "ARQUEO DE CAJA";
            tabArqueo.UseVisualStyleBackColor = true;
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.ColumnCount = 4;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tlpPrincipal.Controls.Add(dgvArqueo, 2, 2);
            tlpPrincipal.Controls.Add(tableLayoutPanel10, 2, 1);
            tlpPrincipal.Controls.Add(tableLayoutPanel11, 2, 3);
            tlpPrincipal.Controls.Add(tableLayoutPanel12, 1, 1);
            tlpPrincipal.Controls.Add(tableLayoutPanel13, 1, 3);
            tlpPrincipal.Controls.Add(tableLayoutPanel14, 1, 2);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Location = new Point(3, 3);
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.RowCount = 5;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlpPrincipal.Size = new Size(1536, 864);
            tlpPrincipal.TabIndex = 0;
            // 
            // dgvArqueo
            // 
            dgvArqueo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvArqueo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvArqueo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArqueo.Dock = DockStyle.Fill;
            dgvArqueo.Location = new Point(556, 149);
            dgvArqueo.Margin = new Padding(20, 20, 10, 10);
            dgvArqueo.Name = "dgvArqueo";
            dgvArqueo.Size = new Size(891, 574);
            dgvArqueo.TabIndex = 2;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 3;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel10.Controls.Add(tableLayoutPanel16, 1, 0);
            tableLayoutPanel10.Controls.Add(mcbSeccion, 2, 0);
            tableLayoutPanel10.Controls.Add(tableLayoutPanel15, 0, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(556, 46);
            tableLayoutPanel10.Margin = new Padding(20, 3, 3, 3);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Size = new Size(898, 80);
            tableLayoutPanel10.TabIndex = 3;
            // 
            // tableLayoutPanel16
            // 
            tableLayoutPanel16.ColumnCount = 1;
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel16.Controls.Add(label9, 0, 0);
            tableLayoutPanel16.Controls.Add(dtpFinPeriodoArqueo, 0, 1);
            tableLayoutPanel16.Dock = DockStyle.Fill;
            tableLayoutPanel16.Location = new Point(272, 3);
            tableLayoutPanel16.Name = "tableLayoutPanel16";
            tableLayoutPanel16.RowCount = 2;
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel16.Size = new Size(263, 74);
            tableLayoutPanel16.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(15, 6);
            label9.Margin = new Padding(15, 6, 15, 3);
            label9.Name = "label9";
            label9.Size = new Size(233, 28);
            label9.TabIndex = 0;
            label9.Text = "FECHA FIN:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpFinPeriodoArqueo
            // 
            dtpFinPeriodoArqueo.Dock = DockStyle.Fill;
            dtpFinPeriodoArqueo.Location = new Point(15, 39);
            dtpFinPeriodoArqueo.Margin = new Padding(15, 2, 15, 0);
            dtpFinPeriodoArqueo.Name = "dtpFinPeriodoArqueo";
            dtpFinPeriodoArqueo.Size = new Size(233, 23);
            dtpFinPeriodoArqueo.TabIndex = 1;
            // 
            // mcbSeccion
            // 
            mcbSeccion.AutoResize = false;
            mcbSeccion.BackColor = Color.FromArgb(255, 255, 255);
            mcbSeccion.Depth = 0;
            mcbSeccion.Dock = DockStyle.Fill;
            mcbSeccion.DrawMode = DrawMode.OwnerDrawVariable;
            mcbSeccion.DropDownHeight = 174;
            mcbSeccion.DropDownStyle = ComboBoxStyle.DropDownList;
            mcbSeccion.DropDownWidth = 121;
            mcbSeccion.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            mcbSeccion.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcbSeccion.FormattingEnabled = true;
            mcbSeccion.IntegralHeight = false;
            mcbSeccion.ItemHeight = 43;
            mcbSeccion.Items.AddRange(new object[] { "Ventas", "Total según medio de pago", "Resumen final", "Resultados manuales" });
            mcbSeccion.Location = new Point(548, 6);
            mcbSeccion.Margin = new Padding(10, 6, 10, 3);
            mcbSeccion.MaxDropDownItems = 4;
            mcbSeccion.MouseState = MaterialSkin.MouseState.OUT;
            mcbSeccion.Name = "mcbSeccion";
            mcbSeccion.Size = new Size(340, 49);
            mcbSeccion.StartIndex = 0;
            mcbSeccion.TabIndex = 0;
            mcbSeccion.SelectedIndexChanged += mcbSeccion_SelectedIndexChanged;
            // 
            // tableLayoutPanel15
            // 
            tableLayoutPanel15.ColumnCount = 1;
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel15.Controls.Add(label8, 0, 0);
            tableLayoutPanel15.Controls.Add(dtpInicioPeriodoArqueo, 0, 1);
            tableLayoutPanel15.Dock = DockStyle.Fill;
            tableLayoutPanel15.Location = new Point(3, 3);
            tableLayoutPanel15.Name = "tableLayoutPanel15";
            tableLayoutPanel15.RowCount = 2;
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel15.Size = new Size(263, 74);
            tableLayoutPanel15.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(15, 6);
            label8.Margin = new Padding(15, 6, 15, 3);
            label8.Name = "label8";
            label8.Size = new Size(233, 28);
            label8.TabIndex = 0;
            label8.Text = "FECHA INICIO:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpInicioPeriodoArqueo
            // 
            dtpInicioPeriodoArqueo.Dock = DockStyle.Fill;
            dtpInicioPeriodoArqueo.Location = new Point(15, 39);
            dtpInicioPeriodoArqueo.Margin = new Padding(15, 2, 15, 0);
            dtpInicioPeriodoArqueo.Name = "dtpInicioPeriodoArqueo";
            dtpInicioPeriodoArqueo.Size = new Size(233, 23);
            dtpInicioPeriodoArqueo.TabIndex = 1;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 2;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel11.Controls.Add(btnDescargarPDF, 1, 0);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(556, 736);
            tableLayoutPanel11.Margin = new Padding(20, 3, 10, 3);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.Size = new Size(891, 80);
            tableLayoutPanel11.TabIndex = 4;
            // 
            // btnDescargarPDF
            // 
            btnDescargarPDF.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDescargarPDF.Location = new Point(537, 3);
            btnDescargarPDF.Name = "btnDescargarPDF";
            btnDescargarPDF.Size = new Size(351, 74);
            btnDescargarPDF.TabIndex = 0;
            btnDescargarPDF.Text = "DESCARGAR PDF";
            btnDescargarPDF.UseVisualStyleBackColor = true;
            btnDescargarPDF.Click += btnDescargarPDF_Click;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel12.ColumnCount = 2;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel12.Controls.Add(btnFinalizarDia, 0, 0);
            tableLayoutPanel12.Location = new Point(86, 46);
            tableLayoutPanel12.Margin = new Padding(10, 3, 20, 3);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 1;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.Size = new Size(430, 80);
            tableLayoutPanel12.TabIndex = 5;
            // 
            // btnFinalizarDia
            // 
            btnFinalizarDia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnFinalizarDia.Location = new Point(3, 3);
            btnFinalizarDia.Name = "btnFinalizarDia";
            btnFinalizarDia.Size = new Size(187, 74);
            btnFinalizarDia.TabIndex = 0;
            btnFinalizarDia.Text = "FINALIZAR DÍA";
            btnFinalizarDia.UseVisualStyleBackColor = true;
            btnFinalizarDia.Click += btnFinalizarDia_Click;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 3;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel13.Controls.Add(btnGuardarArqueoManual, 1, 0);
            tableLayoutPanel13.Dock = DockStyle.Fill;
            tableLayoutPanel13.Location = new Point(86, 736);
            tableLayoutPanel13.Margin = new Padding(10, 3, 20, 3);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 1;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel13.Size = new Size(430, 80);
            tableLayoutPanel13.TabIndex = 6;
            // 
            // btnGuardarArqueoManual
            // 
            btnGuardarArqueoManual.Dock = DockStyle.Fill;
            btnGuardarArqueoManual.Location = new Point(67, 3);
            btnGuardarArqueoManual.Name = "btnGuardarArqueoManual";
            btnGuardarArqueoManual.Size = new Size(295, 74);
            btnGuardarArqueoManual.TabIndex = 0;
            btnGuardarArqueoManual.Text = "REALIZAR ARQUEO MANUAL";
            btnGuardarArqueoManual.UseVisualStyleBackColor = true;
            btnGuardarArqueoManual.Click += btnGuardarArqueoManual_Click;
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.ColumnCount = 4;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2F));
            tableLayoutPanel14.Controls.Add(label11, 1, 1);
            tableLayoutPanel14.Controls.Add(label12, 1, 2);
            tableLayoutPanel14.Controls.Add(label13, 1, 3);
            tableLayoutPanel14.Controls.Add(label14, 1, 4);
            tableLayoutPanel14.Controls.Add(label15, 1, 5);
            tableLayoutPanel14.Controls.Add(txtEfectivo, 2, 1);
            tableLayoutPanel14.Controls.Add(txtDebito, 2, 2);
            tableLayoutPanel14.Controls.Add(txtCredito, 2, 3);
            tableLayoutPanel14.Controls.Add(txtTransferencia, 2, 4);
            tableLayoutPanel14.Controls.Add(txtTotalFinal, 2, 5);
            tableLayoutPanel14.Controls.Add(label16, 1, 0);
            tableLayoutPanel14.Dock = DockStyle.Fill;
            tableLayoutPanel14.Location = new Point(79, 149);
            tableLayoutPanel14.Margin = new Padding(3, 20, 3, 10);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 7;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel14.Size = new Size(454, 574);
            tableLayoutPanel14.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Location = new Point(14, 96);
            label11.Margin = new Padding(5, 10, 5, 10);
            label11.Name = "label11";
            label11.Size = new Size(207, 71);
            label11.TabIndex = 0;
            label11.Text = "TOTAL EFECTIVO:";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Fill;
            label12.Location = new Point(14, 187);
            label12.Margin = new Padding(5, 10, 5, 10);
            label12.Name = "label12";
            label12.Size = new Size(207, 71);
            label12.TabIndex = 1;
            label12.Text = "TOTAL DÉBITO:";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Dock = DockStyle.Fill;
            label13.Location = new Point(14, 278);
            label13.Margin = new Padding(5, 10, 5, 10);
            label13.Name = "label13";
            label13.Size = new Size(207, 71);
            label13.TabIndex = 2;
            label13.Text = "TOTAL CRÉDITO:";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Dock = DockStyle.Fill;
            label14.Location = new Point(14, 369);
            label14.Margin = new Padding(5, 10, 5, 10);
            label14.Name = "label14";
            label14.Size = new Size(207, 71);
            label14.TabIndex = 3;
            label14.Text = "TOTAL TRANSFERENCIA:";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Dock = DockStyle.Fill;
            label15.Location = new Point(14, 460);
            label15.Margin = new Padding(5, 10, 5, 10);
            label15.Name = "label15";
            label15.Size = new Size(207, 71);
            label15.TabIndex = 4;
            label15.Text = "TOTAL FINAL:";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEfectivo
            // 
            txtEfectivo.AnimateReadOnly = false;
            txtEfectivo.BorderStyle = BorderStyle.None;
            txtEfectivo.Depth = 0;
            txtEfectivo.Dock = DockStyle.Fill;
            txtEfectivo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEfectivo.LeadingIcon = null;
            txtEfectivo.Location = new Point(236, 96);
            txtEfectivo.Margin = new Padding(10);
            txtEfectivo.MaxLength = 50;
            txtEfectivo.MouseState = MaterialSkin.MouseState.OUT;
            txtEfectivo.Multiline = false;
            txtEfectivo.Name = "txtEfectivo";
            txtEfectivo.Size = new Size(197, 50);
            txtEfectivo.TabIndex = 1;
            txtEfectivo.Text = "";
            txtEfectivo.TrailingIcon = null;
            // 
            // txtDebito
            // 
            txtDebito.AnimateReadOnly = false;
            txtDebito.BorderStyle = BorderStyle.None;
            txtDebito.Depth = 0;
            txtDebito.Dock = DockStyle.Fill;
            txtDebito.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDebito.LeadingIcon = null;
            txtDebito.Location = new Point(236, 187);
            txtDebito.Margin = new Padding(10);
            txtDebito.MaxLength = 50;
            txtDebito.MouseState = MaterialSkin.MouseState.OUT;
            txtDebito.Multiline = false;
            txtDebito.Name = "txtDebito";
            txtDebito.Size = new Size(197, 50);
            txtDebito.TabIndex = 2;
            txtDebito.Text = "";
            txtDebito.TrailingIcon = null;
            // 
            // txtCredito
            // 
            txtCredito.AnimateReadOnly = false;
            txtCredito.BorderStyle = BorderStyle.None;
            txtCredito.Depth = 0;
            txtCredito.Dock = DockStyle.Fill;
            txtCredito.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCredito.LeadingIcon = null;
            txtCredito.Location = new Point(236, 278);
            txtCredito.Margin = new Padding(10);
            txtCredito.MaxLength = 50;
            txtCredito.MouseState = MaterialSkin.MouseState.OUT;
            txtCredito.Multiline = false;
            txtCredito.Name = "txtCredito";
            txtCredito.Size = new Size(197, 50);
            txtCredito.TabIndex = 3;
            txtCredito.Text = "";
            txtCredito.TrailingIcon = null;
            // 
            // txtTransferencia
            // 
            txtTransferencia.AnimateReadOnly = false;
            txtTransferencia.BorderStyle = BorderStyle.None;
            txtTransferencia.Depth = 0;
            txtTransferencia.Dock = DockStyle.Fill;
            txtTransferencia.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTransferencia.LeadingIcon = null;
            txtTransferencia.Location = new Point(236, 369);
            txtTransferencia.Margin = new Padding(10);
            txtTransferencia.MaxLength = 50;
            txtTransferencia.MouseState = MaterialSkin.MouseState.OUT;
            txtTransferencia.Multiline = false;
            txtTransferencia.Name = "txtTransferencia";
            txtTransferencia.Size = new Size(197, 50);
            txtTransferencia.TabIndex = 4;
            txtTransferencia.Text = "";
            txtTransferencia.TrailingIcon = null;
            // 
            // txtTotalFinal
            // 
            txtTotalFinal.AnimateReadOnly = false;
            txtTotalFinal.BorderStyle = BorderStyle.None;
            txtTotalFinal.Depth = 0;
            txtTotalFinal.Dock = DockStyle.Fill;
            txtTotalFinal.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTotalFinal.LeadingIcon = null;
            txtTotalFinal.Location = new Point(236, 460);
            txtTotalFinal.Margin = new Padding(10);
            txtTotalFinal.MaxLength = 50;
            txtTotalFinal.MouseState = MaterialSkin.MouseState.OUT;
            txtTotalFinal.Multiline = false;
            txtTotalFinal.Name = "txtTotalFinal";
            txtTotalFinal.Size = new Size(197, 50);
            txtTotalFinal.TabIndex = 5;
            txtTotalFinal.Text = "";
            txtTotalFinal.TrailingIcon = null;
            // 
            // label16
            // 
            label16.AutoSize = true;
            tableLayoutPanel14.SetColumnSpan(label16, 2);
            label16.Dock = DockStyle.Fill;
            label16.Location = new Point(12, 3);
            label16.Margin = new Padding(3);
            label16.Name = "label16";
            label16.Padding = new Padding(5);
            label16.Size = new Size(428, 80);
            label16.TabIndex = 10;
            label16.Text = "Realice un arqueo de caja manual (luego de finalizar el día) para comparar los resultados:";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabPromos
            // 
            tabPromos.Controls.Add(tableLayoutPanel5);
            tabPromos.Location = new Point(4, 39);
            tabPromos.Name = "tabPromos";
            tabPromos.Padding = new Padding(3);
            tabPromos.Size = new Size(1542, 870);
            tabPromos.TabIndex = 3;
            tabPromos.Text = "PROMOCIONES";
            tabPromos.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 5;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel8, 1, 1);
            tableLayoutPanel5.Controls.Add(dgvPromos, 3, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel5.Size = new Size(1536, 864);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.21344F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.78656F));
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
            tableLayoutPanel8.Location = new Point(96, 46);
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
            tableLayoutPanel8.Size = new Size(574, 771);
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
            label6.Location = new Point(10, 10);
            label6.Margin = new Padding(10);
            label6.Name = "label6";
            label6.Size = new Size(554, 95);
            label6.TabIndex = 15;
            label6.Text = "INGRESE UNA NUEVA PROMOCION COMPLETANDO LOS CAMPOS: ";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mcbTipo
            // 
            mcbTipo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mcbTipo.AutoResize = false;
            mcbTipo.BackColor = Color.FromArgb(255, 255, 255);
            mcbTipo.Depth = 0;
            mcbTipo.DrawMode = DrawMode.OwnerDrawVariable;
            mcbTipo.DropDownHeight = 174;
            mcbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            mcbTipo.DropDownWidth = 150;
            mcbTipo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            mcbTipo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcbTipo.FormattingEnabled = true;
            mcbTipo.IntegralHeight = false;
            mcbTipo.ItemHeight = 43;
            mcbTipo.Items.AddRange(new object[] { "COMBO", "DESCUENTO", "3X2", "2X1", "3X1" });
            mcbTipo.Location = new Point(194, 140);
            mcbTipo.Margin = new Padding(10, 25, 10, 20);
            mcbTipo.MaxDropDownItems = 4;
            mcbTipo.MouseState = MaterialSkin.MouseState.OUT;
            mcbTipo.Name = "mcbTipo";
            mcbTipo.Size = new Size(370, 49);
            mcbTipo.StartIndex = 0;
            mcbTipo.TabIndex = 1;
            mcbTipo.SelectedIndexChanged += mcbTipo_SelectedIndexChanged;
            // 
            // mtxtPrecioEspecial
            // 
            mtxtPrecioEspecial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mtxtPrecioEspecial.AnimateReadOnly = false;
            mtxtPrecioEspecial.BorderStyle = BorderStyle.None;
            mtxtPrecioEspecial.Depth = 0;
            mtxtPrecioEspecial.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtxtPrecioEspecial.LeadingIcon = null;
            mtxtPrecioEspecial.Location = new Point(194, 354);
            mtxtPrecioEspecial.Margin = new Padding(10, 25, 10, 20);
            mtxtPrecioEspecial.MaxLength = 50;
            mtxtPrecioEspecial.MouseState = MaterialSkin.MouseState.OUT;
            mtxtPrecioEspecial.Multiline = false;
            mtxtPrecioEspecial.Name = "mtxtPrecioEspecial";
            mtxtPrecioEspecial.Size = new Size(370, 50);
            mtxtPrecioEspecial.TabIndex = 3;
            mtxtPrecioEspecial.Text = "";
            mtxtPrecioEspecial.TrailingIcon = null;
            // 
            // dtpInicioPromo
            // 
            dtpInicioPromo.Dock = DockStyle.Fill;
            dtpInicioPromo.Font = new Font("Microsoft Sans Serif", 11.25F);
            dtpInicioPromo.Location = new Point(194, 476);
            dtpInicioPromo.Margin = new Padding(10, 40, 10, 20);
            dtpInicioPromo.Name = "dtpInicioPromo";
            dtpInicioPromo.Size = new Size(370, 24);
            dtpInicioPromo.TabIndex = 4;
            // 
            // dtpFinPromo
            // 
            dtpFinPromo.Dock = DockStyle.Fill;
            dtpFinPromo.Font = new Font("Microsoft Sans Serif", 11.25F);
            dtpFinPromo.Location = new Point(194, 583);
            dtpFinPromo.Margin = new Padding(10, 40, 10, 20);
            dtpFinPromo.Name = "dtpFinPromo";
            dtpFinPromo.Size = new Size(370, 24);
            dtpFinPromo.TabIndex = 5;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Controls.Add(txtProductosPromocion, 0, 0);
            tableLayoutPanel9.Controls.Add(listBoxProductos, 1, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(187, 225);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Size = new Size(384, 101);
            tableLayoutPanel9.TabIndex = 9;
            // 
            // txtProductosPromocion
            // 
            txtProductosPromocion.Dock = DockStyle.Fill;
            txtProductosPromocion.Location = new Point(3, 3);
            txtProductosPromocion.Multiline = true;
            txtProductosPromocion.Name = "txtProductosPromocion";
            txtProductosPromocion.Size = new Size(186, 95);
            txtProductosPromocion.TabIndex = 3;
            txtProductosPromocion.KeyPress += txtProductosPromocion_KeyPress;
            // 
            // listBoxProductos
            // 
            listBoxProductos.BorderStyle = BorderStyle.FixedSingle;
            listBoxProductos.Dock = DockStyle.Fill;
            listBoxProductos.FormattingEnabled = true;
            listBoxProductos.ItemHeight = 15;
            listBoxProductos.Location = new Point(195, 3);
            listBoxProductos.Name = "listBoxProductos";
            listBoxProductos.Size = new Size(186, 95);
            listBoxProductos.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RoyalBlue;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(10, 125);
            label1.Margin = new Padding(10);
            label1.Name = "label1";
            label1.Size = new Size(164, 87);
            label1.TabIndex = 10;
            label1.Text = "TIPO PROMO:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.RoyalBlue;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(10, 232);
            label2.Margin = new Padding(10);
            label2.Name = "label2";
            label2.Size = new Size(164, 87);
            label2.TabIndex = 11;
            label2.Text = "PRODUCTO:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.RoyalBlue;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(10, 339);
            label3.Margin = new Padding(10);
            label3.Name = "label3";
            label3.Size = new Size(164, 87);
            label3.TabIndex = 12;
            label3.Text = "PRECIO:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.RoyalBlue;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(10, 446);
            label4.Margin = new Padding(10);
            label4.Name = "label4";
            label4.Size = new Size(164, 87);
            label4.TabIndex = 13;
            label4.Text = "INICIO:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.RoyalBlue;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(10, 553);
            label5.Margin = new Padding(10);
            label5.Name = "label5";
            label5.Size = new Size(164, 87);
            label5.TabIndex = 14;
            label5.Text = "FIN:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mbtnAgregarPromo
            // 
            mbtnAgregarPromo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mbtnAgregarPromo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel8.SetColumnSpan(mbtnAgregarPromo, 2);
            mbtnAgregarPromo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnAgregarPromo.Depth = 0;
            mbtnAgregarPromo.HighEmphasis = true;
            mbtnAgregarPromo.Icon = null;
            mbtnAgregarPromo.Location = new Point(10, 680);
            mbtnAgregarPromo.Margin = new Padding(10, 30, 10, 30);
            mbtnAgregarPromo.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnAgregarPromo.Name = "mbtnAgregarPromo";
            mbtnAgregarPromo.NoAccentTextColor = Color.Empty;
            mbtnAgregarPromo.Size = new Size(554, 61);
            mbtnAgregarPromo.TabIndex = 6;
            mbtnAgregarPromo.Text = "AGREGAR PROMOCIÓN";
            mbtnAgregarPromo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnAgregarPromo.UseAccentColor = false;
            mbtnAgregarPromo.UseVisualStyleBackColor = true;
            mbtnAgregarPromo.Click += mbtnAgregarPromo_Click;
            // 
            // dgvPromos
            // 
            dgvPromos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPromos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPromos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPromos.Dock = DockStyle.Fill;
            dgvPromos.Location = new Point(723, 53);
            dgvPromos.Margin = new Padding(3, 10, 3, 30);
            dgvPromos.Name = "dgvPromos";
            dgvPromos.Size = new Size(731, 737);
            dgvPromos.TabIndex = 1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1556, 980);
            Controls.Add(interfazPrincipal);
            DrawerTabControl = interfazPrincipal;
            FormBorderStyle = FormBorderStyle.Sizable;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Activated += Form2_Activated;
            Load += Form2_Load;
            Shown += Form2_Shown;
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
            ((System.ComponentModel.ISupportInitialize)dgvArqueo).EndInit();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel16.ResumeLayout(false);
            tableLayoutPanel16.PerformLayout();
            tableLayoutPanel15.ResumeLayout(false);
            tableLayoutPanel15.PerformLayout();
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel14.PerformLayout();
            tabPromos.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
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
        private DataGridView dgvArqueo;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private MaterialSkin.Controls.MaterialRadioButton mrbEfectivo;
        private MaterialSkin.Controls.MaterialRadioButton mrbDebito;
        private MaterialSkin.Controls.MaterialRadioButton mrbCredito;
        private MaterialSkin.Controls.MaterialRadioButton mrbTransferencia;
        private TableLayoutPanel tableLayoutPanel6;
        private DataGridView dgvVentas;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dgvProductos;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel8;
        private MaterialSkin.Controls.MaterialComboBox mcbTipo;
        private MaterialSkin.Controls.MaterialTextBox mtxtPrecioEspecial;
        private DateTimePicker dtpInicioPromo;
        private DateTimePicker dtpFinPromo;
        private TableLayoutPanel tableLayoutPanel9;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dgvPromos;
        private Label label6;
        private MaterialSkin.Controls.MaterialButton mbtnAgregarPromo;
        private Label label7;
        private Label lblTotal;
        private TableLayoutPanel tableLayoutPanel7;
        private MaterialSkin.Controls.MaterialTextBox txtBusqueda;
        private MaterialSkin.Controls.MaterialComboBox cbFiltros;
        private Panel panel2;
        private TableLayoutPanel tlpDesbloquearEdicion;
        private MaterialSkin.Controls.MaterialButton btnDesbloquearEdicion;
        private TableLayoutPanel tlpBotonesProductos;
        private MaterialSkin.Controls.MaterialButton btnAgregarProducto;
        private MaterialSkin.Controls.MaterialButton btnBorrarProducto;
        private MaterialSkin.Controls.MaterialButton btnEditarProducto;
        private MaterialSkin.Controls.MaterialButton btnAjustePorcentual;
        private Button mbtnReiniciar;
        private Button mbtnDevolucion;
        private System.Windows.Forms.Timer timer1;
        private TableLayoutPanel tableLayoutPanel10;
        private MaterialSkin.Controls.MaterialComboBox mcbSeccion;
        private TableLayoutPanel tableLayoutPanel11;
        private Button btnDescargarPDF;
        private TableLayoutPanel tableLayoutPanel12;
        private Button btnFinalizarDia;
        private TableLayoutPanel tableLayoutPanel13;
        private Button btnGuardarArqueoManual;
        private TableLayoutPanel tableLayoutPanel14;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private MaterialSkin.Controls.MaterialTextBox txtEfectivo;
        private MaterialSkin.Controls.MaterialTextBox txtDebito;
        private MaterialSkin.Controls.MaterialTextBox txtCredito;
        private MaterialSkin.Controls.MaterialTextBox txtTransferencia;
        private MaterialSkin.Controls.MaterialTextBox txtTotalFinal;
        private Label label16;
        private Button mbtnAjustarCaja;
        private SaveFileDialog sfdGuardarPDFArqueo;
        private TableLayoutPanel tableLayoutPanel16;
        private TableLayoutPanel tableLayoutPanel15;
        private Label label9;
        private DateTimePicker dtpFinPeriodoArqueo;
        private Label label8;
        private DateTimePicker dtpInicioPeriodoArqueo;
        private TextBox txtProductosPromocion;
        private ListBox listBoxProductos;
        private Label lblEstadosModos;
    }
}