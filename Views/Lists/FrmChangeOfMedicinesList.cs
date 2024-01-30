using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Views.NewForms;
using Views.Reports;

namespace Views.Lists
{
    public partial class FrmChangeOfMedicinesList : Form
    {
        DBConexion con = new DBConexion();
        int medicineDestructionId, rowIndex;
        MedicineChanged medicineChanged;
        List<ElementToDestroy> elementToDestroyList;
        String sql;

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmChangeOfMedicinesList_Load(object sender, EventArgs e)
        {
            grdMedicineDestruction.DataSource = con.consultTable("changeOfMedicines");
            grdMedicineDestruction.Columns[0].Visible = false;
            grdMedicineDestruction.Columns[6].Visible = false;
            grdMedicineDestruction.Columns[7].Visible = false;
            grdMedicineDestruction.Columns[9].Visible = false;
            grdMedicineDestruction.Columns[10].Visible = false;
            grdMedicineDestruction.Columns[11].Visible = false;
            grdMedicineDestruction.Columns[12].Visible = false;

            grdMedicineDestruction.Columns[1].HeaderText = "Numero";
            grdMedicineDestruction.Columns[2].HeaderText = "Ciudad";
            grdMedicineDestruction.Columns[3].HeaderText = "Destino";
            grdMedicineDestruction.Columns[4].HeaderText = "Responsable";
            grdMedicineDestruction.Columns[5].HeaderText = "Fecha";
            grdMedicineDestruction.Columns[8].HeaderText = "Estado";

            grdMedicineDestruction.Columns[1].Width = 70;
            grdMedicineDestruction.Columns[2].Width = 200;
            grdMedicineDestruction.Columns[3].Width = 200;
            grdMedicineDestruction.Columns[4].Width = 180;
            grdMedicineDestruction.Columns[5].Width = 70;
            grdMedicineDestruction.Columns[8].Width = 50;
        }

        private void grdMedicineDestruction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            medicineDestructionId = Convert.ToInt32(grdMedicineDestruction.Rows[e.RowIndex].Cells[0].Value.ToString());
            rowIndex = e.RowIndex;
            if (grdMedicineDestruction.Rows[rowIndex].Cells[7].Value.ToString() == "Anulado")
            {
                btnEdit.Enabled = false;
            }
            else
            {
                btnEdit.Enabled = true;
            }
        }

        private void createElements()
        {
            medicineChanged = new MedicineChanged();
            elementToDestroyList = new List<ElementToDestroy>();
            medicineChanged.ReportNumber = grdMedicineDestruction.Rows[rowIndex].Cells[1].Value.ToString();
            medicineChanged.City = grdMedicineDestruction.Rows[rowIndex].Cells[2].Value.ToString();
            medicineChanged.RequestedBy = grdMedicineDestruction.Rows[rowIndex].Cells[4].Value.ToString();
            medicineChanged.RequestedDate = Convert.ToDateTime(grdMedicineDestruction.Rows[rowIndex].Cells[5].Value.ToString());
            medicineChanged.State = grdMedicineDestruction.Rows[rowIndex].Cells[7].Value.ToString();
            medicineChanged.Destiny = grdMedicineDestruction.Rows[rowIndex].Cells[3].Value.ToString();

            XElement xdocument = XElement.Parse(grdMedicineDestruction.Rows[rowIndex].Cells[6].Value.ToString());

            var list = from item in xdocument.Elements("ElementToDestroy")
                       select new
                       {
                           index = item.Element("Index").Value,
                           ElementName = item.Element("ElementName").Value,
                           Presentation = item.Element("Presentation").Value,
                           Concentration = item.Element("Concentration").Value,
                           BaseName = item.Element("BaseName").Value,
                           Lot = item.Element("Lot").Value,
                           ExpireDate = item.Element("ExpireDate").Value,
                           Egress = item.Element("Egress").Value,
                           Entry = item.Element("Entry").Value,
                           Pending = item.Element("Pending").Value,
                           Observations = item.Element("Observations").Value
                       };

            foreach (var item in list)
            {
                ElementToDestroy elementToDestroy = new ElementToDestroy();
                elementToDestroy.Index = Convert.ToInt32(item.index);
                elementToDestroy.ElementName = item.ElementName;
                elementToDestroy.Presentation = item.Presentation;
                elementToDestroy.Concentration = item.Concentration;
                elementToDestroy.BaseName = item.BaseName;
                elementToDestroy.Lot = item.Lot;
                elementToDestroy.ExpireDate = Convert.ToDateTime(item.ExpireDate);
                elementToDestroy.Egress = Convert.ToInt32(item.Egress);
                elementToDestroy.Entry = Convert.ToInt32(item.Entry);
                elementToDestroy.Pending = Convert.ToInt32(item.Pending);
                elementToDestroy.Observations = item.Observations;

                elementToDestroyList.Add(elementToDestroy);
            }
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            createElements();
            
            FrmChangeOfMedicineReport frmChangeOfMedicineReport = new FrmChangeOfMedicineReport(medicineChanged, elementToDestroyList);
            frmChangeOfMedicineReport.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            createElements();

            FrmNewChangeOfMedicine frmNewChangeOfMedicine = new FrmNewChangeOfMedicine(medicineChanged, elementToDestroyList);
            frmNewChangeOfMedicine.Show();
         }

        public FrmChangeOfMedicinesList()
        {
            InitializeComponent();
        }
    }
}
