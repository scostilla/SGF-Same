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
    public partial class FrmElementsToExpireReport : Form
    {
        string reportTitle;
        List<StockList> stockList;
        public FrmElementsToExpireReport(List<StockList> stockList, string reportTitle)
        {
            this.reportTitle = reportTitle;
            this.stockList = stockList;
            InitializeComponent();
        }

        private void FrmElementsToExpireReport_Load(object sender, EventArgs e)
        {
            if (!stockList.Any()) return;
            
            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter("RptParameterTitle", reportTitle);


            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DSStockList", stockList));
            reportViewer1.LocalReport.SetParameters(parameters);
            this.reportViewer1.RefreshReport();
        }
    }
}
