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
using System.Xml.Linq;
using Views.Reports;

namespace Views.Lists
{
    public partial class FrmControlSheet : Form
    {
        public FrmControlSheet()
        {
            InitializeComponent();
        }

        String sqlFormattedDate, sql, columnDay,lastWordSearched,findErrorMsg, xmlFile;
        
        bool finded=false,isLoading=true;
        int rows, operationalGridId,controlSheetId,index,sum;
        DataTable elementsList = new DataTable();
        List<ElementModel> elementModelList = new List<ElementModel>();
        ControlSheet controlSheet = new ControlSheet();
        ElementSheet elementSheet = new ElementSheet();
        List<Nurse> nurses = new List<Nurse>();
        ControlSheetTotals controlSheetTotals = new ControlSheetTotals();
        List<ElementQuantity> elementQuantities = new List<ElementQuantity>();

        DBConexion con = new DBConexion();

        private void FrmControlSheet_Load(object sender, EventArgs e)
        {
            rows = 0;
            operationalGridId = -1;
            lastWordSearched = String.Empty;
            findErrorMsg = "No se encontraron resultados con la palabra ingresada";
            index = 0;
            
            nbrYear.Value = DateTime.Today.Year;
            Dictionary<string, string> cmbValues = new Dictionary<string, string>();
            cmbValues.Add("1", "Enero");
            cmbValues.Add("2", "Febrero");
            cmbValues.Add("3", "Marzo");
            cmbValues.Add("4", "Abril");
            cmbValues.Add("5", "Mayo");
            cmbValues.Add("6", "Junio");
            cmbValues.Add("7", "Julio");
            cmbValues.Add("8", "Agosto");
            cmbValues.Add("9", "Septiembre");
            cmbValues.Add("10", "Octubre");
            cmbValues.Add("11", "Noviembre");
            cmbValues.Add("12", "Diciembre");

            cmbMonth.DataSource = new BindingSource(cmbValues, null);
            cmbMonth.DisplayMember = "Value";
            cmbMonth.ValueMember = "Key";
            cmbMonth.SelectedItem = "Enero";
            isLoading = true;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            cleanForm();
        }

