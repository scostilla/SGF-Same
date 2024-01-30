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
    public partial class FrmNewProvider : Form
    {
        Provider provider = new Provider();
        bool upDate;
        String sql, successMessage, ErrorMessage;

        public FrmNewProvider(Provider provider)
        {
            InitializeComponent();
            upDate = false;
            if (provider.Id != 0)
            {
                upDate = true;
                lblTitle.Text = "Modificar Base Operativa";
                this.provider = provider;
            }

            txtProviderName.Text = provider.Name;
            txtAddress.Text = provider.Address;
        }

        DBConexion con = new DBConexion();

        private void FrmNewProvider_Load(object sender, EventArgs e)
        {
            //FILLCOMBOBOX
            cmbProvince.DataSource = con.consultTable("province");
            cmbProvince.DisplayMember = "name";
            cmbProvince.ValueMember = "name";

            List<String> values = new List<string>() { "Jujuy", "Salta", "Córdoba", "Buenos Aires", "C.A.B.A.", "Tucuman", "Catamarca", "Chaco", "Chubut", "Corrientes", "Entre Ríos", "Formosa", "La Pampa", "La Rioja", "Mendoza", "Misiones", "Neuquén", "Río Negro", "San Juan", "San Luis", "Santa Cruz", "Santa Fe", "Santiago del Estero", "Tierra del Fuego" };
            cmbProvince.SelectedIndex = (int)values.FindIndex(x => x == provider.Province);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cleanForm()
        {
            txtProviderName.Text = String.Empty;
            cmbProvince.SelectedIndex = 0;
            txtAddress.Text = String.Empty;
            provider = new Provider();
            lblTitle.Text = "Nuevo Proveedor";
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
                sql = "UPDATE provider SET name='" + txtProviderName.Text + "', province='" + cmbProvince.SelectedValue.ToString() + "', address='" + txtAddress.Text +"', id_updater='" + User.Id + "', update_date='" + sqlFormattedDate + "' WHERE id_provider=" + provider.Id;
                successMessage = "Elemento modificado correctamente";
                ErrorMessage = "Error al intentar modificar el Elemento";
            }
            else
            {
                sql = "INSERT INTO provider (name, province, address,id_creator,creation_date) VALUES ('" + txtProviderName.Text + "','" + cmbProvince.SelectedValue.ToString() + "','" + txtAddress.Text + "','" + User.Id + "','" + sqlFormattedDate + "')";
                successMessage = "Elemento agregado correctamente";
                ErrorMessage = "Error al agregar el elemento";
            }
            addNewElement(sql);

            /*Provider provider = new Provider(txtProviderName.Text, cmbProvince.SelectedValue.ToString(), txtAddress.Text);
            String sql = "INSERT INTO provider (name, Province, address) VALUES ('" + provider.Name + "','" + provider.Province + "','" + provider.Address + "')";
            if (con.insert(sql))
            {
                MessageBox.Show("Proveedor agregado correctamente");
                cleanForm();
            }
            else
            {
                MessageBox.Show("Error al agregar el proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
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
