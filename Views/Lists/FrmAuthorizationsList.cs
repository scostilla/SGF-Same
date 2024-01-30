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

namespace Views.Lists
{
    public partial class FrmAuthorizationsList : Form
    {
        String calledFrom;
        public FrmAuthorizationsList(String calledFrom)
        {
            this.calledFrom = calledFrom;
            InitializeComponent();
        }
        DBConexion con = new DBConexion();
        int item;
        BuyOrder buyOrder;
        string sql;

        private void FrmAuthorizationsList_Load(object sender, EventArgs e)
        {
            sql = String.Empty;
            switch (calledFrom)
            {
                case "frmAuthorizationList":
                    sql = @"select TOP 50 bo.id_buyOrder, (CAST(bo.buyOrder_number as varchar)+'/'+CAST(bo.buyOrder_year as varchar))as number, bo.city, bo.request_date,bo.destiny, bo.to_use_in, bo.requested_by,bo.authorized, (CAST(bo.authorization_number as varchar)+'/'+CAST(bo.authorization_year as varchar))as authotization, u.lastName+', '+u.name as name, bo.authorization_date, bo.detail from buyOrder as bo inner join users as u on bo.id_authorizer = u.id_user order by id_buyOrder DESC";
                    break;
                case "PriceOrder":
                    sql = @"select TOP 50 bo.id_buyOrder, (CAST(bo.buyOrder_number as varchar)+'/'+CAST(bo.buyOrder_year as varchar))as number, bo.city, bo.request_date,bo.destiny, bo.to_use_in, bo.requested_by,bo.authorized, (CAST(bo.authorization_number as varchar)+'/'+CAST(bo.authorization_year as varchar))as authotization, u.lastName+', '+u.name as name, bo.authorization_date, bo.detail from buyOrder as bo inner join users as u on bo.id_authorizer = u.id_user and authorized='Autorizado' order by id_buyOrder DESC";
                    break;
            }
            
            grdBuyOrder.DataSource = con.genericConsult("buyOrder",sql);

            grdBuyOrder.RowHeadersVisible = false;
            grdBuyOrder.AllowUserToAddRows = false;
            grdBuyOrder.Columns[0].Visible = false;
            grdBuyOrder.Columns[11].Visible = false;

            grdBuyOrder.Columns[1].HeaderText = "N° O.C.";
            grdBuyOrder.Columns[2].HeaderText = "Lugar";
            grdBuyOrder.Columns[3].HeaderText = "Fecha Solicitud";
            grdBuyOrder.Columns[4].HeaderText = "Destino";
            grdBuyOrder.Columns[5].HeaderText = "Utilizacion";
            grdBuyOrder.Columns[6].HeaderText = "Solicitado Por";
            grdBuyOrder.Columns[7].HeaderText = "Estado";
            grdBuyOrder.Columns[8].HeaderText = "N° Autorizacion";
            grdBuyOrder.Columns[9].HeaderText = "Autorizado Por";
            grdBuyOrder.Columns[10].HeaderText = "Fecha Autorizacion";

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "Details";
            buttonColumn.HeaderText = "Detalle";
            buttonColumn.Text = "Ver Detalle";
            buttonColumn.UseColumnTextForButtonValue = true;
            grdBuyOrder.Columns.Insert(12, buttonColumn);
            
            grdBuyOrder.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

        public void setCellColors()
        {
            foreach (DataGridViewRow row in grdBuyOrder.Rows)
            {
                if (row.Cells[7].Value.ToString() == "Autorizado")
                {
                    row.Cells[7].Style.BackColor = Color.LawnGreen;
                }
                else if (row.Cells[7].Value.ToString() == "Descartado")
                {
                    row.Cells[7].Style.BackColor = Color.LightSalmon;
                }
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
                buyOrder.RequestDate = Convert.ToDateTime(grdBuyOrder.Rows[item].Cells[4].Value.ToString().Trim());
                buyOrder.Destiny = grdBuyOrder.Rows[item].Cells[5].Value.ToString().Trim();
                buyOrder.ToUseIn = grdBuyOrder.Rows[item].Cells[6].Value.ToString().Trim();
                buyOrder.RequestedBy = grdBuyOrder.Rows[item].Cells[7].Value.ToString().Trim();
                buyOrder.authorized = grdBuyOrder.Rows[item].Cells[8].Value.ToString();

                if (buyOrder.authorized == "Autorizado")
                {
                    String[] AuthorizationNumber = grdBuyOrder.Rows[item].Cells[9].Value.ToString().Split('/');
                    buyOrder.AuthorizationNumber = Convert.ToInt32(AuthorizationNumber[0]);
                    buyOrder.AuthorizationYear = Convert.ToInt32(AuthorizationNumber[1]);
                }
                
                buyOrder.authorizedBy= grdBuyOrder.Rows[item].Cells[10].Value.ToString();
                buyOrder.authorizationDate = Convert.ToDateTime(grdBuyOrder.Rows[item].Cells[11].Value.ToString().Trim());

                XElement xdocument = XElement.Parse(grdBuyOrder.Rows[item].Cells[12].Value.ToString());

                var list = from item in xdocument.Elements("ElementToBuy")
                           select new
                           {
                               index = item.Element("Index").Value,
                               ElementName = item.Element("ElementName").Value,
                               Presentation = item.Element("Presentation").Value,
                               Concentration = item.Element("Concentration").Value,
                               Quantity = item.Element("Egress").Value,
                               PriceOrder = item.Element("PriceOrder").Value
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

                    if(calledFrom== "frmAuthorizationList")
                    {
                        buyOrder.elementList.Add(elementToBuy);
                    }
                    else
                    {
                        if(calledFrom == "PriceOrder" && elementToBuy.PriceOrder == "")
                        {
                            buyOrder.elementList.Add(elementToBuy);
                        }
                    }
                }

                FrmBuyOrderDetail frmBuyOrderDetail = new FrmBuyOrderDetail(buyOrder, calledFrom);
                frmBuyOrderDetail.ShowDialog();
            }
        }
    }
}
