namespace Views.NewForms
{
    partial class FrmNewChangeOfMedicine
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
            this.dtpRequestedDate = new System.Windows.Forms.DateTimePicker();
            this.txtDestiny = new System.Windows.Forms.TextBox();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblRequestDate = new System.Windows.Forms.Label();
            this.lblDestiny = new System.Windows.Forms.Label();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtObservatios = new System.Windows.Forms.TextBox();
            this.lblObservations = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.grdElementList = new System.Windows.Forms.DataGridView();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDeleteElement = new System.Windows.Forms.Button();
            this.btnAddElement = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdElementList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(390, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(254, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "CAMBIO DE MEDICINA";
            // 
            // dtpRequestedDate
            // 
            this.dtpRequestedDate.Location = new System.Drawing.Point(117, 124);
            this.dtpRequestedDate.Name = "dtpRequestedDate";
            this.dtpRequestedDate.Size = new System.Drawing.Size(129, 20);
            this.dtpRequestedDate.TabIndex = 47;
            // 
            // txtDestiny
            // 
            this.txtDestiny.Location = new System.Drawing.Point(117, 98);
            this.txtDestiny.Name = "txtDestiny";
            this.txtDestiny.Size = new System.Drawing.Size(322, 20);
            this.txtDestiny.TabIndex = 46;
            // 
            // txtResponsable
            // 
            this.txtResponsable.Location = new System.Drawing.Point(117, 72);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(322, 20);
            this.txtResponsable.TabIndex = 45;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(117, 48);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(322, 20);
            this.txtCity.TabIndex = 44;
            // 
            // lblRequestDate
            // 
            this.lblRequestDate.AutoSize = true;
            this.lblRequestDate.Location = new System.Drawing.Point(64, 124);
            this.lblRequestDate.Name = "lblRequestDate";
            this.lblRequestDate.Size = new System.Drawing.Size(45, 13);
            this.lblRequestDate.TabIndex = 43;
            this.lblRequestDate.Text = "FECHA:";
            // 
            // lblDestiny
            // 
            this.lblDestiny.AutoSize = true;
            this.lblDestiny.Location = new System.Drawing.Point(51, 101);
            this.lblDestiny.Name = "lblDestiny";
            this.lblDestiny.Size = new System.Drawing.Size(58, 13);
            this.lblDestiny.TabIndex = 42;
            this.lblDestiny.Text = "DESTINO:";
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(20, 76);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(89, 13);
            this.lblResponsable.TabIndex = 41;
            this.lblResponsable.Text = "RESPONSABLE:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(62, 51);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(47, 13);
            this.lblCity.TabIndex = 40;
            this.lblCity.Text = "LUGAR:";
            // 
            // txtObservatios
            // 
            this.txtObservatios.Location = new System.Drawing.Point(445, 48);
            this.txtObservatios.Multiline = true;
            this.txtObservatios.Name = "txtObservatios";
            this.txtObservatios.Size = new System.Drawing.Size(621, 96);
            this.txtObservatios.TabIndex = 49;
            // 
            // lblObservations
            // 
            this.lblObservations.AutoSize = true;
            this.lblObservations.Location = new System.Drawing.Point(705, 32);
            this.lblObservations.Name = "lblObservations";
            this.lblObservations.Size = new System.Drawing.Size(101, 13);
            this.lblObservations.TabIndex = 48;
            this.lblObservations.Text = "OBSERVACIONES:";
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(1026, 514);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 59;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // grdElementList
            // 
            this.grdElementList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdElementList.Location = new System.Drawing.Point(7, 161);
            this.grdElementList.Name = "grdElementList";
            this.grdElementList.Size = new System.Drawing.Size(1196, 347);
            this.grdElementList.TabIndex = 58;
            this.grdElementList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdElementList_CellClick);
            this.grdElementList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdElementList_CellValueChanged);
            this.grdElementList.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.grdElementList_EditingControlShowing);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(1129, 514);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 57;
            this.btnQuit.Text = "Salir";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 514);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 56;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDeleteElement
            // 
            this.btnDeleteElement.Location = new System.Drawing.Point(1087, 99);
            this.btnDeleteElement.Name = "btnDeleteElement";
            this.btnDeleteElement.Size = new System.Drawing.Size(117, 23);
            this.btnDeleteElement.TabIndex = 55;
            this.btnDeleteElement.Text = "Eliminar Elemento";
            this.btnDeleteElement.UseVisualStyleBackColor = true;
            this.btnDeleteElement.Click += new System.EventHandler(this.btnDeleteElement_Click);
            // 
            // btnAddElement
            // 
            this.btnAddElement.Location = new System.Drawing.Point(1087, 67);
            this.btnAddElement.Name = "btnAddElement";
            this.btnAddElement.Size = new System.Drawing.Size(117, 22);
            this.btnAddElement.TabIndex = 54;
            this.btnAddElement.Text = "Agregar Elemento";
            this.btnAddElement.UseVisualStyleBackColor = true;
            this.btnAddElement.Click += new System.EventHandler(this.btnAddElement_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(922, 514);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 60;
            this.btnCancel.Text = "Anular";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FrmNewChangeOfMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 549);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.grdElementList);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDeleteElement);
            this.Controls.Add(this.btnAddElement);
            this.Controls.Add(this.txtObservatios);
            this.Controls.Add(this.lblObservations);
            this.Controls.Add(this.dtpRequestedDate);
            this.Controls.Add(this.txtDestiny);
            this.Controls.Add(this.txtResponsable);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblRequestDate);
            this.Controls.Add(this.lblDestiny);
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmNewChangeOfMedicine";
            this.Text = "Cambio de Medicina";
            this.Load += new System.EventHandler(this.FrmNewChangeOfMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdElementList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker dtpRequestedDate;
        private System.Windows.Forms.TextBox txtDestiny;
        private System.Windows.Forms.TextBox txtResponsable;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblRequestDate;
        private System.Windows.Forms.Label lblDestiny;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtObservatios;
        private System.Windows.Forms.Label lblObservations;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.DataGridView grdElementList;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDeleteElement;
        private System.Windows.Forms.Button btnAddElement;
        private System.Windows.Forms.Button btnCancel;
    }
}