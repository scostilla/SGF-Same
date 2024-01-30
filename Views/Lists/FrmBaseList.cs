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
    public partial class FrmBaseList : Form
    {
        public FrmBaseList()
        {
            InitializeComponent();
        }

        DBConexion con = new DBConexion();
        int id;
        String sql;
        OperativeBase operativeBase = new OperativeBase();


        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmBaseList_Load(object sender, EventArgs e)
        {
            grdBases.DataSource = con.consultTable("base");

            grdBases.RowHeadersVisible = false;
            grdBases.Columns[0].Visible = false;
            grdBases.Columns[4].Visible = false;
            grdBases.Columns[5].Visible = false;
            grdBases.Columns[6].Visible = false;
            grdBases.Columns[7].Visible = false;
            grdBases.Columns[1].Width = 200;
            grdBases.Columns[2].Width = 200;
            grdBases.Columns[3].Width = 200;
            grdBases.Columns[1].HeaderText = "Nombre";
            grdBases.Columns[2].HeaderText = "Localidad";
            grdBases.Columns[3].HeaderText = "Domicilio";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmNewBase frmNewBase = new FrmNewBase(new OperativeBase());
            frmNewBase.ShowDialog();
            frmBaseList_Load(sender, e);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            operativeBase.Id = (int)grdBases.CurrentRow.Cells[0].Value;
            operativeBase.BaseName = grdBases.CurrentRow.Cells[1].Value.ToString();
            operativeBase.Locality = grdBases.CurrentRow.Cells[2].Value.ToString();
            operativeBase.Address = grdBases.CurrentRow.Cells[3].Value.ToString();

            FrmNewBase frmNewBase = new FrmNewBase(operativeBase);
            frmNewBase.ShowDialog();
            frmBaseList_Load(sender, e);
        }

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            id = Convert.ToInt32(grdBases.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirmDelete = MessageBox.Show("Esta Seguro de Eliminar el Elemento?", "Eliminar Elemento", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
                sql = "id_base="+id;
                con.remove("base", sql);
            }
            frmBaseList_Load(sender, e);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FrmBaseReport frmBaseReport = new FrmBaseReport();
            frmBaseReport.Show();
        }
    }
}
