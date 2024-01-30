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
    public partial class FrmChangeOfMedicineReport : Form
    {
        List<MedicineChanged> medicineChangedList = new List<MedicineChanged>();
        MedicineDestruction medicine = new MedicineDestruction();
        List<ElementToDestroy> elementToDestroyList = new List<ElementToDestroy>();
        public FrmChangeOfMedicineReport(MedicineChanged medicineChanged, List<ElementToDestroy> elementToDestroyList)
        {
            medicineChangedList.Add(medicineChanged);
            this.elementToDestroyList = elementToDestroyList;
            createElementList();
            InitializeComponent();
        }

        private void createElementList()
        {
            for (int i = 0; i < elementToDestroyList.Count; i++)
            {
                elementToDestroyList[i].ElementName = elementToDestroyList[i].ElementName + " " + elementToDestroyList[i].Concentration + " " + elementToDestroyList[i].Presentation;
            }
        }

        private void FrmChangeOfMedicineReport_Load(object sender, EventArgs e)
        {
            if (!elementToDestroyList.Any()) return;
            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DSMedicineList", elementToDestroyList));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DSMedicineChanged", medicineChangedList));

            this.reportViewer1.RefreshReport();
        }
    }
}
