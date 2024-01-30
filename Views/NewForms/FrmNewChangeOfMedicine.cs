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
using Views.Lists;
using Views.Reports;

namespace Views.NewForms
{
    public partial class FrmNewChangeOfMedicine : Form, IElementToBuy
    {
        public IElementToBuy Caller { private get; set; }
        private static readonly List<ElementToDestroy> Products = new List<ElementToDestroy>();
        public List<ElementToDestroy> ElementToBuyList { get; set; }
        BaseIndex baseIndex;
        List<BaseIndex> baseList = new List<BaseIndex>();
        ElementToDestroy elementToChange;
        List<ElementToDestroy> elementToDestroyList;
        MedicineChanged medicineChanged;
        List<ElementToDestroy> MedicationList { get; set; }
        DBConexion con = new DBConexion();
        DataGridViewComboBoxColumn cmbBase = new DataGridViewComboBoxColumn();
        DateTimePicker dtpExpireDate;
        Rectangle rectangle;
        Boolean elementSaved = false, isEdit;
        int item, detailItems, lastNumber, lastYear, maxQuantity;
        string xmlString, sql, sqlFormattedRequestDate, lastMedicineChangeNumber, sqlFormattedDate;

        public FrmNewChangeOfMedicine()
        {
            MedicationList = new List<ElementToDestroy>();
            ElementToBuyList = new List<ElementToDestroy>();
            dtpExpireDate = new DateTimePicker();
            isEdit = false;

            InitializeComponent();
        }

        public FrmNewChangeOfMedicine(MedicineChanged medicineChanged, List<ElementToDestroy>  elementToDestroyList)
        {
            MedicationList = elementToDestroyList;
            this.medicineChanged = medicineChanged;
            isEdit = true;

            InitializeComponent();
        }

        private void FrmNewChangeOfMedicine_Load(object sender, EventArgs e)
        {
            if (isEdit)
            {
                txtCity.Text = medicineChanged.City;
                txtResponsable.Text = medicineChanged.RequestedBy;
                dtpRequestedDate.Value = medicineChanged.RequestedDate;
                txtDestiny.Text = medicineChanged.Destiny;
            }
            else
            {
                txtCity.Text = "San Salvador de Jujuy";
                txtResponsable.Text = User.LastName + ", " + User.Name;
            }

            dtpRequestedDate.Format = DateTimePickerFormat.Custom;
            dtpRequestedDate.CustomFormat = "dd/MM/yyyy";
            maxQuantity = 15; // cantidad maxima de elementos a agregar
            Products.Clear();

            grdElementList.DataSource = MedicationList;
            grdElementList.AllowUserToAddRows = false;
            grdElementList.Columns[1].Visible = false;
            grdElementList.Columns[11].Visible = false;//baseStockId



            grdElementList.Columns[0].HeaderText = "Item";
            grdElementList.Columns[2].HeaderText = "Nombre";
            grdElementList.Columns[3].HeaderText = "Presentacion";
            grdElementList.Columns[4].HeaderText = "Concentracion";
            grdElementList.Columns[5].HeaderText = "Lote";
            grdElementList.Columns[6].HeaderText = "Vencimiento";
            grdElementList.Columns[7].HeaderText = "Salida";
            grdElementList.Columns[8].HeaderText = "Ingreso";
            grdElementList.Columns[9].HeaderText = "Pend.";
            grdElementList.Columns[10].HeaderText = "Observaciones";
            grdElementList.Columns[6].ReadOnly = true;
            grdElementList.Columns[9].ReadOnly = true;

            grdElementList.Columns[0].Width = 35;
            grdElementList.Columns[2].Width = 230;
            grdElementList.Columns[3].Width = 75;
            grdElementList.Columns[4].Width = 80;
            grdElementList.Columns[7].Width = 45;
            grdElementList.Columns[8].Width = 45;
            grdElementList.Columns[9].Width = 45;
            grdElementList.Columns[10].Width = 230;
            grdElementList.AllowUserToResizeColumns = false;
            
            enableItems();
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

                }

                foreach (ElementToDestroy element in ElementToBuyList)
                {
                    Products.Add(element);
                }

