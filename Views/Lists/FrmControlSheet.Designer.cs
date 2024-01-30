namespace Views.Lists
{
    partial class FrmControlSheet
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
            this.grdControlSheet = new System.Windows.Forms.DataGridView();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtVehicle = new System.Windows.Forms.TextBox();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.btnShowMonth = new System.Windows.Forms.Button();
            this.nbrYear = new System.Windows.Forms.NumericUpDown();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdControlSheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrYear)).BeginInit();
            this.SuspendLayout();
            // 
            // grdControlSheet
            // 
            this.grdControlSheet.AllowUserToAddRows = false;
            this.grdControlSheet.AllowUserToDeleteRows = false;
            this.grdControlSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdControlSheet.Location = new System.Drawing.Point(12, 90);
            this.grdControlSheet.Name = "grdControlSheet";
            this.grdControlSheet.Size = new System.Drawing.Size(1220, 381);
            this.grdControlSheet.TabIndex = 0;
            this.grdControlSheet.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdControlSheet_CellValueChanged);
            this.grdControlSheet.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.GrdControlSheet_EditingControlShowing);
            this.grdControlSheet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GrdControlSheet_KeyPress);
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(426, 55);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(142, 21);
            this.cmbMonth.TabIndex = 6;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(393, 59);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(27, 13);
            this.lblMonth.TabIndex = 5;
            this.lblMonth.Text = "Mes";
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(1133, 54);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(99, 23);
            this.btnClean.TabIndex = 9;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(1157, 477);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "Salir";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(504, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(206, 25);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Planilla de Control";
            // 
            // txtVehicle
            // 
            this.txtVehicle.Location = new System.Drawing.Point(799, 55);
            this.txtVehicle.Name = "txtVehicle";
            this.txtVehicle.Size = new System.Drawing.Size(105, 20);
            this.txtVehicle.TabIndex = 27;
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Location = new System.Drawing.Point(761, 59);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(32, 13);
            this.lblVehicle.TabIndex = 26;
            this.lblVehicle.Text = "Movil";
            // 
            // btnShowMonth
            // 
            this.btnShowMonth.Location = new System.Drawing.Point(921, 54);
            this.btnShowMonth.Name = "btnShowMonth";
            this.btnShowMonth.Size = new System.Drawing.Size(99, 23);
            this.btnShowMonth.TabIndex = 25;
            this.btnShowMonth.Text = "Ver Mes";
            this.btnShowMonth.UseVisualStyleBackColor = true;
            this.btnShowMonth.Click += new System.EventHandler(this.BtnShowMonth_Click);
            // 
            // nbrYear
            // 
            this.nbrYear.Location = new System.Drawing.Point(628, 55);
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
            this.nbrYear.TabIndex = 24;
            this.nbrYear.ThousandsSeparator = true;
            this.nbrYear.Value = new decimal(new int[] {
            2003,
            0,
            0,
            0});
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(596, 59);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(26, 13);
            this.lblYear.TabIndex = 23;
            this.lblYear.Text = "Año";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(16, 55);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(218, 20);
            this.txtFilter.TabIndex = 29;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(240, 54);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 477);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnReport
            // 
            this.btnReport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReport.Location = new System.Drawing.Point(115, 477);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(119, 23);
            this.btnReport.TabIndex = 32;
            this.btnReport.Text = "Generar Reporte";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // FrmControlSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 507);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.txtVehicle);
            this.Controls.Add(this.lblVehicle);
            this.Controls.Add(this.btnShowMonth);
            this.Controls.Add(this.nbrYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.grdControlSheet);
            this.Name = "FrmControlSheet";
            this.Text = "Planilla de Control";
            this.Load += new System.EventHandler(this.FrmControlSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdControlSheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdControlSheet;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtVehicle;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.Button btnShowMonth;
        private System.Windows.Forms.NumericUpDown nbrYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReport;
    }
}