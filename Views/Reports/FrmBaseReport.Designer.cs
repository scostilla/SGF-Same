namespace Views.Reports
{
    partial class FrmBaseReport
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sameDataSet = new Views.sameDataSet();
            this.sameDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseTableAdapter = new Views.sameDataSetTableAdapters.baseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sameDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sameDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // frmAuthorizationReport
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.baseBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Views.Reports.RptBase.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "frmAuthorizationReport";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 373);
            this.reportViewer1.TabIndex = 0;
            // 
            // sameDataSet
            // 
            this.sameDataSet.DataSetName = "sameDataSet";
            this.sameDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sameDataSetBindingSource
            // 
            this.sameDataSetBindingSource.DataSource = this.sameDataSet;
            this.sameDataSetBindingSource.Position = 0;
            // 
            // baseBindingSource
            // 
            this.baseBindingSource.DataMember = "base";
            this.baseBindingSource.DataSource = this.sameDataSetBindingSource;
            // 
            // baseTableAdapter
            // 
            this.baseTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBaseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 373);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmBaseReport";
            this.Text = "FrmBaseReport";
            this.Load += new System.EventHandler(this.FrmBaseReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sameDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sameDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private sameDataSet sameDataSet;
        private System.Windows.Forms.BindingSource sameDataSetBindingSource;
        private System.Windows.Forms.BindingSource baseBindingSource;
        private sameDataSetTableAdapters.baseTableAdapter baseTableAdapter;
    }
}