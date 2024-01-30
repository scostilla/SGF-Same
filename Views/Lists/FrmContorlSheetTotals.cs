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
    public partial class FrmContorlSheetTotals : Form
    {
        public FrmContorlSheetTotals()
        {
            InitializeComponent();
        }

        String sql, reportTitle;
        List<ElementQuantity> elementQuantities = new List<ElementQuantity>();
        List<String> distinctVehicles = new List<string>();
        List<String> elementsList = new List<string>();
        List<String> distinctElementsList = new List<string>();
        int totalColIndex;

        DBConexion con = new DBConexion();


        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmContorlSheetTotals_Load(object sender, EventArgs e)
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
            btnReport.Enabled = false;
        }

        private void rdbMonthly_CheckedChanged(object sender, EventArgs e)
        {
            cmbMonth.Enabled = rdbMonthly.Checked;
        }

        

        private void btnProcess_Click(object sender, EventArgs e)
        {
            cleanGrdControlSheet();
            sql = String.Empty;
            reportTitle = String.Empty;

            RadioButton radioBtn = this.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault();
            if (radioBtn != null)
            {
                sql = "select (emo.name+' '+emo.concentration+' '+emo.presentation) as Element, s.quantity as Egress, b.name as Vehicle from stock s inner join element e on s.id_element=e.id_element inner join elementModel emo on e.id_elementModel=emo.id_elementModel inner join base b on s.id_base=b.id_base where s.id_stock >0 and s.inOut=1 and s.entryDate >= '";

                switch (radioBtn.Name)
                {
                    case "rdbFirstTrimester":
                         sql = sql + (int)nbrYear.Value + "-1-01' and s.entryDate <= '" + (int)nbrYear.Value + "-3-31'";
                        reportTitle = "Primer trimestre";
                        break;
                    case "rdbSecondTrimester":
                        sql = sql +(int)nbrYear.Value + "-3-01' and s.entryDate <= '" + (int)nbrYear.Value + "-7-31'";
                        reportTitle = "Segundo trimestre";
                        break;
                    case "rdbThirdTrimester":
                        sql = sql + (int)nbrYear.Value + "-6-01' and s.entryDate <= '" + (int)nbrYear.Value + "-10-31'";
                        reportTitle = "Tercer trimestre";
                        break;
                    case "rdbFourthTrimester":
                        sql = sql + (int)nbrYear.Value + "-9-01' and s.entryDate <= '" + (int)nbrYear.Value + "-12-31'";
                        reportTitle = "Cuarto trimestre";
                        break;
                    case "rdbMonthly":
                        sql = sql + (int)nbrYear.Value + "-" + cmbMonth.SelectedValue.ToString() + "-01' and s.entryDate <= '" + (int)nbrYear.Value + "-" + cmbMonth.SelectedValue.ToString() + "-" + DateTime.DaysInMonth((int)nbrYear.Value, Convert.ToInt32(cmbMonth.SelectedValue.ToString())) + "'";
                        reportTitle = "Mensual";
                        break;
                }
            }

            bringTable(sql);
            fillDataGrid(elementQuantities);
            btnReport.Enabled = true;
        }


        private void bringTable(string sql)
        {
            DataTable dt = con.genericConsult("stock", sql);
            List<String> Vehicles = new List<string>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ElementQuantity elementQuantity = new ElementQuantity();
                if (dt.Rows.Count != 0)
                {
                    elementQuantity.IdElementQuantity = 0;
                    elementQuantity.Element = dt.Rows[i][0].ToString();
                    elementQuantity.Egress = Convert.ToInt32(dt.Rows[i][1]);
                    elementQuantity.Vehicle = dt.Rows[i][2].ToString();
                    elementQuantities.Add(elementQuantity);
                }
            }

            foreach (ElementQuantity element in elementQuantities)
            {
                Vehicles.Add(element.Vehicle);
                elementsList.Add(element.Element);
                foreach (DataGridViewRow row in grdTotals.Rows)
                {
                    if (row.Cells[0].Value.ToString() == element.Element)
                    {
                        element.IdElementQuantity = row.Index;
                    }
                }
            }

            distinctVehicles = Vehicles.Distinct().ToList();
            distinctElementsList = elementsList.Distinct().ToList();

            for(int i = 0; i < elementQuantities.Count; i++)
            {
                for(int j = i + 1; j < elementQuantities.Count; j++)
                {
                    if(elementQuantities[i].Element== elementQuantities[j].Element && elementQuantities[i].Vehicle== elementQuantities[j].Vehicle)
                    {
                        elementQuantities[i].Egress = elementQuantities[i].Egress + elementQuantities[j].Egress;
                        elementQuantities.RemoveAt(j);
                        j = i + 1;
                    }
                }
            }

            grdTotals.Columns.Add("Detail", "Elemento");
            grdTotals.Columns[0].ReadOnly = true;
            

            foreach (String vehicle in distinctVehicles)
            {
                grdTotals.Columns.Add(vehicle, vehicle);
                grdTotals.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            for (int i = 0; i < distinctElementsList.Count; i++)
            {
                grdTotals.Rows.Add();
                grdTotals.Rows[i].Cells[0].Value = distinctElementsList[i].ToString();
            }

            grdTotals.Columns.Add("total", "Total General");
            grdTotals.Columns["total"].DisplayIndex = 1;
            grdTotals.Columns[0].Frozen = true;
            grdTotals.Columns["total"].ReadOnly = true;
            grdTotals.AutoResizeColumns();
        }

        private void fillDataGrid(List<ElementQuantity> totalList)
        {
            int rowIndex = -1;
            int colIndex=-1;
            totalColIndex= grdTotals.Columns.IndexOf(grdTotals.Columns["total"]);

            for(int i = 0; i < grdTotals.RowCount; i++)
            {
                grdTotals[totalColIndex, i].Value = 0;
            }

            foreach (ElementQuantity element in totalList)
            {
                for (int i = 0; i < grdTotals.Columns.Count; i++)
                {
                    if (grdTotals.Columns[i].Name == element.Vehicle)
                    {
                        colIndex = i;
                        break;
                    }
                }

                for (int i = 0; i < grdTotals.Rows.Count; i++)
                {
                    if (grdTotals.Rows[i].Cells[0].Value.ToString() == element.Element.ToString())
                    {
                        rowIndex = i;
                        break;
                    }
                }
                grdTotals[colIndex, rowIndex].Value = element.Egress;
                grdTotals[totalColIndex, rowIndex].Value = Convert.ToInt32(grdTotals[totalColIndex, rowIndex].Value) + element.Egress;
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            List<ElementQuantity> totals = new List<ElementQuantity>();
            int reportYear = (int)nbrYear.Value;
            int reportMonth;


            for(int i = 0; i < grdTotals.RowCount; i++)
            {
                ElementQuantity elementQuantity = new ElementQuantity();
                elementQuantity.Element = grdTotals[0, i].Value.ToString();
                elementQuantity.Vehicle = grdTotals.Columns[totalColIndex].HeaderText;
                elementQuantity.Egress = Convert.ToInt32(grdTotals[totalColIndex, i].Value);
                totals.Add(elementQuantity);
            }

            if (reportTitle == "Mensual")
            {
                reportMonth = Convert.ToInt32(cmbMonth.SelectedValue);
            }
            else
            {
                reportMonth = 0;
            }

            FrmControlSheetTotalsReport frmControlSheetTotalsReport = new FrmControlSheetTotalsReport(totals, reportTitle,reportYear, reportMonth);
            frmControlSheetTotalsReport.Show();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            rdbFirstTrimester.Checked = true;
            cmbMonth.Enabled = false;
            nbrYear.Enabled = true;
            nbrYear.Value = DateTime.Today.Year;
            btnReport.Enabled = false;
            cleanGrdControlSheet();
        }

        private void cleanGrdControlSheet()
        {
            distinctVehicles = new List<string>();
            distinctElementsList = new List<string>();
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
