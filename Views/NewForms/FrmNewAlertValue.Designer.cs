namespace Views.NewForms
{
    partial class FrmNewAlertValue
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
            this.lblBase = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblElement = new System.Windows.Forms.Label();
            this.lblAlertQuantity = new System.Windows.Forms.Label();
            this.cmbBase = new System.Windows.Forms.ComboBox();
            this.cmbElement = new System.Windows.Forms.ComboBox();
            this.nbrQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnSetAlertValue = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nbrQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(63, 72);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(31, 13);
            this.lblBase.TabIndex = 0;
            this.lblBase.Text = "Base";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Swis721 Blk BT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(26, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(309, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Establecer Valores Limite";
            // 
            // FrmMedicineTrace
            // 
            this.lblElement.AutoSize = true;
            this.lblElement.Location = new System.Drawing.Point(43, 108);
            this.lblElement.Name = "FrmMedicineTrace";
            this.lblElement.Size = new System.Drawing.Size(51, 13);
            this.lblElement.TabIndex = 2;
            this.lblElement.Text = "Elemento";
            // 
            // lblAlertQuantity
            // 
            this.lblAlertQuantity.AutoSize = true;
            this.lblAlertQuantity.Location = new System.Drawing.Point(27, 150);
            this.lblAlertQuantity.Name = "lblAlertQuantity";
            this.lblAlertQuantity.Size = new System.Drawing.Size(85, 13);
            this.lblAlertQuantity.TabIndex = 3;
            this.lblAlertQuantity.Text = "Cantidad Minima";
            // 
            // cmbBase
            // 
            this.cmbBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBase.FormattingEnabled = true;
            this.cmbBase.Location = new System.Drawing.Point(100, 68);
            this.cmbBase.Name = "cmbBase";
            this.cmbBase.Size = new System.Drawing.Size(200, 21);
            this.cmbBase.TabIndex = 0;
            // 
            // cmbElement
            // 
            this.cmbElement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbElement.FormattingEnabled = true;
            this.cmbElement.Location = new System.Drawing.Point(100, 104);
            this.cmbElement.Name = "cmbElement";
            this.cmbElement.Size = new System.Drawing.Size(200, 21);
            this.cmbElement.TabIndex = 1;
            // 
            // nbrQuantity
            // 
            this.nbrQuantity.Location = new System.Drawing.Point(119, 146);
            this.nbrQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nbrQuantity.Name = "nbrQuantity";
            this.nbrQuantity.Size = new System.Drawing.Size(120, 20);
            this.nbrQuantity.TabIndex = 2;
            // 
            // btnSetAlertValue
            // 
            this.btnSetAlertValue.Location = new System.Drawing.Point(26, 203);
            this.btnSetAlertValue.Name = "btnSetAlertValue";
            this.btnSetAlertValue.Size = new System.Drawing.Size(75, 23);
            this.btnSetAlertValue.TabIndex = 3;
            this.btnSetAlertValue.Text = "Establecer";
            this.btnSetAlertValue.UseVisualStyleBackColor = true;
            this.btnSetAlertValue.Click += new System.EventHandler(this.btnSetAlertValue_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(177, 203);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(273, 203);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Salir";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // FrmNewAlertValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 244);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSetAlertValue);
            this.Controls.Add(this.nbrQuantity);
            this.Controls.Add(this.cmbElement);
            this.Controls.Add(this.cmbBase);
            this.Controls.Add(this.lblAlertQuantity);
            this.Controls.Add(this.lblElement);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBase);
            this.Name = "FrmNewAlertValue";
            this.Text = "Valores de Alerta";
            this.Load += new System.EventHandler(this.FrmNewAlertValue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbrQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblElement;
        private System.Windows.Forms.Label lblAlertQuantity;
        private System.Windows.Forms.ComboBox cmbBase;
        private System.Windows.Forms.ComboBox cmbElement;
        private System.Windows.Forms.NumericUpDown nbrQuantity;
        private System.Windows.Forms.Button btnSetAlertValue;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnQuit;
    }
}