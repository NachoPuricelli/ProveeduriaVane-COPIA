namespace ProveeduriaVane
{
    partial class Contenedor
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
            flTotal = new FlowLayoutPanel();
            lblTotal = new Label();
            lblSaldo = new Label();
            flMediosPago = new FlowLayoutPanel();
            rbDebito = new RadioButton();
            rbEfectivo = new RadioButton();
            rbCredito = new RadioButton();
            rbTrasferencia = new RadioButton();
            panelModoEdicion = new Panel();
            btnAumentarProducto = new MaterialSkin.Controls.MaterialButton();
            btnDesbloquearEdicion = new MaterialSkin.Controls.MaterialButton();
            btnEditarProductos = new MaterialSkin.Controls.MaterialButton();
            btnBorrarProducto = new MaterialSkin.Controls.MaterialButton();
            btnAgregarProducto = new MaterialSkin.Controls.MaterialButton();
            txtFiltros = new TextBox();
            cbFiltros = new ComboBox();
            flTotal.SuspendLayout();
            flMediosPago.SuspendLayout();
            SuspendLayout();
            // 
            // flTotal
            // 
            flTotal.Controls.Add(lblTotal);
            flTotal.Controls.Add(lblSaldo);
            flTotal.Location = new Point(76, 214);
            flTotal.Margin = new Padding(3, 6, 3, 3);
            flTotal.Name = "flTotal";
            flTotal.Size = new Size(167, 25);
            flTotal.TabIndex = 22;
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.Blue;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(3, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(60, 28);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "TOTAL:";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSaldo
            // 
            lblSaldo.BackColor = Color.Blue;
            lblSaldo.BorderStyle = BorderStyle.FixedSingle;
            lblSaldo.ForeColor = Color.White;
            lblSaldo.Location = new Point(69, 0);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(90, 28);
            lblSaldo.TabIndex = 10;
            lblSaldo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flMediosPago
            // 
            flMediosPago.Controls.Add(rbDebito);
            flMediosPago.Controls.Add(rbEfectivo);
            flMediosPago.Controls.Add(rbCredito);
            flMediosPago.Controls.Add(rbTrasferencia);
            flMediosPago.Location = new Point(249, 211);
            flMediosPago.Name = "flMediosPago";
            flMediosPago.Size = new Size(475, 28);
            flMediosPago.TabIndex = 21;
            // 
            // rbDebito
            // 
            rbDebito.BackColor = Color.Blue;
            rbDebito.CheckAlign = ContentAlignment.MiddleRight;
            rbDebito.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbDebito.ForeColor = Color.White;
            rbDebito.Location = new Point(3, 3);
            rbDebito.Name = "rbDebito";
            rbDebito.Size = new Size(84, 28);
            rbDebito.TabIndex = 30;
            rbDebito.TabStop = true;
            rbDebito.Text = "DÉBITO";
            rbDebito.UseVisualStyleBackColor = false;
            // 
            // rbEfectivo
            // 
            rbEfectivo.BackColor = Color.Blue;
            rbEfectivo.CheckAlign = ContentAlignment.MiddleRight;
            rbEfectivo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbEfectivo.ForeColor = Color.White;
            rbEfectivo.Location = new Point(93, 3);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Size = new Size(101, 28);
            rbEfectivo.TabIndex = 28;
            rbEfectivo.TabStop = true;
            rbEfectivo.Text = "EFECTIVO";
            rbEfectivo.UseVisualStyleBackColor = false;
            // 
            // rbCredito
            // 
            rbCredito.BackColor = Color.Blue;
            rbCredito.CheckAlign = ContentAlignment.MiddleRight;
            rbCredito.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbCredito.ForeColor = Color.White;
            rbCredito.Location = new Point(200, 3);
            rbCredito.Name = "rbCredito";
            rbCredito.Size = new Size(94, 28);
            rbCredito.TabIndex = 29;
            rbCredito.TabStop = true;
            rbCredito.Text = "CRÉDITO";
            rbCredito.UseVisualStyleBackColor = false;
            // 
            // rbTrasferencia
            // 
            rbTrasferencia.BackColor = Color.Blue;
            rbTrasferencia.CheckAlign = ContentAlignment.MiddleRight;
            rbTrasferencia.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbTrasferencia.ForeColor = Color.White;
            rbTrasferencia.Location = new Point(300, 3);
            rbTrasferencia.Name = "rbTrasferencia";
            rbTrasferencia.Size = new Size(157, 28);
            rbTrasferencia.TabIndex = 31;
            rbTrasferencia.TabStop = true;
            rbTrasferencia.Text = "TRANSFERENCIA";
            rbTrasferencia.UseVisualStyleBackColor = false;
            // 
            // panelModoEdicion
            // 
            panelModoEdicion.Location = new Point(616, 290);
            panelModoEdicion.Name = "panelModoEdicion";
            panelModoEdicion.Size = new Size(259, 35);
            panelModoEdicion.TabIndex = 31;
            // 
            // btnAumentarProducto
            // 
            btnAumentarProducto.AutoSize = false;
            btnAumentarProducto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAumentarProducto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAumentarProducto.Depth = 0;
            btnAumentarProducto.HighEmphasis = true;
            btnAumentarProducto.Icon = null;
            btnAumentarProducto.Location = new Point(509, 40);
            btnAumentarProducto.Margin = new Padding(4, 6, 4, 6);
            btnAumentarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            btnAumentarProducto.Name = "btnAumentarProducto";
            btnAumentarProducto.NoAccentTextColor = Color.Empty;
            btnAumentarProducto.Size = new Size(125, 28);
            btnAumentarProducto.TabIndex = 24;
            btnAumentarProducto.Text = "Aumentar";
            btnAumentarProducto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAumentarProducto.UseAccentColor = false;
            btnAumentarProducto.UseVisualStyleBackColor = true;
            btnAumentarProducto.Visible = false;
            // 
            // btnDesbloquearEdicion
            // 
            btnDesbloquearEdicion.AutoSize = false;
            btnDesbloquearEdicion.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDesbloquearEdicion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDesbloquearEdicion.Depth = 0;
            btnDesbloquearEdicion.HighEmphasis = true;
            btnDesbloquearEdicion.Icon = null;
            btnDesbloquearEdicion.Location = new Point(312, 366);
            btnDesbloquearEdicion.Margin = new Padding(4, 6, 4, 6);
            btnDesbloquearEdicion.MouseState = MaterialSkin.MouseState.HOVER;
            btnDesbloquearEdicion.Name = "btnDesbloquearEdicion";
            btnDesbloquearEdicion.NoAccentTextColor = Color.Empty;
            btnDesbloquearEdicion.Size = new Size(257, 27);
            btnDesbloquearEdicion.TabIndex = 25;
            btnDesbloquearEdicion.Text = "Desbloquear modo edición";
            btnDesbloquearEdicion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDesbloquearEdicion.UseAccentColor = false;
            btnDesbloquearEdicion.UseVisualStyleBackColor = true;
            // 
            // btnEditarProductos
            // 
            btnEditarProductos.AutoSize = false;
            btnEditarProductos.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditarProductos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditarProductos.Depth = 0;
            btnEditarProductos.HighEmphasis = true;
            btnEditarProductos.Icon = null;
            btnEditarProductos.Location = new Point(285, 0);
            btnEditarProductos.Margin = new Padding(4, 6, 4, 6);
            btnEditarProductos.MouseState = MaterialSkin.MouseState.HOVER;
            btnEditarProductos.Name = "btnEditarProductos";
            btnEditarProductos.NoAccentTextColor = Color.Empty;
            btnEditarProductos.Size = new Size(122, 28);
            btnEditarProductos.TabIndex = 23;
            btnEditarProductos.Text = "Editar";
            btnEditarProductos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditarProductos.UseAccentColor = false;
            btnEditarProductos.UseVisualStyleBackColor = true;
            btnEditarProductos.Visible = false;
            // 
            // btnBorrarProducto
            // 
            btnBorrarProducto.AutoSize = false;
            btnBorrarProducto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBorrarProducto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnBorrarProducto.Depth = 0;
            btnBorrarProducto.HighEmphasis = true;
            btnBorrarProducto.Icon = null;
            btnBorrarProducto.Location = new Point(485, 293);
            btnBorrarProducto.Margin = new Padding(4, 6, 4, 6);
            btnBorrarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            btnBorrarProducto.Name = "btnBorrarProducto";
            btnBorrarProducto.NoAccentTextColor = Color.Empty;
            btnBorrarProducto.Size = new Size(123, 28);
            btnBorrarProducto.TabIndex = 30;
            btnBorrarProducto.Text = "Borrar";
            btnBorrarProducto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnBorrarProducto.UseAccentColor = false;
            btnBorrarProducto.UseVisualStyleBackColor = true;
            btnBorrarProducto.Visible = false;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.AutoSize = false;
            btnAgregarProducto.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAgregarProducto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAgregarProducto.Depth = 0;
            btnAgregarProducto.HighEmphasis = true;
            btnAgregarProducto.Icon = null;
            btnAgregarProducto.Location = new Point(353, 293);
            btnAgregarProducto.Margin = new Padding(4, 6, 4, 6);
            btnAgregarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.NoAccentTextColor = Color.Empty;
            btnAgregarProducto.Size = new Size(123, 28);
            btnAgregarProducto.TabIndex = 29;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAgregarProducto.UseAccentColor = false;
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Visible = false;
            // 
            // txtFiltros
            // 
            txtFiltros.BackColor = Color.Blue;
            txtFiltros.BorderStyle = BorderStyle.FixedSingle;
            txtFiltros.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFiltros.ForeColor = SystemColors.Info;
            txtFiltros.Location = new Point(79, 335);
            txtFiltros.Margin = new Padding(3, 7, 3, 3);
            txtFiltros.Multiline = true;
            txtFiltros.Name = "txtFiltros";
            txtFiltros.Size = new Size(211, 28);
            txtFiltros.TabIndex = 27;
            txtFiltros.Text = "Búsqueda";
            // 
            // cbFiltros
            // 
            cbFiltros.BackColor = Color.Blue;
            cbFiltros.FlatStyle = FlatStyle.Popup;
            cbFiltros.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbFiltros.ForeColor = SystemColors.Info;
            cbFiltros.FormattingEnabled = true;
            cbFiltros.Items.AddRange(new object[] { "Tipo", "Marca", "Descripción" });
            cbFiltros.Location = new Point(220, 294);
            cbFiltros.Margin = new Padding(3, 7, 3, 3);
            cbFiltros.Name = "cbFiltros";
            cbFiltros.Size = new Size(116, 28);
            cbFiltros.TabIndex = 28;
            cbFiltros.Text = "Filtros";
            // 
            // Contenedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAumentarProducto);
            Controls.Add(panelModoEdicion);
            Controls.Add(btnEditarProductos);
            Controls.Add(btnDesbloquearEdicion);
            Controls.Add(btnBorrarProducto);
            Controls.Add(btnAgregarProducto);
            Controls.Add(txtFiltros);
            Controls.Add(cbFiltros);
            Controls.Add(flTotal);
            Controls.Add(flMediosPago);
            Name = "Contenedor";
            Text = "Contenedor";
            flTotal.ResumeLayout(false);
            flMediosPago.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flTotal;
        private Label lblTotal;
        private Label lblSaldo;
        private FlowLayoutPanel flMediosPago;
        private RadioButton rbDebito;
        private RadioButton rbEfectivo;
        private RadioButton rbCredito;
        private RadioButton rbTrasferencia;
        private Panel panelModoEdicion;
        private MaterialSkin.Controls.MaterialButton btnAumentarProducto;
        private MaterialSkin.Controls.MaterialButton btnDesbloquearEdicion;
        private MaterialSkin.Controls.MaterialButton btnEditarProductos;
        private MaterialSkin.Controls.MaterialButton btnBorrarProducto;
        private MaterialSkin.Controls.MaterialButton btnAgregarProducto;
        private TextBox txtFiltros;
        private ComboBox cbFiltros;
    }
}