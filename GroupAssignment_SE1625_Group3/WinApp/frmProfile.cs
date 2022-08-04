using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject.Models;
using DataAccess;

namespace WinApp
{
    public partial class frmProfile : Form
    {
        public IAccountRepository AccountRepository;
        public Account accountInfo { get; set; }
        public Account AccountLogin { get; set; }


        public bool IsUpdate = false;
        public frmProfile()
        {
            InitializeComponent();
            AccountRepository = new AccountRepository();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            IsUpdate = true;
            labelHeader.Text = "Update Profile";
            panelUpdateProfile.Visible = true;
            panelUpdateProfile.BringToFront();
            panelProfile.Visible = false;
            panelProfile.SendToBack();

            txtNameUpdate.Text = accountInfo.Name;
            txtPasswordUpdate.Text = accountInfo.Password;
            txtUsernameUpdate.Text = accountInfo.Username;
            cboGenderUpdate.Text = accountInfo.Gender ? "Male" : "Female";
            cboStatusUpdate.SelectedIndex = (int)accountInfo.Status - 1;
            cboRoleUpdate.SelectedIndex = (int)accountInfo.Role - 1;
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            try
            {
                if (AccountLogin.Role == 1 && AccountLogin.Role != accountInfo.Role)
                { // là admin nhưng không update chính tài khoàn cùa mình
                    txtUsernameUpdate.Enabled = false;
                    txtPasswordUpdate.Enabled = false;
                    txtConfirmUpdate.Enabled = false;
                    txtNameUpdate.Enabled = false;
                    cboGenderUpdate.Enabled = false;
                    cboStatusUpdate.Enabled = true;
                    cboRoleUpdate.Enabled = false;

                    panelUpdateProfile.Visible = true;
                    panelUpdateProfile.BringToFront();
                    panelProfile.Visible = false;
                    panelProfile.SendToBack();
                }
                else if (AccountLogin.Role == 1 && AccountLogin.Role == accountInfo.Role)
                { // là admin nhưng update tài khoàn của mình

                    panelProfile.Visible = true;
                    panelProfile.BringToFront();
                    panelUpdateProfile.Visible = false;
                    panelUpdateProfile.SendToBack();

                    txtUsernameUpdate.Enabled = true;
                    txtPasswordUpdate.Enabled = true;
                    txtConfirmUpdate.Enabled = true;
                    txtNameUpdate.Enabled = true;
                    cboGenderUpdate.Enabled = true;
                    cboRoleUpdate.Enabled = false;
                }
                else
                { //không là admin nhưng update tài khoản của mình
                    
                    panelProfile.BringToFront();
                    panelProfile.Visible = true;
                    panelUpdateProfile.SendToBack();
                    panelUpdateProfile.Visible = false;

                    txtUsernameUpdate.Enabled = true;
                    txtPasswordUpdate.Enabled = true;
                    txtConfirmUpdate.Enabled = true;
                    txtNameUpdate.Enabled = true;
                    cboGenderUpdate.Enabled = true;
                    cboRoleUpdate.Enabled = false;
                }

                txtPassword.Enabled = false;
                txtName.Enabled = false;
                txtUsername.Enabled = false;
                cboGender.Enabled = false;

                txtName.Text = accountInfo.Name;
                txtPassword.Text = accountInfo.Password;
                txtUsername.Text = accountInfo.Username;
                cboGender.Text = accountInfo.Gender ? "Male" : "Female";

                if (IsUpdate)
                {
                    labelHeader.Text = "Update your profile";
                }
                else
                {
                    labelHeader.Text = "Your profile";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCloseUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure close this update? ", "Close Update", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (ValidateUpdate())
                {
                    DialogResult result = MessageBox.Show("Are you sure to update? ", "Update", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Account account = new Account()
                        {
                            Name = txtNameUpdate.Text.Trim(),
                            Id = accountInfo.Id,
                            Password = txtPasswordUpdate.Text.Trim(),
                            Gender = cboGenderUpdate.Text.Trim() == "Male",
                            Status = cboStatusUpdate.Text.Trim() == "Active" ? 1
                                        : cboStatusUpdate.Text.Trim() == "Inactive" ? 2 : 0,
                            Role = cboRoleUpdate.Text.Trim() == "Admin" ? 1
                                        : cboRoleUpdate.Text.Trim() == "Staff" ? 2
                                        : cboRoleUpdate.Text.Trim() == "Doctor" ? 3 : 0,
                            Username = txtUsernameUpdate.Text.Trim(),

                        };

                        AccountRepository.UpdateAccount(account);
                        Application.Exit();
                        Application.Restart();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input", "Update profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.None;
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 

        }

        private bool ValidateUpdate()
        {
            bool flag = true;
            if(!(txtNameUpdate.Text.Trim().Length >= 8 && txtNameUpdate.Text.Trim().Length <= 50))
            {
                flag = false;
                labelNameError.Visible = true;
                labelNameError.Text = "Name must be from 8 to 50 characters.";
            }
            if(!(txtUsernameUpdate.Text.Trim().Length >= 8 && txtUsernameUpdate.Text.Trim().Length <= 50))
            {
                flag = false;
                labelUsernameError.Visible = true;
                labelUsernameError.Text = "Username must be from 8 to 50 characters.";
            }
            //password
            if(!(txtPasswordUpdate.Text.Trim().Length >= 8 && txtPasswordUpdate.Text.Trim().Length <= 50))
            {
                
                flag = false;
                labelPasswordError.Visible = true;
                labelPasswordError.Text = "Password must be from 8 to 50 characters.";
            } else if (txtPasswordUpdate.Text.Trim().Contains(" "))
            {
                flag = false;
                labelPasswordError.Visible = true;
                labelPasswordError.Text = "Password cannot contain whitespace.";
            }
            //cofirm
            if (!(txtConfirmUpdate.Text.Trim().Length >= 8 && txtConfirmUpdate.Text.Trim().Length <= 50))
            {
                flag = false;
                labelCofirmError.Visible = true;
                labelCofirmError.Text = "Confirm password must be from 8 to 50 characters.";
            } else
            {
                if(txtConfirmUpdate.Text.Trim() != txtPasswordUpdate.Text.Trim())
                {
                    flag = false;
                    labelCofirmError.Visible = true;
                    labelCofirmError.Text = "Confirm password must be the same with password.";
                }
            }

            //Gender
            if(!(cboGender.Text.Trim() == "Male" || cboGender.Text.Trim() == "Female"))
            {
                flag = false;
                labelGenderError.Visible = true;
                labelGenderError.Text = "Please choose gender.";
            }

            //Status 
            if (!(cboStatusUpdate.Text.Trim() == "Active" || cboStatusUpdate.Text.Trim() == "Inactive"))
            {
                flag = false;
                labelStatusError.Visible = true;
                labelStatusError.Text = "Please choose status account.";
            }

            //Role
            if (!(cboRoleUpdate.Text.Trim() == "Admin" || cboRoleUpdate.Text.Trim() == "Staff" || cboRoleUpdate.Text.Trim() == "Doctor"))
            {
                flag = false;
                labelRoleError.Visible = true;
                labelRoleError.Text = "Please choose status account.";
            }

            return flag;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Application.Restart();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
