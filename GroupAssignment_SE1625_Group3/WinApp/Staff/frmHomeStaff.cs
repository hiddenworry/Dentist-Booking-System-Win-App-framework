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
using WinApp;
using DataAccess;
namespace WinApp
{
    public partial class frmHomeStaff : Form
    {
        List<Panel> panelList = new List<Panel>();
        public Account accountLogin { get; set; }

        ICustomerRepository customerRepository;
        IAppointmentRepository appointmentRepository;
        IAccountRepository accountRepository;
        IAppointmentServiceRepository appointmentServiceRepository;
        IServiceRepository serviceRepository;
        BindingSource source;
        BindingSource sourceAppointment;

        private static Customer customer;
        public frmHomeStaff()
        {
            InitializeComponent();
            customerRepository = new CustomerRepository();
            appointmentRepository = new AppointmentRepository();
            accountRepository = new AccountRepository();
            appointmentServiceRepository = new AppointmentServiceRepository();
            serviceRepository = new ServiceRepository();
        }

        private void LoadListCustomer(List<Customer> list)
        {
            List<CustomerChange> changeList = new List<CustomerChange>();

            foreach (Customer customer in list)
            {
                CustomerChange change = new CustomerChange()
                {
                    Id = customer.Id,
                    Name = customer.Name,
                    Phone = customer.Phone,
                    Gender = customer.Gender ? "Male" : "Female",
                    Dob = customer.Dob,
                };
                changeList.Add(change);
            }
            source = new BindingSource();
            source.DataSource = changeList;
            dataGridViewCustomer.DataSource = source;
            if (list.Count() != 0)
            {
                customer = list[0];
            }
            else
            {
                customer = null;
                buttonCustomerUpdate.Enabled = false;
            }

            if (dataGridViewCustomer.Columns["Appointments"] != null)
            {
                dataGridViewCustomer.Columns["Appointments"].Visible = false;
            }
            if (dataGridViewCustomer.Columns["Id"] != null)
            {
                dataGridViewCustomer.Columns["Id"].Visible = false;
            }

            if (dataGridViewCustomer.Columns["Dob"] != null)
            {
                dataGridViewCustomer.Columns["Dob"].HeaderText = "Date of birth";
            }

        }

        private void buttonAppointment_Click(object sender, EventArgs e)
        {
            panelCustomer.SendToBack();
            panelAppointment.BringToFront();
            buttonAppointment.BackColor = Color.LightBlue;
            buttonCustomer.BackColor = Color.Lavender;
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            panelCustomer.BringToFront();
            panelAppointment.SendToBack();
            buttonAppointment.BackColor = Color.Lavender;
            buttonCustomer.BackColor = Color.LightBlue;
            LoadListCustomer(customerRepository.GetAll());
        }

        private void buttonService_Click(object sender, EventArgs e)
        {
            panelAppointment.SendToBack();
            panelCustomer.SendToBack();
            buttonAppointment.BackColor = Color.Lavender;
            buttonCustomer.BackColor = Color.Lavender;
        }

        private void buttonDentist_Click(object sender, EventArgs e)
        {
            panelAppointment.SendToBack();
            panelCustomer.SendToBack();
            buttonAppointment.BackColor = Color.Lavender;
            buttonCustomer.BackColor = Color.Lavender;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            panelAppointment.BringToFront();
            LoadAppointmentList();
            LoadListCustomer(customerRepository.GetAll());
            List<Account> dentistList = new List<Account>();
            dentistList.Add(new Account
            {
                Id = 0,
                Name = "All"
            });
            txtLinkLabelNameAccountLogin.Text = accountLogin.Name;
            dentistList.AddRange(accountRepository.GetALLDentistList());
            comboBoxAppointmentDentist.DataSource = dentistList;
            comboBoxAppointmentDentist.DisplayMember = "Name";
            comboBoxAppointmentDentist.ValueMember = "Id";
            comboBoxStatus.SelectedIndex = 0;
        }

        private void buttonFindAppointment_Click(object sender, EventArgs e)
        {
            LoadAppointmentList();
        }

        public void LoadAppointmentList()
        {
            buttonAppointmentUpdate.Enabled = false;
            int status;
            switch (comboBoxStatus.Text)
            {
                case "All":
                    {
                        status = 0;
                        break;
                    }
                case "Waiting":
                    {
                        status = 1;
                        break;
                    }
                case "Done":
                    {
                        status = 2;
                        break;
                    }
                case "Cancel":
                    {
                        status = 3;
                        break;
                    }
                default:
                    {
                        status = 0;
                        break;
                    }
            }
            Account dentist = comboBoxAppointmentDentist.SelectedItem as Account;
            int dentistId = dentist != null ? dentist.Id : 0;
            dataGridViewAppointment.DataSource = appointmentRepository.GetAppointmentList(dateTimePickerAppointmentDate.Value, textBoxAppointmentPhone.Text, dentistId, status);
            if (dataGridViewAppointment.Columns["CustomerId"] != null)
            {
                dataGridViewAppointment.Columns["CustomerId"].Visible = false;
            }
            if (dataGridViewAppointment.Columns["DentistId"] != null)
            {
                dataGridViewAppointment.Columns["DentistId"].Visible = false;
            }
            if (dataGridViewAppointment.Columns["AppointmentServices"] != null)
            {
                dataGridViewAppointment.Columns["AppointmentServices"].Visible = false;
            }
            if (dataGridViewAppointment.Columns["Status"] != null)
            {
                dataGridViewAppointment.Columns["Status"].Visible = false;
            }
        }

