namespace Views.Lists
{
    partial class FrmStockControl
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
            this.rdbFourthTrimester = new System.Windows.Forms.RadioButton();
            this.rdbMonthly = new System.Windows.Forms.RadioButton();
            this.rdbThirdTrimester = new System.Windows.Forms.RadioButton();
            this.rdbSecondTrimester = new System.Windows.Forms.RadioButton();
            this.rdbFirstTrimester = new System.Windows.Forms.RadioButton();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.nbrYear = new System.Windows.Forms.NumericUpDown();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.grdTotals = new System.Windows.Forms.DataGridView();
            this.btnClean = new System.Windows.Forms.Button();
            this.grbPeriod = new System.Windows.Forms.GroupBox();
            this.grbMovement = new System.Windows.Forms.GroupBox();
            this.rdbAll = new System.Windows.Forms.RadioButton();
            this.rdbOut = new System.Windows.Forms.RadioButton();
            this.rdbIn = new System.Windows.Forms.RadioButton();
            this.chkGroupByElement = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nbrYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTotals)).BeginInit();
            this.grbPeriod.SuspendLayout();
            this.grbMovement.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbFourthTrimester
            // 
            this.rdbFourthTrimester.AutoSize = true;
            this.rdbFourthTrimester.Location = new System.Drawing.Point(6, 88);
            this.rdbFourthTrimester.Name = "rdbFourthTrimester";
            this.rdbFourthTrimester.Size = new System.Drawing.Size(102, 17);
            this.rdbFourthTrimester.TabIndex = 66;
            this.rdbFourthTrimester.TabStop = true;
            this.rdbFourthTrimester.Text = "Cuarto Trimestre";
            this.rdbFourthTrimester.UseVisualStyleBackColor = true;
            // 
            // rdbMonthly
            // 
            this.rdbMonthly.AutoSize = true;
            this.rdbMonthly.Location = new System.Drawing.Point(6, 111);
            this.rdbMonthly.Name = "rdbMonthly";
            this.rdbMonthly.Size = new System.Drawing.Size(65, 17);
            this.rdbMonthly.TabIndex = 65;
            this.rdbMonthly.TabStop = true;
            this.rdbMonthly.Text = "Mensual";
            this.rdbMonthly.UseVisualStyleBackColor = true;
            this.rdbMonthly.CheckedChanged += new System.EventHandler(this.rdbMonthly_CheckedChanged);
            // 
            // rdbThirdTrimester
            // 
            this.rdbThirdTrimester.AutoSize = true;
            this.rdbThirdTrimester.Location = new System.Drawing.Point(6, 65);
            this.rdbThirdTrimester.Name = "rdbThirdTrimester";
            this.rdbThirdTrimester.Size = new System.Drawing.Size(102, 17);
            this.rdbThirdTrimester.TabIndex = 64;
            this.rdbThirdTrimester.TabStop = true;
            this.rdbThirdTrimester.Text = "Tercer Trimestre";
            this.rdbThirdTrimester.UseVisualStyleBackColor = true;
            // 
            // rdbSecondTrimester
            // 
            this.rdbSecondTrimester.AutoSize = true;
            this.rdbSecondTrimester.Location = new System.Drawing.Point(6, 43);
            this.rdbSecondTrimester.Name = "rdbSecondTrimester";
            this.rdbSecondTrimester.Size = new System.Drawing.Size(114, 17);
            this.rdbSecondTrimester.TabIndex = 63;
            this.rdbSecondTrimester.TabStop = true;
            this.rdbSecondTrimester.Text = "Segundo Trimestre";
            this.rdbSecondTrimester.UseVisualStyleBackColor = true;
            // 
            // rdbFirstTrimester
            // 
            this.rdbFirstTrimester.AutoSize = true;
            this.rdbFirstTrimester.Location = new System.Drawing.Point(6, 21);
            this.rdbFirstTrimester.Name = "rdbFirstTrimester";
            this.rdbFirstTrimester.Size = new System.Drawing.Size(100, 17);
            this.rdbFirstTrimester.TabIndex = 62;
            this.rdbFirstTrimester.TabStop = true;
            this.rdbFirstTrimester.Text = "Primer Trimestre";
            this.rdbFirstTrimester.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReport.Location = new System.Drawing.Point(12, 536);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(119, 23);
            this.btnReport.TabIndex = 61;
            this.btnReport.Text = "Generar Reporte";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(490, 120);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(99, 23);
            this.btnProcess.TabIndex = 60;
            this.btnProcess.Text = "Procesar";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // nbrYear
            // 
            this.nbrYear.Location = new System.Drawing.Point(433, 90);
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
            this.nbrYear.TabIndex = 59;
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
            this.lblYear.Location = new System.Drawing.Point(393, 94);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(26, 13);
            this.lblYear.TabIndex = 58;
            this.lblYear.Text = "Año";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(449, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(293, 25);
            this.lblTitle.TabIndex = 57;
            this.lblTitle.Text = "MOVIMIENTOS DE STOCK";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(1157, 536);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 56;
            this.btnQuit.Text = "Salir";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(433, 63);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(142, 21);
            this.cmbMonth.TabIndex = 55;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(392, 67);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(27, 13);
            this.lblMonth.TabIndex = 54;
            this.lblMonth.Text = "Mes";
            // 
            // grdTotals
            // 
            this.grdTotals.AllowUserToAddRows = false;
            this.grdTotals.AllowUserToDeleteRows = false;
            this.grdTotals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTotals.Location = new System.Drawing.Point(12, 149);
            this.grdTotals.Name = "grdTotals";
            this.grdTotals.Size = new System.Drawing.Size(1243, 381);
            this.grdTotals.TabIndex = 53;
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(641, 120);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(99, 23);
            this.btnClean.TabIndex = 69;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // grbPeriod
            // 
            this.grbPeriod.Controls.Add(this.rdbThirdTrimester);
            this.grbPeriod.Controls.Add(this.rdbFirstTrimester);
            this.grbPeriod.Controls.Add(this.rdbSecondTrimester);
            this.grbPeriod.Controls.Add(this.rdbMonthly);
            this.grbPeriod.Controls.Add(this.rdbFourthTrimester);
            this.grbPeriod.Location = new System.Drawing.Point(177, 5);
            this.grbPeriod.Name = "grbPeriod";
            this.grbPeriod.Size = new System.Drawing.Size(125, 143);
            this.grbPeriod.TabIndex = 70;
            this.grbPeriod.TabStop = false;
            this.grbPeriod.Text = "Periodo";
            // 
            // grbMovement
            // 
            this.grbMovement.Controls.Add(this.rdbAll);
            this.grbMovement.Controls.Add(this.rdbOut);
            this.grbMovement.Controls.Add(this.rdbIn);
            this.grbMovement.Location = new System.Drawing.Point(777, 39);
            this.grbMovement.Name = "grbMovement";
            this.grbMovement.Size = new System.Drawing.Size(122, 100);
            this.grbMovement.TabIndex = 71;
            this.grbMovement.TabStop = false;
            this.grbMovement.Text = "Movimientos";
            // 
            // rdbAll
            // 
            this.rdbAll.AutoSize = true;
            this.rdbAll.Location = new System.Drawing.Point(27, 78);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(50, 17);
            this.rdbAll.TabIndex = 74;
            this.rdbAll.TabStop = true;
            this.rdbAll.Text = "Todo";
            this.rdbAll.UseVisualStyleBackColor = true;
            // 
            // rdbOut
            // 
            this.rdbOut.AutoSize = true;
            this.rdbOut.Location = new System.Drawing.Point(27, 51);
            this.rdbOut.Name = "rdbOut";
            this.rdbOut.Size = new System.Drawing.Size(58, 17);
            this.rdbOut.TabIndex = 73;
            this.rdbOut.TabStop = true;
            this.rdbOut.Text = "Egreso";
            this.rdbOut.UseVisualStyleBackColor = true;
            // 
            // rdbIn
            // 
            this.rdbIn.AutoSize = true;
            this.rdbIn.Location = new System.Drawing.Point(27, 25);
            this.rdbIn.Name = "rdbIn";
            this.rdbIn.Size = new System.Drawing.Size(60, 17);
            this.rdbIn.TabIndex = 72;
            this.rdbIn.TabStop = true;
            this.rdbIn.Text = "Ingreso";
            this.rdbIn.UseVisualStyleBackColor = true;
            // 
            // chkGroupByElement
            // 
            this.chkGroupByElement.AutoSize = true;
            this.chkGroupByElement.Location = new System.Drawing.Point(310, 123);
            this.chkGroupByElement.Name = "chkGroupByElement";
            this.chkGroupByElement.Size = new System.Drawing.Size(128, 17);
            this.chkGroupByElement.TabIndex = 72;
            this.chkGroupByElement.Text = "Agrupar por Elemento";
            this.chkGroupByElement.UseVisualStyleBackColor = true;
            // 
            // FrmStockControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 583);
            this.Controls.Add(this.chkGroupByElement);
            this.Controls.Add(this.grbMovement);
            this.Controls.Add(this.grbPeriod);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.nbrYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.grdTotals);
            this.Name = "FrmStockControl";
            this.Text = "Control de Stock";
            this.Load += new System.EventHandler(this.FrmStockControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbrYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTotals)).EndInit();
            this.grbPeriod.ResumeLayout(false);
            this.grbPeriod.PerformLayout();
            this.grbMovement.ResumeLayout(false);
            this.grbMovement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbFourthTrimester;
        private System.Windows.Forms.RadioButton rdbMonthly;
        private System.Windows.Forms.RadioButton rdbThirdTrimester;
        private System.Windows.Forms.RadioButton rdbSecondTrimester;
        private System.Windows.Forms.RadioButton rdbFirstTrimester;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.NumericUpDown nbrYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.DataGridView grdTotals;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.GroupBox grbPeriod;
        private System.Windows.Forms.GroupBox grbMovement;
        private System.Windows.Forms.RadioButton rdbAll;
        private System.Windows.Forms.RadioButton rdbOut;
        private System.Windows.Forms.RadioButton rdbIn;
        private System.Windows.Forms.CheckBox chkGroupByElement;
    }
}