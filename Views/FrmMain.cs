using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Views.Lists;
using Views.NewForms;


namespace Views
{
    public partial class FrmMain : Form
    {
        List<ElementToAlert> alertList = new List<ElementToAlert>();
        DBConexion con = new DBConexion();
        public FrmMain()
        {
            InitializeComponent();
            //this.Text = "SAME 107 - Version "+ Application.ProductVersion;
            userAccess();
            showAlerts();
        }

        private void showAlerts()
        {
            alertList = con.getAlerts(Warehouse.IdWarehouse);
            if (alertList.Count > 0)
            {
                FrmElementsOnAlert frmElementsOnAlert = new FrmElementsOnAlert(alertList);
                frmElementsOnAlert.MdiParent = this;
                frmElementsOnAlert.Show();
            }
        }

        private void userAccess(Boolean pharmacyValue, Boolean purchaseValue, Boolean newListValue, Boolean listValue, Boolean authorizationsValue, Boolean userValue, Boolean testValue)
        {
            TsmPharmacy.Visible = pharmacyValue;
            TsmNewList.Visible = newListValue;
            TsmLists.Visible = listValue;
            TsmPurchase.Visible = purchaseValue;
            TsmAuthorizations.Visible = authorizationsValue;
            TsmUser.Visible = userValue;
            TsmTest.Visible = testValue;
        }

        private void userAccess()
        {
            if (User.ActiveUser == "admin")
            {
                //        pharm,compr,list, new, auth, user, test
                userAccess(true, true, true, true, true, true, true);
            }
            else
            {//           pharm,compr,  list,  new,   auth,  user,  test
                userAccess(false, false, false, false, false, false, false);

                switch (Convert.ToInt32(User.UserRole))
                {
                    case 1:
                        {
                            //all access
                            //        pharm,compr,list, new, auth, user, test
                            userAccess(true, true, true, true, true, true, true);
                            break;
                        }
                    case 2:
                        {
                            //directivos ven todo excepto ABM usuarios
                            //        pharm,compr,list, new,  auth, user,  test
                            userAccess(true, true, true, true, true, false, false);
                            break;
                        }
                    case 3:
                        {
                            //farmacia
                            //        pharm,compr, list, new,  auth,  user,  test
                            userAccess(true, false, true, true, false, false, false);
                            break;
                        }
                    case 4:
                        {
                            //compras
                            //        pharm, compr,list, new,  auth,  user,  test
                            userAccess(false, true, true, true, false, false, false);
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Error en permisos de acceso,comuniquese con el administrador del sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }

                }
            }

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            txtUserData.Text = "Usuario: " + User.LastName + ", " + User.Name;
            this.Text = "SAME 107 V. " + DBConnectionString.VersionNumber + " - " + DBConnectionString.DBName;
        }

        private FrmNewElement newElement = null;
        FrmNewProvider newProvider = null;
        FrmNewBase newBase = null;
        FrmProviderList frmProviderList = null;
        FrmBaseList frmBaseList = null;
        FrmNewStock frmNewStock = null;
        FrmStockList frmStockList = null;
        FrmNewEgress frmNewEgress = null;
        FrmElementList frmElementList = null;
        FrmNewUser frmNewUser = null;
        FrmNewCart frmNewCart = null;
        FrmNewAlertValue frmNewAlertValue = null;
        FrmBasesStock frmBasesStock = null;
        FrmBuyOrderList frmBuyOrderList = null;
        FrmAlertValuesList frmAlertValuesList = null;
        FrmMedicineTrace frmMedicineTrace = null;
        FrmNurseList frmNurseList = null;
        FrmControlSheet frmControlSheet = null;
        FrmContorlSheetTotals frmContorlSheetTotals = null;
        //FrmNewCart frmNewCart = null;
        //FrmNewUser frmNewUser = null;
        FrmUsersList frmUsersList = null;
        FrmPendingList frmPendingList = null;
        FrmAuthorizationsList frmAuthorizationsList = null;
        FrmMedicineDestructionList frmMedicineDestructionList = null;
        FrmNewMedicineDestruction frmNewMedicineDestruction = null;
        FrmNewChangeOfMedicine frmNewChangeOfMedicine = null;
        //FrmMedicineDestructionList frmMedicineDestructionList = null;
        FrmChangeOfMedicinesList frmChangeOfMedicinesList = null;
        public FrmStockControl frmStockControl = null;

