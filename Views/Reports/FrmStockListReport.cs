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
    public partial class FrmStockListReport : Form
    {
        List<StockList> stockList = new List<StockList>();
        String title, baseTitle;
        public FrmStockListReport(String title,Boolean GroupByElement, List<StockList> stockList)
        {
            this.title = title;
            if (GroupByElement)
            {
                baseTitle = "Ingreso/Egreso";
            }
            else
            {
                baseTitle = "Base Operativa";
            }
            this.stockList = stockList;
            InitializeComponent();
        }

        private void FrmStockListReport_Load(object sender, EventArgs e)
        {
            if (!stockList.Any()) return;

            System.Drawing.Printing.PageSettings ps = new System.Drawing.Printing.PageSettings();
            ps.Landscape = true;
            ps.PaperSize = new System.Drawing.Printing.PaperSize("A4", 827, 1170);
            ps.PaperSize.RawKind = (int)System.Drawing.Printing.PaperKind.A4;

            ps.Margins.Top = 0;
            ps.Margins.Bottom = 0;
            ps.Margins.Left = 70;
            ps.Margins.Right = 10;

            rptStockList.SetPageSettings(ps);

            ReportParameter[] parameters = new ReportParameter[2];
            parameters[0] = new ReportParameter("RptParameterTitle", title);
            parameters[1] = new ReportParameter("RptParameterType", baseTitle);
            rptStockList.LocalReport.DataSources.Clear();
            rptStockList.LocalReport.DataSources.Add(new ReportDataSource("DSStockList", stockList));
            rptStockList.LocalReport.SetParameters(parameters);

            this.rptStockList.RefreshReport();
        }
    }
}