        private void buttonAppointmentAdd_Click(object sender, EventArgs e)
        {
            frmAppointmentDetailStaff frmAppointmentDetailstaff = new frmAppointmentDetailStaff
            {
                appointmentRepository = appointmentRepository,
                customerRepository = customerRepository,
                appointmentServiceRepository = appointmentServiceRepository,
                serviceRepository = serviceRepository,
                InsertUpdateFlag = true,
                detailList = new List<Service>()
            };
            if (frmAppointmentDetailstaff.ShowDialog() == DialogResult.OK)
            {
                LoadAppointmentList();
            }
        }

        private void buttonAppointmentUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridViewAppointment.SelectedRows[0].Cells[0].Value.ToString());
            Appointment appointment = appointmentRepository.GetAppointmentById(id);
            frmAppointmentDetailStaff frmAppointmentDetailstaff = new frmAppointmentDetailStaff
            {
                appointmentRepository = appointmentRepository,
                customerRepository = customerRepository,
                appointment = appointment,
                appointmentServiceRepository = appointmentServiceRepository,
                InsertUpdateFlag = false,
                serviceRepository = serviceRepository,
                detailList = serviceRepository.GetServiceListByAppointmentId(id),
            };
            if (frmAppointmentDetailstaff.ShowDialog() == DialogResult.OK)
            {
                LoadAppointmentList();
            }
        }
        private void buttonCustomerAdd_Click(object sender, EventArgs e)
        {
            frmCustomerDetailStaff frmCustomerDetailStaff = new frmCustomerDetailStaff()
            {
                CustomerRepository = customerRepository,
                isInsert = true,
                Text = "Add new Customer",
            };
            if (frmCustomerDetailStaff.ShowDialog() == DialogResult.OK)
            {
                LoadListCustomer(customerRepository.GetAll());
            }
        }

        private void buttonCustomerUpdate_Click(object sender, EventArgs e)
        {
            if (customerRepository != null)
            {
                frmCustomerDetailStaff frmCustomerDetailStaff = new frmCustomerDetailStaff()
                {
                    CustomerRepository = customerRepository,
                    isInsert = false,
                    Text = "Update new Customer",
                    CustomerInfo = customer,
                };
                if (frmCustomerDetailStaff.ShowDialog() == DialogResult.OK)
                {
                    LoadListCustomer(customerRepository.GetAll());
                }
            }
        }

        private void buttonCustomerFind_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxCustomerName.Text.Trim();
                string phone = textBoxCustomerPhone.Text.Trim();
                if (name.Length != 0 && phone.Length != 0)
                {
                    LoadListCustomer(customerRepository.SearchCustomerByNameAndPhone(name, phone));
                }
                else
                {
                    if (phone.Length != 0)
                    {
                        LoadListCustomer(customerRepository.SearchCustomerByPhone(phone));

                    }
                    else if (name.Length != 0)
                    {
                        LoadListCustomer(customerRepository.SearchCustomerByName(name));
                    }
                    else
                    {
                        LoadListCustomer(customerRepository.GetAll());
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtLinkLabelNameAccountLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmProfile frmProfile = new frmProfile()
            {
                accountInfo = accountLogin,
                AccountLogin = accountLogin,
            };
            frmProfile.ShowDialog();
        }


        private void dataGridViewCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = int.Parse(dataGridViewCustomer.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString());

                if (id != 0)
                {
                    customer = customerRepository.GetById(id);
                }
                else
                {
                    customer = null;
                }

                if (customer == null) { buttonCustomerUpdate.Enabled = false; return; }
                else { buttonCustomerUpdate.Enabled = true; }
                buttonCustomerUpdate_Click(sender, e);
            }
            catch (Exception ex)
            {
            }
        }

        private void dataGridViewAppointment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewAppointment.SelectedRows.Count != 0)
                buttonAppointmentUpdate.Enabled = true; }
        private void dataGridViewCustomer_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = int.Parse(dataGridViewCustomer.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString());

                if (id != 0)
                {
                    customer = customerRepository.GetById(id);
                }
                else
                {
                    customer = null;
                }

                if (customer == null) buttonCustomerUpdate.Enabled = false;
                else { buttonCustomerUpdate.Enabled = true; }
            }
            catch (Exception ex)
            {
            }
        }

        private void dataGridViewCustomer_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = int.Parse(dataGridViewCustomer.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString());
                if (id != 0)
                {
                    customer = customerRepository.GetById(id);
                }
                else
                {
                    customer = null;
                }

                if (customer == null) buttonCustomerUpdate.Enabled = false;
                else { buttonCustomerUpdate.Enabled = true; }
            }
            catch (Exception ex)
            {
            }
        }
    }
}

public class CustomerChange
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Gender { get; set; }
    public DateTime Dob { get; set; }
}
