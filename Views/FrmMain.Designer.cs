namespace Views
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TsmPharmacy = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReport = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewStock = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStockControl = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewEgress = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTraceability = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBaseStock = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMedicineTraceability = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNurses = new System.Windows.Forms.ToolStripMenuItem();
            this.btnControlSheet = new System.Windows.Forms.ToolStripMenuItem();
            this.btnControlSheetTotals = new System.Windows.Forms.ToolStripMenuItem();
            this.decomisarMedicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewMedicineDestruction = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMedicineDestructionList = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioDeMedicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewMedicineChange = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChangesList = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmPurchase = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewPriceOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEmptyPriceOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPriceOrderList = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmNewList = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewElement = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewProvider = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewBase = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewAlertValue = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewOC = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmLists = new System.Windows.Forms.ToolStripMenuItem();
            this.btnElementList = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMedicines = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBlister = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDisposable = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPsychotropic = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCleaning = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSolutions = new System.Windows.Forms.ToolStripMenuItem();
            this.btnantiseptics = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProviderList = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBaseList = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAlertValueList = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBuyOrderList = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmAuthorizations = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPending = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAuthorizationsList = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmUser = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUserList = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmTest = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDatagrid = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btnModifyUser = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUserData = new System.Windows.Forms.ToolStripTextBox();
            this.elementosProximosAVencerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmPharmacy,
            this.TsmPurchase,
            this.TsmNewList,
            this.TsmLists,
            this.TsmAuthorizations,
            this.TsmUser,
            this.TsmTest});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "mSpMain";
            // 
            // TsmPharmacy
            // 
            this.TsmPharmacy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReport,
            this.btnNewStock,
            this.btnStockControl,
            this.btnNewEgress,
            this.btnTraceability,
            this.btnNurses,
            this.btnControlSheet,
            this.btnControlSheetTotals,
            this.elementosProximosAVencerToolStripMenuItem,
            this.decomisarMedicacionToolStripMenuItem,
            this.cambioDeMedicacionToolStripMenuItem});
            this.TsmPharmacy.Name = "TsmPharmacy";
            this.TsmPharmacy.Size = new System.Drawing.Size(67, 20);
            this.TsmPharmacy.Text = "Farmacia";
            // 
            // btnReport
            // 
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(229, 22);
            this.btnReport.Text = "Movimientos de Stock";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnNewStock
            // 
            this.btnNewStock.Name = "btnNewStock";
            this.btnNewStock.Size = new System.Drawing.Size(229, 22);
            this.btnNewStock.Text = "Stock";
            this.btnNewStock.Click += new System.EventHandler(this.btnNewStock_Click);
            // 
            // btnStockControl
            // 
            this.btnStockControl.Name = "btnStockControl";
            this.btnStockControl.Size = new System.Drawing.Size(229, 22);
            this.btnStockControl.Text = "Control de Stock";
            this.btnStockControl.Click += new System.EventHandler(this.btnStockControl_Click);
            // 
            // btnNewEgress
            // 
            this.btnNewEgress.Name = "btnNewEgress";
            this.btnNewEgress.Size = new System.Drawing.Size(229, 22);
            this.btnNewEgress.Text = "Registrar Egreso";
            this.btnNewEgress.Click += new System.EventHandler(this.btnNewEgress_Click);
            // 
            // btnTraceability
            // 
            this.btnTraceability.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBaseStock,
            this.btnMedicineTraceability});
            this.btnTraceability.Name = "btnTraceability";
            this.btnTraceability.Size = new System.Drawing.Size(229, 22);
            this.btnTraceability.Text = "Trazabilidad";
            // 
            // btnBaseStock
            // 
            this.btnBaseStock.Name = "btnBaseStock";
            this.btnBaseStock.Size = new System.Drawing.Size(168, 22);
            this.btnBaseStock.Text = "Stock en las Bases";
            this.btnBaseStock.Click += new System.EventHandler(this.btnBaseStock_Click);
            // 
            // btnMedicineTraceability
            // 
            this.btnMedicineTraceability.Name = "btnMedicineTraceability";
            this.btnMedicineTraceability.Size = new System.Drawing.Size(168, 22);
            this.btnMedicineTraceability.Text = "Medicamentos";
            this.btnMedicineTraceability.Click += new System.EventHandler(this.btnMedicineTraceability_Click);
            // 
            // btnNurses
            // 
            this.btnNurses.Name = "btnNurses";
            this.btnNurses.Size = new System.Drawing.Size(229, 22);
            this.btnNurses.Text = "Grilla operativa de Moviles";
            this.btnNurses.Click += new System.EventHandler(this.btnNurses_Click);
            // 
            // btnControlSheet
            // 
            this.btnControlSheet.Name = "btnControlSheet";
            this.btnControlSheet.Size = new System.Drawing.Size(229, 22);
            this.btnControlSheet.Text = "Planilla de Control";
            this.btnControlSheet.Click += new System.EventHandler(this.btnControlSheet_Click);
            // 
            // btnControlSheetTotals
            // 
            this.btnControlSheetTotals.Name = "btnControlSheetTotals";
            this.btnControlSheetTotals.Size = new System.Drawing.Size(229, 22);
            this.btnControlSheetTotals.Text = "Planillas de Totales";
            this.btnControlSheetTotals.Click += new System.EventHandler(this.btnControlSheetTotals_Click);
            // 
            // decomisarMedicacionToolStripMenuItem
            // 
            this.decomisarMedicacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewMedicineDestruction,
            this.btnMedicineDestructionList});
            this.decomisarMedicacionToolStripMenuItem.Name = "decomisarMedicacionToolStripMenuItem";
            this.decomisarMedicacionToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.decomisarMedicacionToolStripMenuItem.Text = "Decomisar Medicacion";
            // 
            // btnNewMedicineDestruction
            // 
            this.btnNewMedicineDestruction.Name = "btnNewMedicineDestruction";
            this.btnNewMedicineDestruction.Size = new System.Drawing.Size(135, 22);
            this.btnNewMedicineDestruction.Text = "Nueva Acta";
            this.btnNewMedicineDestruction.Click += new System.EventHandler(this.nuevaActaToolStripMenuItem_Click);
            // 
            // btnMedicineDestructionList
            // 
            this.btnMedicineDestructionList.Name = "btnMedicineDestructionList";
            this.btnMedicineDestructionList.Size = new System.Drawing.Size(135, 22);
            this.btnMedicineDestructionList.Text = "Ver listado";
            this.btnMedicineDestructionList.Click += new System.EventHandler(this.verListadoToolStripMenuItem_Click);
            // 
            // cambioDeMedicacionToolStripMenuItem
            // 
            this.cambioDeMedicacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewMedicineChange,
            this.btnChangesList});
            this.cambioDeMedicacionToolStripMenuItem.Name = "cambioDeMedicacionToolStripMenuItem";
            this.cambioDeMedicacionToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.cambioDeMedicacionToolStripMenuItem.Text = "Cambio de Medicacion";
            this.cambioDeMedicacionToolStripMenuItem.Visible = false;
            // 
            // btnNewMedicineChange
            // 
            this.btnNewMedicineChange.Name = "btnNewMedicineChange";
            this.btnNewMedicineChange.Size = new System.Drawing.Size(164, 22);
            this.btnNewMedicineChange.Text = "Nuevo Cambio";
            this.btnNewMedicineChange.Click += new System.EventHandler(this.nuevoCambioToolStripMenuItem_Click);
            // 
            // btnChangesList
            // 
            this.btnChangesList.Name = "btnChangesList";
            this.btnChangesList.Size = new System.Drawing.Size(164, 22);
            this.btnChangesList.Text = "Lista de Cambios";
            this.btnChangesList.Click += new System.EventHandler(this.btnChangesList_Click);
            // 
            // TsmPurchase
            // 
            this.TsmPurchase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewPriceOrder,
            this.btnEmptyPriceOrder,
            this.btnPriceOrderList});
            this.TsmPurchase.Name = "TsmPurchase";
            this.TsmPurchase.Size = new System.Drawing.Size(67, 20);
            this.TsmPurchase.Text = "Compras";
            // 
            // btnNewPriceOrder
            // 
            this.btnNewPriceOrder.Name = "btnNewPriceOrder";
            this.btnNewPriceOrder.Size = new System.Drawing.Size(212, 22);
            this.btnNewPriceOrder.Text = "Generar Pedido de Precios";
            this.btnNewPriceOrder.Click += new System.EventHandler(this.btnNewPriceOrder_Click);
            // 
            // btnEmptyPriceOrder
            // 
            this.btnEmptyPriceOrder.Name = "btnEmptyPriceOrder";
            this.btnEmptyPriceOrder.Size = new System.Drawing.Size(212, 22);
            this.btnEmptyPriceOrder.Text = "Pedido de Precios Vacio";
            this.btnEmptyPriceOrder.Click += new System.EventHandler(this.btnEmptyPriceOrder_Click);
            // 
            // btnPriceOrderList
            // 
            this.btnPriceOrderList.Name = "btnPriceOrderList";
            this.btnPriceOrderList.Size = new System.Drawing.Size(212, 22);
            this.btnPriceOrderList.Text = "Pedidos Generados";
            this.btnPriceOrderList.Click += new System.EventHandler(this.btnPriceOrderList_Click);
            // 
            // TsmNewList
            // 
            this.TsmNewList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewElement,
            this.btnNewProvider,
            this.btnNewBase,
            this.btnNewAlertValue,
            this.btnNewOC});
            this.TsmNewList.Name = "TsmNewList";
            this.TsmNewList.Size = new System.Drawing.Size(54, 20);
            this.TsmNewList.Text = "Nuevo";
            // 
            // btnNewElement
            // 
            this.btnNewElement.Name = "btnNewElement";
            this.btnNewElement.Size = new System.Drawing.Size(169, 22);
            this.btnNewElement.Text = "Elemento";
            this.btnNewElement.Click += new System.EventHandler(this.btnNewElement_Click);
            // 
            // btnNewProvider
            // 
            this.btnNewProvider.Name = "btnNewProvider";
            this.btnNewProvider.Size = new System.Drawing.Size(169, 22);
            this.btnNewProvider.Text = "Proveedor";
            this.btnNewProvider.Click += new System.EventHandler(this.btnNewProvider_Click);
            // 
            // btnNewBase
            // 
            this.btnNewBase.Name = "btnNewBase";
            this.btnNewBase.Size = new System.Drawing.Size(169, 22);
            this.btnNewBase.Text = "Base Operativa";
            this.btnNewBase.Click += new System.EventHandler(this.btnNewBase_Click);
            // 
            // btnNewAlertValue
            // 
            this.btnNewAlertValue.Name = "btnNewAlertValue";
            this.btnNewAlertValue.Size = new System.Drawing.Size(169, 22);
            this.btnNewAlertValue.Text = "Valores de Alerta";
            this.btnNewAlertValue.Click += new System.EventHandler(this.btnNewAlertValue_Click);
            // 
            // btnNewOC
            // 
            this.btnNewOC.Name = "btnNewOC";
            this.btnNewOC.Size = new System.Drawing.Size(169, 22);
            this.btnNewOC.Text = "Orden de Compra";
            this.btnNewOC.Click += new System.EventHandler(this.btnNewOC_Click);
            // 
            // TsmLists
            // 
            this.TsmLists.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnElementList,
            this.btnProviderList,
            this.btnBaseList,
            this.btnAlertValueList,
            this.btnBuyOrderList});
            this.TsmLists.Name = "TsmLists";
            this.TsmLists.Size = new System.Drawing.Size(62, 20);
            this.TsmLists.Text = "Listados";
            // 
            // btnElementList
            // 
            this.btnElementList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMedicines,
            this.btnBlister,
            this.btnDisposable,
            this.btnPsychotropic,
            this.btnCleaning,
            this.btnSolutions,
            this.btnantiseptics});
            this.btnElementList.Name = "btnElementList";
            this.btnElementList.Size = new System.Drawing.Size(180, 22);
            this.btnElementList.Text = "Elementos";
            this.btnElementList.Click += new System.EventHandler(this.btnElementList_Click);
            // 
            // btnMedicines
            // 
            this.btnMedicines.Name = "btnMedicines";
            this.btnMedicines.Size = new System.Drawing.Size(153, 22);
            this.btnMedicines.Text = "Medicamentos";
            this.btnMedicines.Click += new System.EventHandler(this.btnMedicines_Click);
            // 
            // btnBlister
            // 
            this.btnBlister.Name = "btnBlister";
            this.btnBlister.Size = new System.Drawing.Size(153, 22);
            this.btnBlister.Text = "Ampollas";
            this.btnBlister.Click += new System.EventHandler(this.btnBlister_Click);
            // 
            // btnDisposable
            // 
            this.btnDisposable.Name = "btnDisposable";
            this.btnDisposable.Size = new System.Drawing.Size(153, 22);
            this.btnDisposable.Text = "Descartables";
            this.btnDisposable.Click += new System.EventHandler(this.btnDisposable_Click);
            // 
            // btnPsychotropic
            // 
            this.btnPsychotropic.Name = "btnPsychotropic";
            this.btnPsychotropic.Size = new System.Drawing.Size(153, 22);
            this.btnPsychotropic.Text = "Psicofarmacos";
            this.btnPsychotropic.Click += new System.EventHandler(this.btnPsychotropic_Click);
            // 
            // btnCleaning
            // 
            this.btnCleaning.Name = "btnCleaning";
            this.btnCleaning.Size = new System.Drawing.Size(153, 22);
            this.btnCleaning.Text = "Limpieza";
            this.btnCleaning.Click += new System.EventHandler(this.btnCleaning_Click);
            // 
            // btnSolutions
            // 
            this.btnSolutions.Name = "btnSolutions";
            this.btnSolutions.Size = new System.Drawing.Size(153, 22);
            this.btnSolutions.Text = "Soluciones";
            this.btnSolutions.Click += new System.EventHandler(this.btnSolutions_Click);
            // 
            // btnantiseptics
            // 
            this.btnantiseptics.Name = "btnantiseptics";
            this.btnantiseptics.Size = new System.Drawing.Size(153, 22);
            this.btnantiseptics.Text = "Antisépticos";
            this.btnantiseptics.Click += new System.EventHandler(this.btnAntiseptics_Click);
            // 
            // btnProviderList
            // 
            this.btnProviderList.Name = "btnProviderList";
            this.btnProviderList.Size = new System.Drawing.Size(180, 22);
            this.btnProviderList.Text = "Proveedores";
            this.btnProviderList.Click += new System.EventHandler(this.btnProviderList_Click);
            // 
            // btnBaseList
            // 
            this.btnBaseList.Name = "btnBaseList";
            this.btnBaseList.Size = new System.Drawing.Size(180, 22);
            this.btnBaseList.Text = "Bases";
            this.btnBaseList.Click += new System.EventHandler(this.btnBaseList_Click);
            // 
            // btnAlertValueList
            // 
            this.btnAlertValueList.Name = "btnAlertValueList";
            this.btnAlertValueList.Size = new System.Drawing.Size(180, 22);
            this.btnAlertValueList.Text = "Valores de Alerta";
            this.btnAlertValueList.Click += new System.EventHandler(this.btnAlertValueList_Click);
            // 
            // btnBuyOrderList
            // 
            this.btnBuyOrderList.Name = "btnBuyOrderList";
            this.btnBuyOrderList.Size = new System.Drawing.Size(180, 22);
            this.btnBuyOrderList.Text = "Ordenes de Compra";
            this.btnBuyOrderList.Click += new System.EventHandler(this.btnBuyOrderList_Click);
            // 
            // TsmAuthorizations
            // 
            this.TsmAuthorizations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPending,
            this.btnAuthorizationsList});
            this.TsmAuthorizations.Name = "TsmAuthorizations";
            this.TsmAuthorizations.Size = new System.Drawing.Size(97, 20);
            this.TsmAuthorizations.Text = "Autorizaciones";
            // 
            // btnPending
            // 
            this.btnPending.Name = "btnPending";
            this.btnPending.Size = new System.Drawing.Size(171, 22);
            this.btnPending.Text = "Ver Pendientes";
            this.btnPending.Click += new System.EventHandler(this.btnPendingList_Click);
            // 
            // btnAuthorizationsList
            // 
            this.btnAuthorizationsList.Name = "btnAuthorizationsList";
            this.btnAuthorizationsList.Size = new System.Drawing.Size(171, 22);
            this.btnAuthorizationsList.Text = "Ver Autorizaciones";
            this.btnAuthorizationsList.Click += new System.EventHandler(this.btnAuthorizationsList_Click);
            // 
            // TsmUser
            // 
            this.TsmUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewUser,
            this.btnUserList});
            this.TsmUser.Name = "TsmUser";
            this.TsmUser.Size = new System.Drawing.Size(64, 20);
            this.TsmUser.Text = "Usuarios";
            // 
            // btnNewUser
            // 
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(162, 22);
            this.btnNewUser.Text = "Nuevo Usuario";
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // btnUserList
            // 
            this.btnUserList.Name = "btnUserList";
            this.btnUserList.Size = new System.Drawing.Size(162, 22);
            this.btnUserList.Text = "Lista de Usuarios";
            this.btnUserList.Click += new System.EventHandler(this.btnUserList_Click);
            // 
            // TsmTest
            // 
            this.TsmTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDatagrid});
            this.TsmTest.Name = "TsmTest";
            this.TsmTest.Size = new System.Drawing.Size(39, 20);
            this.TsmTest.Text = "Test";
            // 
            // btnDatagrid
            // 
            this.btnDatagrid.Name = "btnDatagrid";
            this.btnDatagrid.Size = new System.Drawing.Size(146, 22);
            this.btnDatagrid.Text = "Control Sheet";
            this.btnDatagrid.Click += new System.EventHandler(this.btnDatagrid_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnModifyUser,
            this.txtUserData});
            this.menuStrip2.Location = new System.Drawing.Point(0, 423);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 27);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "mSpUserData";
            // 
            // btnModifyUser
            // 
            this.btnModifyUser.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnModifyUser.Name = "btnModifyUser";
            this.btnModifyUser.Size = new System.Drawing.Size(37, 23);
            this.btnModifyUser.Text = "@";
            this.btnModifyUser.Click += new System.EventHandler(this.btnModifyUser_Click);
            // 
            // txtUserData
            // 
            this.txtUserData.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtUserData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserData.Enabled = false;
            this.txtUserData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserData.Margin = new System.Windows.Forms.Padding(1, 0, 50, 0);
            this.txtUserData.Name = "txtUserData";
            this.txtUserData.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.txtUserData.Size = new System.Drawing.Size(300, 23);
            // 
            // elementosProximosAVencerToolStripMenuItem
            // 
            this.elementosProximosAVencerToolStripMenuItem.Name = "elementosProximosAVencerToolStripMenuItem";
            this.elementosProximosAVencerToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.elementosProximosAVencerToolStripMenuItem.Text = "Elementos Proximos a Vencer";
            this.elementosProximosAVencerToolStripMenuItem.Click += new System.EventHandler(this.elementosProximosAVencerToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SAME 107";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TsmPharmacy;
        private System.Windows.Forms.ToolStripMenuItem btnReport;
        private System.Windows.Forms.ToolStripMenuItem btnNewStock;
        private System.Windows.Forms.ToolStripMenuItem btnNewEgress;
        private System.Windows.Forms.ToolStripMenuItem TsmUser;
        private System.Windows.Forms.ToolStripMenuItem TsmTest;
        private System.Windows.Forms.ToolStripMenuItem btnDatagrid;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripTextBox txtUserData;
        private System.Windows.Forms.ToolStripMenuItem btnModifyUser;
        private System.Windows.Forms.ToolStripMenuItem TsmNewList;
        private System.Windows.Forms.ToolStripMenuItem btnNewElement;
        private System.Windows.Forms.ToolStripMenuItem btnNewProvider;
        private System.Windows.Forms.ToolStripMenuItem btnNewBase;
        private System.Windows.Forms.ToolStripMenuItem btnNewAlertValue;
        private System.Windows.Forms.ToolStripMenuItem TsmLists;
        private System.Windows.Forms.ToolStripMenuItem btnElementList;
        private System.Windows.Forms.ToolStripMenuItem btnMedicines;
        private System.Windows.Forms.ToolStripMenuItem btnBlister;
        private System.Windows.Forms.ToolStripMenuItem btnDisposable;
        private System.Windows.Forms.ToolStripMenuItem btnPsychotropic;
        private System.Windows.Forms.ToolStripMenuItem btnCleaning;
        private System.Windows.Forms.ToolStripMenuItem btnSolutions;
        private System.Windows.Forms.ToolStripMenuItem btnantiseptics;
        private System.Windows.Forms.ToolStripMenuItem btnProviderList;
        private System.Windows.Forms.ToolStripMenuItem btnBaseList;
        private System.Windows.Forms.ToolStripMenuItem btnAlertValueList;
        private System.Windows.Forms.ToolStripMenuItem btnBuyOrderList;
        private System.Windows.Forms.ToolStripMenuItem btnTraceability;
        private System.Windows.Forms.ToolStripMenuItem btnBaseStock;
        private System.Windows.Forms.ToolStripMenuItem btnMedicineTraceability;
        private System.Windows.Forms.ToolStripMenuItem btnNurses;
        private System.Windows.Forms.ToolStripMenuItem btnControlSheet;
        private System.Windows.Forms.ToolStripMenuItem btnControlSheetTotals;
        private System.Windows.Forms.ToolStripMenuItem btnNewOC;
        private System.Windows.Forms.ToolStripMenuItem TsmPurchase;
        private System.Windows.Forms.ToolStripMenuItem TsmAuthorizations;
        private System.Windows.Forms.ToolStripMenuItem btnNewUser;
        private System.Windows.Forms.ToolStripMenuItem btnUserList;
        private System.Windows.Forms.ToolStripMenuItem btnPending;
        private System.Windows.Forms.ToolStripMenuItem btnAuthorizationsList;
        private System.Windows.Forms.ToolStripMenuItem btnNewPriceOrder;
        private System.Windows.Forms.ToolStripMenuItem btnEmptyPriceOrder;
        private System.Windows.Forms.ToolStripMenuItem btnPriceOrderList;
        private System.Windows.Forms.ToolStripMenuItem decomisarMedicacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambioDeMedicacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnNewMedicineDestruction;
        private System.Windows.Forms.ToolStripMenuItem btnMedicineDestructionList;
        private System.Windows.Forms.ToolStripMenuItem btnNewMedicineChange;
        private System.Windows.Forms.ToolStripMenuItem btnChangesList;
        private System.Windows.Forms.ToolStripMenuItem btnStockControl;
        private System.Windows.Forms.ToolStripMenuItem elementosProximosAVencerToolStripMenuItem;
    }
}

