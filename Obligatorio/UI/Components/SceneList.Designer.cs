namespace UI.Components
{
    partial class SceneList
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
            this.imgPreview = new System.Windows.Forms.PictureBox();
            this.btnDeleteElement = new MaterialSkin.Controls.MaterialButton();
            this.lblElementInfo = new MaterialSkin.Controls.MaterialLabel();
            this.lblElementName = new MaterialSkin.Controls.MaterialLabel();
            this.btnEdit = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPreview
            // 
            this.imgPreview.Location = new System.Drawing.Point(3, 3);
            this.imgPreview.Name = "imgPreview";
            this.imgPreview.Size = new System.Drawing.Size(111, 74);
            this.imgPreview.TabIndex = 0;
            this.imgPreview.TabStop = false;
            // 
            // btnDeleteElement
            // 
            this.btnDeleteElement.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteElement.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteElement.Depth = 0;
            this.btnDeleteElement.HighEmphasis = true;
            this.btnDeleteElement.Icon = null;
            this.btnDeleteElement.Location = new System.Drawing.Point(628, 23);
            this.btnDeleteElement.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnDeleteElement.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteElement.Name = "btnDeleteElement";
            this.btnDeleteElement.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteElement.Size = new System.Drawing.Size(64, 36);
            this.btnDeleteElement.TabIndex = 6;
            this.btnDeleteElement.Text = "X";
            this.btnDeleteElement.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteElement.UseAccentColor = false;
            this.btnDeleteElement.UseVisualStyleBackColor = true;
            this.btnDeleteElement.Click += new System.EventHandler(this.BtnDeleteElement_Click);
            // 
            // lblElementInfo
            // 
            this.lblElementInfo.AutoSize = true;
            this.lblElementInfo.Depth = 0;
            this.lblElementInfo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblElementInfo.Location = new System.Drawing.Point(130, 45);
            this.lblElementInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblElementInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblElementInfo.Name = "lblElementInfo";
            this.lblElementInfo.Size = new System.Drawing.Size(1, 0);
            this.lblElementInfo.TabIndex = 5;
            // 
            // lblElementName
            // 
            this.lblElementName.AutoSize = true;
            this.lblElementName.Depth = 0;
            this.lblElementName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblElementName.Location = new System.Drawing.Point(129, 21);
            this.lblElementName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblElementName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblElementName.Name = "lblElementName";
            this.lblElementName.Size = new System.Drawing.Size(1, 0);
            this.lblElementName.TabIndex = 4;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEdit.Depth = 0;
            this.btnEdit.HighEmphasis = true;
            this.btnEdit.Icon = null;
            this.btnEdit.Location = new System.Drawing.Point(543, 23);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEdit.Size = new System.Drawing.Size(71, 36);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Editar";
            this.btnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEdit.UseAccentColor = false;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // SceneList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDeleteElement);
            this.Controls.Add(this.lblElementInfo);
            this.Controls.Add(this.lblElementName);
            this.Controls.Add(this.imgPreview);
            this.Name = "SceneList";
            this.Size = new System.Drawing.Size(700, 80);
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPreview;
        private MaterialSkin.Controls.MaterialButton btnDeleteElement;
        private MaterialSkin.Controls.MaterialLabel lblElementInfo;
        private MaterialSkin.Controls.MaterialLabel lblElementName;
        private MaterialSkin.Controls.MaterialButton btnEdit;
    }
}
