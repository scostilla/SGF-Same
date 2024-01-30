using ClassLibrary;
using NuGet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Views.Lists;
using Views.Reports;

namespace Views.NewForms
{
    public partial class FrmNewMedicineDestruction : Form, IElementToBuy
    {

        BaseIndex basesIndex;
        //List<BaseIndex> baseList = new List<BaseIndex>();
        BaseStock baseStock;
        List<OperativeBase> operativeBases = new List<OperativeBase>();
        List<ElementModel> elementModelList;
        Element element;
        List<Element> elementList;
        List<BaseStock> baseStockList,auxiliarBaseStockList;
        public IElementToBuy Caller { private get; set; }
        private static readonly List<ElementToDestroy> Products = new List<ElementToDestroy>();
        public List<ElementToDestroy> ElementToBuyList { get; set; }

        ElementToDestroy elementToDestroy;
        List<ElementToDestroy> elementToDestroyList;
        MedicineDestruction medicineDestruction;
        List<ElementToDestroy> MedicationList { get; set; }
        DBConexion con = new DBConexion();
        //DataGridViewComboBoxColumn cmbBase = new DataGridViewComboBoxColumn();
        DateTimePicker dtpExpireDate;
        Rectangle rectangle;
        Boolean elementSaved = false;
        int item, detailItems, lastNumber, lastYear, maxQuantity, baseIndex, elementIndex;
        string xmlString, sql, sqlFormattedRequestDate, lastMedicineDestructionNumber, sqlFormattedDate;

        public FrmNewMedicineDestruction()
        {
            MedicationList = new List<ElementToDestroy>();
            ElementToBuyList = new List<ElementToDestroy>();
            dtpExpireDate = new DateTimePicker();
            InitializeComponent();
        }

