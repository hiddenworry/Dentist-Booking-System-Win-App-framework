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
    public partial class frmCustomerDetailStaff : Form
    {
        public frmCustomerDetailStaff()
        {
            InitializeComponent();
        }
        public bool isInsert;

        public ICustomerRepository CustomerRepository { get; set; }

        public Customer CustomerInfo { get; set; }



        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCustomerName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            cbGender.Text = string.Empty;
            txtDateOfBirth.Text = string.Empty;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateAll())
                {
                    MessageBox.Show("Error input.", isInsert ? "Add new customer" : "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.None;
                    return;
                }
                DialogResult result = MessageBox.Show(isInsert ? "Sure to add customer" : "Sure to update customer", isInsert ? "Add customer" : "Update customer", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                
                if(result == DialogResult.No)
                {
                    DialogResult = DialogResult.No;
                    return;
                }
                string phone = txtPhone.Text.Trim();
                string tmp = "";
                for (int i = 0; i < phone.Length; i++)
                {
                    if ("0123456789".Contains(phone[i]))
                    {
                        tmp += phone[i];
                    }
                }

                Customer newCustomer = new Customer()
                {
                    Name = txtCustomerName.Text.Trim(),
                    Gender = cbGender.Text.Trim() == "Male",
                    Dob = DateTime.Parse(txtDateOfBirth.Text.Trim()),
                    Phone = tmp,
                };
                if (isInsert)
                {
                    CustomerRepository.AddNewCustomer(newCustomer);
                }
                else
                {
                    newCustomer.Id = CustomerInfo.Id;
                    CustomerRepository.UpdateCustomer(newCustomer);
                }

            }
            catch (Exception ex)
            {
                if(ex.Message == "Phone is already used")
                {
                    errorPhone.Text = "Phone is already used";
                    errorPhone.Visible = true;
                }
                MessageBox.Show(ex.Message, isInsert ? "Add customer" : "Update customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            if (isInsert)
            {
                txtPhone.Text = String.Empty;
                txtCustomerName.Text = String.Empty;
                txtDateOfBirth.Text = String.Empty;
                cbGender.Text = String.Empty;
            }
            else
            {
                txtCustomerID.Text = CustomerInfo.Id.ToString();
                txtPhone.Text = CustomerInfo.Phone;
                txtCustomerName.Text = CustomerInfo.Name;
                txtDateOfBirth.Text = CustomerInfo.Dob.ToString();
                cbGender.Text = CustomerInfo.Gender ? "Male" : "Female";
            }
        }

        private void frmCustomerDetailStaff_Load(object sender, EventArgs e)
        {
            if (isInsert)
            {
                txtPhone.Text = String.Empty;
                txtCustomerName.Text = String.Empty;
                txtDateOfBirth.Text = String.Empty;
                txtDateOfBirth.Text = String.Empty;
                btnSave.Text = "Add";
            }
            else
            {
                txtCustomerID.Text = CustomerInfo.Id.ToString();
                txtPhone.Text = CustomerInfo.Phone;
                txtCustomerName.Text = CustomerInfo.Name;
                txtDateOfBirth.Text = CustomerInfo.Dob.ToString("MM/dd/yyyy");
                cbGender.Text = CustomerInfo.Gender ? "Male" : "Female";
            }
        }

        private bool ValidateAll()
        {
            bool flag = true;
            if (txtCustomerName.Text.Length < 8 || txtCustomerName.Text.Length > 30)
            {
                flag = false;
                errorName.Text = "Length of name must be from 8 to 30 characters.";
                errorName.Visible = true;
            } else
            {
                errorName.Visible = false;
            }

            try
            {
                DateTime.Parse(txtDateOfBirth.Text);
                errorDateOfBirth.Visible = false;
            }
            catch
            {
                flag = false;
                errorDateOfBirth.Text = "Please choose date of birth.";
                errorDateOfBirth.Visible = true;
            }

            try
            {
                DateTime input = DateTime.Parse(txtDateOfBirth.Text);
                DateTime now = DateTime.Now;
               
                if( !(input.Year <= (now.Year - 4) && input.Year >= (now.Year - 120) ) )
                {
                    errorDateOfBirth.Text = "Please choose right date of birth.";
                    errorDateOfBirth.Visible = true;
                    flag = false;
                } else
                {
                    errorDateOfBirth.Visible = false;
                }
            }
            catch
            {
                flag = false;
                errorDateOfBirth.Text = "Please choose date of birth.";
                errorDateOfBirth.Visible = true;
            }

            string phone = txtPhone.Text.Trim();
            string tmp = "";
            for (int i = 0; i < phone.Length; i++)
            {
                if ("0123456789".Contains(phone[i]))
                {
                    tmp += phone[i];
                }
            }

            if(tmp.Length != 10)
            {
                errorPhone.Text = "Phone length must be 10 character";
                errorPhone.Visible = true;
            } else
            {
                errorPhone.Visible = false;
            }

            if(!(cbGender.Text == "Male" || cbGender.Text == "Female"))
            {
                errorGender.Text = "Please choose gender";
                errorGender.Visible = true;
            } else
            {
                errorGender.Visible = false;
            }

            return flag;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
                Close();
        }

        private void frmCustomerDetailStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult != DialogResult.OK)
            {
                DialogResult result = MessageBox.Show("Are you sure to quit ? All change will be delete.", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            
        }
    }
}
