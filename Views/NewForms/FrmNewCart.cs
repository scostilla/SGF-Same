using ClassLibrary;
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
using System.Xml.Serialization;
using Views.Lists;
using Views.Reports;

namespace Views.NewForms
{
    public partial class FrmNewCart : Form, IElementToBuy
    {
        public IElementToBuy Caller { private get; set; }
        private static readonly List<ElementToBuy> Products = new List<ElementToBuy>();
        public List<ElementToBuy> ElementToBuyList { get; set; }
        DBConexion con = new DBConexion();
        BuyOrder buyOrder = new BuyOrder();
        int buyOrderId, item, detailItems,lastYear,lastNumber,maxQuantity;
        String sql, sqlFormattedDate, sqlFormattedRequestDate,successMessage;
        Boolean isUpdate;

        public FrmNewCart()
        {
            InitializeComponent();
            ElementToBuyList = new List<ElementToBuy>();
            detailItems = 0;
            isUpdate = false;
        }

        public FrmNewCart(BuyOrder buyOrder)
        {
            Products.Clear();
            ElementToBuyList = buyOrder.elementList;
            this.buyOrder = buyOrder;
            InitializeComponent();
            isUpdate = true;
            txtToUseIn.Text = buyOrder.ToUseIn;

            foreach (ElementToBuy element in ElementToBuyList)
            {
                Products.Add(element);
            }
        }

        public FrmNewCart(List<ElementToBuy> ElementToBuy, String OperativeBase)
        {
            Products.Clear();
            ElementToBuyList = new List<ElementToBuy>();
            InitializeComponent();
            isUpdate = false;
            if (ElementToBuy == null || ElementToBuy.Count == 0)
            {
                ElementToBuyList = new List<ElementToBuy>();
            }
            else
            {
                ElementToBuyList = ElementToBuy;
            }

            foreach (ElementToBuy element in ElementToBuyList)
            {
                Products.Add(element);
            }


            if (OperativeBase.Contains("USE")||isUpdate)
            {
                txtToUseIn.Text = OperativeBase;
            }
            else
            {
                txtToUseIn.Text = "Base "+ OperativeBase;
            }
        }

