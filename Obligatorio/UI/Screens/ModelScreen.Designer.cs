namespace UI.Screens
{
    partial class ModelScreen
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
            this.btnAddModel = new MaterialSkin.Controls.MaterialButton();
            this.pnlMenu = new System.Windows.Forms.Panel();
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
            // btnAddModel
            // 
            this.btnAddModel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddModel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddModel.Depth = 0;
            this.btnAddModel.HighEmphasis = true;
            this.btnAddModel.Icon = null;
            this.btnAddModel.Location = new System.Drawing.Point(342, 5);
            this.btnAddModel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAddModel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddModel.Name = "btnAddModel";
            this.btnAddModel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddModel.Size = new System.Drawing.Size(203, 36);
            this.btnAddModel.TabIndex = 5;
            this.btnAddModel.Text = "Agregar Nuevo Modelo";
            this.btnAddModel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddModel.UseAccentColor = false;
            this.btnAddModel.UseVisualStyleBackColor = true;
            this.btnAddModel.Click += new System.EventHandler(this.BtnAddModel_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(253, 627);
            this.pnlMenu.TabIndex = 4;
            // 
            // ModelScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.btnAddModel);
            this.Controls.Add(this.pnlMenu);
            this.Name = "ModelScreen";
            this.Size = new System.Drawing.Size(1188, 627);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlList;
        private MaterialSkin.Controls.MaterialButton btnAddModel;
        private System.Windows.Forms.Panel pnlMenu;
    }
}
