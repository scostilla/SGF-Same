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
    public partial class FrmExpiredElementsReport : Form
    {
        public List<ElementToBuy> expiredList = new List<ElementToBuy>();

        public FrmExpiredElementsReport(List<ElementToBuy> expiredList)
        {
            this.expiredList = expiredList;
            InitializeComponent();
        }

        private void FrmExpiredElementsReport_Load(object sender, EventArgs e)
        {
            if (!expiredList.Any()) return;

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DSExpiredElements",expiredList));
            this.reportViewer1.RefreshReport();
        }
    }
}
