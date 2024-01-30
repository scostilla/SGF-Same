namespace Views.Lists
{
    partial class FrmAlertValuesList
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
            this.chkAllElements = new System.Windows.Forms.CheckBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.cmbBase = new System.Windows.Forms.ComboBox();
            this.cmbElement = new System.Windows.Forms.ComboBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblElement = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.grdAlertValues = new System.Windows.Forms.DataGridView();
            this.btnClean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdAlertValues)).BeginInit();
            this.SuspendLayout();
            // 
            // chkAllElements
            // 
            this.chkAllElements.AutoSize = true;
            this.chkAllElements.Location = new System.Drawing.Point(367, 59);
            this.chkAllElements.Name = "chkAllElements";
            this.chkAllElements.Size = new System.Drawing.Size(124, 17);
            this.chkAllElements.TabIndex = 1;
            this.chkAllElements.Text = "Todos los Elementos";
            this.chkAllElements.UseVisualStyleBackColor = true;
            this.chkAllElements.CheckStateChanged += new System.EventHandler(this.chkAllElementsChange);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(559, 56);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(99, 23);
            this.btnProcess.TabIndex = 3;
            this.btnProcess.Text = "Procesar";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // cmbBase
            // 
            this.cmbBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBase.FormattingEnabled = true;
            this.cmbBase.Location = new System.Drawing.Point(86, 93);
            this.cmbBase.Name = "cmbBase";
            this.cmbBase.Size = new System.Drawing.Size(264, 21);
            this.cmbBase.TabIndex = 2;
            // 
            // cmbElement
            // 
            this.cmbElement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbElement.FormattingEnabled = true;
            this.cmbElement.Location = new System.Drawing.Point(86, 57);
            this.cmbElement.Name = "cmbElement";
            this.cmbElement.Size = new System.Drawing.Size(264, 21);
            this.cmbElement.TabIndex = 0;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(49, 97);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(31, 13);
            this.lblBase.TabIndex = 17;
            this.lblBase.Text = "Base";
            // 
            // lblElement
            // 
            this.lblElement.AutoSize = true;
            this.lblElement.Location = new System.Drawing.Point(29, 61);
            this.lblElement.Name = "lblElement";
            this.lblElement.Size = new System.Drawing.Size(51, 13);
            this.lblElement.TabIndex = 14;
            this.lblElement.Text = "Elemento";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(237, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(208, 25);
            this.lblTitle.TabIndex = 25;
            this.lblTitle.Text = "Alertas Establecidas";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(713, 415);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Salir";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // grdAlertValues
            // 
            this.grdAlertValues.AllowUserToAddRows = false;
            this.grdAlertValues.AllowUserToDeleteRows = false;
            this.grdAlertValues.AllowUserToOrderColumns = true;
            this.grdAlertValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAlertValues.Location = new System.Drawing.Point(12, 133);
            this.grdAlertValues.Name = "grdAlertValues";
            this.grdAlertValues.ReadOnly = true;
            this.grdAlertValues.Size = new System.Drawing.Size(776, 276);
            this.grdAlertValues.TabIndex = 27;
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(559, 93);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(99, 23);
            this.btnClean.TabIndex = 4;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // FrmAlertValuesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.grdAlertValues);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.chkAllElements);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.cmbBase);
            this.Controls.Add(this.cmbElement);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblElement);
            this.MinimizeBox = false;
            this.Name = "FrmAlertValuesList";
            this.Text = "FrmAlertValuesList";
            this.Load += new System.EventHandler(this.FrmAlertValuesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAlertValues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAllElements;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.ComboBox cmbBase;
        private System.Windows.Forms.ComboBox cmbElement;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblElement;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.DataGridView grdAlertValues;
        private System.Windows.Forms.Button btnClean;
    }
}