        private FrmNewElement NewElementInstance
        {
            get
            {
                if (newElement != null)
                {
                    newElement.Dispose();
                }
                newElement = new FrmNewElement(new ElementModel());
                return newElement;
            }
        }
        private void btnNewElement_Click(object sender, EventArgs e)
        {
            FrmNewElement newElement = this.NewElementInstance;
            newElement.MdiParent = this;
            newElement.Show();
            newElement.BringToFront();
        }

        private FrmNewProvider NewProviderInstance
        {
            get
            {
                if (newProvider != null)
                {
                    newProvider.Dispose();
                }
                newProvider = new FrmNewProvider(new Provider());
                return newProvider;
            }
        }
        private void btnNewProvider_Click(object sender, EventArgs e)
        {
            FrmNewProvider newProvider = this.NewProviderInstance;
            newProvider.MdiParent = this;
            newProvider.Show();
            newProvider.BringToFront();
        }

        private FrmNewBase NewBaseInstance
        {
            get
            {
                if (newBase != null)
                {
                    newBase.Dispose();
                }
                newBase = new FrmNewBase(new OperativeBase());
                return newBase;
            }
        }
        private void btnNewBase_Click(object sender, EventArgs e)
        {
            FrmNewBase newBase = this.NewBaseInstance;
            newBase.MdiParent = this;
            newBase.Show();
            newBase.BringToFront();
        }

        private FrmProviderList ProviderListInstance
        {
            get
            {
                if (frmProviderList != null)
                {
                    frmProviderList.Dispose();
                }
                frmProviderList = new FrmProviderList();
                return frmProviderList;
            }
        }

        private void btnProviderList_Click(object sender, EventArgs e)
        {
            FrmProviderList frmProviderList = this.ProviderListInstance;
            frmProviderList.MdiParent = this;
            frmProviderList.Show();
            frmProviderList.BringToFront();
        }

        private FrmBasesStock frmBasesStockInstance
        {
            get
            {
                if (frmBasesStock != null)
                {
                    frmBasesStock.Dispose();
                }
                frmBasesStock = new FrmBasesStock();
                return frmBasesStock;
            }
        }
        private void btnBaseStock_Click(object sender, EventArgs e)
        {
            FrmBasesStock frmBasesStock = this.frmBasesStockInstance;
            frmBasesStock.MdiParent = this;
            frmBasesStock.Show();
            frmBasesStock.BringToFront();
        }

        private FrmBaseList BaseListInstance
        {
            get
            {
                if (frmBaseList != null)
                {
                    frmBaseList.Dispose();
                }
                frmBaseList = new FrmBaseList();
                return frmBaseList;
            }
        }
        private void btnBaseList_Click(object sender, EventArgs e)
        {
            FrmBaseList frmBaseList = this.BaseListInstance;
            frmBaseList.MdiParent = this;
            frmBaseList.Show();
            frmBaseList.BringToFront();
        }

        private FrmNewStock NewStockInstance
        {
            get
            {
                if (frmNewStock != null)
                {
                    frmNewStock.Dispose();
                }
                frmNewStock = new FrmNewStock(-1);
                return frmNewStock;
            }
        }
        private void btnNewStock_Click(object sender, EventArgs e)
        {
            FrmNewStock frmNewStock = this.NewStockInstance;
            frmNewStock.MdiParent = this;
            frmNewStock.Show();
            frmNewStock.BringToFront();
        }

        private FrmStockList StockListInstance
        {
            get
            {
                if (frmStockList != null)
                {
                    frmStockList.Dispose();
                }
                frmStockList = new FrmStockList();
                return frmStockList;
            }
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            FrmStockList frmStockList = this.StockListInstance;
            frmStockList.MdiParent = this;
            frmStockList.Show();
            frmStockList.BringToFront();
        }

        private FrmNewEgress NewEgressInstance
        {
            get
            {
                if (frmNewEgress != null)
                {
                    frmNewEgress.Dispose();
                }
                frmNewEgress = new FrmNewEgress();
                return frmNewEgress;
            }
        }
        private void btnNewEgress_Click(object sender, EventArgs e)
        {
            FrmNewEgress frmNewEgress = this.NewEgressInstance;
            frmNewEgress.MdiParent = this;
            frmNewEgress.Show();
            frmNewEgress.BringToFront();
        }

