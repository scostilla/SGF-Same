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
using Views.NewForms;

namespace Views.Lists
{
    public partial class FrmUsersList : Form
    {
        int id,selectedRow;
        DBConexion con = new DBConexion();
        public FrmUsersList()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmUsersList_Load(object sender, EventArgs e)
        {
            grdUsers.DataSource = con.consultTable("users");

            grdUsers.RowHeadersVisible = false;
            grdUsers.Columns[2].Visible = false;
            grdUsers.Columns[7].Visible = false;
            grdUsers.Columns[8].Visible = false;
            grdUsers.Columns[9].Visible = false;
            grdUsers.Columns[10].Visible = false;

            grdUsers.Columns[0].HeaderText = "ID";
            grdUsers.Columns[1].HeaderText = "Usuario";
            grdUsers.Columns[3].HeaderText = "Nombre";
            grdUsers.Columns[4].HeaderText = "Apellido";
            grdUsers.Columns[5].HeaderText = "Rol";
            grdUsers.Columns[6].HeaderText = "Activo";
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            AuxiliarUser auxiliarUser = new AuxiliarUser();
            auxiliarUser.Id = (int)grdUsers.Rows[selectedRow].Cells[0].Value;
            auxiliarUser.UserName= grdUsers.Rows[selectedRow].Cells[1].Value.ToString();
            auxiliarUser.Pass = grdUsers.Rows[selectedRow].Cells[2].Value.ToString();
            auxiliarUser.Name = grdUsers.Rows[selectedRow].Cells[3].Value.ToString();
            auxiliarUser.LastName = grdUsers.Rows[selectedRow].Cells[4].Value.ToString();
            auxiliarUser.UserRole = grdUsers.Rows[selectedRow].Cells[5].Value.ToString();
            auxiliarUser.ActiveUser = grdUsers.Rows[selectedRow].Cells[6].Value.ToString();

            FrmNewUser frmNewUser = new FrmNewUser(auxiliarUser);
            frmNewUser.ShowDialog();
            FrmUsersList_Load(sender, e);

            //crear un auxiliarUser con los datos del usuario seleccionado 
            //desde los datos de las celdas!!!!!!!!!!!!!!!!!!!!!
            //y mandarlo
        }

        private void grdUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            id = Convert.ToInt32(grdUsers.Rows[e.RowIndex].Cells[0].Value.ToString());
            selectedRow = e.RowIndex;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmNewUser frmNewUser = new FrmNewUser(false);
            frmNewUser.ShowDialog();
            FrmUsersList_Load(sender, e);
        }
    }
}
