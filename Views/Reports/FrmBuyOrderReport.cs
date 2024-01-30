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
    public partial class FrmBuyOrderReport : Form
    {
        List <BuyOrder> buyOrder = new List<BuyOrder>();
        public FrmBuyOrderReport(BuyOrder buyOrder)
        {
            this.buyOrder.Add(buyOrder);
            InitializeComponent();
        }

        private void FrmBuyOrderReport_Load(object sender, EventArgs e)
        {
            if (!buyOrder.Any()) return;
            rptBuyOrder.LocalReport.DataSources.Clear();
            rptBuyOrder.LocalReport.DataSources.Add(new ReportDataSource ("DSBuyOrder", buyOrder));
            rptBuyOrder.LocalReport.DataSources.Add(new ReportDataSource ("DSElementToBuy", buyOrder[0].elementList));
            this.rptBuyOrder.RefreshReport();
        }
    }
}
