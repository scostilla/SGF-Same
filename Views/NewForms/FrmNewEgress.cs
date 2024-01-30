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
using Views.Lists;

namespace Views.NewForms
{
    public partial class FrmNewEgress : Form
    {
        public FrmNewEgress()
        {
            InitializeComponent();
        }
        DBConexion con = new DBConexion();
        Element element = new Element();
        List<Element> elements;
        BaseStock baseStock = new BaseStock();
        string sql;
        private void FrmNewEgress_Load(object sender, EventArgs e)
        {
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "dd/MM/yyyy";

            cmbElement.DataSource = con.consultElement("elementModel");
            cmbElement.DisplayMember = "elementName";
            cmbElement.ValueMember = "id_elementModel";
            cmbElement.SelectedValue = 1;

            cmbBase.DataSource = con.consultTable("base");
            cmbBase.DisplayMember = "name";
            cmbBase.ValueMember = "id_base";
            cmbBase.SelectedValue = Warehouse.IdWarehouse;
            lblElementQuantity.Text = "";
            lblTotalResidue.Text = "";

            txtLot.Visible = true;
            cmbLot.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cleanForm();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void cleanForm()
        {
            dtpDate.Value = DateTime.Today;
            cmbElement.SelectedValue = 1;
            cmbBase.SelectedValue = 1;
            lblElementQuantity.Text = "";
            lblTotalResidue.Text = "";
            nbrQantity.Value = 0;
            txtLot.Text = "";
            txtObservations.Text = "";
            txtBarCode.Text = "";
            cmbElement.Enabled = true;
            cmbBase.Enabled = true;
            txtLot.Visible = true;
            txtLot.Enabled = true;
            cmbLot.Visible = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if(nbrQantity.Value<1 || txtLot.Text=="")
            {
                MessageBox.Show("Debe ingresar un lote y la cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //element = con.selectElement(Convert.ToInt64(txtBarCode.Text));
                //baseStock = con.selectBaseStock(Convert.ToInt32(cmbBase.SelectedValue), element.Id);

                if (element.Id < 1)
                {
                    MessageBox.Show("Elemento no Encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    lblElementQuantity.Text = baseStock.Quantity.ToString();
                    lblTotalResidue.Text = (baseStock.Quantity - (int)nbrQantity.Value).ToString();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lblTotalResidue.Text == "")
            {
                MessageBox.Show("Falta calcular el saldo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Convert.ToInt32(lblTotalResidue.Text) < 0)
                {
                    MessageBox.Show("No hay suficiente Stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    sql = string.Empty;
                    sql = "UPDATE baseStock SET quantity=" + lblTotalResidue.Text + " where baseStock.id_baseStock=" + baseStock.Id;

                    if (con.insert(sql))
                    {
                        MessageBox.Show("Registrado Correctamente");
                        cleanForm();
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar el egreso");
                    }
                }
            }
        }

        private void cmbLot_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i].Lot == cmbLot.SelectedItem.ToString())
                {
                    element = elements[i];
                    break;
                }
            }
            searchBaseStock();
        }

        private void searchBaseStock()
        {
            if (element.Id != 0)
            {
                baseStock = con.selectBaseStock(Convert.ToInt32(cmbBase.SelectedValue), element.Id);
                if (baseStock.Id == 0)
                {
                    MessageBox.Show("La base seleccionada no posee ese elemento en stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    lblElementQuantity.Text = element.Quantity.ToString();
                    cmbElement.SelectedValue = element.IdElementModel;
                    cmbElement.Enabled = false;
                    cmbBase.Enabled = false;
                    txtLot.Text = element.Lot;
                    txtLot.Enabled = false;
                    lblElementQuantity.Text = baseStock.Quantity.ToString();
                }
            }
        }

        private void txtBarCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                cmbLot.Items.Clear();
                elements = new List<Element>();
                elements = con.selectElement(txtBarCode.Text);

                if (elements.Count > 1)
                {
                    txtLot.Visible = false;
                    cmbLot.Visible = true;

                    foreach (Element el in elements)
                    {
                        cmbLot.Items.Add(el.Lot);
                    }
                    cmbLot.SelectedItem = elements[0].Lot;
                    txtLot.Text = elements[0].Lot;
                    /*element = elements[0];
                    searchBaseStock();*/
                }
                else
                {
                    txtLot.Visible = true;
                    cmbLot.Visible = false;
                    element = elements[0];
                    searchBaseStock();
                }
            }
        }
    }
}
