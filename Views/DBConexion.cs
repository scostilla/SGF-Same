using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    class DBConexion
    {
        /*
        //SERVER CONNEXION
        private string connexionString = @"Data Source=SRVSAMERADIORDP\SQLSAME;Initial Catalog=Same;Integrated Security=False;User ID=SaSame;Password=SebaSame123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        
        //LOCALHOST CONNEXION
        private string connexionString = @"Data Source=SCOSTILLA\SQLEXPRESS;Initial Catalog=same;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        
        //SERVER PUNTA CORRARL
         private string connexionString = @"Data Source=SRVSAMERADIORDP\SQLSAME;Initial Catalog=SamePuntaCorral;Integrated Security=False;User ID=SaSame;Password=SebaSame123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        //SERVER VIR
        private string connexionString = @"Data Source=SRVSAMERADIORDP\SQLSAME;Initial Catalog=VIR;Integrated Security=False;User ID=SaSame;Password=SebaSame123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
         
        */


        public SqlConnection cn;
        private SqlCommandBuilder cmb;
        private string sql;

        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        private string connexionString;

        private SqlCommand cmd;

        private void conect(string connexionString)
        {
            cn = new SqlConnection(connexionString);
        }

        public void getConnectionString(string connection)
        {
            connexionString = connection;
        }

        public DBConexion()
        {
            if(DBConnectionString.ConnectionString == null)
            {
                
                //SAME CENTRAL - DEFAULT
                DBConnectionString.ConnectionString= @"Data Source=SRVSAMERADIORDP\SQLSAME;Initial Catalog=Same;Integrated Security=False;User ID=SaSame;Password=SebaSame123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
               
               /*
                  //LOCALHOST - DEBUG
                DBConnectionString.ConnectionString = @"Data Source=SCOSTILLA\SQLEXPRESS;Initial Catalog=same;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                */
            }

            conect(DBConnectionString.ConnectionString);
        }

        //SELECT USER 
        public int selectUser(String userName,String pass)
        {
            sql = string.Empty;
            sql = "SELECT id_user, userName, CONVERT(VARCHAR(MAX), DECRYPTBYPASSPHRASE('SQL SERVER 2008',pass)) as pass, name, lastName, userRole, activeUser FROM users where userName like '" + userName + "' and CONVERT(VARCHAR(MAX), DECRYPTBYPASSPHRASE('SQL SERVER 2008',pass)) like '" + pass + "'";

            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, cn);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, "users");

            if (ds.Tables[0].Rows.Count != 0)
            {
                User.Id = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                User.UserName = ds.Tables[0].Rows[0][1].ToString();
                User.Pass = ds.Tables[0].Rows[0][2].ToString();
                User.Name = ds.Tables[0].Rows[0][3].ToString();
                User.LastName = ds.Tables[0].Rows[0][4].ToString();
                User.UserRole = ds.Tables[0].Rows[0][5].ToString();
                User.ActiveUser = ds.Tables[0].Rows[0][6].ToString();
            }
            else {
                User.Id = -1;
            }
            return User.Id;
        }

        public void getWarehouseId()
        {
            sql = string.Empty;
            sql = "select id_base from base where name='Deposito'";
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, cn);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, "warehouse");

            if (ds.Tables[0].Rows.Count != 0)
            {
                Warehouse.IdWarehouse = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            }
        }

        //CONSULT USER
        public Boolean consultuser(String userName)
        {
            sql = string.Empty;
            sql = "select * from users where userName like '" + userName + "'";
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, cn);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, "users");
            if (ds.Tables[0].Rows.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
        public ElementModel selectElementModel(int idElementModel)
        {
            ElementModel elementModel = new ElementModel();
            sql = string.Empty;
            sql = "select * from elementModel where id_elementModel=" + idElementModel;
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, cn);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, "elementModel");

            if (ds.Tables[0].Rows.Count != 0)
            {
                elementModel.Id = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                elementModel.ElementName = ds.Tables[0].Rows[0][1].ToString();
                elementModel.Concentration = ds.Tables[0].Rows[0][2].ToString();
                elementModel.Presentation = ds.Tables[0].Rows[0][3].ToString();
                elementModel.Uses = ds.Tables[0].Rows[0][4].ToString();
                elementModel.Observations = ds.Tables[0].Rows[0][5].ToString();

                if (ds.Tables[0].Rows[0][6].ToString() != "")
                {
                    elementModel.Total = Convert.ToInt32(ds.Tables[0].Rows[0][6]);
                }
                else
                {
                    elementModel.Total = 0;
                }
            }
            return elementModel;
        }

        public List<OperativeBase> getBasesList()
        {
            OperativeBase operativeBase;
            List<OperativeBase> bases = new List<OperativeBase>();
            ds.Tables.Clear();
            da = new SqlDataAdapter("select id_base, name from base", cn);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, "operativeBase");
            for (int i = 0; i < ds.Tables["operativeBase"].Rows.Count; i++)
            {
                operativeBase = new OperativeBase();
                operativeBase.Id= Convert.ToInt32(ds.Tables["operativeBase"].Rows[i][0]);
                operativeBase.BaseName= ds.Tables["operativeBase"].Rows[i][1].ToString();
                bases.Add(operativeBase);
            }
                return bases;
        }

        public List <ElementModel> selectElementModelList(String sql)
        {
            ElementModel elementModel;
            List<ElementModel> elementModelList = new List<ElementModel>();
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, cn);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, "elementModel");

            for(int i=0;i< ds.Tables["elementModel"].Rows.Count;i++)
            {
                elementModel = new ElementModel();
                elementModel.Id = Convert.ToInt32(ds.Tables["elementModel"].Rows[i][0]);
                elementModel.ElementName = ds.Tables["elementModel"].Rows[i][1].ToString();
                elementModel.Concentration = ds.Tables["elementModel"].Rows[i][2].ToString();
                elementModel.Presentation = ds.Tables["elementModel"].Rows[i][3].ToString();
                elementModel.Uses = ds.Tables["elementModel"].Rows[i][4].ToString();
                elementModel.Observations = ds.Tables["elementModel"].Rows[i][5].ToString();

                if (ds.Tables[0].Rows[i][6].ToString() != "")
                {
                    elementModel.Total = Convert.ToInt32(ds.Tables[0].Rows[i][6]);
                }
                else
                {
                    elementModel.Total = 0;
                }
                
                elementModelList.Add(elementModel);
            }
            return elementModelList;
        }

        public List<String> selectStringList(String sql,String table)
        {
            String stringElement;
            List<String> elements= new List<String>();
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, cn);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, table);

            for (int i = 0; i < ds.Tables[table].Rows.Count; i++)
            {
                stringElement =  ds.Tables[table].Rows[i][0].ToString();

                elements.Add(stringElement);
            }
            return elements;
        }

        public Element selectElement(string lot,int idElementModel)
        {
            Element element = new Element();
            sql = string.Empty;
            sql = "select * from element where lot='" + lot + "' and id_elementModel="+ idElementModel;
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, cn);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, "element");

            if (ds.Tables[0].Rows.Count != 0)
            {
                element.Id= Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                element.IdElementModel = Convert.ToInt32(ds.Tables[0].Rows[0][1]);
                element.Lot = ds.Tables[0].Rows[0][2].ToString();
                element.ExpireDate = Convert.ToDateTime(ds.Tables[0].Rows[0][3]);
                element.Quantity = Convert.ToInt32(ds.Tables[0].Rows[0][4]);
                element.BarCode= ds.Tables[0].Rows[0][5].ToString();
            }
            return element;
        }

        public List<ElementToAlert> getAlerts(int baseId)
        {
            ElementToAlert element;
            List<ElementToAlert> list = new List<ElementToAlert>();
            sql = string.Empty;
            sql = "select el.barCode, emo.name, emo.concentration, emo.presentation, SUM(bs.quantity) as total, av.quantity as alert from baseStock bs left join element el on el.id_element = bs.id_element left join elementModel emo on emo.id_elementModel = el.id_elementModel left join alertValue av on av.id_base = bs.id_base and av.id_elementModel = emo.id_elementModel where bs.id_base = " + baseId + " and el.expireDate > GETDATE() GROUP BY el.barCode, emo.name, emo.concentration, emo.presentation, av.quantity having SUM(bs.quantity) < av.quantity order by el.barCode";

            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, cn);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, "element");

            for (int i = 0; i < ds.Tables["element"].Rows.Count; i++)
            {
                element = new ElementToAlert();
                if (ds.Tables["element"].Rows.Count != 0)
                { 
                    element.BarCode = ds.Tables["element"].Rows[i][0].ToString();
                    element.Name = ds.Tables["element"].Rows[i][1].ToString();
                    element.Presentation = ds.Tables["element"].Rows[i][2].ToString();
                    element.Concentration = ds.Tables["element"].Rows[i][3].ToString();
                    element.Total = Convert.ToInt32(ds.Tables["element"].Rows[i][4]);
                    element.Alert = Convert.ToInt32(ds.Tables["element"].Rows[i][5]);
                    list.Add(element);
                }
            }
                return list;
        }
        public List <Element> selectElement(String barCode)
        {
            Element element;
            List<Element> elements = new List<Element>();
            sql = string.Empty;
            sql = "select * from element where barCode='" + barCode + "' order by expireDate";

            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, cn);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, "element");

            for(int i = 0; i < ds.Tables["element"].Rows.Count; i++)
            {
                element = new Element();
                if (ds.Tables["element"].Rows.Count != 0)
                {
                    element.Id = Convert.ToInt32(ds.Tables["element"].Rows[i][0]);
                    element.IdElementModel = Convert.ToInt32(ds.Tables["element"].Rows[i][1]);
                    element.Lot = ds.Tables["element"].Rows[i][2].ToString();
                    element.ExpireDate = Convert.ToDateTime(ds.Tables["element"].Rows[i][3]);
                    element.Quantity = Convert.ToInt32(ds.Tables["element"].Rows[i][4]);
                    element.BarCode = ds.Tables["element"].Rows[i][5].ToString();
                    elements.Add(element);
                }
            }
            return elements;
        }
        public Element selectElement(int idElement)
        {
            Element element = new Element();
            sql = string.Empty;
            sql = "select * from element where id_element=" + idElement;
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, cn);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, "element");

            if (ds.Tables[0].Rows.Count != 0)
            {
                element.Id = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                element.IdElementModel = Convert.ToInt32(ds.Tables[0].Rows[0][1]);
                element.Lot = ds.Tables[0].Rows[0][2].ToString();
                element.ExpireDate = Convert.ToDateTime(ds.Tables[0].Rows[0][3]);
                element.Quantity = Convert.ToInt32(ds.Tables[0].Rows[0][4]);
            }
            return element;
        }

        //CONSULT TABLE
        public DataTable consultTable(string table)
        {
            sql = string.Empty;
            sql = "SELECT TOP 100 * FROM " + table;
            da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds, table);
            DataTable dt = new DataTable();
            dt = ds.Tables[table];
            return dt;
        }

        //CONSULT STOCK MOVEMENT
        public DataTable consultStock(int month,int year,int id_base,int id_element)
        {
            sql = string.Empty;
            sql = "select st.id_stock, st.creation_date as date, pr.name providerName, emo.name, emo.concentration, emo.presentation, st.lot, st.expireDate, st.quantity, ba.name baseName, st.entryDate as DepartureDate, st.residue from stock st left join provider pr on pr.id_provider = st.id_provider left join base ba on ba.id_base = st.id_base left join element el left join elementModel emo on emo.id_elementModel = el.id_elementModel on el.id_element = st.id_element where MONTH(st.creation_date)="+month+" and YEAR(st.creation_date)="+year;

            if (id_base != -1)
            {
                sql += " and ba.id_base='" + id_base + "'";
            }
            if (id_element != -1)
            {
                sql += " and emo.id_elementModel='" + id_element + "'";
            }

            da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "stock");
            DataTable dt = new DataTable();
            dt = ds.Tables["stock"];
            return dt;
        }

        //SELECT BASE STOCK
        public BaseStock selectBaseStock(int idBase,int idElement)
        {
            BaseStock baseStock = new BaseStock();
            sql = string.Empty;

            sql = "SELECT * FROM baseStock WHERE id_base=" + idBase+" AND id_element="+idElement;
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, cn);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, "baseStock");

            if (ds.Tables[0].Rows.Count != 0)
            {
                baseStock.Id = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                baseStock.IdBase = Convert.ToInt32(ds.Tables[0].Rows[0][1]);
                baseStock.IdElement = Convert.ToInt32(ds.Tables[0].Rows[0][2]);
                baseStock.Quantity = Convert.ToInt32(ds.Tables[0].Rows[0][3]);
            }
            return baseStock;
        }

        //GET STOCK
        public Stock getStock(int stockId)
        {
            Stock stock = new Stock();
            sql = string.Empty;
            sql = "select * from stock where id_stock=" + stockId;
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, cn);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, "stock");

            if (ds.Tables[0].Rows.Count != 0)
            {
                stock.Id = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                stock.InOut = Convert.ToInt32(ds.Tables[0].Rows[0][1]);
                stock.EntryDate = Convert.ToDateTime(ds.Tables[0].Rows[0][2]);
                stock.Id_provider = Convert.ToInt32(ds.Tables[0].Rows[0][3]);
                stock.Id_base = Convert.ToInt32(ds.Tables[0].Rows[0][4]);
                stock.Id_element = Convert.ToInt32(ds.Tables[0].Rows[0][5]);
                stock.Quantity = Convert.ToInt32(ds.Tables[0].Rows[0][6]);
                stock.Lot = ds.Tables[0].Rows[0][7].ToString();
                stock.ExpireDate = Convert.ToDateTime(ds.Tables[0].Rows[0][8]);
                stock.Residue = Convert.ToInt32(ds.Tables[0].Rows[0][9]);
                stock.Remit = ds.Tables[0].Rows[0][10].ToString();
                stock.Observations = ds.Tables[0].Rows[0][15].ToString();
            }
            return stock;

        }

        //CONSULT ALERT VALUE
        public AlertValue consultAlertValue(int id_base,int id_elementModel)
        {
            AlertValue alertValue = new AlertValue();
            sql = string.Empty;
            sql = "SELECT * FROM alertValue WHERE id_base=" + id_base + " AND id_elementModel=" + id_elementModel;
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, cn);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, "alertValue");

            if (ds.Tables[0].Rows.Count != 0)
            {
                alertValue.Id = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                alertValue.Id_base = Convert.ToInt32(ds.Tables[0].Rows[0][1]);
                alertValue.Id_element = Convert.ToInt32(ds.Tables[0].Rows[0][2]);
                alertValue.Quantity = Convert.ToInt32(ds.Tables[0].Rows[0][3]);
            }
            return alertValue;
        }

        //CONSULT ALERT VALUE LIST
        public DataTable consultAlertValues(int idBase, int idElementModel)
        {
            sql = string.Empty;
            sql = "select bs.name, emo.name, emo.concentration, emo.presentation, al.quantity from base bs left join alertValue al  left join elementModel emo on emo.id_elementModel = al.id_elementModel on bs.id_base=al.id_base where al.id_base= " + idBase;

            if (idElementModel != -1)
            {
                sql += " and emo.id_elementModel=" + idElementModel;
            }
            da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "alertValue");
            DataTable dt = new DataTable();
            dt = ds.Tables["alertValue"];
            return dt;
        }

        //CONSULT STOCK PER OPERATIVE BASE
        public DataTable consultStock(int id_base, int id_elementModel)
        {
            sql = string.Empty;
            sql = "select el.barCode, emo.name, emo.concentration, emo.presentation, el.lot, el.expireDate, bs.quantity as total, av.quantity from baseStock bs left join element el on el.id_element = bs.id_element left join elementModel emo on emo.id_elementModel = el.id_elementModel left join alertValue av on av.id_base=bs.id_base and av.id_elementModel=emo.id_elementModel where bs.id_base = " + id_base+ " and bs.quantity > 0";

            if (id_elementModel != -1)
            {
                sql += " and emo.id_elementModel= "+id_elementModel;
            }

            sql += " order by emo.name";

            da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "stock");
            DataTable dt = new DataTable();
            dt = ds.Tables["stock"];
            return dt;
        }

        //CONSULT STOCK PER OPERATIVE BASE GROUP BY ELEMENT MODEL
        public DataTable consultStocByElement(int id_base, int id_elementModel)
        {
            sql = string.Empty;
            sql = "select emo.name, emo.concentration, emo.presentation, SUM(bs.quantity) as total, av.quantity from baseStock bs left join element el on el.id_element = bs.id_element left join elementModel emo on emo.id_elementModel = el.id_elementModel left join alertValue av on av.id_base=bs.id_base and av.id_elementModel=emo.id_elementModel where bs.id_base = " + id_base+ " and bs.quantity > 0";

            if (id_elementModel != -1)
            {
                sql += " and emo.id_elementModel= " + id_elementModel;
            }
            sql += " GROUP BY emo.name, emo.concentration, emo.presentation, av.quantity";
            da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "stock");
            DataTable dt = new DataTable();
            dt = ds.Tables["stock"];
            return dt;
        }


        //CONSULT GENERIC VALUE
        public Object getValue(string table, string value, string condition)
        {

            // USE WITH TRY CATCH!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            cn.Close();
            sql = string.Empty;
            sql = "select " + value + " from " + table + " where " + condition;
            cn.Open();
            SqlCommand cmd = new SqlCommand(sql, cn);
            Object Value = cmd.ExecuteScalar();
            cn.Close();
            return Value;
        }

        public string getString(string table, string value, string condition)
        {

            // USE WITH TRY CATCH!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            cn.Close();
            sql = string.Empty;
            sql = "select " + value + " from " + table + " where " + condition;
            cn.Open();
            SqlCommand cmd = new SqlCommand(sql, cn);
            String Value = cmd.ExecuteScalar().ToString();
            cn.Close();
            return Value;
        }


        //GENERIC CONSULT
        public DataTable genericConsult(string table, string sql)
        {
            da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds, table);
            DataTable dt = new DataTable();
            dt = ds.Tables[table];
            return dt;
        }


        public DataTable consultElement(string table)
        {
            sql = string.Empty;
            sql = "select id_elementModel, (name +' ' +concentration+ ' - '+presentation) as elementName from elementModel order by name";
            da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds, table);
            DataTable dt = new DataTable();
            dt = ds.Tables[table];
            return dt;
        }

        public int insertGetID(string sql, string table)
        {
            cn.Open();
            cmd = new SqlCommand(sql+ ";SELECT IDENT_CURRENT('"+table+"')", cn);
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            cn.Close();
            if (id > 0)
            {
                return id;
            }
            else
            {
                return -1;
            }
        }

        //CONSULT TABLE ORDER BY
        public DataTable consultSortTable(string table,string condition)
        {
            sql = string.Empty;
            sql = "SELECT TOP 50 * FROM " + table + " ORDER BY "+ condition;
            da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds, table);
            DataTable dt = new DataTable();
            dt = ds.Tables[table];
            return dt;
        }

        //INSERT
        public bool insert(string sql)
        {
            cn.Close();
            cn.Open();
            cmd = new SqlCommand(sql, cn);
            int i = cmd.ExecuteNonQuery();
            cn.Close();

            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //REMOVE
        public bool remove(string table, string condition)
        {
            sql = string.Empty;
            cn.Open();
            sql = "DELETE FROM " + table + " WHERE " + condition;
            cmd = new SqlCommand(sql, cn);
            int i = cmd.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //UPDATE
        public bool update(string table, string fields, string condition)
        {
            sql = string.Empty;
            cn.Open();
            sql = "UPDATE " + table + " SET " + fields + " WHERE " + condition;
            cmd = new SqlCommand(sql, cn);
            int i = cmd.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
