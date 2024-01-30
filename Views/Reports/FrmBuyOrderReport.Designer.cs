namespace Views.Reports
{
    partial class FrmBuyOrderReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.BuyOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ElementToBuyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptBuyOrder = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.BuyOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElementToBuyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BuyOrderBindingSource
            // 
            this.BuyOrderBindingSource.DataSource = typeof(ClassLibrary.BuyOrder);
            // 
            // ElementToBuyBindingSource
            // 
            this.ElementToBuyBindingSource.DataSource = typeof(ClassLibrary.ElementToBuy);
            // 
            // rptBuyOrder
            // 
            this.rptBuyOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSBuyOrder";
            reportDataSource1.Value = this.BuyOrderBindingSource;
            reportDataSource2.Name = "DSElementToBuy";
            reportDataSource2.Value = this.ElementToBuyBindingSource;
            this.rptBuyOrder.LocalReport.DataSources.Add(reportDataSource1);
            this.rptBuyOrder.LocalReport.DataSources.Add(reportDataSource2);
            this.rptBuyOrder.LocalReport.ReportEmbeddedResource = "Views.Reports.RptBuyOrder.rdlc";
            this.rptBuyOrder.Location = new System.Drawing.Point(0, 0);
            this.rptBuyOrder.Name = "rptBuyOrder";
            this.rptBuyOrder.ServerReport.BearerToken = null;
            this.rptBuyOrder.Size = new System.Drawing.Size(852, 509);
            this.rptBuyOrder.TabIndex = 0;
            // 
            // FrmBuyOrderReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 509);
            this.Controls.Add(this.rptBuyOrder);
            this.Name = "FrmBuyOrderReport";
            this.Text = "Orden de Compra";
            this.Load += new System.EventHandler(this.FrmBuyOrderReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BuyOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElementToBuyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource BuyOrderBindingSource;
        private System.Windows.Forms.BindingSource ElementToBuyBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer rptBuyOrder;
    }
}