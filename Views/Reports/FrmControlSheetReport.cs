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
    public partial class FrmControlSheetReport : Form
    {
        public List<ElementSheet> Detail = new List<ElementSheet>();
        public List<OperationalGrid> Data = new List<OperationalGrid>();
        OperationalGrid operationalGrid = new OperationalGrid();
        public FrmControlSheetReport(ControlSheet controlSheet,int operationalMonth,int operationalYear,String vehicle)
        {
            this.Detail = controlSheet.Detail;
            this.operationalGrid.OperationalMonth = operationalMonth;
            this.operationalGrid.OperationaYear = operationalYear;
            this.operationalGrid.Vehicle = vehicle;
            Data.Add(operationalGrid);
            InitializeComponent();
        }

        private void FrmControlSheetReport_Load(object sender, EventArgs e)
        {
            if (!Detail.Any()) return;
            rptControlSheet.LocalReport.DataSources.Clear();
            rptControlSheet.LocalReport.DataSources.Add(new ReportDataSource("DSControlSheet", Detail));
            rptControlSheet.LocalReport.DataSources.Add(new ReportDataSource("DSOperationalGrid", Data));

            this.rptControlSheet.RefreshReport();
        }
    }
}