        private void BtnShowMonth_Click(object sender, EventArgs e)
        {
            cleanGrdControlSheet();
            if (txtVehicle.Text == "" || cmbMonth.SelectedValue == null)
            {
                MessageBox.Show("Faltan Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sql = "operationalMonth = " + Convert.ToInt32(cmbMonth.SelectedValue) + " and operationalYear=" + (int)nbrYear.Value + " and vehicle='" + txtVehicle.Text + "'";

            try
            {
                operationalGridId = (int)con.getValue("operationalGrid", "id_operationalGrid", sql);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("La grilla operativa no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            rows = 0;
            sql = String.Empty;
            cleanGrdControlSheet();
            elementsList = con.genericConsult("elementModel", "select (name +' ' +concentration+ ' - '+presentation) as name from elementModel order by name");

            grdControlSheet.DataSource = elementsList;
            grdControlSheet.Columns[0].HeaderText = "Elemento";
            grdControlSheet.Columns[0].Name = "Detail";
            grdControlSheet.Columns[0].ReadOnly = true;
            grdControlSheet.AutoResizeColumns();
            grdControlSheet.Columns.Add("total", "Totales");

            try
            {
                controlSheetId = (int)con.getValue("controlSheet", "id_controlSheet", "id_operationalGrid=" + operationalGridId);
            }
            catch
            {
                controlSheetId = -1;
            }
            
            //load an empty control sheet
            rows = System.DateTime.DaysInMonth((int)nbrYear.Value, Convert.ToInt32(cmbMonth.SelectedValue));
            for (int i = 0; i < rows; i++)
            {
                columnDay = String.Empty;
                if (i < 9)
                {
                    columnDay = "0" + (i + 1) + "/" + cmbMonth.SelectedValue + "/" + (int)nbrYear.Value;
                }
                else
                {
                    columnDay = i + 1 + "/" + cmbMonth.SelectedValue + "/" + (int)nbrYear.Value;
                }
                grdControlSheet.Columns.Add(columnDay, columnDay);
                grdControlSheet.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            
            if (controlSheetId > 0) //bring control sheet data
            {
                controlSheet = new ControlSheet();
                xmlFile = String.Empty;
                try
                {
                    xmlFile = con.getValue("controlSheet", "detail", "id_controlSheet=" + controlSheetId).ToString();
                }
                catch (NullReferenceException)
                {
                    xmlFile = "-1";
                }

                if (xmlFile == "-1")
                {
                    MessageBox.Show("Error al traer los datos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    XElement xdocument = XElement.Parse(xmlFile);
                    int colIndex,rowIndex,datagridIndex;

                    var list = from item in xdocument.Elements("ElementSheet")
                               select new
                               {
                                   date = item.Element("OperationalDay").Value,
                                   nurse = item.Element("Nurse").Value,
                                   elementName = item.Element("ElementName").Value,
                                   quantity = item.Element("Egress").Value
                               };

                    foreach (var item in list)
                    {
                        ElementSheet elementSheet = new ElementSheet();
                        elementSheet.OperationalDay = Convert.ToDateTime(item.date);
                        elementSheet.Nurse = item.nurse;
                        elementSheet.ElementName = item.elementName;
                        elementSheet.Quantity = Convert.ToInt32(item.quantity);

                        controlSheet.Detail.Add(elementSheet);
                    }
                    //recorrer controlSheet.Detail para poner los valores
                    datagridIndex = 0;
                    foreach (ElementSheet element in controlSheet.Detail)
                    {
                        colIndex = element.OperationalDay.Day+1;
                        rowIndex = -1;
                        
                        while(datagridIndex < grdControlSheet.Rows.Count)
                        {
                            if (grdControlSheet.Rows[datagridIndex].Cells[0].Value.ToString() == element.ElementName)
                            {
                                rowIndex = datagridIndex;
                                break;
                            }
                            datagridIndex++;
                        }
                        grdControlSheet.Rows[rowIndex].Cells[colIndex].Value = element.Quantity;
                    }
                }
                
                foreach (DataGridViewRow row in grdControlSheet.Rows)
                {
                    sum = 0;
                    for(int i = 2; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null)
                        {
                            sum = sum + Convert.ToInt32(row.Cells[i].Value.ToString());
                        }
                    }
                    row.Cells[1].Value = sum;
                }
            }

            xmlFile = String.Empty;
            try
            {
                xmlFile = con.getValue("operationalGrid", "nurses", "id_operationalGrid=" + operationalGridId).ToString();
            }
            catch (NullReferenceException)
            {
                xmlFile = "-1";
            }

            if (xmlFile == "-1")
            {
                MessageBox.Show("Error al traer los datos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                XElement xdocument = XElement.Parse(xmlFile);

                var list = from item in xdocument.Elements("Nurse")
                           select new
                           {
                               date = item.Element("OperationalDay").Value,
                               name = item.Element("name").Value
                           };

                foreach (var item in list)
                {
                    Nurse nurse = new Nurse();
                    nurse.OperationalDay = Convert.ToDateTime(item.date);
                    nurse.name = item.name;

                    nurses.Add(nurse);
                }
            }

            grdControlSheet.Columns[0].Frozen = true;
            grdControlSheet.Columns[1].Frozen = true;
            grdControlSheet.Columns[1].ReadOnly = true;
            isLoading = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtVehicle.Text == "")
            {
                MessageBox.Show("Falta el numero de movil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Desea realizar la modificacion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if (result == DialogResult.Yes)
            {
                saveControlSheet();
            }
            else
            {
                BtnShowMonth_Click(sender, e);
            }
        }

        private void saveControlSheet()
        {
            sql = String.Empty;
            sqlFormattedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");

            controlSheet = new ControlSheet();
            controlSheet.Id = controlSheetId;
            controlSheet.OperationalGridId = operationalGridId;

            foreach (DataGridViewRow row in grdControlSheet.Rows)
            {
                for (int i = 2; i < grdControlSheet.ColumnCount; i++)
                {
                    if (row.Cells[i].Value != null && Convert.ToInt32(row.Cells[i].Value) > 0)
                    {
                        elementSheet = new ElementSheet();
                        elementSheet.OperationalDay = Convert.ToDateTime(grdControlSheet.Columns[i].HeaderText.ToString());
                        elementSheet.ElementName = row.Cells[0].Value.ToString();
                        elementSheet.Quantity = Convert.ToInt32(row.Cells[i].Value);
                        elementSheet.Nurse = nurses[i-2].name;

                        controlSheet.Detail.Add(elementSheet);
                    }
                }
            }

            if (controlSheetId < 0)
            {
                sql = "INSERT INTO controlSheet (id_operationalGrid, creation_date, id_creator) VALUES (" + operationalGridId + ",'"+sqlFormattedDate+"',"+User.Id+")";
                controlSheetId = con.insertGetID(sql, "controlSheet");
            }

            generateXml(controlSheet.Detail);
        }

        private void generateXml(List<ElementSheet> elementList)
        {
            string xmlString = String.Empty;
            xmlString = string.Format("'<?xml version=\"1.0\"?>{0}<ArrayOfElementSheet xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">{0}", Environment.NewLine);
            foreach (ElementSheet element in elementList)
            {
                string sqlFormattedOperationalDay = element.OperationalDay.Date.ToString("yyyy-MM-dd");
                xmlString = xmlString + string.Format("<ElementSheet>{0}        <OperationalDay>" + sqlFormattedOperationalDay + "</OperationalDay>{0}", Environment.NewLine);
                xmlString = xmlString + string.Format("        <Nurse>" + element.Nurse + "</Nurse>{0}", Environment.NewLine);
                xmlString = xmlString + string.Format("        <ElementName>" + element.ElementName + "</ElementName>{0}", Environment.NewLine);
                xmlString = xmlString + string.Format("     <Egress>" + element.Quantity + "</Egress>{0}    </ElementSheet>{0}", Environment.NewLine);
            }
            xmlString = xmlString + "</ArrayOfElementSheet>'";

            sql = "update controlSheet set Detail = " + @xmlString + ", update_date= '" + sqlFormattedDate + "', id_updater=" + User.Id + " where id_controlSheet = " + controlSheetId ;
            if (con.insert(sql))
            {
                generateTotalXml();
            }
            else
            {
                MessageBox.Show("Error al registrar la grilla operativa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void generateTotalXml()
        {
            controlSheetTotals.OperationalMonth= Convert.ToInt32(cmbMonth.SelectedValue.ToString());
            controlSheetTotals.OperationaYear = (int)nbrYear.Value;
            controlSheetTotals.Vehicle = txtVehicle.Text;
            elementQuantities = new List<ElementQuantity>();
            sql = String.Empty;

            try
            {
                controlSheetTotals.IdControlSheetTotals=Convert.ToInt32(con.getValue("controlSheetTotals", "id_controlSheetTotals", "operativeMonth=" + controlSheetTotals.OperationalMonth + " and operativeYear=" + controlSheetTotals.OperationaYear + " and vehicle= '" + controlSheetTotals.Vehicle + "'"));
            }
            catch
            {
                sql = "INSERT INTO controlSheetTotals (operativeMonth,operativeYear,vehicle,id_creator,creation_date) VALUES (" + controlSheetTotals.OperationalMonth + "," + controlSheetTotals.OperationaYear + ",'" + controlSheetTotals.Vehicle + "'," + User.Id + ",'" + sqlFormattedDate + "')";


                controlSheetTotals.IdControlSheetTotals = con.insertGetID(sql, "controlSheetTotals");
            }

            if (controlSheetTotals.IdControlSheetTotals == 0)
            {
                sql = "INSERT INTO controlSheetTotals (operativeMonth,operativeYear,vehicle,id_creator,creation_date) VALUES (" + controlSheetTotals.OperationalMonth + "," + controlSheetTotals.OperationaYear + ",'" + controlSheetTotals.Vehicle + "'," + User.Id + ",'" + sqlFormattedDate + "')";

                controlSheetTotals.IdControlSheetTotals = con.insertGetID(sql, "controlSheetTotals");
            }
            

            foreach (DataGridViewRow row in grdControlSheet.Rows)
            {
                try 
                {
                    if (Convert.ToInt32(row.Cells[1].Value.ToString()) > 0)
                    {
                        ElementQuantity elementQuantity = new ElementQuantity();
                        elementQuantity.Element = row.Cells[0].Value.ToString();
                        elementQuantity.Egress = Convert.ToInt32(row.Cells[1].Value.ToString());
                        elementQuantities.Add(elementQuantity);
                    }
                }
                catch
                {
                }
            }

            string xmlString = String.Empty;
            xmlString = string.Format("'<?xml version=\"1.0\"?>{0}<ArrayOfElementQuantity xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">{0}", Environment.NewLine);
            foreach (ElementQuantity element in elementQuantities)
            {
                xmlString = xmlString + string.Format(" <ElementQuantity>{0}        <Element>" + element.Element + "</Element>{0}", Environment.NewLine);
                xmlString = xmlString + string.Format("     <Vehicle>" + txtVehicle.Text + "</Vehicle>{0}", Environment.NewLine);
                xmlString = xmlString + string.Format("     <Egress>" + element.Egress + "</Egress>{0}    </ElementQuantity>{0}", Environment.NewLine);
            }
            xmlString = xmlString + "</ArrayOfElementQuantity>'";
            
            if(controlSheetTotals.IdControlSheetTotals == -1)
            {
                sql = "INSERT INTO controlSheetTotals (operativeMonth,operativeYear,vehicle,detail,id_creator,creation_date) VALUES (" + controlSheetTotals.OperationalMonth + "," + controlSheetTotals.OperationaYear + ",'" + controlSheetTotals.Vehicle + "'," + @xmlString + "," + User.Id + ",'" + sqlFormattedDate + "')";
            }
            else
            {
                sql = "update controlSheetTotals set detail = " + @xmlString + ", id_updater=" + User.Id + ", update_date='" + sqlFormattedDate + "' where id_controlSheetTotals = " + controlSheetTotals.IdControlSheetTotals;


            }

            if (con.insert(sql))
            {
                 MessageBox.Show("Grilla operativa generada exitosamente");
            }
            else
            {
                 MessageBox.Show("Error al registrar la grilla operativa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            BtnSave_Click(sender,e);
            FrmControlSheetReport frmControlSheetReport = new FrmControlSheetReport(controlSheet,Convert.ToInt32(cmbMonth.SelectedValue), (int)nbrYear.Value,txtVehicle.Text);
            frmControlSheetReport.Show();
        }

        private void grdControlSheet_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!isLoading)
            {
                sum = 0;
                for (int i = 2; i < grdControlSheet.Rows[e.RowIndex].Cells.Count; i++)
                {
                    if (grdControlSheet.Rows[e.RowIndex].Cells[i].Value != null)
                    {
                        sum = sum + Convert.ToInt32(grdControlSheet.Rows[e.RowIndex].Cells[i].Value.ToString());
                    }
                }
                grdControlSheet.Rows[e.RowIndex].Cells[1].Value = sum;
            }

        }

        private void cleanForm()
        {
            txtFilter.Text = String.Empty;
            txtVehicle.Text = string.Empty;
            cmbMonth.SelectedValue = "1";
            grdControlSheet.DataSource = null;
            rows = 0;
            controlSheetId = -1;
            sql = String.Empty;
            columnDay = String.Empty;
            findErrorMsg = "No se encontraron resultados con la palabra ingresada";
            txtFilter.Text = "";
            finded = false;
            index = 0;
            cleanGrdControlSheet();
        }

        private void cleanGrdControlSheet()
        {
            isLoading = true;
            for (int i = grdControlSheet.Rows.Count - 1; i >= 0; i--)
            {
                grdControlSheet.Rows.RemoveAt(i);
            }
            for (int i = grdControlSheet.Columns.Count - 1; i >= 0; i--)
            {
                grdControlSheet.Columns.RemoveAt(i);
            }
            grdControlSheet.DataSource = null;
            grdControlSheet.Refresh();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            grdControlSheet.ClearSelection();
            finded = false;

            if (txtFilter.Text.ToUpper() != lastWordSearched)
            {
                index = 0;
                findErrorMsg = "No se encontraron resultados con la palabra ingresada";
            }

            for (int i=index;i< elementsList.Rows.Count; i++)
            {
                if (elementsList.Rows[i][0].ToString().Contains(txtFilter.Text.ToUpper()))
                {
                    grdControlSheet.Rows[i].Selected = true;
                    grdControlSheet.FirstDisplayedScrollingRowIndex = i;
                    lastWordSearched = txtFilter.Text.ToUpper();
                    index = i+1;
                    finded = true;
                    findErrorMsg = "No se encontraron más resultados";
                    return;
                }
            }
            if(!finded)
            {
                index = 0;
                MessageBox.Show(findErrorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GrdControlSheet_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(GrdControlSheet_KeyPress);
            TextBox tb = e.Control as TextBox;
            if (tb != null)
            {
                tb.KeyPress += new KeyPressEventHandler(GrdControlSheet_KeyPress);
            }
        }

        private void GrdControlSheet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
