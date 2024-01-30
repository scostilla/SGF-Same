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
    public partial class FrmControlSheetTotalsReport : Form
    {
        List<ElementQuantity> totals = new List<ElementQuantity>();
        ControlSheetTotals controlSheetTotals = new ControlSheetTotals();
        OperationalGrid operationalGrid = new OperationalGrid();
        List<OperatingPeriod> auxiliarData = new List<OperatingPeriod>();
        OperatingPeriod operatingPeriod = new OperatingPeriod();

        public FrmControlSheetTotalsReport(List<ElementQuantity> totals,String reportTitle, int reportYear,int reportMonth)
        {
            this.totals = totals;
            InitializeComponent();
            this.Text = reportTitle;

            if(reportTitle== "Mensual")
            {
                switch (reportMonth)
                {
                    case 1:
                        operatingPeriod.OperatingMonth = "Enero";
                        break;
                    case 2:
                        operatingPeriod.OperatingMonth = "Febrero";
                        break;
                    case 3:
                        operatingPeriod.OperatingMonth = "Marzo";
                        break;
                    case 4:
                        operatingPeriod.OperatingMonth = "Abril";
                        break;
                    case 5:
                        operatingPeriod.OperatingMonth = "Mayo";
                        break;
                    case 6:
                        operatingPeriod.OperatingMonth = "Junio";
                        break;
                    case 7:
                        operatingPeriod.OperatingMonth = "Julio";
                        break;
                    case 8:
                        operatingPeriod.OperatingMonth = "Agosto";
                        break;
                    case 9:
                        operatingPeriod.OperatingMonth = "Septiembre";
                        break;
                    case 10:
                        operatingPeriod.OperatingMonth = "Octubre";
                        break;
                    case 11:
                        operatingPeriod.OperatingMonth = "Noviembre";
                        break;
                    case 12:
                        operatingPeriod.OperatingMonth = "Diciembre";
                        break;
                }
            }
            else
            {
                operatingPeriod.OperatingMonth = reportTitle;
            }
            operatingPeriod.OperatingYear = reportYear.ToString();
            auxiliarData.Add(operatingPeriod);

        }

        private void FrmControlSheetTotalsReport_Load(object sender, EventArgs e)
        {

            if (!totals.Any()) return;
            rptControlSheetTotals.LocalReport.DataSources.Clear();
            rptControlSheetTotals.LocalReport.DataSources.Add(new ReportDataSource("DSElementQuantity", totals));
            rptControlSheetTotals.LocalReport.DataSources.Add(new ReportDataSource("DSOperatingPeriod", auxiliarData));

            this.rptControlSheetTotals.RefreshReport();

        }
    }
}
