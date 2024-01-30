using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using Views.NewForms;
using Views.Reports;

namespace Views.Lists
{
    public partial class FrmBasesStock : Form
    {
        //private static readonly List<ElementToBuy> ElementToBuyList = new List<ElementToBuy>();
        public FrmBasesStock()
        {
            InitializeComponent();
        }

        DBConexion con = new DBConexion();
        public bool allElements,elementModels;
        int id_elementModel,index;
        ElementToBuy elementToBuy;
        List<ElementToBuy> elementToBuyList, expiredList;
        List<StockList> elementsToReport;
        List<StockList> stockLists;
        List<ElementToAlert> alertList;
        DateTime deadline;
        String sql, reportOrigin;


        private void FrmBasesStock_Load(object sender, EventArgs e)
        {
            cmbBase.DataSource = con.consultTable("base");
            cmbBase.DisplayMember = "name";
            cmbBase.ValueMember = "id_base";
            cmbBase.SelectedValue = 1;

            cmbElement.DataSource = con.consultElement("elementModel");
            cmbElement.DisplayMember = "elementName";
            cmbElement.ValueMember = "id_elementModel";
            cmbElement.SelectedValue = 1;

            allElements = false;
            elementToBuy = new ElementToBuy();
            btnBuyOrder.Enabled = false;
            btnExpiredElements.Enabled = false;
            btnReport.Enabled = false;
            reportOrigin = String.Empty;
        }

        private void chkAllElementsChange(object sender, EventArgs e)
        {
            if (chkAllElements.Checked)
            {
                allElements = true;
                cmbElement.Enabled = false;
            }
            else
            {
                allElements = false;
                cmbElement.Enabled = true;
            }
        }


        private void btnProcess_Click(object sender, EventArgs e)
        {
            elementToBuyList = new List<ElementToBuy>();
            expiredList = new List<ElementToBuy>();
            alertList = new List<ElementToAlert>();
            btnBuyOrder.Enabled = true;
            btnExpiredElements.Enabled = true;
            btnReport.Enabled = true;
            reportOrigin = "btnProcess";

            int id_base = Convert.ToInt32(cmbBase.SelectedValue);

            if (allElements)
            {
                id_elementModel = -1;
            }
            else
            {
                id_elementModel = Convert.ToInt32(cmbElement.SelectedValue);
            }
            cleanDataGridView();
            grdStock.DataSource = con.consultStock(id_base, id_elementModel);
            grdStock.AllowUserToAddRows = false;
            grdStock.Columns[0].HeaderText = "Codigo";
            grdStock.Columns[1].HeaderText = "Elemento";
            grdStock.Columns[2].HeaderText = "Concentracion";
            grdStock.Columns[3].HeaderText = "Presentacion";
            grdStock.Columns[4].HeaderText = "Lote";
            grdStock.Columns[5].HeaderText = "Vencimiento";
            grdStock.Columns[6].HeaderText = "Total";
            grdStock.Columns[7].HeaderText = "Alerta";

            loadAlertValue();
            loadAlertExpireDate();
            alertList=con.getAlerts(id_base);

            elementModels = false;
            deadline = DateTime.Today;
            deadline = deadline.AddMonths(3);

            if (grdStock.Rows.Count != 0)
            {
                index = 0;
                for (int i = index; i < grdStock.Rows.Count; i++)
                {
                    if (grdStock.Rows[i].Cells[7].Value.ToString() != "")
                    {
                        foreach(ElementToAlert element in alertList) {
                            if (element.BarCode== grdStock.Rows[i].Cells[0].Value.ToString() && element.Name== grdStock.Rows[i].Cells[1].Value.ToString())
                            {
                                grdStock.Rows[i].Cells[8].Value = true;
                                grdStock.Rows[i].Cells[8].Style.BackColor = Color.Red;
                                addNewCart(i, 1, 3, 2, 7);
                            }
                        }
                    }
                }
                for (int i = 0; i < grdStock.Rows.Count; i++)
                {
                    DateTime expireDate;
                    DateTime.TryParse(grdStock.Rows[i].Cells[5].Value.ToString(),out expireDate);

                    if (expireDate <= deadline)
                    {
                        grdStock.Rows[i].Cells[9].Value = true;
                        grdStock.Rows[i].Cells[9].Style.BackColor = Color.Red;
                        if (DateTime.Now > expireDate)
                        {
                            expiredElement(i, 1, 3, 2, 5);
                        }
                    }
                }
            }
            btnBuyOrder.Enabled = true;
            btnExpiredElements.Enabled = true;
            noSortGrid();
        }

