namespace Views.NewForms
{
    partial class FrmNewCart
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
            this.grdBuyOrder = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblDestiny = new System.Windows.Forms.Label();
            this.lblToUseIn = new System.Windows.Forms.Label();
            this.lblRequestedBy = new System.Windows.Forms.Label();
            this.lblRequestDate = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtDestiny = new System.Windows.Forms.TextBox();
            this.txtToUseIn = new System.Windows.Forms.TextBox();
            this.txtRequestedBy = new System.Windows.Forms.TextBox();
            this.dtpRequestedDate = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdBuyOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // grdBuyOrder
            // 
            this.grdBuyOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBuyOrder.Location = new System.Drawing.Point(12, 195);
            this.grdBuyOrder.Name = "grdBuyOrder";
            this.grdBuyOrder.Size = new System.Drawing.Size(568, 341);
            this.grdBuyOrder.TabIndex = 0;
            this.grdBuyOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBuyOrder_CellClick);
            this.grdBuyOrder.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.grdBuyOrder_EditingControlShowing);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(451, 124);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 22);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Agregar Elemento";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(171, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(197, 25);
            this.lblTitle.TabIndex = 26;
            this.lblTitle.Text = "Orden de Compra";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(492, 542);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 27;
            this.btnQuit.Text = "Salir";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(20, 542);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(106, 23);
            this.btnGenerate.TabIndex = 28;
            this.btnGenerate.Text = "Generar O.C.";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(355, 542);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(109, 23);
            this.btnClean.TabIndex = 29;
            this.btnClean.Text = "Limpiar Listado";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(12, 60);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(47, 13);
            this.lblCity.TabIndex = 30;
            this.lblCity.Text = "LUGAR:";
            // 
            // lblDestiny
            // 
            this.lblDestiny.AutoSize = true;
            this.lblDestiny.Location = new System.Drawing.Point(12, 97);
            this.lblDestiny.Name = "lblDestiny";
            this.lblDestiny.Size = new System.Drawing.Size(154, 13);
            this.lblDestiny.TabIndex = 31;
            this.lblDestiny.Text = "ARTICULOS DESTINADOS A:";
            // 
            // lblToUseIn
            // 
            this.lblToUseIn.AutoSize = true;
            this.lblToUseIn.Location = new System.Drawing.Point(12, 130);
            this.lblToUseIn.Name = "lblToUseIn";
            this.lblToUseIn.Size = new System.Drawing.Size(112, 13);
            this.lblToUseIn.TabIndex = 32;
            this.lblToUseIn.Text = "PARA UTILIZAR EN: ";
            // 
            // lblRequestedBy
            // 
            this.lblRequestedBy.AutoSize = true;
            this.lblRequestedBy.Location = new System.Drawing.Point(12, 164);
            this.lblRequestedBy.Name = "lblRequestedBy";
            this.lblRequestedBy.Size = new System.Drawing.Size(110, 13);
            this.lblRequestedBy.TabIndex = 33;
            this.lblRequestedBy.Text = "SOLICITADOS  POR:";
            // 
            // lblRequestDate
            // 
            this.lblRequestDate.AutoSize = true;
            this.lblRequestDate.Location = new System.Drawing.Point(397, 60);
            this.lblRequestDate.Name = "lblRequestDate";
            this.lblRequestDate.Size = new System.Drawing.Size(45, 13);
            this.lblRequestDate.TabIndex = 34;
            this.lblRequestDate.Text = "FECHA:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(66, 56);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(322, 20);
            this.txtCity.TabIndex = 35;
            // 
            // txtDestiny
            // 
            this.txtDestiny.Location = new System.Drawing.Point(172, 93);
            this.txtDestiny.Name = "txtDestiny";
            this.txtDestiny.Size = new System.Drawing.Size(216, 20);
            this.txtDestiny.TabIndex = 36;
            // 
            // txtToUseIn
            // 
            this.txtToUseIn.Location = new System.Drawing.Point(130, 126);
            this.txtToUseIn.Name = "txtToUseIn";
            this.txtToUseIn.Size = new System.Drawing.Size(258, 20);
            this.txtToUseIn.TabIndex = 37;
            // 
            // txtRequestedBy
            // 
            this.txtRequestedBy.Location = new System.Drawing.Point(128, 160);
            this.txtRequestedBy.Name = "txtRequestedBy";
            this.txtRequestedBy.Size = new System.Drawing.Size(260, 20);
            this.txtRequestedBy.TabIndex = 38;
            // 
            // dtpRequestedDate
            // 
            this.dtpRequestedDate.Location = new System.Drawing.Point(451, 56);
            this.dtpRequestedDate.Name = "dtpRequestedDate";
            this.dtpRequestedDate.Size = new System.Drawing.Size(129, 20);
            this.dtpRequestedDate.TabIndex = 39;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(451, 157);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 23);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Eliminar Elemento";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmNewCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 572);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dtpRequestedDate);
            this.Controls.Add(this.txtRequestedBy);
            this.Controls.Add(this.txtToUseIn);
            this.Controls.Add(this.txtDestiny);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblRequestDate);
            this.Controls.Add(this.lblRequestedBy);
            this.Controls.Add(this.lblToUseIn);
            this.Controls.Add(this.lblDestiny);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grdBuyOrder);
            this.Name = "FrmNewCart";
            this.Text = "Orden de Compra";
            this.Load += new System.EventHandler(this.FrmNewCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBuyOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdBuyOrder;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblDestiny;
        private System.Windows.Forms.Label lblToUseIn;
        private System.Windows.Forms.Label lblRequestedBy;
        private System.Windows.Forms.Label lblRequestDate;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtDestiny;
        private System.Windows.Forms.TextBox txtToUseIn;
        private System.Windows.Forms.TextBox txtRequestedBy;
        private System.Windows.Forms.DateTimePicker dtpRequestedDate;
        private System.Windows.Forms.Button btnDelete;
    }
}