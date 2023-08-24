namespace UI.Screens
{
    partial class PositionElementScreen
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
            this.txtZ = new MaterialSkin.Controls.MaterialTextBox();
            this.lblZValue = new MaterialSkin.Controls.MaterialLabel();
            this.txtY = new MaterialSkin.Controls.MaterialTextBox();
            this.lblYValue = new MaterialSkin.Controls.MaterialLabel();
            this.btnCloseTab = new MaterialSkin.Controls.MaterialButton();
            this.btnSaveMaterial = new MaterialSkin.Controls.MaterialButton();
            this.txtX = new MaterialSkin.Controls.MaterialTextBox();
            this.lblXValue = new MaterialSkin.Controls.MaterialLabel();
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.cboxModels = new MaterialSkin.Controls.MaterialComboBox();
            this.lblmsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtZ
            // 
            this.txtZ.AnimateReadOnly = false;
            this.txtZ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtZ.Depth = 0;
            this.txtZ.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtZ.LeadingIcon = null;
            this.txtZ.Location = new System.Drawing.Point(964, 320);
            this.txtZ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZ.MaxLength = 50;
            this.txtZ.MouseState = MaterialSkin.MouseState.OUT;
            this.txtZ.Multiline = false;
            this.txtZ.Name = "txtZ";
            this.txtZ.Size = new System.Drawing.Size(107, 50);
            this.txtZ.TabIndex = 32;
            this.txtZ.Text = "";
            this.txtZ.TrailingIcon = null;
            // 
            // lblZValue
            // 
            this.lblZValue.AutoSize = true;
            this.lblZValue.Depth = 0;
            this.lblZValue.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblZValue.Location = new System.Drawing.Point(960, 293);
            this.lblZValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblZValue.Name = "lblZValue";
            this.lblZValue.Size = new System.Drawing.Size(11, 19);
            this.lblZValue.TabIndex = 35;
            this.lblZValue.Text = "Z";
            // 
            // txtY
            // 
            this.txtY.AnimateReadOnly = false;
            this.txtY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtY.Depth = 0;
            this.txtY.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtY.LeadingIcon = null;
            this.txtY.Location = new System.Drawing.Point(849, 319);
            this.txtY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtY.MaxLength = 50;
            this.txtY.MouseState = MaterialSkin.MouseState.OUT;
            this.txtY.Multiline = false;
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(107, 50);
            this.txtY.TabIndex = 31;
            this.txtY.Text = "";
            this.txtY.TrailingIcon = null;
            // 
            // lblYValue
            // 
            this.lblYValue.AutoSize = true;
            this.lblYValue.Depth = 0;
            this.lblYValue.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblYValue.Location = new System.Drawing.Point(845, 294);
            this.lblYValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblYValue.Name = "lblYValue";
            this.lblYValue.Size = new System.Drawing.Size(11, 19);
            this.lblYValue.TabIndex = 33;
            this.lblYValue.Text = "Y";
            // 
            // btnCloseTab
            // 
            this.btnCloseTab.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCloseTab.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCloseTab.Depth = 0;
            this.btnCloseTab.HighEmphasis = true;
            this.btnCloseTab.Icon = null;
            this.btnCloseTab.Location = new System.Drawing.Point(924, 420);
            this.btnCloseTab.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCloseTab.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCloseTab.Name = "btnCloseTab";
            this.btnCloseTab.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCloseTab.Size = new System.Drawing.Size(77, 36);
            this.btnCloseTab.TabIndex = 34;
            this.btnCloseTab.Text = "Cerrar";
            this.btnCloseTab.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCloseTab.UseAccentColor = false;
            this.btnCloseTab.UseVisualStyleBackColor = true;
            this.btnCloseTab.Click += new System.EventHandler(this.BtnCloseTab_Click);
            // 
            // btnSaveMaterial
            // 
            this.btnSaveMaterial.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveMaterial.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveMaterial.Depth = 0;
            this.btnSaveMaterial.HighEmphasis = true;
            this.btnSaveMaterial.Icon = null;
            this.btnSaveMaterial.Location = new System.Drawing.Point(776, 420);
            this.btnSaveMaterial.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveMaterial.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveMaterial.Name = "btnSaveMaterial";
            this.btnSaveMaterial.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveMaterial.Size = new System.Drawing.Size(88, 36);
            this.btnSaveMaterial.TabIndex = 33;
            this.btnSaveMaterial.Text = "Guardar";
            this.btnSaveMaterial.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveMaterial.UseAccentColor = false;
            this.btnSaveMaterial.UseVisualStyleBackColor = true;
            this.btnSaveMaterial.Click += new System.EventHandler(this.BtnSaveMaterial_Click);
            // 
            // txtX
            // 
            this.txtX.AnimateReadOnly = false;
            this.txtX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtX.Depth = 0;
            this.txtX.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtX.LeadingIcon = null;
            this.txtX.Location = new System.Drawing.Point(733, 320);
            this.txtX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtX.MaxLength = 50;
            this.txtX.MouseState = MaterialSkin.MouseState.OUT;
            this.txtX.Multiline = false;
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(107, 50);
            this.txtX.TabIndex = 30;
            this.txtX.Text = "";
            this.txtX.TrailingIcon = null;
            // 
            // lblXValue
            // 
            this.lblXValue.AutoSize = true;
            this.lblXValue.Depth = 0;
            this.lblXValue.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblXValue.Location = new System.Drawing.Point(729, 294);
            this.lblXValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblXValue.Name = "lblXValue";
            this.lblXValue.Size = new System.Drawing.Size(11, 19);
            this.lblXValue.TabIndex = 29;
            this.lblXValue.Text = "X";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.Location = new System.Drawing.Point(729, 178);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(133, 19);
            this.lblTitle.TabIndex = 26;
            this.lblTitle.Text = "Posicionar modelo";
            // 
            // pnlMenu
            // 
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(337, 772);
            this.pnlMenu.TabIndex = 25;
            // 
            // cboxModels
            // 
            this.cboxModels.AutoResize = false;
            this.cboxModels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboxModels.Depth = 0;
            this.cboxModels.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboxModels.DropDownHeight = 174;
            this.cboxModels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxModels.DropDownWidth = 121;
            this.cboxModels.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboxModels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboxModels.FormattingEnabled = true;
            this.cboxModels.IntegralHeight = false;
            this.cboxModels.ItemHeight = 43;
            this.cboxModels.Location = new System.Drawing.Point(733, 206);
            this.cboxModels.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxModels.MaxDropDownItems = 4;
            this.cboxModels.MouseState = MaterialSkin.MouseState.OUT;
            this.cboxModels.Name = "cboxModels";
            this.cboxModels.Size = new System.Drawing.Size(336, 49);
            this.cboxModels.StartIndex = 0;
            this.cboxModels.TabIndex = 37;
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(733, 376);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(265, 16);
            this.lblmsg.TabIndex = 38;
            this.lblmsg.Text = "En caso de ser decimales, utilice una coma";
            // 
            // PositionElementScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.cboxModels);
            this.Controls.Add(this.txtZ);
            this.Controls.Add(this.lblZValue);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.lblYValue);
            this.Controls.Add(this.btnCloseTab);
            this.Controls.Add(this.btnSaveMaterial);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lblXValue);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PositionElementScreen";
            this.Size = new System.Drawing.Size(1584, 772);
            this.Load += new System.EventHandler(this.PositionElementScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtZ;
        private MaterialSkin.Controls.MaterialLabel lblZValue;
        private MaterialSkin.Controls.MaterialTextBox txtY;
        private MaterialSkin.Controls.MaterialLabel lblYValue;
        private MaterialSkin.Controls.MaterialButton btnCloseTab;
        private MaterialSkin.Controls.MaterialButton btnSaveMaterial;
        private MaterialSkin.Controls.MaterialTextBox txtX;
        private MaterialSkin.Controls.MaterialLabel lblXValue;
        private MaterialSkin.Controls.MaterialLabel lblTitle;
        private System.Windows.Forms.Panel pnlMenu;
        private MaterialSkin.Controls.MaterialComboBox cboxModels;
        private System.Windows.Forms.Label lblmsg;
    }
}
