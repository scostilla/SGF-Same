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
    public partial class FrmBuyOrderList : Form
    {
        BuyOrder buyOrder = new BuyOrder();
        List<ElementToBuy> elementList = new List<ElementToBuy>();

        public FrmBuyOrderList()
        {
            InitializeComponent();
        }

        DBConexion con = new DBConexion();
        int item;

        private void FrmBuyOrderList_Load(object sender, EventArgs e)
        {
            //grdBuyOrder.DataSource = con.consultSortTable("buyOrder", "id_buyOrder DESC");
            grdBuyOrder.DataSource = con.genericConsult("buyOrder", "select TOP 50 bo.id_buyOrder, (CAST(bo.buyOrder_number as varchar)+'/'+CAST(bo.buyOrder_year as varchar))as number,bo.city,bo.request_date,bo.destiny,bo.to_use_in,bo.requested_by,bo.authorized,bo.detail, bo.authorization_number, bo.authorization_year, bo.id_authorizer, bo.authorization_date from buyOrder as bo where bo.id_role = "+User.UserRole+" order by id_buyOrder DESC");

            grdBuyOrder.RowHeadersVisible = false;
            grdBuyOrder.AllowUserToAddRows = false;
            grdBuyOrder.Columns[0].Visible = false;
            grdBuyOrder.Columns[8].Visible = false;
            grdBuyOrder.Columns[10].Visible = false;
            grdBuyOrder.Columns[11].Visible = false;
            grdBuyOrder.Columns[12].Visible = false;
            grdBuyOrder.Columns[9].Visible = false;

            grdBuyOrder.Columns[1].HeaderText = "Numero";
            grdBuyOrder.Columns[2].HeaderText = "Lugar";
            grdBuyOrder.Columns[3].HeaderText = "Fecha";
            grdBuyOrder.Columns[4].HeaderText = "Destino";
            grdBuyOrder.Columns[5].HeaderText = "Utilizacion";
            grdBuyOrder.Columns[6].HeaderText = "Solicitado Por";
            grdBuyOrder.Columns[7].HeaderText = "Estado";

            DataGridViewButtonColumn buttonColumn =
            new DataGridViewButtonColumn();
            buttonColumn.Name = "Details";
            buttonColumn.HeaderText = "Detalle";
            buttonColumn.Text = "Ver Detalle";
            buttonColumn.UseColumnTextForButtonValue = true;
            grdBuyOrder.Columns.Insert(8, buttonColumn);
        }

        private void grdBuyOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            item = grdBuyOrder.CurrentCell.RowIndex;
            if (e.ColumnIndex == 0)
            {
                buyOrder = new BuyOrder();
                buyOrder.Id = Convert.ToInt32(grdBuyOrder.Rows[item].Cells[1].Value);

                String[] buyOrderNumber = grdBuyOrder.Rows[item].Cells[2].Value.ToString().Split('/');
                buyOrder.BuyOrderNumber = Convert.ToInt32(buyOrderNumber[0]);
                buyOrder.BuyOrderYear = Convert.ToInt32(buyOrderNumber[1]);

                buyOrder.City = grdBuyOrder.Rows[item].Cells[3].Value.ToString();
                buyOrder.RequestDate = Convert.ToDateTime(grdBuyOrder.Rows[item].Cells[4].Value.ToString());
                buyOrder.Destiny = grdBuyOrder.Rows[item].Cells[5].Value.ToString();
                buyOrder.ToUseIn = grdBuyOrder.Rows[item].Cells[6].Value.ToString();
                buyOrder.RequestedBy = grdBuyOrder.Rows[item].Cells[7].Value.ToString();

                buyOrder.authorized = grdBuyOrder.Rows[item].Cells[8].Value.ToString();

                if (buyOrder.authorized == "Autorizado")
                {
                    buyOrder.AuthorizationNumber = Convert.ToInt32(grdBuyOrder.Rows[item].Cells[10].Value);
                    buyOrder.AuthorizationYear = Convert.ToInt32(grdBuyOrder.Rows[item].Cells[11].Value);
                    
                    buyOrder.authorizedBy = con.getString("users", "lastName+', '+name as name", " id_user=" + grdBuyOrder.Rows[item].Cells[12].Value.ToString());
                    
                    buyOrder.authorizationDate = Convert.ToDateTime(grdBuyOrder.Rows[item].Cells[13].Value.ToString().Trim());
                }
                else if(buyOrder.authorized == "Descartado")
                {
                    buyOrder.authorizedBy = con.getString("users", "lastName+', '+name as name", " id_user=" + grdBuyOrder.Rows[item].Cells[12].Value.ToString());
                    buyOrder.authorizationDate = Convert.ToDateTime(grdBuyOrder.Rows[item].Cells[13].Value.ToString().Trim());
                }

                XElement xdocument = XElement.Parse(grdBuyOrder.Rows[item].Cells[9].Value.ToString());

                var list = from item in xdocument.Elements("ElementToBuy")
                           select new
                           {
                               index = item.Element("Index").Value,
                               ElementName = item.Element("ElementName").Value,
                               Presentation = item.Element("Presentation").Value,
                               Concentration = item.Element("Concentration").Value,
                               Quantity = item.Element("Egress").Value,
                               PriceOrder=item.Element("PriceOrder").Value
                           };

                foreach (var item in list)
                {
                    ElementToBuy elementToBuy = new ElementToBuy();
                    elementToBuy.Index = Convert.ToInt32(item.index);
                    elementToBuy.ElementName = item.ElementName;
                    elementToBuy.Presentation = item.Presentation;
                    elementToBuy.Concentration = item.Concentration;
                    elementToBuy.Quantity = Convert.ToInt32(item.Quantity);
                    elementToBuy.PriceOrder = item.PriceOrder;

                    buyOrder.elementList.Add(elementToBuy);
                }

                FrmBuyOrderDetail frmBuyOrderDetail =new FrmBuyOrderDetail(buyOrder, "frmBuyOrderList");
                frmBuyOrderDetail.Show();
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
