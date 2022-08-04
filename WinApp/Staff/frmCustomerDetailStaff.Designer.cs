namespace WinApp
{
    partial class frmCustomerDetailStaff
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbCustomerGender = new System.Windows.Forms.Label();
            this.lbCustomerPhone = new System.Windows.Forms.Label();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.lbCustomerlID = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.txtDateOfBirth = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDentist = new System.Windows.Forms.Label();
            this.errorName = new System.Windows.Forms.Label();
            this.errorGender = new System.Windows.Forms.Label();
            this.errorPhone = new System.Windows.Forms.Label();
            this.errorDateOfBirth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.MistyRose;
            this.btnClose.Location = new System.Drawing.Point(580, 373);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.MistyRose;
            this.btnReset.Location = new System.Drawing.Point(451, 373);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 29);
            this.btnReset.TabIndex = 24;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MistyRose;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(316, 373);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // lbCustomerGender
            // 
            this.lbCustomerGender.AutoSize = true;
            this.lbCustomerGender.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCustomerGender.Location = new System.Drawing.Point(184, 203);
            this.lbCustomerGender.Name = "lbCustomerGender";
            this.lbCustomerGender.Size = new System.Drawing.Size(60, 20);
            this.lbCustomerGender.TabIndex = 21;
            this.lbCustomerGender.Text = "Gender";
            // 
            // lbCustomerPhone
            // 
            this.lbCustomerPhone.AutoSize = true;
            this.lbCustomerPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCustomerPhone.Location = new System.Drawing.Point(184, 266);
            this.lbCustomerPhone.Name = "lbCustomerPhone";
            this.lbCustomerPhone.Size = new System.Drawing.Size(53, 20);
            this.lbCustomerPhone.TabIndex = 19;
            this.lbCustomerPhone.Text = "Phone";
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCustomerName.Location = new System.Drawing.Point(184, 135);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(51, 20);
            this.lbCustomerName.TabIndex = 17;
            this.lbCustomerName.Text = "Name";
            // 
            // lbCustomerlID
            // 
            this.lbCustomerlID.AutoSize = true;
            this.lbCustomerlID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCustomerlID.Location = new System.Drawing.Point(185, 87);
            this.lbCustomerlID.Name = "lbCustomerlID";
            this.lbCustomerlID.Size = new System.Drawing.Size(25, 20);
            this.lbCustomerlID.TabIndex = 16;
            this.lbCustomerlID.Text = "ID";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.Location = new System.Drawing.Point(291, 80);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(151, 27);
            this.txtCustomerID.TabIndex = 15;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(291, 128);
            this.txtCustomerName.MaxLength = 50;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(469, 27);
            this.txtCustomerName.TabIndex = 14;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(291, 266);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(151, 27);
            this.txtPhone.TabIndex = 26;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(291, 195);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(151, 28);
            this.cbGender.TabIndex = 27;
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Location = new System.Drawing.Point(609, 266);
            this.txtDateOfBirth.Mask = "00/00/0000";
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Size = new System.Drawing.Size(151, 27);
            this.txtDateOfBirth.TabIndex = 29;
            this.txtDateOfBirth.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(500, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Date of birth";
            // 
            // labelDentist
            // 
            this.labelDentist.AutoSize = true;
            this.labelDentist.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDentist.Location = new System.Drawing.Point(370, 18);
            this.labelDentist.Name = "labelDentist";
            this.labelDentist.Size = new System.Drawing.Size(225, 37);
            this.labelDentist.TabIndex = 30;
            this.labelDentist.Text = "Customer Detail";
            // 
            // errorName
            // 
            this.errorName.AutoSize = true;
            this.errorName.ForeColor = System.Drawing.Color.Red;
            this.errorName.Location = new System.Drawing.Point(291, 158);
            this.errorName.Name = "errorName";
            this.errorName.Size = new System.Drawing.Size(284, 20);
            this.errorName.TabIndex = 31;
            this.errorName.Text = "Length of name must from 8..50 character";
            this.errorName.Visible = false;
            // 
            // errorGender
            // 
            this.errorGender.AutoSize = true;
            this.errorGender.ForeColor = System.Drawing.Color.Red;
            this.errorGender.Location = new System.Drawing.Point(291, 226);
            this.errorGender.Name = "errorGender";
            this.errorGender.Size = new System.Drawing.Size(284, 20);
            this.errorGender.TabIndex = 31;
            this.errorGender.Text = "Length of name must from 8..50 character";
            this.errorGender.Visible = false;
            // 
            // errorPhone
            // 
            this.errorPhone.AutoSize = true;
            this.errorPhone.ForeColor = System.Drawing.Color.Red;
            this.errorPhone.Location = new System.Drawing.Point(291, 293);
            this.errorPhone.Name = "errorPhone";
            this.errorPhone.Size = new System.Drawing.Size(284, 20);
            this.errorPhone.TabIndex = 31;
            this.errorPhone.Text = "Length of name must from 8..50 character";
            this.errorPhone.Visible = false;
            // 
            // errorDateOfBirth
            // 
            this.errorDateOfBirth.AutoSize = true;
            this.errorDateOfBirth.ForeColor = System.Drawing.Color.Red;
            this.errorDateOfBirth.Location = new System.Drawing.Point(609, 293);
            this.errorDateOfBirth.Name = "errorDateOfBirth";
            this.errorDateOfBirth.Size = new System.Drawing.Size(284, 20);
            this.errorDateOfBirth.TabIndex = 31;
            this.errorDateOfBirth.Text = "Length of name must from 8..50 character";
            this.errorDateOfBirth.Visible = false;
            // 
            // frmCustomerDetailStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(947, 450);
            this.Controls.Add(this.errorDateOfBirth);
            this.Controls.Add(this.errorPhone);
            this.Controls.Add(this.errorGender);
            this.Controls.Add(this.errorName);
            this.Controls.Add(this.labelDentist);
            this.Controls.Add(this.txtDateOfBirth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbCustomerGender);
            this.Controls.Add(this.lbCustomerPhone);
            this.Controls.Add(this.lbCustomerName);
            this.Controls.Add(this.lbCustomerlID);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtCustomerName);
            this.Name = "frmCustomerDetailStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomerDetailStaff_FormClosing);
            this.Load += new System.EventHandler(this.frmCustomerDetailStaff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbCustomerGender;
        private System.Windows.Forms.Label lbCustomerPhone;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.Label lbCustomerlID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.MaskedTextBox txtDateOfBirth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDentist;
        private System.Windows.Forms.Label errorName;
        private System.Windows.Forms.Label errorGender;
        private System.Windows.Forms.Label errorPhone;
        private System.Windows.Forms.Label errorDateOfBirth;
    }
}