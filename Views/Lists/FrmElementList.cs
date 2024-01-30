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
using Views.Reports;
using Views.NewForms;
using ClassLibrary;

namespace Views.Lists
{
    public partial class FrmElementList : Form
    {
        public IElementToBuy Caller { private get; set; }
        String sql;
        public FrmElementList(String filterBy, String title)
        {
            InitializeComponent();
            sql = filterBy;
            lblTitle.Text = title;
        }

        DBConexion con = new DBConexion();
        int id;
        ElementModel elementModel = new ElementModel();
        List<ElementModel> elementModelList = new List<ElementModel>();


        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmElementList_Load(object sender, EventArgs e)
        {
            elementModelList = con.selectElementModelList(sql);


            //grdElements.DataSource = con.consultTable(sql);
            grdElements.DataSource = elementModelList;
            grdElements.RowHeadersVisible = false;
            grdElements.Columns[0].Visible = false;
            grdElements.Columns[4].Visible = false; // TOTALES

            grdElements.Columns[1].Width = 200;
            grdElements.Columns[2].Width = 100;
            grdElements.Columns[3].Width = 100;
            //grdElements.Columns[4].Width = 50;
            grdElements.Columns[5].Width = 200;
            grdElements.Columns[6].Width = 400;
            grdElements.Columns[1].HeaderText = "Nombre";
            grdElements.Columns[2].HeaderText = "Concentracion";
            grdElements.Columns[3].HeaderText = "Presentacion";
            //grdElements.Columns[4].HeaderText = "Total";
            grdElements.Columns[5].HeaderText = "Usos";
            grdElements.Columns[6].HeaderText = "Observaciones";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmNewElement frmNewElement = new FrmNewElement(new ElementModel());
            frmNewElement.ShowDialog();
            FrmElementList_Load(sender, e);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                elementModel.Id = (int)grdElements.CurrentRow.Cells[0].Value;
                elementModel.ElementName = grdElements.CurrentRow.Cells[1].Value.ToString();
                elementModel.Concentration = grdElements.CurrentRow.Cells[2].Value.ToString();
                elementModel.Presentation = grdElements.CurrentRow.Cells[3].Value.ToString();
                elementModel.Uses = grdElements.CurrentRow.Cells[4].Value.ToString();
                elementModel.Observations = grdElements.CurrentRow.Cells[5].Value.ToString();

                FrmNewElement frmNewElement = new FrmNewElement(elementModel);
                frmNewElement.ShowDialog();
                FrmElementList_Load(sender, e);
            }
            catch (System.Exception)
            {
                MessageBox.Show("Debe seleccionar un elemento", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            id = Convert.ToInt32(grdElements.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            var filter = from ElementModel elementModel in elementModelList where elementModel.ElementName.ToUpper().Contains(txtFilter.Text.ToUpper()) select elementModel;
            this.grdElements.DataSource = filter.ToList<ElementModel>();
        }

        private void grdElements_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                    return;

                DataGridViewRow row = grdElements.Rows[e.RowIndex];

                ElementToBuy elementToBuy = new ElementToBuy();

                elementToBuy.ElementName = row.Cells[1].Value.ToString();
                elementToBuy.Presentation = row.Cells[3].Value.ToString();
                elementToBuy.Concentration = row.Cells[2].Value.ToString();
                elementToBuy.Quantity = 0;
                elementToBuy.PriceOrder = "";

                //
                //Si no existe llamador para nuestro formulario nos retornamos sin hacer ninguna acción
                //
                if (Caller == null)
                    return;
                
                //Si el Form1 devolvió false por haber encontrado el Producto dentro de la lista
                //Informamos de lo sucedido al usuario
                if (!Caller.LoadDataRow(elementToBuy))
                {
                    MessageBox.Show("El Producto ya existe en la lista", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error : {0}", ex.Message), "Error Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
