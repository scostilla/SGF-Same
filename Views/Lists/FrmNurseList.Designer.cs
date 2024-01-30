namespace Views.Lists
{
    partial class FrmNurseList
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
            this.btnClean = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.grdNurses = new System.Windows.Forms.DataGridView();
            this.nbrYear = new System.Windows.Forms.NumericUpDown();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnShowMonth = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.txtVehicle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdNurses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrYear)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(161, 521);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(84, 23);
            this.btnClean.TabIndex = 14;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(261, 521);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 15;
            this.btnQuit.Text = "Salir";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(49, 47);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(142, 21);
            this.cmbMonth.TabIndex = 13;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(15, 51);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(27, 13);
            this.lblMonth.TabIndex = 12;
            this.lblMonth.Text = "Mes";
            // 
            // grdNurses
            // 
            this.grdNurses.AllowUserToAddRows = false;
            this.grdNurses.AllowUserToDeleteRows = false;
            this.grdNurses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNurses.Location = new System.Drawing.Point(12, 110);
            this.grdNurses.Name = "grdNurses";
            this.grdNurses.Size = new System.Drawing.Size(324, 405);
            this.grdNurses.TabIndex = 11;
            // 
            // nbrYear
            // 
            this.nbrYear.Location = new System.Drawing.Point(231, 47);
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
            this.nbrYear.TabIndex = 17;
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
            this.lblYear.Location = new System.Drawing.Point(198, 51);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(26, 13);
            this.lblYear.TabIndex = 16;
            this.lblYear.Text = "Año";
            // 
            // btnShowMonth
            // 
            this.btnShowMonth.Location = new System.Drawing.Point(237, 81);
            this.btnShowMonth.Name = "btnShowMonth";
            this.btnShowMonth.Size = new System.Drawing.Size(99, 23);
            this.btnShowMonth.TabIndex = 18;
            this.btnShowMonth.Text = "Ver Mes";
            this.btnShowMonth.UseVisualStyleBackColor = true;
            this.btnShowMonth.Click += new System.EventHandler(this.btnShowMonth_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 521);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Swis721 Hv BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(86, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(177, 25);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Grilla Operativa";
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Location = new System.Drawing.Point(10, 87);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(32, 13);
            this.lblVehicle.TabIndex = 21;
            this.lblVehicle.Text = "Movil";
            // 
            // txtVehicle
            // 
            this.txtVehicle.Location = new System.Drawing.Point(48, 84);
            this.txtVehicle.Name = "txtVehicle";
            this.txtVehicle.Size = new System.Drawing.Size(100, 20);
            this.txtVehicle.TabIndex = 22;
            // 
            // FrmNurseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 552);
            this.Controls.Add(this.txtVehicle);
            this.Controls.Add(this.lblVehicle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnShowMonth);
            this.Controls.Add(this.nbrYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.grdNurses);
            this.Name = "FrmNurseList";
            this.Text = "Grilla Operativa";
            this.Load += new System.EventHandler(this.FrmNurseList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdNurses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.DataGridView grdNurses;
        private System.Windows.Forms.NumericUpDown nbrYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnShowMonth;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.TextBox txtVehicle;
    }
}