        private void btnElementModels_Click(object sender, EventArgs e)
        {
            elementToBuyList = new List<ElementToBuy>();
            btnExpiredElements.Enabled = false;
            btnBuyOrder.Enabled = true;
            btnReport.Enabled = true;
            reportOrigin = "btnElementModels";
            int id_base = Convert.ToInt32(cmbBase.SelectedValue);
            if (allElements)
            {
                id_elementModel = -1;
            }
            else
            {
                id_elementModel = Convert.ToInt32(cmbElement.SelectedValue);
            }

            cleanDataGridView();
            grdStock.DataSource = con.consultStocByElement(id_base, id_elementModel);
            grdStock.Columns[0].HeaderText = "Elemento";
            grdStock.Columns[1].HeaderText = "Concentracion";
            grdStock.Columns[2].HeaderText = "Presentacion";
            grdStock.Columns[3].HeaderText = "Total";
            grdStock.Columns[4].HeaderText = "Alerta";

            loadAlertValue();
            elementModels = true;

            if (grdStock.Rows.Count != 0)
            {
                for (int i = 0; i < grdStock.Rows.Count; i++)
                {
                    if (grdStock.Rows[i].Cells[4].Value.ToString() != "")
                    {
                        if (Convert.ToInt32(grdStock.Rows[i].Cells[3].Value) <= Convert.ToInt32(grdStock.Rows[i].Cells[4].Value))
                        {
                            grdStock.Rows[i].Cells[5].Value = true;
                            grdStock.Rows[i].Cells[5].Style.BackColor = Color.Red;
                            addNewCart(i, 0, 2, 1, 4);
                        }
                    }
                }
            }
            noSortGrid();
        }

        private void addNewCart(int row, int name, int presentation, int concentration, int alert)
        {
            elementToBuy = new ElementToBuy();
            elementToBuy.ElementName = grdStock.Rows[row].Cells[name].Value.ToString();
            elementToBuy.Presentation = grdStock.Rows[row].Cells[presentation].Value.ToString();
            elementToBuy.Concentration = grdStock.Rows[row].Cells[concentration].Value.ToString();
            if (grdStock.Rows[row].Cells[alert].Value.ToString() != "")
            {
                elementToBuy.Quantity = Convert.ToInt32(grdStock.Rows[row].Cells[alert].Value) * 2;
            }
            else
            {
                elementToBuy.Quantity = 0;
            }
            elementToBuy.PriceOrder = "";

            bool exists = elementToBuyList.Any(x => x.ElementName.Equals(elementToBuy.ElementName) && x.Presentation.Equals(elementToBuy.Presentation) && x.Concentration.Equals(elementToBuy.Concentration));

            if (!exists)
            {
                elementToBuyList.Add(elementToBuy);
            }
        }

        private void expiredElement(int row, int name, int presentation, int concentration, int expireDate)
        {
            ElementToBuy expiredElement = new ElementToBuy();
            expiredElement.ElementName = grdStock.Rows[row].Cells[name].Value.ToString();
            expiredElement.Presentation = grdStock.Rows[row].Cells[presentation].Value.ToString();
            expiredElement.Concentration = grdStock.Rows[row].Cells[concentration].Value.ToString();
            expiredElement.Quantity = Convert.ToInt32(grdStock.Rows[row].Cells[6].Value); 
            expiredElement.PriceOrder = "";

            try {
                expiredElement.ExpireDate = Convert.ToDateTime(grdStock.Rows[row].Cells[expireDate].Value.ToString());
            }
            catch
            {
                expiredElement.ExpireDate = DateTime.Today;
            }

            bool exists = expiredList.Any(x => x.ElementName.Equals(expiredElement.ElementName) && x.Presentation.Equals(expiredElement.Presentation) && x.Concentration.Equals(expiredElement.Concentration));

            if (!exists)
            {
                expiredList.Add(expiredElement);
            }
        }


