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

namespace Views.NewForms
{
    public partial class FrmNewUser : Form
    {
        Boolean Update;
        
        String sql,errorMsg,SuccessMsg, sqlFormattedDate;
        AuxiliarUser auxiliarUser = new AuxiliarUser();

        public FrmNewUser(Boolean updated)
        {
            InitializeComponent();
            Update = updated;
            
        }

        public FrmNewUser(AuxiliarUser auxiliarUser)
        {
            this.auxiliarUser = auxiliarUser;
            InitializeComponent();
        }

        DBConexion con = new DBConexion();

        private void FrmNewUser_Load(object sender, EventArgs e)
        {
            if (User.UserRole != "1")
            {
                chkActiveUser.Visible = false;
            }
            else
            {
                chkActiveUser.Visible = true;
            }
            if (auxiliarUser.Id > 0)
            {
                txtUserName.Text = auxiliarUser.UserName;
                txtUserName.Enabled = false;
                txtName.Text = auxiliarUser.Name;
                txtLastName.Text = auxiliarUser.LastName;
                txtPass.Text = txtRePass.Text = "";
                txtPass.Enabled = false;
                txtRePass.Enabled = false;
                cmbRole.DataSource = con.consultSortTable("userRole", "id_userRole");
                cmbRole.DisplayMember = "description";
                cmbRole.ValueMember = "id_userRole";
                cmbRole.SelectedValue = auxiliarUser.UserRole;
                lblTitle.Text = User.LastName + ", " + User.Name;
                chkActiveUser.Checked = Convert.ToBoolean(auxiliarUser.ActiveUser);
            }
            else
            {
                if (Update)
                {
                    txtUserName.Text = User.UserName;
                    txtUserName.Enabled = false;
                    txtName.Text = User.Name;
                    txtLastName.Text = User.LastName;
                    txtPass.Text = txtRePass.Text = User.Pass;
                    cmbRole.Visible = false;
                    lblRole.Visible = false;
                    lblTitle.Text = User.LastName + ", " + User.Name;
                    chkActiveUser.Checked = Convert.ToBoolean(User.ActiveUser);
                }
                else
                {
                    lblTitle.Text = "Nuevo Usuario";
                    cmbRole.DataSource = con.consultSortTable("userRole", "id_userRole");
                    cmbRole.DisplayMember = "description";
                    cmbRole.ValueMember = "id_userRole";
                    chkActiveUser.Checked = true;
                }
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cleanForm();
        }

        public void cleanForm()
        {
            auxiliarUser = new AuxiliarUser();
            if (User.UserRole != "1")
            {
                this.Dispose();
            }
            else
            {
                txtUserName.Text = String.Empty;
                txtName.Text = String.Empty;
                txtLastName.Text = String.Empty;
                txtPass.Text = String.Empty;
                txtRePass.Text = String.Empty;
                txtUserName.Enabled = true;
                chkActiveUser.Visible = true;
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (con.consultuser(txtUserName.Text))
            {
                MessageBox.Show("Nombre de Usuaro No disponible","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Text = String.Empty;
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sql = String.Empty;
            sqlFormattedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");

            if (auxiliarUser.Id > 0)
            {
                if ((txtUserName.Text == String.Empty) || (txtName.Text == String.Empty) || (txtLastName.Text == String.Empty))
                {
                    MessageBox.Show("Faltan campos por llenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    FrmPassVerification frmPassVerification = new FrmPassVerification();
                    frmPassVerification.ShowDialog();

                    if (frmPassVerification.DialogResult == DialogResult.OK)
                    {
                        sql = "UPDATE users SET userName= '" + txtUserName.Text + "', name= '" + txtName.Text + "', lastName= '" + txtLastName.Text + "', activeUser= '" + chkActiveUser.Checked + "',update_date= '"+ sqlFormattedDate +"', id_updater= "+User.Id+" where id_user= " + auxiliarUser.Id;
                        errorMsg = "Error al intentar modificar el usuario";
                        SuccessMsg = "Usuario modificado correctamente";

                    }
                }

            }
            else
            {
                if ((txtUserName.Text == String.Empty) || (txtName.Text == String.Empty) || (txtLastName.Text == String.Empty) || (txtPass.Text == String.Empty) || (txtRePass.Text == String.Empty))
                {
                    MessageBox.Show("Faltan campos por llenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtPass.Text != txtRePass.Text)
                    {
                        MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtRePass.Text = String.Empty;
                        txtPass.Text = String.Empty;
                    }
                    else
                    {
                        if (!Update)
                        {
                            sql = "INSERT INTO users (userName,pass,name,lastName,userRole,activeUser,creation_date,id_creator) VALUES('" + txtUserName.Text + "',ENCRYPTBYPASSPHRASE('SQL SERVER 2008', '" + txtPass.Text + "'),'" + txtName.Text + "','" + txtLastName.Text + "','" + cmbRole.SelectedValue + "','" + chkActiveUser.Checked + "','"+sqlFormattedDate+"',"+User.Id+")";
                            errorMsg = "Error al agregar el nuevo usuario";
                            SuccessMsg = "Usuario agregado correctamente";
                        }
                        else
                        {
                            FrmPassVerification frmPassVerification = new FrmPassVerification();
                            frmPassVerification.ShowDialog();

                            if (frmPassVerification.DialogResult == DialogResult.OK)
                            {
                                sql = "UPDATE users SET userName= '" + txtUserName.Text + "', name= '" + txtName.Text + "', lastName= '" + txtLastName.Text + "', activeUser= '" + chkActiveUser.Checked + "', pass= ENCRYPTBYPASSPHRASE('SQL SERVER 2008', '" + txtPass.Text + "')" + ",update_date= '" + sqlFormattedDate + "', id_updater= " + User.Id + " where id_user= " + User.Id;
                                errorMsg = "Error al intentar modificar el usuario";
                                SuccessMsg = "Usuario modificado correctamente";
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                }
            }

            if (con.insert(sql))
            {
                MessageBox.Show(SuccessMsg);

                if (Update)
                {
                    User.UserName = txtUserName.Text;
                    User.Name = txtName.Text;
                    User.LastName = txtLastName.Text;
                    User.Pass = txtPass.Text;
                    this.DialogResult = DialogResult.OK;
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Dispose();
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text.Length < 6)
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
