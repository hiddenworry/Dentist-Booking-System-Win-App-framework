namespace WinApp
{
    partial class frmHomeDentist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelAppointment = new System.Windows.Forms.Panel();
            this.labelAppointment = new System.Windows.Forms.Label();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.buttonFindAppointment = new System.Windows.Forms.Button();
            this.textBoxAppointmentPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.dataGridViewAppointment = new System.Windows.Forms.DataGridView();
            this.panelUpdateAppointment = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCheckAbsent = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnViewHistoryCustomer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.Label();
            this.txtLinkLabelNameAccountLogin = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.panelAppointment.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointment)).BeginInit();
            this.panelUpdateAppointment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAppointment
            // 
            this.panelAppointment.BackColor = System.Drawing.Color.LightBlue;
            this.panelAppointment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAppointment.Controls.Add(this.labelAppointment);
            this.panelAppointment.Controls.Add(this.groupBoxFilter);
            this.panelAppointment.Controls.Add(this.dataGridViewAppointment);
            this.panelAppointment.Location = new System.Drawing.Point(12, 47);
            this.panelAppointment.Name = "panelAppointment";
            this.panelAppointment.Size = new System.Drawing.Size(775, 450);
            this.panelAppointment.TabIndex = 16;
            // 
            // labelAppointment
            // 
            this.labelAppointment.AutoSize = true;
            this.labelAppointment.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAppointment.Location = new System.Drawing.Point(85, 59);
            this.labelAppointment.Name = "labelAppointment";
            this.labelAppointment.Size = new System.Drawing.Size(248, 37);
            this.labelAppointment.TabIndex = 12;
            this.labelAppointment.Text = "List Appointment ";
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.buttonFindAppointment);
            this.groupBoxFilter.Controls.Add(this.textBoxAppointmentPhone);
            this.groupBoxFilter.Controls.Add(this.labelPhone);
            this.groupBoxFilter.Location = new System.Drawing.Point(508, 38);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(225, 140);
            this.groupBoxFilter.TabIndex = 11;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filter";
            // 
            // buttonFindAppointment
            // 
            this.buttonFindAppointment.Location = new System.Drawing.Point(81, 80);
            this.buttonFindAppointment.Name = "buttonFindAppointment";
            this.buttonFindAppointment.Size = new System.Drawing.Size(127, 29);
            this.buttonFindAppointment.TabIndex = 10;
            this.buttonFindAppointment.Text = "Find";
            this.buttonFindAppointment.UseVisualStyleBackColor = true;
            this.buttonFindAppointment.Click += new System.EventHandler(this.buttonFindAppointment_Click);
            // 
            // textBoxAppointmentPhone
            // 
            this.textBoxAppointmentPhone.Location = new System.Drawing.Point(81, 47);
            this.textBoxAppointmentPhone.Name = "textBoxAppointmentPhone";
            this.textBoxAppointmentPhone.Size = new System.Drawing.Size(127, 27);
            this.textBoxAppointmentPhone.TabIndex = 6;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(10, 52);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(50, 20);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "Phone";
            // 
            // dataGridViewAppointment
            // 
            this.dataGridViewAppointment.AllowUserToAddRows = false;
            this.dataGridViewAppointment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAppointment.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointment.Location = new System.Drawing.Point(3, 205);
            this.dataGridViewAppointment.Name = "dataGridViewAppointment";
            this.dataGridViewAppointment.ReadOnly = true;
            this.dataGridViewAppointment.RowHeadersWidth = 51;
            this.dataGridViewAppointment.RowTemplate.Height = 29;
            this.dataGridViewAppointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAppointment.Size = new System.Drawing.Size(767, 240);
            this.dataGridViewAppointment.TabIndex = 7;
            this.dataGridViewAppointment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAppointment_CellContentClick);
            this.dataGridViewAppointment.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAppointment_CellDoubleClick);
            // 
            // panelUpdateAppointment
            // 
            this.panelUpdateAppointment.BackColor = System.Drawing.Color.LightBlue;
            this.panelUpdateAppointment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUpdateAppointment.Controls.Add(this.btnBack);
            this.panelUpdateAppointment.Controls.Add(this.btnCheckAbsent);
            this.panelUpdateAppointment.Controls.Add(this.label7);
            this.panelUpdateAppointment.Controls.Add(this.dgvService);
            this.panelUpdateAppointment.Controls.Add(this.txtPhone);
            this.panelUpdateAppointment.Controls.Add(this.btnViewHistoryCustomer);
            this.panelUpdateAppointment.Controls.Add(this.label6);
            this.panelUpdateAppointment.Controls.Add(this.label5);
            this.panelUpdateAppointment.Controls.Add(this.txtDateOfBirth);
            this.panelUpdateAppointment.Controls.Add(this.label2);
            this.panelUpdateAppointment.Controls.Add(this.label4);
            this.panelUpdateAppointment.Controls.Add(this.txtDescription);
            this.panelUpdateAppointment.Controls.Add(this.txtGender);
            this.panelUpdateAppointment.Controls.Add(this.label3);
            this.panelUpdateAppointment.Controls.Add(this.label1);
            this.panelUpdateAppointment.Controls.Add(this.txtCustomerName);
            this.panelUpdateAppointment.Controls.Add(this.btnFinish);
            this.panelUpdateAppointment.Controls.Add(this.Name);
            this.panelUpdateAppointment.Location = new System.Drawing.Point(12, 47);
            this.panelUpdateAppointment.Name = "panelUpdateAppointment";
            this.panelUpdateAppointment.Size = new System.Drawing.Size(775, 450);
            this.panelUpdateAppointment.TabIndex = 17;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(164, 402);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(131, 29);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCheckAbsent
            // 
            this.btnCheckAbsent.Location = new System.Drawing.Point(472, 402);
            this.btnCheckAbsent.Name = "btnCheckAbsent";
            this.btnCheckAbsent.Size = new System.Drawing.Size(131, 29);
            this.btnCheckAbsent.TabIndex = 27;
            this.btnCheckAbsent.Text = "Check Absent";
            this.btnCheckAbsent.UseVisualStyleBackColor = true;
            this.btnCheckAbsent.Click += new System.EventHandler(this.btnCheckAbsent_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(388, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Phone";
            // 
            // dgvService
            // 
            this.dgvService.AllowUserToAddRows = false;
            this.dgvService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvService.BackgroundColor = System.Drawing.Color.White;
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService.ColumnHeadersVisible = false;
            this.dgvService.Location = new System.Drawing.Point(11, 243);
            this.dgvService.Name = "dgvService";
            this.dgvService.RowHeadersVisible = false;
            this.dgvService.RowHeadersWidth = 51;
            this.dgvService.RowTemplate.Height = 29;
            this.dgvService.Size = new System.Drawing.Size(370, 150);
            this.dgvService.TabIndex = 17;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.Enabled = false;
            this.txtPhone.ForeColor = System.Drawing.Color.Transparent;
            this.txtPhone.Location = new System.Drawing.Point(472, 107);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(224, 27);
            this.txtPhone.TabIndex = 23;
            // 
            // btnViewHistoryCustomer
            // 
            this.btnViewHistoryCustomer.Location = new System.Drawing.Point(313, 168);
            this.btnViewHistoryCustomer.Name = "btnViewHistoryCustomer";
            this.btnViewHistoryCustomer.Size = new System.Drawing.Size(139, 29);
            this.btnViewHistoryCustomer.TabIndex = 16;
            this.btnViewHistoryCustomer.Text = "View history";
            this.btnViewHistoryCustomer.UseVisualStyleBackColor = true;
            this.btnViewHistoryCustomer.Click += new System.EventHandler(this.btnViewHistoryCustomer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Description";
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.BackColor = System.Drawing.Color.White;
            this.txtDateOfBirth.Enabled = false;
            this.txtDateOfBirth.ForeColor = System.Drawing.Color.Transparent;
            this.txtDateOfBirth.Location = new System.Drawing.Point(472, 61);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Size = new System.Drawing.Size(224, 27);
            this.txtDateOfBirth.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Services";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Date Of Birth";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(392, 243);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(370, 150);
            this.txtDescription.TabIndex = 13;
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.Color.White;
            this.txtGender.Enabled = false;
            this.txtGender.ForeColor = System.Drawing.Color.Transparent;
            this.txtGender.Location = new System.Drawing.Point(109, 111);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(224, 27);
            this.txtGender.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Gender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Update Appointment";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.White;
            this.txtCustomerName.Enabled = false;
            this.txtCustomerName.ForeColor = System.Drawing.Color.Transparent;
            this.txtCustomerName.Location = new System.Drawing.Point(109, 65);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(224, 27);
            this.txtCustomerName.TabIndex = 26;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(313, 402);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(139, 29);
            this.btnFinish.TabIndex = 9;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(18, 68);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(49, 20);
            this.Name.TabIndex = 22;
            this.Name.Text = "Name";
            // 
            // txtLinkLabelNameAccountLogin
            // 
            this.txtLinkLabelNameAccountLogin.AutoSize = true;
            this.txtLinkLabelNameAccountLogin.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLinkLabelNameAccountLogin.Location = new System.Drawing.Point(95, 9);
            this.txtLinkLabelNameAccountLogin.Name = "txtLinkLabelNameAccountLogin";
            this.txtLinkLabelNameAccountLogin.Size = new System.Drawing.Size(90, 25);
            this.txtLinkLabelNameAccountLogin.TabIndex = 23;
            this.txtLinkLabelNameAccountLogin.TabStop = true;
            this.txtLinkLabelNameAccountLogin.Text = "linkLabel1";
            this.txtLinkLabelNameAccountLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtLinkLabelNameAccountLogin_LinkClicked_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Welcome, ";
            // 
            // frmHomeDentist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.txtLinkLabelNameAccountLogin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panelAppointment);
            this.Controls.Add(this.panelUpdateAppointment);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RaDe - Dental information management system";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.panelAppointment.ResumeLayout(false);
            this.panelAppointment.PerformLayout();
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointment)).EndInit();
            this.panelUpdateAppointment.ResumeLayout(false);
            this.panelUpdateAppointment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelAppointment;
        private System.Windows.Forms.Label labelAppointment;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.Button buttonFindAppointment;
        private System.Windows.Forms.TextBox textBoxAppointmentPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.DataGridView dataGridViewAppointment;
        private System.Windows.Forms.Panel panelUpdateAppointment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnViewHistoryCustomer;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvService;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDateOfBirth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.LinkLabel txtLinkLabelNameAccountLogin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCheckAbsent;
    }
}