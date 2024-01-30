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
    public partial class FrmPendingList : Form
    {
        public FrmPendingList()
        {
            InitializeComponent();
        }
        DBConexion con = new DBConexion();
        int item;
        BuyOrder buyOrder;

        private void FrmAuthorizationList_Load(object sender, EventArgs e)
        {
            //grdBuyOrder.DataSource = con.consultSortTable("buyOrder where authorized='Pendiente' ", "request_date DESC");

            grdBuyOrder.DataSource = con.genericConsult("buyOrder", "select TOP 50 id_buyOrder, (CAST(buyOrder_number as varchar)+'/'+CAST(buyOrder_year as varchar))as number,city,request_date,destiny,to_use_in,requested_by,detail from buyOrder where authorized='Pendiente'order by request_date DESC");

            grdBuyOrder.RowHeadersVisible = false;
            grdBuyOrder.AllowUserToAddRows = false;
            grdBuyOrder.Columns[0].Visible = false;

            grdBuyOrder.Columns[1].HeaderText = "Numero";
            grdBuyOrder.Columns[2].HeaderText = "Lugar";
            grdBuyOrder.Columns[3].HeaderText = "Fecha";
            grdBuyOrder.Columns[4].HeaderText = "Destino";
            grdBuyOrder.Columns[5].HeaderText = "Utilizacion";
            grdBuyOrder.Columns[6].HeaderText = "Solicitado Por";

            DataGridViewButtonColumn buttonColumn =
            new DataGridViewButtonColumn();
            buttonColumn.Name = "Details";
            buttonColumn.HeaderText = "Detalle";
            buttonColumn.Text = "Ver Detalle";
            buttonColumn.UseColumnTextForButtonValue = true;
            grdBuyOrder.Columns.Insert(7, buttonColumn);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void grdBuyOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            item = grdBuyOrder.CurrentCell.RowIndex;
            if (e.ColumnIndex == 0 || e.ColumnIndex == 6)
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

                buyOrder.authorized = "Pendiente";

                XElement xdocument = XElement.Parse(grdBuyOrder.Rows[item].Cells[8].Value.ToString());

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

                    buyOrder.elementList.Add(elementToBuy);
                }

                FrmBuyOrderDetail frmBuyOrderDetail = new FrmBuyOrderDetail(buyOrder,"frmPendingList");
                frmBuyOrderDetail.ShowDialog();
                this.Dispose();
            }
        }
    }
}
