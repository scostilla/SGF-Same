namespace Views.NewForms
{
    partial class FrmNewMedicineDestruction
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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtRequestedBy = new System.Windows.Forms.TextBox();
            this.lblRequestedBy = new System.Windows.Forms.Label();
            this.btnDeleteElement = new System.Windows.Forms.Button();
            this.btnAddElement = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.grdElementList = new System.Windows.Forms.DataGridView();
            this.btnClean = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBase = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdElementList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(459, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(307, 25);
            this.lblTitle.TabIndex = 27;
            this.lblTitle.Text = "Decomiso de Medicamentos";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(460, 92);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(129, 20);
            this.dtpDate.TabIndex = 45;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(62, 56);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(322, 20);
            this.txtCity.TabIndex = 43;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(406, 96);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(45, 13);
            this.lblDate.TabIndex = 42;
            this.lblDate.Text = "FECHA:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(8, 60);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(51, 13);
            this.lblCity.TabIndex = 41;
            this.lblCity.Text = "CIUDAD:";
            // 
            // txtRequestedBy
            // 
            this.txtRequestedBy.Location = new System.Drawing.Point(124, 92);
            this.txtRequestedBy.Name = "txtRequestedBy";
            this.txtRequestedBy.Size = new System.Drawing.Size(260, 20);
            this.txtRequestedBy.TabIndex = 47;
            // 
            // lblRequestedBy
            // 
            this.lblRequestedBy.AutoSize = true;
            this.lblRequestedBy.Location = new System.Drawing.Point(8, 96);
            this.lblRequestedBy.Name = "lblRequestedBy";
            this.lblRequestedBy.Size = new System.Drawing.Size(110, 13);
            this.lblRequestedBy.TabIndex = 46;
            this.lblRequestedBy.Text = "SOLICITADOS  POR:";
            // 
            // btnDeleteElement
            // 
            this.btnDeleteElement.Location = new System.Drawing.Point(882, 91);
            this.btnDeleteElement.Name = "btnDeleteElement";
            this.btnDeleteElement.Size = new System.Drawing.Size(117, 23);
            this.btnDeleteElement.TabIndex = 49;
            this.btnDeleteElement.Text = "Eliminar Elemento";
            this.btnDeleteElement.UseVisualStyleBackColor = true;
            this.btnDeleteElement.Click += new System.EventHandler(this.btnDeleteElement_Click);
            // 
            // btnAddElement
            // 
            this.btnAddElement.Location = new System.Drawing.Point(759, 91);
            this.btnAddElement.Name = "btnAddElement";
            this.btnAddElement.Size = new System.Drawing.Size(117, 22);
            this.btnAddElement.TabIndex = 48;
            this.btnAddElement.Text = "Agregar Elemento";
            this.btnAddElement.UseVisualStyleBackColor = true;
            this.btnAddElement.Click += new System.EventHandler(this.btnAddElement_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 513);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 50;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(1134, 513);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 51;
            this.btnQuit.Text = "Salir";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // grdElementList
            // 
            this.grdElementList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdElementList.Location = new System.Drawing.Point(12, 137);
            this.grdElementList.Name = "grdElementList";
            this.grdElementList.Size = new System.Drawing.Size(1196, 370);
            this.grdElementList.TabIndex = 52;
            this.grdElementList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdElementList_CellClick);
            this.grdElementList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdElementList_CellValueChanged);
            this.grdElementList.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.grdElementList_ColumnWidthChanged);
            this.grdElementList.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.grdElementList_DataError);
            this.grdElementList.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.grdElementList_EditingControlShowing);
            this.grdElementList.Scroll += new System.Windows.Forms.ScrollEventHandler(this.grdElementList_Scroll);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(1036, 513);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 53;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "BASE:";
            // 
            // cmbBase
            // 
            this.cmbBase.FormattingEnabled = true;
            this.cmbBase.Location = new System.Drawing.Point(457, 56);
            this.cmbBase.Name = "cmbBase";
            this.cmbBase.Size = new System.Drawing.Size(301, 21);
            this.cmbBase.TabIndex = 55;
            // 
            // FrmNewMedicineDestruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 548);
            this.Controls.Add(this.cmbBase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.grdElementList);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDeleteElement);
            this.Controls.Add(this.btnAddElement);
            this.Controls.Add(this.txtRequestedBy);
            this.Controls.Add(this.lblRequestedBy);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmNewMedicineDestruction";
            this.Text = "Decomiso de Medicamentos";
            this.Load += new System.EventHandler(this.FrmNewMedicineDestruction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdElementList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtRequestedBy;
        private System.Windows.Forms.Label lblRequestedBy;
        private System.Windows.Forms.Button btnDeleteElement;
        private System.Windows.Forms.Button btnAddElement;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.DataGridView grdElementList;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBase;
    }
}