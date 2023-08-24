namespace UI.Screens
{
    partial class AddMetallicScreen
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.txtBlue = new MaterialSkin.Controls.MaterialTextBox();
            this.lblBlueValue = new MaterialSkin.Controls.MaterialLabel();
            this.txtGreen = new MaterialSkin.Controls.MaterialTextBox();
            this.lblGreenValue = new MaterialSkin.Controls.MaterialLabel();
            this.btnCloseTab = new MaterialSkin.Controls.MaterialButton();
            this.btnSaveMaterial = new MaterialSkin.Controls.MaterialButton();
            this.txtRed = new MaterialSkin.Controls.MaterialTextBox();
            this.lblRedValue = new MaterialSkin.Controls.MaterialLabel();
            this.txtFigureName = new MaterialSkin.Controls.MaterialTextBox();
            this.lblFigureName = new MaterialSkin.Controls.MaterialLabel();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.txtRoughness = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblmsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Location = new System.Drawing.Point(1, 1);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(253, 627);
            this.pnlMenu.TabIndex = 0;
            // 
            // txtBlue
            // 
            this.txtBlue.AnimateReadOnly = false;
            this.txtBlue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBlue.Depth = 0;
            this.txtBlue.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBlue.LeadingIcon = null;
            this.txtBlue.Location = new System.Drawing.Point(719, 264);
            this.txtBlue.Margin = new System.Windows.Forms.Padding(2);
            this.txtBlue.MaxLength = 50;
            this.txtBlue.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBlue.Multiline = false;
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.Size = new System.Drawing.Size(80, 50);
            this.txtBlue.TabIndex = 30;
            this.txtBlue.Text = "";
            this.txtBlue.TrailingIcon = null;
            // 
            // lblBlueValue
            // 
            this.lblBlueValue.AutoSize = true;
            this.lblBlueValue.Depth = 0;
            this.lblBlueValue.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBlueValue.Location = new System.Drawing.Point(716, 244);
            this.lblBlueValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBlueValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBlueValue.Name = "lblBlueValue";
            this.lblBlueValue.Size = new System.Drawing.Size(32, 19);
            this.lblBlueValue.TabIndex = 34;
            this.lblBlueValue.Text = "Azul";
            // 
            // txtGreen
            // 
            this.txtGreen.AnimateReadOnly = false;
            this.txtGreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGreen.Depth = 0;
            this.txtGreen.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtGreen.LeadingIcon = null;
            this.txtGreen.Location = new System.Drawing.Point(633, 265);
            this.txtGreen.Margin = new System.Windows.Forms.Padding(2);
            this.txtGreen.MaxLength = 50;
            this.txtGreen.MouseState = MaterialSkin.MouseState.OUT;
            this.txtGreen.Multiline = false;
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(80, 50);
            this.txtGreen.TabIndex = 29;
            this.txtGreen.Text = "";
            this.txtGreen.TrailingIcon = null;
            // 
            // lblGreenValue
            // 
            this.lblGreenValue.AutoSize = true;
            this.lblGreenValue.Depth = 0;
            this.lblGreenValue.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGreenValue.Location = new System.Drawing.Point(630, 245);
            this.lblGreenValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGreenValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGreenValue.Name = "lblGreenValue";
            this.lblGreenValue.Size = new System.Drawing.Size(41, 19);
            this.lblGreenValue.TabIndex = 32;
            this.lblGreenValue.Text = "Verde";
            // 
            // btnCloseTab
            // 
            this.btnCloseTab.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCloseTab.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCloseTab.Depth = 0;
            this.btnCloseTab.HighEmphasis = true;
            this.btnCloseTab.Icon = null;
            this.btnCloseTab.Location = new System.Drawing.Point(689, 421);
            this.btnCloseTab.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCloseTab.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCloseTab.Name = "btnCloseTab";
            this.btnCloseTab.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCloseTab.Size = new System.Drawing.Size(77, 36);
            this.btnCloseTab.TabIndex = 33;
            this.btnCloseTab.Text = "Cerrar";
            this.btnCloseTab.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCloseTab.UseAccentColor = false;
            this.btnCloseTab.UseVisualStyleBackColor = true;
            this.btnCloseTab.Click += new System.EventHandler(this.BtnCloseTab_Click);
            // 
            // btnSaveMaterial
            // 
            this.btnSaveMaterial.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveMaterial.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveMaterial.Depth = 0;
            this.btnSaveMaterial.HighEmphasis = true;
            this.btnSaveMaterial.Icon = null;
            this.btnSaveMaterial.Location = new System.Drawing.Point(578, 421);
            this.btnSaveMaterial.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSaveMaterial.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveMaterial.Name = "btnSaveMaterial";
            this.btnSaveMaterial.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveMaterial.Size = new System.Drawing.Size(88, 36);
            this.btnSaveMaterial.TabIndex = 32;
            this.btnSaveMaterial.Text = "Guardar";
            this.btnSaveMaterial.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveMaterial.UseAccentColor = false;
            this.btnSaveMaterial.UseVisualStyleBackColor = true;
            this.btnSaveMaterial.Click += new System.EventHandler(this.BtnSaveMaterial_Click);
            // 
            // txtRed
            // 
            this.txtRed.AnimateReadOnly = false;
            this.txtRed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRed.Depth = 0;
            this.txtRed.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRed.LeadingIcon = null;
            this.txtRed.Location = new System.Drawing.Point(546, 266);
            this.txtRed.Margin = new System.Windows.Forms.Padding(2);
            this.txtRed.MaxLength = 50;
            this.txtRed.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRed.Multiline = false;
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(80, 50);
            this.txtRed.TabIndex = 28;
            this.txtRed.Text = "";
            this.txtRed.TrailingIcon = null;
            // 
            // lblRedValue
            // 
            this.lblRedValue.AutoSize = true;
            this.lblRedValue.Depth = 0;
            this.lblRedValue.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRedValue.Location = new System.Drawing.Point(543, 245);
            this.lblRedValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRedValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRedValue.Name = "lblRedValue";
            this.lblRedValue.Size = new System.Drawing.Size(33, 19);
            this.lblRedValue.TabIndex = 27;
            this.lblRedValue.Text = "Rojo";
            // 
            // txtFigureName
            // 
            this.txtFigureName.AnimateReadOnly = false;
            this.txtFigureName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFigureName.Depth = 0;
            this.txtFigureName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFigureName.LeadingIcon = null;
            this.txtFigureName.Location = new System.Drawing.Point(546, 193);
            this.txtFigureName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFigureName.MaxLength = 50;
            this.txtFigureName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFigureName.Multiline = false;
            this.txtFigureName.Name = "txtFigureName";
            this.txtFigureName.Size = new System.Drawing.Size(253, 50);
            this.txtFigureName.TabIndex = 26;
            this.txtFigureName.Text = "";
            this.txtFigureName.TrailingIcon = null;
            // 
            // lblFigureName
            // 
            this.lblFigureName.AutoSize = true;
            this.lblFigureName.Depth = 0;
            this.lblFigureName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFigureName.Location = new System.Drawing.Point(543, 175);
            this.lblFigureName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFigureName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFigureName.Name = "lblFigureName";
            this.lblFigureName.Size = new System.Drawing.Size(57, 19);
            this.lblFigureName.TabIndex = 25;
            this.lblFigureName.Text = "Nombre";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.Location = new System.Drawing.Point(623, 149);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(108, 19);
            this.lblTitle.TabIndex = 24;
            this.lblTitle.Text = "Nuevo Material";
            // 
            // txtRoughness
            // 
            this.txtRoughness.AnimateReadOnly = false;
            this.txtRoughness.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRoughness.Depth = 0;
            this.txtRoughness.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRoughness.LeadingIcon = null;
            this.txtRoughness.Location = new System.Drawing.Point(546, 337);
            this.txtRoughness.Margin = new System.Windows.Forms.Padding(2);
            this.txtRoughness.MaxLength = 50;
            this.txtRoughness.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRoughness.Multiline = false;
            this.txtRoughness.Name = "txtRoughness";
            this.txtRoughness.Size = new System.Drawing.Size(253, 50);
            this.txtRoughness.TabIndex = 31;
            this.txtRoughness.Text = "";
            this.txtRoughness.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(543, 316);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(85, 19);
            this.materialLabel1.TabIndex = 35;
            this.materialLabel1.Text = "Difuminado";
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(543, 389);
            this.lblmsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(211, 13);
            this.lblmsg.TabIndex = 37;
            this.lblmsg.Text = "En caso de ser decimales, utilice una coma";
            // 
            // AddMetallicScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.txtRoughness);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtBlue);
            this.Controls.Add(this.lblBlueValue);
            this.Controls.Add(this.txtGreen);
            this.Controls.Add(this.lblGreenValue);
            this.Controls.Add(this.btnCloseTab);
            this.Controls.Add(this.btnSaveMaterial);
            this.Controls.Add(this.txtRed);
            this.Controls.Add(this.lblRedValue);
            this.Controls.Add(this.txtFigureName);
            this.Controls.Add(this.lblFigureName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlMenu);
            this.Name = "AddMetallicScreen";
            this.Size = new System.Drawing.Size(1188, 627);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private MaterialSkin.Controls.MaterialTextBox txtBlue;
        private MaterialSkin.Controls.MaterialLabel lblBlueValue;
        private MaterialSkin.Controls.MaterialTextBox txtGreen;
        private MaterialSkin.Controls.MaterialLabel lblGreenValue;
        private MaterialSkin.Controls.MaterialButton btnCloseTab;
        private MaterialSkin.Controls.MaterialButton btnSaveMaterial;
        private MaterialSkin.Controls.MaterialTextBox txtRed;
        private MaterialSkin.Controls.MaterialLabel lblRedValue;
        private MaterialSkin.Controls.MaterialTextBox txtFigureName;
        private MaterialSkin.Controls.MaterialLabel lblFigureName;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private MaterialSkin.Controls.MaterialTextBox txtRoughness;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label lblmsg;
    }
}