        private void FrmNewMedicineDestruction_Load(object sender, EventArgs e)
        {
            maxQuantity = 15; // cantidad maxima de elementos a agregar


            txtCity.Text = "San Salvador de Jujuy";
            txtRequestedBy.Text = User.LastName + ", " + User.Name;
            cmbBase.DataSource = con.consultTable("base");
            btnAddElement.Enabled = true;
            btnDeleteElement.Enabled = true;
            btnSave.Enabled = true;
            cmbBase.DisplayMember = "name";
            cmbBase.ValueMember = "name";
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "dd/MM/yyyy";
            Products.Clear();

            grdElementList.DataSource = MedicationList;
            grdElementList.AllowUserToAddRows = false;
            grdElementList.Columns[1].Visible = false;
            grdElementList.Columns[8].Visible = false;
            grdElementList.Columns[9].Visible = false;
            grdElementList.Columns[11].Visible = false; //BaseStockId

            grdElementList.Columns[0].HeaderText = "Item";
            grdElementList.Columns[2].HeaderText = "Nombre";
            grdElementList.Columns[3].HeaderText = "Presentacion";
            grdElementList.Columns[4].HeaderText = "Concentracion";
            grdElementList.Columns[5].HeaderText = "Lote";
            grdElementList.Columns[6].HeaderText = "Vencimiento";
            grdElementList.Columns[7].HeaderText = "Cantidad";
            grdElementList.Columns[10].HeaderText = "Observaciones";
            grdElementList.Columns[6].ReadOnly = true;

            grdElementList.Columns[0].Width = 35;
            grdElementList.Columns[2].Width = 230;
            grdElementList.Columns[3].Width = 75;
            grdElementList.Columns[4].Width = 80;
            grdElementList.Columns[7].Width = 50;
            grdElementList.Columns[10].Width = 300;
            grdElementList.AllowUserToResizeColumns = false;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAddElement_Click(object sender, EventArgs e)
        {
            if (detailItems >= maxQuantity)
            {
                MessageBox.Show("Solo puede agregar hasta " + maxQuantity + " elementos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Products.Clear();
                /*
                try
                {
                    cmbBase.DataSource = con.consultTable("base");
                    cmbBase.DisplayMember = "name";
                    cmbBase.ValueMember = "name";
                    grdElementList.Columns.Add(cmbBase);

                    grdElementList.Columns[12].HeaderText = "Base";
                    grdElementList.Columns[12].DisplayIndex = 1;
                    grdElementList.Columns[12].Width = 150; //BASE
                }
                catch
                {

                }*/

                foreach (ElementToDestroy element in ElementToBuyList)
                {
                    Products.Add(element);
                }

                FrmElementList frmElementList = new FrmElementList("select * from elementModel", "Listado de Elementos");
                frmElementList.Caller = this;
                frmElementList.ShowDialog();
            }
        }

        public bool LoadDataRow(ElementToBuy elementToBuy)
        {
            detailItems = grdElementList.Rows.Count;

            if (detailItems >= maxQuantity)
            {
                MessageBox.Show("Solo puede agregar hasta " + maxQuantity + " elementos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                //permite agregar elementos repetidos
                elementToDestroy = new ElementToDestroy();
                elementToDestroy.ElementName = elementToBuy.ElementName;
                elementToDestroy.Concentration = elementToBuy.Concentration;
                elementToDestroy.Presentation = elementToBuy.Presentation;

                Products.Add(elementToDestroy);
                ElementToBuyList.Add(elementToDestroy);

                detailDataSource(Products, "loadDatarow");
                /*
                for (int i = 0; i < grdElementList.Rows.Count; i++)
                {
                    if (baseList[i].BaseName != "")
                    {
                        grdElementList.Rows[i].Cells[12].Value = baseList[i].BaseName;
                    }
                }*/
                // 
                //Retornamos True
            }
            return true;
        }

        private void detailDataSource(List<ElementToDestroy> Products, String calledFrom)
        {

            if (calledFrom == "loadDatarow" && detailItems >= maxQuantity)
            {
                MessageBox.Show("Solo puede agregar hasta " + maxQuantity + " elementos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else {
                grdElementList.AutoGenerateColumns = false;
                grdElementList.DataSource = null;
                //Establecemos el DataSource del DataGridView enlazándolo a la lista
                //genérica
                grdElementList.DataSource = Products;

                //
                //Mapeamos las propiedades a las columnas
                grdElementList.Columns[2].DataPropertyName = "ElementName";
                grdElementList.Columns[3].DataPropertyName = "Presentation";
                grdElementList.Columns[4].DataPropertyName = "Concentration";

                grdElementList.Columns[0].ReadOnly = true;
                grdElementList.Columns[2].ReadOnly = true;
                grdElementList.Columns[3].ReadOnly = true;
                grdElementList.Columns[4].ReadOnly = true;

                //detailItems = grdElementList.Rows.Count;

                grdElementList.Controls.Add(dtpExpireDate);
                dtpExpireDate.Visible = false;
                dtpExpireDate.Format = DateTimePickerFormat.Short;
                dtpExpireDate.TextChanged += new EventHandler(dtp_TextChange);

                if (calledFrom == "loadDatarow")
                {
                    basesIndex = new BaseIndex();
                    basesIndex.Index = detailItems;
                    basesIndex.BaseName = "";
                    //baseList.Add(basesIndex);
                }

                for (int i = 0; i < grdElementList.Rows.Count; i++)
                {
                    grdElementList.Rows[i].Cells[0].Value = i + 1;
                    grdElementList.Rows[i].Cells[9].Value = 0;
                }
            }
            if (grdElementList.Rows.Count > 1)
            {
                grdElementList.Rows[grdElementList.Rows.Count - 1].Cells[10].Value = "";
            }
        }

        private void grdElementList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            item = grdElementList.CurrentCell.RowIndex;

            if (e.ColumnIndex == 6)
            {
                rectangle = grdElementList.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dtpExpireDate.Size = new Size(rectangle.Width, rectangle.Height);
                dtpExpireDate.Location = new Point(rectangle.X, rectangle.Y);
                dtpExpireDate.Visible = true;
            }
        }

        private void dtp_TextChange(object sender, EventArgs e)
        {
            grdElementList.CurrentCell.Value = dtpExpireDate.Text.ToString();
        }

        private void grdElementList_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            dtpExpireDate.Visible = false;
        }

        private void grdElementList_Scroll(object sender, ScrollEventArgs e)
        {
            dtpExpireDate.Visible = false;
        }

        private void btnDeleteElement_Click(object sender, EventArgs e)
        {
            if (Products.Count < 1) return;

            Products.RemoveAt(item);
            ElementToBuyList.RemoveAt(item);
            detailDataSource(Products, "btnDelete");
            /*
            baseList.RemoveAt(item);
            for (int i = item; i < baseList.Count; i++)
            {
                baseList[i].Index = baseList[i].Index - 1;
            }

            if (Products.Count > 0)
            {
                item = grdElementList.CurrentCell.RowIndex;
            }

            for (int i = 0; i < grdElementList.Rows.Count; i++)
            {
                if (baseList[i].BaseName != "")
                {
                    grdElementList.Rows[i].Cells[12].Value = baseList[i].BaseName;
                }
            }*/
            detailItems = grdElementList.Rows.Count;
        }

        private void grdElementList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 12 && grdElementList.RowCount > 0)
            {
               //baseList[e.RowIndex].BaseName = grdElementList.Rows[e.RowIndex].Cells[12].Value.ToString();
            }
        }

