namespace UI
{
    partial class AddFigureScreen
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
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.lblFigureName = new MaterialSkin.Controls.MaterialLabel();
            this.txtFigureName = new MaterialSkin.Controls.MaterialTextBox();
            this.lblFigureRadius = new MaterialSkin.Controls.MaterialLabel();
            this.txtFigureRadius = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSaveFigure = new MaterialSkin.Controls.MaterialButton();
            this.btnCloseTab = new MaterialSkin.Controls.MaterialButton();
            this.lblmsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Location = new System.Drawing.Point(1, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(337, 772);
            this.pnlMenu.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.Location = new System.Drawing.Point(827, 210);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(95, 19);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Nueva Figura";
            // 
            // lblFigureName
            // 
            this.lblFigureName.AutoSize = true;
            this.lblFigureName.Depth = 0;
            this.lblFigureName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFigureName.Location = new System.Drawing.Point(720, 242);
            this.lblFigureName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFigureName.Name = "lblFigureName";
            this.lblFigureName.Size = new System.Drawing.Size(57, 19);
            this.lblFigureName.TabIndex = 5;
            this.lblFigureName.Text = "Nombre";
            // 
            // txtFigureName
            // 
            this.txtFigureName.AnimateReadOnly = false;
            this.txtFigureName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFigureName.Depth = 0;
            this.txtFigureName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFigureName.LeadingIcon = null;
            this.txtFigureName.Location = new System.Drawing.Point(724, 265);
            this.txtFigureName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFigureName.MaxLength = 50;
            this.txtFigureName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFigureName.Multiline = false;
            this.txtFigureName.Name = "txtFigureName";
            this.txtFigureName.Size = new System.Drawing.Size(337, 50);
            this.txtFigureName.TabIndex = 6;
            this.txtFigureName.Text = "";
            this.txtFigureName.TrailingIcon = null;
            // 
            // lblFigureRadius
            // 
            this.lblFigureRadius.AutoSize = true;
            this.lblFigureRadius.Depth = 0;
            this.lblFigureRadius.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFigureRadius.Location = new System.Drawing.Point(720, 329);
            this.lblFigureRadius.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFigureRadius.Name = "lblFigureRadius";
            this.lblFigureRadius.Size = new System.Drawing.Size(42, 19);
            this.lblFigureRadius.TabIndex = 7;
            this.lblFigureRadius.Text = "Radio";
            // 
            // txtFigureRadius
            // 
            this.txtFigureRadius.AnimateReadOnly = false;
            this.txtFigureRadius.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFigureRadius.Depth = 0;
            this.txtFigureRadius.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFigureRadius.LeadingIcon = null;
            this.txtFigureRadius.Location = new System.Drawing.Point(724, 354);
            this.txtFigureRadius.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFigureRadius.MaxLength = 50;
            this.txtFigureRadius.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFigureRadius.Multiline = false;
            this.txtFigureRadius.Name = "txtFigureRadius";
            this.txtFigureRadius.Size = new System.Drawing.Size(100, 50);
            this.txtFigureRadius.TabIndex = 8;
            this.txtFigureRadius.Text = "";
            this.txtFigureRadius.TrailingIcon = null;
            // 
            // btnSaveFigure
            // 
            this.btnSaveFigure.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveFigure.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveFigure.Depth = 0;
            this.btnSaveFigure.HighEmphasis = true;
            this.btnSaveFigure.Icon = null;
            this.btnSaveFigure.Location = new System.Drawing.Point(767, 454);
            this.btnSaveFigure.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveFigure.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveFigure.Name = "btnSaveFigure";
            this.btnSaveFigure.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveFigure.Size = new System.Drawing.Size(88, 36);
            this.btnSaveFigure.TabIndex = 9;
            this.btnSaveFigure.Text = "Guardar";
            this.btnSaveFigure.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveFigure.UseAccentColor = false;
            this.btnSaveFigure.UseVisualStyleBackColor = true;
            this.btnSaveFigure.Click += new System.EventHandler(this.BtnSaveFigure_Click);
            // 
            // btnCloseTab
            // 
            this.btnCloseTab.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCloseTab.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCloseTab.Depth = 0;
            this.btnCloseTab.HighEmphasis = true;
            this.btnCloseTab.Icon = null;
            this.btnCloseTab.Location = new System.Drawing.Point(915, 454);
            this.btnCloseTab.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCloseTab.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCloseTab.Name = "btnCloseTab";
            this.btnCloseTab.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCloseTab.Size = new System.Drawing.Size(77, 36);
            this.btnCloseTab.TabIndex = 10;
            this.btnCloseTab.Text = "Cerrar";
            this.btnCloseTab.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCloseTab.UseAccentColor = false;
            this.btnCloseTab.UseVisualStyleBackColor = true;
            this.btnCloseTab.Click += new System.EventHandler(this.BtnCloseTab_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(723, 410);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(265, 16);
            this.lblmsg.TabIndex = 11;
            this.lblmsg.Text = "En caso de ser decimales, utilice una coma";
            // 
            // AddFigureScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btnCloseTab);
            this.Controls.Add(this.btnSaveFigure);
            this.Controls.Add(this.txtFigureRadius);
            this.Controls.Add(this.lblFigureRadius);
            this.Controls.Add(this.txtFigureName);
            this.Controls.Add(this.lblFigureName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddFigureScreen";
            this.Size = new System.Drawing.Size(1584, 772);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private MaterialSkin.Controls.MaterialLabel lblFigureName;
        private MaterialSkin.Controls.MaterialTextBox txtFigureName;
        private MaterialSkin.Controls.MaterialLabel lblFigureRadius;
        private MaterialSkin.Controls.MaterialTextBox txtFigureRadius;
        private MaterialSkin.Controls.MaterialButton btnSaveFigure;
        private MaterialSkin.Controls.MaterialButton btnCloseTab;
        private System.Windows.Forms.Label lblmsg;
    }
}
