namespace Views.Lists
{
    partial class FrmContorlSheetTotals
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
            this.btnReport = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.nbrYear = new System.Windows.Forms.NumericUpDown();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.grdTotals = new System.Windows.Forms.DataGridView();
            this.rdbFirstTrimester = new System.Windows.Forms.RadioButton();
            this.rdbSecondTrimester = new System.Windows.Forms.RadioButton();
            this.rdbThirdTrimester = new System.Windows.Forms.RadioButton();
            this.rdbMonthly = new System.Windows.Forms.RadioButton();
            this.rdbFourthTrimester = new System.Windows.Forms.RadioButton();
            this.btnClean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nbrYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTotals)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReport
            // 
            this.btnReport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReport.Location = new System.Drawing.Point(12, 514);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(119, 23);
            this.btnReport.TabIndex = 47;
            this.btnReport.Text = "Generar Reporte";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(593, 83);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(99, 23);
            this.btnProcess.TabIndex = 41;
            this.btnProcess.Text = "Procesar";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // nbrYear
            // 
            this.nbrYear.Location = new System.Drawing.Point(433, 86);
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
            this.nbrYear.TabIndex = 40;
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
            this.lblYear.Location = new System.Drawing.Point(394, 90);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(26, 13);
            this.lblYear.TabIndex = 39;
            this.lblYear.Text = "Año";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(504, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(208, 25);
            this.lblTitle.TabIndex = 38;
            this.lblTitle.Text = "Planilla de Totales";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(1157, 514);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 37;
            this.btnQuit.Text = "Salir";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(433, 59);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(142, 21);
            this.cmbMonth.TabIndex = 35;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(393, 63);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(27, 13);
            this.lblMonth.TabIndex = 34;
            this.lblMonth.Text = "Mes";
            // 
            // grdTotals
            // 
            this.grdTotals.AllowUserToAddRows = false;
            this.grdTotals.AllowUserToDeleteRows = false;
            this.grdTotals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTotals.Location = new System.Drawing.Point(12, 127);
            this.grdTotals.Name = "grdTotals";
            this.grdTotals.Size = new System.Drawing.Size(1220, 381);
            this.grdTotals.TabIndex = 33;
            // 
            // rdbFirstTrimester
            // 
            this.rdbFirstTrimester.AutoSize = true;
            this.rdbFirstTrimester.Location = new System.Drawing.Point(237, 12);
            this.rdbFirstTrimester.Name = "rdbFirstTrimester";
            this.rdbFirstTrimester.Size = new System.Drawing.Size(100, 17);
            this.rdbFirstTrimester.TabIndex = 48;
            this.rdbFirstTrimester.TabStop = true;
            this.rdbFirstTrimester.Text = "Primer Trimester";
            this.rdbFirstTrimester.UseVisualStyleBackColor = true;
            // 
            // rdbSecondTrimester
            // 
            this.rdbSecondTrimester.AutoSize = true;
            this.rdbSecondTrimester.Location = new System.Drawing.Point(237, 34);
            this.rdbSecondTrimester.Name = "rdbSecondTrimester";
            this.rdbSecondTrimester.Size = new System.Drawing.Size(114, 17);
            this.rdbSecondTrimester.TabIndex = 49;
            this.rdbSecondTrimester.TabStop = true;
            this.rdbSecondTrimester.Text = "Segundo Trimester";
            this.rdbSecondTrimester.UseVisualStyleBackColor = true;
            // 
            // rdbThirdTrimester
            // 
            this.rdbThirdTrimester.AutoSize = true;
            this.rdbThirdTrimester.Location = new System.Drawing.Point(237, 56);
            this.rdbThirdTrimester.Name = "rdbThirdTrimester";
            this.rdbThirdTrimester.Size = new System.Drawing.Size(102, 17);
            this.rdbThirdTrimester.TabIndex = 50;
            this.rdbThirdTrimester.TabStop = true;
            this.rdbThirdTrimester.Text = "Tercer Trimester";
            this.rdbThirdTrimester.UseVisualStyleBackColor = true;
            // 
            // rdbMonthly
            // 
            this.rdbMonthly.AutoSize = true;
            this.rdbMonthly.Location = new System.Drawing.Point(237, 102);
            this.rdbMonthly.Name = "rdbMonthly";
            this.rdbMonthly.Size = new System.Drawing.Size(65, 17);
            this.rdbMonthly.TabIndex = 51;
            this.rdbMonthly.TabStop = true;
            this.rdbMonthly.Text = "Mensual";
            this.rdbMonthly.UseVisualStyleBackColor = true;
            this.rdbMonthly.CheckedChanged += new System.EventHandler(this.rdbMonthly_CheckedChanged);
            // 
            // rdbFourthTrimester
            // 
            this.rdbFourthTrimester.AutoSize = true;
            this.rdbFourthTrimester.Location = new System.Drawing.Point(237, 79);
            this.rdbFourthTrimester.Name = "rdbFourthTrimester";
            this.rdbFourthTrimester.Size = new System.Drawing.Size(102, 17);
            this.rdbFourthTrimester.TabIndex = 52;
            this.rdbFourthTrimester.TabStop = true;
            this.rdbFourthTrimester.Text = "Cuarto Trimester";
            this.rdbFourthTrimester.UseVisualStyleBackColor = true;
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(728, 83);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(99, 23);
            this.btnClean.TabIndex = 41;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // FrmContorlSheetTotals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 547);
            this.Controls.Add(this.rdbFourthTrimester);
            this.Controls.Add(this.rdbMonthly);
            this.Controls.Add(this.rdbThirdTrimester);
            this.Controls.Add(this.rdbSecondTrimester);
            this.Controls.Add(this.rdbFirstTrimester);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.nbrYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.grdTotals);
            this.Name = "FrmContorlSheetTotals";
            this.Text = "FrmContorlSheetTotals";
            this.Load += new System.EventHandler(this.FrmContorlSheetTotals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbrYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTotals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.NumericUpDown nbrYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.DataGridView grdTotals;
        private System.Windows.Forms.RadioButton rdbFirstTrimester;
        private System.Windows.Forms.RadioButton rdbSecondTrimester;
        private System.Windows.Forms.RadioButton rdbThirdTrimester;
        private System.Windows.Forms.RadioButton rdbMonthly;
        private System.Windows.Forms.RadioButton rdbFourthTrimester;
        private System.Windows.Forms.Button btnClean;
    }
}