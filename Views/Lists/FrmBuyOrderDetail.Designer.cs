namespace Views.Lists
{
    partial class FrmBuyOrderDetail
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
            this.lblRequestDateTitle = new System.Windows.Forms.Label();
            this.lblRequestedByTitle = new System.Windows.Forms.Label();
            this.lblToUseInTitle = new System.Windows.Forms.Label();
            this.lblDestinyTitle = new System.Windows.Forms.Label();
            this.lblCityTitle = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grdBuyOrder = new System.Windows.Forms.DataGridView();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblRequestDate = new System.Windows.Forms.Label();
            this.lblDestiny = new System.Windows.Forms.Label();
            this.lblToUseIn = new System.Windows.Forms.Label();
            this.lblRequestedBy = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.lblAuthorized = new System.Windows.Forms.Label();
            this.lblAuthorizedTitle = new System.Windows.Forms.Label();
            this.lblAuthorizedBy = new System.Windows.Forms.Label();
            this.lblAuthorizedByTitle = new System.Windows.Forms.Label();
            this.lblAuthorizationDate = new System.Windows.Forms.Label();
            this.lblAuthorizationDateTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.grbAuthorization = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdBuyOrder)).BeginInit();
            this.grbAuthorization.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRequestDateTitle
            // 
            this.lblRequestDateTitle.AutoSize = true;
            this.lblRequestDateTitle.Location = new System.Drawing.Point(14, 146);
            this.lblRequestDateTitle.Name = "lblRequestDateTitle";
            this.lblRequestDateTitle.Size = new System.Drawing.Size(45, 13);
            this.lblRequestDateTitle.TabIndex = 51;
            this.lblRequestDateTitle.Text = "FECHA:";
            // 
            // lblRequestedByTitle
            // 
            this.lblRequestedByTitle.AutoSize = true;
            this.lblRequestedByTitle.Location = new System.Drawing.Point(14, 172);
            this.lblRequestedByTitle.Name = "lblRequestedByTitle";
            this.lblRequestedByTitle.Size = new System.Drawing.Size(110, 13);
            this.lblRequestedByTitle.TabIndex = 50;
            this.lblRequestedByTitle.Text = "SOLICITADOS  POR:";
            // 
            // lblToUseInTitle
            // 
            this.lblToUseInTitle.AutoSize = true;
            this.lblToUseInTitle.Location = new System.Drawing.Point(14, 120);
            this.lblToUseInTitle.Name = "lblToUseInTitle";
            this.lblToUseInTitle.Size = new System.Drawing.Size(112, 13);
            this.lblToUseInTitle.TabIndex = 49;
            this.lblToUseInTitle.Text = "PARA UTILIZAR EN: ";
            // 
            // lblDestinyTitle
            // 
            this.lblDestinyTitle.AutoSize = true;
            this.lblDestinyTitle.Location = new System.Drawing.Point(14, 94);
            this.lblDestinyTitle.Name = "lblDestinyTitle";
            this.lblDestinyTitle.Size = new System.Drawing.Size(154, 13);
            this.lblDestinyTitle.TabIndex = 48;
            this.lblDestinyTitle.Text = "ARTICULOS DESTINADOS A:";
            // 
            // lblCityTitle
            // 
            this.lblCityTitle.AutoSize = true;
            this.lblCityTitle.Location = new System.Drawing.Point(14, 68);
            this.lblCityTitle.Name = "lblCityTitle";
            this.lblCityTitle.Size = new System.Drawing.Size(47, 13);
            this.lblCityTitle.TabIndex = 47;
            this.lblCityTitle.Text = "LUGAR:";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(20, 542);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(106, 23);
            this.btnPrint.TabIndex = 45;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(564, 542);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 44;
            this.btnQuit.Text = "Volver";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(199, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(229, 25);
            this.lblTitle.TabIndex = 43;
            this.lblTitle.Text = "Orden de Compra N°";
            // 
            // grdBuyOrder
            // 
            this.grdBuyOrder.AllowUserToAddRows = false;
            this.grdBuyOrder.AllowUserToDeleteRows = false;
            this.grdBuyOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBuyOrder.Location = new System.Drawing.Point(12, 195);
            this.grdBuyOrder.Name = "grdBuyOrder";
            this.grdBuyOrder.Size = new System.Drawing.Size(627, 341);
            this.grdBuyOrder.TabIndex = 41;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(62, 67);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(34, 13);
            this.lblCity.TabIndex = 52;
            this.lblCity.Text = "lblCity";
            // 
            // lblRequestDate
            // 
            this.lblRequestDate.AutoSize = true;
            this.lblRequestDate.Location = new System.Drawing.Point(64, 146);
            this.lblRequestDate.Name = "lblRequestDate";
            this.lblRequestDate.Size = new System.Drawing.Size(80, 13);
            this.lblRequestDate.TabIndex = 53;
            this.lblRequestDate.Text = "lblRequestDate";
            // 
            // lblDestiny
            // 
            this.lblDestiny.AutoSize = true;
            this.lblDestiny.Location = new System.Drawing.Point(169, 94);
            this.lblDestiny.Name = "lblDestiny";
            this.lblDestiny.Size = new System.Drawing.Size(52, 13);
            this.lblDestiny.TabIndex = 54;
            this.lblDestiny.Text = "lblDestiny";
            // 
            // lblToUseIn
            // 
            this.lblToUseIn.AutoSize = true;
            this.lblToUseIn.Location = new System.Drawing.Point(123, 120);
            this.lblToUseIn.Name = "lblToUseIn";
            this.lblToUseIn.Size = new System.Drawing.Size(58, 13);
            this.lblToUseIn.TabIndex = 55;
            this.lblToUseIn.Text = "lblToUseIn";
            // 
            // lblRequestedBy
            // 
            this.lblRequestedBy.AutoSize = true;
            this.lblRequestedBy.Location = new System.Drawing.Point(126, 172);
            this.lblRequestedBy.Name = "lblRequestedBy";
            this.lblRequestedBy.Size = new System.Drawing.Size(81, 13);
            this.lblRequestedBy.TabIndex = 56;
            this.lblRequestedBy.Text = "lblRequestedBy";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(146, 542);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 57;
            this.btnModify.Text = "Modificar";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // lblAuthorized
            // 
            this.lblAuthorized.AutoSize = true;
            this.lblAuthorized.Location = new System.Drawing.Point(95, 56);
            this.lblAuthorized.Name = "lblAuthorized";
            this.lblAuthorized.Size = new System.Drawing.Size(67, 13);
            this.lblAuthorized.TabIndex = 59;
            this.lblAuthorized.Text = "lblAuthorized";
            // 
            // lblAuthorizedTitle
            // 
            this.lblAuthorizedTitle.AutoSize = true;
            this.lblAuthorizedTitle.Location = new System.Drawing.Point(42, 56);
            this.lblAuthorizedTitle.Name = "lblAuthorizedTitle";
            this.lblAuthorizedTitle.Size = new System.Drawing.Size(54, 13);
            this.lblAuthorizedTitle.TabIndex = 58;
            this.lblAuthorizedTitle.Text = "ESTADO:";
            // 
            // lblAuthorizedBy
            // 
            this.lblAuthorizedBy.AutoSize = true;
            this.lblAuthorizedBy.Location = new System.Drawing.Point(137, 24);
            this.lblAuthorizedBy.Name = "lblAuthorizedBy";
            this.lblAuthorizedBy.Size = new System.Drawing.Size(79, 13);
            this.lblAuthorizedBy.TabIndex = 61;
            this.lblAuthorizedBy.Text = "lblAuthorizedBy";
            // 
            // lblAuthorizedByTitle
            // 
            this.lblAuthorizedByTitle.AutoSize = true;
            this.lblAuthorizedByTitle.Location = new System.Drawing.Point(42, 24);
            this.lblAuthorizedByTitle.Name = "lblAuthorizedByTitle";
            this.lblAuthorizedByTitle.Size = new System.Drawing.Size(91, 13);
            this.lblAuthorizedByTitle.TabIndex = 60;
            this.lblAuthorizedByTitle.Text = "REVISADO POR:";
            // 
            // lblAuthorizationDate
            // 
            this.lblAuthorizationDate.AutoSize = true;
            this.lblAuthorizationDate.Location = new System.Drawing.Point(159, 88);
            this.lblAuthorizationDate.Name = "lblAuthorizationDate";
            this.lblAuthorizationDate.Size = new System.Drawing.Size(101, 13);
            this.lblAuthorizationDate.TabIndex = 63;
            this.lblAuthorizationDate.Text = "lblAuthorizationDate";
            // 
            // lblAuthorizationDateTitle
            // 
            this.lblAuthorizationDateTitle.AutoSize = true;
            this.lblAuthorizationDateTitle.Location = new System.Drawing.Point(42, 88);
            this.lblAuthorizationDateTitle.Name = "lblAuthorizationDateTitle";
            this.lblAuthorizationDateTitle.Size = new System.Drawing.Size(117, 13);
            this.lblAuthorizationDateTitle.TabIndex = 62;
            this.lblAuthorizationDateTitle.Text = "FECHA DE REVISION:";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Location = new System.Drawing.Point(280, 43);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(56, 13);
            this.lblSubTitle.TabIndex = 64;
            this.lblSubTitle.Text = "lblSubTitle";
            // 
            // grbAuthorization
            // 
            this.grbAuthorization.Controls.Add(this.lblAuthorizationDate);
            this.grbAuthorization.Controls.Add(this.lblAuthorizationDateTitle);
            this.grbAuthorization.Controls.Add(this.lblAuthorizedBy);
            this.grbAuthorization.Controls.Add(this.lblAuthorized);
            this.grbAuthorization.Controls.Add(this.lblAuthorizedByTitle);
            this.grbAuthorization.Controls.Add(this.lblAuthorizedTitle);
            this.grbAuthorization.Location = new System.Drawing.Point(336, 67);
            this.grbAuthorization.Name = "grbAuthorization";
            this.grbAuthorization.Size = new System.Drawing.Size(303, 110);
            this.grbAuthorization.TabIndex = 65;
            this.grbAuthorization.TabStop = false;
            this.grbAuthorization.Text = "Autorización";
            // 
            // FrmBuyOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 574);
            this.Controls.Add(this.grbAuthorization);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.lblRequestedBy);
            this.Controls.Add(this.lblToUseIn);
            this.Controls.Add(this.lblDestiny);
            this.Controls.Add(this.lblRequestDate);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblRequestDateTitle);
            this.Controls.Add(this.lblRequestedByTitle);
            this.Controls.Add(this.lblToUseInTitle);
            this.Controls.Add(this.lblDestinyTitle);
            this.Controls.Add(this.lblCityTitle);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grdBuyOrder);
            this.Name = "FrmBuyOrderDetail";
            this.Text = "Detalle de Orden de Compra";
            this.Load += new System.EventHandler(this.FrmBuyOrderDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBuyOrder)).EndInit();
            this.grbAuthorization.ResumeLayout(false);
            this.grbAuthorization.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRequestDateTitle;
        private System.Windows.Forms.Label lblRequestedByTitle;
        private System.Windows.Forms.Label lblToUseInTitle;
        private System.Windows.Forms.Label lblDestinyTitle;
        private System.Windows.Forms.Label lblCityTitle;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView grdBuyOrder;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblRequestDate;
        private System.Windows.Forms.Label lblDestiny;
        private System.Windows.Forms.Label lblToUseIn;
        private System.Windows.Forms.Label lblRequestedBy;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label lblAuthorized;
        private System.Windows.Forms.Label lblAuthorizedTitle;
        private System.Windows.Forms.Label lblAuthorizedBy;
        private System.Windows.Forms.Label lblAuthorizedByTitle;
        private System.Windows.Forms.Label lblAuthorizationDate;
        private System.Windows.Forms.Label lblAuthorizationDateTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.GroupBox grbAuthorization;
    }
}