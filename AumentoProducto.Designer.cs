namespace ProveeduriaVane
{
    partial class AumentoProducto
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
            mbtnAceptar = new MaterialSkin.Controls.MaterialButton();
            mbtnCancelar = new MaterialSkin.Controls.MaterialButton();
            mtxtPorcentaje = new TextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            rbAumentar = new MaterialSkin.Controls.MaterialRadioButton();
            rbDisminuir = new MaterialSkin.Controls.MaterialRadioButton();
            SuspendLayout();
            // 
            // mbtnAceptar
            // 
            mbtnAceptar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnAceptar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnAceptar.Depth = 0;
            mbtnAceptar.HighEmphasis = true;
            mbtnAceptar.Icon = null;
            mbtnAceptar.Location = new Point(245, 207);
            mbtnAceptar.Margin = new Padding(4, 6, 4, 6);
            mbtnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnAceptar.Name = "mbtnAceptar";
            mbtnAceptar.NoAccentTextColor = Color.Empty;
            mbtnAceptar.Size = new Size(86, 36);
            mbtnAceptar.TabIndex = 0;
            mbtnAceptar.Text = "aceptar";
            mbtnAceptar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnAceptar.UseAccentColor = false;
            mbtnAceptar.UseVisualStyleBackColor = true;
            mbtnAceptar.Click += mbtnAceptar_Click;
            // 
            // mbtnCancelar
            // 
            mbtnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnCancelar.Depth = 0;
            mbtnCancelar.HighEmphasis = true;
            mbtnCancelar.Icon = null;
            mbtnCancelar.Location = new Point(339, 207);
            mbtnCancelar.Margin = new Padding(4, 6, 4, 6);
            mbtnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnCancelar.Name = "mbtnCancelar";
            mbtnCancelar.NoAccentTextColor = Color.Empty;
            mbtnCancelar.Size = new Size(96, 36);
            mbtnCancelar.TabIndex = 1;
            mbtnCancelar.Text = "cancelar";
            mbtnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnCancelar.UseAccentColor = false;
            mbtnCancelar.UseVisualStyleBackColor = true;
            mbtnCancelar.Click += mbtnCancelar_Click;
            // 
            // mtxtPorcentaje
            // 
            mtxtPorcentaje.Location = new Point(138, 207);
            mtxtPorcentaje.Multiline = true;
            mtxtPorcentaje.Name = "mtxtPorcentaje";
            mtxtPorcentaje.Size = new Size(87, 36);
            mtxtPorcentaje.TabIndex = 2;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(36, 217);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(96, 19);
            materialLabel1.TabIndex = 3;
            materialLabel1.Text = "Porcentaje: %";
            // 
            // materialLabel2
            // 
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(24, 50);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(424, 65);
            materialLabel2.TabIndex = 4;
            materialLabel2.Text = "POR FAVOR, INGRESE EL PORCENTAJE POR EL QUE QUIERE AUMENTAR LOS PRODUCTOS SELECCIONADOS:";
            materialLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rbAumentar
            // 
            rbAumentar.AutoSize = true;
            rbAumentar.Depth = 0;
            rbAumentar.Location = new Point(121, 136);
            rbAumentar.Margin = new Padding(0);
            rbAumentar.MouseLocation = new Point(-1, -1);
            rbAumentar.MouseState = MaterialSkin.MouseState.HOVER;
            rbAumentar.Name = "rbAumentar";
            rbAumentar.Ripple = true;
            rbAumentar.Size = new Size(104, 37);
            rbAumentar.TabIndex = 5;
            rbAumentar.TabStop = true;
            rbAumentar.Text = "Aumentar";
            rbAumentar.UseVisualStyleBackColor = true;
            // 
            // rbDisminuir
            // 
            rbDisminuir.AutoSize = true;
            rbDisminuir.Depth = 0;
            rbDisminuir.Location = new Point(245, 136);
            rbDisminuir.Margin = new Padding(0);
            rbDisminuir.MouseLocation = new Point(-1, -1);
            rbDisminuir.MouseState = MaterialSkin.MouseState.HOVER;
            rbDisminuir.Name = "rbDisminuir";
            rbDisminuir.Ripple = true;
            rbDisminuir.Size = new Size(103, 37);
            rbDisminuir.TabIndex = 6;
            rbDisminuir.TabStop = true;
            rbDisminuir.Text = "Disminuir";
            rbDisminuir.UseVisualStyleBackColor = true;
            // 
            // AumentoProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 287);
            Controls.Add(rbDisminuir);
            Controls.Add(rbAumentar);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(mtxtPorcentaje);
            Controls.Add(mbtnCancelar);
            Controls.Add(mbtnAceptar);
            FormStyle = FormStyles.ActionBar_None;
            Name = "AumentoProducto";
            Padding = new Padding(3, 24, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AumentoProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton mbtnAceptar;
        private MaterialSkin.Controls.MaterialButton mbtnCancelar;
        private TextBox mtxtPorcentaje;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRadioButton rbAumentar;
        private MaterialSkin.Controls.MaterialRadioButton rbDisminuir;
    }
}