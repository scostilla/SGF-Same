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
    public partial class FrmElementsOnAlert : Form
    {
        ElementToBuy elementToBuy;
        List<ElementToBuy> elementToBuyList;
        public FrmElementsOnAlert(List<ElementToAlert> alertList)
        {
            InitializeComponent();
            grdAlertList.DataSource = alertList;
            grdAlertList.Columns[0].Visible = false;
            grdAlertList.Columns[1].ReadOnly = true;
            grdAlertList.Columns[2].ReadOnly = true;
            grdAlertList.Columns[3].ReadOnly = true;
            grdAlertList.Columns[4].ReadOnly = true;

            grdAlertList.Columns[1].HeaderText = "Codigo";
            grdAlertList.Columns[2].HeaderText = "Elemento";
            grdAlertList.Columns[3].HeaderText = "Concentracion";
            grdAlertList.Columns[4].HeaderText = "Presentacion";
            grdAlertList.Columns[5].HeaderText = "Candidad";
            grdAlertList.Columns[6].HeaderText = "Alerta";

            elementToBuyList = new List<ElementToBuy>();

            foreach (ElementToAlert element in alertList)
            {
                elementToBuy = new ElementToBuy();

                elementToBuy.ElementName = element.Name;
                elementToBuy.Presentation = element.Presentation;
                elementToBuy.Concentration = element.Concentration;
                elementToBuy.Quantity = element.Alert * 2;
                elementToBuy.PriceOrder = "";
                elementToBuyList.Add(elementToBuy);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNewCart_Click(object sender, EventArgs e)
        {
            String OperativeBase = "Deposito";
            FrmNewCart frmNewCart = new FrmNewCart(elementToBuyList, OperativeBase);
            frmNewCart.Show();
        }
    }
}