                FrmElementList frmElementList = new FrmElementList("select * from elementModel", "Listado de Elementos");
                frmElementList.Caller = this;
                frmElementList.ShowDialog();
            }
        }

        private void btnDeleteElement_Click(object sender, EventArgs e)
        {
            if (Products.Count < 1) return;

            Products.RemoveAt(item);
            ElementToBuyList.RemoveAt(item);
            detailDataSource(Products, "btnDelete");

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
            }
            detailItems = grdElementList.Rows.Count;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            cleanForm();
        }

        private void detailDataSource(List<ElementToDestroy> Products, String calledFrom)
        {

            if (calledFrom == "loadDatarow" && detailItems >= maxQuantity)
            {
                MessageBox.Show("Solo puede agregar hasta " + maxQuantity + " elementos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
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
                    baseIndex = new BaseIndex();
                    baseIndex.Index = detailItems;
                    baseIndex.BaseName = "";
                    baseList.Add(baseIndex);
                }

                for (int i = 0; i < grdElementList.Rows.Count; i++)
                {
                    grdElementList.Rows[i].Cells[0].Value = i + 1;
                    grdElementList.Rows[i].Cells[9].Value = 0;
                }
                grdElementList.Rows[grdElementList.Rows.Count-1].Cells[10].Value = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCity.Text == "" || txtResponsable.Text == "" || txtDestiny.Text == "")
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
                if (row.Cells[5].Value == null || row.Cells[6].Value == null || row.Cells[7].Value == null || Convert.ToInt32(row.Cells[7].Value) < 1 || baseList[row.Index].BaseName == null)
                {
                    MessageBox.Show("Faltan Datos por Completar en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            createAndSaveMedicineDestruction();

            if (elementSaved)
            {
                this.Dispose();
            }
        }

        public void createAndSaveMedicineDestruction()
        {
            medicineChanged = new MedicineChanged();
            elementToDestroyList = new List<ElementToDestroy>();

            medicineChanged.City = txtCity.Text;
            medicineChanged.RequestedBy = txtResponsable.Text;
            medicineChanged.RequestedDate = dtpRequestedDate.Value;
            medicineChanged.BaseName = txtCity.Text;
            medicineChanged.Destiny = txtDestiny.Text;
            medicineChanged.ChangeObservations = txtObservatios.Text;
            medicineChanged.State = "Activo";// Activo - Anulado - Completo


            foreach (DataGridViewRow row in grdElementList.Rows)
            {
                elementToChange = new ElementToDestroy();

                elementToChange.Index = Convert.ToInt32(row.Cells[0].Value);
                elementToChange.ElementName = row.Cells[2].Value.ToString();
                elementToChange.Presentation = row.Cells[3].Value.ToString();
                elementToChange.Concentration = row.Cells[4].Value.ToString();
                elementToChange.ExpireDate = Convert.ToDateTime(row.Cells[6].Value.ToString());
                elementToChange.BaseName = row.Cells[12].Value.ToString();

                elementToChange.Lot = row.Cells[5].Value.ToString();
                elementToChange.Egress = Convert.ToInt32(row.Cells[7].Value);
                elementToChange.Entry = Convert.ToInt32(row.Cells[8].Value);
                elementToChange.Pending = Convert.ToInt32(row.Cells[9].Value);


                if (row.Cells[10].Value.ToString() == null)
                {
                    elementToChange.Observations = "";
                }
                else
                {
                    elementToChange.Observations = row.Cells[10].Value.ToString();
                }
                elementToDestroyList.Add(elementToChange);
            }

            for (int i = 0; i < elementToDestroyList.Count; i++)
            {
                for (int j = i + 1; j < elementToDestroyList.Count; j++)
                {
                    if (elementToDestroyList[i].ElementName == elementToDestroyList[j].ElementName && elementToDestroyList[i].Lot == elementToDestroyList[j].Lot && elementToDestroyList[i].BaseName == elementToDestroyList[j].BaseName)
                    {
                        MessageBox.Show("Hay elementos con lote repetido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        elementSaved = false;
                        return;
                    }
                }
            }

            try
            {
                lastMedicineChangeNumber = con.getValue("changeOfMedicines", "changeOfMedicines_Number", "changeOfMedicines_id=(select top 1 changeOfMedicines_id from changeOfMedicines order by changeOfMedicines_id DESC)").ToString();

                string[] splitNumber = lastMedicineChangeNumber.Split('/');
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
            medicineChanged.ReportNumber = lastNumber + "/" + lastYear;

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
                xmlString = xmlString + string.Format("     <Entry>" + element.Entry + "</Entry>{0}", Environment.NewLine);
                xmlString = xmlString + string.Format("     <Pending>" + element.Pending + "</Pending>{0}", Environment.NewLine);
                xmlString = xmlString + string.Format("     <BaseStockId>" + element.BaseStockId + "</BaseStockId>{0}", Environment.NewLine);
                xmlString = xmlString + string.Format("     <Observations>" + element.Observations + "</Observations>{0}    </ElementToDestroy>{0}", Environment.NewLine);
            }
            medicineChanged.ElementList = xmlString + "</ArrayOfElementToDestroy>'";
            sqlFormattedRequestDate = medicineChanged.RequestedDate.Date.ToString("yyyy-MM-dd");
            sqlFormattedDate = DateTime.Now.ToString("yyyy-MM-dd");

            sql = "INSERT INTO changeOfMedicines (changeOfMedicines_Number, city, destiny, requested_by, request_date, detail, change_observations, state, creation_date, id_creator) VALUES ('" + medicineChanged.ReportNumber + "','" + medicineChanged.City + "','"+ medicineChanged.Destiny + "','" + medicineChanged.RequestedBy + "','" + sqlFormattedRequestDate + "'," + medicineChanged.ElementList + ",'"+ medicineChanged.ChangeObservations + "','" + medicineChanged.State + "','" + sqlFormattedDate + "'," + User.Id + ")";

            if (con.insert(sql))
            {
                MessageBox.Show("Informe de cambio generado exitosamente");
                FrmChangeOfMedicineReport frmChangeOfMedicineReport = new FrmChangeOfMedicineReport(medicineChanged, elementToDestroyList);
                frmChangeOfMedicineReport.ShowDialog();
                elementSaved = true;
            }
            else
            {
                MessageBox.Show("Error al intentar registrar el cambio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                elementSaved = false;
                return;
            }
        }

        private void grdElementList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (isEdit) return;

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

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public bool LoadDataRow(ElementToBuy elementToBuy)
        {
            detailItems = grdElementList.Rows.Count;

            if (detailItems >= maxQuantity)
            {
                MessageBox.Show("Solo puede agregar hasta " + maxQuantity + " elementos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //permite agregar elementos repetidos
                elementToChange = new ElementToDestroy();
                elementToChange.ElementName = elementToBuy.ElementName;
                elementToChange.Concentration = elementToBuy.Concentration;
                elementToChange.Presentation = elementToBuy.Presentation;

                Products.Add(elementToChange);
                ElementToBuyList.Add(elementToChange);

                detailDataSource(Products, "loadDatarow");

                for (int i = 0; i < grdElementList.Rows.Count; i++)
                {
                    if (baseList[i].BaseName != "")
                    {
                        grdElementList.Rows[i].Cells[12].Value = baseList[i].BaseName;
                    }
                }
                // 
                //Retornamos True
            }
            return true;
        }

        private void grdElementList_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (grdElementList.CurrentCell.ColumnIndex == 7 || grdElementList.CurrentCell.ColumnIndex == 8)
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

        private void grdElementList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (grdElementList.Rows.Count < 1) return;

            if (grdElementList.Columns[e.ColumnIndex].Name == "Egress" || grdElementList.Columns[e.ColumnIndex].Name == "Entry")
            {
                try 
                {
                    if (Convert.ToInt32(grdElementList.Rows[e.RowIndex].Cells[7].Value) - Convert.ToInt32(grdElementList.Rows[e.RowIndex].Cells[8].Value) < 0)
                    {
                        MessageBox.Show("El egreso no puede ser menor al ingreso", "Valor incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        grdElementList.Rows[e.RowIndex].Cells[8].Value = 0;
                        grdElementList.Rows[e.RowIndex].Cells[9].Value = 0;
                    }
                    else
                    {
                        grdElementList.Rows[e.RowIndex].Cells[9].Value = Convert.ToInt32(grdElementList.Rows[e.RowIndex].Cells[7].Value) - Convert.ToInt32(grdElementList.Rows[e.RowIndex].Cells[8].Value);
                    }
                }
                catch
                {

                }
                
            }
            if (e.ColumnIndex == 12 && grdElementList.RowCount > 0)
            {
                baseList[e.RowIndex].BaseName = grdElementList.Rows[e.RowIndex].Cells[12].Value.ToString();
            }
        }

        public void enableItems()
        {
            btnAddElement.Enabled = !isEdit;
            grdElementList.Columns[5].ReadOnly = isEdit;
            grdElementList.Columns[6].ReadOnly = isEdit;
        }
        public void cleanForm()
        {
            txtCity.Text = "San Salvador de Jujuy";
            txtResponsable.Text = User.LastName + ", " + User.Name;
            dtpRequestedDate.Value = DateTime.Now;
            grdElementList.DataSource = null;
            txtDestiny.Text = "";
            txtObservatios.Text = "";

            medicineChanged = new MedicineChanged();
            elementToDestroyList = new List<ElementToDestroy>();
            sql = String.Empty;
            xmlString = String.Empty;
            sqlFormattedRequestDate = String.Empty;
            baseList.Clear();
        }
    }
}
