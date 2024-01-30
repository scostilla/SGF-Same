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
    public partial class FrmAlertValuesList : Form
    {
        public FrmAlertValuesList()
        {
            InitializeComponent();
        }

        DBConexion con = new DBConexion();
        bool allElements;

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

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (allElements)
            {
                grdAlertValues.DataSource = con.consultAlertValues((int)cmbBase.SelectedValue,-1);
            }
            else
            {
                grdAlertValues.DataSource = con.consultAlertValues((int)cmbBase.SelectedValue, (int)cmbElement.SelectedValue);
            }

            grdAlertValues.RowHeadersVisible = false;
            grdAlertValues.AllowUserToAddRows = false;
            grdAlertValues.Columns[0].HeaderText = "Base";
            grdAlertValues.Columns[1].HeaderText = "Elemento";
            grdAlertValues.Columns[2].HeaderText = "Concentracion";
            grdAlertValues.Columns[3].HeaderText = "Presentacion";
            grdAlertValues.Columns[4].HeaderText = "Alerta";
        }

        private void FrmAlertValuesList_Load(object sender, EventArgs e)
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
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            allElements = false;
            chkAllElements.Checked = false;
            cmbElement.SelectedValue = 1;
            cmbBase.SelectedValue = 1;
            grdAlertValues.DataSource = null;
            grdAlertValues.Refresh();
        }
    }
}
