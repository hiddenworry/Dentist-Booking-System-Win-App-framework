namespace WinApp
{
    partial class frmHomeStaff
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.buttonFindAppointment = new System.Windows.Forms.Button();
            this.textBoxAppointmentPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.dateTimePickerAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAppointmentDentist = new System.Windows.Forms.ComboBox();
            this.buttonAppointmentUpdate = new System.Windows.Forms.Button();
            this.buttonAppointmentAdd = new System.Windows.Forms.Button();
            this.dataGridViewAppointment = new System.Windows.Forms.DataGridView();
            this.buttonAppointment = new System.Windows.Forms.Button();
            this.buttonCustomer = new System.Windows.Forms.Button();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.buttonCustomerAdd = new System.Windows.Forms.Button();
            this.buttonCustomerUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxCustomerPhone = new System.Windows.Forms.TextBox();
            this.labelCustomerPhone = new System.Windows.Forms.Label();
            this.buttonCustomerFind = new System.Windows.Forms.Button();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.labelNameCustomer = new System.Windows.Forms.Label();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.txtLinkLabelNameAccountLogin = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.panelAppointment.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAppointment
            // 
            this.panelAppointment.BackColor = System.Drawing.Color.LightBlue;
            this.panelAppointment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAppointment.Controls.Add(this.labelAppointment);
            this.panelAppointment.Controls.Add(this.groupBoxFilter);
            this.panelAppointment.Controls.Add(this.buttonAppointmentUpdate);
            this.panelAppointment.Controls.Add(this.buttonAppointmentAdd);
            this.panelAppointment.Controls.Add(this.dataGridViewAppointment);
            this.panelAppointment.Location = new System.Drawing.Point(12, 80);
            this.panelAppointment.Name = "panelAppointment";
            this.panelAppointment.Size = new System.Drawing.Size(775, 450);
            this.panelAppointment.TabIndex = 0;
            // 
            // labelAppointment
            // 
            this.labelAppointment.AutoSize = true;
            this.labelAppointment.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAppointment.Location = new System.Drawing.Point(85, 59);
            this.labelAppointment.Name = "labelAppointment";
            this.labelAppointment.Size = new System.Drawing.Size(367, 37);
            this.labelAppointment.TabIndex = 12;
            this.labelAppointment.Text = "Appointment Management";
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.label2);
            this.groupBoxFilter.Controls.Add(this.comboBoxStatus);
            this.groupBoxFilter.Controls.Add(this.buttonFindAppointment);
            this.groupBoxFilter.Controls.Add(this.textBoxAppointmentPhone);
            this.groupBoxFilter.Controls.Add(this.label3);
            this.groupBoxFilter.Controls.Add(this.labelPhone);
            this.groupBoxFilter.Controls.Add(this.dateTimePickerAppointmentDate);
            this.groupBoxFilter.Controls.Add(this.label1);
            this.groupBoxFilter.Controls.Add(this.comboBoxAppointmentDentist);
            this.groupBoxFilter.Location = new System.Drawing.Point(501, 4);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(225, 195);
            this.groupBoxFilter.TabIndex = 11;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Status";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "All",
            "Waiting",
            "Done",
            "Cancel"});
            this.comboBoxStatus.Location = new System.Drawing.Point(77, 126);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(127, 28);
            this.comboBoxStatus.TabIndex = 11;
            // 
            // buttonFindAppointment
            // 
            this.buttonFindAppointment.Location = new System.Drawing.Point(43, 160);
            this.buttonFindAppointment.Name = "buttonFindAppointment";
            this.buttonFindAppointment.Size = new System.Drawing.Size(139, 29);
            this.buttonFindAppointment.TabIndex = 10;
            this.buttonFindAppointment.Text = "Find";
            this.buttonFindAppointment.UseVisualStyleBackColor = true;
            this.buttonFindAppointment.Click += new System.EventHandler(this.buttonFindAppointment_Click);
            // 
            // textBoxAppointmentPhone
            // 
            this.textBoxAppointmentPhone.Location = new System.Drawing.Point(77, 59);
            this.textBoxAppointmentPhone.Name = "textBoxAppointmentPhone";
            this.textBoxAppointmentPhone.Size = new System.Drawing.Size(127, 27);
            this.textBoxAppointmentPhone.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(6, 64);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(50, 20);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "Phone";
            // 
            // dateTimePickerAppointmentDate
            // 
            this.dateTimePickerAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAppointmentDate.Location = new System.Drawing.Point(77, 26);
            this.dateTimePickerAppointmentDate.Name = "dateTimePickerAppointmentDate";
            this.dateTimePickerAppointmentDate.Size = new System.Drawing.Size(127, 27);
            this.dateTimePickerAppointmentDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dentist";
            // 
            // comboBoxAppointmentDentist
            // 
            this.comboBoxAppointmentDentist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAppointmentDentist.FormattingEnabled = true;
            this.comboBoxAppointmentDentist.Location = new System.Drawing.Point(77, 92);
            this.comboBoxAppointmentDentist.Name = "comboBoxAppointmentDentist";
            this.comboBoxAppointmentDentist.Size = new System.Drawing.Size(127, 28);
            this.comboBoxAppointmentDentist.TabIndex = 0;
            // 
            // buttonAppointmentUpdate
            // 
            this.buttonAppointmentUpdate.Location = new System.Drawing.Point(265, 164);
            this.buttonAppointmentUpdate.Name = "buttonAppointmentUpdate";
            this.buttonAppointmentUpdate.Size = new System.Drawing.Size(139, 29);
            this.buttonAppointmentUpdate.TabIndex = 8;
            this.buttonAppointmentUpdate.Text = "Detail";
            this.buttonAppointmentUpdate.UseVisualStyleBackColor = true;
            this.buttonAppointmentUpdate.Click += new System.EventHandler(this.buttonAppointmentUpdate_Click);
            // 
            // buttonAppointmentAdd
            // 
            this.buttonAppointmentAdd.Location = new System.Drawing.Point(120, 164);
            this.buttonAppointmentAdd.Name = "buttonAppointmentAdd";
            this.buttonAppointmentAdd.Size = new System.Drawing.Size(139, 29);
            this.buttonAppointmentAdd.TabIndex = 5;
            this.buttonAppointmentAdd.Text = "Add";
            this.buttonAppointmentAdd.UseVisualStyleBackColor = true;
            this.buttonAppointmentAdd.Click += new System.EventHandler(this.buttonAppointmentAdd_Click);
            // 
            // dataGridViewAppointment
            // 
            this.dataGridViewAppointment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAppointment.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointment.Location = new System.Drawing.Point(3, 205);
            this.dataGridViewAppointment.MultiSelect = false;
            this.dataGridViewAppointment.Name = "dataGridViewAppointment";
            this.dataGridViewAppointment.ReadOnly = true;
            this.dataGridViewAppointment.RowHeadersWidth = 51;
            this.dataGridViewAppointment.RowTemplate.Height = 29;
            this.dataGridViewAppointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAppointment.Size = new System.Drawing.Size(767, 240);
            this.dataGridViewAppointment.TabIndex = 7;
            this.dataGridViewAppointment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAppointment_CellClick);
            // 
            // buttonAppointment
            // 
            this.buttonAppointment.BackColor = System.Drawing.Color.LightBlue;
            this.buttonAppointment.Location = new System.Drawing.Point(504, 45);
            this.buttonAppointment.Name = "buttonAppointment";
            this.buttonAppointment.Size = new System.Drawing.Size(139, 29);
            this.buttonAppointment.TabIndex = 1;
            this.buttonAppointment.Text = "Appointment";
            this.buttonAppointment.UseVisualStyleBackColor = false;
            this.buttonAppointment.Click += new System.EventHandler(this.buttonAppointment_Click);
            // 
            // buttonCustomer
            // 
            this.buttonCustomer.Location = new System.Drawing.Point(649, 45);
            this.buttonCustomer.Name = "buttonCustomer";
            this.buttonCustomer.Size = new System.Drawing.Size(139, 29);
            this.buttonCustomer.TabIndex = 2;
            this.buttonCustomer.Text = "Customer";
            this.buttonCustomer.UseVisualStyleBackColor = true;
            this.buttonCustomer.Click += new System.EventHandler(this.buttonCustomer_Click);
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(3, 204);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.ReadOnly = true;
            this.dataGridViewCustomer.RowHeadersWidth = 51;
            this.dataGridViewCustomer.RowTemplate.Height = 29;
            this.dataGridViewCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(767, 240);
            this.dataGridViewCustomer.TabIndex = 7;
            this.dataGridViewCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomer_CellClick_1);
            this.dataGridViewCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomer_CellContentClick_1);
            this.dataGridViewCustomer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomer_CellDoubleClick);
            // 
            // buttonCustomerAdd
            // 
            this.buttonCustomerAdd.Location = new System.Drawing.Point(50, 141);
            this.buttonCustomerAdd.Name = "buttonCustomerAdd";
            this.buttonCustomerAdd.Size = new System.Drawing.Size(139, 29);
            this.buttonCustomerAdd.TabIndex = 5;
            this.buttonCustomerAdd.Text = "Add";
            this.buttonCustomerAdd.UseVisualStyleBackColor = true;
            this.buttonCustomerAdd.Click += new System.EventHandler(this.buttonCustomerAdd_Click);
            // 
            // buttonCustomerUpdate
            // 
            this.buttonCustomerUpdate.Location = new System.Drawing.Point(195, 141);
            this.buttonCustomerUpdate.Name = "buttonCustomerUpdate";
            this.buttonCustomerUpdate.Size = new System.Drawing.Size(139, 29);
            this.buttonCustomerUpdate.TabIndex = 8;
            this.buttonCustomerUpdate.Text = "Update";
            this.buttonCustomerUpdate.UseVisualStyleBackColor = true;
            this.buttonCustomerUpdate.Click += new System.EventHandler(this.buttonCustomerUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxCustomerPhone);
            this.groupBox1.Controls.Add(this.labelCustomerPhone);
            this.groupBox1.Controls.Add(this.buttonCustomerFind);
            this.groupBox1.Controls.Add(this.textBoxCustomerName);
            this.groupBox1.Controls.Add(this.labelNameCustomer);
            this.groupBox1.Location = new System.Drawing.Point(501, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 166);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // textBoxCustomerPhone
            // 
            this.textBoxCustomerPhone.Location = new System.Drawing.Point(85, 64);
            this.textBoxCustomerPhone.Name = "textBoxCustomerPhone";
            this.textBoxCustomerPhone.Size = new System.Drawing.Size(127, 27);
            this.textBoxCustomerPhone.TabIndex = 12;
            // 
            // labelCustomerPhone
            // 
            this.labelCustomerPhone.AutoSize = true;
            this.labelCustomerPhone.Location = new System.Drawing.Point(18, 67);
            this.labelCustomerPhone.Name = "labelCustomerPhone";
            this.labelCustomerPhone.Size = new System.Drawing.Size(50, 20);
            this.labelCustomerPhone.TabIndex = 11;
            this.labelCustomerPhone.Text = "Phone";
            // 
            // buttonCustomerFind
            // 
            this.buttonCustomerFind.Location = new System.Drawing.Point(73, 122);
            this.buttonCustomerFind.Name = "buttonCustomerFind";
            this.buttonCustomerFind.Size = new System.Drawing.Size(139, 29);
            this.buttonCustomerFind.TabIndex = 10;
            this.buttonCustomerFind.Text = "Find";
            this.buttonCustomerFind.UseVisualStyleBackColor = true;
            this.buttonCustomerFind.Click += new System.EventHandler(this.buttonCustomerFind_Click);
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(85, 31);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(127, 27);
            this.textBoxCustomerName.TabIndex = 6;
            // 
            // labelNameCustomer
            // 
            this.labelNameCustomer.AutoSize = true;
            this.labelNameCustomer.Location = new System.Drawing.Point(18, 34);
            this.labelNameCustomer.Name = "labelNameCustomer";
            this.labelNameCustomer.Size = new System.Drawing.Size(49, 20);
            this.labelNameCustomer.TabIndex = 4;
            this.labelNameCustomer.Text = "Name";
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCustomer.Location = new System.Drawing.Point(108, 59);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(319, 37);
            this.labelCustomer.TabIndex = 12;
            this.labelCustomer.Text = "Customer Management";
            // 
            // panelCustomer
            // 
            this.panelCustomer.BackColor = System.Drawing.Color.LightBlue;
            this.panelCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCustomer.Controls.Add(this.labelCustomer);
            this.panelCustomer.Controls.Add(this.groupBox1);
            this.panelCustomer.Controls.Add(this.buttonCustomerUpdate);
            this.panelCustomer.Controls.Add(this.buttonCustomerAdd);
            this.panelCustomer.Controls.Add(this.dataGridViewCustomer);
            this.panelCustomer.Location = new System.Drawing.Point(12, 80);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(775, 450);
            this.panelCustomer.TabIndex = 13;
            // 
            // txtLinkLabelNameAccountLogin
            // 
            this.txtLinkLabelNameAccountLogin.AutoSize = true;
            this.txtLinkLabelNameAccountLogin.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLinkLabelNameAccountLogin.Location = new System.Drawing.Point(95, 9);
            this.txtLinkLabelNameAccountLogin.Name = "txtLinkLabelNameAccountLogin";
            this.txtLinkLabelNameAccountLogin.Size = new System.Drawing.Size(90, 25);
            this.txtLinkLabelNameAccountLogin.TabIndex = 25;
            this.txtLinkLabelNameAccountLogin.TabStop = true;
            this.txtLinkLabelNameAccountLogin.Text = "linkLabel1";
            this.txtLinkLabelNameAccountLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtLinkLabelNameAccountLogin_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "Welcome, ";
            // 
            // frmHomeStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.txtLinkLabelNameAccountLogin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panelCustomer);
            this.Controls.Add(this.buttonCustomer);
            this.Controls.Add(this.buttonAppointment);
            this.Controls.Add(this.panelAppointment);
            this.Name = "frmHomeStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RaDe - Dental information management system";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.panelAppointment.ResumeLayout(false);
            this.panelAppointment.PerformLayout();
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelCustomer.ResumeLayout(false);
            this.panelCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAppointment;
        private System.Windows.Forms.Button buttonAppointment;
        private System.Windows.Forms.Button buttonCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAppointmentDentist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.DateTimePicker dateTimePickerAppointmentDate;
        private System.Windows.Forms.TextBox textBoxAppointmentPhone;
        private System.Windows.Forms.DataGridView dataGridViewAppointment;
        private System.Windows.Forms.Button buttonAppointmentAdd;
        private System.Windows.Forms.Button buttonAppointmentUpdate;
        private System.Windows.Forms.Button buttonFindAppointment;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.Label labelAppointment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.Button buttonCustomerAdd;
        private System.Windows.Forms.Button buttonCustomerUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxCustomerPhone;
        private System.Windows.Forms.Label labelCustomerPhone;
        private System.Windows.Forms.Button buttonCustomerFind;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Label labelNameCustomer;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.LinkLabel txtLinkLabelNameAccountLogin;
        private System.Windows.Forms.Label label8;
    }
}