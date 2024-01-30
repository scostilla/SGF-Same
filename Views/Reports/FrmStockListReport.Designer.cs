namespace Views.Reports
{
    partial class FrmStockListReport
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
            this.StockListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptStockList = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ElementToBuyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.StockListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElementToBuyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // StockListBindingSource
            // 
            this.StockListBindingSource.DataSource = typeof(ClassLibrary.StockList);
            // 
            // rptStockList
            // 
            this.rptStockList.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSStockList";
            reportDataSource1.Value = this.StockListBindingSource;
            this.rptStockList.LocalReport.DataSources.Add(reportDataSource1);
            this.rptStockList.LocalReport.ReportEmbeddedResource = "Views.Reports.RptStockList.rdlc";
            this.rptStockList.Location = new System.Drawing.Point(0, 0);
            this.rptStockList.Name = "rptStockList";
            this.rptStockList.ServerReport.BearerToken = null;
            this.rptStockList.Size = new System.Drawing.Size(800, 450);
            this.rptStockList.TabIndex = 0;
            // 
            // ElementToBuyBindingSource
            // 
            this.ElementToBuyBindingSource.DataSource = typeof(ClassLibrary.ElementToBuy);
            // 
            // FrmStockListReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptStockList);
            this.Name = "FrmStockListReport";
            this.Text = "Listado de Elementos";
            this.Load += new System.EventHandler(this.FrmStockListReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StockListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElementToBuyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptStockList;
        private System.Windows.Forms.BindingSource StockListBindingSource;
        private System.Windows.Forms.BindingSource ElementToBuyBindingSource;
    }
}