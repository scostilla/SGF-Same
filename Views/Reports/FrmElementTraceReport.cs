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
    public partial class FrmElementTraceReport : Form
    {
        List<StockList> elementsToReport;
        Stock stock = new Stock();
        List<Stock> data = new List<Stock>();
        public FrmElementTraceReport(String baseName, DateTime dtpSince, DateTime dtpUntil, List<StockList> elementsToReport)
        {
            this.Text = "Stock en Base " + baseName;
            this.elementsToReport = elementsToReport;
            stock.EntryDate = dtpSince;
            stock.ExpireDate = dtpUntil;
            stock.Remit = baseName;
            data.Add(stock);
            InitializeComponent();
        }

        private void FrmElementTraceReport_Load(object sender, EventArgs e)
        {
            if (!elementsToReport.Any()) return;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DSStockToReport", elementsToReport));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DSData", data));
            
            this.reportViewer1.RefreshReport();
        }
    }
}
