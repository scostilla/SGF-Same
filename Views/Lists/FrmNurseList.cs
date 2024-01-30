using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using ClassLibrary;
using Views.Lists;
using Views.Reports;

namespace Views.Lists
{
    public partial class FrmNurseList : Form
    {
        int rows,operationalGridId;
        string sql, sqlFormattedDate;
        DBConexion con = new DBConexion();
        DataGridViewColumn col1 = new DataGridViewTextBoxColumn();
        DataGridViewColumn col2 = new DataGridViewTextBoxColumn();
        OperationalGrid operationalGrid = new OperationalGrid();
        Nurse nurse = new Nurse();
        String xmlFile;

        public FrmNurseList()
        {
            InitializeComponent();
        }

        private void FrmNurseList_Load(object sender, EventArgs e)
        {
            rows = 0;
            operationalGridId = -1;
            Dictionary<string, string> cmbValues = new Dictionary<string, string>();
            cmbValues.Add("01", "Enero");
            cmbValues.Add("02", "Febrero");
            cmbValues.Add("03", "Marzo");
            cmbValues.Add("04", "Abril");
            cmbValues.Add("05", "Mayo");
            cmbValues.Add("06", "Junio");
            cmbValues.Add("07", "Julio");
            cmbValues.Add("08", "Agosto");
            cmbValues.Add("09", "Septiembre");
            cmbValues.Add("10", "Octubre");
            cmbValues.Add("11", "Noviembre");
            cmbValues.Add("12", "Diciembre");

            cmbMonth.DataSource = new BindingSource(cmbValues, null);
            cmbMonth.DisplayMember = "Value";
            cmbMonth.ValueMember = "Key";
            cmbMonth.SelectedItem = "Enero";

            nbrYear.Value = DateTime.Today.Year;
            txtVehicle.Text = "";

            col1.HeaderText = "Dia";
            col1.Name = "day";
            col2.HeaderText = "Enfermero";
            col2.Name = "nurse";
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            cleanForm();
        }

