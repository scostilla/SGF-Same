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
using Views.Lists;
using Views.NewForms;
using Views.Reports;

namespace Views.Lists
{
    public partial class FrmBuyOrderDetail : Form
    {
        BuyOrder buyOrder = new BuyOrder();
        DBConexion con = new DBConexion();
        String calledFrom;
        int lastYear, lastNumber;
        FrmAuthorizationReport frmAuthorizationReport;

        public FrmBuyOrderDetail(BuyOrder buyOrder, String calledFrom)
        {
            InitializeComponent();
            this.buyOrder = buyOrder;
            this.calledFrom = calledFrom;
        }

        private void FrmBuyOrderDetail_Load(object sender, EventArgs e)
        {
            lblCity.Text = buyOrder.City;
            lblRequestDate.Text = buyOrder.RequestDate.ToString("dd/MM/yyyy"); ;
            lblDestiny.Text = buyOrder.Destiny;
            lblToUseIn.Text = buyOrder.ToUseIn;
            lblRequestedBy.Text = buyOrder.RequestedBy;

            grdBuyOrder.DataSource = buyOrder.elementList;
            grdBuyOrder.Columns[0].ReadOnly = true;
            grdBuyOrder.Columns[1].ReadOnly = true;
            grdBuyOrder.Columns[2].ReadOnly = true;
            grdBuyOrder.Columns[3].ReadOnly = true;
            grdBuyOrder.Columns[4].ReadOnly = true;


            switch (calledFrom)
            {
                case "frmAuthorizationList":
                    caseAuthorizationList();
                    break;
                case "frmBuyOrderList":
                    switch (buyOrder.authorized)
                    {
                        case "Autorizado":
                            caseAuthorizationList();
                            break;
                        case "Descartado":
                            caseAuthorizationList();
                            break;
                        case "Pendiente":
                            casePendingList();
                            break;
                    }
                    break;
                case "frmPendingList":
                    casePendingList();
                    break;
                case "PriceOrder":
                    casePriceOrder();
                    break;
            }

            grdBuyOrder.AllowUserToAddRows = false;

            grdBuyOrder.Columns[0].HeaderText = "Item";
            grdBuyOrder.Columns[1].HeaderText = "Nombre";
            grdBuyOrder.Columns[2].HeaderText = "Presentacion";
            grdBuyOrder.Columns[3].HeaderText = "Concentracion";
            grdBuyOrder.Columns[4].HeaderText = "Cantidad";
            grdBuyOrder.Columns[5].HeaderText = "Pedido de Precios";

            grdBuyOrder.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            switch (calledFrom)
            {
                case "frmAuthorizationList":
                    frmAuthorizationReport = new FrmAuthorizationReport(buyOrder);
                    frmAuthorizationReport.Show();
                    break;
                case "frmBuyOrderList":
                    FrmBuyOrderReport frmBuyOrderReport = new FrmBuyOrderReport(buyOrder);
                    frmBuyOrderReport.Show();
                    break;
                case "frmPendingList":
                    authorization("Autorizado");
                    break;
                case "PriceOrder":
                    generatePriceOrder();
                    break;
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {

            switch (calledFrom)
            {
                case "frmAuthorizationList":
                    break;
                case "frmBuyOrderList":
                    FrmNewCart frmNewCart = new FrmNewCart(buyOrder);
                    frmNewCart.Show();
                    break;
                case "frmPendingList":
                    authorization("Descartado");
                    break;
            }
        }

        private void authorization(String authorized)
        {
            FrmPassVerification frmPassVerification = new FrmPassVerification();
            frmPassVerification.ShowDialog();
            String sql, successMessage, ErrorMessage = String.Empty;
            string sqlFormattedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");

            buyOrder.authorized = authorized;
            buyOrder.authorizedBy=User.LastName+", "+User.Name;
            buyOrder.authorizationDate = DateTime.Now;

            if (frmPassVerification.DialogResult == DialogResult.OK)
            {
                if(authorized== "Autorizado")
                {
                    try
                    {
                        lastNumber =Convert.ToInt32(con.getValue("buyOrder", "TOP 1 authorization_number", "authorization_number!='' and authorization_year=YEAR(GETDATE()) order by authorization_number desc"));

                        /*
                        string[] splitNumber = lastAuthorizationNumber.Split('/');
                        lastNumber = Convert.ToInt32(splitNumber[0]);
                        lastYear = Convert.ToInt32(splitNumber[1]);
                        */
                        lastYear = Convert.ToInt32(con.getValue("buyOrder", "TOP 1 authorization_year", "authorization_number!='' and authorization_year=YEAR(GETDATE()) order by authorization_number desc"));
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
                    lastNumber = lastNumber + 1;
                    sql = "update buyOrder set authorized='" + authorized + "', authorization_number=" + lastNumber + ", authorization_year="+lastYear+", id_authorizer=" + User.Id + ", authorization_date='" + sqlFormattedDate + "'  where id_buyOrder=" + buyOrder.Id;
                }else
                {
                    sql = "update buyOrder set authorized='" + authorized + "', id_authorizer=" + User.Id + ", authorization_date='" + sqlFormattedDate + "'  where id_buyOrder=" + buyOrder.Id;
                }

                successMessage = "O.C. modificada correctamente";
                ErrorMessage = "Error al modificar la O.C.";

                if (con.insert(sql))
                {
                    MessageBox.Show(successMessage);
                    frmAuthorizationReport = new FrmAuthorizationReport(buyOrder);
                    frmAuthorizationReport.ShowDialog();
                }
                else
                {
                    MessageBox.Show(ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                return;
            }
            this.Dispose();
        }

        private void showLabels(Boolean value)
        {
            lblAuthorizationDate.Visible = value;
            lblAuthorizationDateTitle.Visible = value;
            lblAuthorized.Visible = value;
            lblAuthorizedTitle.Visible = value;
            lblAuthorizedBy.Visible = value;
            lblAuthorizedByTitle.Visible = value;
            btnModify.Visible = !value;
        }

        private void generatePriceOrder()
        {
            //nueva pantalla con el listado de elementos seleccionados y las opciones 
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void caseAuthorizationList()
        {
            showLabels(true);
            if (buyOrder.authorized == "Descartado")
            {
                lblTitle.Text = "Orden de Compra Descartada";
            }
            else
            {
                lblTitle.Text = "Autorizacion N° " + buyOrder.AuthorizationNumber + "/" + buyOrder.AuthorizationYear;
            }
            lblAuthorizationDate.Text = buyOrder.authorizationDate.ToString("dd/MM/yyyy");
            lblSubTitle.Text = "O.C.: " + buyOrder.BuyOrderNumber + "/" + buyOrder.BuyOrderYear;
            lblAuthorized.Text = buyOrder.authorized.ToString();
            lblAuthorizedBy.Text = buyOrder.authorizedBy.ToString();
            btnPrint.Text = "Imprimir";
            grdBuyOrder.Columns[5].Visible = false;
            grdBuyOrder.Columns[6].Visible = false;
        }

        private void caseBuyOrderList()
        {
            lblTitle.Text = "Orden de Compra N° " + buyOrder.BuyOrderNumber + "/" + buyOrder.BuyOrderYear;
            lblSubTitle.Text = "";
            showLabels(false);
            btnModify.Text = "Modificar";
            btnPrint.Text = "Imprimir";
            if (buyOrder.authorized != "Autorizado")
            {
                btnModify.Enabled = true;
            }
            else
            {
                btnModify.Enabled = false;
            }
            grdBuyOrder.Columns[5].Visible = false;
            grdBuyOrder.Columns[6].Visible = false;
        }

        private void casePendingList()
        {
            lblTitle.Text = "Orden de Compra N° " + buyOrder.BuyOrderNumber + "/" + buyOrder.BuyOrderYear;
            lblSubTitle.Text = "Pendiente de Autorización";
            showLabels(false);
            btnModify.Text = "Descartar";
            btnPrint.Text = "Autorizar";
            grdBuyOrder.Columns[5].Visible = false;
            grdBuyOrder.Columns[6].Visible = false;
            grbAuthorization.Visible = false;
        }

        private void casePriceOrder()
        {
            lblTitle.Text = "Autorizacion N° " + buyOrder.AuthorizationNumber + "/" + buyOrder.AuthorizationYear;
            lblSubTitle.Text = "O.C.: " + buyOrder.BuyOrderNumber + "/" + buyOrder.BuyOrderYear;
            showLabels(true);
            lblAuthorizationDate.Text = buyOrder.authorizationDate.ToString("dd/MM/yyyy");
            lblAuthorized.Text = buyOrder.authorized.ToString();
            lblAuthorizedBy.Text = buyOrder.authorizedBy.ToString();
            btnPrint.Text = "Generar";
            DataGridViewCheckBoxColumn chkColumn = new DataGridViewCheckBoxColumn();
            chkColumn.ValueType = typeof(bool);
            chkColumn.Name = "Chk";
            chkColumn.HeaderText = "Seleccionar";
            grdBuyOrder.Columns.Insert(6, chkColumn);
            grdBuyOrder.Columns[5].Visible = false;
        }
    }
}