        private void callFrmElementList(String filterBy, String title)
        {
            FrmElementList frmElementList = new FrmElementList(filterBy, title);
            frmElementList.MdiParent = this;
            frmElementList.Show();
        }

        private void btnElementList_Click(object sender, EventArgs e)
        {
            callFrmElementList("select * from elementModel", "Listado de Elementos");
        }

        private void btnMedicines_Click(object sender, EventArgs e)
        {
            callFrmElementList("select * from elementModel where (presentation like 'comprimidos' or presentation like'crema' or presentation like'Jarabe - Gotas')", "Listado de Medicamentos");
        }

        private void btnBlister_Click(object sender, EventArgs e)
        {
            callFrmElementList("select * from elementModel where presentation like 'Ampolla'", "Listado de Ampollas");
        }

        private void btnDisposable_Click(object sender, EventArgs e)
        {
            callFrmElementList("select * from elementModel where presentation like 'Descartables'", "Listado de Descartables");
        }

        private void btnPsychotropic_Click(object sender, EventArgs e)
        {
            callFrmElementList("select * from elementModel where presentation like 'Psicofarmaco'", "Listado de Psicofarmacos");
        }

        private void btnCleaning_Click(object sender, EventArgs e)
        {
            callFrmElementList("select * from elementModel where presentation like 'Limpieza'", "Listado de Limpieza");
        }

        private void btnSolutions_Click(object sender, EventArgs e)
        {
            callFrmElementList("select * from elementModel where presentation like 'Soluciones'", "Listado de Soluciones");
        }

        private void btnAntiseptics_Click(object sender, EventArgs e)
        {
            callFrmElementList("select * from elementModel where presentation like 'Antisepticos'", "Listado de Antisépticos");
        }

        private void btnModifyUser_Click(object sender, EventArgs e)
        {
            FrmNewUser frmNewUser = new FrmNewUser(true);
            frmNewUser.ShowDialog();
            if (frmNewUser.DialogResult == DialogResult.OK)
            {
                txtUserData.Text = "Usuario: " + User.LastName + ", " + User.Name;
            }
        }

        private FrmNewAlertValue NewAlertValueInstance
        {
            get
            {
                if (frmNewAlertValue != null)
                {
                    frmNewAlertValue.Dispose();
                }
                frmNewAlertValue = new FrmNewAlertValue();
                return frmNewAlertValue;
            }
        }
        private void btnNewAlertValue_Click(object sender, EventArgs e)
        {
            FrmNewAlertValue frmNewAlertValue = this.NewAlertValueInstance;
            frmNewAlertValue.MdiParent = this;
            frmNewAlertValue.Show();
            frmNewAlertValue.BringToFront();
        }

        private FrmBasesStock BasesStockInstance
        {
            get
            {
                if (frmBasesStock != null)
                {
                    frmBasesStock.Dispose();
                }
                frmBasesStock = new FrmBasesStock();
                return frmBasesStock;
            }
        }
        private void btnBasesStock_Click(object sender, EventArgs e)
        {
            FrmBasesStock frmBasesStock = this.BasesStockInstance;
            frmBasesStock.MdiParent = this;
            frmBasesStock.Show();
            frmBasesStock.BringToFront();
        }

