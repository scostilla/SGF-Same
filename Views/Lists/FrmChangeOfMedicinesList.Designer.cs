namespace Views.Lists
{
    partial class FrmChangeOfMedicinesList
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grdMedicineDestruction = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdMedicineDestruction)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(161, 456);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 35;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(23, 456);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(132, 23);
            this.btnReport.TabIndex = 34;
            this.btnReport.Text = "Generar Reporte";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(777, 456);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 33;
            this.btnQuit.Text = "Salir";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(334, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(263, 25);
            this.lblTitle.TabIndex = 32;
            this.lblTitle.Text = "Cambios de Medicacion";
            // 
            // grdMedicineDestruction
            // 
            this.grdMedicineDestruction.AllowUserToAddRows = false;
            this.grdMedicineDestruction.AllowUserToDeleteRows = false;
            this.grdMedicineDestruction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMedicineDestruction.Location = new System.Drawing.Point(14, 47);
            this.grdMedicineDestruction.Name = "grdMedicineDestruction";
            this.grdMedicineDestruction.ReadOnly = true;
            this.grdMedicineDestruction.Size = new System.Drawing.Size(838, 386);
            this.grdMedicineDestruction.TabIndex = 31;
            this.grdMedicineDestruction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMedicineDestruction_CellClick);
            // 
            // FrmChangeOfMedicinesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 489);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grdMedicineDestruction);
            this.Name = "FrmChangeOfMedicinesList";
            this.Text = "Cambios de Medicina";
            this.Load += new System.EventHandler(this.FrmChangeOfMedicinesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMedicineDestruction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView grdMedicineDestruction;
    }
}