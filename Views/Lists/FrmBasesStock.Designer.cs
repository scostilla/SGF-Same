namespace Views.Lists
{
    partial class FrmBasesStock
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
            this.btnClean = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.chkAllElements = new System.Windows.Forms.CheckBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbBase = new System.Windows.Forms.ComboBox();
            this.cmbElement = new System.Windows.Forms.ComboBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblElement = new System.Windows.Forms.Label();
            this.grdStock = new System.Windows.Forms.DataGridView();
            this.btnElementModels = new System.Windows.Forms.Button();
            this.btnBuyOrder = new System.Windows.Forms.Button();
            this.dtpUntil = new System.Windows.Forms.DateTimePicker();
            this.dtpSince = new System.Windows.Forms.DateTimePicker();
            this.lblUntill = new System.Windows.Forms.Label();
            this.lblSince = new System.Windows.Forms.Label();
            this.btnTrace = new System.Windows.Forms.Button();
            this.grpHistory = new System.Windows.Forms.GroupBox();
            this.btnExpiredElements = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdStock)).BeginInit();
            this.grpHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(459, 85);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(99, 23);
            this.btnClean.TabIndex = 5;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(1035, 480);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "Salir";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // chkAllElements
            // 
            this.chkAllElements.AutoSize = true;
            this.chkAllElements.Location = new System.Drawing.Point(335, 50);
            this.chkAllElements.Name = "chkAllElements";
            this.chkAllElements.Size = new System.Drawing.Size(124, 17);
            this.chkAllElements.TabIndex = 1;
            this.chkAllElements.Text = "Todos los Elementos";
            this.chkAllElements.UseVisualStyleBackColor = true;
            this.chkAllElements.CheckStateChanged += new System.EventHandler(this.chkAllElementsChange);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(459, 48);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(99, 23);
            this.btnProcess.TabIndex = 3;
            this.btnProcess.Text = "Procesar";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(474, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(176, 25);
            this.lblTitle.TabIndex = 25;
            this.lblTitle.Text = "Stock en Bases";
            // 
            // cmbBase
            // 
            this.cmbBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBase.FormattingEnabled = true;
            this.cmbBase.Location = new System.Drawing.Point(65, 84);
            this.cmbBase.Name = "cmbBase";
            this.cmbBase.Size = new System.Drawing.Size(264, 21);
            this.cmbBase.TabIndex = 2;
            // 
            // cmbElement
            // 
            this.cmbElement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbElement.FormattingEnabled = true;
            this.cmbElement.Location = new System.Drawing.Point(65, 48);
            this.cmbElement.Name = "cmbElement";
            this.cmbElement.Size = new System.Drawing.Size(264, 21);
            this.cmbElement.TabIndex = 0;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(28, 88);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(31, 13);
            this.lblBase.TabIndex = 20;
            this.lblBase.Text = "Base";
            // 
            // lblElement
            // 
            this.lblElement.AutoSize = true;
            this.lblElement.Location = new System.Drawing.Point(8, 52);
            this.lblElement.Name = "lblElement";
            this.lblElement.Size = new System.Drawing.Size(51, 13);
            this.lblElement.TabIndex = 17;
            this.lblElement.Text = "Elemento";
            // 
            // grdStock
            // 
            this.grdStock.AllowUserToAddRows = false;
            this.grdStock.AllowUserToDeleteRows = false;
            this.grdStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStock.Location = new System.Drawing.Point(12, 126);
            this.grdStock.Name = "grdStock";
            this.grdStock.ReadOnly = true;
            this.grdStock.Size = new System.Drawing.Size(1098, 348);
            this.grdStock.TabIndex = 31;
            // 
            // btnElementModels
            // 
            this.btnElementModels.Location = new System.Drawing.Point(577, 48);
            this.btnElementModels.Name = "btnElementModels";
            this.btnElementModels.Size = new System.Drawing.Size(117, 60);
            this.btnElementModels.TabIndex = 4;
            this.btnElementModels.Text = "Agrupado por tipo de Elemento";
            this.btnElementModels.UseVisualStyleBackColor = true;
            this.btnElementModels.Click += new System.EventHandler(this.btnElementModels_Click);
            // 
            // btnBuyOrder
            // 
            this.btnBuyOrder.Location = new System.Drawing.Point(12, 480);
            this.btnBuyOrder.Name = "btnBuyOrder";
            this.btnBuyOrder.Size = new System.Drawing.Size(114, 23);
            this.btnBuyOrder.TabIndex = 6;
            this.btnBuyOrder.Text = "Orden de Compra";
            this.btnBuyOrder.UseVisualStyleBackColor = true;
            this.btnBuyOrder.Click += new System.EventHandler(this.btnBuyOrder_Click);
            // 
            // dtpUntil
            // 
            this.dtpUntil.Location = new System.Drawing.Point(59, 53);
            this.dtpUntil.Name = "dtpUntil";
            this.dtpUntil.Size = new System.Drawing.Size(126, 20);
            this.dtpUntil.TabIndex = 34;
            // 
            // dtpSince
            // 
            this.dtpSince.Location = new System.Drawing.Point(59, 27);
            this.dtpSince.Name = "dtpSince";
            this.dtpSince.Size = new System.Drawing.Size(126, 20);
            this.dtpSince.TabIndex = 33;
            // 
            // lblUntill
            // 
            this.lblUntill.AutoSize = true;
            this.lblUntill.Location = new System.Drawing.Point(15, 57);
            this.lblUntill.Name = "lblUntill";
            this.lblUntill.Size = new System.Drawing.Size(35, 13);
            this.lblUntill.TabIndex = 36;
            this.lblUntill.Text = "Hasta";
            // 
            // lblSince
            // 
            this.lblSince.AutoSize = true;
            this.lblSince.Location = new System.Drawing.Point(12, 31);
            this.lblSince.Name = "lblSince";
            this.lblSince.Size = new System.Drawing.Size(38, 13);
            this.lblSince.TabIndex = 35;
            this.lblSince.Text = "Desde";
            // 
            // btnTrace
            // 
            this.btnTrace.Location = new System.Drawing.Point(205, 23);
            this.btnTrace.Name = "btnTrace";
            this.btnTrace.Size = new System.Drawing.Size(117, 60);
            this.btnTrace.TabIndex = 37;
            this.btnTrace.Text = "Trazabilidad";
            this.btnTrace.UseVisualStyleBackColor = true;
            this.btnTrace.Click += new System.EventHandler(this.btnTrace_Click);
            // 
            // grpHistory
            // 
            this.grpHistory.Controls.Add(this.btnTrace);
            this.grpHistory.Controls.Add(this.dtpUntil);
            this.grpHistory.Controls.Add(this.dtpSince);
            this.grpHistory.Controls.Add(this.lblUntill);
            this.grpHistory.Controls.Add(this.lblSince);
            this.grpHistory.Location = new System.Drawing.Point(770, 28);
            this.grpHistory.Name = "grpHistory";
            this.grpHistory.Size = new System.Drawing.Size(340, 92);
            this.grpHistory.TabIndex = 38;
            this.grpHistory.TabStop = false;
            this.grpHistory.Text = "Historial";
            // 
            // btnExpiredElements
            // 
            this.btnExpiredElements.Location = new System.Drawing.Point(132, 480);
            this.btnExpiredElements.Name = "btnExpiredElements";
            this.btnExpiredElements.Size = new System.Drawing.Size(114, 23);
            this.btnExpiredElements.TabIndex = 39;
            this.btnExpiredElements.Text = "Elementos Vencidos";
            this.btnExpiredElements.UseVisualStyleBackColor = true;
            this.btnExpiredElements.Click += new System.EventHandler(this.btnExpiredElements_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(252, 480);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(114, 23);
            this.btnReport.TabIndex = 40;
            this.btnReport.Text = "Reporte";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.lblReport_Click);
            // 
            // FrmBasesStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 515);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnExpiredElements);
            this.Controls.Add(this.grpHistory);
            this.Controls.Add(this.btnBuyOrder);
            this.Controls.Add(this.btnElementModels);
            this.Controls.Add(this.grdStock);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.chkAllElements);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cmbBase);
            this.Controls.Add(this.cmbElement);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblElement);
            this.Name = "FrmBasesStock";
            this.Text = "Stock por Bases";
            this.Load += new System.EventHandler(this.FrmBasesStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdStock)).EndInit();
            this.grpHistory.ResumeLayout(false);
            this.grpHistory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.CheckBox chkAllElements;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbBase;
        private System.Windows.Forms.ComboBox cmbElement;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblElement;
        private System.Windows.Forms.DataGridView grdStock;
        private System.Windows.Forms.Button btnElementModels;
        private System.Windows.Forms.Button btnBuyOrder;
        private System.Windows.Forms.DateTimePicker dtpUntil;
        private System.Windows.Forms.DateTimePicker dtpSince;
        private System.Windows.Forms.Label lblUntill;
        private System.Windows.Forms.Label lblSince;
        private System.Windows.Forms.Button btnTrace;
        private System.Windows.Forms.GroupBox grpHistory;
        private System.Windows.Forms.Button btnExpiredElements;
        private System.Windows.Forms.Button btnReport;
    }
}