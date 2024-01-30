namespace Views.Lists
{
    partial class FrmMedicineTrace
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLot = new System.Windows.Forms.Label();
            this.lblProvider = new System.Windows.Forms.Label();
            this.lblSince = new System.Windows.Forms.Label();
            this.lblUntill = new System.Windows.Forms.Label();
            this.txtElement = new System.Windows.Forms.TextBox();
            this.dtpSince = new System.Windows.Forms.DateTimePicker();
            this.dtpUntil = new System.Windows.Forms.DateTimePicker();
            this.txtLot = new System.Windows.Forms.TextBox();
            this.cmbProvider = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.grdElement = new System.Windows.Forms.DataGridView();
            this.lblTraceabilityTitle = new System.Windows.Forms.Label();
            this.grdTraceability = new System.Windows.Forms.DataGridView();
            this.btnQuit = new System.Windows.Forms.Button();
            this.chkDates = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTraceability)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Swis721 Hv BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(522, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(190, 25);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Buscar Elemento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Elemento";
            // 
            // lblLot
            // 
            this.lblLot.AutoSize = true;
            this.lblLot.Location = new System.Drawing.Point(18, 149);
            this.lblLot.Name = "lblLot";
            this.lblLot.Size = new System.Drawing.Size(28, 13);
            this.lblLot.TabIndex = 18;
            this.lblLot.Text = "Lote";
            // 
            // lblProvider
            // 
            this.lblProvider.AutoSize = true;
            this.lblProvider.Location = new System.Drawing.Point(18, 105);
            this.lblProvider.Name = "lblProvider";
            this.lblProvider.Size = new System.Drawing.Size(56, 13);
            this.lblProvider.TabIndex = 19;
            this.lblProvider.Text = "Proveedor";
            // 
            // lblSince
            // 
            this.lblSince.AutoSize = true;
            this.lblSince.Location = new System.Drawing.Point(19, 226);
            this.lblSince.Name = "lblSince";
            this.lblSince.Size = new System.Drawing.Size(38, 13);
            this.lblSince.TabIndex = 21;
            this.lblSince.Text = "Desde";
            // 
            // lblUntill
            // 
            this.lblUntill.AutoSize = true;
            this.lblUntill.Location = new System.Drawing.Point(22, 252);
            this.lblUntill.Name = "lblUntill";
            this.lblUntill.Size = new System.Drawing.Size(35, 13);
            this.lblUntill.TabIndex = 22;
            this.lblUntill.Text = "Hasta";
            // 
            // txtElement
            // 
            this.txtElement.Location = new System.Drawing.Point(18, 80);
            this.txtElement.Name = "txtElement";
            this.txtElement.Size = new System.Drawing.Size(271, 20);
            this.txtElement.TabIndex = 0;
            this.txtElement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtElement_KeyPress);
            // 
            // dtpSince
            // 
            this.dtpSince.Location = new System.Drawing.Point(66, 222);
            this.dtpSince.Name = "dtpSince";
            this.dtpSince.Size = new System.Drawing.Size(126, 20);
            this.dtpSince.TabIndex = 4;
            this.dtpSince.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpSince_KeyPress);
            // 
            // dtpUntil
            // 
            this.dtpUntil.Location = new System.Drawing.Point(66, 248);
            this.dtpUntil.Name = "dtpUntil";
            this.dtpUntil.Size = new System.Drawing.Size(126, 20);
            this.dtpUntil.TabIndex = 5;
            this.dtpUntil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpUntil_KeyPress);
            // 
            // txtLot
            // 
            this.txtLot.Location = new System.Drawing.Point(18, 167);
            this.txtLot.Name = "txtLot";
            this.txtLot.Size = new System.Drawing.Size(162, 20);
            this.txtLot.TabIndex = 2;
            this.txtLot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLot_KeyPress);
            // 
            // cmbProvider
            // 
            this.cmbProvider.FormattingEnabled = true;
            this.cmbProvider.Location = new System.Drawing.Point(18, 123);
            this.cmbProvider.Name = "cmbProvider";
            this.cmbProvider.Size = new System.Drawing.Size(215, 21);
            this.cmbProvider.TabIndex = 1;
            this.cmbProvider.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbProvider_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(307, 121);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(307, 150);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 7;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // grdElement
            // 
            this.grdElement.AllowUserToAddRows = false;
            this.grdElement.AllowUserToDeleteRows = false;
            this.grdElement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdElement.Location = new System.Drawing.Point(407, 62);
            this.grdElement.Name = "grdElement";
            this.grdElement.ReadOnly = true;
            this.grdElement.Size = new System.Drawing.Size(815, 233);
            this.grdElement.TabIndex = 9;
            this.grdElement.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdElement_CellDoubleClick);
            // 
            // lblTraceabilityTitle
            // 
            this.lblTraceabilityTitle.AutoSize = true;
            this.lblTraceabilityTitle.Font = new System.Drawing.Font("Swis721 Hv BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraceabilityTitle.Location = new System.Drawing.Point(547, 310);
            this.lblTraceabilityTitle.Name = "lblTraceabilityTitle";
            this.lblTraceabilityTitle.Size = new System.Drawing.Size(141, 25);
            this.lblTraceabilityTitle.TabIndex = 24;
            this.lblTraceabilityTitle.Text = "Trazabilidad";
            // 
            // grdTraceability
            // 
            this.grdTraceability.AllowUserToAddRows = false;
            this.grdTraceability.AllowUserToDeleteRows = false;
            this.grdTraceability.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTraceability.Location = new System.Drawing.Point(12, 338);
            this.grdTraceability.Name = "grdTraceability";
            this.grdTraceability.ReadOnly = true;
            this.grdTraceability.Size = new System.Drawing.Size(1210, 186);
            this.grdTraceability.TabIndex = 25;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(307, 193);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 8;
            this.btnQuit.Text = "Salir";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // chkDates
            // 
            this.chkDates.AutoSize = true;
            this.chkDates.Location = new System.Drawing.Point(18, 199);
            this.chkDates.Name = "chkDates";
            this.chkDates.Size = new System.Drawing.Size(108, 17);
            this.chkDates.TabIndex = 3;
            this.chkDates.Text = "Fecha de ingreso";
            this.chkDates.UseVisualStyleBackColor = true;
            this.chkDates.CheckedChanged += new System.EventHandler(this.chkDates_CheckedChanged);
            this.chkDates.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chkDates_KeyPress);
            // 
            // FrmMedicineTrace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 536);
            this.Controls.Add(this.chkDates);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.grdTraceability);
            this.Controls.Add(this.lblTraceabilityTitle);
            this.Controls.Add(this.grdElement);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbProvider);
            this.Controls.Add(this.txtLot);
            this.Controls.Add(this.dtpUntil);
            this.Controls.Add(this.dtpSince);
            this.Controls.Add(this.txtElement);
            this.Controls.Add(this.lblUntill);
            this.Controls.Add(this.lblSince);
            this.Controls.Add(this.lblProvider);
            this.Controls.Add(this.lblLot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmMedicineTrace";
            this.Text = "Trazabilidad de Medicamentos";
            this.Load += new System.EventHandler(this.lblElement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTraceability)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLot;
        private System.Windows.Forms.Label lblProvider;
        private System.Windows.Forms.Label lblSince;
        private System.Windows.Forms.Label lblUntill;
        private System.Windows.Forms.TextBox txtElement;
        private System.Windows.Forms.DateTimePicker dtpSince;
        private System.Windows.Forms.DateTimePicker dtpUntil;
        private System.Windows.Forms.TextBox txtLot;
        private System.Windows.Forms.ComboBox cmbProvider;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.DataGridView grdElement;
        private System.Windows.Forms.Label lblTraceabilityTitle;
        private System.Windows.Forms.DataGridView grdTraceability;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.CheckBox chkDates;
    }
}