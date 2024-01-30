namespace Views.Lists
{
    partial class FrmStockDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.lblOriginDestinyTitle = new System.Windows.Forms.Label();
            this.lblTypeTitle = new System.Windows.Forms.Label();
            this.lblDateTitle = new System.Windows.Forms.Label();
            this.grbElement = new System.Windows.Forms.GroupBox();
            this.txtObservations = new System.Windows.Forms.TextBox();
            this.lblObservations = new System.Windows.Forms.Label();
            this.lblRemitTitle = new System.Windows.Forms.Label();
            this.lblBarCodeTitle = new System.Windows.Forms.Label();
            this.lblLotTitle = new System.Windows.Forms.Label();
            this.lblElementTitle = new System.Windows.Forms.Label();
            this.lblQuantityTitle = new System.Windows.Forms.Label();
            this.lblExpirationTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblOriginDestiny = new System.Windows.Forms.Label();
            this.lblBarCode = new System.Windows.Forms.Label();
            this.lblElement = new System.Windows.Forms.Label();
            this.lblLot = new System.Windows.Forms.Label();
            this.lblExpiration = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblRemit = new System.Windows.Forms.Label();
            this.grbElement.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(394, 390);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Salir";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(12, 390);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 24;
            this.btnModify.Text = "Modificar";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // lblOriginDestinyTitle
            // 
            this.lblOriginDestinyTitle.AutoSize = true;
            this.lblOriginDestinyTitle.Location = new System.Drawing.Point(137, 101);
            this.lblOriginDestinyTitle.Name = "lblOriginDestinyTitle";
            this.lblOriginDestinyTitle.Size = new System.Drawing.Size(64, 13);
            this.lblOriginDestinyTitle.TabIndex = 28;
            this.lblOriginDestinyTitle.Text = "lblOriginTitle";
            // 
            // lblTypeTitle
            // 
            this.lblTypeTitle.AutoSize = true;
            this.lblTypeTitle.Location = new System.Drawing.Point(170, 46);
            this.lblTypeTitle.Name = "lblTypeTitle";
            this.lblTypeTitle.Size = new System.Drawing.Size(31, 13);
            this.lblTypeTitle.TabIndex = 27;
            this.lblTypeTitle.Text = "Tipo:";
            // 
            // lblDateTitle
            // 
            this.lblDateTitle.AutoSize = true;
            this.lblDateTitle.Location = new System.Drawing.Point(161, 73);
            this.lblDateTitle.Name = "lblDateTitle";
            this.lblDateTitle.Size = new System.Drawing.Size(40, 13);
            this.lblDateTitle.TabIndex = 21;
            this.lblDateTitle.Text = "Fecha:";
            // 
            // grbElement
            // 
            this.grbElement.Controls.Add(this.lblRemit);
            this.grbElement.Controls.Add(this.lblQuantity);
            this.grbElement.Controls.Add(this.lblExpiration);
            this.grbElement.Controls.Add(this.lblLot);
            this.grbElement.Controls.Add(this.lblElement);
            this.grbElement.Controls.Add(this.lblBarCode);
            this.grbElement.Controls.Add(this.txtObservations);
            this.grbElement.Controls.Add(this.lblObservations);
            this.grbElement.Controls.Add(this.lblRemitTitle);
            this.grbElement.Controls.Add(this.lblBarCodeTitle);
            this.grbElement.Controls.Add(this.lblLotTitle);
            this.grbElement.Controls.Add(this.lblElementTitle);
            this.grbElement.Controls.Add(this.lblQuantityTitle);
            this.grbElement.Controls.Add(this.lblExpirationTitle);
            this.grbElement.Location = new System.Drawing.Point(12, 129);
            this.grbElement.Name = "grbElement";
            this.grbElement.Size = new System.Drawing.Size(457, 255);
            this.grbElement.TabIndex = 23;
            this.grbElement.TabStop = false;
            this.grbElement.Text = "Elemento";
            // 
            // txtObservations
            // 
            this.txtObservations.Enabled = false;
            this.txtObservations.Location = new System.Drawing.Point(6, 194);
            this.txtObservations.Multiline = true;
            this.txtObservations.Name = "txtObservations";
            this.txtObservations.Size = new System.Drawing.Size(445, 51);
            this.txtObservations.TabIndex = 13;
            // 
            // lblObservations
            // 
            this.lblObservations.AutoSize = true;
            this.lblObservations.Location = new System.Drawing.Point(189, 178);
            this.lblObservations.Name = "lblObservations";
            this.lblObservations.Size = new System.Drawing.Size(78, 13);
            this.lblObservations.TabIndex = 12;
            this.lblObservations.Text = "Observaciones";
            // 
            // lblRemitTitle
            // 
            this.lblRemitTitle.AutoSize = true;
            this.lblRemitTitle.Location = new System.Drawing.Point(65, 132);
            this.lblRemitTitle.Name = "lblRemitTitle";
            this.lblRemitTitle.Size = new System.Drawing.Size(43, 13);
            this.lblRemitTitle.TabIndex = 9;
            this.lblRemitTitle.Text = "Remito:";
            // 
            // lblBarCodeTitle
            // 
            this.lblBarCodeTitle.AutoSize = true;
            this.lblBarCodeTitle.Location = new System.Drawing.Point(65, 16);
            this.lblBarCodeTitle.Name = "lblBarCodeTitle";
            this.lblBarCodeTitle.Size = new System.Drawing.Size(43, 13);
            this.lblBarCodeTitle.TabIndex = 7;
            this.lblBarCodeTitle.Text = "Codigo:";
            // 
            // lblLotTitle
            // 
            this.lblLotTitle.AutoSize = true;
            this.lblLotTitle.Location = new System.Drawing.Point(77, 74);
            this.lblLotTitle.Name = "lblLotTitle";
            this.lblLotTitle.Size = new System.Drawing.Size(31, 13);
            this.lblLotTitle.TabIndex = 4;
            this.lblLotTitle.Text = "Lote:";
            // 
            // lblElementTitle
            // 
            this.lblElementTitle.AutoSize = true;
            this.lblElementTitle.Location = new System.Drawing.Point(54, 45);
            this.lblElementTitle.Name = "lblElementTitle";
            this.lblElementTitle.Size = new System.Drawing.Size(54, 13);
            this.lblElementTitle.TabIndex = 2;
            this.lblElementTitle.Text = "Elemento:";
            // 
            // lblQuantityTitle
            // 
            this.lblQuantityTitle.AutoSize = true;
            this.lblQuantityTitle.Location = new System.Drawing.Point(55, 161);
            this.lblQuantityTitle.Name = "lblQuantityTitle";
            this.lblQuantityTitle.Size = new System.Drawing.Size(52, 13);
            this.lblQuantityTitle.TabIndex = 3;
            this.lblQuantityTitle.Text = "Cantidad:";
            // 
            // lblExpirationTitle
            // 
            this.lblExpirationTitle.AutoSize = true;
            this.lblExpirationTitle.Location = new System.Drawing.Point(40, 103);
            this.lblExpirationTitle.Name = "lblExpirationTitle";
            this.lblExpirationTitle.Size = new System.Drawing.Size(68, 13);
            this.lblExpirationTitle.TabIndex = 5;
            this.lblExpirationTitle.Text = "Vencimiento:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(109, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(235, 25);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "DETALLE DE STOCK";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(216, 46);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(41, 13);
            this.lblType.TabIndex = 29;
            this.lblType.Text = "lblType";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(216, 73);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(40, 13);
            this.lblDate.TabIndex = 30;
            this.lblDate.Text = "lblDate";
            // 
            // lblOriginDestiny
            // 
            this.lblOriginDestiny.AutoSize = true;
            this.lblOriginDestiny.Location = new System.Drawing.Point(216, 101);
            this.lblOriginDestiny.Name = "lblOriginDestiny";
            this.lblOriginDestiny.Size = new System.Drawing.Size(79, 13);
            this.lblOriginDestiny.TabIndex = 31;
            this.lblOriginDestiny.Text = "lblOriginDestiny";
            // 
            // lblBarCode
            // 
            this.lblBarCode.AutoSize = true;
            this.lblBarCode.Location = new System.Drawing.Point(114, 16);
            this.lblBarCode.Name = "lblBarCode";
            this.lblBarCode.Size = new System.Drawing.Size(58, 13);
            this.lblBarCode.TabIndex = 14;
            this.lblBarCode.Text = "lblBarCode";
            // 
            // lblElement
            // 
            this.lblElement.AutoSize = true;
            this.lblElement.Location = new System.Drawing.Point(114, 45);
            this.lblElement.Name = "lblElement";
            this.lblElement.Size = new System.Drawing.Size(55, 13);
            this.lblElement.TabIndex = 15;
            this.lblElement.Text = "lblElement";
            // 
            // lblLot
            // 
            this.lblLot.AutoSize = true;
            this.lblLot.Location = new System.Drawing.Point(114, 74);
            this.lblLot.Name = "lblLot";
            this.lblLot.Size = new System.Drawing.Size(28, 13);
            this.lblLot.TabIndex = 16;
            this.lblLot.Text = "Lote";
            // 
            // lblExpiration
            // 
            this.lblExpiration.AutoSize = true;
            this.lblExpiration.Location = new System.Drawing.Point(114, 103);
            this.lblExpiration.Name = "lblExpiration";
            this.lblExpiration.Size = new System.Drawing.Size(63, 13);
            this.lblExpiration.TabIndex = 17;
            this.lblExpiration.Text = "lblExpiration";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(113, 161);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(56, 13);
            this.lblQuantity.TabIndex = 18;
            this.lblQuantity.Text = "lblQuantity";
            // 
            // lblRemit
            // 
            this.lblRemit.AutoSize = true;
            this.lblRemit.Location = new System.Drawing.Point(114, 132);
            this.lblRemit.Name = "lblRemit";
            this.lblRemit.Size = new System.Drawing.Size(44, 13);
            this.lblRemit.TabIndex = 19;
            this.lblRemit.Text = "lblRemit";
            // 
            // FrmStockDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 421);
            this.Controls.Add(this.lblOriginDestiny);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.lblOriginDestinyTitle);
            this.Controls.Add(this.lblTypeTitle);
            this.Controls.Add(this.lblDateTitle);
            this.Controls.Add(this.grbElement);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmStockDetail";
            this.Text = "Detalle de Stock";
            this.Load += new System.EventHandler(this.FrmStockDetail_Load);
            this.grbElement.ResumeLayout(false);
            this.grbElement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label lblOriginDestinyTitle;
        private System.Windows.Forms.Label lblTypeTitle;
        private System.Windows.Forms.Label lblDateTitle;
        private System.Windows.Forms.GroupBox grbElement;
        private System.Windows.Forms.TextBox txtObservations;
        private System.Windows.Forms.Label lblObservations;
        private System.Windows.Forms.Label lblRemitTitle;
        private System.Windows.Forms.Label lblBarCodeTitle;
        private System.Windows.Forms.Label lblLotTitle;
        private System.Windows.Forms.Label lblElementTitle;
        private System.Windows.Forms.Label lblQuantityTitle;
        private System.Windows.Forms.Label lblExpirationTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblOriginDestiny;
        private System.Windows.Forms.Label lblElement;
        private System.Windows.Forms.Label lblBarCode;
        private System.Windows.Forms.Label lblLot;
        private System.Windows.Forms.Label lblExpiration;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblRemit;
    }
}