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
    public partial class FrmAuthorizationReport : Form
    {
        List<BuyOrder> buyOrder = new List<BuyOrder>();
        public FrmAuthorizationReport(BuyOrder buyOrder)
        {
            this.buyOrder.Add(buyOrder);
            InitializeComponent();
        }

        private void FrmAuthorizationReport_Load(object sender, EventArgs e)
        {
            if (!buyOrder.Any()) return;
            rptAuthorization.LocalReport.DataSources.Clear();
            rptAuthorization.LocalReport.DataSources.Add(new ReportDataSource("DSBuyOrder", buyOrder));
            rptAuthorization.LocalReport.DataSources.Add(new ReportDataSource("DSElementToBuy", buyOrder[0].elementList));
            this.rptAuthorization.RefreshReport();
        }
    }
}
