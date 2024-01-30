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
using Views.Reports;

namespace Views.Lists
{
    public partial class FrmStockControl : Form
    {

        public FrmStockControl()
        {
            InitializeComponent();
        }

        DBConexion con = new DBConexion();
        StockList stockElement;
        List<StockList> stockList, auxStockList;
        String sql, reportTitle;
        Boolean GroupByElement=false;

        private void FrmStockControl_Load(object sender, EventArgs e)
        {
            nbrYear.Value = DateTime.Today.Year;
            Dictionary<string, string> cmbValues = new Dictionary<string, string>();
            cmbValues.Add("1", "Enero");
            cmbValues.Add("2", "Febrero");
            cmbValues.Add("3", "Marzo");
            cmbValues.Add("4", "Abril");
            cmbValues.Add("5", "Mayo");
            cmbValues.Add("6", "Junio");
            cmbValues.Add("7", "Julio");
            cmbValues.Add("8", "Agosto");
            cmbValues.Add("9", "Septiembre");
            cmbValues.Add("10", "Octubre");
            cmbValues.Add("11", "Noviembre");
            cmbValues.Add("12", "Diciembre");

            cmbMonth.DataSource = new BindingSource(cmbValues, null);
            cmbMonth.DisplayMember = "Value";
            cmbMonth.ValueMember = "Key";
            cmbMonth.SelectedItem = "Enero";

            rdbFirstTrimester.Checked = true;
            rdbIn.Checked = true;
            cmbMonth.Enabled = false;
            nbrYear.Enabled = false;
            nbrYear.Enabled = true;

            grbPeriod.Controls.Add(rdbFirstTrimester);
            grbPeriod.Controls.Add(rdbSecondTrimester);
            grbPeriod.Controls.Add(rdbThirdTrimester);
            grbPeriod.Controls.Add(rdbFourthTrimester);
            grbPeriod.Controls.Add(rdbMonthly);

            grbMovement.Controls.Add(rdbIn);
            grbMovement.Controls.Add(rdbOut);
            grbMovement.Controls.Add(rdbAll);
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            cleanGrdTotals();
            GroupByElement = chkGroupByElement.Checked;
            sql = String.Empty;
            sql = "select p.name as providerName, (emo.name+' '+emo.concentration+' '+emo.presentation) as elementName, s.lot, s.expireDate, s.quantity,s.entryDate, s.remit,b.name as baseName from stock s inner join element e on s.id_element=e.id_element inner join elementModel emo on e.id_elementModel=emo.id_elementModel inner join base b on s.id_base=b.id_base full join provider p on s.id_provider=p.id_provider where s.id_stock >0 ";
            reportTitle = String.Empty;

            RadioButton rdbPeriod = this.grbPeriod.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault();
            if (rdbPeriod != null)
            {
                switch (rdbPeriod.Name)
                {
                    case "rdbFirstTrimester":
                        sql = sql+" and s.entryDate >= '"+ (int)nbrYear.Value + "-1-01' and s.entryDate <= '"+ (int)nbrYear.Value + "-3-31'";
                        reportTitle = "Primer trimestre año " + (int)nbrYear.Value;
                        break;
                    case "rdbSecondTrimester":
                        sql = sql+ " and s.entryDate >= '" + (int)nbrYear.Value + "-4-01' and s.entryDate <= '" + (int)nbrYear.Value + "-6-30'";
                        reportTitle = "Segundo trimestre año " + (int)nbrYear.Value;
                        break;
                    case "rdbThirdTrimester":
                        sql =sql+ " and s.entryDate >= '" + (int)nbrYear.Value + "-7-01' and s.entryDate <= '" + (int)nbrYear.Value + "-9-30'";
                        reportTitle = "Tercer trimestre año " + (int)nbrYear.Value;
                        break;
                    case "rdbFourthTrimester":
                        sql =sql+ " and s.entryDate >= '" + (int)nbrYear.Value + "-10-01' and s.entryDate <= '" + (int)nbrYear.Value + "-12-31'";
                        reportTitle = "Cuarto trimestre año " + (int)nbrYear.Value;
                        break;
                    case "rdbMonthly":
                        int daysInMonth = DateTime.DaysInMonth(Convert.ToInt32(nbrYear.Value.ToString()),Convert.ToInt32(cmbMonth.SelectedValue.ToString()));
                        sql =sql+ " and s.entryDate >= '" + Convert.ToInt32(nbrYear.Value.ToString()) + "-"+ Convert.ToInt32(cmbMonth.SelectedValue.ToString()) +"-01' and s.entryDate <= '" + Convert.ToInt32(nbrYear.Value.ToString()) +"-"+ Convert.ToInt32(cmbMonth.SelectedValue.ToString()) + "-" + daysInMonth + "'";
                        reportTitle = "mes de "+cmbMonth.SelectedValue+" año "+ (int)nbrYear.Value;
                        break;
                }
            }

            RadioButton rdbMovement = this.grbMovement.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault();
            if (rdbMovement != null)
            {
                switch (rdbMovement.Name)
                {
                    case "rdbIn":
                        sql = sql + " and s.inOut=0 order by s.entryDate";
                        break;
                    case "rdbOut":
                        sql = sql + " and s.inOut=1 order by s.entryDate";
                        break;
                    case "rdbAll":
                        sql = sql + "order by s.entryDate";
                        break;
                }
            }

            grdTotals.DataSource = con.genericConsult("stock", sql);

            


            foreach (DataGridViewRow row in grdTotals.Rows)
            {
                stockElement = new StockList();

                stockElement.ElementName = row.Cells[1].Value.ToString();
                stockElement.Quantity = (int)row.Cells[4].Value;
                stockElement.EntryDate = Convert.ToDateTime(row.Cells[5].Value);
                stockElement.Remit = row.Cells[6].Value.ToString();
                stockElement.BarCode = "0";

                if (GroupByElement)
                {
                    stockElement.ProviderName = "0";
                    stockElement.Lot = "0";
                    stockElement.ExpireDate = DateTime.Now;
                    if (row.Cells[7].Value.ToString() == "DEPOSITO")
                    {
                        stockElement.OperativeBase = "Ingreso";
                    }
                    else
                    {
                        stockElement.OperativeBase = "Egreso";
                    }
                }
                else
                {
                    stockElement.OperativeBase = row.Cells[7].Value.ToString();
                    stockElement.ProviderName = row.Cells[0].Value.ToString();
                    stockElement.Lot = row.Cells[2].Value.ToString();
                    try
                    {
                        stockElement.ExpireDate = Convert.ToDateTime(row.Cells[3].Value);
                    }
                    catch
                    {
                        stockElement.ExpireDate = DateTime.Now;
                    }
                }
                stockList.Add(stockElement);
            }

            if (GroupByElement == true)
            {
                for (int i = 0; i < stockList.Count; i++)
                {
                    for (int j = (i+1); j < stockList.Count; j++)
                    {
                        if (stockList[i].ElementName == stockList[j].ElementName && stockList[i].OperativeBase == stockList[j].OperativeBase)
                        {
                            stockList[i].Quantity = stockList[i].Quantity + stockList[j].Quantity;
                            stockList.RemoveAt(j);
                            j = j - 1;
                        }
                    }
                    auxStockList.Add(stockList[i]);
                }
                grdTotals.DataSource = auxStockList;
            }
            else
            {
                grdTotals.DataSource = stockList;

                grdTotals.ReadOnly = true;

                grdTotals.Columns[0].HeaderText = "Proveedor";
                grdTotals.Columns[1].HeaderText = "Elemento";
                grdTotals.Columns[2].HeaderText = "Lote";
                grdTotals.Columns[3].HeaderText = "Vencimieto";
                grdTotals.Columns[5].HeaderText = "Cantidad";
                grdTotals.Columns[6].HeaderText = "Destino";
                grdTotals.Columns[7].HeaderText = "Ingreso";
                grdTotals.Columns[4].Visible = false;
                grdTotals.Columns[8].HeaderText = "Remito";
                
                grdTotals.Columns[0].Width = 200;
                grdTotals.Columns[1].Width = 300;
                grdTotals.Columns[2].Width = 70;
                grdTotals.Columns[3].Width = 70;
                grdTotals.Columns[5].Width = 60;
                grdTotals.Columns[7].Width = 70;
                grdTotals.Columns[8].Width = 50;
                grdTotals.Columns[6].Width = 300;
            }

            if (GroupByElement == true)
            {
                grdTotals.Columns[0].Visible = false;
                grdTotals.Columns[1].HeaderText = "Elemento";
                grdTotals.Columns[2].Visible = false;
                grdTotals.Columns[3].Visible = false;
                grdTotals.Columns[4].Visible = false;
                grdTotals.Columns[5].HeaderText = "Cantidad";
                grdTotals.Columns[6].HeaderText = "Destino";
                grdTotals.Columns[7].Visible = false;
                grdTotals.Columns[8].Visible = false;
                
                grdTotals.Columns[1].Width = 300;
                grdTotals.Columns[5].Width = 60;
                grdTotals.Columns[6].Width = 70;
            }
        }

