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
    public partial class frmAppointmentDetailStaff : Form
    {
        public IAppointmentRepository appointmentRepository;
        public ICustomerRepository customerRepository;
        public IAppointmentServiceRepository appointmentServiceRepository;
        public IServiceRepository serviceRepository;
        public List<Service> detailList;
        public Appointment appointment;
        public bool InsertUpdateFlag;
        public BindingSource BindingSource;
        public frmAppointmentDetailStaff()
        {
            InitializeComponent();
            serviceRepository = new ServiceRepository();
            label5.Visible = false;
        }

        private void frmAppointmentDetailStaff_Load(object sender, EventArgs e)
        {
            comboBoxService.DataSource = serviceRepository.GetActiveServiceList();
            comboBoxService.DisplayMember = "Name";
            comboBoxService.ValueMember = "Id";
            if (InsertUpdateFlag)
            {
                dateTimePickerTime.MinDate = DateTime.Now.Date.AddDays(1);
                dateTimePickerTime.MaxDate = DateTime.Now.Date.AddDays(14);
                dateTimePickerTime.Value = DateTime.Now.Date.AddDays(1);
                LoadDetailList();
                buttonCancel.Visible = false;
            }
            else
            {
                if (appointment.Time >= DateTime.Now.Date.AddDays(1) && appointment.Status == 1) UpdateAble();
                else ViewOnly();
                ChangeTimeOptionList();
                dateTimePickerTime.Value = appointment.Time;
                comboBoxWorkingHour.SelectedIndex = comboBoxWorkingHour.Items.IndexOf(appointment.WorkingHour);
                textBoxPhone.Text = customerRepository.GetById(appointment.CustomerId).Phone;
                LoadDetailList();
            }
        }

        public void UpdateAble()
        {
            textBoxPhone.Enabled = false;
        }

        public void ViewOnly()
        {
            switch (appointment.Status)
            {
                case 1:
                    {
                        label5.Text = "This appointment is too late to update";
                        label5.Visible = true;
                        break;
                    }
                case 2:
                    {
                        label5.Text = "This appointment was done";
                        label5.Visible = true;
                        break;
                    }
                case 3:
                    {
                        label5.Text = "This appointment was cancelled";
                        label5.Visible = true;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            buttonDeleteService.Visible = false;
            buttonSave.Visible = false;
            dateTimePickerTime.Enabled = false;
            comboBoxService.Enabled = false;
            comboBoxWorkingHour.Enabled = false;
            textBoxPhone.Enabled = false;
            buttonCancel.Visible = false;
        }

        public void LoadDetailList()
        {
            BindingSource = new BindingSource();
            BindingSource.DataSource = detailList;
            dataGridViewDetail.DataSource = BindingSource;
            buttonDeleteService.Enabled = false;
            if (dataGridViewDetail.Columns["ServiceTypeId"] != null)
            {
                dataGridViewDetail.Columns["ServiceTypeId"].Visible = false;
            }
            if (dataGridViewDetail.Columns["AppointmentServices"] != null)
            {
                dataGridViewDetail.Columns["AppointmentServices"].Visible = false;
            }
            if (dataGridViewDetail.Columns["Status"] != null)
            {
                dataGridViewDetail.Columns["Status"].Visible = false;
            }
        }

        private void comboBoxService_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Service service = comboBoxService.SelectedItem as Service;
            if (detailList.Count >= 3) {
                MessageBox.Show("The maximum number of selected services is 3");
                return;
            } 
            foreach(Service tmp in detailList){
                if(tmp.Id == service.Id)
                {
                    MessageBox.Show("Service already choosed");
                    return;
                }
            }
            detailList.Add(service);
            LoadDetailList();
            ChangeTimeOptionList();
        }

        public void ChangeTimeOptionList()
        {
            comboBoxWorkingHour.Text = string.Empty;
            if (!(detailList != null && detailList.Count != 0))
            {
                BindingSource = new BindingSource();
                BindingSource.DataSource = new List<string>();
                comboBoxWorkingHour.DataSource = BindingSource;
                return;
            }
            BindingSource = new BindingSource();
            BindingSource.DataSource = appointmentRepository.GetTimeOptionByDate(dateTimePickerTime.Value, detailList, appointment);
            comboBoxWorkingHour.DataSource = BindingSource;
        }

        private void dataGridViewDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonDeleteService.Enabled = true;
        }

        private void dateTimePickerTime_ValueChanged(object sender, EventArgs e)
        {
            ChangeTimeOptionList();
        }

        private void buttonDeleteService_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewDetail.SelectedRows)
            {
                foreach (Service service in detailList)
                {
                    if (service.Id == int.Parse(row.Cells[0].Value.ToString()))
                    {
                        detailList.Remove(service);
                        break;
                    }
                }
            }
            LoadDetailList();
            ChangeTimeOptionList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer = customerRepository.CheckCustomerByPhone(textBoxPhone.Text);
            if (customer == null)
            {
                MessageBox.Show("Customer with this phone does not exist\nCreate a profile for this customer before create an appointment");
            }
            else
            {
                frmCustomerDetailStaff frmCustomerDetailStaff = new frmCustomerDetailStaff()
                {
                    CustomerRepository = customerRepository,
                    isInsert = false,
                    Text = "Update new Customer",
                    CustomerInfo = customer,
                };
                frmCustomerDetailStaff.ShowDialog();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(textBoxPhone.Text.Trim().Length != 10 || !int.TryParse(textBoxPhone.Text.Trim(), out _))
            {
                MessageBox.Show("Wrong phone format. Ex: 0123456789");
                return;
            }
            Customer customer = customerRepository.CheckCustomerByPhone(textBoxPhone.Text.Trim());
            if (customer == null)
            {
                MessageBox.Show("Customer with this phone does not exist\nCreate a profile for this customer before create an appointment");
                return;
            }
            if (!(detailList != null && detailList.Count != 0))
            {
                MessageBox.Show("Service list must not be empty");
                return;
            }
            if (!appointmentRepository.GetTimeOptionByDate(dateTimePickerTime.Value, detailList, this.appointment).Any(o => o.Equals(comboBoxWorkingHour.Text))) {
                MessageBox.Show("This working hour slot is not available now\nPlease reload form or comeback later");
                return;
            };



            
            if (InsertUpdateFlag)
            {
                Appointment existingAppointment = appointmentRepository.GetWaitingAppointmentByCustomerId(customer.Id);
                if (existingAppointment != null)
                {
                    MessageBox.Show("This customer already has a waiting appointment on " + existingAppointment.Time.Date.ToString().Split(" ")[0]);
                    return;
                }
                Appointment appointment = new Appointment
                {
                    CustomerId = customer.Id,
                    DentistId = appointmentRepository.GetGetSuitableDentistByDate(dateTimePickerTime.Value, detailList, comboBoxWorkingHour.Text, this.appointment),
                    Time = dateTimePickerTime.Value,
                    WorkingHour = comboBoxWorkingHour.Text,
                    Status = 1
                };
                int id = appointmentRepository.AddAppointment(appointment).Id;
                foreach (Service service in detailList)
                {
                    appointmentServiceRepository.AddAppointmentService(new AppointmentService
                    {
                        AppointmentId = id,
                        ServiceId = service.Id
                    });
                }
                MessageBox.Show("Added successfully", "Add appointment");
            }
            else
            {
                Appointment appointment = new Appointment
                {
                    Id = this.appointment.Id,
                    CustomerId = customer.Id,
                    DentistId = appointmentRepository.GetGetSuitableDentistByDate(dateTimePickerTime.Value, detailList, comboBoxWorkingHour.Text, this.appointment),
                    Time = dateTimePickerTime.Value,
                    WorkingHour = comboBoxWorkingHour.Text,
                    Status = 1
                };
                appointmentRepository.UpdateAppointment(appointment);
                appointmentServiceRepository.DeleteAppointmentServiceByAppointmentId(appointment.Id);
                foreach (Service service in detailList)
                {
                    appointmentServiceRepository.AddAppointmentService(new AppointmentService
                    {
                        AppointmentId = appointment.Id,
                        ServiceId = service.Id
                    });
                }
                MessageBox.Show("Updated successfully", "Update appointment");
            }
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                d = MessageBox.Show("Sure to cancel this appointment?", "Cancel appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    appointment.Status = 3;
                    appointmentRepository.UpdateAppointment(appointment);
                    MessageBox.Show("Cancelled successfully", "Cancel appointment");
                    Close();
                    DialogResult = DialogResult.OK;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cancel appointment error");
            }
        }
    }
}
