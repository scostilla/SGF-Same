namespace Views.Lists
{
    partial class FrmAuthorizationsList
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
            this.btnQuit = new System.Windows.Forms.Button();
            this.grdBuyOrder = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdBuyOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(906, 415);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 34;
            this.btnQuit.Text = "Salir";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // grdBuyOrder
            // 
            this.grdBuyOrder.AllowUserToAddRows = false;
            this.grdBuyOrder.AllowUserToDeleteRows = false;
            this.grdBuyOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBuyOrder.Location = new System.Drawing.Point(12, 57);
            this.grdBuyOrder.Name = "grdBuyOrder";
            this.grdBuyOrder.ReadOnly = true;
            this.grdBuyOrder.Size = new System.Drawing.Size(988, 346);
            this.grdBuyOrder.TabIndex = 33;
            this.grdBuyOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBuyOrder_CellClick);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(361, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(285, 25);
            this.lblTitle.TabIndex = 32;
            this.lblTitle.Text = "Autorizaciones Revisadas";
            // 
            // FrmAuthorizationsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 450);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.grdBuyOrder);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmAuthorizationsList";
            this.Text = "Autorizaciones";
            this.Load += new System.EventHandler(this.FrmAuthorizationsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBuyOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.DataGridView grdBuyOrder;
        private System.Windows.Forms.Label lblTitle;
    }
}