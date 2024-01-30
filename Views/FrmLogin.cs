using ClassLibrary;
using Squirrel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Views
{
    public partial class FrmLogin : Form
    {
        DBConexion con = new DBConexion();
        FileVersionInfo versionInfo;

        public FrmLogin()
        {
            InitializeComponent();
            addVersionNumber();
            checkForUpdates();
        }

        private void addVersionNumber()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            
            lblConnectionString.Text = DBConnectionString.DBName;
            cleanTitle();

        }
        private async Task checkForUpdates()
        {
            using (var manager= new UpdateManager(@"C:\Dropbox\S.G. Same"))
            {
                await manager.UpdateApp();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text=="" || txtPass.Text == "")
            {
                MessageBox.Show("Faltan datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cleanTitle();
            }
            else
            {
                switch (cmbDataBase.SelectedItem)
                {
                    case "Same Central":
                        DBConnectionString.ConnectionString = @"Data Source=SRVSAMERADIORDP\SQLSAME;Initial Catalog=Same;Integrated Security=False;User ID=SaSame;Password=SebaSame123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        DBConnectionString.DBName = "Same Central";
                        this.Text += $" - Central";
                        break;
                    case "VIR":
                        DBConnectionString.ConnectionString = @"Data Source=SRVSAMERADIORDP\SQLSAME;Initial Catalog=VIR;Integrated Security=False;User ID=SaSame;Password=SebaSame123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        DBConnectionString.DBName = "Local";
                        break;
                    case "Punta Corral":
                        DBConnectionString.ConnectionString = @"Data Source=SRVSAMERADIORDP\SQLSAME;Initial Catalog=SamePuntaCorral;Integrated Security=False;User ID=SaSame;Password=SebaSame123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        DBConnectionString.DBName = "Punta Corral";
                        this.Text += $" - Punta Corral";
                        break;
                    case "LocalHost":
                        DBConnectionString.ConnectionString = @"Data Source=SCOSTILLA\SQLEXPRESS;Initial Catalog=same;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        DBConnectionString.DBName = "Local";
                        break;
                    
                    default:
                        MessageBox.Show("Debe seleccionar alguna Base de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                }
                con.getConnectionString(DBConnectionString.ConnectionString);

                int userId = con.selectUser(txtUserName.Text, txtPass.Text);
                if (userId != -1)
                {
                    if (User.ActiveUser == "False")
                    {
                        MessageBox.Show("Usuario inactivo, comuniquese con el administrador del sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DialogResult = DialogResult.Abort;
                        cleanTitle();
                    }
                    else
                    {
                        con.getWarehouseId();
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Text = "";
                    txtPass.Text = "";
                    cleanTitle();
                }
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                this.SelectNextControl((System.Windows.Forms.Control)sender, true, true, true, true);
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnLogin_Click(sender, e);
            }
        }

        private void cmbDataBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = String.Empty;
            this.Text = $"SG SAME 107 - V.{versionInfo.FileVersion}";

            switch (cmbDataBase.SelectedItem)
            {
                case "Same Central":
                    this.Text += $" - Same Central";
                    break;
                case "VIR":
                    this.Text += $" - VIR";
                    break;
                case "Punta Corral":
                    this.Text += $" - Punta Corral";
                    break;
                case "LocalHost":
                    this.Text += $" - LocalHost";
                    break;
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text == "admin" || txtUserName.Text == "nuevo")
            {
                cmbDataBase.Items.Add("LocalHost");
                cmbDataBase.SelectedIndex = 3;
            }
            else
            {
                cmbDataBase.Items.Remove("LocalHost");
                cmbDataBase.SelectedIndex = 0;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            cmbDataBase.Items.Add("Same Central");
            cmbDataBase.Items.Add("VIR");
            cmbDataBase.Items.Add("Punta Corral");
            cmbDataBase.SelectedIndex = 0;
            cleanTitle();
            DBConnectionString.VersionNumber = $"{ versionInfo.FileVersion}";
            this.Text += DBConnectionString.VersionNumber + " - Same Central";
        }

        private void cleanTitle()
        {
            this.Text = String.Empty;
            this.Text = $"SG SAME 107 - V."+ DBConnectionString.VersionNumber;
        }
    }
}
