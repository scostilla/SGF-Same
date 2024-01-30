namespace Views.Reports
{
    partial class FrmControlSheetReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ElementToBuyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptControlSheet = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ElementToBuyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ElementToBuyBindingSource
            // 
            this.ElementToBuyBindingSource.DataSource = typeof(ClassLibrary.ElementToBuy);
            // 
            // rptControlSheet
            // 
            this.rptControlSheet.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSExpiredelements";
            reportDataSource1.Value = this.ElementToBuyBindingSource;
            this.rptControlSheet.LocalReport.DataSources.Add(reportDataSource1);
            this.rptControlSheet.LocalReport.ReportEmbeddedResource = "Views.Reports.RptExpiredElements.rdlc";
            this.rptControlSheet.Location = new System.Drawing.Point(0, 0);
            this.rptControlSheet.Margin = new System.Windows.Forms.Padding(1);
            this.rptControlSheet.Name = "rptControlSheet";
            this.rptControlSheet.ServerReport.BearerToken = null;
            this.rptControlSheet.Size = new System.Drawing.Size(872, 542);
            this.rptControlSheet.TabIndex = 0;
            // 
            // FrmControlSheetReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 542);
            this.Controls.Add(this.rptControlSheet);
            this.Name = "FrmControlSheetReport";
            this.Text = "Planilla de Control";
            this.Load += new System.EventHandler(this.FrmControlSheetReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ElementToBuyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptControlSheet;
        private System.Windows.Forms.BindingSource ElementToBuyBindingSource;
    }
}