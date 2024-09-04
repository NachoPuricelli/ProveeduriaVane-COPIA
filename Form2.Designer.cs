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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            tlpPrincipal = new TableLayoutPanel();
            tlpBotonesArriba = new TableLayoutPanel();
            mcbFechaInicio = new MaterialSkin.Controls.MaterialComboBox();
            mcbFechaFin = new MaterialSkin.Controls.MaterialComboBox();
            materialComboBox3 = new MaterialSkin.Controls.MaterialComboBox();
            tlpDescarga = new TableLayoutPanel();
            btnDescargarPDF = new Button();
            dgvArqueo = new DataGridView();
            tabPromos = new TabPage();
            tableLayoutPanel5 = new TableLayoutPanel();
            gbPromociones = new GroupBox();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            dtpFechaInicio = new DateTimePicker();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            mtxtPrecioEspecial = new MaterialSkin.Controls.MaterialTextBox2();
            mcbTipo = new MaterialSkin.Controls.MaterialComboBox();
            btnEscanearPromocion = new Button();
            mtxtDescripcion = new MaterialSkin.Controls.MaterialTextBox2();
            dtpFechaFin = new DateTimePicker();
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
            tlpPrincipal.SuspendLayout();
            tlpBotonesArriba.SuspendLayout();
            tlpDescarga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArqueo).BeginInit();
            tabPromos.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            gbPromociones.SuspendLayout();
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
            interfazPrincipal.MouseState = MaterialSkin.MouseState.HOVER;
            interfazPrincipal.Multiline = true;
            interfazPrincipal.Name = "interfazPrincipal";
            interfazPrincipal.SelectedIndex = 0;
            interfazPrincipal.Size = new Size(1466, 913);
            interfazPrincipal.TabIndex = 0;
            // 
            // tabVentas
            // 
            tabVentas.Controls.Add(tlVentas);
            tabVentas.Location = new Point(4, 39);
            tabVentas.Name = "tabVentas";
            tabVentas.Padding = new Padding(3);
            tabVentas.Size = new Size(1458, 870);
            tabVentas.TabIndex = 0;
            tabVentas.Text = "VENTAS";
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
            tlVentas.Size = new Size(1452, 864);
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
            btnAgregarDevolucion.Location = new Point(752, 6);
            btnAgregarDevolucion.Margin = new Padding(4, 6, 4, 6);
            btnAgregarDevolucion.MouseState = MaterialSkin.MouseState.HOVER;
            btnAgregarDevolucion.Name = "btnAgregarDevolucion";
            btnAgregarDevolucion.NoAccentTextColor = Color.Empty;
            btnAgregarDevolucion.Size = new Size(383, 57);
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tlVentas.SetColumnSpan(dgvVentas, 5);
            dgvVentas.Dock = DockStyle.Fill;
            dgvVentas.Location = new Point(3, 72);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.Size = new Size(1446, 719);
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
            btnAjustarCaja.Location = new Point(1143, 6);
            btnAjustarCaja.Margin = new Padding(4, 6, 4, 6);
            btnAjustarCaja.MouseState = MaterialSkin.MouseState.HOVER;
            btnAjustarCaja.Name = "btnAjustarCaja";
            btnAjustarCaja.NoAccentTextColor = Color.Empty;
            btnAjustarCaja.Size = new Size(305, 57);
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
            btnReiniciarLista.Size = new Size(198, 57);
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
            tlMediosPago.Location = new Point(3, 797);
            tlMediosPago.Name = "tlMediosPago";
            tlMediosPago.RowCount = 1;
            tlMediosPago.RowStyles.Add(new RowStyle());
            tlMediosPago.Size = new Size(1446, 64);
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
            rbCredito.Location = new Point(632, 3);
            rbCredito.Name = "rbCredito";
            rbCredito.Padding = new Padding(0, 0, 4, 4);
            rbCredito.Size = new Size(157, 58);
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
            rbTrasferencia.Location = new Point(795, 3);
            rbTrasferencia.Name = "rbTrasferencia";
            rbTrasferencia.Padding = new Padding(0, 0, 4, 4);
            rbTrasferencia.Size = new Size(253, 58);
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
            tableLayoutPanel1.Size = new Size(290, 58);
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
            lblTotal.Size = new Size(101, 58);
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
            lblSaldo.Location = new Point(110, 0);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Padding = new Padding(0, 0, 0, 4);
            lblSaldo.Size = new Size(177, 58);
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
            rbEfectivo.Location = new Point(299, 3);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Padding = new Padding(0, 0, 4, 4);
            rbEfectivo.Size = new Size(176, 58);
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
            rbDebito.Location = new Point(481, 3);
            rbDebito.Name = "rbDebito";
            rbDebito.Padding = new Padding(0, 0, 4, 4);
            rbDebito.Size = new Size(145, 58);
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
            tabProductos.Size = new Size(1458, 870);
            tabProductos.TabIndex = 1;
            tabProductos.Text = "PRODUCTOS";
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
            tlProductos.Size = new Size(1452, 864);
            tlProductos.TabIndex = 0;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tlProductos.SetColumnSpan(dgvProductos, 7);
            dgvProductos.Dock = DockStyle.Fill;
            dgvProductos.Location = new Point(20, 108);
            dgvProductos.Margin = new Padding(20, 30, 20, 40);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            tlProductos.SetRowSpan(dgvProductos, 10);
            dgvProductos.Size = new Size(1412, 716);
            dgvProductos.TabIndex = 27;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            tableLayoutPanel2.Location = new Point(20, 20);
            tableLayoutPanel2.Margin = new Padding(20, 20, 20, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1412, 55);
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
            btnBorrarProducto.Location = new Point(709, 6);
            btnBorrarProducto.Margin = new Padding(4, 6, 4, 6);
            btnBorrarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            btnBorrarProducto.Name = "btnBorrarProducto";
            btnBorrarProducto.NoAccentTextColor = Color.Empty;
            btnBorrarProducto.Size = new Size(227, 43);
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
            btnAgregarProducto.Location = new Point(474, 6);
            btnAgregarProducto.Margin = new Padding(4, 6, 4, 6);
            btnAgregarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.NoAccentTextColor = Color.Empty;
            btnAgregarProducto.Size = new Size(227, 43);
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
            cbFiltros.Dock = DockStyle.Fill;
            cbFiltros.FlatStyle = FlatStyle.Popup;
            cbFiltros.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbFiltros.ForeColor = SystemColors.Info;
            cbFiltros.FormattingEnabled = true;
            cbFiltros.Items.AddRange(new object[] { "Tipo", "Marca", "Descripción" });
            cbFiltros.Location = new Point(250, 13);
            cbFiltros.Margin = new Padding(15, 13, 15, 3);
            cbFiltros.Name = "cbFiltros";
            cbFiltros.Size = new Size(205, 28);
            cbFiltros.TabIndex = 29;
            cbFiltros.Text = "Filtros";
            // 
            // txtFiltros
            // 
            txtFiltros.BackColor = Color.Blue;
            txtFiltros.BorderStyle = BorderStyle.FixedSingle;
            txtFiltros.Dock = DockStyle.Fill;
            txtFiltros.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFiltros.ForeColor = SystemColors.Info;
            txtFiltros.Location = new Point(3, 7);
            txtFiltros.Margin = new Padding(3, 7, 3, 3);
            txtFiltros.Multiline = true;
            txtFiltros.Name = "txtFiltros";
            txtFiltros.Size = new Size(229, 45);
            txtFiltros.TabIndex = 28;
            // 
            // panel1
            // 
            tableLayoutPanel2.SetColumnSpan(panel1, 2);
            panel1.Controls.Add(btnEditarProductos);
            panel1.Controls.Add(btnAumentarProducto);
            panel1.Controls.Add(btnDesbloquearEdicion);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1109, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 49);
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
            btnDesbloquearEdicion.Size = new Size(230, 49);
            btnDesbloquearEdicion.TabIndex = 26;
            btnDesbloquearEdicion.Text = "Desbloquear modo edición";
            btnDesbloquearEdicion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDesbloquearEdicion.UseAccentColor = false;
            btnDesbloquearEdicion.UseVisualStyleBackColor = true;
            // 
            // tabArqueo
            // 
            tabArqueo.Controls.Add(tlpPrincipal);
            tabArqueo.Location = new Point(4, 39);
            tabArqueo.Name = "tabArqueo";
            tabArqueo.Padding = new Padding(3);
            tabArqueo.Size = new Size(1458, 870);
            tabArqueo.TabIndex = 4;
            tabArqueo.Text = "ARQUEO DE CAJA";
            tabArqueo.UseVisualStyleBackColor = true;
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.ColumnCount = 3;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
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
            tlpPrincipal.Size = new Size(1452, 864);
            tlpPrincipal.TabIndex = 0;
            // 
            // tlpBotonesArriba
            // 
            tlpBotonesArriba.ColumnCount = 4;
            tlpBotonesArriba.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpBotonesArriba.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpBotonesArriba.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpBotonesArriba.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpBotonesArriba.Controls.Add(mcbFechaInicio, 0, 0);
            tlpBotonesArriba.Controls.Add(mcbFechaFin, 1, 0);
            tlpBotonesArriba.Controls.Add(materialComboBox3, 3, 0);
            tlpBotonesArriba.Dock = DockStyle.Fill;
            tlpBotonesArriba.Location = new Point(148, 46);
            tlpBotonesArriba.Margin = new Padding(3, 3, 3, 15);
            tlpBotonesArriba.Name = "tlpBotonesArriba";
            tlpBotonesArriba.RowCount = 1;
            tlpBotonesArriba.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBotonesArriba.Size = new Size(1155, 68);
            tlpBotonesArriba.TabIndex = 0;
            // 
            // mcbFechaInicio
            // 
            mcbFechaInicio.AutoResize = false;
            mcbFechaInicio.BackColor = Color.FromArgb(255, 255, 255);
            mcbFechaInicio.Depth = 0;
            mcbFechaInicio.Dock = DockStyle.Fill;
            mcbFechaInicio.DrawMode = DrawMode.OwnerDrawVariable;
            mcbFechaInicio.DropDownHeight = 174;
            mcbFechaInicio.DropDownStyle = ComboBoxStyle.DropDownList;
            mcbFechaInicio.DropDownWidth = 121;
            mcbFechaInicio.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            mcbFechaInicio.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcbFechaInicio.FormattingEnabled = true;
            mcbFechaInicio.IntegralHeight = false;
            mcbFechaInicio.ItemHeight = 43;
            mcbFechaInicio.Location = new Point(3, 3);
            mcbFechaInicio.MaxDropDownItems = 4;
            mcbFechaInicio.MouseState = MaterialSkin.MouseState.OUT;
            mcbFechaInicio.Name = "mcbFechaInicio";
            mcbFechaInicio.Size = new Size(225, 49);
            mcbFechaInicio.StartIndex = 0;
            mcbFechaInicio.TabIndex = 0;
            // 
            // mcbFechaFin
            // 
            mcbFechaFin.AutoResize = false;
            mcbFechaFin.BackColor = Color.FromArgb(255, 255, 255);
            mcbFechaFin.Depth = 0;
            mcbFechaFin.Dock = DockStyle.Fill;
            mcbFechaFin.DrawMode = DrawMode.OwnerDrawVariable;
            mcbFechaFin.DropDownHeight = 174;
            mcbFechaFin.DropDownStyle = ComboBoxStyle.DropDownList;
            mcbFechaFin.DropDownWidth = 121;
            mcbFechaFin.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            mcbFechaFin.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcbFechaFin.FormattingEnabled = true;
            mcbFechaFin.IntegralHeight = false;
            mcbFechaFin.ItemHeight = 43;
            mcbFechaFin.Location = new Point(234, 3);
            mcbFechaFin.MaxDropDownItems = 4;
            mcbFechaFin.MouseState = MaterialSkin.MouseState.OUT;
            mcbFechaFin.Name = "mcbFechaFin";
            mcbFechaFin.Size = new Size(225, 49);
            mcbFechaFin.StartIndex = 0;
            mcbFechaFin.TabIndex = 1;
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
            materialComboBox3.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBox3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBox3.FormattingEnabled = true;
            materialComboBox3.IntegralHeight = false;
            materialComboBox3.ItemHeight = 43;
            materialComboBox3.Location = new Point(927, 3);
            materialComboBox3.MaxDropDownItems = 4;
            materialComboBox3.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBox3.Name = "materialComboBox3";
            materialComboBox3.Size = new Size(225, 49);
            materialComboBox3.StartIndex = 0;
            materialComboBox3.TabIndex = 2;
            // 
            // tlpDescarga
            // 
            tlpDescarga.ColumnCount = 2;
            tlpDescarga.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlpDescarga.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpDescarga.Controls.Add(btnDescargarPDF, 1, 0);
            tlpDescarga.Dock = DockStyle.Fill;
            tlpDescarga.Location = new Point(148, 736);
            tlpDescarga.Name = "tlpDescarga";
            tlpDescarga.RowCount = 1;
            tlpDescarga.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDescarga.Size = new Size(1155, 80);
            tlpDescarga.TabIndex = 1;
            // 
            // btnDescargarPDF
            // 
            btnDescargarPDF.BackColor = Color.RoyalBlue;
            btnDescargarPDF.Dock = DockStyle.Fill;
            btnDescargarPDF.Font = new Font("Roboto", 15.75F, FontStyle.Bold);
            btnDescargarPDF.ForeColor = SystemColors.Control;
            btnDescargarPDF.Location = new Point(927, 3);
            btnDescargarPDF.Name = "btnDescargarPDF";
            btnDescargarPDF.Size = new Size(225, 74);
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
            dgvArqueo.Location = new Point(148, 132);
            dgvArqueo.Margin = new Padding(3, 3, 3, 30);
            dgvArqueo.Name = "dgvArqueo";
            dgvArqueo.Size = new Size(1155, 571);
            dgvArqueo.TabIndex = 2;
            // 
            // tabPromos
            // 
            tabPromos.Controls.Add(tableLayoutPanel5);
            tabPromos.Location = new Point(4, 39);
            tabPromos.Name = "tabPromos";
            tabPromos.Padding = new Padding(3);
            tabPromos.Size = new Size(1442, 870);
            tabPromos.TabIndex = 3;
            tabPromos.Text = "PROMOCIONES";
            tabPromos.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel5.Controls.Add(gbPromociones, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(1436, 864);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // gbPromociones
            // 
            gbPromociones.BackColor = SystemColors.GradientActiveCaption;
            gbPromociones.Controls.Add(materialLabel5);
            gbPromociones.Controls.Add(dtpFechaInicio);
            gbPromociones.Controls.Add(materialLabel4);
            gbPromociones.Controls.Add(materialLabel3);
            gbPromociones.Controls.Add(materialLabel2);
            gbPromociones.Controls.Add(materialLabel1);
            gbPromociones.Controls.Add(mtxtPrecioEspecial);
            gbPromociones.Controls.Add(mcbTipo);
            gbPromociones.Controls.Add(btnEscanearPromocion);
            gbPromociones.Controls.Add(mtxtDescripcion);
            gbPromociones.Controls.Add(dtpFechaFin);
            gbPromociones.Dock = DockStyle.Fill;
            gbPromociones.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbPromociones.Location = new Point(3, 3);
            gbPromociones.Name = "gbPromociones";
            gbPromociones.Size = new Size(568, 858);
            gbPromociones.TabIndex = 3;
            gbPromociones.TabStop = false;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(35, 388);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(95, 19);
            materialLabel5.TabIndex = 42;
            materialLabel5.Text = "Fecha de Fin:";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpFechaInicio.Font = new Font("Roboto", 12F);
            dtpFechaInicio.Location = new Point(136, 299);
            dtpFechaInicio.Margin = new Padding(3, 3, 15, 3);
            dtpFechaInicio.MinDate = new DateTime(2010, 12, 31, 0, 0, 0, 0);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(414, 27);
            dtpFechaInicio.TabIndex = 33;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(19, 302);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(111, 19);
            materialLabel4.TabIndex = 41;
            materialLabel4.Text = "Fecha de Inicio:";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(19, 231);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(111, 19);
            materialLabel3.TabIndex = 40;
            materialLabel3.Text = "Precio especial:";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(42, 156);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(88, 19);
            materialLabel2.TabIndex = 39;
            materialLabel2.Text = "Descripción:";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(93, 69);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(37, 19);
            materialLabel1.TabIndex = 38;
            materialLabel1.Text = "Tipo:";
            // 
            // mtxtPrecioEspecial
            // 
            mtxtPrecioEspecial.AnimateReadOnly = false;
            mtxtPrecioEspecial.BackgroundImageLayout = ImageLayout.None;
            mtxtPrecioEspecial.CharacterCasing = CharacterCasing.Normal;
            mtxtPrecioEspecial.Depth = 0;
            mtxtPrecioEspecial.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtxtPrecioEspecial.HideSelection = true;
            mtxtPrecioEspecial.LeadingIcon = null;
            mtxtPrecioEspecial.Location = new Point(136, 219);
            mtxtPrecioEspecial.Margin = new Padding(3, 3, 15, 3);
            mtxtPrecioEspecial.MaxLength = 32767;
            mtxtPrecioEspecial.MouseState = MaterialSkin.MouseState.OUT;
            mtxtPrecioEspecial.Name = "mtxtPrecioEspecial";
            mtxtPrecioEspecial.PasswordChar = '\0';
            mtxtPrecioEspecial.PrefixSuffixText = null;
            mtxtPrecioEspecial.ReadOnly = false;
            mtxtPrecioEspecial.RightToLeft = RightToLeft.No;
            mtxtPrecioEspecial.SelectedText = "";
            mtxtPrecioEspecial.SelectionLength = 0;
            mtxtPrecioEspecial.SelectionStart = 0;
            mtxtPrecioEspecial.ShortcutsEnabled = true;
            mtxtPrecioEspecial.Size = new Size(209, 48);
            mtxtPrecioEspecial.TabIndex = 37;
            mtxtPrecioEspecial.TabStop = false;
            mtxtPrecioEspecial.TextAlign = HorizontalAlignment.Left;
            mtxtPrecioEspecial.TrailingIcon = null;
            mtxtPrecioEspecial.UseSystemPasswordChar = false;
            // 
            // mcbTipo
            // 
            mcbTipo.AutoResize = false;
            mcbTipo.BackColor = Color.FromArgb(255, 255, 255);
            mcbTipo.Depth = 0;
            mcbTipo.DrawMode = DrawMode.OwnerDrawVariable;
            mcbTipo.DropDownHeight = 174;
            mcbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            mcbTipo.DropDownWidth = 121;
            mcbTipo.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            mcbTipo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcbTipo.FormattingEnabled = true;
            mcbTipo.IntegralHeight = false;
            mcbTipo.ItemHeight = 43;
            mcbTipo.Items.AddRange(new object[] { "2x1", "3x2", "Descuento", "Combo" });
            mcbTipo.Location = new Point(136, 55);
            mcbTipo.Margin = new Padding(3, 3, 15, 3);
            mcbTipo.MaxDropDownItems = 4;
            mcbTipo.MouseState = MaterialSkin.MouseState.OUT;
            mcbTipo.Name = "mcbTipo";
            mcbTipo.Size = new Size(209, 49);
            mcbTipo.StartIndex = 0;
            mcbTipo.TabIndex = 35;
            // 
            // btnEscanearPromocion
            // 
            btnEscanearPromocion.Font = new Font("Roboto", 12F);
            btnEscanearPromocion.Location = new Point(282, 142);
            btnEscanearPromocion.Margin = new Padding(0);
            btnEscanearPromocion.Name = "btnEscanearPromocion";
            btnEscanearPromocion.Size = new Size(63, 48);
            btnEscanearPromocion.TabIndex = 32;
            btnEscanearPromocion.Text = "Escanear";
            btnEscanearPromocion.UseVisualStyleBackColor = true;
            // 
            // mtxtDescripcion
            // 
            mtxtDescripcion.AnimateReadOnly = false;
            mtxtDescripcion.BackgroundImageLayout = ImageLayout.None;
            mtxtDescripcion.CharacterCasing = CharacterCasing.Normal;
            mtxtDescripcion.Depth = 0;
            mtxtDescripcion.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtxtDescripcion.HideSelection = true;
            mtxtDescripcion.LeadingIcon = null;
            mtxtDescripcion.Location = new Point(136, 142);
            mtxtDescripcion.Margin = new Padding(3, 3, 5, 3);
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
            mtxtDescripcion.Size = new Size(141, 48);
            mtxtDescripcion.TabIndex = 36;
            mtxtDescripcion.TabStop = false;
            mtxtDescripcion.TextAlign = HorizontalAlignment.Left;
            mtxtDescripcion.TrailingIcon = null;
            mtxtDescripcion.UseSystemPasswordChar = false;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpFechaFin.Font = new Font("Roboto", 12F);
            dtpFechaFin.Location = new Point(136, 384);
            dtpFechaFin.Margin = new Padding(3, 3, 15, 3);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(414, 27);
            dtpFechaFin.TabIndex = 34;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1472, 980);
            Controls.Add(interfazPrincipal);
            DrawerTabControl = interfazPrincipal;
            FormBorderStyle = FormBorderStyle.Sizable;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
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
            tlpPrincipal.ResumeLayout(false);
            tlpBotonesArriba.ResumeLayout(false);
            tlpDescarga.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvArqueo).EndInit();
            tabPromos.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            gbPromociones.ResumeLayout(false);
            gbPromociones.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabPage tabPage1;
        private TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabControl interfazPrincipal;
        private TabPage tabVentas;
        private TabPage tabProductos;
        private TableLayoutPanel tlVentas;
        private MaterialSkin.Controls.MaterialButton btnReiniciarLista;
        private MaterialSkin.Controls.MaterialButton btnAgregarDevolucion;
        private MaterialSkin.Controls.MaterialButton btnAjustarCaja;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TableLayoutPanel tlProductos;
        private DataGridView dgvProductos;
        private DataGridView dgvVentas;
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
        private TabPage tabPromos;
        private TableLayoutPanel tableLayoutPanel5;
        private GroupBox gbPromociones;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 mtxtPrecioEspecial;
        private MaterialSkin.Controls.MaterialComboBox mcbTipo;
        private Button btnEscanearPromocion;
        private MaterialSkin.Controls.MaterialTextBox2 mtxtDescripcion;
        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechaFin;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private TabPage tabArqueo;
        private TableLayoutPanel tlpPrincipal;
        private TableLayoutPanel tlpBotonesArriba;
        private TableLayoutPanel tlpDescarga;
        private Button btnDescargarPDF;
        private DataGridView dgvArqueo;
        private MaterialSkin.Controls.MaterialComboBox mcbFechaInicio;
        private MaterialSkin.Controls.MaterialComboBox mcbFechaFin;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox3;
    }
}