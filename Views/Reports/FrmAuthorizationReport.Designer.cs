namespace Views.Reports
{
    partial class FrmAuthorizationReport
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
            this.rptAuthorization = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptAuthorization
            // 
            this.rptAuthorization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptAuthorization.LocalReport.ReportEmbeddedResource = "Views.Reports.RptAuthorization.rdlc";
            this.rptAuthorization.Location = new System.Drawing.Point(0, 0);
            this.rptAuthorization.Name = "rptAuthorization";
            this.rptAuthorization.ServerReport.BearerToken = null;
            this.rptAuthorization.Size = new System.Drawing.Size(800, 450);
            this.rptAuthorization.TabIndex = 0;
            // 
            // FrmAuthorizationReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptAuthorization);
            this.Name = "FrmAuthorizationReport";
            this.Text = "Autorizacion";
            this.Load += new System.EventHandler(this.FrmAuthorizationReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptAuthorization;
    }
}