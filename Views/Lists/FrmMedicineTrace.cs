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

namespace Views.Lists
{
    public partial class FrmMedicineTrace : Form
    {
        DBConexion con = new DBConexion();
        String sql;
        int id, idElement;

        public FrmMedicineTrace()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lblElement_Load(object sender, EventArgs e)
        {
            cmbProvider.DataSource = con.consultSortTable("provider", "name");
            cmbProvider.DisplayMember = "name";
            cmbProvider.ValueMember = "id_provider";
            cmbProvider.SelectedItem = null;

            dtpSince.Format = DateTimePickerFormat.Custom;
            dtpSince.CustomFormat = "dd/MM/yyyy";
            dtpUntil.Format = DateTimePickerFormat.Custom;
            dtpUntil.CustomFormat = "dd/MM/yyyy";

            dtpSince.Enabled = false;
            dtpUntil.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sql = String.Empty;

            if (txtElement.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar el nombre del elemento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sql = "select s.id_stock as operationalGridId, em.name as elementName, p.name as providerName, s.lot, s.entryDate, s.remit from stock as s inner join provider p on p.id_provider = s.id_provider inner join element e on e.id_element = s.id_element inner join elementModel em on em.id_elementModel = e.id_elementModel  where e.id_element in(select id_element from element where id_elementModel in (select id_elementModel from elementModel where name LIKE '%" + txtElement.Text + "%'))";

                if (cmbProvider.SelectedItem != null)
                {
                    sql = sql + " and p.id_provider=" + cmbProvider.SelectedValue;
                }

                if (txtLot.Text != String.Empty)
                {
                    sql = sql + " and s.lot='"+ txtLot.Text + "'";
                }

                if (chkDates.Checked)
                {
                    if(dtpSince.Value > dtpUntil.Value || dtpSince.Value > DateTime.Now)
                    {
                        MessageBox.Show("Fechas invalidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    sql = sql + " and s.entryDate>='" + dtpSince.Value.Date.ToString("yyyy-MM-dd") + "' and s.entryDate<='" + dtpUntil.Value.Date.ToString("yyyy-MM-dd") + "'";
                }
                sql = sql + " order by s.entryDate";
                grdElement.DataSource = con.genericConsult("stock", sql);
                grdElement.RowHeadersVisible = false;
                grdElement.Columns[0].Visible = false;

                grdElement.Columns[1].HeaderText = "Nombre";
                grdElement.Columns[2].HeaderText = "Proveedor";
                grdElement.Columns[3].HeaderText = "Lote";
                grdElement.Columns[4].HeaderText = "Ingreso";
                grdElement.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
                grdElement.Columns[5].HeaderText = "Remito";

                grdElement.Columns[1].Width = 300;
                grdElement.Columns[2].Width = 200;
                grdElement.Columns[3].Width = 150;
                grdElement.Columns[4].Width = 70;
                grdElement.Columns[5].Width = 150;
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            cleanForm();
        }

        private void cleanForm()
        {
            cmbProvider.SelectedItem = null;
            dtpSince.Value = DateTime.Now;
            dtpUntil.Value = DateTime.Now;
            txtElement.Text = "";
            txtLot.Text = "";
            grdElement.DataSource = null;
            grdTraceability.DataSource = null;
            chkDates.Checked = false;
        }

        private void chkDates_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDates.Checked)
            {
                dtpSince.Enabled = true;
                dtpUntil.Enabled = true;
            }
            else
            {
                dtpSince.Enabled = false;
                dtpUntil.Enabled = false;
            }
        }

        private void txtElement_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void cmbProvider_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtLot_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void chkDates_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void dtpSince_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void dtpUntil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void grdElement_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
             * guardar el operationalGridId del elemento seleccionado y en base a eso conseguir el operationalGridId del elemento. con el operationalGridId del elemento mostrar todos los movimientos del mismo
             */
            idElement = -1;
            sql = String.Empty;

            if (e.RowIndex == -1) return;
            id = Convert.ToInt32(grdElement.Rows[e.RowIndex].Cells[0].Value.ToString());

            try
            {
                idElement = (int)con.getValue("stock", "id_element", "id_stock = " + id);
            }
            catch (NullReferenceException ex)
            {
                idElement = -1;
            }

            sql = "select s.id_stock,em.name as elementName, e.lot, e.barCode, e.expireDate,p.name as providerName, b.name, s.quantity,s.entryDate, s.remit from stock as s inner join element e on e.id_element = s.id_element inner join provider p on p.id_provider = s.id_provider inner join base b on b.id_base = s.id_base inner join elementModel em on em.id_elementModel = e.id_elementModel where s.id_stock in (select s.id_stock where s.id_element = "+idElement+") order by s.entryDate ";
            grdTraceability.DataSource = con.genericConsult("stock", sql);
            grdTraceability.RowHeadersVisible = false;
            grdTraceability.Columns[0].Visible = false;

            grdTraceability.Columns[1].HeaderText = "Nombre";
            grdTraceability.Columns[2].HeaderText = "Lote";
            grdTraceability.Columns[3].HeaderText = "Codigo de Barras";
            grdTraceability.Columns[4].HeaderText = "Vencimiento";
            grdTraceability.Columns[5].HeaderText = "Proveedor";
            grdTraceability.Columns[6].HeaderText = "Base";
            grdTraceability.Columns[7].HeaderText = "Cantidad";
            grdTraceability.Columns[8].HeaderText = "Ingreso";
            grdTraceability.Columns[9].HeaderText = "Remito";

            grdTraceability.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            grdTraceability.Columns[8].DefaultCellStyle.Format = "dd/MM/yyyy";

            grdTraceability.Columns[1].Width = 300;
            grdTraceability.Columns[2].Width = 150;
            grdTraceability.Columns[3].Width = 250;
            grdTraceability.Columns[4].Width = 70;
            grdTraceability.Columns[5].Width = 200;
            grdTraceability.Columns[6].Width = 200;
            grdTraceability.Columns[7].Width = 70;
            grdTraceability.Columns[8].Width = 70;
            grdTraceability.Columns[9].Width = 150;

        }
    }
}
