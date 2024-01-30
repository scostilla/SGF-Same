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
    public partial class FrmMedicineDestructionReport : Form
    {
        List <MedicineDestruction> medicineDestructionList=new List<MedicineDestruction>();
        MedicineDestruction medicine = new MedicineDestruction();
        List<ElementToDestroy> elementToDestroyList=new List<ElementToDestroy>();
        public FrmMedicineDestructionReport(MedicineDestruction medicineDestruction, List<ElementToDestroy> elementToDestroyList)
        {
            medicineDestructionList.Add(medicineDestruction);
            this.elementToDestroyList = elementToDestroyList;
            createElementList();
            InitializeComponent();
        }

        private void createElementList()
        {
            for(int i=0;i< elementToDestroyList.Count; i++)
            {
                elementToDestroyList[i].ElementName = elementToDestroyList[i].ElementName + " " + elementToDestroyList[i].Concentration + " " + elementToDestroyList[i].Presentation;
                if (elementToDestroyList[i].BaseName.Contains("BASE"))
                {
                    string[] splitBase = elementToDestroyList[i].BaseName.Split(':');
                    elementToDestroyList[i].BaseName = splitBase[1].TrimStart(' ');
                }
            }
        }

        private void FrmMedicineDestruction_Load(object sender, EventArgs e)
        {
            if (!elementToDestroyList.Any()) return;
            rptMedicineDestruction.LocalReport.DataSources.Clear();

            rptMedicineDestruction.LocalReport.DataSources.Add(new ReportDataSource("DSMedicineDestruction", medicineDestructionList));
            rptMedicineDestruction.LocalReport.DataSources.Add(new ReportDataSource("DSElementToDestroyList", elementToDestroyList));
            
            this.rptMedicineDestruction.RefreshReport();
        }
    }
}
