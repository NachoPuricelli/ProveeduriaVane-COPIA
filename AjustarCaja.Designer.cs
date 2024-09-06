namespace ProveeduriaVane
{
    partial class AjustarCaja
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
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            mtxtMotivo = new MaterialSkin.Controls.MaterialTextBox2();
            mtxtMonto = new MaterialSkin.Controls.MaterialTextBox2();
            mrbSuma = new MaterialSkin.Controls.MaterialRadioButton();
            mrbResta = new MaterialSkin.Controls.MaterialRadioButton();
            mbtnCancelar = new MaterialSkin.Controls.MaterialButton();
            mbtnAceptar = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // materialLabel2
            // 
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(30, 118);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(118, 48);
            materialLabel2.TabIndex = 15;
            materialLabel2.Text = "Ingrese el monto";
            materialLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialLabel1
            // 
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(30, 51);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(125, 48);
            materialLabel1.TabIndex = 14;
            materialLabel1.Text = "Ingrese el motivo:";
            materialLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mtxtMotivo
            // 
            mtxtMotivo.AnimateReadOnly = false;
            mtxtMotivo.BackgroundImageLayout = ImageLayout.None;
            mtxtMotivo.CharacterCasing = CharacterCasing.Normal;
            mtxtMotivo.Depth = 0;
            mtxtMotivo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtxtMotivo.HideSelection = true;
            mtxtMotivo.LeadingIcon = null;
            mtxtMotivo.Location = new Point(192, 51);
            mtxtMotivo.MaxLength = 32767;
            mtxtMotivo.MouseState = MaterialSkin.MouseState.OUT;
            mtxtMotivo.Name = "mtxtMotivo";
            mtxtMotivo.PasswordChar = '\0';
            mtxtMotivo.PrefixSuffixText = null;
            mtxtMotivo.ReadOnly = false;
            mtxtMotivo.RightToLeft = RightToLeft.No;
            mtxtMotivo.SelectedText = "";
            mtxtMotivo.SelectionLength = 0;
            mtxtMotivo.SelectionStart = 0;
            mtxtMotivo.ShortcutsEnabled = true;
            mtxtMotivo.Size = new Size(250, 48);
            mtxtMotivo.TabIndex = 13;
            mtxtMotivo.TabStop = false;
            mtxtMotivo.TextAlign = HorizontalAlignment.Left;
            mtxtMotivo.TrailingIcon = null;
            mtxtMotivo.UseSystemPasswordChar = false;
            // 
            // mtxtMonto
            // 
            mtxtMonto.AnimateReadOnly = false;
            mtxtMonto.BackgroundImageLayout = ImageLayout.None;
            mtxtMonto.CharacterCasing = CharacterCasing.Normal;
            mtxtMonto.Depth = 0;
            mtxtMonto.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtxtMonto.HideSelection = true;
            mtxtMonto.LeadingIcon = null;
            mtxtMonto.Location = new Point(192, 118);
            mtxtMonto.MaxLength = 32767;
            mtxtMonto.MouseState = MaterialSkin.MouseState.OUT;
            mtxtMonto.Name = "mtxtMonto";
            mtxtMonto.PasswordChar = '\0';
            mtxtMonto.PrefixSuffixText = null;
            mtxtMonto.ReadOnly = false;
            mtxtMonto.RightToLeft = RightToLeft.No;
            mtxtMonto.SelectedText = "";
            mtxtMonto.SelectionLength = 0;
            mtxtMonto.SelectionStart = 0;
            mtxtMonto.ShortcutsEnabled = true;
            mtxtMonto.Size = new Size(250, 48);
            mtxtMonto.TabIndex = 12;
            mtxtMonto.TabStop = false;
            mtxtMonto.TextAlign = HorizontalAlignment.Left;
            mtxtMonto.TrailingIcon = null;
            mtxtMonto.UseSystemPasswordChar = false;
            // 
            // mrbSuma
            // 
            mrbSuma.AutoSize = true;
            mrbSuma.Depth = 0;
            mrbSuma.Location = new Point(19, 190);
            mrbSuma.Margin = new Padding(0);
            mrbSuma.MouseLocation = new Point(-1, -1);
            mrbSuma.MouseState = MaterialSkin.MouseState.HOVER;
            mrbSuma.Name = "mrbSuma";
            mrbSuma.Ripple = true;
            mrbSuma.Size = new Size(89, 37);
            mrbSuma.TabIndex = 11;
            mrbSuma.TabStop = true;
            mrbSuma.Text = "SUMAR";
            mrbSuma.UseVisualStyleBackColor = true;
            // 
            // mrbResta
            // 
            mrbResta.AutoSize = true;
            mrbResta.Depth = 0;
            mrbResta.Location = new Point(125, 190);
            mrbResta.Margin = new Padding(0);
            mrbResta.MouseLocation = new Point(-1, -1);
            mrbResta.MouseState = MaterialSkin.MouseState.HOVER;
            mrbResta.Name = "mrbResta";
            mrbResta.Ripple = true;
            mrbResta.Size = new Size(94, 37);
            mrbResta.TabIndex = 10;
            mrbResta.TabStop = true;
            mrbResta.Text = "RESTAR";
            mrbResta.UseVisualStyleBackColor = true;
            // 
            // mbtnCancelar
            // 
            mbtnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnCancelar.Depth = 0;
            mbtnCancelar.HighEmphasis = true;
            mbtnCancelar.Icon = null;
            mbtnCancelar.Location = new Point(346, 191);
            mbtnCancelar.Margin = new Padding(4, 6, 4, 6);
            mbtnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnCancelar.Name = "mbtnCancelar";
            mbtnCancelar.NoAccentTextColor = Color.Empty;
            mbtnCancelar.Size = new Size(96, 36);
            mbtnCancelar.TabIndex = 9;
            mbtnCancelar.Text = "CANCELAR";
            mbtnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnCancelar.UseAccentColor = false;
            mbtnCancelar.UseVisualStyleBackColor = true;
            mbtnCancelar.Click += mbtnCancelar_Click;
            // 
            // mbtnAceptar
            // 
            mbtnAceptar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnAceptar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnAceptar.Depth = 0;
            mbtnAceptar.HighEmphasis = true;
            mbtnAceptar.Icon = null;
            mbtnAceptar.Location = new Point(252, 191);
            mbtnAceptar.Margin = new Padding(4, 6, 4, 6);
            mbtnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnAceptar.Name = "mbtnAceptar";
            mbtnAceptar.NoAccentTextColor = Color.Empty;
            mbtnAceptar.Size = new Size(86, 36);
            mbtnAceptar.TabIndex = 8;
            mbtnAceptar.Text = "ACEPTAR";
            mbtnAceptar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnAceptar.UseAccentColor = false;
            mbtnAceptar.UseVisualStyleBackColor = true;
            // 
            // AjustarCaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 251);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(mtxtMotivo);
            Controls.Add(mtxtMonto);
            Controls.Add(mrbSuma);
            Controls.Add(mrbResta);
            Controls.Add(mbtnCancelar);
            Controls.Add(mbtnAceptar);
            FormStyle = FormStyles.ActionBar_None;
            Name = "AjustarCaja";
            Padding = new Padding(3, 24, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 mtxtMotivo;
        private MaterialSkin.Controls.MaterialTextBox2 mtxtMonto;
        private MaterialSkin.Controls.MaterialRadioButton mrbSuma;
        private MaterialSkin.Controls.MaterialRadioButton mrbResta;
        private MaterialSkin.Controls.MaterialButton mbtnCancelar;
        private MaterialSkin.Controls.MaterialButton mbtnAceptar;
    }
}