namespace ProveeduriaVane
{
    partial class CajaInicial
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
            mtxtCajaInicial = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            mbtnAceptar = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // mtxtCajaInicial
            // 
            mtxtCajaInicial.AnimateReadOnly = false;
            mtxtCajaInicial.BorderStyle = BorderStyle.None;
            mtxtCajaInicial.Depth = 0;
            mtxtCajaInicial.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtxtCajaInicial.LeadingIcon = null;
            mtxtCajaInicial.Location = new Point(89, 118);
            mtxtCajaInicial.MaxLength = 50;
            mtxtCajaInicial.MouseState = MaterialSkin.MouseState.OUT;
            mtxtCajaInicial.Multiline = false;
            mtxtCajaInicial.Name = "mtxtCajaInicial";
            mtxtCajaInicial.Size = new Size(287, 50);
            mtxtCajaInicial.TabIndex = 0;
            mtxtCajaInicial.Text = "";
            mtxtCajaInicial.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            materialLabel1.Location = new Point(89, 57);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(287, 41);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "POR FAVOR, INGRESE EL MONTO INICIAL DE LA CAJA PARA CONTINUAR:";
            materialLabel1.TextAlign = ContentAlignment.TopCenter;
            // 
            // mbtnAceptar
            // 
            mbtnAceptar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnAceptar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnAceptar.Depth = 0;
            mbtnAceptar.HighEmphasis = true;
            mbtnAceptar.Icon = null;
            mbtnAceptar.Location = new Point(364, 194);
            mbtnAceptar.Margin = new Padding(4, 6, 4, 6);
            mbtnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnAceptar.Name = "mbtnAceptar";
            mbtnAceptar.NoAccentTextColor = Color.Empty;
            mbtnAceptar.Size = new Size(86, 36);
            mbtnAceptar.TabIndex = 2;
            mbtnAceptar.Text = "ACEPTAR";
            mbtnAceptar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnAceptar.UseAccentColor = false;
            mbtnAceptar.UseVisualStyleBackColor = true;
            mbtnAceptar.Click += mbtnAceptar_Click;
            // 
            // CajaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 251);
            ControlBox = false;
            Controls.Add(mbtnAceptar);
            Controls.Add(materialLabel1);
            Controls.Add(mtxtCajaInicial);
            FormStyle = FormStyles.ActionBar_None;
            Name = "CajaInicial";
            Padding = new Padding(3, 24, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CajaInicial";
            TopMost = true;
            KeyDown += CajaInicial_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox mtxtCajaInicial;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton mbtnAceptar;
    }
}