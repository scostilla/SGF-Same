namespace Views.Reports
{
    partial class FrmControlSheetTotalsReport
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
            this.rptControlSheetTotals = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ElementQuantityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ElementQuantityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptControlSheetTotals
            // 
            this.rptControlSheetTotals.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSElementQuantity";
            reportDataSource1.Value = this.ElementQuantityBindingSource;
            this.rptControlSheetTotals.LocalReport.DataSources.Add(reportDataSource1);
            this.rptControlSheetTotals.LocalReport.ReportEmbeddedResource = "Views.Reports.RptControlSheetTotals.rdlc";
            this.rptControlSheetTotals.Location = new System.Drawing.Point(0, 0);
            this.rptControlSheetTotals.Name = "rptControlSheetTotals";
            this.rptControlSheetTotals.ServerReport.BearerToken = null;
            this.rptControlSheetTotals.Size = new System.Drawing.Size(800, 450);
            this.rptControlSheetTotals.TabIndex = 0;
            // 
            // ElementQuantityBindingSource
            // 
            this.ElementQuantityBindingSource.DataSource = typeof(ClassLibrary.ElementQuantity);
            // 
            // FrmControlSheetTotalsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptControlSheetTotals);
            this.Name = "FrmControlSheetTotalsReport";
            this.Text = "FrmControlSheetTotalsReport";
            this.Load += new System.EventHandler(this.FrmControlSheetTotalsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ElementQuantityBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptControlSheetTotals;
        private System.Windows.Forms.BindingSource ElementQuantityBindingSource;
    }
}