        private void loadAlertValue()
        {
            DataGridViewCheckBoxColumn quantityAlert = new DataGridViewCheckBoxColumn();
            quantityAlert.HeaderText = "Valor Critico";
            quantityAlert.Name = "criticValue";
            grdStock.Columns.Add(quantityAlert);
        }

        private void loadAlertExpireDate()
        {
            DataGridViewCheckBoxColumn ExpireDateAlert = new DataGridViewCheckBoxColumn();
            ExpireDateAlert.HeaderText = "Pronto a Vencer";
            ExpireDateAlert.Name = "expireDate";
            grdStock.Columns.Add(ExpireDateAlert);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            cleanForm();
        }

        private void cleanForm()
        {
            allElements = false;
            chkAllElements.Checked = false;
            cmbElement.SelectedValue = 1;
            cmbBase.SelectedValue = 1;
            dtpSince.Value = DateTime.Now;
            dtpUntil.Value = DateTime.Now;
            btnExpiredElements.Enabled = false;
            btnBuyOrder.Enabled = false;
            btnReport.Enabled = false;
            reportOrigin = String.Empty;
            cleanDataGridView();
        }

            public void cleanDataGridView()
        {
            grdStock.DataSource = null;
            if (grdStock.Columns.Contains("criticValue"))
            {
                grdStock.Columns.Remove("criticValue");
            }

            if (grdStock.Columns.Contains("expireDate"))
            {
                grdStock.Columns.Remove("expireDate");
            }

            grdStock.Refresh();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnExpiredElements_Click(object sender, EventArgs e)
        {
            FrmExpiredElementsReport frmExpiredElementsReport= new FrmExpiredElementsReport(expiredList);
            frmExpiredElementsReport.Show();
        }

        private void btnTrace_Click(object sender, EventArgs e)
        {
            btnExpiredElements.Enabled = false;
            btnReport.Enabled = true;
            btnBuyOrder.Enabled = false;
            sql = String.Empty;
            reportOrigin = "btnTrace";
            btnBuyOrder.Enabled = false;
            if (dtpSince.Value > dtpUntil.Value || dtpSince.Value > DateTime.Now)
            {
                    MessageBox.Show("Fechas invalidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            else
            {
                int id_base = Convert.ToInt32(cmbBase.SelectedValue);

                sql = "select em.name as elementName, e.lot, e.barCode, e.expireDate,p.name as providerName, s.quantity, s.entryDate, s.remit from stock as s inner join element e on e.id_element = s.id_element inner join provider p on p.id_provider = s.id_provider inner join elementModel em on em.id_elementModel = e.id_elementModel where s.id_stock in (select s.id_stock where s.id_base= " + id_base+ ") and s.quantity > 0 and s.entryDate>'"+ dtpSince.Value + "' and s.entryDate<'"+ dtpUntil.Value + "'";

                if (!allElements)
                {
                    id_elementModel = Convert.ToInt32(cmbElement.SelectedValue);
                    sql = sql + " and s.id_element in(select e.id_element where e.id_elementModel= " + id_elementModel + ") order by s.entryDate";
                }
                else
                {
                    sql = sql + " order by s.entryDate";
                }
                cleanDataGridView();
                grdStock.DataSource = con.genericConsult("stock", sql);

                grdStock.RowHeadersVisible = false;

                grdStock.Columns[0].HeaderText = "Nombre";
                grdStock.Columns[1].HeaderText = "Lote";
                grdStock.Columns[2].HeaderText = "Codigo de Barras";
                grdStock.Columns[3].HeaderText = "Vencimiento";
                grdStock.Columns[4].HeaderText = "Proveedor";
                grdStock.Columns[5].HeaderText = "Cantidad";
                grdStock.Columns[6].HeaderText = "Ingreso";
                grdStock.Columns[7].HeaderText = "Remito";

                grdStock.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                grdStock.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";

                grdStock.Columns[0].Width = 300;
                grdStock.Columns[1].Width = 150;
                grdStock.Columns[2].Width = 250;
                grdStock.Columns[3].Width = 70;
                grdStock.Columns[4].Width = 200;
                grdStock.Columns[5].Width = 70;
                grdStock.Columns[6].Width = 70;
                grdStock.Columns[7].Width = 150;
            }
        }

        private void lblReport_Click(object sender, EventArgs e)
        {
            elementsToReport = new List<StockList>();
            stockLists = new List<StockList>();
            StockList elementToReport;
            int elementName;
            int concentration;
            int presentation;
            int quantity;
            int lot;
            int barCode;
            int expireDate;
            int providerName;
            int entrydate;
            int remit;

            switch (reportOrigin)
            {
                case "btnProcess":
                    elementName = 1;
                    concentration = 2;
                    presentation = 3;
                    quantity = 6;
                    lot = 4;
                    barCode = 0;
                    expireDate = 5;
                    foreach (DataGridViewRow row in grdStock.Rows)
                    {
                        elementToReport = new StockList();

                        elementToReport.ElementName = row.Cells[elementName].Value.ToString()+" "+ row.Cells[concentration].Value.ToString();
                        elementToReport.Quantity = Convert.ToInt32(row.Cells[quantity].Value);
                        elementToReport.ExpireDate = Convert.ToDateTime(row.Cells[expireDate].Value.ToString());
                        elementToReport.BarCode = row.Cells[barCode].Value.ToString();
                        elementToReport.Lot = row.Cells[lot].Value.ToString();
                        elementToReport.OperativeBase = cmbBase.Text.ToLower();
                        elementsToReport.Add(elementToReport);
                    }
                        FrmBaseStockReport frmBaseStockReport = new FrmBaseStockReport(cmbBase.Text.ToLower(), elementsToReport);
                        frmBaseStockReport.Show();
                     break;

                case "btnElementModels":
                    elementName = 0;
                    concentration = 1;
                    presentation = 2;
                    quantity = 3;
                    foreach (DataGridViewRow row in grdStock.Rows)
                    {
                        elementToReport = new StockList();

                        elementToReport.ElementName = row.Cells[elementName].Value.ToString() + " " + row.Cells[presentation].Value.ToString() + " " + row.Cells[concentration].Value.ToString();
                        elementToReport.Quantity = Convert.ToInt32(row.Cells[quantity].Value);
                        elementsToReport.Add(elementToReport);
                    }

                    FrmBaseElementModelReport frmBaseElementModelReport = new FrmBaseElementModelReport(cmbBase.Text.ToLower(), elementsToReport);
                    frmBaseElementModelReport.Show();

                    break;

                case "btnTrace":
                    elementName =0;
                    quantity =5;
                    lot =1;
                    barCode =2;
                    expireDate =3;
                    providerName =4;
                    entrydate =6;
                    remit =7;
                    foreach (DataGridViewRow row in grdStock.Rows)
                    {
                        elementToReport = new StockList();

                        elementToReport.ElementName = row.Cells[elementName].Value.ToString();
                        elementToReport.Quantity = Convert.ToInt32(row.Cells[quantity].Value);
                        elementToReport.ExpireDate = Convert.ToDateTime(row.Cells[expireDate].Value.ToString());
                        elementToReport.BarCode = row.Cells[barCode].Value.ToString();
                        elementToReport.Lot = row.Cells[lot].Value.ToString();
                        elementToReport.ProviderName = row.Cells[providerName].Value.ToString();
                        elementToReport.EntryDate = Convert.ToDateTime(row.Cells[entrydate].Value.ToString());
                        elementToReport.Remit = row.Cells[remit].Value.ToString();
                        elementToReport.OperativeBase = cmbBase.Text.ToLower();

                        elementsToReport.Add(elementToReport);
                    }
                    FrmElementTraceReport frmElementTraceReport = new FrmElementTraceReport(cmbBase.Text.ToLower(),dtpSince.Value, dtpUntil.Value, elementsToReport);
                    frmElementTraceReport.Show();
                    /*FrmElementTraceReport
                    RptElementTrace
                    */
                    break;

                default:
                    return;
            }
        }

        private void noSortGrid()
        {
            foreach (DataGridViewColumn column in grdStock.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void btnBuyOrder_Click(object sender, EventArgs e)
        {
            String OperativeBase = cmbBase.Text.ToString();
            if((elementToBuyList == null || elementToBuyList.Count == 0))
            {
                btnProcess_Click(sender, e);
            }
            FrmNewCart frmNewCart = new FrmNewCart(elementToBuyList, OperativeBase);
            frmNewCart.Show();
        }
    }
}