        private void rdbMonthly_CheckedChanged(object sender, EventArgs e)
        {
            cmbMonth.Enabled = rdbMonthly.Checked;
        }
        private void btnReport_Click(object sender, EventArgs e)
        {

            if (GroupByElement == false)
            {
                for (int i = 0; i < stockList.Count; i++)
                {
                    for (int j = i + 1; j < stockList.Count; j++)
                    {
                        if (stockList[i].ElementName == stockList[j].ElementName && stockList[i].OperativeBase == stockList[j].OperativeBase && stockList[i].ProviderName == stockList[j].ProviderName)
                        {
                            stockList[i].Quantity = stockList[i].Quantity + stockList[j].Quantity;
                            stockList.RemoveAt(j);
                            j = j - 1;
                        }
                    }
                }
            }

            stockList = stockList.OrderBy(o => o.ElementName).ToList();
            FrmStockListReport frmStockListReport = new FrmStockListReport("Movimiento de stock del "+reportTitle, GroupByElement, stockList);
            frmStockListReport.Show();
            CleanForm();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void CleanForm()
        {
            rdbIn.Checked = true;
            rdbFirstTrimester.Checked = true;
            cleanGrdTotals();
            chkGroupByElement.Checked = false;
            GroupByElement = false;
        }

        private void cleanGrdTotals()
        {
            sql = String.Empty;
            stockList=new List<StockList>();
            auxStockList = new List<StockList>();
            grdTotals.DataSource = null;
            grdTotals.Refresh();
        }
    }
}
