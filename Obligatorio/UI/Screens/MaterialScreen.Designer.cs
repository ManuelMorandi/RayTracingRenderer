namespace UI.Screens
{
    partial class MaterialScreen
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
            this.pnlList = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddMaterial = new MaterialSkin.Controls.MaterialButton();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.cboxMaterial = new MaterialSkin.Controls.MaterialComboBox();
            this.SuspendLayout();
            // 
            // pnlList
            // 
            this.pnlList.AutoScroll = true;
            this.pnlList.Location = new System.Drawing.Point(342, 70);
            this.pnlList.Margin = new System.Windows.Forms.Padding(2);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(844, 555);
            this.pnlList.TabIndex = 6;
            // 
            // btnAddMaterial
            // 
            this.btnAddMaterial.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddMaterial.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddMaterial.Depth = 0;
            this.btnAddMaterial.HighEmphasis = true;
            this.btnAddMaterial.Icon = null;
            this.btnAddMaterial.Location = new System.Drawing.Point(641, 5);
            this.btnAddMaterial.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAddMaterial.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddMaterial.Size = new System.Drawing.Size(214, 36);
            this.btnAddMaterial.TabIndex = 5;
            this.btnAddMaterial.Text = "Agregar Nuevo Material";
            this.btnAddMaterial.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddMaterial.UseAccentColor = false;
            this.btnAddMaterial.UseVisualStyleBackColor = true;
            this.btnAddMaterial.Click += new System.EventHandler(this.BtnAddMaterial_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(253, 627);
            this.pnlMenu.TabIndex = 4;
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
            this.cboxMaterial.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboxMaterial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboxMaterial.FormattingEnabled = true;
            this.cboxMaterial.IntegralHeight = false;
            this.cboxMaterial.ItemHeight = 43;
            this.cboxMaterial.Items.AddRange(new object[] {
            "Lambertiano",
            "Metálico"});
            this.cboxMaterial.Location = new System.Drawing.Point(342, 5);
            this.cboxMaterial.MaxDropDownItems = 4;
            this.cboxMaterial.MouseState = MaterialSkin.MouseState.OUT;
            this.cboxMaterial.Name = "cboxMaterial";
            this.cboxMaterial.Size = new System.Drawing.Size(293, 49);
            this.cboxMaterial.StartIndex = 0;
            this.cboxMaterial.TabIndex = 7;
            // 
            // MaterialScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboxMaterial);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.btnAddMaterial);
            this.Controls.Add(this.pnlMenu);
            this.Name = "MaterialScreen";
            this.Size = new System.Drawing.Size(1188, 627);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlList;
        private MaterialSkin.Controls.MaterialButton btnAddMaterial;
        private System.Windows.Forms.Panel pnlMenu;
        private MaterialSkin.Controls.MaterialComboBox cboxMaterial;
    }
}
