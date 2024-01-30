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
    public partial class FrmMedicineDestructionList : Form
    {
        DBConexion con = new DBConexion();
        int medicineDestructionId, rowIndex;
        MedicineDestruction medicineDestruction;
        List<ElementToDestroy> elementToDestroyList;
        BaseStock baseStock;
        List<BaseStock> baseStockList;
        String sql;
        public FrmMedicineDestructionList()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmMedicineDestructionList_Load(object sender, EventArgs e)
        {
            grdMedicineDestruction.DataSource = con.consultTable("medicineDestruction order by MedicineDestruction_id");
            grdMedicineDestruction.Columns[0].Visible = false;
            grdMedicineDestruction.Columns[6].Visible = false;
            grdMedicineDestruction.Columns[8].Visible = false;
            grdMedicineDestruction.Columns[9].Visible = false;
            grdMedicineDestruction.Columns[10].Visible = false;
            grdMedicineDestruction.Columns[11].Visible = false;

            grdMedicineDestruction.Columns[1].HeaderText = "Numero";
            grdMedicineDestruction.Columns[2].HeaderText = "Ciudad";
            grdMedicineDestruction.Columns[3].HeaderText = "Base";
            grdMedicineDestruction.Columns[4].HeaderText = "Responsable";
            grdMedicineDestruction.Columns[5].HeaderText = "Fecha";
            grdMedicineDestruction.Columns[7].HeaderText = "Estado";

            grdMedicineDestruction.Columns[2].Width = 200;
            grdMedicineDestruction.Columns[3].Width = 200;
            grdMedicineDestruction.Columns[4].Width = 200;

            DataGridViewButtonColumn buttonColumn =
            new DataGridViewButtonColumn();
            buttonColumn.Name = "Details";
            buttonColumn.HeaderText = "Detalle";
            buttonColumn.Text = "Ver Detalle";
            buttonColumn.UseColumnTextForButtonValue = true;
            grdMedicineDestruction.Columns.Insert(12, buttonColumn);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            generateElemntToDestroy();

            FrmMedicineDestructionReport frmMedicineDestruction = new FrmMedicineDestructionReport(medicineDestruction, elementToDestroyList);
            frmMedicineDestruction.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro de anular el decomiso N°"+ grdMedicineDestruction.Rows[rowIndex].Cells[1].Value.ToString()+"\nADVERTENCIA: estos elementos volveran al stock correspondiente", "Anular", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                generateList();

                //traer id y cantidad de lista de basestock
                sql = String.Empty;
                if (elementToDestroyList[0].BaseStockId != -1)
                {
                    sql = "select * from basestock where id_baseStock= " + elementToDestroyList[0].BaseStockId;
                }
                if (elementToDestroyList.Count > 1)
                {
                    for(int i=1;i< elementToDestroyList.Count; i++)
                    {
                        if (elementToDestroyList[i].BaseStockId != -1)
                        {
                            if (sql == "")
                            {
                                sql = "select * from basestock where id_baseStock= " + elementToDestroyList[i].BaseStockId;
                            }
                            else
                            {
                                sql = sql + " or id_baseStock= " + elementToDestroyList[i].BaseStockId;
                            }
                        }
                    }
                }
                if (sql != "")
                {
                    baseStockList = con.genericConsult("basestock", sql).AsEnumerable().Select(m => new BaseStock()
                    {
                        Id = m.Field<int>("id_BaseStock"),
                        IdBase = m.Field<int>("id_base"),
                        IdElement = m.Field<int>("id_element"),
                        Quantity = m.Field<int>("quantity"),
                    }).ToList();

                    sql = String.Empty;
                    foreach (BaseStock baseStock in baseStockList)
                    {
                        if (baseStock.Id != -1)
                        {
                            foreach (ElementToDestroy element in elementToDestroyList)
                            {
                                if (baseStock.Id == element.BaseStockId)
                                {
                                    sql = sql + "update baseStock set quantity=" + baseStock.Quantity + element.Egress + " where id_baseStock=" + baseStock.Id + ";";
                                }
                            }
                        }
                    }
                }
                    sql = sql + "update medicineDestruction set state='Anulado' where MedicineDestruction_id=" + medicineDestructionId + ";";
                    if (con.insert(sql))
                    {
                        MessageBox.Show("El decomiso N°" + grdMedicineDestruction.Rows[rowIndex].Cells[1].Value.ToString() + "fue anulado correctamente");
                        grdMedicineDestruction.DataSource = con.consultTable("medicineDestruction");
                    }
                    else
                    {
                        MessageBox.Show("Error al anular decomiso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
        }

        private void generateElemntToDestroy()
        {
            medicineDestruction = new MedicineDestruction();
            medicineDestruction.Id = Convert.ToInt32(grdMedicineDestruction.Rows[rowIndex].Cells[1].Value);
            medicineDestruction.ReportNumber = grdMedicineDestruction.Rows[rowIndex].Cells[2].Value.ToString();
            medicineDestruction.City = grdMedicineDestruction.Rows[rowIndex].Cells[3].Value.ToString();
            medicineDestruction.BaseName = grdMedicineDestruction.Rows[rowIndex].Cells[4].Value.ToString();
            medicineDestruction.RequestedBy = grdMedicineDestruction.Rows[rowIndex].Cells[5].Value.ToString();
            medicineDestruction.RequestedDate = Convert.ToDateTime(grdMedicineDestruction.Rows[rowIndex].Cells[6].Value.ToString());
            medicineDestruction.State = grdMedicineDestruction.Rows[rowIndex].Cells[8].Value.ToString();

            generateList();
        }
        private void generateList()
        {
            elementToDestroyList = new List<ElementToDestroy>();
            XElement xdocument = XElement.Parse(grdMedicineDestruction.Rows[rowIndex].Cells[7].Value.ToString());

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
                           Quantity = item.Element("Egress").Value,
                           Observations = item.Element("Observations").Value,
                           BaseStockId = item.Element("BaseStockId").Value
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
                elementToDestroy.Egress = Convert.ToInt32(item.Quantity);
                elementToDestroy.Observations = item.Observations;
                elementToDestroy.BaseStockId = Convert.ToInt32(item.BaseStockId);

                elementToDestroyList.Add(elementToDestroy);
            }
        }
        private void grdMedicineDestruction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            medicineDestructionId = Convert.ToInt32(grdMedicineDestruction.Rows[e.RowIndex].Cells[1].Value.ToString());
            rowIndex = e.RowIndex;
            if (grdMedicineDestruction.Rows[rowIndex].Cells[7].Value.ToString() == "Anulado")
            {
                btnCancel.Enabled = false;
            }
            else
            {
                btnCancel.Enabled = true;
            }

            if (e.ColumnIndex == 0)
            {
                generateElemntToDestroy();
                FrmMedicineDestructionDetail frmNewMedicineDestruction=new FrmMedicineDestructionDetail(medicineDestruction, elementToDestroyList);
                frmNewMedicineDestruction.Show();
            }
        }
    }
}
