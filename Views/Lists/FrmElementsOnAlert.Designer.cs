namespace Views.Lists
{
    partial class FrmElementsOnAlert
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
            this.grdAlertList = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNewCart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdAlertList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(166, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(353, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Elementos con valores en Alerta";
            // 
            // grdAlertList
            // 
            this.grdAlertList.AllowUserToAddRows = false;
            this.grdAlertList.AllowUserToDeleteRows = false;
            this.grdAlertList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAlertList.Location = new System.Drawing.Point(12, 46);
            this.grdAlertList.Name = "grdAlertList";
            this.grdAlertList.ReadOnly = true;
            this.grdAlertList.Size = new System.Drawing.Size(660, 307);
            this.grdAlertList.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(597, 359);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNewCart
            // 
            this.btnNewCart.Location = new System.Drawing.Point(12, 359);
            this.btnNewCart.Name = "btnNewCart";
            this.btnNewCart.Size = new System.Drawing.Size(88, 23);
            this.btnNewCart.TabIndex = 3;
            this.btnNewCart.Text = "Generar O.C.";
            this.btnNewCart.UseVisualStyleBackColor = true;
            this.btnNewCart.Click += new System.EventHandler(this.btnNewCart_Click);
            // 
            // FrmElementsOnAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 392);
            this.Controls.Add(this.btnNewCart);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grdAlertList);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmElementsOnAlert";
            this.Text = "Elementos en Alerta";
            ((System.ComponentModel.ISupportInitialize)(this.grdAlertList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView grdAlertList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNewCart;
    }
}