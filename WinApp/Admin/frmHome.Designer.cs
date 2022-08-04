namespace WinApp
{
    partial class frmHome
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
            this.panelService = new System.Windows.Forms.Panel();
            this.labelService = new System.Windows.Forms.Label();
            this.groupBoxFilterService = new System.Windows.Forms.GroupBox();
            this.labelServiceStatus = new System.Windows.Forms.Label();
            this.comboBoxServiceStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxServiceType = new System.Windows.Forms.ComboBox();
            this.labelServiceType = new System.Windows.Forms.Label();
            this.buttonServiceFind = new System.Windows.Forms.Button();
            this.textBoxServiceName = new System.Windows.Forms.TextBox();
            this.labelServicename = new System.Windows.Forms.Label();
            this.buttonServiceDisable = new System.Windows.Forms.Button();
            this.buttonServiceUpdate = new System.Windows.Forms.Button();
            this.buttonServiceAdd = new System.Windows.Forms.Button();
            this.dataGridViewService = new System.Windows.Forms.DataGridView();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxCustomerPhone = new System.Windows.Forms.TextBox();
            this.labelCustomerPhone = new System.Windows.Forms.Label();
            this.buttonCustomerFind = new System.Windows.Forms.Button();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.labelNameCustomer = new System.Windows.Forms.Label();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.panelDentist = new System.Windows.Forms.Panel();
            this.btnDisableDentist = new System.Windows.Forms.Button();
            this.labelDentist = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.labelDentistStatus = new System.Windows.Forms.Label();
            this.comboDentistStatus = new System.Windows.Forms.ComboBox();
            this.filterDentist = new System.Windows.Forms.Button();
            this.textDentistName = new System.Windows.Forms.TextBox();
            this.labelDentistName = new System.Windows.Forms.Label();
            this.buttonDentistUpdate = new System.Windows.Forms.Button();
            this.buttonDentistAdd = new System.Windows.Forms.Button();
            this.dataGridViewDentist = new System.Windows.Forms.DataGridView();
            this.panelAppointment = new System.Windows.Forms.Panel();
            this.labelAppointment = new System.Windows.Forms.Label();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboxAppointmentStatus = new System.Windows.Forms.ComboBox();
            this.buttonFindAppointment = new System.Windows.Forms.Button();
            this.textBoxAppointmentPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.dateTimePickerAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAppointmentDentist = new System.Windows.Forms.ComboBox();
            this.dataGridViewAppointment = new System.Windows.Forms.DataGridView();
            this.buttonAppointment = new System.Windows.Forms.Button();
            this.buttonCustomer = new System.Windows.Forms.Button();
            this.buttonService = new System.Windows.Forms.Button();
            this.buttonDentist = new System.Windows.Forms.Button();
            this.txtLinkLabelNameAccountLogin = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.panelService.SuspendLayout();
            this.groupBoxFilterService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).BeginInit();
            this.panelCustomer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.panelDentist.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDentist)).BeginInit();
            this.panelAppointment.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // panelService
            // 
            this.panelService.BackColor = System.Drawing.Color.LightBlue;
            this.panelService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelService.Controls.Add(this.labelService);
            this.panelService.Controls.Add(this.groupBoxFilterService);
            this.panelService.Controls.Add(this.buttonServiceDisable);
            this.panelService.Controls.Add(this.buttonServiceUpdate);
            this.panelService.Controls.Add(this.buttonServiceAdd);
            this.panelService.Controls.Add(this.dataGridViewService);
            this.panelService.Location = new System.Drawing.Point(11, 80);
            this.panelService.Name = "panelService";
            this.panelService.Size = new System.Drawing.Size(775, 450);
            this.panelService.TabIndex = 14;
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelService.Location = new System.Drawing.Point(110, 57);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(288, 37);
            this.labelService.TabIndex = 12;
            this.labelService.Text = "Service Management";
            this.labelService.Click += new System.EventHandler(this.labelService_Click);
            // 
            // groupBoxFilterService
            // 
            this.groupBoxFilterService.Controls.Add(this.labelServiceStatus);
            this.groupBoxFilterService.Controls.Add(this.comboBoxServiceStatus);
            this.groupBoxFilterService.Controls.Add(this.comboBoxServiceType);
            this.groupBoxFilterService.Controls.Add(this.labelServiceType);
            this.groupBoxFilterService.Controls.Add(this.buttonServiceFind);
            this.groupBoxFilterService.Controls.Add(this.textBoxServiceName);
            this.groupBoxFilterService.Controls.Add(this.labelServicename);
            this.groupBoxFilterService.Location = new System.Drawing.Point(501, 4);
            this.groupBoxFilterService.Name = "groupBoxFilterService";
            this.groupBoxFilterService.Size = new System.Drawing.Size(225, 166);
            this.groupBoxFilterService.TabIndex = 11;
            this.groupBoxFilterService.TabStop = false;
            this.groupBoxFilterService.Text = "Filter";
            // 
            // labelServiceStatus
            // 
            this.labelServiceStatus.AutoSize = true;
            this.labelServiceStatus.Location = new System.Drawing.Point(18, 92);
            this.labelServiceStatus.Name = "labelServiceStatus";
            this.labelServiceStatus.Size = new System.Drawing.Size(49, 20);
            this.labelServiceStatus.TabIndex = 14;
            this.labelServiceStatus.Text = "Status";
            // 
            // comboBoxServiceStatus
            // 
            this.comboBoxServiceStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxServiceStatus.FormattingEnabled = true;
            this.comboBoxServiceStatus.Location = new System.Drawing.Point(85, 89);
            this.comboBoxServiceStatus.Name = "comboBoxServiceStatus";
            this.comboBoxServiceStatus.Size = new System.Drawing.Size(127, 28);
            this.comboBoxServiceStatus.TabIndex = 13;
            // 
            // comboBoxServiceType
            // 
            this.comboBoxServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxServiceType.FormattingEnabled = true;
            this.comboBoxServiceType.Location = new System.Drawing.Point(85, 55);
            this.comboBoxServiceType.Name = "comboBoxServiceType";
            this.comboBoxServiceType.Size = new System.Drawing.Size(127, 28);
            this.comboBoxServiceType.TabIndex = 12;
            // 
            // labelServiceType
            // 
            this.labelServiceType.AutoSize = true;
            this.labelServiceType.Location = new System.Drawing.Point(18, 58);
            this.labelServiceType.Name = "labelServiceType";
            this.labelServiceType.Size = new System.Drawing.Size(40, 20);
            this.labelServiceType.TabIndex = 11;
            this.labelServiceType.Text = "Type";
            // 
            // buttonServiceFind
            // 
            this.buttonServiceFind.Location = new System.Drawing.Point(56, 126);
            this.buttonServiceFind.Name = "buttonServiceFind";
            this.buttonServiceFind.Size = new System.Drawing.Size(139, 29);
            this.buttonServiceFind.TabIndex = 10;
            this.buttonServiceFind.Text = "Find";
            this.buttonServiceFind.UseVisualStyleBackColor = true;
            this.buttonServiceFind.Click += new System.EventHandler(this.buttonServiceFind_Click);
            // 
            // textBoxServiceName
            // 
            this.textBoxServiceName.Location = new System.Drawing.Point(85, 20);
            this.textBoxServiceName.Name = "textBoxServiceName";
            this.textBoxServiceName.Size = new System.Drawing.Size(127, 27);
            this.textBoxServiceName.TabIndex = 6;
            // 
            // labelServicename
            // 
            this.labelServicename.AutoSize = true;
            this.labelServicename.Location = new System.Drawing.Point(18, 25);
            this.labelServicename.Name = "labelServicename";
            this.labelServicename.Size = new System.Drawing.Size(49, 20);
            this.labelServicename.TabIndex = 4;
            this.labelServicename.Text = "Name";
            // 
            // buttonServiceDisable
            // 
            this.buttonServiceDisable.Location = new System.Drawing.Point(307, 141);
            this.buttonServiceDisable.Name = "buttonServiceDisable";
            this.buttonServiceDisable.Size = new System.Drawing.Size(139, 29);
            this.buttonServiceDisable.TabIndex = 9;
            this.buttonServiceDisable.Text = "Disable";
            this.buttonServiceDisable.UseVisualStyleBackColor = true;
            this.buttonServiceDisable.Click += new System.EventHandler(this.buttonServiceDisable_Click);
            // 
            // buttonServiceUpdate
            // 
            this.buttonServiceUpdate.Location = new System.Drawing.Point(162, 141);
            this.buttonServiceUpdate.Name = "buttonServiceUpdate";
            this.buttonServiceUpdate.Size = new System.Drawing.Size(139, 29);
            this.buttonServiceUpdate.TabIndex = 8;
            this.buttonServiceUpdate.Text = "Update";
            this.buttonServiceUpdate.UseVisualStyleBackColor = true;
            this.buttonServiceUpdate.Click += new System.EventHandler(this.buttonServiceUpdate_Click);
            // 
            // buttonServiceAdd
            // 
            this.buttonServiceAdd.Location = new System.Drawing.Point(17, 141);
            this.buttonServiceAdd.Name = "buttonServiceAdd";
            this.buttonServiceAdd.Size = new System.Drawing.Size(139, 29);
            this.buttonServiceAdd.TabIndex = 5;
            this.buttonServiceAdd.Text = "Add";
            this.buttonServiceAdd.UseVisualStyleBackColor = true;
            this.buttonServiceAdd.Click += new System.EventHandler(this.buttonServiceAdd_Click);
            // 
            // dataGridViewService
            // 
            this.dataGridViewService.AllowUserToAddRows = false;
            this.dataGridViewService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewService.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewService.Location = new System.Drawing.Point(3, 204);
            this.dataGridViewService.Name = "dataGridViewService";
            this.dataGridViewService.ReadOnly = true;
            this.dataGridViewService.RowHeadersWidth = 51;
            this.dataGridViewService.RowTemplate.Height = 29;
            this.dataGridViewService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewService.Size = new System.Drawing.Size(767, 240);
            this.dataGridViewService.TabIndex = 7;
            this.dataGridViewService.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewService_CellClick);
            this.dataGridViewService.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewService_CellDoubleClick);
            // 
            // panelCustomer
            // 
            this.panelCustomer.BackColor = System.Drawing.Color.LightBlue;
            this.panelCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCustomer.Controls.Add(this.labelCustomer);
            this.panelCustomer.Controls.Add(this.groupBox1);
            this.panelCustomer.Controls.Add(this.dataGridViewCustomer);
            this.panelCustomer.Location = new System.Drawing.Point(11, 80);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(775, 450);
            this.panelCustomer.TabIndex = 13;
            this.panelCustomer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCustomer_Paint);
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
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.AllowUserToAddRows = false;
            this.dataGridViewCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(3, 205);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.ReadOnly = true;
            this.dataGridViewCustomer.RowHeadersWidth = 51;
            this.dataGridViewCustomer.RowTemplate.Height = 29;
            this.dataGridViewCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(767, 240);
            this.dataGridViewCustomer.TabIndex = 7;
            // 
            // panelDentist
            // 
            this.panelDentist.BackColor = System.Drawing.Color.LightBlue;
            this.panelDentist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDentist.Controls.Add(this.btnDisableDentist);
            this.panelDentist.Controls.Add(this.labelDentist);
            this.panelDentist.Controls.Add(this.groupBox3);
            this.panelDentist.Controls.Add(this.buttonDentistUpdate);
            this.panelDentist.Controls.Add(this.buttonDentistAdd);
            this.panelDentist.Controls.Add(this.dataGridViewDentist);
            this.panelDentist.Location = new System.Drawing.Point(11, 80);
            this.panelDentist.Name = "panelDentist";
            this.panelDentist.Size = new System.Drawing.Size(775, 450);
            this.panelDentist.TabIndex = 15;
            // 
            // btnDisableDentist
            // 
            this.btnDisableDentist.Location = new System.Drawing.Point(307, 141);
            this.btnDisableDentist.Name = "btnDisableDentist";
            this.btnDisableDentist.Size = new System.Drawing.Size(126, 29);
            this.btnDisableDentist.TabIndex = 13;
            this.btnDisableDentist.Text = "Disable";
            this.btnDisableDentist.UseVisualStyleBackColor = true;
            this.btnDisableDentist.Click += new System.EventHandler(this.btnDisableDentist_Click);
            // 
            // labelDentist
            // 
            this.labelDentist.AutoSize = true;
            this.labelDentist.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDentist.Location = new System.Drawing.Point(109, 45);
            this.labelDentist.Name = "labelDentist";
            this.labelDentist.Size = new System.Drawing.Size(300, 37);
            this.labelDentist.TabIndex = 12;
            this.labelDentist.Text = "Account Management";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cbRole);
            this.groupBox3.Controls.Add(this.labelDentistStatus);
            this.groupBox3.Controls.Add(this.comboDentistStatus);
            this.groupBox3.Controls.Add(this.filterDentist);
            this.groupBox3.Controls.Add(this.textDentistName);
            this.groupBox3.Controls.Add(this.labelDentistName);
            this.groupBox3.Location = new System.Drawing.Point(501, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 166);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Role";
            // 
            // cbRole
            // 
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(77, 92);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(127, 28);
            this.cbRole.TabIndex = 15;
            // 
            // labelDentistStatus
            // 
            this.labelDentistStatus.AutoSize = true;
            this.labelDentistStatus.Location = new System.Drawing.Point(17, 55);
            this.labelDentistStatus.Name = "labelDentistStatus";
            this.labelDentistStatus.Size = new System.Drawing.Size(49, 20);
            this.labelDentistStatus.TabIndex = 14;
            this.labelDentistStatus.Text = "Status";
            // 
            // comboDentistStatus
            // 
            this.comboDentistStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDentistStatus.FormattingEnabled = true;
            this.comboDentistStatus.Location = new System.Drawing.Point(77, 55);
            this.comboDentistStatus.Name = "comboDentistStatus";
            this.comboDentistStatus.Size = new System.Drawing.Size(127, 28);
            this.comboDentistStatus.TabIndex = 13;
            // 
            // filterDentist
            // 
            this.filterDentist.Location = new System.Drawing.Point(77, 131);
            this.filterDentist.Name = "filterDentist";
            this.filterDentist.Size = new System.Drawing.Size(139, 29);
            this.filterDentist.TabIndex = 10;
            this.filterDentist.Text = "Find";
            this.filterDentist.UseVisualStyleBackColor = true;
            this.filterDentist.Click += new System.EventHandler(this.filterDentist_Click);
            // 
            // textDentistName
            // 
            this.textDentistName.Location = new System.Drawing.Point(77, 21);
            this.textDentistName.Name = "textDentistName";
            this.textDentistName.Size = new System.Drawing.Size(127, 27);
            this.textDentistName.TabIndex = 6;
            // 
            // labelDentistName
            // 
            this.labelDentistName.AutoSize = true;
            this.labelDentistName.Location = new System.Drawing.Point(17, 26);
            this.labelDentistName.Name = "labelDentistName";
            this.labelDentistName.Size = new System.Drawing.Size(49, 20);
            this.labelDentistName.TabIndex = 4;
            this.labelDentistName.Text = "Name";
            // 
            // buttonDentistUpdate
            // 
            this.buttonDentistUpdate.Location = new System.Drawing.Point(197, 141);
            this.buttonDentistUpdate.Name = "buttonDentistUpdate";
            this.buttonDentistUpdate.Size = new System.Drawing.Size(104, 29);
            this.buttonDentistUpdate.TabIndex = 8;
            this.buttonDentistUpdate.Text = "Update";
            this.buttonDentistUpdate.UseVisualStyleBackColor = true;
            this.buttonDentistUpdate.Click += new System.EventHandler(this.buttonDentistUpdate_Click);
            // 
            // buttonDentistAdd
            // 
            this.buttonDentistAdd.Location = new System.Drawing.Point(84, 141);
            this.buttonDentistAdd.Name = "buttonDentistAdd";
            this.buttonDentistAdd.Size = new System.Drawing.Size(107, 29);
            this.buttonDentistAdd.TabIndex = 5;
            this.buttonDentistAdd.Text = "Add";
            this.buttonDentistAdd.UseVisualStyleBackColor = true;
            this.buttonDentistAdd.Click += new System.EventHandler(this.buttonDentistAdd_Click);
            // 
            // dataGridViewDentist
            // 
            this.dataGridViewDentist.AllowUserToAddRows = false;
            this.dataGridViewDentist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDentist.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDentist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDentist.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewDentist.Location = new System.Drawing.Point(3, 205);
            this.dataGridViewDentist.Name = "dataGridViewDentist";
            this.dataGridViewDentist.ReadOnly = true;
            this.dataGridViewDentist.RowHeadersWidth = 51;
            this.dataGridViewDentist.RowTemplate.Height = 29;
            this.dataGridViewDentist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDentist.Size = new System.Drawing.Size(767, 240);
            this.dataGridViewDentist.TabIndex = 7;
            this.dataGridViewDentist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDentist_CellClick);
            this.dataGridViewDentist.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDentist_CellDoubleClick);
            // 
            // panelAppointment
            // 
            this.panelAppointment.BackColor = System.Drawing.Color.LightBlue;
            this.panelAppointment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAppointment.Controls.Add(this.labelAppointment);
            this.panelAppointment.Controls.Add(this.groupBoxFilter);
            this.panelAppointment.Controls.Add(this.dataGridViewAppointment);
            this.panelAppointment.Location = new System.Drawing.Point(12, 80);
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
            this.labelAppointment.Size = new System.Drawing.Size(367, 37);
            this.labelAppointment.TabIndex = 12;
            this.labelAppointment.Text = "Appointment Management";
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.label2);
            this.groupBoxFilter.Controls.Add(this.comboxAppointmentStatus);
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
            // comboxAppointmentStatus
            // 
            this.comboxAppointmentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxAppointmentStatus.FormattingEnabled = true;
            this.comboxAppointmentStatus.Location = new System.Drawing.Point(77, 126);
            this.comboxAppointmentStatus.Name = "comboxAppointmentStatus";
            this.comboxAppointmentStatus.Size = new System.Drawing.Size(127, 28);
            this.comboxAppointmentStatus.TabIndex = 11;
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
            // 
            // buttonAppointment
            // 
            this.buttonAppointment.BackColor = System.Drawing.Color.LightBlue;
            this.buttonAppointment.Location = new System.Drawing.Point(214, 45);
            this.buttonAppointment.Name = "buttonAppointment";
            this.buttonAppointment.Size = new System.Drawing.Size(139, 29);
            this.buttonAppointment.TabIndex = 1;
            this.buttonAppointment.Text = "Appointment";
            this.buttonAppointment.UseVisualStyleBackColor = false;
            this.buttonAppointment.Click += new System.EventHandler(this.buttonAppointment_Click);
            // 
            // buttonCustomer
            // 
            this.buttonCustomer.Location = new System.Drawing.Point(359, 45);
            this.buttonCustomer.Name = "buttonCustomer";
            this.buttonCustomer.Size = new System.Drawing.Size(139, 29);
            this.buttonCustomer.TabIndex = 2;
            this.buttonCustomer.Text = "Customer";
            this.buttonCustomer.UseVisualStyleBackColor = true;
            this.buttonCustomer.Click += new System.EventHandler(this.buttonCustomer_Click);
            // 
            // buttonService
            // 
            this.buttonService.Location = new System.Drawing.Point(504, 45);
            this.buttonService.Name = "buttonService";
            this.buttonService.Size = new System.Drawing.Size(139, 29);
            this.buttonService.TabIndex = 3;
            this.buttonService.Text = "Service";
            this.buttonService.UseVisualStyleBackColor = true;
            this.buttonService.Click += new System.EventHandler(this.buttonService_Click);
            // 
            // buttonDentist
            // 
            this.buttonDentist.Location = new System.Drawing.Point(649, 45);
            this.buttonDentist.Name = "buttonDentist";
            this.buttonDentist.Size = new System.Drawing.Size(139, 29);
            this.buttonDentist.TabIndex = 4;
            this.buttonDentist.Text = "Account";
            this.buttonDentist.UseVisualStyleBackColor = true;
            this.buttonDentist.Click += new System.EventHandler(this.buttonDentist_Click);
            // 
            // txtLinkLabelNameAccountLogin
            // 
            this.txtLinkLabelNameAccountLogin.AutoSize = true;
            this.txtLinkLabelNameAccountLogin.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLinkLabelNameAccountLogin.Location = new System.Drawing.Point(95, 9);
            this.txtLinkLabelNameAccountLogin.Name = "txtLinkLabelNameAccountLogin";
            this.txtLinkLabelNameAccountLogin.Size = new System.Drawing.Size(90, 25);
            this.txtLinkLabelNameAccountLogin.TabIndex = 27;
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
            this.label8.TabIndex = 26;
            this.label8.Text = "Welcome, ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.txtLinkLabelNameAccountLogin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonDentist);
            this.Controls.Add(this.buttonService);
            this.Controls.Add(this.buttonCustomer);
            this.Controls.Add(this.buttonAppointment);
            this.Controls.Add(this.panelAppointment);
            this.Controls.Add(this.panelCustomer);
            this.Controls.Add(this.panelService);
            this.Controls.Add(this.panelDentist);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RaDe - Dental information management system";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.panelService.ResumeLayout(false);
            this.panelService.PerformLayout();
            this.groupBoxFilterService.ResumeLayout(false);
            this.groupBoxFilterService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).EndInit();
            this.panelCustomer.ResumeLayout(false);
            this.panelCustomer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.panelDentist.ResumeLayout(false);
            this.panelDentist.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDentist)).EndInit();
            this.panelAppointment.ResumeLayout(false);
            this.panelAppointment.PerformLayout();
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAppointment;
        private System.Windows.Forms.Button buttonCustomer;
        private System.Windows.Forms.Button buttonService;
        private System.Windows.Forms.Button buttonDentist;
        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCustomerFind;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Label labelNameCustomer;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.TextBox textBoxCustomerPhone;
        private System.Windows.Forms.Label labelCustomerPhone;
        private System.Windows.Forms.Panel panelService;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.GroupBox groupBoxFilterService;
        private System.Windows.Forms.Label labelServiceType;
        private System.Windows.Forms.Button buttonServiceFind;
        private System.Windows.Forms.TextBox textBoxServiceName;
        private System.Windows.Forms.Label labelServicename;
        private System.Windows.Forms.Button buttonServiceDisable;
        private System.Windows.Forms.Button buttonServiceUpdate;
        private System.Windows.Forms.Button buttonServiceAdd;
        private System.Windows.Forms.DataGridView dataGridViewService;
        private System.Windows.Forms.ComboBox comboBoxServiceType;
        private System.Windows.Forms.Label labelServiceStatus;
        private System.Windows.Forms.ComboBox comboBoxServiceStatus;
        private System.Windows.Forms.Panel panelDentist;
        private System.Windows.Forms.Label labelDentist;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelDentistStatus;
        private System.Windows.Forms.ComboBox comboDentistStatus;
        private System.Windows.Forms.Button filterDentist;
        private System.Windows.Forms.TextBox textDentistName;
        private System.Windows.Forms.Label labelDentistName;
        private System.Windows.Forms.Button buttonDentistUpdate;
        private System.Windows.Forms.Button buttonDentistAdd;
        private System.Windows.Forms.DataGridView dataGridViewDentist;
        private System.Windows.Forms.Button btnDisableDentist;
        private System.Windows.Forms.Panel panelAppointment;
        private System.Windows.Forms.Label labelAppointment;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboxAppointmentStatus;
        private System.Windows.Forms.Button buttonFindAppointment;
        private System.Windows.Forms.TextBox textBoxAppointmentPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.DateTimePicker dateTimePickerAppointmentDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAppointmentDentist;
        private System.Windows.Forms.DataGridView dataGridViewAppointment;
        private System.Windows.Forms.LinkLabel txtLinkLabelNameAccountLogin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbRole;
    }
}