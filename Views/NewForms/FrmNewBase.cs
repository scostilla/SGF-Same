using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Views.Lists;

namespace Views.NewForms
{
    public partial class FrmNewBase : Form
    {
        OperativeBase operativeBase = new OperativeBase();
        bool upDate;
        String sql, successMessage, ErrorMessage;

        public FrmNewBase(OperativeBase operativeBase)
        {
            InitializeComponent();
            upDate = false;
            if (operativeBase.Id != 0)
            {
                upDate = true;
                lblTitle.Text = "Modificar Base Operativa";
                this.operativeBase = operativeBase;
            }

            txtBaseName.Text = operativeBase.BaseName;
            txtLocality.Text = operativeBase.Locality;
            txtAddress.Text = operativeBase.Address;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        DBConexion con = new DBConexion();

        private void cleanForm()
        {
            txtBaseName.Text = String.Empty;
            txtLocality.Text = String.Empty;
            txtAddress.Text = String.Empty;
            operativeBase = new OperativeBase();
            lblTitle.Text = "Nueva Base Operativa";
            upDate = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cleanForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sqlFormattedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");

            if (upDate)
            {
                sql = "UPDATE base SET name='" + txtBaseName.Text + "', locality='" + txtLocality.Text + "', address='" + txtAddress.Text + "', id_updater='" + User.Id + "', update_date='" + sqlFormattedDate + "' WHERE id_base=" + operativeBase.Id;
                successMessage = "Base modificada correctamente";
                ErrorMessage = "Error al intentar modificar la Base";
            }
            else
            {
                sql = "INSERT INTO base (name, locality, address,id_creator,creation_date) VALUES ('" + txtBaseName.Text + "','" + txtLocality.Text + "','" + txtAddress.Text + "','" + User.Id + "','" + sqlFormattedDate + "')";
                successMessage = "Base agregada correctamente";
                ErrorMessage = "Error al agregar la Base";
            }
            addNewBase(sql);
        }

        void addNewBase(String sql)
        {
            if (con.insert(sql))
            {
                MessageBox.Show(successMessage);
                cleanForm();
            }
            else
            {
                MessageBox.Show(ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Dispose();
        }
    }
}
