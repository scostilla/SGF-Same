namespace Views.Lists
{
    partial class FrmStockList
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
            this.lblElement = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.chkAllBases = new System.Windows.Forms.CheckBox();
            this.cmbElement = new System.Windows.Forms.ComboBox();
            this.cmbBase = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.nbrYear = new System.Windows.Forms.NumericUpDown();
            this.chkAllElements = new System.Windows.Forms.CheckBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.grdStock = new System.Windows.Forms.DataGridView();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.txtProviderFilter = new System.Windows.Forms.TextBox();
            this.txtElementFilter = new System.Windows.Forms.TextBox();
            this.txtLotFilter = new System.Windows.Forms.TextBox();
            this.txtRemitFilter = new System.Windows.Forms.TextBox();
            this.txtOperativeBaseFilter = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nbrYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdStock)).BeginInit();
            this.SuspendLayout();
            // 
            // lblElement
            // 
            this.lblElement.AutoSize = true;
            this.lblElement.Location = new System.Drawing.Point(127, 51);
            this.lblElement.Name = "lblElement";
            this.lblElement.Size = new System.Drawing.Size(51, 13);
            this.lblElement.TabIndex = 1;
            this.lblElement.Text = "Elemento";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(602, 51);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(27, 13);
            this.lblMonth.TabIndex = 2;
            this.lblMonth.Text = "Mes";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(790, 52);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(26, 13);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "Año";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(147, 87);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(31, 13);
            this.lblBase.TabIndex = 4;
            this.lblBase.Text = "Base";
            // 
            // chkAllBases
            // 
            this.chkAllBases.AutoSize = true;
            this.chkAllBases.Location = new System.Drawing.Point(454, 85);
            this.chkAllBases.Name = "chkAllBases";
            this.chkAllBases.Size = new System.Drawing.Size(104, 17);
            this.chkAllBases.TabIndex = 3;
            this.chkAllBases.Text = "Todas las Bases";
            this.chkAllBases.UseVisualStyleBackColor = true;
            this.chkAllBases.CheckStateChanged += new System.EventHandler(this.chkAllBasesChange);
            // 
            // cmbElement
            // 
            this.cmbElement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbElement.FormattingEnabled = true;
            this.cmbElement.Location = new System.Drawing.Point(184, 47);
            this.cmbElement.Name = "cmbElement";
            this.cmbElement.Size = new System.Drawing.Size(264, 21);
            this.cmbElement.TabIndex = 0;
            // 
            // cmbBase
            // 
            this.cmbBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBase.FormattingEnabled = true;
            this.cmbBase.Location = new System.Drawing.Point(184, 83);
            this.cmbBase.Name = "cmbBase";
            this.cmbBase.Size = new System.Drawing.Size(264, 21);
            this.cmbBase.TabIndex = 2;
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(635, 47);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(142, 21);
            this.cmbMonth.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(370, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(259, 29);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Movimiento De Stock";
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(635, 82);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(99, 23);
            this.btnProcess.TabIndex = 6;
            this.btnProcess.Text = "Procesar";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // nbrYear
            // 
            this.nbrYear.Location = new System.Drawing.Point(822, 49);
            this.nbrYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nbrYear.Minimum = new decimal(new int[] {
            2003,
            0,
            0,
            0});
            this.nbrYear.Name = "nbrYear";
            this.nbrYear.Size = new System.Drawing.Size(105, 20);
            this.nbrYear.TabIndex = 5;
            this.nbrYear.ThousandsSeparator = true;
            this.nbrYear.Value = new decimal(new int[] {
            2003,
            0,
            0,
            0});
            // 
            // chkAllElements
            // 
            this.chkAllElements.AutoSize = true;
            this.chkAllElements.Location = new System.Drawing.Point(454, 49);
            this.chkAllElements.Name = "chkAllElements";
            this.chkAllElements.Size = new System.Drawing.Size(124, 17);
            this.chkAllElements.TabIndex = 1;
            this.chkAllElements.Text = "Todos los Elementos";
            this.chkAllElements.UseVisualStyleBackColor = true;
            this.chkAllElements.CheckStateChanged += new System.EventHandler(this.chkAllElementsChange);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(984, 515);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 8;
            this.btnQuit.Text = "Salir";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // grdStock
            // 
            this.grdStock.AllowUserToAddRows = false;
            this.grdStock.AllowUserToDeleteRows = false;
            this.grdStock.AllowUserToOrderColumns = true;
            this.grdStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStock.Location = new System.Drawing.Point(12, 161);
            this.grdStock.Name = "grdStock";
            this.grdStock.ReadOnly = true;
            this.grdStock.Size = new System.Drawing.Size(1048, 348);
            this.grdStock.TabIndex = 15;
            this.grdStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdStock_CellClick);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(758, 81);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(84, 23);
            this.btnClean.TabIndex = 7;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(32, 521);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(99, 23);
            this.btnReport.TabIndex = 16;
            this.btnReport.Text = "Reporte";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // txtProviderFilter
            // 
            this.txtProviderFilter.Location = new System.Drawing.Point(12, 128);
            this.txtProviderFilter.Name = "txtProviderFilter";
            this.txtProviderFilter.Size = new System.Drawing.Size(199, 20);
            this.txtProviderFilter.TabIndex = 31;
            this.txtProviderFilter.TextChanged += new System.EventHandler(this.txtProviderFilter_TextChanged);
            // 
            // txtElementFilter
            // 
            this.txtElementFilter.Location = new System.Drawing.Point(217, 128);
            this.txtElementFilter.Name = "txtElementFilter";
            this.txtElementFilter.Size = new System.Drawing.Size(292, 20);
            this.txtElementFilter.TabIndex = 32;
            this.txtElementFilter.TextChanged += new System.EventHandler(this.txtElementFilter_TextChanged);
            // 
            // txtLotFilter
            // 
            this.txtLotFilter.Location = new System.Drawing.Point(515, 128);
            this.txtLotFilter.Name = "txtLotFilter";
            this.txtLotFilter.Size = new System.Drawing.Size(147, 20);
            this.txtLotFilter.TabIndex = 33;
            this.txtLotFilter.TextChanged += new System.EventHandler(this.txtLotFilter_TextChanged);
            // 
            // txtRemitFilter
            // 
            this.txtRemitFilter.Location = new System.Drawing.Point(775, 128);
            this.txtRemitFilter.Name = "txtRemitFilter";
            this.txtRemitFilter.Size = new System.Drawing.Size(135, 20);
            this.txtRemitFilter.TabIndex = 35;
            this.txtRemitFilter.TextChanged += new System.EventHandler(this.txtRemitFilter_TextChanged);
            // 
            // txtOperativeBaseFilter
            // 
            this.txtOperativeBaseFilter.Location = new System.Drawing.Point(668, 128);
            this.txtOperativeBaseFilter.Name = "txtOperativeBaseFilter";
            this.txtOperativeBaseFilter.Size = new System.Drawing.Size(101, 20);
            this.txtOperativeBaseFilter.TabIndex = 36;
            this.txtOperativeBaseFilter.TextChanged += new System.EventHandler(this.txtOperativeBaseFilter_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(217, 521);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(136, 521);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(75, 23);
            this.btnDetail.TabIndex = 38;
            this.btnDetail.Text = "Detalle";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // FrmStockList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 551);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtOperativeBaseFilter);
            this.Controls.Add(this.txtRemitFilter);
            this.Controls.Add(this.txtLotFilter);
            this.Controls.Add(this.txtElementFilter);
            this.Controls.Add(this.txtProviderFilter);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.grdStock);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.chkAllElements);
            this.Controls.Add(this.nbrYear);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.cmbBase);
            this.Controls.Add(this.cmbElement);
            this.Controls.Add(this.chkAllBases);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblElement);
            this.Name = "FrmStockList";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.FrmStockList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbrYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblElement;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.CheckBox chkAllBases;
        private System.Windows.Forms.ComboBox cmbElement;
        private System.Windows.Forms.ComboBox cmbBase;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.NumericUpDown nbrYear;
        private System.Windows.Forms.CheckBox chkAllElements;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.DataGridView grdStock;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.TextBox txtProviderFilter;
        private System.Windows.Forms.TextBox txtElementFilter;
        private System.Windows.Forms.TextBox txtLotFilter;
        private System.Windows.Forms.TextBox txtRemitFilter;
        private System.Windows.Forms.TextBox txtOperativeBaseFilter;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDetail;
    }
}