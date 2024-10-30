namespace ProveeduriaVane
{
    partial class IngresoPin
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
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            mbtnCancelar = new MaterialSkin.Controls.MaterialButton();
            mbtnAceptar = new MaterialSkin.Controls.MaterialButton();
            mbtnGestionar = new MaterialSkin.Controls.MaterialButton();
            mtxtPIN = new MaterialSkin.Controls.MaterialTextBox2();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            materialLabel1.Location = new Point(25, 64);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(446, 59);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "INGRESE EL PIN DE 4 DÍGITOS PARA PODER DESBLOQUEAR LAS FUNCIONES DE AGREGAR, BORRAR, EDITAR Y AUMENTAR PRODUCTOS:";
            materialLabel1.TextAlign = ContentAlignment.TopCenter;
            // 
            // mbtnCancelar
            // 
            mbtnCancelar.AutoSize = false;
            mbtnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnCancelar.BackColor = Color.IndianRed;
            mbtnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnCancelar.Depth = 0;
            mbtnCancelar.DialogResult = DialogResult.Cancel;
            mbtnCancelar.HighEmphasis = true;
            mbtnCancelar.Icon = null;
            mbtnCancelar.Location = new Point(253, 166);
            mbtnCancelar.Margin = new Padding(4, 6, 4, 6);
            mbtnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnCancelar.Name = "mbtnCancelar";
            mbtnCancelar.NoAccentTextColor = Color.Empty;
            mbtnCancelar.Size = new Size(105, 48);
            mbtnCancelar.TabIndex = 2;
            mbtnCancelar.Text = "CANCELAR";
            mbtnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnCancelar.UseAccentColor = false;
            mbtnCancelar.UseVisualStyleBackColor = true;
            mbtnCancelar.Click += mbtnCancelar_Click;
            // 
            // mbtnAceptar
            // 
            mbtnAceptar.AutoSize = false;
            mbtnAceptar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnAceptar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnAceptar.Depth = 0;
            mbtnAceptar.HighEmphasis = true;
            mbtnAceptar.Icon = null;
            mbtnAceptar.Location = new Point(140, 166);
            mbtnAceptar.Margin = new Padding(4, 6, 4, 6);
            mbtnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnAceptar.Name = "mbtnAceptar";
            mbtnAceptar.NoAccentTextColor = Color.Empty;
            mbtnAceptar.Size = new Size(105, 48);
            mbtnAceptar.TabIndex = 1;
            mbtnAceptar.Text = "ACEPTAR";
            mbtnAceptar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnAceptar.UseAccentColor = false;
            mbtnAceptar.UseVisualStyleBackColor = true;
            mbtnAceptar.Click += mbtnAceptar_Click;
            // 
            // mbtnGestionar
            // 
            mbtnGestionar.AutoSize = false;
            mbtnGestionar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnGestionar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnGestionar.Depth = 0;
            mbtnGestionar.HighEmphasis = true;
            mbtnGestionar.Icon = null;
            mbtnGestionar.Location = new Point(366, 166);
            mbtnGestionar.Margin = new Padding(4, 6, 4, 6);
            mbtnGestionar.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnGestionar.Name = "mbtnGestionar";
            mbtnGestionar.NoAccentTextColor = Color.Empty;
            mbtnGestionar.Size = new Size(105, 48);
            mbtnGestionar.TabIndex = 3;
            mbtnGestionar.Text = "GESTIONAR";
            mbtnGestionar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnGestionar.UseAccentColor = false;
            mbtnGestionar.UseVisualStyleBackColor = true;
            // 
            // mtxtPIN
            // 
            mtxtPIN.AnimateReadOnly = false;
            mtxtPIN.BackgroundImageLayout = ImageLayout.None;
            mtxtPIN.CharacterCasing = CharacterCasing.Normal;
            mtxtPIN.Depth = 0;
            mtxtPIN.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtxtPIN.HelperText = "Ingresa tu PIN:";
            mtxtPIN.HideSelection = true;
            mtxtPIN.LeadingIcon = null;
            mtxtPIN.Location = new Point(25, 166);
            mtxtPIN.MaxLength = 32767;
            mtxtPIN.MouseState = MaterialSkin.MouseState.OUT;
            mtxtPIN.Name = "mtxtPIN";
            mtxtPIN.PasswordChar = '●';
            mtxtPIN.PrefixSuffixText = null;
            mtxtPIN.ReadOnly = false;
            mtxtPIN.RightToLeft = RightToLeft.No;
            mtxtPIN.SelectedText = "";
            mtxtPIN.SelectionLength = 0;
            mtxtPIN.SelectionStart = 0;
            mtxtPIN.ShortcutsEnabled = true;
            mtxtPIN.ShowAssistiveText = true;
            mtxtPIN.Size = new Size(108, 64);
            mtxtPIN.TabIndex = 0;
            mtxtPIN.TabStop = false;
            mtxtPIN.TextAlign = HorizontalAlignment.Left;
            mtxtPIN.TrailingIcon = null;
            mtxtPIN.UseSystemPasswordChar = true;
            // 
            // IngresoPin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 251);
            Controls.Add(mtxtPIN);
            Controls.Add(mbtnGestionar);
            Controls.Add(mbtnAceptar);
            Controls.Add(mbtnCancelar);
            Controls.Add(materialLabel1);
            FormStyle = FormStyles.ActionBar_None;
            Name = "IngresoPin";
            Padding = new Padding(3, 24, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IngresoPin";
            KeyDown += IngresoPin_KeyDown;
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton mbtnCancelar;
        private MaterialSkin.Controls.MaterialButton mbtnAceptar;
        private MaterialSkin.Controls.MaterialButton mbtnGestionar;
        private MaterialSkin.Controls.MaterialTextBox2 mtxtPIN;
    }
}