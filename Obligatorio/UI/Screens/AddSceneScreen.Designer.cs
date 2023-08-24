namespace UI.Screens
{
    partial class AddSceneScreen
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
            this.btnCloseTab = new MaterialSkin.Controls.MaterialButton();
            this.btnSaveScene = new MaterialSkin.Controls.MaterialButton();
            this.txtSceneName = new MaterialSkin.Controls.MaterialTextBox();
            this.lblFigureName = new MaterialSkin.Controls.MaterialLabel();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Location = new System.Drawing.Point(1, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(337, 772);
            this.pnlMenu.TabIndex = 3;
            // 
            // btnCloseTab
            // 
            this.btnCloseTab.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCloseTab.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCloseTab.Depth = 0;
            this.btnCloseTab.HighEmphasis = true;
            this.btnCloseTab.Icon = null;
            this.btnCloseTab.Location = new System.Drawing.Point(919, 354);
            this.btnCloseTab.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCloseTab.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCloseTab.Name = "btnCloseTab";
            this.btnCloseTab.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCloseTab.Size = new System.Drawing.Size(77, 36);
            this.btnCloseTab.TabIndex = 15;
            this.btnCloseTab.Text = "Cerrar";
            this.btnCloseTab.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCloseTab.UseAccentColor = false;
            this.btnCloseTab.UseVisualStyleBackColor = true;
            this.btnCloseTab.Click += new System.EventHandler(this.BtnCloseTab_Click);
            // 
            // btnSaveScene
            // 
            this.btnSaveScene.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveScene.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveScene.Depth = 0;
            this.btnSaveScene.HighEmphasis = true;
            this.btnSaveScene.Icon = null;
            this.btnSaveScene.Location = new System.Drawing.Point(771, 354);
            this.btnSaveScene.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveScene.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveScene.Name = "btnSaveScene";
            this.btnSaveScene.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveScene.Size = new System.Drawing.Size(88, 36);
            this.btnSaveScene.TabIndex = 14;
            this.btnSaveScene.Text = "Guardar";
            this.btnSaveScene.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveScene.UseAccentColor = false;
            this.btnSaveScene.UseVisualStyleBackColor = true;
            this.btnSaveScene.Click += new System.EventHandler(this.BtnSaveScene_Click);
            // 
            // txtSceneName
            // 
            this.txtSceneName.AnimateReadOnly = false;
            this.txtSceneName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSceneName.Depth = 0;
            this.txtSceneName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSceneName.LeadingIcon = null;
            this.txtSceneName.Location = new System.Drawing.Point(728, 242);
            this.txtSceneName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSceneName.MaxLength = 50;
            this.txtSceneName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSceneName.Multiline = false;
            this.txtSceneName.Name = "txtSceneName";
            this.txtSceneName.Size = new System.Drawing.Size(337, 50);
            this.txtSceneName.TabIndex = 13;
            this.txtSceneName.Text = "";
            this.txtSceneName.TrailingIcon = null;
            // 
            // lblFigureName
            // 
            this.lblFigureName.AutoSize = true;
            this.lblFigureName.Depth = 0;
            this.lblFigureName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFigureName.Location = new System.Drawing.Point(724, 220);
            this.lblFigureName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFigureName.Name = "lblFigureName";
            this.lblFigureName.Size = new System.Drawing.Size(57, 19);
            this.lblFigureName.TabIndex = 12;
            this.lblFigureName.Text = "Nombre";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.Location = new System.Drawing.Point(831, 167);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(101, 19);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Nueva Escena";
            // 
            // AddSceneScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCloseTab);
            this.Controls.Add(this.btnSaveScene);
            this.Controls.Add(this.txtSceneName);
            this.Controls.Add(this.lblFigureName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddSceneScreen";
            this.Size = new System.Drawing.Size(1584, 772);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private MaterialSkin.Controls.MaterialButton btnCloseTab;
        private MaterialSkin.Controls.MaterialButton btnSaveScene;
        private MaterialSkin.Controls.MaterialTextBox txtSceneName;
        private MaterialSkin.Controls.MaterialLabel lblFigureName;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
    }
}
