namespace UI.Screens
{
    partial class EditSceneScreen
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
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.lblName = new MaterialSkin.Controls.MaterialLabel();
            this.lblLastModification = new MaterialSkin.Controls.MaterialLabel();
            this.lblLookFrom = new MaterialSkin.Controls.MaterialLabel();
            this.lblLookAt = new MaterialSkin.Controls.MaterialLabel();
            this.lblFov = new MaterialSkin.Controls.MaterialLabel();
            this.txtLookFrom = new MaterialSkin.Controls.MaterialTextBox();
            this.txtLookAt = new MaterialSkin.Controls.MaterialTextBox();
            this.txtFov = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pnlAvailableModels = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlPositionedModels = new System.Windows.Forms.FlowLayoutPanel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblLastRender = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.lblOutdatedRender = new MaterialSkin.Controls.MaterialLabel();
            this.btnRender = new MaterialSkin.Controls.MaterialButton();
            this.imgRender = new System.Windows.Forms.PictureBox();
            this.btnPlaceModel = new MaterialSkin.Controls.MaterialButton();
            this.btnUpdate = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDownload = new MaterialSkin.Controls.MaterialButton();
            this.btnPPM = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnJPG = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnPNG = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtAperture = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.chkBlur = new MaterialSkin.Controls.MaterialCheckbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgRender)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Location = new System.Drawing.Point(1, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(253, 627);
            this.pnlMenu.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(260, 6);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(96, 36);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Depth = 0;
            this.lblName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblName.Location = new System.Drawing.Point(373, 16);
            this.lblName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(1, 0);
            this.lblName.TabIndex = 12;
            // 
            // lblLastModification
            // 
            this.lblLastModification.AutoSize = true;
            this.lblLastModification.Depth = 0;
            this.lblLastModification.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLastModification.Location = new System.Drawing.Point(373, 40);
            this.lblLastModification.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLastModification.Name = "lblLastModification";
            this.lblLastModification.Size = new System.Drawing.Size(148, 19);
            this.lblLastModification.TabIndex = 13;
            this.lblLastModification.Text = "Última modificación:";
            // 
            // lblLookFrom
            // 
            this.lblLookFrom.AutoSize = true;
            this.lblLookFrom.Depth = 0;
            this.lblLookFrom.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLookFrom.Location = new System.Drawing.Point(275, 80);
            this.lblLookFrom.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLookFrom.Name = "lblLookFrom";
            this.lblLookFrom.Size = new System.Drawing.Size(73, 19);
            this.lblLookFrom.TabIndex = 14;
            this.lblLookFrom.Text = "LookFrom";
            // 
            // lblLookAt
            // 
            this.lblLookAt.AutoSize = true;
            this.lblLookAt.Depth = 0;
            this.lblLookAt.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLookAt.Location = new System.Drawing.Point(413, 80);
            this.lblLookAt.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLookAt.Name = "lblLookAt";
            this.lblLookAt.Size = new System.Drawing.Size(51, 19);
            this.lblLookAt.TabIndex = 15;
            this.lblLookAt.Text = "LookAt";
            // 
            // lblFov
            // 
            this.lblFov.AutoSize = true;
            this.lblFov.Depth = 0;
            this.lblFov.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFov.Location = new System.Drawing.Point(553, 80);
            this.lblFov.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFov.Name = "lblFov";
            this.lblFov.Size = new System.Drawing.Size(29, 19);
            this.lblFov.TabIndex = 16;
            this.lblFov.Text = "FoV";
            // 
            // txtLookFrom
            // 
            this.txtLookFrom.AnimateReadOnly = false;
            this.txtLookFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLookFrom.Depth = 0;
            this.txtLookFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLookFrom.LeadingIcon = null;
            this.txtLookFrom.Location = new System.Drawing.Point(278, 102);
            this.txtLookFrom.MaxLength = 50;
            this.txtLookFrom.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLookFrom.Multiline = false;
            this.txtLookFrom.Name = "txtLookFrom";
            this.txtLookFrom.Size = new System.Drawing.Size(111, 50);
            this.txtLookFrom.TabIndex = 17;
            this.txtLookFrom.Text = "4 2 8";
            this.txtLookFrom.TrailingIcon = null;
            // 
            // txtLookAt
            // 
            this.txtLookAt.AnimateReadOnly = false;
            this.txtLookAt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLookAt.Depth = 0;
            this.txtLookAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLookAt.LeadingIcon = null;
            this.txtLookAt.Location = new System.Drawing.Point(416, 102);
            this.txtLookAt.MaxLength = 50;
            this.txtLookAt.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLookAt.Multiline = false;
            this.txtLookAt.Name = "txtLookAt";
            this.txtLookAt.Size = new System.Drawing.Size(111, 50);
            this.txtLookAt.TabIndex = 18;
            this.txtLookAt.Text = "0 0.5 -2";
            this.txtLookAt.TrailingIcon = null;
            // 
            // txtFov
            // 
            this.txtFov.AnimateReadOnly = false;
            this.txtFov.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFov.Depth = 0;
            this.txtFov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFov.LeadingIcon = null;
            this.txtFov.Location = new System.Drawing.Point(556, 101);
            this.txtFov.MaxLength = 50;
            this.txtFov.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFov.Multiline = false;
            this.txtFov.Name = "txtFov";
            this.txtFov.Size = new System.Drawing.Size(111, 50);
            this.txtFov.TabIndex = 19;
            this.txtFov.Text = "40";
            this.txtFov.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(341, 249);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(147, 19);
            this.materialLabel1.TabIndex = 21;
            this.materialLabel1.Text = "Modelos disponibles";
            // 
            // pnlAvailableModels
            // 
            this.pnlAvailableModels.Location = new System.Drawing.Point(260, 271);
            this.pnlAvailableModels.Name = "pnlAvailableModels";
            this.pnlAvailableModels.Size = new System.Drawing.Size(300, 308);
            this.pnlAvailableModels.TabIndex = 22;
            // 
            // pnlPositionedModels
            // 
            this.pnlPositionedModels.Location = new System.Drawing.Point(885, 271);
            this.pnlPositionedModels.Name = "pnlPositionedModels";
            this.pnlPositionedModels.Size = new System.Drawing.Size(300, 353);
            this.pnlPositionedModels.TabIndex = 23;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(954, 249);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(161, 19);
            this.materialLabel2.TabIndex = 24;
            this.materialLabel2.Text = "Modelos posicionados";
            // 
            // lblLastRender
            // 
            this.lblLastRender.AutoSize = true;
            this.lblLastRender.Depth = 0;
            this.lblLastRender.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLastRender.Location = new System.Drawing.Point(577, 483);
            this.lblLastRender.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLastRender.Name = "lblLastRender";
            this.lblLastRender.Size = new System.Drawing.Size(138, 19);
            this.lblLastRender.TabIndex = 25;
            this.lblLastRender.Text = "Último renderizado:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(577, 239);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(52, 19);
            this.materialLabel4.TabIndex = 26;
            this.materialLabel4.Text = "Escena";
            // 
            // lblOutdatedRender
            // 
            this.lblOutdatedRender.AutoSize = true;
            this.lblOutdatedRender.Depth = 0;
            this.lblOutdatedRender.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblOutdatedRender.Location = new System.Drawing.Point(577, 513);
            this.lblOutdatedRender.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOutdatedRender.Name = "lblOutdatedRender";
            this.lblOutdatedRender.Size = new System.Drawing.Size(1, 0);
            this.lblOutdatedRender.TabIndex = 27;
            // 
            // btnRender
            // 
            this.btnRender.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRender.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRender.Depth = 0;
            this.btnRender.HighEmphasis = true;
            this.btnRender.Icon = null;
            this.btnRender.Location = new System.Drawing.Point(764, 229);
            this.btnRender.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRender.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRender.Name = "btnRender";
            this.btnRender.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRender.Size = new System.Drawing.Size(109, 36);
            this.btnRender.TabIndex = 28;
            this.btnRender.Text = "Renderizar";
            this.btnRender.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRender.UseAccentColor = false;
            this.btnRender.UseVisualStyleBackColor = true;
            this.btnRender.Click += new System.EventHandler(this.BtnRender_Click);
            // 
            // imgRender
            // 
            this.imgRender.Location = new System.Drawing.Point(573, 270);
            this.imgRender.Name = "imgRender";
            this.imgRender.Size = new System.Drawing.Size(300, 200);
            this.imgRender.TabIndex = 20;
            this.imgRender.TabStop = false;
            // 
            // btnPlaceModel
            // 
            this.btnPlaceModel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlaceModel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPlaceModel.Depth = 0;
            this.btnPlaceModel.HighEmphasis = true;
            this.btnPlaceModel.Icon = null;
            this.btnPlaceModel.Location = new System.Drawing.Point(313, 585);
            this.btnPlaceModel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPlaceModel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPlaceModel.Name = "btnPlaceModel";
            this.btnPlaceModel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPlaceModel.Size = new System.Drawing.Size(175, 36);
            this.btnPlaceModel.TabIndex = 29;
            this.btnPlaceModel.Text = "Colocar un modelo";
            this.btnPlaceModel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPlaceModel.UseAccentColor = false;
            this.btnPlaceModel.UseVisualStyleBackColor = true;
            this.btnPlaceModel.Click += new System.EventHandler(this.BtnPlaceModel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpdate.Depth = 0;
            this.btnUpdate.HighEmphasis = true;
            this.btnUpdate.Icon = null;
            this.btnUpdate.Location = new System.Drawing.Point(1030, 102);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpdate.Size = new System.Drawing.Size(154, 36);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Aceptar cambios";
            this.btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdate.UseAccentColor = false;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nota: Colocar los valores de LookFrom y LookAt de la forma x y z";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "En todo caso, de ser decimales, utilice una coma";
            // 
            // btnDownload
            // 
            this.btnDownload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDownload.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDownload.Depth = 0;
            this.btnDownload.HighEmphasis = true;
            this.btnDownload.Icon = null;
            this.btnDownload.Location = new System.Drawing.Point(764, 580);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDownload.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDownload.Size = new System.Drawing.Size(106, 36);
            this.btnDownload.TabIndex = 33;
            this.btnDownload.Text = "Descargar";
            this.btnDownload.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDownload.UseAccentColor = false;
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
            // 
            // btnPPM
            // 
            this.btnPPM.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnPPM.AutoSize = true;
            this.btnPPM.Depth = 0;
            this.btnPPM.Location = new System.Drawing.Point(580, 537);
            this.btnPPM.Margin = new System.Windows.Forms.Padding(0);
            this.btnPPM.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btnPPM.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPPM.Name = "btnPPM";
            this.btnPPM.Ripple = true;
            this.btnPPM.Size = new System.Drawing.Size(67, 37);
            this.btnPPM.TabIndex = 34;
            this.btnPPM.TabStop = true;
            this.btnPPM.Text = "ppm";
            this.btnPPM.UseVisualStyleBackColor = true;
            // 
            // btnJPG
            // 
            this.btnJPG.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnJPG.AutoSize = true;
            this.btnJPG.Depth = 0;
            this.btnJPG.Location = new System.Drawing.Point(672, 537);
            this.btnJPG.Margin = new System.Windows.Forms.Padding(0);
            this.btnJPG.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btnJPG.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnJPG.Name = "btnJPG";
            this.btnJPG.Ripple = true;
            this.btnJPG.Size = new System.Drawing.Size(57, 37);
            this.btnJPG.TabIndex = 35;
            this.btnJPG.TabStop = true;
            this.btnJPG.Text = "jpg";
            this.btnJPG.UseVisualStyleBackColor = true;
            // 
            // btnPNG
            // 
            this.btnPNG.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnPNG.AutoSize = true;
            this.btnPNG.Depth = 0;
            this.btnPNG.Location = new System.Drawing.Point(764, 537);
            this.btnPNG.Margin = new System.Windows.Forms.Padding(0);
            this.btnPNG.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btnPNG.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPNG.Name = "btnPNG";
            this.btnPNG.Ripple = true;
            this.btnPNG.Size = new System.Drawing.Size(62, 37);
            this.btnPNG.TabIndex = 36;
            this.btnPNG.TabStop = true;
            this.btnPNG.Text = "png";
            this.btnPNG.UseVisualStyleBackColor = true;
            // 
            // txtAperture
            // 
            this.txtAperture.AnimateReadOnly = false;
            this.txtAperture.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAperture.Depth = 0;
            this.txtAperture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAperture.LeadingIcon = null;
            this.txtAperture.Location = new System.Drawing.Point(727, 101);
            this.txtAperture.MaxLength = 50;
            this.txtAperture.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAperture.Multiline = false;
            this.txtAperture.Name = "txtAperture";
            this.txtAperture.Size = new System.Drawing.Size(111, 50);
            this.txtAperture.TabIndex = 38;
            this.txtAperture.Text = "1,5";
            this.txtAperture.TrailingIcon = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(724, 80);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(61, 19);
            this.materialLabel3.TabIndex = 37;
            this.materialLabel3.Text = "Apertura";
            // 
            // chkBlur
            // 
            this.chkBlur.AutoSize = true;
            this.chkBlur.Depth = 0;
            this.chkBlur.Location = new System.Drawing.Point(841, 103);
            this.chkBlur.Margin = new System.Windows.Forms.Padding(0);
            this.chkBlur.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkBlur.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkBlur.Name = "chkBlur";
            this.chkBlur.ReadOnly = false;
            this.chkBlur.Ripple = true;
            this.chkBlur.Size = new System.Drawing.Size(171, 37);
            this.chkBlur.TabIndex = 39;
            this.chkBlur.Text = "Activar desenfoque";
            this.chkBlur.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(724, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "La apertura debe tener precisión decimal de 1 dígito";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(724, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Si introduce más de un dígito tras la coma, se redondeará";
            // 
            // EditSceneScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkBlur);
            this.Controls.Add(this.txtAperture);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.btnPNG);
            this.Controls.Add(this.btnJPG);
            this.Controls.Add(this.btnPPM);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnPlaceModel);
            this.Controls.Add(this.btnRender);
            this.Controls.Add(this.lblOutdatedRender);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.lblLastRender);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.pnlPositionedModels);
            this.Controls.Add(this.pnlAvailableModels);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.imgRender);
            this.Controls.Add(this.txtFov);
            this.Controls.Add(this.txtLookAt);
            this.Controls.Add(this.txtLookFrom);
            this.Controls.Add(this.lblFov);
            this.Controls.Add(this.lblLookAt);
            this.Controls.Add(this.lblLookFrom);
            this.Controls.Add(this.lblLastModification);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlMenu);
            this.Name = "EditSceneScreen";
            this.Size = new System.Drawing.Size(1188, 627);
            ((System.ComponentModel.ISupportInitialize)(this.imgRender)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlMenu;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialLabel lblName;
        private MaterialSkin.Controls.MaterialLabel lblLastModification;
        private MaterialSkin.Controls.MaterialLabel lblLookFrom;
        private MaterialSkin.Controls.MaterialLabel lblLookAt;
        private MaterialSkin.Controls.MaterialLabel lblFov;
        private MaterialSkin.Controls.MaterialTextBox txtLookFrom;
        private MaterialSkin.Controls.MaterialTextBox txtLookAt;
        private MaterialSkin.Controls.MaterialTextBox txtFov;
        private System.Windows.Forms.PictureBox imgRender;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.FlowLayoutPanel pnlAvailableModels;
        private System.Windows.Forms.FlowLayoutPanel pnlPositionedModels;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel lblLastRender;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel lblOutdatedRender;
        private MaterialSkin.Controls.MaterialButton btnRender;
        private MaterialSkin.Controls.MaterialButton btnPlaceModel;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialButton btnDownload;
        private MaterialSkin.Controls.MaterialRadioButton btnPPM;
        private MaterialSkin.Controls.MaterialRadioButton btnJPG;
        private MaterialSkin.Controls.MaterialRadioButton btnPNG;
        private MaterialSkin.Controls.MaterialTextBox txtAperture;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialCheckbox chkBlur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
