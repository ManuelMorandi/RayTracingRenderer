namespace UI
{
    partial class Menu
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
            this.btnFigure = new MaterialSkin.Controls.MaterialButton();
            this.btnMaterial = new MaterialSkin.Controls.MaterialButton();
            this.btnModel = new MaterialSkin.Controls.MaterialButton();
            this.btnScene = new MaterialSkin.Controls.MaterialButton();
            this.lblUserName = new MaterialSkin.Controls.MaterialLabel();
            this.btnSignOut = new MaterialSkin.Controls.MaterialButton();
            this.imgUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFigure
            // 
            this.btnFigure.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFigure.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFigure.Depth = 0;
            this.btnFigure.HighEmphasis = true;
            this.btnFigure.Icon = null;
            this.btnFigure.Location = new System.Drawing.Point(77, 140);
            this.btnFigure.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnFigure.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFigure.Name = "btnFigure";
            this.btnFigure.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFigure.Size = new System.Drawing.Size(81, 36);
            this.btnFigure.TabIndex = 0;
            this.btnFigure.Text = "Figuras";
            this.btnFigure.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFigure.UseAccentColor = false;
            this.btnFigure.UseVisualStyleBackColor = true;
            this.btnFigure.Click += new System.EventHandler(this.BtnFigure_Click);
            // 
            // btnMaterial
            // 
            this.btnMaterial.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMaterial.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMaterial.Depth = 0;
            this.btnMaterial.HighEmphasis = true;
            this.btnMaterial.Icon = null;
            this.btnMaterial.Location = new System.Drawing.Point(62, 226);
            this.btnMaterial.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnMaterial.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMaterial.Size = new System.Drawing.Size(110, 36);
            this.btnMaterial.TabIndex = 1;
            this.btnMaterial.Text = "Materiales";
            this.btnMaterial.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMaterial.UseAccentColor = false;
            this.btnMaterial.UseVisualStyleBackColor = true;
            this.btnMaterial.Click += new System.EventHandler(this.BtnMaterial_Click);
            // 
            // btnModel
            // 
            this.btnModel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnModel.Depth = 0;
            this.btnModel.HighEmphasis = true;
            this.btnModel.Icon = null;
            this.btnModel.Location = new System.Drawing.Point(70, 315);
            this.btnModel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnModel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModel.Name = "btnModel";
            this.btnModel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnModel.Size = new System.Drawing.Size(90, 36);
            this.btnModel.TabIndex = 2;
            this.btnModel.Text = "Modelos";
            this.btnModel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnModel.UseAccentColor = false;
            this.btnModel.UseVisualStyleBackColor = true;
            this.btnModel.Click += new System.EventHandler(this.BtnModel_Click);
            // 
            // btnScene
            // 
            this.btnScene.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnScene.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnScene.Depth = 0;
            this.btnScene.HighEmphasis = true;
            this.btnScene.Icon = null;
            this.btnScene.Location = new System.Drawing.Point(73, 403);
            this.btnScene.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnScene.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnScene.Name = "btnScene";
            this.btnScene.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnScene.Size = new System.Drawing.Size(86, 36);
            this.btnScene.TabIndex = 3;
            this.btnScene.Text = "Escenas";
            this.btnScene.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnScene.UseAccentColor = false;
            this.btnScene.UseVisualStyleBackColor = true;
            this.btnScene.Click += new System.EventHandler(this.btnScene_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Depth = 0;
            this.lblUserName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUserName.Location = new System.Drawing.Point(89, 25);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(1, 0);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSignOut
            // 
            this.btnSignOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSignOut.BackColor = System.Drawing.SystemColors.Control;
            this.btnSignOut.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSignOut.Depth = 0;
            this.btnSignOut.HighEmphasis = true;
            this.btnSignOut.Icon = null;
            this.btnSignOut.Location = new System.Drawing.Point(78, 569);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSignOut.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSignOut.Size = new System.Drawing.Size(87, 36);
            this.btnSignOut.TabIndex = 5;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSignOut.UseAccentColor = false;
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.BtnSignOut_Click);
            // 
            // imgUser
            // 
            this.imgUser.InitialImage = null;
            this.imgUser.Location = new System.Drawing.Point(3, 3);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(76, 76);
            this.imgUser.TabIndex = 6;
            this.imgUser.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imgUser);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnScene);
            this.Controls.Add(this.btnModel);
            this.Controls.Add(this.btnMaterial);
            this.Controls.Add(this.btnFigure);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(253, 627);
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnFigure;
        private MaterialSkin.Controls.MaterialButton btnMaterial;
        private MaterialSkin.Controls.MaterialButton btnModel;
        private MaterialSkin.Controls.MaterialButton btnScene;
        private MaterialSkin.Controls.MaterialLabel lblUserName;
        private MaterialSkin.Controls.MaterialButton btnSignOut;
        private System.Windows.Forms.PictureBox imgUser;
    }
}
