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
using Views;

namespace Views.NewForms
{
    public partial class FrmNewElement : Form
    {
        ElementModel elementModel = new ElementModel();
        bool upDate;
        String sql, successMessage, ErrorMessage;

        public FrmNewElement(ElementModel elementModel)
        {
            InitializeComponent();
            upDate = false;
            if (elementModel.Id != 0)
            {
                upDate = true;
                lblTitle.Text = "Modificar Elemento";
                this.elementModel = elementModel;
            }
            txtElementName.Text = elementModel.ElementName;
            txtConcentration.Text = elementModel.Concentration;
            txtUse.Text = elementModel.Uses;
            txtObservations.Text = elementModel.Observations;
        }

        DBConexion con = new DBConexion();

        private void FrmNewElement_Load(object sender, EventArgs e)
        {
            //FILL COMBOBOX
            cmbPresentation.DataSource = con.consultTable("presentation");
            cmbPresentation.DisplayMember = "name";
            cmbPresentation.ValueMember = "name";

            List<String> values = new List<string>() { "Comprimidos", "Crema", "Jarabe - Gotas", "Soluciones", "Ampollas", "Psicofarmaco", "Limpieza", "Descartables", "antisepticos ", "Otro" };
            cmbPresentation.SelectedIndex = (int)values.FindIndex(x => x == elementModel.Presentation);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cleanForm()
        {
            txtElementName.Text = String.Empty;
            cmbPresentation.SelectedIndex = 0;
            txtConcentration.Text = String.Empty;
            txtUse.Text = String.Empty;
            txtObservations.Text = String.Empty;
            elementModel = new ElementModel();
            lblTitle.Text = "Nuevo Elemento";
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
                sql = "UPDATE elementModel SET name='" + txtElementName.Text + "', concentration='" + txtConcentration.Text + "', presentation='" + cmbPresentation.SelectedValue.ToString() +"', uses='" + txtUse.Text + "', Remit='" + txtObservations.Text + "', id_updater='" + User.Id +"', update_date='" + sqlFormattedDate + "' WHERE id_elementModel=" + elementModel.Id;
                successMessage = "Elemento modificado correctamente";
                ErrorMessage = "Error al intentar modificar el Elemento";
            }
            else
            {
                sql = "INSERT INTO elementModel (name, concentration, presentation, uses, observations,id_creator,creation_date) VALUES ('" + txtElementName.Text + "','" + txtConcentration.Text + "','" + cmbPresentation.SelectedValue.ToString() + "','" + txtUse.Text + "','" + txtObservations.Text + "','" + User.Id + "','" + sqlFormattedDate + "')";
                successMessage = "Elemento agregado correctamente";
                ErrorMessage = "Error al agregar el elemento";
            }
            addNewElement(sql);
        }

        void addNewElement(String sql)
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

