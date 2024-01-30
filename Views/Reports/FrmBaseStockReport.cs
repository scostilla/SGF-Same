using ClassLibrary;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.Reports
{
    public partial class FrmBaseStockReport : Form
    {
        List<StockList> elementsToReport;
        public FrmBaseStockReport(String baseName, List<StockList> elementsToReport)
        {
            this.Text = "Stock en Base " + baseName;
            this.elementsToReport = elementsToReport;
            InitializeComponent();
        }

        private void FrmBaseStockReport_Load(object sender, EventArgs e)
        {
            if (!elementsToReport.Any()) return;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DSStockToReport", elementsToReport));
            this.reportViewer1.RefreshReport();
        }
    }
}