        private FrmBuyOrderList BuyOrderListInstance
        {
            get
            {
                if (frmBuyOrderList != null)
                {
                    frmBuyOrderList.Dispose();
                }
                frmBuyOrderList = new FrmBuyOrderList();
                return frmBuyOrderList;
            }
        }
        private void btnBuyOrderList_Click(object sender, EventArgs e)
        {
            FrmBuyOrderList frmBuyOrderList = this.BuyOrderListInstance;
            frmBuyOrderList.MdiParent = this;
            frmBuyOrderList.Show();
            frmBuyOrderList.BringToFront();
        }
        private FrmAlertValuesList AlertValueListInstance
        {
            get
            {
                if (frmAlertValuesList != null)
                {
                    frmAlertValuesList.Dispose();
                }
                frmAlertValuesList = new FrmAlertValuesList();
                return frmAlertValuesList;
            }
        }
        private void btnAlertValueList_Click(object sender, EventArgs e)
        {
            FrmAlertValuesList frmAlertValuesList = this.AlertValueListInstance;
            frmAlertValuesList.MdiParent = this;
            frmAlertValuesList.Show();
            frmAlertValuesList.BringToFront();
        }
        private FrmMedicineTrace MedicineTraceInstance
        {
            get
            {
                if (frmMedicineTrace != null)
                {
                    frmMedicineTrace.Dispose();
                }
                frmMedicineTrace = new FrmMedicineTrace();
                return frmMedicineTrace;
            }
        }
        private void btnMedicineTraceability_Click(object sender, EventArgs e)
        {
            FrmMedicineTrace frmMedicineTrace = this.MedicineTraceInstance;
            frmMedicineTrace.MdiParent = this;
            frmMedicineTrace.Show();
            frmMedicineTrace.BringToFront();
        }

        private FrmNurseList frmNewInstance
        {
            get {
                if (frmNurseList != null)
                {
                    frmNurseList.Dispose();
                }
                frmNurseList = new FrmNurseList();
                return frmNurseList;
            }
        }
        private void btnNurses_Click(object sender, EventArgs e)
        {
            FrmNurseList frmNurseList = this.frmNewInstance;
            frmNurseList.MdiParent = this;
            frmNurseList.Show();
            frmNurseList.BringToFront();
        }

        private FrmControlSheet FrmControlSheetInstance
        {
            get
            {
                if (frmControlSheet != null)
                {
                    frmControlSheet.Dispose();
                }
                frmControlSheet = new FrmControlSheet();
                return frmControlSheet;
            }
        }
        private void btnControlSheet_Click(object sender, EventArgs e)
        {
            FrmControlSheet frmControlSheet = this.FrmControlSheetInstance;
            frmControlSheet.MdiParent = this;
            frmControlSheet.Show();
            frmControlSheet.BringToFront();
        }

        private FrmContorlSheetTotals ContorlSheetTotalsInstance
        {
            get
            {
                if (frmContorlSheetTotals != null)
                {
                    frmContorlSheetTotals.Dispose();
                }
                frmContorlSheetTotals = new FrmContorlSheetTotals();
                return frmContorlSheetTotals;
            }
        }
        private void btnControlSheetTotals_Click(object sender, EventArgs e)
        {
            FrmContorlSheetTotals frmContorlSheetTotals = this.ContorlSheetTotalsInstance;
            frmContorlSheetTotals.MdiParent = this;
            frmContorlSheetTotals.Show();
            frmContorlSheetTotals.BringToFront();
        }
        private FrmNewCart FrmNewCartInstance
        {
            get
            {
                if (frmNewCart != null)
                {
                    frmNewCart.Dispose();
                }
                frmNewCart = new FrmNewCart();
                return frmNewCart;
            }
        }
        private void btnNewOC_Click(object sender, EventArgs e)
        {
            FrmNewCart frmNewCart = this.FrmNewCartInstance;
            frmNewCart.MdiParent = this;
            frmNewCart.Show();
            frmNewCart.BringToFront();
        }
        private FrmNewUser newUserInstance {
            get
            {
                if (frmNewUser != null)
                {
                    frmNewUser.Dispose();
                }
                new FrmNewUser(false);
                return frmNewUser;
            }
        }
        private void btnNewUser_Click(object sender, EventArgs e)
        {
            FrmNewUser frmNewUser = this.newUserInstance;
            frmNewUser.MdiParent = this;
            frmNewUser.Show();
            frmNewUser.BringToFront();
        }
        private FrmUsersList UserListInstance {
            get
            {
                if (frmUsersList != null)
                {
                    frmUsersList.Dispose();
                }
                frmUsersList = new FrmUsersList();
                return frmUsersList;
            }
        }
        private void btnUserList_Click(object sender, EventArgs e)
        {
            FrmUsersList frmUsersList = this.UserListInstance;
            frmUsersList.MdiParent = this;
            frmUsersList.Show();
            frmUsersList.BringToFront();
        }

