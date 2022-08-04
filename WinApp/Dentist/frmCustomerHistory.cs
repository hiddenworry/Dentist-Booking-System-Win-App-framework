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

namespace WinApp.Dentist
{
    public partial class frmCustomerHistory : Form
    {
        public Customer customerInfo { get; set; }
        public ICustomerRepository CustomerRepository { get; set; }
        public IAppointmentRepository AppointmentRepository { get; set; }
        public IServiceRepository ServiceRepository { get; set; }
        public IAccountRepository AccountRepository { get; set; }
        BindingSource source;
        public frmCustomerHistory()
        {
            InitializeComponent();
            AccountRepository = new AccountRepository();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panelCustomer_Paint(object sender, PaintEventArgs e)
        {
            LoadCustomer();
            LoadListAppointmentHistory(AppointmentRepository.Get10FistappointmentDoneCustomerById(customerInfo.Id));
            dataGridViewCustomer.BackgroundColor = Color.White;
            dataGridViewCustomer.RowHeadersVisible = false;
        }

        public void LoadCustomer()
        {
            txtName.Text = customerInfo.Name;
            txtDateOfBirth.Text = customerInfo.Dob.ToString("dd/MM/yyyy");
            txtGender.Text = customerInfo.Gender ? "Male" : "Female";
            txtPhone.Text = customerInfo.Phone;
        }

        public void LoadListAppointmentHistory(List<Appointment> list)
        {
            try
            {
                List<AppointmentHistory> historyList = new List<AppointmentHistory>();

                foreach (Appointment history in list)
                {
                    AppointmentHistory tmp = new AppointmentHistory()
                    {
                        IdHistory = history.Id,
                        Time = history.Time,
                        WorkingHour = history.WorkingHour,
                        DotorName = AccountRepository.GetAccountById(history.DentistId).Name,
                        Description = history.Description,
                    };
                    historyList.Add(tmp);
                }


                source = new BindingSource();
                source.DataSource = historyList;

                dataGridViewCustomer.DataSource = null;
                dataGridViewCustomer.DataSource = source;

                if(list.Count > 0)
                {
                    LoadListServicesInAppointment(ServiceRepository.GetServiceListByAppointmentId(list[0].Id));
                }

                txtDescription.DataBindings.Clear();
                txtDescription.DataBindings.Add("Text", source, "Description");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load list appointment history", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1) return;
                int id = int.Parse(dataGridViewCustomer.Rows[e.RowIndex].Cells["IdHistory"].FormattedValue.ToString());
                LoadListServicesInAppointment(ServiceRepository.GetServiceListByAppointmentId(id));
                txtDescription.Text = dataGridViewCustomer.Rows[e.RowIndex].Cells["Description"].FormattedValue.ToString();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Load service", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }

        }

        private void LoadListServicesInAppointment(List<Service> list)
        {
            try
            {
                source = new BindingSource();
                source.DataSource = list;
                dgvListService.DataSource = null;
                dgvListService.DataSource = source;

                foreach (DataGridViewColumn column in dgvListService.Columns)
                {
                    if (column.Name != "Name")
                    {
                        column.Visible = false;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load list service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex == -1) return;
                int id = int.Parse(dataGridViewCustomer.Rows[e.RowIndex].Cells["IdHistory"].FormattedValue.ToString());
                LoadListServicesInAppointment(ServiceRepository.GetServiceListByAppointmentId(id));
                txtDescription.Text = dataGridViewCustomer.Rows[e.RowIndex].Cells["Description"].FormattedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCustomerHistory_Load(object sender, EventArgs e)
        {

        }
    }
}

public class AppointmentHistory
{
    public int IdHistory { get; set; }
    public DateTime Time { get; set; }
    public string DotorName { get; set; }

    public string WorkingHour { get; set; }

    public string Description { get; set; }
}
