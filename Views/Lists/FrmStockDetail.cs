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
using Views.NewForms;

namespace Views.Lists
{
    public partial class FrmStockDetail : Form
    {
        ElementModel elementModel = new ElementModel();
        Element element = new Element();
        Stock stock = new Stock();
        int stockId, elementModelId;
        DBConexion con = new DBConexion();

        public FrmStockDetail(int stockId)
        {
            this.stockId = stockId;
            InitializeComponent();
        }

        private void FrmStockDetail_Load(object sender, EventArgs e)
        {
            stock = con.getStock(stockId);

            try
            {
                elementModelId = Convert.ToInt32(con.getValue("element", "id_elementModel", "id_element=" + stock.Id_element));
            }
            catch
            {
                MessageBox.Show("Error al intentar mostrar detalles del elemento seleccionado", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            element = con.selectElement(stock.Lot, elementModelId);
            elementModel = con.selectElementModel(elementModelId);

            if (stock.InOut == 0)
            {
                lblOriginDestinyTitle.Text = "Proveedor: ";
                lblType.Text = "Ingreso";
                try
                {
                    lblOriginDestiny.Text = con.getValue("provider", "name", "id_provider=" + stock.Id_provider).ToString();
                }
                catch
                {
                    lblOriginDestiny.Text = "No especificado";
                }
            }
            else
            {
                lblOriginDestinyTitle.Text = "Base: ";
                lblType.Text = "Egreso";
                try
                {
                    lblOriginDestiny.Text = con.getValue("base", "name", "id_base=" + stock.Id_base).ToString();
                }
                catch
                {
                    lblOriginDestiny.Text = "No especificado";
                }

            }
            lblBarCode.Text = element.BarCode;
            lblRemit.Text = stock.Remit;
            lblQuantity.Text= stock.Quantity.ToString();
            lblLot.Text = stock.Lot;
            lblElement.Text = elementModel.ElementName;
            txtObservations.Text = stock.Observations;
            lblExpiration.Text = stock.ExpireDate.Day.ToString() + "/" + stock.ExpireDate.Month.ToString() + "/" + stock.ExpireDate.Year.ToString();
            lblDate.Text = stock.EntryDate.Day.ToString() + "/" + stock.EntryDate.Month.ToString() + "/" + stock.EntryDate.Year.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            FrmNewStock frmNewStock = new FrmNewStock(stockId);
            frmNewStock.Show();
        }
    }
}
