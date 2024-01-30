using ClassLibrary;
using NuGet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Views.Lists;
using Views.Reports;

namespace Views.Lists
{
    public partial class FrmMedicineDestructionDetail : Form
    {
        DBConexion con = new DBConexion();
        MedicineDestruction medicineDestruction;
        List<ElementToDestroy> elementToDestroyList;
        List<BaseStock> baseStockList;
        String sql;
        public FrmMedicineDestructionDetail(MedicineDestruction medicineDestruction, List<ElementToDestroy> elementToDestroyList)
        {
            this.medicineDestruction = medicineDestruction;
            this.elementToDestroyList = elementToDestroyList;
            InitializeComponent();
        }

        private void FrmNewMedicineDestructionDetail_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Detalle de decomiso N°" + medicineDestruction.ReportNumber;
            lblCity.Text = medicineDestruction.City;
            lblBase.Text = medicineDestruction.BaseName;
            lblState.Text = medicineDestruction.State;
            lblRequestedBy.Text = medicineDestruction.RequestedBy;
            lblRequestedDate.Text = medicineDestruction.RequestedDate.ToString("dd/MM/yyyy");

            grdElementList.DataSource = elementToDestroyList;

            grdElementList.Columns[1].Visible = false;
            grdElementList.Columns[8].Visible = false;
            grdElementList.Columns[9].Visible = false;
            grdElementList.Columns[11].Visible = false;

            grdElementList.Columns[0].HeaderText = "Item";
            grdElementList.Columns[2].HeaderText = "Elemento";
            grdElementList.Columns[3].HeaderText = "Concentracion";
            grdElementList.Columns[4].HeaderText = "Presentacion";
            grdElementList.Columns[5].HeaderText = "Lote";
            grdElementList.Columns[6].HeaderText = "Vencimiento";
            grdElementList.Columns[7].HeaderText = "Cantidad";
            grdElementList.Columns[10].HeaderText = "Observaciones";

            grdElementList.Columns[0].Width = 50;
            grdElementList.Columns[6].Width = 70;
            grdElementList.Columns[7].Width = 70;
            grdElementList.Columns[10].Width = 250;


            if (medicineDestruction.State == "Anulado")
            {
                btnCancel.Enabled = false;
            }
            else
            {
                btnCancel.Enabled = true;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FrmMedicineDestructionReport frmMedicineDestruction = new FrmMedicineDestructionReport(medicineDestruction, elementToDestroyList);
            frmMedicineDestruction.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro de anular el decomiso N°" + medicineDestruction.ReportNumber + "\nADVERTENCIA: estos elementos volveran al stock correspondiente", "Anular", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                //traer id y cantidad de lista de basestock
                sql = String.Empty;

                if (elementToDestroyList[0].BaseStockId != -1)
                {
                    sql = "select * from basestock where id_baseStock= " + elementToDestroyList[0].BaseStockId;
                }

                if (elementToDestroyList.Count > 1)
                {
                    for (int i = 1; i < elementToDestroyList.Count; i++)
                    {
                        if(elementToDestroyList[i].BaseStockId != -1)
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
                sql = sql + "update medicineDestruction set state='Anulado' where MedicineDestruction_id=" + medicineDestruction.Id + ";";
                if (con.insert(sql))
                {
                    MessageBox.Show("El decomiso N°" + medicineDestruction.ReportNumber + "fue anulado correctamente");
                    medicineDestruction.State = "Anulado"; 
                    lblState.Text = "Anulado";
                    btnCancel.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error al anular decomiso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
