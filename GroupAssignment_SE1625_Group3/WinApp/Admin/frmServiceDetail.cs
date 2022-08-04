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
    public partial class frmServiceDetail : Form
    {
        IServiceTypeRepository ServiceTypeRepository = new ServiceTypeRepository();
        public IServiceRepository ServiceRepository { get; set; }

        public Service serviceData { get; set; }

        public bool Insert { get; set; }
        public frmServiceDetail()
        {
            InitializeComponent();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Service service = LoadData();
                if (validate(service))
                {
                    if (Insert)
                    {
                        if(ServiceRepository.GetServiceByName(service.Name) != null)
                        {
                            MessageBox.Show("Service's name is already used");
                            return;
                        }
                        DialogResult result = MessageBox.Show("Sure to add this service?", "Add service", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (result.Equals(DialogResult.OK))
                        {
                            ServiceRepository.SaveService(service);
                            this.DialogResult = DialogResult.OK;
                            this.Close();

                        }

                    }
                    else
                    {
                        if (ServiceRepository.GetServiceByName(service.Name) != null)
                        {
                            if (ServiceRepository.GetServiceByName(service.Name).Id != service.Id)
                            {
                                MessageBox.Show("Service's name is already used");
                                return;
                            }
                            
                        }
                        DialogResult result = MessageBox.Show("Sure to update this service?", "Update service", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (result.Equals(DialogResult.OK))
                        {
                            ServiceRepository.UpdateService(service);
                            this.DialogResult = DialogResult.OK;
                            this.Close();


                        }

                    }
                }
                
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           


        }

        private Service LoadData()
        {
            Service service = new Service();
            if (!Insert)
            {
                service.Id = int.Parse(txtServiceID.Text);
            }
            service.Name = txtServiceName.Text;
            service.Status = Int32.Parse(cbStatus.SelectedValue.ToString());
            service.EstimatedTime = float.Parse(cbEstimatedTime.Text);
            service.ServiceTypeId = Int32.Parse(cbServiceType.SelectedValue.ToString());
            service.Description = txtDescription.Text;
            return service;

        }

        private void frmServiceDetail_Load(object sender, EventArgs e)
        {
            try
            {

                var StatusDictionary = new Dictionary<int, string>();
                StatusDictionary.Add(1, "Active");
                StatusDictionary.Add(2, "Inactive");

                cbStatus.DataSource = StatusDictionary.ToList();
                cbStatus.DisplayMember = "Value";
                cbStatus.ValueMember = "Key";
                // load service type
                cbServiceType.DataSource = ServiceTypeRepository.GetServiceTypeList();
                cbServiceType.DisplayMember = "name";
                cbServiceType.ValueMember = "id";

                txtServiceID.Enabled = false;

                if (Insert)
                {
                    lbServiceDetailID.Visible = false;
                    txtServiceID.Visible = false;
                    Reset();

                }
                else
                {
                    txtServiceID.Text = serviceData.Id.ToString();
                    txtServiceName.Text = serviceData.Name.ToString();
                    cbStatus.Text = serviceData.Status.ToString();
                    cbServiceType.Text = serviceData.ServiceTypeId.ToString();
                    cbEstimatedTime.Text = serviceData.EstimatedTime.ToString();
                    txtDescription.Text = serviceData.Description;
                }
            } catch(Exception ex) { }
            

        }
        private void Reset()
        {
            txtServiceName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            cbEstimatedTime.SelectedIndex = 1;
            cbServiceType.SelectedIndex = 0;
            cbStatus.SelectedIndex = 1;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validate(Service service)
        {
            bool check = true;
            string error = "";
            if(string.IsNullOrEmpty(service.Name) || service.Name.Length < 8 || service.Name.Length > 30)
             
            {
                check = false;
                error += "Servcie Name must be from 8 to 30 character\n";

            }
            if (string.IsNullOrEmpty(service.Description) || service.Description.Length < 8)
            {
                check = false;
                error += "Servcie description must be from 8 character\n";

            }
            if(!check)
                MessageBox.Show(error);
            return check;

        }
    }
}
