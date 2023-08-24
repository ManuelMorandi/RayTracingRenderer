namespace UI
{
    partial class ListElement
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
            this.lblElementName = new MaterialSkin.Controls.MaterialLabel();
            this.lblElementInfo = new MaterialSkin.Controls.MaterialLabel();
            this.btnDeleteElement = new MaterialSkin.Controls.MaterialButton();
            this.imgShape = new System.Windows.Forms.PictureBox();
            this.imgColor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgShape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgColor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblElementName
            // 
            this.lblElementName.AutoSize = true;
            this.lblElementName.Depth = 0;
            this.lblElementName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblElementName.Location = new System.Drawing.Point(67, 14);
            this.lblElementName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblElementName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblElementName.Name = "lblElementName";
            this.lblElementName.Size = new System.Drawing.Size(1, 0);
            this.lblElementName.TabIndex = 1;
            // 
            // lblElementInfo
            // 
            this.lblElementInfo.AutoSize = true;
            this.lblElementInfo.Depth = 0;
            this.lblElementInfo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblElementInfo.Location = new System.Drawing.Point(68, 38);
            this.lblElementInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblElementInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblElementInfo.Name = "lblElementInfo";
            this.lblElementInfo.Size = new System.Drawing.Size(1, 0);
            this.lblElementInfo.TabIndex = 2;
            // 
            // btnDeleteElement
            // 
            this.btnDeleteElement.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteElement.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteElement.Depth = 0;
            this.btnDeleteElement.HighEmphasis = true;
            this.btnDeleteElement.Icon = null;
            this.btnDeleteElement.Location = new System.Drawing.Point(623, 15);
            this.btnDeleteElement.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnDeleteElement.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteElement.Name = "btnDeleteElement";
            this.btnDeleteElement.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteElement.Size = new System.Drawing.Size(64, 36);
            this.btnDeleteElement.TabIndex = 3;
            this.btnDeleteElement.Text = "X";
            this.btnDeleteElement.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteElement.UseAccentColor = false;
            this.btnDeleteElement.UseVisualStyleBackColor = true;
            this.btnDeleteElement.Click += new System.EventHandler(this.BtnDeleteElement_Click);
            // 
            // imgShape
            // 
            this.imgShape.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.imgShape.InitialImage = null;
            this.imgShape.Location = new System.Drawing.Point(2, 2);
            this.imgShape.Margin = new System.Windows.Forms.Padding(2);
            this.imgShape.Name = "imgShape";
            this.imgShape.Size = new System.Drawing.Size(61, 61);
            this.imgShape.TabIndex = 0;
            this.imgShape.TabStop = false;
            // 
            // imgColor
            // 
            this.imgColor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.imgColor.InitialImage = null;
            this.imgColor.Location = new System.Drawing.Point(38, 38);
            this.imgColor.Margin = new System.Windows.Forms.Padding(2);
            this.imgColor.Name = "imgColor";
            this.imgColor.Size = new System.Drawing.Size(25, 25);
            this.imgColor.TabIndex = 4;
            this.imgColor.TabStop = false;
            // 
            // ListElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.imgColor);
            this.Controls.Add(this.btnDeleteElement);
            this.Controls.Add(this.lblElementInfo);
            this.Controls.Add(this.lblElementName);
            this.Controls.Add(this.imgShape);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListElement";
            this.Size = new System.Drawing.Size(700, 65);
            ((System.ComponentModel.ISupportInitialize)(this.imgShape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgShape;
        private MaterialSkin.Controls.MaterialLabel lblElementName;
        private MaterialSkin.Controls.MaterialLabel lblElementInfo;
        private MaterialSkin.Controls.MaterialButton btnDeleteElement;
        private System.Windows.Forms.PictureBox imgColor;
    }
}
