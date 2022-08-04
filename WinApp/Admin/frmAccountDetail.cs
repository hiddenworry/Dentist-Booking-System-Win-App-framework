using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class frmAccountDetail : Form
    {
        public IAccountRepository AccountRepository { get; set; }

        public bool Insert { get; set; }

        public Account accountData { get; set; }
        public frmAccountDetail()
        {
            InitializeComponent();
        }


     

        private void frmDentistDetail_Load(object sender, EventArgs e)
        {
            try
            {
                txtDentistPassword.UseSystemPasswordChar = true;
                txtCofirmPassword.UseSystemPasswordChar = true;
               

                var GenderDictionary = new Dictionary<bool, string>();
                GenderDictionary.Add(true, "Male");
                GenderDictionary.Add(false, "Female");
                cbDentistGender.DataSource = GenderDictionary.ToList();
                cbDentistGender.DisplayMember = "Value";
                cbDentistGender.ValueMember = "Key";


                var StatusDictionary = new Dictionary<decimal, string>();
                StatusDictionary.Add(1, "Active");
                StatusDictionary.Add(2, "Inactive");
                cbStatus.DataSource = StatusDictionary.ToArray();
                cbStatus.DisplayMember = "Value";
                cbStatus.ValueMember = "Key";


                var RoleDictionary = new Dictionary<int, string>();
                RoleDictionary.Add(2, "Staff");
                RoleDictionary.Add(3, "Doctor");
                cbRole.DataSource = RoleDictionary.ToList();
                cbRole.DisplayMember = "Value";
                cbRole.ValueMember = "Key";

                if (Insert)
                {
                    txtDentistID.Visible = false;
                    txtDentistID.Enabled = false;
                    lbID.Visible = false;
                }
                else
                {
                    lbID.Visible = true;
                    txtDentistID.Visible = true;
                    txtDentistID.Enabled = false;

                    lbID.Visible = true;
                    txtDentistID.Text = accountData.Id.ToString();
                    txtDentistName.Text = accountData.Name.ToString();
                    txtDentistLoginName.Text = accountData.Username.ToString();
                    txtDentistPassword.Text = accountData.Password.ToString();
                    cbDentistGender.SelectedValue = accountData.Gender;
                    cbStatus.SelectedValue = accountData.Status;
                    
                    cbRole.SelectedValue = accountData.Role;
                    cbRole.DataSource = RoleDictionary.ToList();
                    cbRole.Enabled = false;
                    txtCofirmPassword.Text = txtDentistPassword.Text;



                }
            } catch(Exception ex) { }
        }
        private Account LoadData()
        {
            try
            {
                Account account = new Account();

                account.Name = txtDentistName.Text;
                account.Username = txtDentistLoginName.Text;
                account.Password = txtDentistPassword.Text;

                account.Status = decimal.Parse(cbStatus.SelectedValue.ToString());
                account.Gender = Boolean.Parse(cbDentistGender.SelectedValue.ToString());
                account.Role = decimal.Parse(cbRole.SelectedValue.ToString());


                if (Insert == false)
                {
                    account.Id = Int32.Parse(txtDentistID.Text);
                    

                }
                return account;
            } catch(Exception ex) { };
            return null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                if (Validate())
                {
                    Account Dentist = LoadData();

                    if (Insert == true)
                    {
                        DialogResult result = MessageBox.Show("Sure to add this account?", "Add account", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            AccountRepository.AddAccount(Dentist);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    if (Insert == false)
                    {
                        DialogResult result = MessageBox.Show("Sure to update this account?", "Update Account", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            AccountRepository.UpdateAccount(Dentist);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
               
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }
        }

        private bool Validate()
        {
            bool check = true;
            string error = "";
            if (string.IsNullOrEmpty(txtDentistName.Text)||txtDentistName.TextLength < 8 || txtDentistName.TextLength > 30)
            {
                error += "Dentist name must be from 8 to 30 character\n";
                check = false;
            }
            if (string.IsNullOrEmpty(txtDentistLoginName.Text) || txtDentistLoginName.TextLength < 8 || txtDentistLoginName.TextLength > 30)
            {
                error += "Dentist Login name must be from 8 to 30 character\n";
                check = false;
            }
            if (string.IsNullOrEmpty(txtDentistPassword.Text) || txtDentistPassword.TextLength < 8 || txtDentistPassword.TextLength > 30)
            {
                error += "Dentist password must be from 8 to 30 character\n";
                check = false;
            }
            if (!txtDentistPassword.Text.Equals(txtCofirmPassword.Text))
            {
                error += "Password is not match\n";
                check = false;
            }
            if (string.IsNullOrEmpty(cbRole.Text))
            {
                error += "Role not valid";
                check = false;
            }
            if (txtDentistLoginName.Text.Contains(" "))
            {
                error += "Login name do not allow contain whitespace\n";
                check = false;
            }
            if (txtDentistPassword.Text.Contains(" "))
            {
                error += "Password do not allow contain whitespace\n";
                check = false;
            }
            if (!check)
            {
                MessageBox.Show(error);
            }
            
            return check;




        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(checkShowPassword.Checked == true)
            {
                txtDentistPassword.UseSystemPasswordChar = false;
                
            }
            else
            {
                txtDentistPassword.UseSystemPasswordChar = true;
            }
        }

        private void checkShowConfirmPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowConfirmPassword.Checked == true)
            {
                txtCofirmPassword.UseSystemPasswordChar = false;

            }
            else
            {
                txtCofirmPassword.UseSystemPasswordChar = true;
            }
        }
    }


}
