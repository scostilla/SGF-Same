using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace Views
{
    public partial class FrmPassVerification : Form
    {
        String message;
        public FrmPassVerification()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == User.Pass)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta","Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Text = String.Empty;
            }

        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnSubmit_Click(sender, e);
            }
        }
    }
}
