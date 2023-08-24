namespace UI
{
    partial class FigureScreen
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
            this.btnAddFigure = new MaterialSkin.Controls.MaterialButton();
            this.pnlList = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(253, 627);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnAddFigure
            // 
            this.btnAddFigure.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddFigure.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddFigure.Depth = 0;
            this.btnAddFigure.HighEmphasis = true;
            this.btnAddFigure.Icon = null;
            this.btnAddFigure.Location = new System.Drawing.Point(342, 5);
            this.btnAddFigure.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAddFigure.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddFigure.Name = "btnAddFigure";
            this.btnAddFigure.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddFigure.Size = new System.Drawing.Size(194, 36);
            this.btnAddFigure.TabIndex = 2;
            this.btnAddFigure.Text = "Agregar Nueva Figura";
            this.btnAddFigure.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddFigure.UseAccentColor = false;
            this.btnAddFigure.UseVisualStyleBackColor = true;
            this.btnAddFigure.Click += new System.EventHandler(this.BtnAddFigure_Click);
            // 
            // pnlList
            // 
            this.pnlList.AutoScroll = true;
            this.pnlList.Location = new System.Drawing.Point(342, 72);
            this.pnlList.Margin = new System.Windows.Forms.Padding(2);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(844, 555);
            this.pnlList.TabIndex = 3;
            // 
            // FigureScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.btnAddFigure);
            this.Controls.Add(this.pnlMenu);
            this.Name = "FigureScreen";
            this.Size = new System.Drawing.Size(1188, 627);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlMenu;
        private MaterialSkin.Controls.MaterialButton btnAddFigure;
        private System.Windows.Forms.FlowLayoutPanel pnlList;
    }
}
