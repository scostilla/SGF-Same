namespace Views.NewForms
{
    partial class FrmNewStock
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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblElement = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblExpiration = new System.Windows.Forms.Label();
            this.lblResidueTitle = new System.Windows.Forms.Label();
            this.grbElement = new System.Windows.Forms.GroupBox();
            this.btnNewLot = new System.Windows.Forms.Button();
            this.txtObservations = new System.Windows.Forms.TextBox();
            this.lblObservations = new System.Windows.Forms.Label();
            this.lblResidue = new System.Windows.Forms.Label();
            this.cmbLot = new System.Windows.Forms.ComboBox();
            this.txtRemit = new System.Windows.Forms.TextBox();
            this.lblRemit = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.lblBarCode = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnNewElement = new System.Windows.Forms.Button();
            this.nbrQuantity = new System.Windows.Forms.NumericUpDown();
            this.dtpExpire = new System.Windows.Forms.DateTimePicker();
            this.txtLot = new System.Windows.Forms.TextBox();
            this.cmbElement = new System.Windows.Forms.ComboBox();
            this.lblInOut = new System.Windows.Forms.Label();
            this.cmbInOut = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblOriginDestiny = new System.Windows.Forms.Label();
            this.cmbOriginDestiny = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grbElement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbrQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(238, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(114, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "INGRESO";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(158, 109);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(37, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Fecha";
            // 
            // lblElement
            // 
            this.lblElement.AutoSize = true;
            this.lblElement.Location = new System.Drawing.Point(36, 55);
            this.lblElement.Name = "lblElement";
            this.lblElement.Size = new System.Drawing.Size(51, 13);
            this.lblElement.TabIndex = 2;
            this.lblElement.Text = "Elemento";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(39, 146);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lote";
            // 
            // lblExpiration
            // 
            this.lblExpiration.AutoSize = true;
            this.lblExpiration.Location = new System.Drawing.Point(22, 116);
            this.lblExpiration.Name = "lblExpiration";
            this.lblExpiration.Size = new System.Drawing.Size(65, 13);
            this.lblExpiration.TabIndex = 5;
            this.lblExpiration.Text = "Vencimiento";
            // 
            // lblResidueTitle
            // 
            this.lblResidueTitle.AutoSize = true;
            this.lblResidueTitle.Location = new System.Drawing.Point(326, 149);
            this.lblResidueTitle.Name = "lblResidueTitle";
            this.lblResidueTitle.Size = new System.Drawing.Size(37, 13);
            this.lblResidueTitle.TabIndex = 8;
            this.lblResidueTitle.Text = "Saldo:";
            // 
            // grbElement
            // 
            this.grbElement.Controls.Add(this.btnNewLot);
            this.grbElement.Controls.Add(this.txtObservations);
            this.grbElement.Controls.Add(this.lblObservations);
            this.grbElement.Controls.Add(this.lblResidue);
            this.grbElement.Controls.Add(this.cmbLot);
            this.grbElement.Controls.Add(this.txtRemit);
            this.grbElement.Controls.Add(this.lblRemit);
            this.grbElement.Controls.Add(this.btnSearch);
            this.grbElement.Controls.Add(this.txtBarCode);
            this.grbElement.Controls.Add(this.lblBarCode);
            this.grbElement.Controls.Add(this.btnCalculate);
            this.grbElement.Controls.Add(this.btnNewElement);
            this.grbElement.Controls.Add(this.nbrQuantity);
            this.grbElement.Controls.Add(this.dtpExpire);
            this.grbElement.Controls.Add(this.txtLot);
            this.grbElement.Controls.Add(this.lblResidueTitle);
            this.grbElement.Controls.Add(this.cmbElement);
            this.grbElement.Controls.Add(this.label1);
            this.grbElement.Controls.Add(this.lblElement);
            this.grbElement.Controls.Add(this.lblQuantity);
            this.grbElement.Controls.Add(this.lblExpiration);
            this.grbElement.Location = new System.Drawing.Point(38, 175);
            this.grbElement.Name = "grbElement";
            this.grbElement.Size = new System.Drawing.Size(457, 255);
            this.grbElement.TabIndex = 3;
            this.grbElement.TabStop = false;
            this.grbElement.Text = "Elemento";
            // 
            // btnNewLot
            // 
            this.btnNewLot.Location = new System.Drawing.Point(217, 81);
            this.btnNewLot.Name = "btnNewLot";
            this.btnNewLot.Size = new System.Drawing.Size(72, 23);
            this.btnNewLot.TabIndex = 14;
            this.btnNewLot.Text = "Nuevo Lote";
            this.btnNewLot.UseVisualStyleBackColor = true;
            this.btnNewLot.Click += new System.EventHandler(this.btnNewLot_Click);
            // 
            // txtObservations
            // 
            this.txtObservations.Location = new System.Drawing.Point(93, 194);
            this.txtObservations.Multiline = true;
            this.txtObservations.Name = "txtObservations";
            this.txtObservations.Size = new System.Drawing.Size(338, 51);
            this.txtObservations.TabIndex = 13;
            // 
            // lblObservations
            // 
            this.lblObservations.AutoSize = true;
            this.lblObservations.Location = new System.Drawing.Point(10, 202);
            this.lblObservations.Name = "lblObservations";
            this.lblObservations.Size = new System.Drawing.Size(78, 13);
            this.lblObservations.TabIndex = 12;
            this.lblObservations.Text = "Observaciones";
            // 
            // lblResidue
            // 
            this.lblResidue.AutoSize = true;
            this.lblResidue.Location = new System.Drawing.Point(369, 149);
            this.lblResidue.Name = "lblResidue";
            this.lblResidue.Size = new System.Drawing.Size(56, 13);
            this.lblResidue.TabIndex = 11;
            this.lblResidue.Text = "lblResidue";
            // 
            // cmbLot
            // 
            this.cmbLot.FormattingEnabled = true;
            this.cmbLot.Location = new System.Drawing.Point(93, 82);
            this.cmbLot.Name = "cmbLot";
            this.cmbLot.Size = new System.Drawing.Size(121, 21);
            this.cmbLot.TabIndex = 10;
            this.cmbLot.SelectedIndexChanged += new System.EventHandler(this.cmbLot_SelectedIndexChanged);
            // 
            // txtRemit
            // 
            this.txtRemit.Location = new System.Drawing.Point(93, 168);
            this.txtRemit.MaxLength = 15;
            this.txtRemit.Name = "txtRemit";
            this.txtRemit.Size = new System.Drawing.Size(120, 20);
            this.txtRemit.TabIndex = 8;
            // 
            // lblRemit
            // 
            this.lblRemit.AutoSize = true;
            this.lblRemit.Location = new System.Drawing.Point(47, 171);
            this.lblRemit.Name = "lblRemit";
            this.lblRemit.Size = new System.Drawing.Size(40, 13);
            this.lblRemit.TabIndex = 9;
            this.lblRemit.Text = "Remito";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(377, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(54, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBarCode
            // 
            this.txtBarCode.Location = new System.Drawing.Point(94, 21);
            this.txtBarCode.MaxLength = 50;
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(277, 20);
            this.txtBarCode.TabIndex = 0;
            this.txtBarCode.TextChanged += new System.EventHandler(this.txtBarCode_TextChanged);
            this.txtBarCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarCode_KeyPress);
            // 
            // lblBarCode
            // 
            this.lblBarCode.AutoSize = true;
            this.lblBarCode.Location = new System.Drawing.Point(48, 25);
            this.lblBarCode.Name = "lblBarCode";
            this.lblBarCode.Size = new System.Drawing.Size(40, 13);
            this.lblBarCode.TabIndex = 7;
            this.lblBarCode.Text = "Codigo";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(327, 117);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(104, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calcular Saldo";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnNewElement
            // 
            this.btnNewElement.Location = new System.Drawing.Point(327, 88);
            this.btnNewElement.Name = "btnNewElement";
            this.btnNewElement.Size = new System.Drawing.Size(104, 23);
            this.btnNewElement.TabIndex = 6;
            this.btnNewElement.Text = "Nuevo Elemento";
            this.btnNewElement.UseVisualStyleBackColor = true;
            this.btnNewElement.Click += new System.EventHandler(this.btnNewElement_Click);
            // 
            // nbrQuantity
            // 
            this.nbrQuantity.Location = new System.Drawing.Point(94, 142);
            this.nbrQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nbrQuantity.Name = "nbrQuantity";
            this.nbrQuantity.Size = new System.Drawing.Size(120, 20);
            this.nbrQuantity.TabIndex = 1;
            // 
            // dtpExpire
            // 
            this.dtpExpire.Location = new System.Drawing.Point(93, 112);
            this.dtpExpire.Name = "dtpExpire";
            this.dtpExpire.Size = new System.Drawing.Size(121, 20);
            this.dtpExpire.TabIndex = 5;
            // 
            // txtLot
            // 
            this.txtLot.Location = new System.Drawing.Point(93, 82);
            this.txtLot.MaxLength = 20;
            this.txtLot.Name = "txtLot";
            this.txtLot.Size = new System.Drawing.Size(120, 20);
            this.txtLot.TabIndex = 4;
            // 
            // cmbElement
            // 
            this.cmbElement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbElement.FormattingEnabled = true;
            this.cmbElement.Location = new System.Drawing.Point(93, 51);
            this.cmbElement.Name = "cmbElement";
            this.cmbElement.Size = new System.Drawing.Size(338, 21);
            this.cmbElement.TabIndex = 3;
            // 
            // lblInOut
            // 
            this.lblInOut.AutoSize = true;
            this.lblInOut.Location = new System.Drawing.Point(115, 71);
            this.lblInOut.Name = "lblInOut";
            this.lblInOut.Size = new System.Drawing.Size(80, 13);
            this.lblInOut.TabIndex = 10;
            this.lblInOut.Text = "Ingreso/Egreso";
            // 
            // cmbInOut
            // 
            this.cmbInOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInOut.FormattingEnabled = true;
            this.cmbInOut.Location = new System.Drawing.Point(201, 68);
            this.cmbInOut.Name = "cmbInOut";
            this.cmbInOut.Size = new System.Drawing.Size(126, 21);
            this.cmbInOut.TabIndex = 0;
            this.cmbInOut.SelectedIndexChanged += new System.EventHandler(this.cmbInOut_SelectedIndexChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(201, 107);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(126, 20);
            this.dtpDate.TabIndex = 1;
            // 
            // lblOriginDestiny
            // 
            this.lblOriginDestiny.AutoSize = true;
            this.lblOriginDestiny.Location = new System.Drawing.Point(128, 146);
            this.lblOriginDestiny.Name = "lblOriginDestiny";
            this.lblOriginDestiny.Size = new System.Drawing.Size(67, 13);
            this.lblOriginDestiny.TabIndex = 17;
            this.lblOriginDestiny.Text = "Procedencia";
            // 
            // cmbOriginDestiny
            // 
            this.cmbOriginDestiny.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOriginDestiny.FormattingEnabled = true;
            this.cmbOriginDestiny.Location = new System.Drawing.Point(201, 143);
            this.cmbOriginDestiny.Name = "cmbOriginDestiny";
            this.cmbOriginDestiny.Size = new System.Drawing.Size(200, 21);
            this.cmbOriginDestiny.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 436);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(394, 436);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(486, 436);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Salir";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmNewStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 474);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbOriginDestiny);
            this.Controls.Add(this.lblOriginDestiny);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbInOut);
            this.Controls.Add(this.lblInOut);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.grbElement);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmNewStock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.FrmNewStock_Load);
            this.grbElement.ResumeLayout(false);
            this.grbElement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbrQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblElement;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExpiration;
        private System.Windows.Forms.Label lblResidueTitle;
        private System.Windows.Forms.GroupBox grbElement;
        private System.Windows.Forms.Label lblInOut;
        private System.Windows.Forms.DateTimePicker dtpExpire;
        private System.Windows.Forms.TextBox txtLot;
        private System.Windows.Forms.ComboBox cmbElement;
        private System.Windows.Forms.ComboBox cmbInOut;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblOriginDestiny;
        private System.Windows.Forms.ComboBox cmbOriginDestiny;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.NumericUpDown nbrQuantity;
        private System.Windows.Forms.Button btnNewElement;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Label lblBarCode;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtRemit;
        private System.Windows.Forms.Label lblRemit;
        private System.Windows.Forms.ComboBox cmbLot;
        private System.Windows.Forms.Label lblResidue;
        private System.Windows.Forms.TextBox txtObservations;
        private System.Windows.Forms.Label lblObservations;
        private System.Windows.Forms.Button btnNewLot;
    }
}