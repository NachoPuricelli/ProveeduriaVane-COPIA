namespace ProveeduriaVane
{
    partial class ElegirPromociones
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
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvElegirPromo = new DataGridView();
            btnSalirEleccionPromo = new MaterialSkin.Controls.MaterialButton();
            lblElegirPromo = new MaterialSkin.Controls.MaterialLabel();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvElegirPromo).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.LightGray;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dgvElegirPromo, 0, 1);
            tableLayoutPanel1.Controls.Add(btnSalirEleccionPromo, 0, 2);
            tableLayoutPanel1.Controls.Add(lblElegirPromo, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(594, 697);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvElegirPromo
            // 
            dgvElegirPromo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvElegirPromo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvElegirPromo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvElegirPromo.Dock = DockStyle.Fill;
            dgvElegirPromo.Location = new Point(20, 79);
            dgvElegirPromo.Margin = new Padding(20, 10, 20, 10);
            dgvElegirPromo.Name = "dgvElegirPromo";
            dgvElegirPromo.Size = new Size(554, 537);
            dgvElegirPromo.TabIndex = 4;
            // 
            // btnSalirEleccionPromo
            // 
            btnSalirEleccionPromo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalirEleccionPromo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalirEleccionPromo.Depth = 0;
            btnSalirEleccionPromo.Dock = DockStyle.Fill;
            btnSalirEleccionPromo.HighEmphasis = true;
            btnSalirEleccionPromo.Icon = null;
            btnSalirEleccionPromo.Location = new Point(20, 636);
            btnSalirEleccionPromo.Margin = new Padding(20, 10, 20, 10);
            btnSalirEleccionPromo.MouseState = MaterialSkin.MouseState.HOVER;
            btnSalirEleccionPromo.Name = "btnSalirEleccionPromo";
            btnSalirEleccionPromo.NoAccentTextColor = Color.Empty;
            btnSalirEleccionPromo.Size = new Size(554, 51);
            btnSalirEleccionPromo.TabIndex = 2;
            btnSalirEleccionPromo.Text = "Salir";
            btnSalirEleccionPromo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalirEleccionPromo.UseAccentColor = false;
            btnSalirEleccionPromo.UseVisualStyleBackColor = true;
            btnSalirEleccionPromo.Click += materialButton1_Click;
            // 
            // lblElegirPromo
            // 
            lblElegirPromo.AutoSize = true;
            lblElegirPromo.BorderStyle = BorderStyle.FixedSingle;
            lblElegirPromo.Depth = 0;
            lblElegirPromo.Dock = DockStyle.Fill;
            lblElegirPromo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblElegirPromo.Location = new Point(20, 10);
            lblElegirPromo.Margin = new Padding(20, 10, 20, 10);
            lblElegirPromo.MouseState = MaterialSkin.MouseState.HOVER;
            lblElegirPromo.Name = "lblElegirPromo";
            lblElegirPromo.Size = new Size(554, 49);
            lblElegirPromo.TabIndex = 5;
            lblElegirPromo.Text = "ELIJA LAS PROMOCIÓN QUE DESEA AGREGAR A LA VENTA:";
            lblElegirPromo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ElegirPromociones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(600, 700);
            Controls.Add(tableLayoutPanel1);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "ElegirPromociones";
            Padding = new Padding(3, 0, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ElegirPromociones";
            Load += ElegirPromociones_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvElegirPromo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvElegirPromo;
        private MaterialSkin.Controls.MaterialButton btnSalirEleccionPromo;
        private MaterialSkin.Controls.MaterialLabel lblElegirPromo;
    }
}