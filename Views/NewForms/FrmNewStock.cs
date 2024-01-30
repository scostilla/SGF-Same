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
    public partial class FrmNewStock : Form
    {
        String sql, successMessage, ErrorMessage;
        int stockId, elementModelId, oldQuantity;
        ElementModel elementModel;
        Element element;
        List<Element> elements;
        BaseStock baseStock;
        Stock stock;
        Boolean isUpdate;

        public FrmNewStock(int stockId)
        {
            this.stockId = stockId;
            InitializeComponent();
        }

        DBConexion con = new DBConexion();
        String cmbValue = "in";

        private void FrmNewStock_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> cmbValues = new Dictionary<string, string>();
            cmbValues.Add("0", "Ingreso");
            cmbValues.Add("1", "Egreso");
            cmbInOut.DataSource = new BindingSource(cmbValues, null);
            cmbInOut.DisplayMember = "Value";
            cmbInOut.ValueMember = "Key";
            txtLot.Visible = true;
            cmbLot.Visible = false;

            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "dd/MM/yyyy";
            dtpExpire.Format = DateTimePickerFormat.Custom;
            dtpExpire.CustomFormat = "dd/MM/yyyy";

            cmbElement.DataSource = con.consultElement("elementModel");
            cmbElement.DisplayMember = "elementName";
            cmbElement.ValueMember = "id_elementModel";

            if (stockId > 0)
            {
                elementModel = new ElementModel();
                element = new Element();
                stock = new Stock();
                baseStock = new BaseStock();

                stock = con.getStock(stockId);
                elementModelId = Convert.ToInt32(con.getValue("element", "id_elementModel", "id_element=" + stock.Id_element));
                elementModel = con.selectElementModel(Convert.ToInt32(cmbElement.SelectedValue));
                element = con.selectElement(stock.Lot, elementModelId);
                baseStock = con.selectBaseStock(stock.Id_base, element.Id);
                if (stock.InOut == 0)
                {
                    cmbOriginDestiny.SelectedValue = stock.Id_provider;
                    fillCmbOriginDestiny("origin");
                }
                else
                {
                    cmbOriginDestiny.SelectedValue = stock.Id_base;
                    fillCmbOriginDestiny("destiny");
                }
                cmbInOut.SelectedValue = stock.InOut;
                cmbInOut.Enabled = false;
                dtpDate.Value = stock.EntryDate;
                dtpDate.Enabled = false;

                cmbElement.SelectedValue = elementModelId;
                txtLot.Text = stock.Lot;
                dtpExpire.Value = stock.ExpireDate;
                nbrQuantity.Value = stock.Quantity;
                txtRemit.Text = stock.Remit;

                txtBarCode.Text = element.BarCode;
                isUpdate = true;
                lblResidue.Text = stock.Residue.ToString();
                oldQuantity = stock.Quantity;
            }
            else
            {
                fillCmbOriginDestiny("origin");
                cmbElement.SelectedValue = 1;
                isUpdate = false;

            }
        }

        private void cmbInOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbValue = ((KeyValuePair<string, string>)cmbInOut.SelectedItem).Value;
            }
            catch
            {
                if (stock.InOut == 0)
                {
                    cmbValue = "Ingreso";
                }
                else
                {
                    cmbValue = "Egreso";
                }
            }

            if (cmbValue == "Egreso")
            {
                lblTitle.Text = "Egreso";
                lblOriginDestiny.Text = "Destino";
                fillCmbOriginDestiny("destiny");
                btnSearch.Enabled = false;
                enableFields(true);
            }
            else
            {
                lblTitle.Text = "Ingreso";
                lblOriginDestiny.Text = "Procedencia";
                fillCmbOriginDestiny("origin");
                btnSearch.Enabled = true;
                enableFields(true);
            }
            cmbOriginDestiny.SelectedIndex = 0;
        }

        private void fillCmbOriginDestiny(String direction)
        {
            cmbOriginDestiny.DataSource = null;
            cleanForm();


            if (direction == "origin")
            {
                cmbOriginDestiny.DataSource = con.consultSortTable("provider","name");
                cmbOriginDestiny.DisplayMember = "name";
                cmbOriginDestiny.ValueMember = "id_provider";
                btnNewLot.Enabled = true;
            }
            else
            {
                cmbOriginDestiny.DataSource = con.consultTable("base");
                cmbOriginDestiny.DisplayMember = "name";
                cmbOriginDestiny.ValueMember = "id_base";
                btnNewLot.Enabled = false;
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNewElement_Click(object sender, EventArgs e)
        {
            FrmNewElement frmNewElement = new FrmNewElement(new ElementModel());
            frmNewElement.Show();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (nbrQuantity.Value==0)
            {
                MessageBox.Show("Debe ingresar la cantidad");
            }
            else
            {
                if (isUpdate)
                {
                    updateStockValues(oldQuantity);
                }
                else
                {
                    calculateNewStock();
                }
            }
            btnSave.Enabled = true;
        }

        private void calculateNewStock()
        {
            elementModel = new ElementModel();
            element = new Element();
            stock = new Stock();

            elementModel = con.selectElementModel(Convert.ToInt32(cmbElement.SelectedValue));
            element = con.selectElement(txtLot.Text.ToString(), elementModel.Id);

            element.Lot = txtLot.Text.ToUpper();
            element.ExpireDate = dtpExpire.Value.Date;
            if (txtBarCode.Text == "")
            {
                element.BarCode = "0";
            }
            else
            {
                element.BarCode = txtBarCode.Text;
            }
            stock.EntryDate = dtpDate.Value.Date;
            stock.Id_element = element.Id;
            stock.Quantity = (int)nbrQuantity.Value;
            stock.Lot = element.Lot;
            stock.ExpireDate = element.ExpireDate;
            if (cmbValue == "Egreso")
            {
                //ver que exista el elemento
                if (element.Id < 1)
                {
                    MessageBox.Show("El elemento ingresado no existe", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    stock.InOut = 1;
                    stock.Id_base = Convert.ToInt32(cmbOriginDestiny.SelectedValue);
                    stock.Id_provider = 0;
                    element.Quantity -= (int)nbrQuantity.Value;
                    lblResidue.Text = element.Quantity.ToString();
                    elementModel.Total -= element.Quantity;
                    stock.Remit = txtRemit.Text;
                    stock.Residue = Convert.ToInt32(lblResidue.Text);
                }
            }
            else
            {
                if (txtRemit.Text == String.Empty)
                {
                    MessageBox.Show("Debe ingresar el numero de remito", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    enableAllFields(false);

                    stock.InOut = 0;
                    stock.Id_base = Warehouse.IdWarehouse; // ID del deposito
                    stock.Id_provider = Convert.ToInt32(cmbOriginDestiny.SelectedValue);
                    element.Quantity += (int)nbrQuantity.Value;
                    lblResidue.Text = element.Quantity.ToString();
                    elementModel.Total += element.Quantity;
                    stock.Residue = Convert.ToInt32(lblResidue.Text);
                    stock.Remit = txtRemit.Text;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lblResidue.Text.ToString()=="")
            {
                MessageBox.Show("Falta Calcular el total");
            }
            else
            {
                if (isUpdate)
                {
                    saveUpdatesValues();
                }
                else
                {
                    saveNewStock();
                }
            }
            cleanForm();
        }

        private void saveNewStock()
        {
            if (Convert.ToInt32(lblResidue.Text) < 0)
            {
                MessageBox.Show("No hay suficiente Stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (element.IdElementModel != elementModel.Id)
                {
                    if (element.Id < 1)
                    {
                        //create new element LOT
                        createNewElement("new");
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("El numero de lote no coincide con algun lote elemento previamente, desea crear un nuevo elemento con este lote?", "Advertencia", MessageBoxButtons.YesNo);

                        if (dialogResult == DialogResult.Yes)
                        {
                            //create new element LOT
                            createNewElement("new");
                        }
                        else
                        {
                            txtLot.Text = "";
                        }
                    }
                }
                else
                {
                    //upDate quantity and total in elementModel y element LOT
                    createNewElement("update");
                }
            }
        }


        public void createNewElement(string option)
        {
            string sqlFormattedDate = DateTime.Now.ToString("yyyy-MM-dd");
            string sqlFormattedExpireDate = element.ExpireDate.Date.ToString("yyyy-MM-dd");
            string sqlFormattedEntryDate = dtpDate.Value.Date.ToString("yyyy-MM-dd");
            baseStock = new BaseStock();
            stock.Observations = txtObservations.Text;

            sql = String.Empty;
            if (option == "new")
            {
                successMessage = "Elemento agregado correctamente";
                ErrorMessage = "Error al agregar el elemento";

                //CREATE ELEMENT 
                sql = "INSERT INTO element (id_elementModel, lot, expireDate, quantity, barCode,creation_date, id_creator) VALUES(" + elementModel.Id + ",'" + element.Lot + "','" + sqlFormattedExpireDate + "'," + element.Quantity+ ",'"+element.BarCode+ "','" + sqlFormattedDate + "'," + User.Id+")";

                if (con.insert(sql))
                {
                    //BRING THE ELEMENT ID
                    element = con.selectElement(txtLot.Text.ToString(), elementModel.Id);
                }
                else
                {
                    MessageBox.Show(ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //update elementModel - save stock in database - create BaseStock
                sql ="UPDATE elementModel SET total = "+elementModel.Total+", update_date='"+ sqlFormattedDate + "', id_updater="+User.Id+" WHERE id_elementModel="+elementModel.Id+ ";INSERT INTO stock (inOut,entryDate,id_provider,id_base,id_element,quantity,lot,expireDate,residue,remit,creation_date, id_creator,observations) VALUES(" + stock.InOut+",'"+ sqlFormattedEntryDate + "',"+stock.Id_provider+","+stock.Id_base+","+element.Id+","+stock.Quantity+",'"+element.Lot+"','"+ sqlFormattedExpireDate + "',"+stock.Residue+",'"+stock.Remit+"','"+sqlFormattedDate+"',"+User.Id+",'"+ stock.Observations +"'); INSERT INTO baseStock (id_base,id_element,quantity,creation_date, id_creator) VALUES(" + stock.Id_base + "," + element.Id + "," + (int)nbrQuantity.Value + ",'" + sqlFormattedDate + "'," + User.Id + ")";
            }
            else
            {
                baseStock = con.selectBaseStock(stock.Id_base, element.Id);

                //update element quantity - update elementModel total - save stock in database
                sql = "UPDATE element SET quantity = " + element.Quantity + ", update_date='" + sqlFormattedDate + "', id_updater=" + User.Id + " WHERE id_element=" + element.Id + ";UPDATE elementModel SET total = " + elementModel.Total + ", update_date='" + sqlFormattedDate + "', id_updater=" + User.Id + " WHERE id_elementModel=" + elementModel.Id + ";INSERT INTO stock (inOut,entryDate,id_provider,id_base,id_element,quantity,lot,expireDate,residue,remit,creation_date, id_creator,observations) VALUES(" + stock.InOut + ",'" + sqlFormattedEntryDate + "'," + stock.Id_provider + "," + stock.Id_base + "," + element.Id + "," + stock.Quantity + ",'" + element.Lot + "','" + sqlFormattedExpireDate + "'," + stock.Residue + ",'" + stock.Remit + "','" + sqlFormattedDate + "'," + User.Id + ",'" + stock.Observations + "')";

                //verify if this baseStock already exist 
                if (baseStock.Id < 1)
                {
                    //create new baseStock
                    sql+= "; INSERT INTO baseStock (id_base,id_element,quantity,creation_date, id_creator) VALUES(" + Convert.ToInt32(cmbOriginDestiny.SelectedValue) + "," + element.Id + "," + (int)nbrQuantity.Value + ",'" + sqlFormattedDate + "'," + User.Id + "); UPDATE baseStock SET quantity = " + Convert.ToInt32(lblResidue.Text) + "  where id_base="+ Warehouse.IdWarehouse + "  and id_element= " + element.Id;
                }
                else
                {
                    //Update baseStock quantity - add quantity to destiny baseStock 
                    int newQuantity = baseStock.Quantity + (int)nbrQuantity.Value;
                    if (cmbValue == "Egreso")
                    {
                        //subtract from Warehouse baseStock
                        sql += "; UPDATE baseStock SET quantity = " + Convert.ToInt32(lblResidue.Text) + "  where id_base="+ Warehouse.IdWarehouse + " and id_element= " + element.Id;
                    }
                    sql += "; UPDATE baseStock SET quantity=" + newQuantity + ", update_date='" + sqlFormattedDate + "', id_updater=" + User.Id + " WHERE id_baseStock=" + baseStock.Id+ " and id_element= " + element.Id;
                }

                successMessage = "Elemento modificado correctamente";
                ErrorMessage = "Error al intentar modificar el Elemento";
            }

            if (con.insert(sql))
            {
                MessageBox.Show(successMessage);
                cleanForm();
            }
            else
            {
                MessageBox.Show(ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //this.Dispose();
        }


        private void enableFields(Boolean value)
        {
            cmbElement.Enabled = value;
            txtLot.Enabled = value;
            dtpExpire.Enabled = value;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cmbLot.Items.Clear();
            if (txtBarCode.Text == "")
            {
                MessageBox.Show("Debe ingresar un codigo para buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                elements = new List<Element>();
                elements = con.selectElement(txtBarCode.Text);

                if (elements.Count < 1)
                {
                    MessageBox.Show("Elemento no Encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cleanForm();
                }
                else
                {
                    cmbElement.SelectedValue = elements[0].IdElementModel;
                    cmbElement.SelectedItem = elements[0].IdElementModel;
                    lblResidue.Text = elements[0].Quantity.ToString();

                    if (elements.Count > 1)
                    {
                        txtLot.Visible = false;
                        cmbLot.Visible = true;

                        foreach (Element el in elements)
                        {
                            if(cmbValue == "Egreso")
                            {
                                if (el.Quantity > 0)
                                {
                                    cmbLot.Items.Add(el.Lot);
                                }
                            }
                            else
                            {
                                cmbLot.Items.Add(el.Lot);
                            }
                        }
                        cmbLot.SelectedItem = elements[0].Lot;
                        txtLot.Text = elements[0].Lot;
                    }
                    else
                    {
                        txtLot.Visible = true;
                        cmbLot.Visible = false;
                        txtLot.Text = elements[0].Lot;
                        dtpExpire.Value = elements[0].ExpireDate;
                    }
                    

                    if (cmbValue == "Egreso")
                    {
                        enableFields(false);
                    }
                    else
                    {
                        enableFields(true);
                    }
                    this.SelectNextControl((Control)sender, true, true, true, true);
                }
            }
        }

        private void cmbLot_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i=0; i < elements.Count; i++){
                if (elements[i].Lot == cmbLot.SelectedItem.ToString())
                {
                    cmbElement.SelectedValue = elements[i].IdElementModel;
                    cmbElement.SelectedItem = elements[i].IdElementModel;
                    dtpExpire.Value = elements[i].ExpireDate;
                    cmbLot.SelectedItem = i;
                    dtpExpire.Value = elements[i].ExpireDate;
                    txtLot.Text = elements[i].Lot;
                    lblResidue.Text = elements[i].Quantity.ToString();
                    break;
                }
            }
        }

        private void txtBarCode_TextChanged(object sender, EventArgs e)
        {
            List<Element> elements = new List<Element>();
            elements = con.selectElement(txtBarCode.Text);

            if (elements.Count > 0)
            {
                btnSearch_Click(sender, e);

            }
        }

        private void txtBarCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar=='\r')
            {
                if (txtBarCode.Text == "")
                {
                    return;
                }
                else
                {
                    btnSearch_Click(sender, e);
                }
            }

        }

        private void updateStockValues(int oldQuantity)
        {
            if (txtBarCode.Text == "")
            {
                element.BarCode = "0";
            }
            else
            {
                element.BarCode = txtBarCode.Text;
            }
            enableAllFields(false);

            if (txtRemit.Text == "")
            {
                MessageBox.Show("Debe ingresar el numero de remito", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                enableAllFields(true);
            }
            else
            {
                if (stock.InOut == 0)
                {
                    stock.Id_base = Warehouse.IdWarehouse;
                    stock.Id_provider = Convert.ToInt32(cmbOriginDestiny.SelectedValue);
                    stock.Remit = txtRemit.Text;
                    if (nbrQuantity.Value != oldQuantity)
                    {
                        //desde proveedor - restar en elementModel, BaseStock(deposito) y element y cambio en stock
                        elementModel.Total = elementModel.Total - oldQuantity + (int)nbrQuantity.Value;
                        baseStock.Quantity = baseStock.Quantity - oldQuantity + (int)nbrQuantity.Value;
                        element.Quantity = element.Quantity - oldQuantity + (int)nbrQuantity.Value;
                        stock.Quantity = (int)nbrQuantity.Value;
                        stock.Residue = stock.Residue - oldQuantity + (int)nbrQuantity.Value;
                    }
                }
                else
                {
                    stock.Id_base = Convert.ToInt32(cmbOriginDestiny.SelectedValue);
                    stock.Id_provider = 0;
                    stock.Remit = txtRemit.Text;
                    if (nbrQuantity.Value != oldQuantity)
                    {
                        //desde deposito - restar en basestock(base), sumar a elementModel, BaseStock(deposito) y cambio en stock
                        BaseStock warehouseBase = new BaseStock();
                        warehouseBase = con.selectBaseStock(Warehouse.IdWarehouse, element.Id);

                        elementModel.Total = elementModel.Total + oldQuantity - (int)nbrQuantity.Value;
                        baseStock.Quantity = baseStock.Quantity - oldQuantity + (int)nbrQuantity.Value;
                        warehouseBase.Quantity = warehouseBase.Quantity + oldQuantity - (int)nbrQuantity.Value;
                        element.Quantity = element.Quantity - oldQuantity + (int)nbrQuantity.Value;
                        stock.Quantity = (int)nbrQuantity.Value;
                        stock.Residue = stock.Residue + oldQuantity - (int)nbrQuantity.Value;
                    }
                }
                element.Lot = txtLot.Text.ToUpper();
                element.ExpireDate = dtpExpire.Value.Date;
                if (txtBarCode.Text == "")
                {
                    element.BarCode = "0";
                }
                else
                {
                    element.BarCode = txtBarCode.Text;
                }
                stock.EntryDate = dtpDate.Value.Date;
                stock.Id_element = element.Id;
                stock.Lot = element.Lot;
                stock.ExpireDate = element.ExpireDate;

                lblResidue.Text = stock.Residue.ToString();
            }
        }

        private void btnNewLot_Click(object sender, EventArgs e)
        {
            txtLot.Visible = true;
            cmbLot.Visible = false;

        }

        private void saveUpdatesValues()
        {
            sql = String.Empty;
            string sqlFormattedDate = DateTime.Now.ToString("yyyy-MM-dd");
            string sqlFormattedExpireDate = dtpExpire.Value.Date.ToString("yyyy-MM-dd");

            if (stock.Observations != null && txtObservations.Text != "")
            {
                stock.Observations = stock.Observations + " -- " + txtObservations.Text;
            }
            sql= "update stock set id_provider=" + stock.Id_provider + ",id_base=" + stock.Id_base + ", id_element=" + stock.Id_element + ", quantity=" + stock.Quantity + ", lot='" + stock.Lot + "', expireDate='" + sqlFormattedExpireDate + "',residue=" + stock.Residue + ", remit='" + stock.Remit + "', observations='" + stock.Observations + "', id_updater="+User.Id+", update_date='"+sqlFormattedDate+" ' where id_stock="+stockId+ "; update element set id_elementModel=" + element.IdElementModel + ", lot=" + element.Lot + ", expireDate='" + sqlFormattedExpireDate + "',  quantity=" + element.Quantity + ", barCode='" + element.BarCode + "', update_date='" + sqlFormattedDate + "', id_updater=" + User.Id + " where id_element=" + element.Id + "; update baseStock set id_base=" + stock.Id_base + ", id_element=" + element.Id + ",quantity=" + baseStock.Quantity + ", update_date='" + sqlFormattedDate + "', id_updater=" + User.Id + " where id_baseStock=" + baseStock.Id + "; update elementModel set total= " + elementModel.Total + " where id_elementModel= " + element.IdElementModel;

            successMessage = "Elemento modificado correctamente";
            ErrorMessage = "Error al intentar modificar el Elemento";
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

        private void cleanForm()
        {
            cmbElement.SelectedItem = -1;
            cmbElement.SelectedValue = 0;
            nbrQuantity.Value = 0;
            txtLot.Text = "";
            txtRemit.Text = "";
            dtpExpire.Value = DateTime.Now;
            txtBarCode.Text = "";
            txtObservations.Text = "";
            txtLot.Visible = true;
            cmbLot.Visible = false;
            lblResidue.Text = "";
            enableAllFields(true);
            isUpdate = false;
            btnSave.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            fillCmbOriginDestiny("origin");
            enableAllFields(true);
            cmbInOut.SelectedIndex = 0;
            txtObservations.Text = "";

        }

        private void enableAllFields(Boolean value)
        {
            cmbOriginDestiny.Enabled = value;
            cmbInOut.Enabled = value;
            dtpDate.Enabled = value;
            cmbElement.Enabled = value;
            txtLot.Enabled = value;
            dtpExpire.Enabled = value;
            nbrQuantity.Enabled = value;
            txtRemit.Enabled = value;
            txtBarCode.Enabled = value;
            txtObservations.Enabled = value;
            btnSearch.Enabled = value;
            btnNewElement.Enabled = value;
            btnCalculate.Enabled = value;
            txtLot.Enabled = value;
            cmbLot.Enabled = value;
            btnNewLot.Enabled = true;
        }
    }
}
