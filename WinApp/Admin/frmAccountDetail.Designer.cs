namespace WinApp
{
    partial class frmAccountDetail
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
            this.txtDentistName = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.cbDentistGender = new System.Windows.Forms.ComboBox();
            this.txtDentistPassword = new System.Windows.Forms.TextBox();
            this.txtDentistLoginName = new System.Windows.Forms.TextBox();
            this.txtDentistID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCofirmPassword = new System.Windows.Forms.TextBox();
            this.checkShowPassword = new System.Windows.Forms.CheckBox();
            this.checkShowConfirmPassword = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtDentistName
            // 
            this.txtDentistName.Location = new System.Drawing.Point(260, 198);
            this.txtDentistName.Name = "txtDentistName";
            this.txtDentistName.Size = new System.Drawing.Size(190, 27);
            this.txtDentistName.TabIndex = 0;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbID.Location = new System.Drawing.Point(92, 46);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(25, 20);
            this.lbID.TabIndex = 1;
            this.lbID.Text = "ID";
            // 
            // cbDentistGender
            // 
            this.cbDentistGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDentistGender.FormattingEnabled = true;
            this.cbDentistGender.Location = new System.Drawing.Point(260, 242);
            this.cbDentistGender.Name = "cbDentistGender";
            this.cbDentistGender.Size = new System.Drawing.Size(190, 28);
            this.cbDentistGender.TabIndex = 2;
            // 
            // txtDentistPassword
            // 
            this.txtDentistPassword.Location = new System.Drawing.Point(260, 125);
            this.txtDentistPassword.Name = "txtDentistPassword";
            this.txtDentistPassword.Size = new System.Drawing.Size(190, 27);
            this.txtDentistPassword.TabIndex = 5;
            // 
            // txtDentistLoginName
            // 
            this.txtDentistLoginName.Location = new System.Drawing.Point(260, 81);
            this.txtDentistLoginName.Name = "txtDentistLoginName";
            this.txtDentistLoginName.Size = new System.Drawing.Size(190, 27);
            this.txtDentistLoginName.TabIndex = 6;
            // 
            // txtDentistID
            // 
            this.txtDentistID.Location = new System.Drawing.Point(260, 43);
            this.txtDentistID.Name = "txtDentistID";
            this.txtDentistID.ReadOnly = true;
            this.txtDentistID.Size = new System.Drawing.Size(190, 27);
            this.txtDentistID.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(92, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(89, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(92, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(83, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Gender";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSave.Location = new System.Drawing.Point(107, 432);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 34);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LavenderBlush;
            this.button2.Location = new System.Drawing.Point(312, 432);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 34);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(92, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Status";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(260, 291);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(190, 28);
            this.cbStatus.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(83, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Confirm Password";
            // 
            // txtCofirmPassword
            // 
            this.txtCofirmPassword.Location = new System.Drawing.Point(260, 162);
            this.txtCofirmPassword.Name = "txtCofirmPassword";
            this.txtCofirmPassword.Size = new System.Drawing.Size(190, 27);
            this.txtCofirmPassword.TabIndex = 18;
            // 
            // checkShowPassword
            // 
            this.checkShowPassword.AutoSize = true;
            this.checkShowPassword.Location = new System.Drawing.Point(465, 131);
            this.checkShowPassword.Name = "checkShowPassword";
            this.checkShowPassword.Size = new System.Drawing.Size(67, 24);
            this.checkShowPassword.TabIndex = 20;
            this.checkShowPassword.Text = "Show";
            this.checkShowPassword.UseVisualStyleBackColor = true;
            this.checkShowPassword.CheckedChanged += new System.EventHandler(this.checkShowPassword_CheckedChanged);
            // 
            // checkShowConfirmPassword
            // 
            this.checkShowConfirmPassword.AutoSize = true;
            this.checkShowConfirmPassword.Location = new System.Drawing.Point(465, 164);
            this.checkShowConfirmPassword.Name = "checkShowConfirmPassword";
            this.checkShowConfirmPassword.Size = new System.Drawing.Size(67, 24);
            this.checkShowConfirmPassword.TabIndex = 21;
            this.checkShowConfirmPassword.Text = "Show";
            this.checkShowConfirmPassword.UseVisualStyleBackColor = true;
            this.checkShowConfirmPassword.CheckedChanged += new System.EventHandler(this.checkShowConfirmPassword_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(92, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Role";
            // 
            // cbRole
            // 
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(260, 349);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(190, 28);
            this.cbRole.TabIndex = 22;
            // 
            // frmAccountDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(561, 506);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.checkShowConfirmPassword);
            this.Controls.Add(this.checkShowPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCofirmPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDentistID);
            this.Controls.Add(this.txtDentistLoginName);
            this.Controls.Add(this.txtDentistPassword);
            this.Controls.Add(this.cbDentistGender);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.txtDentistName);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmAccountDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dentist information";
            this.Load += new System.EventHandler(this.frmDentistDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDentistName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.ComboBox cbDentistGender;
        private System.Windows.Forms.TextBox txtDentistPassword;
        private System.Windows.Forms.TextBox txtDentistLoginName;
        private System.Windows.Forms.TextBox txtDentistID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCofirmPassword;
        private System.Windows.Forms.CheckBox checkShowPassword;
        private System.Windows.Forms.CheckBox checkShowConfirmPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbRole;
    }
}