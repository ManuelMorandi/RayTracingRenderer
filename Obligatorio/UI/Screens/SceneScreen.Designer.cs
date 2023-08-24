namespace UI.Screens
{
    partial class SceneScreen
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
            this.btnAddScene = new MaterialSkin.Controls.MaterialButton();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlList
            // 
            this.pnlList.AutoScroll = true;
            this.pnlList.Location = new System.Drawing.Point(343, 70);
            this.pnlList.Margin = new System.Windows.Forms.Padding(2);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(844, 555);
            this.pnlList.TabIndex = 9;
            // 
            // btnAddScene
            // 
            this.btnAddScene.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddScene.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddScene.Depth = 0;
            this.btnAddScene.HighEmphasis = true;
            this.btnAddScene.Icon = null;
            this.btnAddScene.Location = new System.Drawing.Point(343, 5);
            this.btnAddScene.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAddScene.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddScene.Name = "btnAddScene";
            this.btnAddScene.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddScene.Size = new System.Drawing.Size(214, 36);
            this.btnAddScene.TabIndex = 8;
            this.btnAddScene.Text = "Agregar Nueva Escena";
            this.btnAddScene.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddScene.UseAccentColor = false;
            this.btnAddScene.UseVisualStyleBackColor = true;
            this.btnAddScene.Click += new System.EventHandler(this.btnAddScene_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Location = new System.Drawing.Point(1, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(253, 627);
            this.pnlMenu.TabIndex = 7;
            // 
            // SceneScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.btnAddScene);
            this.Controls.Add(this.pnlMenu);
            this.Name = "SceneScreen";
            this.Size = new System.Drawing.Size(1188, 627);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlList;
        private MaterialSkin.Controls.MaterialButton btnAddScene;
        private System.Windows.Forms.Panel pnlMenu;
    }
}
