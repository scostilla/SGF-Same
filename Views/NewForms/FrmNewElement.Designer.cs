namespace Views.NewForms
{
    partial class FrmNewElement
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbPresentation = new System.Windows.Forms.ComboBox();
            this.txtConcentration = new System.Windows.Forms.TextBox();
            this.txtElementName = new System.Windows.Forms.TextBox();
            this.lblConcentration = new System.Windows.Forms.Label();
            this.lblPresentation = new System.Windows.Forms.Label();
            this.lblElementName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtUse = new System.Windows.Forms.TextBox();
            this.lblUse = new System.Windows.Forms.Label();
            this.lblObservations = new System.Windows.Forms.Label();
            this.txtObservations = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(313, 312);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "Salir";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(232, 312);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 312);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbPresentation
            // 
            this.cmbPresentation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPresentation.FormattingEnabled = true;
            this.cmbPresentation.Location = new System.Drawing.Point(158, 113);
            this.cmbPresentation.Name = "cmbPresentation";
            this.cmbPresentation.Size = new System.Drawing.Size(153, 21);
            this.cmbPresentation.TabIndex = 1;
            // 
            // txtConcentration
            // 
            this.txtConcentration.Location = new System.Drawing.Point(158, 149);
            this.txtConcentration.Name = "txtConcentration";
            this.txtConcentration.Size = new System.Drawing.Size(153, 20);
            this.txtConcentration.TabIndex = 2;
            // 
            // txtElementName
            // 
            this.txtElementName.Location = new System.Drawing.Point(158, 78);
            this.txtElementName.Name = "txtElementName";
            this.txtElementName.Size = new System.Drawing.Size(153, 20);
            this.txtElementName.TabIndex = 0;
            // 
            // lblConcentration
            // 
            this.lblConcentration.AutoSize = true;
            this.lblConcentration.Location = new System.Drawing.Point(76, 152);
            this.lblConcentration.Name = "lblConcentration";
            this.lblConcentration.Size = new System.Drawing.Size(76, 13);
            this.lblConcentration.TabIndex = 13;
            this.lblConcentration.Text = "Concentracion";
            // 
            // lblPresentation
            // 
            this.lblPresentation.AutoSize = true;
            this.lblPresentation.Location = new System.Drawing.Point(83, 116);
            this.lblPresentation.Name = "lblPresentation";
            this.lblPresentation.Size = new System.Drawing.Size(69, 13);
            this.lblPresentation.TabIndex = 11;
            this.lblPresentation.Text = "Presentacion";
            // 
            // lblElementName
            // 
            this.lblElementName.AutoSize = true;
            this.lblElementName.Location = new System.Drawing.Point(108, 81);
            this.lblElementName.Name = "lblElementName";
            this.lblElementName.Size = new System.Drawing.Size(44, 13);
            this.lblElementName.TabIndex = 9;
            this.lblElementName.Text = "Nombre";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Swis721 Hv BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(94, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(184, 25);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Nuevo Elemento";
            // 
            // txtUse
            // 
            this.txtUse.Location = new System.Drawing.Point(158, 184);
            this.txtUse.Name = "txtUse";
            this.txtUse.Size = new System.Drawing.Size(153, 20);
            this.txtUse.TabIndex = 3;
            // 
            // lblUse
            // 
            this.lblUse.AutoSize = true;
            this.lblUse.Location = new System.Drawing.Point(126, 187);
            this.lblUse.Name = "lblUse";
            this.lblUse.Size = new System.Drawing.Size(26, 13);
            this.lblUse.TabIndex = 17;
            this.lblUse.Text = "Uso";
            // 
            // lblObservations
            // 
            this.lblObservations.AutoSize = true;
            this.lblObservations.Location = new System.Drawing.Point(74, 222);
            this.lblObservations.Name = "lblObservations";
            this.lblObservations.Size = new System.Drawing.Size(78, 13);
            this.lblObservations.TabIndex = 18;
            this.lblObservations.Text = "Observaciones";
            // 
            // txtObservations
            // 
            this.txtObservations.Location = new System.Drawing.Point(158, 219);
            this.txtObservations.Multiline = true;
            this.txtObservations.Name = "txtObservations";
            this.txtObservations.Size = new System.Drawing.Size(230, 77);
            this.txtObservations.TabIndex = 4;
            // 
            // FrmNewElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 347);
            this.Controls.Add(this.txtObservations);
            this.Controls.Add(this.lblObservations);
            this.Controls.Add(this.txtUse);
            this.Controls.Add(this.lblUse);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbPresentation);
            this.Controls.Add(this.txtConcentration);
            this.Controls.Add(this.txtElementName);
            this.Controls.Add(this.lblConcentration);
            this.Controls.Add(this.lblPresentation);
            this.Controls.Add(this.lblElementName);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmNewElement";
            this.Text = "Nuevo Elemento";
            this.Load += new System.EventHandler(this.FrmNewElement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbPresentation;
        private System.Windows.Forms.TextBox txtConcentration;
        private System.Windows.Forms.TextBox txtElementName;
        private System.Windows.Forms.Label lblConcentration;
        private System.Windows.Forms.Label lblPresentation;
        private System.Windows.Forms.Label lblElementName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtUse;
        private System.Windows.Forms.Label lblUse;
        private System.Windows.Forms.Label lblObservations;
        private System.Windows.Forms.TextBox txtObservations;
    }
}