        private void FrmNewCart_Load(object sender, EventArgs e)
        {
            grdBuyOrder.DataSource = ElementToBuyList;
            grdBuyOrder.AllowUserToAddRows = false;

            grdBuyOrder.Columns[0].Width = 50;
            grdBuyOrder.Columns[1].Width = 200;
            grdBuyOrder.Columns[2].Width = 100;
            grdBuyOrder.Columns[3].Width = 100;
            grdBuyOrder.Columns[4].Width = 50;
            grdBuyOrder.Columns[5].Visible = false;
            grdBuyOrder.Columns[6].Visible = false;

            grdBuyOrder.Columns[0].HeaderText = "Item";
            grdBuyOrder.Columns[1].HeaderText = "Nombre";
            grdBuyOrder.Columns[2].HeaderText = "Presentacion";
            grdBuyOrder.Columns[3].HeaderText = "Concentracion";
            grdBuyOrder.Columns[4].HeaderText = "Cantidad";
            //grdBuyOrder.Columns[5].HeaderText = "Pedido de Precios";
            //grdBuyOrder.Columns[5].ReadOnly = true;
            maxQuantity = 100; // cantidad maxima de elementos a agregar

            if (isUpdate)
            {
                txtCity.Text = buyOrder.Destiny;
                txtRequestedBy.Text = buyOrder.RequestedBy;
                dtpRequestedDate.Value = buyOrder.RequestDate;
                txtDestiny.Text = buyOrder.Destiny;
                btnGenerate.Text = "Modificar";
                //item = grdBuyOrder.Rows.Count;
                detailItems = grdBuyOrder.Rows.Count;

            }
            else
            {
                txtCity.Text = "San Salvador de Jujuy";
                txtRequestedBy.Text = User.LastName + ", " + User.Name;
                btnGenerate.Text = "Generar O.C.";
                grdBuyOrder.Columns[5].Visible = false;
                grdBuyOrder.Columns[6].Visible = false;
            }
            dtpRequestedDate.Format = DateTimePickerFormat.Custom;
            dtpRequestedDate.CustomFormat = "dd/MM/yyyy";

            for (int i = 0; i < grdBuyOrder.Rows.Count; i++)
            {
                grdBuyOrder.Rows[i].Cells[0].Value = i+1;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (detailItems < maxQuantity)
            {
                Products.Clear();

                foreach (ElementToBuy element in ElementToBuyList)
                {
                    Products.Add(element);
                }

                FrmElementList frmElementList = new FrmElementList("select * from elementModel", "Listado de Elementos");
                frmElementList.Caller = this;
                frmElementList.ShowDialog();
            }
            else
            {
                MessageBox.Show("Solo puede agregar hasta "+ maxQuantity + " elementos por Orden de Provisión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        public bool LoadDataRow(ElementToBuy elementToBuy)
        {
            detailItems = grdBuyOrder.Rows.Count;
            if (detailItems >= maxQuantity)
            {
                MessageBox.Show("Solo puede agregar hasta " + maxQuantity + " elementos por Orden de Provisión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            //Busca si el Articulo ya se encuentra en la lista
            bool exists = Products.Any(x => x.ElementName.Equals(elementToBuy.ElementName)&& x.Presentation.Equals(elementToBuy.Presentation)&& x.Concentration.Equals(elementToBuy.Concentration));

            

            //Preguntamos por el resultado de la búsqueda del Articulo dentro de la lista
            if (!exists)
            {
                Products.Add(elementToBuy);
                ElementToBuyList.Add(elementToBuy);

                detailDataSource(Products);
                // 
                //Retornamos True
                return true;
            }
            //
            //Si la condición exists es igual a False, es decir, que el producto SI existe en la lista
            //retornamos FALSE para mostrar un mensaje información
            return false;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if ((txtCity.Text=="") || (txtDestiny.Text=="") || (txtRequestedBy.Text=="") ||(txtToUseIn.Text==""))
            {
                MessageBox.Show("Faltan campos por completar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (grdBuyOrder.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un elemento a la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < grdBuyOrder.Rows.Count; i++)
            {
                if (Convert.ToInt32(grdBuyOrder.Rows[i].Cells[4].Value) < 1)
                {
                    MessageBox.Show("Hay elementos con cantidades incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            sql = String.Empty;

            buyOrder.City = txtCity.Text.Trim(' ');
            buyOrder.RequestDate = dtpRequestedDate.Value;
            buyOrder.Destiny = txtDestiny.Text.Trim(' ');
            buyOrder.ToUseIn = txtToUseIn.Text.Trim(' ');
            buyOrder.RequestedBy = txtRequestedBy.Text.Trim(' ');
            buyOrder.IdRole = Convert.ToInt32(User.UserRole);

            if (!isUpdate)
            {
                ElementToBuy elementToBuy;

                for (int i = 0; i < grdBuyOrder.Rows.Count; i++)
                {
                    elementToBuy = new ElementToBuy();

                    elementToBuy.Index = Convert.ToInt32(grdBuyOrder.Rows[i].Cells[0].Value);
                    elementToBuy.ElementName = grdBuyOrder.Rows[i].Cells[1].Value.ToString().Trim(' ');
                    elementToBuy.Presentation = grdBuyOrder.Rows[i].Cells[2].Value.ToString().Trim(' ');
                    elementToBuy.Concentration = grdBuyOrder.Rows[i].Cells[3].Value.ToString().Trim(' ');
                    elementToBuy.Quantity = Convert.ToInt32(grdBuyOrder.Rows[i].Cells[4].Value);

                    try
                    {
                        elementToBuy.PriceOrder = grdBuyOrder.Rows[i].Cells[5].Value.ToString().Trim(' ');
                    }
                    catch
                    {
                        elementToBuy.PriceOrder = ".";
                    }

                    buyOrder.elementList.Add(elementToBuy);
                }

                try
                {
                    lastNumber = Convert.ToInt32(con.getValue("buyOrder", "buyOrder_number", "id_buyOrder=(select top 1 id_buyOrder from buyOrder order by id_buyOrder DESC)"));

                    /*
                    string[] splitNumber = lastBuyOrderNumber.Split('/');
                    lastNumber = Convert.ToInt32(splitNumber[0]);
                    */

                    lastYear = Convert.ToInt32(con.getValue("buyOrder", "buyOrder_year", "id_buyOrder=(select top 1 id_buyOrder from buyOrder order by id_buyOrder DESC)"));
                }
                catch
                {
                    lastYear = DateTime.Now.Year;
                    lastNumber = 0;
                }
                if((DateTime.Now.Year - lastYear) > 0)
                {
                    lastYear = DateTime.Now.Year;
                    lastNumber = 0;
                }

                sqlFormattedDate = DateTime.Now.ToString("yyyy-MM-dd");
                lastNumber = lastNumber + 1;
                sqlFormattedRequestDate = buyOrder.RequestDate.Date.ToString("yyyy-MM-dd");
                sql = "INSERT INTO buyOrder (city,Request_date,destiny,to_use_in,Requested_by,id_creator,creation_date,authorized,buyOrder_number,buyOrder_year,id_role) VALUES('" + buyOrder.City + "','" + sqlFormattedRequestDate + "','" + buyOrder.Destiny + "','" + buyOrder.ToUseIn + "','" + buyOrder.RequestedBy + "'," + User.Id + ",'" + sqlFormattedDate + "','Pendiente',"+ lastNumber + ","+ lastYear + ","+ buyOrder.IdRole +")";

                buyOrderId = con.insertGetID(sql, "buyOrder");
            }
            else
            {
                buyOrderId = buyOrder.Id;
                sqlFormattedDate = DateTime.Now.ToString("yyyy-MM-dd");
                sqlFormattedRequestDate = buyOrder.RequestDate.Date.ToString("yyyy-MM-dd");
                sql = "update buyOrder set city = '"+ buyOrder.City + "', Request_date = '"+buyOrder.RequestDate+"', destiny = '"+ buyOrder.Destiny + "', to_use_in = '"+ buyOrder.ToUseIn + "', Requested_by = '"+ buyOrder.RequestedBy + "', id_updater = '"+ User.Id + "', update_date = '"+ sqlFormattedDate + ", id_role = "+buyOrder.IdRole +"' where id_buyOrder = " + buyOrderId;

                if (con.insert(sql))
                {
                    successMessage = "Pedido de provisión modificado exitosamente";
                }
                else
                {
                    MessageBox.Show("Error al intentar generar el Pedido de provisión");
                    return;
                }
            }

            if (buyOrderId < 0)
            {
                MessageBox.Show("Error al generar la orden de compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                generateXml(buyOrder.elementList);
                buyOrder = new BuyOrder();
                isUpdate = false;
            }

            btnClean_Click(sender, e);
        }

        public void generateXml(List<ElementToBuy> elementList)
        {
            string xmlString = String.Empty;
            xmlString = string.Format("'<?xml version=\"1.0\"?>{0}<ArrayOfElementToBuy xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">{0}", Environment.NewLine);
            foreach (ElementToBuy element in elementList)
            {
                xmlString = xmlString + string.Format("<ElementToBuy>{0}        <Index>" + element.Index +"</Index>{0}", Environment.NewLine);
                xmlString = xmlString + string.Format("     <ElementName>" + element.ElementName + "</ElementName>{0}", Environment.NewLine);
                xmlString = xmlString + string.Format("     <Presentation>" + element.Presentation + "</Presentation>{0}", Environment.NewLine);
                xmlString = xmlString + string.Format("     <Concentration>" + element.Concentration + "</Concentration>{0}", Environment.NewLine);
                xmlString = xmlString + string.Format("     <Egress>" + element.Quantity + "</Egress>{0}", Environment.NewLine);
                xmlString = xmlString + string.Format("     <PriceOrder>" + element.PriceOrder + "</PriceOrder>{0}    </ElementToBuy>{0}", Environment.NewLine);
            }
            xmlString = xmlString + "</ArrayOfElementToBuy>'";

            sql = "update buyOrder set detail = " + @xmlString + " where id_buyOrder = " + buyOrderId;
            if (con.insert(sql))
            {
                successMessage = "Pedido de provisión generado exitosamente";
            }
            else
            {
                MessageBox.Show("Error al intentar generar el Pedido de provisión");
                return;
            }
            MessageBox.Show(successMessage);
            FrmBuyOrderReport frmBuyOrderReport = new FrmBuyOrderReport(buyOrder);
            frmBuyOrderReport.Show();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            detailItems = 0;
            ElementToBuyList = new List<ElementToBuy>();
            Products.Clear();
            txtDestiny.Text = "";
            txtToUseIn.Text = "";
            buyOrder = new BuyOrder();
            FrmNewCart_Load(sender, e);
            isUpdate = false;
            lastNumber = -1;
            lastYear = 1;
        }

        private void grdBuyOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            item = grdBuyOrder.CurrentCell.RowIndex;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Products.Count < 1) return;
            
            Products.RemoveAt(item);
            ElementToBuyList.RemoveAt(item);
            detailDataSource(Products);
            detailItems = -1;
            
            if (Products.Count  > 0)
            {
            item = grdBuyOrder.CurrentCell.RowIndex;
            }
        }
        

        private void grdBuyOrder_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column4_KeyPress);
            if (grdBuyOrder.CurrentCell.ColumnIndex == 4)
            {
                TextBox tb = e.Control as TextBox;
                if(tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column4_KeyPress);
                }
            }
        }
        private void Column4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void detailDataSource(List<ElementToBuy> Products)
        {
            grdBuyOrder.AutoGenerateColumns = false;
            grdBuyOrder.DataSource = null;
            //Establecemos el DataSource del DataGridView enlazándolo a la lista
            //genérica
            grdBuyOrder.DataSource = Products;
            //
            //Mapeamos las propiedades a las columnas
            grdBuyOrder.Columns[1].DataPropertyName = "ElementName";
            grdBuyOrder.Columns[2].DataPropertyName = "Presentation";
            grdBuyOrder.Columns[3].DataPropertyName = "Concentration";
            grdBuyOrder.Columns[4].DataPropertyName = "Egress";
            detailItems = grdBuyOrder.Rows.Count;
            
            for (int i = 0; i < grdBuyOrder.Rows.Count; i++)
            {
                grdBuyOrder.Rows[i].Cells[0].Value = i + 1;
            }
            grdBuyOrder.Columns[0].ReadOnly = true;
        }

        
    }
}
