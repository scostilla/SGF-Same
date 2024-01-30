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
using Views.Reports;

namespace Views.Lists
{
    public partial class FrmElementsToExpire : Form
    {
        public FrmElementsToExpire()
        {
            InitializeComponent();
        }

        DBConexion con = new DBConexion();
        StockList stockElement;
        List<StockList> stockList;
        String sql, reportTitle;

        private void FrmElementsToExpire_Load(object sender, EventArgs e)
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
            cmbMonth.Enabled = false;
            nbrYear.Enabled = true;
        }

        

        private void btnProcess_Click(object sender, EventArgs e)
        {
            cleanGrdControlSheet();
            sql = String.Empty;
            reportTitle = String.Empty;

            RadioButton radioBtn = this.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault();
            if (radioBtn != null)
            {
                sql = "select (emo.name+' '+emo.concentration+' '+emo.presentation) as elementName, s.lot, s.expireDate, s.quantity,s.entryDate, s.remit from stock s inner join element e on s.id_element=e.id_element inner join elementModel emo on e.id_elementModel=emo.id_elementModel where s.id_stock >0 and s.id_base="+Warehouse.IdWarehouse+" and s.expireDate >= '";

                switch (radioBtn.Name)
                {
                    case "rdbFirstTrimester":
                        sql = sql + (int)nbrYear.Value + "-1-01' and s.expireDate <= '" + (int)nbrYear.Value + "-3-31'";
                        reportTitle = "Elementos a vencer el Primer trimestre de " + nbrYear.Value;
                        break;
                    case "rdbSecondTrimester":
                        sql = sql + (int)nbrYear.Value + "-3-01' and s.expireDate <= '" + (int)nbrYear.Value + "-7-31'";
                        reportTitle = "Elementos a vencer el Segundo trimestre de " + nbrYear.Value;
                        break;
                    case "rdbThirdTrimester":
                        sql = sql + (int)nbrYear.Value + "-6-01' and s.expireDate <= '" + (int)nbrYear.Value + "-10-31'";
                        reportTitle = "Elementos a vencer el Tercer trimestre de " + nbrYear.Value;
                        break;
                    case "rdbFourthTrimester":
                        sql = sql + (int)nbrYear.Value + "-9-01' and s.expireDate <= '" + (int)nbrYear.Value + "-12-31'";
                        reportTitle = "Elementos a vencer el Cuarto trimestre de " + nbrYear.Value;
                        break;
                    case "rdbMonthly":
                        sql = sql + (int)nbrYear.Value + "-" + cmbMonth.SelectedValue.ToString() + "-01' and s.expireDate <= '" + (int)nbrYear.Value + "-" + cmbMonth.SelectedValue.ToString() + "-" + DateTime.DaysInMonth((int)nbrYear.Value, Convert.ToInt32(cmbMonth.SelectedValue.ToString())) + "'";
                        reportTitle = "Elementos a vencer el mes de "+((KeyValuePair<string,string>)cmbMonth.SelectedItem).Value+" de "+nbrYear.Value;
                        break;
                    case "rdbAnnual":
                        sql = sql + (int)nbrYear.Value + "-01-01' and s.expireDate <= '" + (int)nbrYear.Value + "-12-31'";
                        reportTitle = "Elementos a vencer durante el año " + nbrYear.Value;
                        break;
                }
            }

            grdTotals.DataSource= con.genericConsult("stock", sql);

            grdTotals.Columns[0].HeaderText = "Elemento";
            grdTotals.Columns[1].HeaderText = "Lote";
            grdTotals.Columns[2].HeaderText = "Vencimiento";
            grdTotals.Columns[3].HeaderText = "Cantidad";
            grdTotals.Columns[4].HeaderText = "Ingreso";
            grdTotals.Columns[5].HeaderText = "Remito";

            grdTotals.Columns[0].Width = 300;
            grdTotals.Columns[1].Width = 100;
            grdTotals.Columns[2].Width = 70;
            grdTotals.Columns[3].Width = 50;
            grdTotals.Columns[4].Width = 70;
            grdTotals.Columns[5].Width = 70;

            btnReport.Enabled = true;
        }

        private void rdbMonthly_CheckedChanged(object sender, EventArgs e)
        {
            cmbMonth.Enabled = rdbMonthly.Checked;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            stockList = new List<StockList>();

            foreach (DataGridViewRow row in grdTotals.Rows)
            {
                stockElement = new StockList();

                stockElement.ElementName = row.Cells[0].Value.ToString();
                stockElement.Lot = row.Cells[1].Value.ToString();
                stockElement.ExpireDate = Convert.ToDateTime(row.Cells[2].Value.ToString());
                stockElement.Quantity = (int)row.Cells[3].Value;
                stockElement.EntryDate = Convert.ToDateTime(row.Cells[4].Value);
                stockElement.Remit = row.Cells[5].Value.ToString();

                stockElement.BarCode = "0";
                stockElement.ProviderName = "0";
                stockElement.OperativeBase = "Ingreso";

                stockList.Add(stockElement);
            }

            FrmElementsToExpireReport frmElementsToExpireReport = new FrmElementsToExpireReport(stockList, reportTitle);
            frmElementsToExpireReport.Show();
            cleanForm();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            cleanForm();
        }

        private void cleanForm() {
            rdbFirstTrimester.Checked = true;
            cmbMonth.Enabled = false;
            nbrYear.Enabled = true;
            nbrYear.Value = DateTime.Today.Year;
            btnReport.Enabled = false;
            cleanGrdControlSheet();
        }
        private void cleanGrdControlSheet()
        {

            for (int i = grdTotals.Rows.Count - 1; i >= 0; i--)
            {
                grdTotals.Rows.RemoveAt(i);
            }
            for (int i = grdTotals.Columns.Count - 1; i >= 0; i--)
            {
                grdTotals.Columns.RemoveAt(i);
            }
            grdTotals.DataSource = null;
            grdTotals.Refresh();
        }
    }
}
