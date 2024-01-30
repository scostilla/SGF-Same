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
    public partial class FrmStockList : Form
    {
        public FrmStockList()
        {
            InitializeComponent();
        }

        DBConexion con = new DBConexion();
        bool allBases, allElements;
        int stockId;
        String sql, rowFilter;
        List<StockList> stockList = new List<StockList>();

        private void FrmStockList_Load(object sender, EventArgs e)
        {
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

            cmbBase.DataSource = con.consultTable("base");
            cmbBase.DisplayMember = "name";
            cmbBase.ValueMember = "id_base";
            cmbBase.SelectedValue = 1;

            cmbElement.DataSource = con.consultElement("elementModel");
            cmbElement.DisplayMember = "elementName";
            cmbElement.ValueMember = "id_elementModel";
            cmbElement.SelectedValue = 1;
            
            nbrYear.Value = DateTime.Today.Year;
            allElements = false;
            allBases = false;
        }

        private void chkAllBasesChange(object sender, EventArgs e)
        {
            if (chkAllBases.Checked)
            {
                allBases = true;
                cmbBase.Enabled = false;
            }
            else
            {
                allBases = false;
                cmbBase.Enabled = true;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            sql = string.Empty;
            int id_base=Convert.ToInt32(cmbBase.SelectedValue);
            int id_element= Convert.ToInt32(cmbElement.SelectedValue);
            int month = Convert.ToInt32(cmbMonth.SelectedValue);
            int year= (int)nbrYear.Value;

            sql = "select st.id_stock, pr.name providerName, emo.name, st.lot, ba.name baseName, st.remit, st.entryDate, st.quantity, st.expireDate from stock st left join provider pr on pr.id_provider = st.id_provider left join base ba on ba.id_base = st.id_base left join element el left join elementModel emo on emo.id_elementModel = el.id_elementModel on el.id_element = st.id_element where MONTH(st.entryDate)=" + month + " and YEAR(st.entryDate)=" + year;

            if (!allElements)
            {
                sql += " and emo.id_elementModel='" + id_element + "'";
            }
            if (!allBases)
            {
                sql += " and ba.id_base='" + id_base + "'";
            }
            
            grdStock.DataSource = con.genericConsult("stock",sql);
            //stockElement = grdStock.DataSource as List<StockList>;

            grdStock.RowHeadersVisible = false;
            grdStock.AllowUserToAddRows = false;
            grdStock.Columns[0].Visible = false;
            //grdStock.Columns[8].Visible = false;

            grdStock.Columns[1].HeaderText = "Proveedor";
            grdStock.Columns[2].HeaderText = "Elemento";
            grdStock.Columns[3].HeaderText = "Lote";
            grdStock.Columns[4].HeaderText = "Base";
            grdStock.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            grdStock.Columns[5].HeaderText = "Remito";
            grdStock.Columns[6].HeaderText = "Ingreso";
            grdStock.Columns[7].HeaderText = "Cantidad";
            grdStock.Columns[8].HeaderText = "Vencimiento";

            grdStock.Columns[1].Width = 200;
            grdStock.Columns[2].Width = 300;
            grdStock.Columns[3].Width = 150;
            grdStock.Columns[4].Width = 100;
            grdStock.Columns[5].Width = 150;
            grdStock.Columns[6].Width = 70;
            grdStock.Columns[7].Width = 55;

        }

        private void grdStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            stockId = Convert.ToInt32(grdStock.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void txtProviderFilter_TextChanged(object sender, EventArgs e)
        {
            filters();
        }

        private void txtElementFilter_TextChanged(object sender, EventArgs e)
        {
            filters();
        }

        private void txtLotFilter_TextChanged(object sender, EventArgs e)
        {
            filters();
        }

        private void txtRemitFilter_TextChanged(object sender, EventArgs e)
        {
            filters();
        }

        private void txtOperativeBaseFilter_TextChanged(object sender, EventArgs e)
        {
            filters();
        }

        private void filters()
        {
            rowFilter = string.Format("providerName LIKE '%{0}%'", txtProviderFilter.Text);
            rowFilter += string.Format(" AND name LIKE '%{0}%'", txtElementFilter.Text);
            rowFilter += string.Format(" AND lot LIKE '%{0}%'", txtLotFilter.Text);
            rowFilter += string.Format(" AND remit LIKE '%{0}%'", txtRemitFilter.Text);
            rowFilter += string.Format(" AND baseName LIKE '%{0}%'", txtOperativeBaseFilter.Text);

            (grdStock.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            cleanForm();
        }


        private void cleanForm()
        {
            nbrYear.Value = DateTime.Today.Year;
            allElements = false;
            allBases = false;
            chkAllBases.Checked = false;
            chkAllElements.Checked = false;
            cmbElement.SelectedValue = 1;
            cmbBase.SelectedValue = 1;
            cmbMonth.SelectedValue = "1";
            rowFilter = String.Empty;
            txtProviderFilter.Text = String.Empty;
            txtElementFilter.Text = String.Empty;
            txtLotFilter.Text = String.Empty;
            txtRemitFilter.Text = String.Empty;
            txtOperativeBaseFilter.Text = String.Empty;
            grdStock.DataSource = null;
            grdStock.Refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmNewStock frmNewStock = new FrmNewStock(stockId);
            frmNewStock.Show();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            FrmStockDetail frmStockDetail = new FrmStockDetail(stockId);
            frmStockDetail.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdStock.Rows)
            {
                StockList element = new StockList();
                element.ProviderName = row.Cells[1].Value.ToString();
                element.ElementName = row.Cells[2].Value.ToString();
                element.Lot = row.Cells[3].Value.ToString();
                
                try{
                    element.ExpireDate = Convert.ToDateTime(row.Cells[8].Value);
                }catch
                {
                    element.ExpireDate = DateTime.Now;
                }/*
                try
                {
                    element.BarCode = row.Cells[9].Value.ToString();
                }
                catch
                {
                    element.BarCode = "";

                }*/
                element.Quantity = Convert.ToInt32(row.Cells[7].Value);
                element.OperativeBase = row.Cells[4].Value.ToString();
                element.EntryDate = Convert.ToDateTime(row.Cells[6].Value);
                element.Remit = row.Cells[5].Value.ToString();

                stockList.Add(element);
            }

            FrmStockListReport frmStockListReport = new FrmStockListReport("Listado de Stock",false,stockList);
            frmStockListReport.Show();
            cleanForm();
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
    }
}
