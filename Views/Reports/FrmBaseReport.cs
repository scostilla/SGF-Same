using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.Reports
{
    public partial class FrmBaseReport : Form
    {
        public FrmBaseReport()
        {
            InitializeComponent();
        }

        private void FrmBaseReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sameDataSet._base' table. You can move, or remove it, as needed.
            this.baseTableAdapter.Fill(this.sameDataSet._base);

            this.reportViewer1.RefreshReport();
        }
    }
}
