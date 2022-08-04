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
namespace WinApp
{
    public partial class frmAppointmentDetailDentist : Form
    {
        public AppointmentChange appointmentChange { get; set; }
        public Appointment Appointment { get; set; }    

        public List<Service> listServiccInAppointment { get; set; }

        BindingSource source;
        public frmAppointmentDetailDentist()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            if (appointmentChange.StatusId == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to pick this appointment \n " +
                                                                         "Customer name: " + appointmentChange.CustomerName + "\n" +
                                                                         "Working hour: " + appointmentChange.WorkingHour,
                                                                         "Confirm pick appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    DialogResult = DialogResult.Yes;
                }
            }
            this.Close();
        }

        private void frmAppointmentDetailDoctor_Load(object sender, EventArgs e)
        {
            this.Text = "View";
            txtName.Text = appointmentChange.CustomerName;
            txtStatus.Text = appointmentChange.Status;
            
            LoadListServicesInAppointment(listServiccInAppointment);

            txtWorkingHour.Text = appointmentChange.WorkingHour;
            txtDescription.Text = Appointment.Description;
            txtPhone.Text = appointmentChange.Phone;
            if (appointmentChange.StatusId == 3 || appointmentChange.StatusId == 2)
            {
                btnCheck.Text = "OK";

            }
            else
            {
                btnCheck.Text = "Pick appointment";
            }
        }


        private void LoadListServicesInAppointment(List<Service> list)
        {
            try
            {
                source = new BindingSource();
                source.DataSource = list;
                dgvService.DataSource = null;
                dgvService.DataSource = source;

                foreach (DataGridViewColumn column in dgvService.Columns)
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
    }
}
