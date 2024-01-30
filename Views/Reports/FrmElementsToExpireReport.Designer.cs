
namespace Views.Reports
{
    partial class FrmElementsToExpireReport
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ElementToDestroyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MedicineChangedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ElementToDestroyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedicineChangedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Views.Reports.RptElementsToExpire.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ElementToDestroyBindingSource
            // 
            this.ElementToDestroyBindingSource.DataSource = typeof(ClassLibrary.ElementToDestroy);
            // 
            // MedicineChangedBindingSource
            // 
            this.MedicineChangedBindingSource.DataSource = typeof(ClassLibrary.MedicineChanged);
            // 
            // FrmElementsToExpireReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmElementsToExpireReport";
            this.Text = "Elementos proximos a vencer";
            this.Load += new System.EventHandler(this.FrmElementsToExpireReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ElementToDestroyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedicineChangedBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ElementToDestroyBindingSource;
        private System.Windows.Forms.BindingSource MedicineChangedBindingSource;
    }
}