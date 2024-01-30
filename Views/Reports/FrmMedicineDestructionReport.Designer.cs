namespace Views.Reports
{
    partial class FrmMedicineDestructionReport
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
            this.rptMedicineDestruction = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptMedicineDestruction
            // 
            this.rptMedicineDestruction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptMedicineDestruction.LocalReport.ReportEmbeddedResource = "Views.Reports.RptMedicineDestruction.rdlc";
            this.rptMedicineDestruction.Location = new System.Drawing.Point(0, 0);
            this.rptMedicineDestruction.Name = "rptMedicineDestruction";
            this.rptMedicineDestruction.ServerReport.BearerToken = null;
            this.rptMedicineDestruction.Size = new System.Drawing.Size(800, 450);
            this.rptMedicineDestruction.TabIndex = 0;
            // 
            // FrmMedicineDestructionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptMedicineDestruction);
            this.Name = "FrmMedicineDestructionReport";
            this.Text = "Decomiso de Medicina";
            this.Load += new System.EventHandler(this.FrmMedicineDestruction_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptMedicineDestruction;
    }
}