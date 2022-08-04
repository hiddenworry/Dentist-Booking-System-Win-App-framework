namespace WinApp
{
    partial class frmProfile
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelUsernameError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelUpdateProfile = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.labelStatusError = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelRoleError = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelGenderError = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelNameError = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.labelPasswordError = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelCofirmError = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtConfirmUpdate = new System.Windows.Forms.TextBox();
            this.cboGenderUpdate = new System.Windows.Forms.ComboBox();
            this.cboStatusUpdate = new System.Windows.Forms.ComboBox();
            this.cboRoleUpdate = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsernameUpdate = new System.Windows.Forms.TextBox();
            this.btnCloseUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPasswordUpdate = new System.Windows.Forms.TextBox();
            this.Role = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNameUpdate = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panelProfile.SuspendLayout();
            this.panelUpdateProfile.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User name";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(138, 40);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "Enter username";
            this.txtUsername.Size = new System.Drawing.Size(261, 27);
            this.txtUsername.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(97, 224);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(94, 29);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.Connection = null;
            this.sqlCommand1.Notification = null;
            this.sqlCommand1.Transaction = null;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(328, 224);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.AllowDrop = true;
            this.labelHeader.AutoEllipsis = true;
            this.labelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHeader.Location = new System.Drawing.Point(0, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(701, 56);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "label1";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 56);
            this.panel1.TabIndex = 3;
            // 
            // labelUsernameError
            // 
            this.labelUsernameError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUsernameError.ForeColor = System.Drawing.Color.Red;
            this.labelUsernameError.Location = new System.Drawing.Point(0, 0);
            this.labelUsernameError.Name = "labelUsernameError";
            this.labelUsernameError.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelUsernameError.Size = new System.Drawing.Size(261, 30);
            this.labelUsernameError.TabIndex = 5;
            this.labelUsernameError.Text = "label8";
            this.labelUsernameError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelUsernameError.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(138, 85);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "Enter password";
            this.txtPassword.Size = new System.Drawing.Size(261, 27);
            this.txtPassword.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(138, 132);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Enter name";
            this.txtName.Size = new System.Drawing.Size(261, 27);
            this.txtName.TabIndex = 1;
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cboGender.Location = new System.Drawing.Point(138, 174);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(261, 28);
            this.cboGender.TabIndex = 4;
            // 
            // panelProfile
            // 
            this.panelProfile.Controls.Add(this.cboGender);
            this.panelProfile.Controls.Add(this.label1);
            this.panelProfile.Controls.Add(this.txtUsername);
            this.panelProfile.Controls.Add(this.btnClose);
            this.panelProfile.Controls.Add(this.label2);
            this.panelProfile.Controls.Add(this.button1);
            this.panelProfile.Controls.Add(this.btnLogout);
            this.panelProfile.Controls.Add(this.txtPassword);
            this.panelProfile.Controls.Add(this.label3);
            this.panelProfile.Controls.Add(this.label4);
            this.panelProfile.Controls.Add(this.txtName);
            this.panelProfile.Location = new System.Drawing.Point(67, 95);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(469, 384);
            this.panelProfile.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panelUpdateProfile
            // 
            this.panelUpdateProfile.Controls.Add(this.panel7);
            this.panelUpdateProfile.Controls.Add(this.panel6);
            this.panelUpdateProfile.Controls.Add(this.panel5);
            this.panelUpdateProfile.Controls.Add(this.panel4);
            this.panelUpdateProfile.Controls.Add(this.panel8);
            this.panelUpdateProfile.Controls.Add(this.panel3);
            this.panelUpdateProfile.Controls.Add(this.panel2);
            this.panelUpdateProfile.Controls.Add(this.txtConfirmUpdate);
            this.panelUpdateProfile.Controls.Add(this.cboGenderUpdate);
            this.panelUpdateProfile.Controls.Add(this.cboStatusUpdate);
            this.panelUpdateProfile.Controls.Add(this.cboRoleUpdate);
            this.panelUpdateProfile.Controls.Add(this.label6);
            this.panelUpdateProfile.Controls.Add(this.txtUsernameUpdate);
            this.panelUpdateProfile.Controls.Add(this.btnCloseUpdate);
            this.panelUpdateProfile.Controls.Add(this.label7);
            this.panelUpdateProfile.Controls.Add(this.btnSave);
            this.panelUpdateProfile.Controls.Add(this.label5);
            this.panelUpdateProfile.Controls.Add(this.label11);
            this.panelUpdateProfile.Controls.Add(this.txtPasswordUpdate);
            this.panelUpdateProfile.Controls.Add(this.Role);
            this.panelUpdateProfile.Controls.Add(this.label9);
            this.panelUpdateProfile.Controls.Add(this.label10);
            this.panelUpdateProfile.Controls.Add(this.txtNameUpdate);
            this.panelUpdateProfile.Location = new System.Drawing.Point(67, 95);
            this.panelUpdateProfile.Name = "panelUpdateProfile";
            this.panelUpdateProfile.Size = new System.Drawing.Size(546, 555);
            this.panelUpdateProfile.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.labelStatusError);
            this.panel7.Location = new System.Drawing.Point(188, 473);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(261, 29);
            this.panel7.TabIndex = 6;
            // 
            // labelStatusError
            // 
            this.labelStatusError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStatusError.ForeColor = System.Drawing.Color.Red;
            this.labelStatusError.Location = new System.Drawing.Point(0, 0);
            this.labelStatusError.Name = "labelStatusError";
            this.labelStatusError.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelStatusError.Size = new System.Drawing.Size(261, 29);
            this.labelStatusError.TabIndex = 7;
            this.labelStatusError.Text = "label16";
            this.labelStatusError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelStatusError.Visible = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.labelRoleError);
            this.panel6.Location = new System.Drawing.Point(188, 406);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(261, 29);
            this.panel6.TabIndex = 6;
            // 
            // labelRoleError
            // 
            this.labelRoleError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRoleError.ForeColor = System.Drawing.Color.Red;
            this.labelRoleError.Location = new System.Drawing.Point(0, 0);
            this.labelRoleError.Name = "labelRoleError";
            this.labelRoleError.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelRoleError.Size = new System.Drawing.Size(261, 29);
            this.labelRoleError.TabIndex = 7;
            this.labelRoleError.Text = "label15";
            this.labelRoleError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelRoleError.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.labelGenderError);
            this.panel5.Location = new System.Drawing.Point(188, 339);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(261, 26);
            this.panel5.TabIndex = 6;
            // 
            // labelGenderError
            // 
            this.labelGenderError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGenderError.ForeColor = System.Drawing.Color.Red;
            this.labelGenderError.Location = new System.Drawing.Point(0, 0);
            this.labelGenderError.Name = "labelGenderError";
            this.labelGenderError.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelGenderError.Size = new System.Drawing.Size(261, 26);
            this.labelGenderError.TabIndex = 7;
            this.labelGenderError.Text = "label14";
            this.labelGenderError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelGenderError.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelNameError);
            this.panel4.Location = new System.Drawing.Point(93, 270);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(356, 29);
            this.panel4.TabIndex = 6;
            // 
            // labelNameError
            // 
            this.labelNameError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNameError.ForeColor = System.Drawing.Color.Red;
            this.labelNameError.Location = new System.Drawing.Point(0, 0);
            this.labelNameError.Name = "labelNameError";
            this.labelNameError.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelNameError.Size = new System.Drawing.Size(356, 29);
            this.labelNameError.TabIndex = 7;
            this.labelNameError.Text = "label13";
            this.labelNameError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelNameError.Visible = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.labelPasswordError);
            this.panel8.Location = new System.Drawing.Point(188, 131);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(261, 29);
            this.panel8.TabIndex = 6;
            // 
            // labelPasswordError
            // 
            this.labelPasswordError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPasswordError.ForeColor = System.Drawing.Color.Red;
            this.labelPasswordError.Location = new System.Drawing.Point(0, 0);
            this.labelPasswordError.Name = "labelPasswordError";
            this.labelPasswordError.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPasswordError.Size = new System.Drawing.Size(261, 29);
            this.labelPasswordError.TabIndex = 6;
            this.labelPasswordError.Text = "label8";
            this.labelPasswordError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelPasswordError.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelCofirmError);
            this.panel3.Location = new System.Drawing.Point(93, 202);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 29);
            this.panel3.TabIndex = 6;
            // 
            // labelCofirmError
            // 
            this.labelCofirmError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCofirmError.ForeColor = System.Drawing.Color.Red;
            this.labelCofirmError.Location = new System.Drawing.Point(0, 0);
            this.labelCofirmError.Name = "labelCofirmError";
            this.labelCofirmError.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCofirmError.Size = new System.Drawing.Size(356, 29);
            this.labelCofirmError.TabIndex = 7;
            this.labelCofirmError.Text = "label12";
            this.labelCofirmError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelCofirmError.Visible = false;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.labelUsernameError);
            this.panel2.Location = new System.Drawing.Point(188, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 30);
            this.panel2.TabIndex = 5;
            // 
            // txtConfirmUpdate
            // 
            this.txtConfirmUpdate.Location = new System.Drawing.Point(188, 169);
            this.txtConfirmUpdate.Name = "txtConfirmUpdate";
            this.txtConfirmUpdate.PasswordChar = '*';
            this.txtConfirmUpdate.PlaceholderText = "Enter confirm password";
            this.txtConfirmUpdate.Size = new System.Drawing.Size(261, 27);
            this.txtConfirmUpdate.TabIndex = 1;
            // 
            // cboGenderUpdate
            // 
            this.cboGenderUpdate.FormattingEnabled = true;
            this.cboGenderUpdate.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cboGenderUpdate.Location = new System.Drawing.Point(188, 305);
            this.cboGenderUpdate.Name = "cboGenderUpdate";
            this.cboGenderUpdate.Size = new System.Drawing.Size(261, 28);
            this.cboGenderUpdate.TabIndex = 4;
            // 
            // cboStatusUpdate
            // 
            this.cboStatusUpdate.Enabled = false;
            this.cboStatusUpdate.FormattingEnabled = true;
            this.cboStatusUpdate.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cboStatusUpdate.Location = new System.Drawing.Point(188, 441);
            this.cboStatusUpdate.Name = "cboStatusUpdate";
            this.cboStatusUpdate.Size = new System.Drawing.Size(261, 28);
            this.cboStatusUpdate.TabIndex = 4;
            // 
            // cboRoleUpdate
            // 
            this.cboRoleUpdate.Enabled = false;
            this.cboRoleUpdate.FormattingEnabled = true;
            this.cboRoleUpdate.Items.AddRange(new object[] {
            "Admin",
            "Staff",
            "Doctor"});
            this.cboRoleUpdate.Location = new System.Drawing.Point(188, 372);
            this.cboRoleUpdate.Name = "cboRoleUpdate";
            this.cboRoleUpdate.Size = new System.Drawing.Size(261, 28);
            this.cboRoleUpdate.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "User name";
            // 
            // txtUsernameUpdate
            // 
            this.txtUsernameUpdate.Location = new System.Drawing.Point(188, 33);
            this.txtUsernameUpdate.Name = "txtUsernameUpdate";
            this.txtUsernameUpdate.PlaceholderText = "Enter username";
            this.txtUsernameUpdate.Size = new System.Drawing.Size(261, 27);
            this.txtUsernameUpdate.TabIndex = 1;
            // 
            // btnCloseUpdate
            // 
            this.btnCloseUpdate.Location = new System.Drawing.Point(355, 508);
            this.btnCloseUpdate.Name = "btnCloseUpdate";
            this.btnCloseUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnCloseUpdate.TabIndex = 2;
            this.btnCloseUpdate.Text = "Close";
            this.btnCloseUpdate.UseVisualStyleBackColor = true;
            this.btnCloseUpdate.Click += new System.EventHandler(this.btnCloseUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Password";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(188, 508);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Gender";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(93, 444);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Status";
            // 
            // txtPasswordUpdate
            // 
            this.txtPasswordUpdate.Location = new System.Drawing.Point(188, 98);
            this.txtPasswordUpdate.Name = "txtPasswordUpdate";
            this.txtPasswordUpdate.PasswordChar = '*';
            this.txtPasswordUpdate.PlaceholderText = "Enter password";
            this.txtPasswordUpdate.Size = new System.Drawing.Size(261, 27);
            this.txtPasswordUpdate.TabIndex = 1;
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.Location = new System.Drawing.Point(93, 372);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(39, 20);
            this.Role.TabIndex = 0;
            this.Role.Text = "Role";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(93, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Confirm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(93, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Name";
            // 
            // txtNameUpdate
            // 
            this.txtNameUpdate.Location = new System.Drawing.Point(188, 237);
            this.txtNameUpdate.Name = "txtNameUpdate";
            this.txtNameUpdate.PlaceholderText = "Enter name";
            this.txtNameUpdate.Size = new System.Drawing.Size(261, 27);
            this.txtNameUpdate.TabIndex = 1;
            // 
            // frmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(701, 662);
            this.Controls.Add(this.panelUpdateProfile);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelProfile);
            this.Name = "frmProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile ";
            this.Load += new System.EventHandler(this.frmProfile_Load);
            this.panel1.ResumeLayout(false);
            this.panelProfile.ResumeLayout(false);
            this.panelProfile.PerformLayout();
            this.panelUpdateProfile.ResumeLayout(false);
            this.panelUpdateProfile.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnLogout;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.Panel panelUpdateProfile;
        private System.Windows.Forms.TextBox txtConfirmUpdate;
        private System.Windows.Forms.ComboBox cboRoleUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUsernameUpdate;
        private System.Windows.Forms.Button btnCloseUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPasswordUpdate;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNameUpdate;
        private System.Windows.Forms.ComboBox cboGenderUpdate;
        private System.Windows.Forms.ComboBox cboStatusUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelUsernameError;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label labelStatusError;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label labelRoleError;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelGenderError;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelNameError;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label labelPasswordError;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelCofirmError;
        private System.Windows.Forms.Button button1;
    }
}