        private void btnPendingList_Click(object sender, EventArgs e)
        {
            FrmPendingList frmPendingList = new FrmPendingList();
            frmPendingList.MdiParent = this;
            frmPendingList.Show();
        }

        private void btnAuthorizationsList_Click(object sender, EventArgs e)
        {
            FrmAuthorizationsList frmAuthorizationsList = new FrmAuthorizationsList("frmAuthorizationList");
            frmAuthorizationsList.MdiParent = this;
            frmAuthorizationsList.Show();
        }

        private void btnNewPriceOrder_Click(object sender, EventArgs e)
        {
            FrmAuthorizationsList frmAuthorizationsList = new FrmAuthorizationsList("PriceOrder");
            frmAuthorizationsList.MdiParent = this;
            frmAuthorizationsList.Show();
        }

        private FrmMedicineDestructionList MedicineDestructionListInstance
        {
            get
            {
                if (frmMedicineDestructionList != null)
                {
                    frmMedicineDestructionList.Dispose();
                }
                frmMedicineDestructionList = new FrmMedicineDestructionList();
                return frmMedicineDestructionList;
            }
        }
        private void btnMedicineDestructionList_Click(object sender, EventArgs e)
        {
            FrmMedicineDestructionList frmMedicineDestructionList = this.MedicineDestructionListInstance;
            frmMedicineDestructionList.MdiParent = this;
            frmMedicineDestructionList.Show();
            frmMedicineDestructionList.BringToFront();
        }

        private FrmNewMedicineDestruction NewMedicineDestructionInstance
        {
            get
            {
                if (frmNewMedicineDestruction != null)
                {
                    frmNewMedicineDestruction.Dispose();
                }
                frmNewMedicineDestruction = new FrmNewMedicineDestruction();
                return frmNewMedicineDestruction;
            }
        }

        private void nuevaActaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNewMedicineDestruction frmNewMedicineDestruction = this.NewMedicineDestructionInstance;
            frmNewMedicineDestruction.MdiParent = this;
            frmNewMedicineDestruction.Show();
            frmNewMedicineDestruction.BringToFront();
        }
        private FrmNewChangeOfMedicine NewChangeOfMedicineInstance
        {
            get
            {
                if (frmNewChangeOfMedicine != null)
                {
                    frmNewChangeOfMedicine.Dispose();
                }
                frmNewChangeOfMedicine = new FrmNewChangeOfMedicine();
                return frmNewChangeOfMedicine;
            }
        }
        private void nuevoCambioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNewChangeOfMedicine frmNewChangeOfMedicine = this.NewChangeOfMedicineInstance;
            frmNewChangeOfMedicine.MdiParent = this;
            frmNewChangeOfMedicine.Show();
            frmNewChangeOfMedicine.BringToFront();
        }
        private FrmStockControl StockControlInstance
        {
            get
            {
                if (frmStockControl != null)
                {
                    frmStockControl.Dispose();
                }
                frmStockControl = new FrmStockControl();

                return frmStockControl;
            }
        }
        private void btnStockControl_Click(object sender, EventArgs e)
        {
            
            FrmStockControl frmStockControl = this.StockControlInstance;
            frmStockControl.MdiParent = this;
            frmStockControl.Show();
            frmStockControl.BringToFront();
        }

        
        private void verListadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMedicineDestructionList frmMedicineDestructionList = new FrmMedicineDestructionList();
            frmMedicineDestructionList.MdiParent = this;
            frmMedicineDestructionList.Show();
        }

        private void btnChangesList_Click(object sender, EventArgs e)
        {
            FrmChangeOfMedicinesList frmChangeOfMedicinesList = new FrmChangeOfMedicinesList();
            frmChangeOfMedicinesList.MdiParent = this;
            frmChangeOfMedicinesList.Show();
        }

        private void btnEmptyPriceOrder_Click(object sender, EventArgs e)
        {

        }
        private void btnPriceOrderList_Click(object sender, EventArgs e)
        {

        }
        private void btnDatagrid_Click(object sender, EventArgs e)
        {
        }

        private void elementosProximosAVencerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmElementsToExpire frmElementsToExpire = new FrmElementsToExpire();
            frmElementsToExpire.MdiParent = this;
            frmElementsToExpire.Show();
        }
    }
}