        private void btnShowMonth_Click(object sender, EventArgs e)
        {

            if (txtVehicle.Text == ""|| cmbMonth.SelectedValue==null)
            {
                MessageBox.Show("Faltan Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            rows = 0;
            sql = String.Empty;
            cleanGrdNurses();

            sql = "operationalMonth = " + Convert.ToInt32(cmbMonth.SelectedValue) + " and operationalYear=" + (int)nbrYear.Value + " and vehicle='"+txtVehicle.Text+"'";

            try
            {
                operationalGridId = (int)con.getValue("operationalGrid", "id_operationalGrid", sql);
            }
            catch (NullReferenceException)
            {
                operationalGridId = -1;
            }

            if (operationalGridId<0)//new operational grid
            {
                grdNurses.Columns.AddRange(col1, col2);
                rows = System.DateTime.DaysInMonth((int)nbrYear.Value, Convert.ToInt32(cmbMonth.SelectedValue));
                grdNurses.Rows.Add((int)rows);

                for (int i = 0; i < rows; i++)
                {
                    if (i < 9)
                    {
                        grdNurses.Rows[i].Cells[0].Value = "0" + (i + 1) + "/" + cmbMonth.SelectedValue + "/" + (int)nbrYear.Value;
                    }
                    else
                    {
                        grdNurses.Rows[i].Cells[0].Value = i + 1 + "/" + cmbMonth.SelectedValue + "/" + (int)nbrYear.Value;
                    }
                    grdNurses.Rows[i].Cells[1].Value = "";
                }
                grdNurses.Columns[0].ReadOnly = true;
            }
            else
            {
                operationalGrid = new OperationalGrid();
                xmlFile = String.Empty;
                try
                {
                    xmlFile = con.getValue("operationalGrid", "nurses", "id_operationalGrid="+ operationalGridId).ToString();
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

                        operationalGrid.nurses.Add(nurse);
                    }

                    grdNurses.DataSource = operationalGrid.nurses;
                    grdNurses.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                    grdNurses.Columns[0].Visible = false;
                    grdNurses.Columns[1].HeaderText = "Dia";
                    grdNurses.Columns[2].HeaderText = "Enfermero";
                    grdNurses.Columns[1].ReadOnly = true;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtVehicle.Text == "")
            {
                MessageBox.Show("Falta el numero de movil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Desea realizar la modificacion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if (result == DialogResult.Yes)
            {
                saveNurseList();
            }
            else
            {
                btnShowMonth_Click(sender, e);
            }
        }

        private void saveNurseList()
        {
            sqlFormattedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            operationalGrid = new OperationalGrid();

            operationalGrid.OperationalMonth = Convert.ToInt32(cmbMonth.SelectedValue.ToString());
            operationalGrid.OperationaYear = (int)nbrYear.Value;
            operationalGrid.Vehicle = txtVehicle.Text;

            if (operationalGridId < 0)
            {
                for (int i = 0; i < grdNurses.RowCount; i++)
                {
                    nurse = new Nurse();
                    nurse.OperationalDay = Convert.ToDateTime(grdNurses.Rows[i].Cells[0].Value.ToString());
                    nurse.name = grdNurses.Rows[i].Cells[1].Value.ToString();
                    operationalGrid.nurses.Add(nurse);

                }
                sql = "INSERT INTO operationalGrid (operationalMonth,operationalYear,vehicle,creation_date,id_creator) VALUES (" + Convert.ToInt32(cmbMonth.SelectedValue.ToString()) + "," + (int)nbrYear.Value + "," + txtVehicle.Text + ",'"+ sqlFormattedDate + "',"+User.Id+")";
                operationalGridId = con.insertGetID(sql, "operationalGrid");
            }
            else
            {
                for (int i = 0; i < grdNurses.RowCount; i++)
                {
                    nurse = new Nurse();
                    nurse.OperationalDay = Convert.ToDateTime(grdNurses.Rows[i].Cells[1].Value.ToString());

                    try
                    {
                        nurse.name = grdNurses.Rows[i].Cells[2].Value.ToString();
                    }
                    catch
                    {
                        nurse.name = "";
                    }
                    operationalGrid.nurses.Add(nurse);
                }
            }
            generateXml(operationalGrid.nurses);
        }


        public void generateXml(List<Nurse> nurses)
        {
            string xmlString = String.Empty;
            xmlString = string.Format("'<?xml version=\"1.0\"?>{0}<ArrayOfNurses xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">{0}", Environment.NewLine);
            foreach (Nurse nurse in nurses)
            {
                string sqlFormattedOperationalDay = nurse.OperationalDay.Date.ToString("yyyy-MM-dd");
                xmlString = xmlString + string.Format("<Nurse>{0}        <OperationalDay>" + sqlFormattedOperationalDay + "</OperationalDay>{0}", Environment.NewLine);
                xmlString = xmlString + string.Format("     <name>" + nurse.name + "</name>{0}    </Nurse>{0}", Environment.NewLine);
            }
            xmlString = xmlString + "</ArrayOfNurses>'";

            sql = "update operationalGrid set nurses = " + @xmlString + ", update_date= '"+sqlFormattedDate+"', id_updater= "+User.Id +" where id_operationalGrid = " + operationalGridId;
            if (con.insert(sql))
            {
                MessageBox.Show("Grilla operativa generada exitosamente");
            }
            else
            {
                MessageBox.Show("Error al registrar la grilla operativa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cleanForm()
        {
            cmbMonth.SelectedValue = "1";
            cmbMonth.SelectedItem = 1;
            nbrYear.Value = DateTime.Today.Year;
            txtVehicle.Text = "";
            rows = 0;
            grdNurses.DataSource = null;
            operationalGridId = -1;
            cleanGrdNurses();
        }

        private void cleanGrdNurses()
        {
            grdNurses.DataSource = null;
            for (int i = grdNurses.Rows.Count - 1; i >= 0; i--)
            {
                grdNurses.Rows.RemoveAt(i);
            }
            for (int i = grdNurses.Columns.Count - 1; i >= 0; i--)
            {
                grdNurses.Columns.RemoveAt(i);
            }
            grdNurses.Refresh();
        }
    }
}