        private void grdElementList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Equals("System.FormatException"))
            {
                grdElementList.Rows[e.RowIndex].Cells[7].Value = 1;
                MessageBox.Show("Error!!!!!!!!!!!!!!!!!!!!!!!!!!");
            }
        }

        private void grdElementList_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (grdElementList.CurrentCell.ColumnIndex == 9)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }

        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            cleanForm();
            ElementToBuyList.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCity.Text == "" || txtRequestedBy.Text == "")
            {
                MessageBox.Show("Faltan datos por Completar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (grdElementList.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un elemento a la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (DataGridViewRow row in grdElementList.Rows)
            {
                if (row.Cells[5].Value == null || row.Cells[6].Value == null || row.Cells[7].Value == null || Convert.ToInt32(row.Cells[7].Value) < 1)
                {
                    MessageBox.Show("Faltan Datos por Completar en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            stockCheck();

            if (elementSaved)
            {
                this.Dispose();
            }
        }

        public void stockCheck()
        {
            baseStockList = new List<BaseStock>();
            elementModelList = new List<ElementModel>();
            sql = String.Empty;
            int elementModelIndex;
            Boolean createAndSave = false;

            //crear la lista de bases
            operativeBases = con.consultTable("base").AsEnumerable().Select(m => new OperativeBase()
            {
                Id = m.Field<int>("id_base"),
                BaseName = m.Field<String>("name"),
                Locality = m.Field<String>("locality"),
                Address = m.Field<String>("address"),
            }).ToList();

            //crear la lista de elementModel (para crear la lista de element)
            sql = "select * from elementModel where (name='" + grdElementList.Rows[0].Cells[2].Value.ToString()+"' and presentation='"+ grdElementList.Rows[0].Cells[3].Value.ToString() + "'";
            if (grdElementList.Rows[0].Cells[4].Value.ToString() != "")
            {
                sql=sql+ " and concentration='" + grdElementList.Rows[0].Cells[4].Value.ToString() + "')";
            }
            else
            {
                sql = sql + ")";
            }

            for(int i = 1; i < grdElementList.Rows.Count; i++)
            {
                sql = sql + " or (name = '" + grdElementList.Rows[i].Cells[2].Value.ToString()+"' and presentation = '"+ grdElementList.Rows[i].Cells[3].Value.ToString() + "'";

                if (grdElementList.Rows[i].Cells[4].Value.ToString() != "")
                {
                    sql = sql + " and concentration='" + grdElementList.Rows[i].Cells[4].Value.ToString() + "')";
                }
                else
                {
                    sql = sql + ")";
                }
            }


            elementModelList = con.genericConsult("elementModel", sql).AsEnumerable().Select(m => new ElementModel()
            {
                Id = m.Field<int>("id_elementModel"),
                ElementName = m.Field<String>("name"),
                Concentration = m.Field<string>("concentration"),
                Presentation = m.Field<string>("presentation"),
            }).ToList();

            //crear la lista de element
            elementList = new List<Element>();

            foreach (DataGridViewRow row in grdElementList.Rows)
            {
                baseStock = new BaseStock();
                element = new Element();

                if (row.Cells[4].Value.ToString() == "")
                {
                    elementModelIndex = elementModelList.FindIndex(a => (a.ElementName == row.Cells[2].Value.ToString() && a.Presentation == row.Cells[3].Value.ToString()));
                }
                else
                {
                    elementModelIndex = elementModelList.FindIndex(a => (a.ElementName == row.Cells[2].Value.ToString() && a.Presentation == row.Cells[3].Value.ToString() && a.Concentration == row.Cells[4].Value.ToString()));
                }
                element.IdElementModel = elementModelList[elementModelIndex].Id;
                element.Lot = row.Cells[5].Value.ToString();
                element.ExpireDate=Convert.ToDateTime(row.Cells[6].Value.ToString());
                element.ExpireDate.ToString("yyyy,MM,dd");
                element.Quantity = Convert.ToInt32(row.Cells[7].Value);
                elementList.Add(element);
            }

            sql = string.Empty;
            sql = "select * from element where (id_elementModel= "+elementList[0].IdElementModel+" and lot='"+ elementList[0].Lot +"' and expireDate='"+elementList[0].ExpireDate+"')";
            for(int i = 1; i < elementList.Count; i++)
            {
                sql = sql + " or (id_elementModel= " + elementList[i].IdElementModel + " and lot='" + elementList[i].Lot + "' and expireDate='" + elementList[i].ExpireDate + "')";
            }
            elementList = new List<Element>();

            elementList = con.genericConsult("element", sql).AsEnumerable().Select(m => new Element()
            {
                Id = m.Field<int>("id_element"),
                IdElementModel = m.Field<int>("id_elementModel"),
                Lot = m.Field<String>("lot"),
                ExpireDate = m.Field<DateTime>("expireDate"),
            }).ToList();

            if (elementList.Count<1 || createAndSave)
            {
                DialogResult dialogResult = MessageBox.Show("Algunas bases no poseen el stock necesario ¿desea continuar?", "Advertencia", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    createAndSaveMedicineDestruction();
                    createAndSave = true;
                    return;
                }
                else if (dialogResult == DialogResult.No)
                {
                    //limpiar formulario
                    cleanForm();
                    return;
                }
            }

            foreach (DataGridViewRow row in grdElementList.Rows)
            {
                baseStock = new BaseStock();
                baseIndex = operativeBases.FindIndex(a => a.BaseName == row.Cells[12].Value.ToString());
                elementIndex=elementList.FindIndex(a => (a.Lot == row.Cells[5].Value.ToString()) && (a.ExpireDate ==Convert.ToDateTime(row.Cells[6].Value.ToString())));

                if (elementIndex > -1)
                {
                    baseStock.IdBase = operativeBases[baseIndex].Id;
                    baseStock.IdElement = elementList[elementIndex].Id;
                    baseStock.Quantity = Convert.ToInt32(row.Cells[7].Value);

                    baseStockList.Add(baseStock);
                }
            }

            sql = string.Empty;
            sql = "select * from basestock where (id_base="+baseStockList[0].IdBase+" and id_element= "+baseStockList[0].IdElement+")";
            for(int i = 1; i < baseStockList.Count; i++)
            {
                sql = sql + " or (id_base=" + baseStockList[i].IdBase + " and id_element= " + baseStockList[i].IdElement + ")";
            }
            
            auxiliarBaseStockList = new List<BaseStock>();
            auxiliarBaseStockList = con.genericConsult("basestock", sql).AsEnumerable().Select(m => new BaseStock()
            {
                Id = m.Field<int>("id_BaseStock"),
                IdBase = m.Field<int>("id_base"),
                IdElement = m.Field<int>("id_element"),
                Quantity = m.Field<int>("quantity"),
            }).ToList();

            foreach(BaseStock stock in baseStockList)
            {
                baseIndex = auxiliarBaseStockList.FindIndex(a => (a.IdBase == stock.IdBase) && (a.IdElement == stock.IdElement));

                if(auxiliarBaseStockList[baseIndex].Quantity - stock.Quantity < 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Algunas bases no poseen el stock necesario ¿desea continuar?", "Advertencia", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes || !createAndSave)
                    {
                        createAndSaveMedicineDestruction();
                        createAndSave = true;
                        break;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        break;
                    }
                }
                else
                {
                    if(createAndSave != true)
                    {
                        createAndSaveMedicineDestruction();
                        createAndSave = true;
                    }
                }
            }
        }

        public void createAndSaveMedicineDestruction()
        {
            medicineDestruction = new MedicineDestruction();
            elementToDestroyList = new List<ElementToDestroy>();

            medicineDestruction.City = txtCity.Text;
            medicineDestruction.RequestedBy = txtRequestedBy.Text;
            medicineDestruction.RequestedDate = dtpDate.Value;
            medicineDestruction.BaseName = cmbBase.Text;
            medicineDestruction.State = "Activo";


            foreach (DataGridViewRow row in grdElementList.Rows)
            {
                elementToDestroy = new ElementToDestroy();

                elementToDestroy.Index = Convert.ToInt32(row.Cells[0].Value);
                elementToDestroy.BaseName = cmbBase.Text;
                elementToDestroy.ElementName = row.Cells[2].Value.ToString();
                elementToDestroy.Presentation = row.Cells[3].Value.ToString();
                elementToDestroy.Concentration = row.Cells[4].Value.ToString();
                elementToDestroy.ExpireDate = Convert.ToDateTime(row.Cells[6].Value.ToString());
                elementToDestroy.Lot = row.Cells[5].Value.ToString();
                elementToDestroy.Egress = Convert.ToInt32(row.Cells[7].Value);

                //BaseStockId
                elementIndex = elementList.FindIndex(a => (a.Lot == row.Cells[5].Value.ToString()) && (a.ExpireDate == Convert.ToDateTime(row.Cells[6].Value.ToString())));
                try
                {
                    elementIndex = elementList[elementIndex].Id;
                }
                catch
                {
                    elementIndex = -1;
                }


                baseIndex = operativeBases.FindIndex(a => a.BaseName == elementToDestroy.BaseName);
                
                try
                {
                    baseIndex = operativeBases[baseIndex].Id;
                }
                catch
                {
                    baseIndex = -1;
                }

                if (baseIndex == -1 || elementIndex == -1)
                {
                    elementToDestroy.BaseStockId = -1;
                }
                else
                {
                    elementToDestroy.BaseStockId = auxiliarBaseStockList.FindIndex(a => (a.IdBase == baseIndex) && (a.IdElement == elementIndex));
                    elementToDestroy.BaseStockId = auxiliarBaseStockList[elementToDestroy.BaseStockId].Id;
                }
                

                try
                {
                    elementToDestroy.Observations = row.Cells[10].Value.ToString();
                }
                catch
                {
                    elementToDestroy.Observations = "";
                }

                elementToDestroyList.Add(elementToDestroy);
            }

            for(int i=0;i<elementToDestroyList.Count;i++)
            {
                for(int j = i + 1; j < elementToDestroyList.Count; j++)
                {
                    if(elementToDestroyList[i].ElementName == elementToDestroyList[j].ElementName && elementToDestroyList[i].Lot == elementToDestroyList[j].Lot && elementToDestroyList[i].BaseName == elementToDestroyList[j].BaseName)
                    {
                        MessageBox.Show("Hay elementos repetidos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        elementSaved = false;
                        return;
                    }
                }
            }

            try
            {
                lastMedicineDestructionNumber = con.getValue("medicineDestruction", "medicineDestruction_Number", "MedicineDestruction_id=(select top 1 MedicineDestruction_id from medicineDestruction order by MedicineDestruction_id DESC)").ToString();

                string[] splitNumber = lastMedicineDestructionNumber.Split('/');
                lastNumber = Convert.ToInt32(splitNumber[0]);
                lastYear = Convert.ToInt32(splitNumber[1]);
            }
            catch
            {
                lastYear = DateTime.Now.Year;
                lastNumber = 0;
            }
            if ((DateTime.Now.Year - lastYear) > 0)
            {
                lastYear = DateTime.Now.Year;
                lastNumber = 0;
            }

            sql = String.Empty;
            xmlString = String.Empty;
            sqlFormattedRequestDate = String.Empty;
            lastNumber = lastNumber + 1;
            medicineDestruction.ReportNumber = lastNumber + "/" + lastYear;

            xmlString = string.Format("'<?xml version=\"1.0\"?>{0}<ArrayOfElementToDestroy xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">{0}", Environment.NewLine);
            foreach (ElementToDestroy element in elementToDestroyList)
            {
                xmlString = xmlString + string.Format("<ElementToDestroy>{0}        <Index>" + element.Index + "</Index>{0}", Environment.NewLine);
                xmlString = xmlString + string.Format("     <ElementName>" + element.ElementName + "</ElementName>{0}", Environment.NewLine);
                xmlString = xmlString + string.Format("     <Presentation>" + element.Presentation + "</Presentation>{0}", Environment.NewLine);
                xmlString = xmlString + string.Format("     <Concentration>" + element.Concentration + "</Concentration>{0}", Environment.NewLine);
                xmlString = xmlString + string.Format("     <BaseName>" + element.BaseName + "</BaseName>{0}", Environment.NewLine);
                xmlString = xmlString + string.Format("     <Lot>" + element.Lot + "</Lot>{0}", Environment.NewLine);
                xmlString = xmlString + string.Format("     <ExpireDate>" + element.ExpireDate.Date.ToString("yyyy-MM-dd") + "</ExpireDate>{0}", Environment.NewLine);
                xmlString = xmlString + string.Format("     <Egress>" + element.Egress + "</Egress>{0}", Environment.NewLine);
                xmlString = xmlString + string.Format("     <BaseStockId>" + element.BaseStockId + "</BaseStockId>{0}", Environment.NewLine);
                xmlString = xmlString + string.Format("     <Observations>" + element.Observations + "</Observations>{0}    </ElementToDestroy>{0}", Environment.NewLine);
            }
            medicineDestruction.ElementList = xmlString + "</ArrayOfElementToDestroy>'";
            sqlFormattedRequestDate = medicineDestruction.RequestedDate.Date.ToString("yyyy-MM-dd");
            sqlFormattedDate = DateTime.Now.ToString("yyyy-MM-dd");

            sql = "INSERT INTO medicineDestruction (medicineDestruction_Number, city, requested_by, request_date, base_name, detail, state, creation_date, id_creator) VALUES ('" + medicineDestruction.ReportNumber + "','" + medicineDestruction.City + "','"+ medicineDestruction .RequestedBy+ "','"+ sqlFormattedRequestDate +"','"+ medicineDestruction.BaseName + "',"+ medicineDestruction.ElementList + ",'"+medicineDestruction.State+"','"+ sqlFormattedDate +"',"+User.Id+ ")";

            String updateStock = String.Empty;

            foreach (BaseStock stock in baseStockList)
            {
                baseIndex = auxiliarBaseStockList.FindIndex(a => (a.IdBase == stock.IdBase) && (a.IdElement == stock.IdElement));

                if (auxiliarBaseStockList[baseIndex].Quantity - stock.Quantity < 0)
                {
                    auxiliarBaseStockList[baseIndex].Quantity = 0;
                }
                else
                {
                    auxiliarBaseStockList[baseIndex].Quantity = auxiliarBaseStockList[baseIndex].Quantity - stock.Quantity;
                }
                updateStock = updateStock + "update baseStock set quantity=" + auxiliarBaseStockList[baseIndex].Quantity + " where id_base=" + auxiliarBaseStockList[baseIndex].IdBase + " and id_element=" + auxiliarBaseStockList[baseIndex].IdElement + "; ";
            }

            sql = sql + "; " + updateStock;

            if (con.insert(sql))
            {
                MessageBox.Show("Informe de decomiso generado exitosamente");
                FrmMedicineDestructionReport frmMedicineDestruction = new FrmMedicineDestructionReport(medicineDestruction, elementToDestroyList);
                frmMedicineDestruction.ShowDialog();
                elementSaved = true;
            }
            else
            {
                MessageBox.Show("Error al intentar registrar el informe","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                elementSaved = false;
                return;
            }
        }

        public void cleanForm()
        {
            txtCity.Text = "San Salvador de Jujuy";
            lblTitle.Text = "Decomiso de Medicamentos";
            cmbBase.SelectedIndex = cmbBase.Items.IndexOf("BASE 1: CENTRAL");
            txtRequestedBy.Text = User.LastName + ", " + User.Name;
            dtpDate.Value = DateTime.Now;
            grdElementList.DataSource = null;

            medicineDestruction = new MedicineDestruction();
            elementToDestroyList = new List<ElementToDestroy>();
            sql = String.Empty;
            xmlString = String.Empty;
            sqlFormattedRequestDate = String.Empty;
            //baseList.Clear();
        }
    }
}
