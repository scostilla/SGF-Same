namespace Views.NewForms
{
    partial class FrmNewEgress
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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblElement = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbBase = new System.Windows.Forms.ComboBox();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lblElementQuantity = new System.Windows.Forms.Label();
            this.cmbElement = new System.Windows.Forms.ComboBox();
            this.nbrQantity = new System.Windows.Forms.NumericUpDown();
            this.lblResidue = new System.Windows.Forms.Label();
            this.lblTotalResidue = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblObservations = new System.Windows.Forms.Label();
            this.txtObservations = new System.Windows.Forms.TextBox();
            this.lblLot = new System.Windows.Forms.Label();
            this.txtLot = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.lblBarCode = new System.Windows.Forms.Label();
            this.cmbLot = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nbrQantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(49, 66);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(37, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Fecha";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(55, 98);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(31, 13);
            this.lblBase.TabIndex = 2;
            this.lblBase.Text = "Base";
            // 
            // lblElement
            // 
            this.lblElement.AutoSize = true;
            this.lblElement.Location = new System.Drawing.Point(33, 163);
            this.lblElement.Name = "lblElement";
            this.lblElement.Size = new System.Drawing.Size(51, 13);
            this.lblElement.TabIndex = 3;
            this.lblElement.Text = "Elemento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cantidad";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(92, 62);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(120, 20);
            this.dtpDate.TabIndex = 0;
            // 
            // cmbBase
            // 
            this.cmbBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBase.FormattingEnabled = true;
            this.cmbBase.Location = new System.Drawing.Point(92, 94);
            this.cmbBase.Name = "cmbBase";
            this.cmbBase.Size = new System.Drawing.Size(200, 21);
            this.cmbBase.TabIndex = 1;
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(249, 229);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(64, 13);
            this.lblAvailable.TabIndex = 7;
            this.lblAvailable.Text = "Disponibles:";
            // 
            // lblElementQuantity
            // 
            this.lblElementQuantity.AutoSize = true;
            this.lblElementQuantity.Location = new System.Drawing.Point(319, 229);
            this.lblElementQuantity.Name = "lblElementQuantity";
            this.lblElementQuantity.Size = new System.Drawing.Size(86, 13);
            this.lblElementQuantity.TabIndex = 8;
            this.lblElementQuantity.Text = "element.Egress";
            // 
            // cmbElement
            // 
            this.cmbElement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbElement.FormattingEnabled = true;
            this.cmbElement.Location = new System.Drawing.Point(90, 159);
            this.cmbElement.Name = "cmbElement";
            this.cmbElement.Size = new System.Drawing.Size(200, 21);
            this.cmbElement.TabIndex = 3;
            // 
            // nbrQantity
            // 
            this.nbrQantity.Location = new System.Drawing.Point(90, 224);
            this.nbrQantity.Name = "nbrQantity";
            this.nbrQantity.Size = new System.Drawing.Size(120, 20);
            this.nbrQantity.TabIndex = 5;
            // 
            // lblResidue
            // 
            this.lblResidue.AutoSize = true;
            this.lblResidue.Location = new System.Drawing.Point(249, 263);
            this.lblResidue.Name = "lblResidue";
            this.lblResidue.Size = new System.Drawing.Size(53, 13);
            this.lblResidue.TabIndex = 11;
            this.lblResidue.Text = "Restante:";
            // 
            // lblTotalResidue
            // 
            this.lblTotalResidue.AutoSize = true;
            this.lblTotalResidue.Location = new System.Drawing.Point(308, 263);
            this.lblTotalResidue.Name = "lblTotalResidue";
            this.lblTotalResidue.Size = new System.Drawing.Size(149, 13);
            this.lblTotalResidue.TabIndex = 12;
            this.lblTotalResidue.Text = "element.Egress - nbrQuantity";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 404);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(237, 404);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(342, 404);
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
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(69, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(331, 25);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Registro de Uso de Elementos";
            // 
            // lblObservations
            // 
            this.lblObservations.AutoSize = true;
            this.lblObservations.Location = new System.Drawing.Point(8, 295);
            this.lblObservations.Name = "lblObservations";
            this.lblObservations.Size = new System.Drawing.Size(78, 13);
            this.lblObservations.TabIndex = 17;
            this.lblObservations.Text = "Observaciones";
            // 
            // txtObservations
            // 
            this.txtObservations.Location = new System.Drawing.Point(90, 291);
            this.txtObservations.MaxLength = 250;
            this.txtObservations.Multiline = true;
            this.txtObservations.Name = "txtObservations";
            this.txtObservations.Size = new System.Drawing.Size(305, 97);
            this.txtObservations.TabIndex = 7;
            // 
            // lblLot
            // 
            this.lblLot.AutoSize = true;
            this.lblLot.Location = new System.Drawing.Point(53, 196);
            this.lblLot.Name = "lblLot";
            this.lblLot.Size = new System.Drawing.Size(28, 13);
            this.lblLot.TabIndex = 19;
            this.lblLot.Text = "Lote";
            // 
            // txtLot
            // 
            this.txtLot.Location = new System.Drawing.Point(88, 192);
            this.txtLot.MaxLength = 10;
            this.txtLot.Name = "txtLot";
            this.txtLot.Size = new System.Drawing.Size(122, 20);
            this.txtLot.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(90, 258);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(117, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calcular Saldo";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtBarCode
            // 
            this.txtBarCode.Location = new System.Drawing.Point(92, 128);
            this.txtBarCode.MaxLength = 50;
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(200, 20);
            this.txtBarCode.TabIndex = 2;
            this.txtBarCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarCode_KeyPress);
            // 
            // lblBarCode
            // 
            this.lblBarCode.AutoSize = true;
            this.lblBarCode.Location = new System.Drawing.Point(49, 131);
            this.lblBarCode.Name = "lblBarCode";
            this.lblBarCode.Size = new System.Drawing.Size(40, 13);
            this.lblBarCode.TabIndex = 22;
            this.lblBarCode.Text = "Codigo";
            // 
            // cmbLot
            // 
            this.cmbLot.FormattingEnabled = true;
            this.cmbLot.Location = new System.Drawing.Point(89, 192);
            this.cmbLot.Name = "cmbLot";
            this.cmbLot.Size = new System.Drawing.Size(121, 21);
            this.cmbLot.TabIndex = 23;
            this.cmbLot.SelectedIndexChanged += new System.EventHandler(this.cmbLot_SelectedIndexChanged);
            // 
            // FrmNewEgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 439);
            this.Controls.Add(this.cmbLot);
            this.Controls.Add(this.txtBarCode);
            this.Controls.Add(this.lblBarCode);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtLot);
            this.Controls.Add(this.lblLot);
            this.Controls.Add(this.txtObservations);
            this.Controls.Add(this.lblObservations);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTotalResidue);
            this.Controls.Add(this.lblResidue);
            this.Controls.Add(this.nbrQantity);
            this.Controls.Add(this.cmbElement);
            this.Controls.Add(this.lblElementQuantity);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.cmbBase);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblElement);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblDate);
            this.Name = "FrmNewEgress";
            this.Text = "Nuevo Egreso";
            this.Load += new System.EventHandler(this.FrmNewEgress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbrQantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblElement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cmbBase;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblElementQuantity;
        private System.Windows.Forms.ComboBox cmbElement;
        private System.Windows.Forms.NumericUpDown nbrQantity;
        private System.Windows.Forms.Label lblResidue;
        private System.Windows.Forms.Label lblTotalResidue;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblObservations;
        private System.Windows.Forms.TextBox txtObservations;
        private System.Windows.Forms.Label lblLot;
        private System.Windows.Forms.TextBox txtLot;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Label lblBarCode;
        private System.Windows.Forms.ComboBox cmbLot;
    }
}