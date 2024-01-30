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
using Views.NewForms;

namespace Views.Lists
{
    public partial class FrmProviderList : Form
    {
        public FrmProviderList()
        {
            InitializeComponent();
        }

        DBConexion con = new DBConexion();
        int id;
        String sql;
        Provider provider = new Provider();


        private void FrmProviderList_Load(object sender, EventArgs e)
        {
            grdProviders.DataSource = con.consultTable("provider");

            grdProviders.RowHeadersVisible = false;
            grdProviders.AllowUserToAddRows = false;
            grdProviders.Columns[0].Visible = false;
            grdProviders.Columns[4].Visible = false;
            grdProviders.Columns[5].Visible = false;
            grdProviders.Columns[6].Visible = false;
            grdProviders.Columns[7].Visible = false;
            grdProviders.Columns[1].Width = 200;
            grdProviders.Columns[2].Width = 200;
            grdProviders.Columns[3].Width = 200;
            grdProviders.Columns[1].HeaderText = "Nombre";
            grdProviders.Columns[2].HeaderText = "Provincia";
            grdProviders.Columns[3].HeaderText = "Domicilio";
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmNewProvider frmNewProvider = new FrmNewProvider(new Provider());
            frmNewProvider.ShowDialog();
            FrmProviderList_Load(sender, e);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            provider.Id = (int)grdProviders.CurrentRow.Cells[0].Value;
            provider.Name = grdProviders.CurrentRow.Cells[1].Value.ToString();
            provider.Province = grdProviders.CurrentRow.Cells[2].Value.ToString();
            provider.Address = grdProviders.CurrentRow.Cells[3].Value.ToString();

            FrmNewProvider frmNewProvider = new FrmNewProvider(provider);
            frmNewProvider.ShowDialog();
            FrmProviderList_Load(sender, e);
        }

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            id = Convert.ToInt32(grdProviders.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirmDelete = MessageBox.Show("Esta Seguro de Eliminar el Elemento?", "Eliminar Elemento", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
                sql = "id_provider=" + id;
                con.remove("provider", sql);
            }
            FrmProviderList_Load(sender, e);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {/*
            FrmBaseReport frmBaseReport = new FrmBaseReport();
            frmBaseReport.Show();*/
        }
    }
}
