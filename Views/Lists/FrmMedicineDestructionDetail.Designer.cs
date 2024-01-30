namespace Views.Lists
{
    partial class FrmMedicineDestructionDetail
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
            this.lblBaseTitle = new System.Windows.Forms.Label();
            this.grdElementList = new System.Windows.Forms.DataGridView();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblRequestedByTitle = new System.Windows.Forms.Label();
            this.lblDateTitle = new System.Windows.Forms.Label();
            this.lblCityTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStateTitle = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblRequestedBy = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblRequestedDate = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdElementList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaseTitle
            // 
            this.lblBaseTitle.AutoSize = true;
            this.lblBaseTitle.Location = new System.Drawing.Point(431, 59);
            this.lblBaseTitle.Name = "lblBaseTitle";
            this.lblBaseTitle.Size = new System.Drawing.Size(38, 13);
            this.lblBaseTitle.TabIndex = 69;
            this.lblBaseTitle.Text = "BASE:";
            // 
            // grdElementList
            // 
            this.grdElementList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdElementList.Location = new System.Drawing.Point(12, 135);
            this.grdElementList.Name = "grdElementList";
            this.grdElementList.ReadOnly = true;
            this.grdElementList.Size = new System.Drawing.Size(894, 370);
            this.grdElementList.TabIndex = 67;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(831, 511);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 66;
            this.btnQuit.Text = "Salir";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblRequestedByTitle
            // 
            this.lblRequestedByTitle.AutoSize = true;
            this.lblRequestedByTitle.Location = new System.Drawing.Point(29, 101);
            this.lblRequestedByTitle.Name = "lblRequestedByTitle";
            this.lblRequestedByTitle.Size = new System.Drawing.Size(110, 13);
            this.lblRequestedByTitle.TabIndex = 61;
            this.lblRequestedByTitle.Text = "SOLICITADOS  POR:";
            // 
            // lblDateTitle
            // 
            this.lblDateTitle.AutoSize = true;
            this.lblDateTitle.Location = new System.Drawing.Point(427, 101);
            this.lblDateTitle.Name = "lblDateTitle";
            this.lblDateTitle.Size = new System.Drawing.Size(45, 13);
            this.lblDateTitle.TabIndex = 58;
            this.lblDateTitle.Text = "FECHA:";
            // 
            // lblCityTitle
            // 
            this.lblCityTitle.AutoSize = true;
            this.lblCityTitle.Location = new System.Drawing.Point(29, 59);
            this.lblCityTitle.Name = "lblCityTitle";
            this.lblCityTitle.Size = new System.Drawing.Size(51, 13);
            this.lblCityTitle.TabIndex = 57;
            this.lblCityTitle.Text = "CIUDAD:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(240, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(307, 25);
            this.lblTitle.TabIndex = 56;
            this.lblTitle.Text = "Decomiso de Medicamentos";
            // 
            // lblStateTitle
            // 
            this.lblStateTitle.AutoSize = true;
            this.lblStateTitle.Location = new System.Drawing.Point(673, 59);
            this.lblStateTitle.Name = "lblStateTitle";
            this.lblStateTitle.Size = new System.Drawing.Size(54, 13);
            this.lblStateTitle.TabIndex = 70;
            this.lblStateTitle.Text = "ESTADO:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(86, 59);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(34, 13);
            this.lblCity.TabIndex = 71;
            this.lblCity.Text = "lblCity";
            // 
            // lblRequestedBy
            // 
            this.lblRequestedBy.AutoSize = true;
            this.lblRequestedBy.Location = new System.Drawing.Point(145, 101);
            this.lblRequestedBy.Name = "lblRequestedBy";
            this.lblRequestedBy.Size = new System.Drawing.Size(81, 13);
            this.lblRequestedBy.TabIndex = 72;
            this.lblRequestedBy.Text = "lblRequestedBy";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(483, 59);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(41, 13);
            this.lblBase.TabIndex = 73;
            this.lblBase.Text = "lblBase";
            // 
            // lblRequestedDate
            // 
            this.lblRequestedDate.AutoSize = true;
            this.lblRequestedDate.Location = new System.Drawing.Point(485, 101);
            this.lblRequestedDate.Name = "lblRequestedDate";
            this.lblRequestedDate.Size = new System.Drawing.Size(92, 13);
            this.lblRequestedDate.TabIndex = 74;
            this.lblRequestedDate.Text = "lblRequestedDate";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(737, 59);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(42, 13);
            this.lblState.TabIndex = 75;
            this.lblState.Text = "lblState";
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(32, 511);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(107, 23);
            this.btnReport.TabIndex = 76;
            this.btnReport.Text = "Generar Reporte";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(172, 511);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 77;
            this.btnCancel.Text = "Anular";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmMedicineDestructionDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 546);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblRequestedDate);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblRequestedBy);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblStateTitle);
            this.Controls.Add(this.lblBaseTitle);
            this.Controls.Add(this.grdElementList);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblRequestedByTitle);
            this.Controls.Add(this.lblDateTitle);
            this.Controls.Add(this.lblCityTitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmMedicineDestructionDetail";
            this.Text = "Detalle de Decomiso";
            this.Load += new System.EventHandler(this.FrmNewMedicineDestructionDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdElementList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaseTitle;
        private System.Windows.Forms.DataGridView grdElementList;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblRequestedByTitle;
        private System.Windows.Forms.Label lblDateTitle;
        private System.Windows.Forms.Label lblCityTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStateTitle;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblRequestedBy;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblRequestedDate;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnCancel;
    }
}