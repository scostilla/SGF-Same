
namespace Views.Lists
{
    partial class FrmElementsToExpire
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
            this.btnQuit = new System.Windows.Forms.Button();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.grdTotals = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.rdbAnnual = new System.Windows.Forms.RadioButton();
            this.btnClean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nbrYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTotals)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbFourthTrimester
            // 
            this.rdbFourthTrimester.AutoSize = true;
            this.rdbFourthTrimester.Location = new System.Drawing.Point(141, 82);
            this.rdbFourthTrimester.Name = "rdbFourthTrimester";
            this.rdbFourthTrimester.Size = new System.Drawing.Size(102, 17);
            this.rdbFourthTrimester.TabIndex = 66;
            this.rdbFourthTrimester.TabStop = true;
            this.rdbFourthTrimester.Text = "Cuarto Trimester";
            this.rdbFourthTrimester.UseVisualStyleBackColor = true;
            // 
            // rdbMonthly
            // 
            this.rdbMonthly.AutoSize = true;
            this.rdbMonthly.Location = new System.Drawing.Point(285, 56);
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
            this.rdbThirdTrimester.Location = new System.Drawing.Point(141, 56);
            this.rdbThirdTrimester.Name = "rdbThirdTrimester";
            this.rdbThirdTrimester.Size = new System.Drawing.Size(102, 17);
            this.rdbThirdTrimester.TabIndex = 64;
            this.rdbThirdTrimester.TabStop = true;
            this.rdbThirdTrimester.Text = "Tercer Trimester";
            this.rdbThirdTrimester.UseVisualStyleBackColor = true;
            // 
            // rdbSecondTrimester
            // 
            this.rdbSecondTrimester.AutoSize = true;
            this.rdbSecondTrimester.Location = new System.Drawing.Point(21, 82);
            this.rdbSecondTrimester.Name = "rdbSecondTrimester";
            this.rdbSecondTrimester.Size = new System.Drawing.Size(114, 17);
            this.rdbSecondTrimester.TabIndex = 63;
            this.rdbSecondTrimester.TabStop = true;
            this.rdbSecondTrimester.Text = "Segundo Trimester";
            this.rdbSecondTrimester.UseVisualStyleBackColor = true;
            // 
            // rdbFirstTrimester
            // 
            this.rdbFirstTrimester.AutoSize = true;
            this.rdbFirstTrimester.Location = new System.Drawing.Point(21, 56);
            this.rdbFirstTrimester.Name = "rdbFirstTrimester";
            this.rdbFirstTrimester.Size = new System.Drawing.Size(100, 17);
            this.rdbFirstTrimester.TabIndex = 62;
            this.rdbFirstTrimester.TabStop = true;
            this.rdbFirstTrimester.Text = "Primer Trimester";
            this.rdbFirstTrimester.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReport.Location = new System.Drawing.Point(18, 508);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(119, 23);
            this.btnReport.TabIndex = 61;
            this.btnReport.Text = "Generar Reporte";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(615, 53);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(99, 23);
            this.btnProcess.TabIndex = 60;
            this.btnProcess.Text = "Procesar";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // nbrYear
            // 
            this.nbrYear.Location = new System.Drawing.Point(439, 80);
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
            this.lblYear.Location = new System.Drawing.Point(400, 84);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(26, 13);
            this.lblYear.TabIndex = 58;
            this.lblYear.Text = "Año";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(1163, 508);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 56;
            this.btnQuit.Text = "Salir";
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(439, 54);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(142, 21);
            this.cmbMonth.TabIndex = 55;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(399, 58);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(27, 13);
            this.lblMonth.TabIndex = 54;
            this.lblMonth.Text = "Mes";
            // 
            // grdTotals
            // 
            this.grdTotals.AllowUserToAddRows = false;
            this.grdTotals.AllowUserToDeleteRows = false;
            this.grdTotals.AllowUserToResizeColumns = false;
            this.grdTotals.AllowUserToResizeRows = false;
            this.grdTotals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTotals.Location = new System.Drawing.Point(4, 121);
            this.grdTotals.Name = "grdTotals";
            this.grdTotals.ReadOnly = true;
            this.grdTotals.Size = new System.Drawing.Size(727, 381);
            this.grdTotals.TabIndex = 53;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(167, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(325, 25);
            this.lblTitle.TabIndex = 57;
            this.lblTitle.Text = "Elementos proximos a Vencer";
            // 
            // rdbAnnual
            // 
            this.rdbAnnual.AutoSize = true;
            this.rdbAnnual.Location = new System.Drawing.Point(285, 82);
            this.rdbAnnual.Name = "rdbAnnual";
            this.rdbAnnual.Size = new System.Drawing.Size(52, 17);
            this.rdbAnnual.TabIndex = 65;
            this.rdbAnnual.TabStop = true;
            this.rdbAnnual.Text = "Anual";
            this.rdbAnnual.UseVisualStyleBackColor = true;
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(615, 79);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(99, 23);
            this.btnClean.TabIndex = 67;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // FrmElementsToExpire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 539);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.rdbFourthTrimester);
            this.Controls.Add(this.rdbAnnual);
            this.Controls.Add(this.rdbMonthly);
            this.Controls.Add(this.rdbThirdTrimester);
            this.Controls.Add(this.rdbSecondTrimester);
            this.Controls.Add(this.rdbFirstTrimester);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.nbrYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.grdTotals);
            this.Name = "FrmElementsToExpire";
            this.Text = "Elementos Proximos a Vencer";
            this.Load += new System.EventHandler(this.FrmElementsToExpire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbrYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTotals)).EndInit();
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
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.DataGridView grdTotals;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton rdbAnnual;
        private System.Windows.Forms.Button btnClean;
    }
}