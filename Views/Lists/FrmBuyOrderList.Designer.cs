namespace Views.Lists
{
    partial class FrmBuyOrderList
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
            this.grdBuyOrder = new System.Windows.Forms.DataGridView();
            this.btnQuit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdBuyOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Swis721 Hv BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(210, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(346, 25);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Ordenes de Compra Generadas";
            // 
            // grdBuyOrder
            // 
            this.grdBuyOrder.AllowUserToAddRows = false;
            this.grdBuyOrder.AllowUserToDeleteRows = false;
            this.grdBuyOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBuyOrder.Location = new System.Drawing.Point(12, 50);
            this.grdBuyOrder.Name = "grdBuyOrder";
            this.grdBuyOrder.ReadOnly = true;
            this.grdBuyOrder.Size = new System.Drawing.Size(776, 346);
            this.grdBuyOrder.TabIndex = 17;
            this.grdBuyOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBuyOrder_CellClick);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(713, 415);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 28;
            this.btnQuit.Text = "Salir";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // FrmBuyOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.grdBuyOrder);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmBuyOrderList";
            this.Text = "Ordenes de Compra";
            this.Load += new System.EventHandler(this.FrmBuyOrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBuyOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView grdBuyOrder;
        private System.Windows.Forms.Button btnQuit;
    }
}