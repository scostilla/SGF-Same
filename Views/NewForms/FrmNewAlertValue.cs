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

namespace Views.NewForms
{
    public partial class FrmNewAlertValue : Form
    {
        public FrmNewAlertValue()
        {
            InitializeComponent();
        }
        DBConexion con = new DBConexion();
        AlertValue alertValue;
        String sql, successMessage, ErrorMessage;

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmNewAlertValue_Load(object sender, EventArgs e)
        {
            cmbBase.DataSource = con.consultTable("base");
            cmbBase.DisplayMember = "name";
            cmbBase.ValueMember = "id_base";
            cmbBase.SelectedValue = 1;

            cmbElement.DataSource = con.consultElement("elementModel");
            cmbElement.DisplayMember = "elementName";
            cmbElement.ValueMember = "id_elementModel";
            cmbElement.SelectedValue = 1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cleanForm();
        }

        private void btnSetAlertValue_Click(object sender, EventArgs e)
        {
            sql = "";
            string sqlFormattedDate = DateTime.Now.ToString("yyyy-MM-dd");
            alertValue = new AlertValue();
            alertValue = con.consultAlertValue((int)cmbBase.SelectedValue,(int)cmbElement.SelectedValue);

            if (alertValue.Id > 0)
            {
                DialogResult dialogResult = MessageBox.Show("El valor de alerta ya existe, desea modificarlo?", "Advertencia", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    sql = "UPDATE alertValue SET id_base='" + (int)cmbBase.SelectedValue+ "', id_elementModel='" + (int)cmbElement.SelectedValue+ "', quantity='"+ (int)nbrQuantity.Value + "', id_updater='" + User.Id + "', update_date='" + sqlFormattedDate + "' WHERE id_alertValue='" + alertValue.Id+"'";
                    successMessage = "Elemento modificado correctamente";
                    ErrorMessage = "Error al intentar modificar el Elemento";
                }
            }
            else
            {
                sql = "INSERT INTO alertValue (id_base,id_elementModel,quantity,id_creator,creation_date) VALUES('" + (int)cmbBase.SelectedValue+"','"+ (int)cmbElement.SelectedValue +"','"+(int)nbrQuantity.Value+ "','" + User.Id + "','" + sqlFormattedDate + "')";
                successMessage = "Elemento agregado correctamente";
                ErrorMessage = "Error al agregar el elemento";
            }
            addNewAlert(sql);
        }

        void addNewAlert(String sql)
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
        }

        public void cleanForm()
        {
            cmbBase.SelectedValue = 1;
            cmbElement.SelectedValue = 1;
            nbrQuantity.Value = 0;
        }
    }
}
