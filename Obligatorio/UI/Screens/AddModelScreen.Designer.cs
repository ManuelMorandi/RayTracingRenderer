namespace UI.Screens
{
    partial class AddModelScreen
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
            this.btnCloseTab = new MaterialSkin.Controls.MaterialButton();
            this.btnSaveModel = new MaterialSkin.Controls.MaterialButton();
            this.txtModelName = new MaterialSkin.Controls.MaterialTextBox();
            this.lblFigureName = new MaterialSkin.Controls.MaterialLabel();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.chkPreview = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cboxShape = new MaterialSkin.Controls.MaterialComboBox();
            this.cboxMaterial = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btnCloseTab
            // 
            this.btnCloseTab.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCloseTab.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCloseTab.Depth = 0;
            this.btnCloseTab.HighEmphasis = true;
            this.btnCloseTab.Icon = null;
            this.btnCloseTab.Location = new System.Drawing.Point(702, 436);
            this.btnCloseTab.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCloseTab.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCloseTab.Name = "btnCloseTab";
            this.btnCloseTab.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCloseTab.Size = new System.Drawing.Size(77, 36);
            this.btnCloseTab.TabIndex = 32;
            this.btnCloseTab.Text = "Cerrar";
            this.btnCloseTab.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCloseTab.UseAccentColor = false;
            this.btnCloseTab.UseVisualStyleBackColor = true;
            this.btnCloseTab.Click += new System.EventHandler(this.BtnCloseTab_Click);
            // 
            // btnSaveModel
            // 
            this.btnSaveModel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveModel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveModel.Depth = 0;
            this.btnSaveModel.HighEmphasis = true;
            this.btnSaveModel.Icon = null;
            this.btnSaveModel.Location = new System.Drawing.Point(591, 436);
            this.btnSaveModel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSaveModel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveModel.Name = "btnSaveModel";
            this.btnSaveModel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveModel.Size = new System.Drawing.Size(88, 36);
            this.btnSaveModel.TabIndex = 31;
            this.btnSaveModel.Text = "Guardar";
            this.btnSaveModel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveModel.UseAccentColor = false;
            this.btnSaveModel.UseVisualStyleBackColor = true;
            this.btnSaveModel.Click += new System.EventHandler(this.BtnSaveModel_Click);
            // 
            // txtModelName
            // 
            this.txtModelName.AnimateReadOnly = false;
            this.txtModelName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModelName.Depth = 0;
            this.txtModelName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtModelName.LeadingIcon = null;
            this.txtModelName.Location = new System.Drawing.Point(559, 170);
            this.txtModelName.Margin = new System.Windows.Forms.Padding(2);
            this.txtModelName.MaxLength = 50;
            this.txtModelName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtModelName.Multiline = false;
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(253, 50);
            this.txtModelName.TabIndex = 28;
            this.txtModelName.Text = "";
            this.txtModelName.TrailingIcon = null;
            // 
            // lblFigureName
            // 
            this.lblFigureName.AutoSize = true;
            this.lblFigureName.Depth = 0;
            this.lblFigureName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFigureName.Location = new System.Drawing.Point(556, 149);
            this.lblFigureName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFigureName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFigureName.Name = "lblFigureName";
            this.lblFigureName.Size = new System.Drawing.Size(57, 19);
            this.lblFigureName.TabIndex = 27;
            this.lblFigureName.Text = "Nombre";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.Location = new System.Drawing.Point(636, 139);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(103, 19);
            this.lblTitle.TabIndex = 26;
            this.lblTitle.Text = "Nuevo Modelo";
            // 
            // pnlMenu
            // 
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(253, 627);
            this.pnlMenu.TabIndex = 25;
            // 
            // chkPreview
            // 
            this.chkPreview.AutoSize = true;
            this.chkPreview.Depth = 0;
            this.chkPreview.Location = new System.Drawing.Point(559, 364);
            this.chkPreview.Margin = new System.Windows.Forms.Padding(0);
            this.chkPreview.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkPreview.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkPreview.Name = "chkPreview";
            this.chkPreview.ReadOnly = false;
            this.chkPreview.Ripple = true;
            this.chkPreview.Size = new System.Drawing.Size(224, 37);
            this.chkPreview.TabIndex = 34;
            this.chkPreview.Text = "Generar preview al guardar";
            this.chkPreview.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(556, 222);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(46, 19);
            this.materialLabel1.TabIndex = 35;
            this.materialLabel1.Text = "Figura";
            // 
            // cboxShape
            // 
            this.cboxShape.AutoResize = false;
            this.cboxShape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboxShape.Depth = 0;
            this.cboxShape.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboxShape.DropDownHeight = 174;
            this.cboxShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxShape.DropDownWidth = 121;
            this.cboxShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboxShape.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboxShape.FormattingEnabled = true;
            this.cboxShape.IntegralHeight = false;
            this.cboxShape.ItemHeight = 43;
            this.cboxShape.Location = new System.Drawing.Point(558, 244);
            this.cboxShape.MaxDropDownItems = 4;
            this.cboxShape.MouseState = MaterialSkin.MouseState.OUT;
            this.cboxShape.Name = "cboxShape";
            this.cboxShape.Size = new System.Drawing.Size(254, 49);
            this.cboxShape.StartIndex = 0;
            this.cboxShape.TabIndex = 36;
            // 
            // cboxMaterial
            // 
            this.cboxMaterial.AutoResize = false;
            this.cboxMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboxMaterial.Depth = 0;
            this.cboxMaterial.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboxMaterial.DropDownHeight = 174;
            this.cboxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMaterial.DropDownWidth = 121;
            this.cboxMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboxMaterial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboxMaterial.FormattingEnabled = true;
            this.cboxMaterial.IntegralHeight = false;
            this.cboxMaterial.ItemHeight = 43;
            this.cboxMaterial.Location = new System.Drawing.Point(558, 319);
            this.cboxMaterial.MaxDropDownItems = 4;
            this.cboxMaterial.MouseState = MaterialSkin.MouseState.OUT;
            this.cboxMaterial.Name = "cboxMaterial";
            this.cboxMaterial.Size = new System.Drawing.Size(254, 49);
            this.cboxMaterial.StartIndex = 0;
            this.cboxMaterial.TabIndex = 38;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(556, 297);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(59, 19);
            this.materialLabel2.TabIndex = 37;
            this.materialLabel2.Text = "Material";
            // 
            // AddModelScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboxMaterial);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.cboxShape);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.chkPreview);
            this.Controls.Add(this.btnCloseTab);
            this.Controls.Add(this.btnSaveModel);
            this.Controls.Add(this.txtModelName);
            this.Controls.Add(this.lblFigureName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlMenu);
            this.Name = "AddModelScreen";
            this.Size = new System.Drawing.Size(1188, 627);
            this.Load += new System.EventHandler(this.AddModelScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnCloseTab;
        private MaterialSkin.Controls.MaterialButton btnSaveModel;
        private MaterialSkin.Controls.MaterialTextBox txtModelName;
        private MaterialSkin.Controls.MaterialLabel lblFigureName;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private System.Windows.Forms.Panel pnlMenu;
        private MaterialSkin.Controls.MaterialCheckbox chkPreview;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox cboxShape;
        private MaterialSkin.Controls.MaterialComboBox cboxMaterial;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}
