namespace FinTrustApp.PresentationLayer
{
    partial class FinTrust_Registration
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
            this.components = new System.ComponentModel.Container();
            this.labellRegistrationHead = new System.Windows.Forms.Label();
            this.panelRegistration = new System.Windows.Forms.Panel();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.comboBoxDesignation = new System.Windows.Forms.ComboBox();
            this.radioButtonEmployeeFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonEmployeeMale = new System.Windows.Forms.RadioButton();
            this.dateTimePickerEmployeeDOB = new System.Windows.Forms.DateTimePicker();
            this.textBoxtEmployeePAN = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeAadhar = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeAddress = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeEmail = new System.Windows.Forms.TextBox();
            this.textBoxEmployeePhone = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeID = new System.Windows.Forms.TextBox();
            this.labelEmployeePan = new System.Windows.Forms.Label();
            this.labelEmployeeAadhar = new System.Windows.Forms.Label();
            this.labelEmployeeAddress = new System.Windows.Forms.Label();
            this.labelEmployeeEmail = new System.Windows.Forms.Label();
            this.labelEmployeePhone = new System.Windows.Forms.Label();
            this.labelDesignation = new System.Windows.Forms.Label();
            this.labelEmployeeGender = new System.Windows.Forms.Label();
            this.labelEmployeeDOB = new System.Windows.Forms.Label();
            this.labelEmployeeName = new System.Windows.Forms.Label();
            this.labelEmployeeID = new System.Windows.Forms.Label();
            this.labelUserRegistrtionMessage = new System.Windows.Forms.Label();
            this.errorProviderUserRegistration = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserRegistration)).BeginInit();
            this.SuspendLayout();
            // 
            // labellRegistrationHead
            // 
            this.labellRegistrationHead.AutoSize = true;
            this.labellRegistrationHead.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellRegistrationHead.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labellRegistrationHead.Location = new System.Drawing.Point(375, 0);
            this.labellRegistrationHead.Name = "labellRegistrationHead";
            this.labellRegistrationHead.Size = new System.Drawing.Size(218, 29);
            this.labellRegistrationHead.TabIndex = 1;
            this.labellRegistrationHead.Text = "Registration Form";
            // 
            // panelRegistration
            // 
            this.panelRegistration.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelRegistration.Controls.Add(this.buttonRegister);
            this.panelRegistration.Controls.Add(this.comboBoxDesignation);
            this.panelRegistration.Controls.Add(this.radioButtonEmployeeFemale);
            this.panelRegistration.Controls.Add(this.radioButtonEmployeeMale);
            this.panelRegistration.Controls.Add(this.dateTimePickerEmployeeDOB);
            this.panelRegistration.Controls.Add(this.textBoxtEmployeePAN);
            this.panelRegistration.Controls.Add(this.textBoxEmployeeAadhar);
            this.panelRegistration.Controls.Add(this.textBoxEmployeeAddress);
            this.panelRegistration.Controls.Add(this.textBoxEmployeeEmail);
            this.panelRegistration.Controls.Add(this.textBoxEmployeePhone);
            this.panelRegistration.Controls.Add(this.textBoxEmployeeName);
            this.panelRegistration.Controls.Add(this.textBoxEmployeeID);
            this.panelRegistration.Controls.Add(this.labelEmployeePan);
            this.panelRegistration.Controls.Add(this.labelEmployeeAadhar);
            this.panelRegistration.Controls.Add(this.labelEmployeeAddress);
            this.panelRegistration.Controls.Add(this.labelEmployeeEmail);
            this.panelRegistration.Controls.Add(this.labelEmployeePhone);
            this.panelRegistration.Controls.Add(this.labelDesignation);
            this.panelRegistration.Controls.Add(this.labelEmployeeGender);
            this.panelRegistration.Controls.Add(this.labelEmployeeDOB);
            this.panelRegistration.Controls.Add(this.labelEmployeeName);
            this.panelRegistration.Controls.Add(this.labelEmployeeID);
            this.panelRegistration.Location = new System.Drawing.Point(92, 47);
            this.panelRegistration.Name = "panelRegistration";
            this.panelRegistration.Size = new System.Drawing.Size(791, 614);
            this.panelRegistration.TabIndex = 2;
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRegister.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRegister.Location = new System.Drawing.Point(310, 558);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(198, 44);
            this.buttonRegister.TabIndex = 43;
            this.buttonRegister.Text = "REGISTER";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // comboBoxDesignation
            // 
            this.comboBoxDesignation.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDesignation.FormattingEnabled = true;
            this.comboBoxDesignation.Items.AddRange(new object[] {
            "Cashier",
            "Clerk",
            "Probationary Officer"});
            this.comboBoxDesignation.Location = new System.Drawing.Point(401, 200);
            this.comboBoxDesignation.Name = "comboBoxDesignation";
            this.comboBoxDesignation.Size = new System.Drawing.Size(234, 26);
            this.comboBoxDesignation.TabIndex = 42;
            this.comboBoxDesignation.Text = "           - - - Select - - -";
            this.comboBoxDesignation.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxDesignation_Validating);
            // 
            // radioButtonEmployeeFemale
            // 
            this.radioButtonEmployeeFemale.AutoSize = true;
            this.radioButtonEmployeeFemale.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEmployeeFemale.Location = new System.Drawing.Point(541, 159);
            this.radioButtonEmployeeFemale.Name = "radioButtonEmployeeFemale";
            this.radioButtonEmployeeFemale.Size = new System.Drawing.Size(72, 22);
            this.radioButtonEmployeeFemale.TabIndex = 41;
            this.radioButtonEmployeeFemale.TabStop = true;
            this.radioButtonEmployeeFemale.Text = "Female";
            this.radioButtonEmployeeFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonEmployeeMale
            // 
            this.radioButtonEmployeeMale.AutoSize = true;
            this.radioButtonEmployeeMale.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEmployeeMale.Location = new System.Drawing.Point(401, 159);
            this.radioButtonEmployeeMale.Name = "radioButtonEmployeeMale";
            this.radioButtonEmployeeMale.Size = new System.Drawing.Size(58, 22);
            this.radioButtonEmployeeMale.TabIndex = 40;
            this.radioButtonEmployeeMale.TabStop = true;
            this.radioButtonEmployeeMale.Text = "Male";
            this.radioButtonEmployeeMale.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerEmployeeDOB
            // 
            this.dateTimePickerEmployeeDOB.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEmployeeDOB.Location = new System.Drawing.Point(401, 110);
            this.dateTimePickerEmployeeDOB.Name = "dateTimePickerEmployeeDOB";
            this.dateTimePickerEmployeeDOB.Size = new System.Drawing.Size(234, 25);
            this.dateTimePickerEmployeeDOB.TabIndex = 39;
            this.dateTimePickerEmployeeDOB.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePickerEmployeeDOB_Validating);
            // 
            // textBoxtEmployeePAN
            // 
            this.textBoxtEmployeePAN.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxtEmployeePAN.Location = new System.Drawing.Point(401, 512);
            this.textBoxtEmployeePAN.Name = "textBoxtEmployeePAN";
            this.textBoxtEmployeePAN.Size = new System.Drawing.Size(234, 25);
            this.textBoxtEmployeePAN.TabIndex = 38;
            this.textBoxtEmployeePAN.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxtEmployeePAN_Validating);
            // 
            // textBoxEmployeeAadhar
            // 
            this.textBoxEmployeeAadhar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmployeeAadhar.Location = new System.Drawing.Point(401, 463);
            this.textBoxEmployeeAadhar.Name = "textBoxEmployeeAadhar";
            this.textBoxEmployeeAadhar.Size = new System.Drawing.Size(234, 25);
            this.textBoxEmployeeAadhar.TabIndex = 37;
            this.textBoxEmployeeAadhar.TextChanged += new System.EventHandler(this.textBoxEmployeeAadhar_TextChanged);
            this.textBoxEmployeeAadhar.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmployeeAadhar_Validating);
            // 
            // textBoxEmployeeAddress
            // 
            this.textBoxEmployeeAddress.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmployeeAddress.Location = new System.Drawing.Point(401, 347);
            this.textBoxEmployeeAddress.Multiline = true;
            this.textBoxEmployeeAddress.Name = "textBoxEmployeeAddress";
            this.textBoxEmployeeAddress.Size = new System.Drawing.Size(234, 91);
            this.textBoxEmployeeAddress.TabIndex = 36;
            this.textBoxEmployeeAddress.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmployeeAddress_Validating);
            // 
            // textBoxEmployeeEmail
            // 
            this.textBoxEmployeeEmail.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmployeeEmail.Location = new System.Drawing.Point(401, 298);
            this.textBoxEmployeeEmail.Name = "textBoxEmployeeEmail";
            this.textBoxEmployeeEmail.Size = new System.Drawing.Size(234, 25);
            this.textBoxEmployeeEmail.TabIndex = 35;
            this.textBoxEmployeeEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmployeeEmail_Validating);
            // 
            // textBoxEmployeePhone
            // 
            this.textBoxEmployeePhone.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmployeePhone.Location = new System.Drawing.Point(401, 251);
            this.textBoxEmployeePhone.Name = "textBoxEmployeePhone";
            this.textBoxEmployeePhone.Size = new System.Drawing.Size(234, 25);
            this.textBoxEmployeePhone.TabIndex = 34;
            this.textBoxEmployeePhone.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmployeePhone_Validating);
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmployeeName.Location = new System.Drawing.Point(401, 63);
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.Size = new System.Drawing.Size(234, 25);
            this.textBoxEmployeeName.TabIndex = 33;
            this.textBoxEmployeeName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmployeeName_Validating);
            // 
            // textBoxEmployeeID
            // 
            this.textBoxEmployeeID.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmployeeID.Location = new System.Drawing.Point(401, 16);
            this.textBoxEmployeeID.Name = "textBoxEmployeeID";
            this.textBoxEmployeeID.Size = new System.Drawing.Size(234, 25);
            this.textBoxEmployeeID.TabIndex = 32;
            this.textBoxEmployeeID.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmployeeID_Validating);
            // 
            // labelEmployeePan
            // 
            this.labelEmployeePan.AutoSize = true;
            this.labelEmployeePan.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeePan.Location = new System.Drawing.Point(178, 514);
            this.labelEmployeePan.Name = "labelEmployeePan";
            this.labelEmployeePan.Size = new System.Drawing.Size(90, 18);
            this.labelEmployeePan.TabIndex = 31;
            this.labelEmployeePan.Text = "Pan Number";
            // 
            // labelEmployeeAadhar
            // 
            this.labelEmployeeAadhar.AutoSize = true;
            this.labelEmployeeAadhar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeAadhar.Location = new System.Drawing.Point(178, 465);
            this.labelEmployeeAadhar.Name = "labelEmployeeAadhar";
            this.labelEmployeeAadhar.Size = new System.Drawing.Size(112, 18);
            this.labelEmployeeAadhar.TabIndex = 30;
            this.labelEmployeeAadhar.Text = "Aadhar Number";
            // 
            // labelEmployeeAddress
            // 
            this.labelEmployeeAddress.AutoSize = true;
            this.labelEmployeeAddress.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeAddress.Location = new System.Drawing.Point(178, 347);
            this.labelEmployeeAddress.Name = "labelEmployeeAddress";
            this.labelEmployeeAddress.Size = new System.Drawing.Size(59, 18);
            this.labelEmployeeAddress.TabIndex = 29;
            this.labelEmployeeAddress.Text = "Address";
            // 
            // labelEmployeeEmail
            // 
            this.labelEmployeeEmail.AutoSize = true;
            this.labelEmployeeEmail.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeEmail.Location = new System.Drawing.Point(178, 300);
            this.labelEmployeeEmail.Name = "labelEmployeeEmail";
            this.labelEmployeeEmail.Size = new System.Drawing.Size(48, 18);
            this.labelEmployeeEmail.TabIndex = 28;
            this.labelEmployeeEmail.Text = "Email";
            // 
            // labelEmployeePhone
            // 
            this.labelEmployeePhone.AutoSize = true;
            this.labelEmployeePhone.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeePhone.Location = new System.Drawing.Point(178, 253);
            this.labelEmployeePhone.Name = "labelEmployeePhone";
            this.labelEmployeePhone.Size = new System.Drawing.Size(49, 18);
            this.labelEmployeePhone.TabIndex = 27;
            this.labelEmployeePhone.Text = "Phone";
            // 
            // labelDesignation
            // 
            this.labelDesignation.AutoSize = true;
            this.labelDesignation.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesignation.Location = new System.Drawing.Point(178, 206);
            this.labelDesignation.Name = "labelDesignation";
            this.labelDesignation.Size = new System.Drawing.Size(86, 18);
            this.labelDesignation.TabIndex = 26;
            this.labelDesignation.Text = "Designation";
            // 
            // labelEmployeeGender
            // 
            this.labelEmployeeGender.AutoSize = true;
            this.labelEmployeeGender.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeGender.Location = new System.Drawing.Point(178, 159);
            this.labelEmployeeGender.Name = "labelEmployeeGender";
            this.labelEmployeeGender.Size = new System.Drawing.Size(54, 18);
            this.labelEmployeeGender.TabIndex = 25;
            this.labelEmployeeGender.Text = "Gender";
            // 
            // labelEmployeeDOB
            // 
            this.labelEmployeeDOB.AutoSize = true;
            this.labelEmployeeDOB.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeDOB.Location = new System.Drawing.Point(178, 112);
            this.labelEmployeeDOB.Name = "labelEmployeeDOB";
            this.labelEmployeeDOB.Size = new System.Drawing.Size(97, 18);
            this.labelEmployeeDOB.TabIndex = 24;
            this.labelEmployeeDOB.Text = "Date of Birth";
            // 
            // labelEmployeeName
            // 
            this.labelEmployeeName.AutoSize = true;
            this.labelEmployeeName.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeName.Location = new System.Drawing.Point(178, 65);
            this.labelEmployeeName.Name = "labelEmployeeName";
            this.labelEmployeeName.Size = new System.Drawing.Size(111, 18);
            this.labelEmployeeName.TabIndex = 23;
            this.labelEmployeeName.Text = "Employee Name";
            // 
            // labelEmployeeID
            // 
            this.labelEmployeeID.AutoSize = true;
            this.labelEmployeeID.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeID.Location = new System.Drawing.Point(178, 18);
            this.labelEmployeeID.Name = "labelEmployeeID";
            this.labelEmployeeID.Size = new System.Drawing.Size(94, 18);
            this.labelEmployeeID.TabIndex = 22;
            this.labelEmployeeID.Text = "Employee ID";
            // 
            // labelUserRegistrtionMessage
            // 
            this.labelUserRegistrtionMessage.AutoSize = true;
            this.labelUserRegistrtionMessage.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserRegistrtionMessage.ForeColor = System.Drawing.Color.Maroon;
            this.labelUserRegistrtionMessage.Location = new System.Drawing.Point(445, 28);
            this.labelUserRegistrtionMessage.Name = "labelUserRegistrtionMessage";
            this.labelUserRegistrtionMessage.Size = new System.Drawing.Size(0, 14);
            this.labelUserRegistrtionMessage.TabIndex = 3;
            // 
            // errorProviderUserRegistration
            // 
            this.errorProviderUserRegistration.ContainerControl = this;
            // 
            // FinTrust_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.labelUserRegistrtionMessage);
            this.Controls.Add(this.labellRegistrationHead);
            this.Controls.Add(this.panelRegistration);
            this.Name = "FinTrust_Registration";
            this.Text = "FinTrust_Registration";
            this.panelRegistration.ResumeLayout(false);
            this.panelRegistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserRegistration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labellRegistrationHead;
        private System.Windows.Forms.Panel panelRegistration;
        private System.Windows.Forms.ComboBox comboBoxDesignation;
        private System.Windows.Forms.RadioButton radioButtonEmployeeFemale;
        private System.Windows.Forms.RadioButton radioButtonEmployeeMale;
        private System.Windows.Forms.DateTimePicker dateTimePickerEmployeeDOB;
        private System.Windows.Forms.TextBox textBoxtEmployeePAN;
        private System.Windows.Forms.TextBox textBoxEmployeeAadhar;
        private System.Windows.Forms.TextBox textBoxEmployeeAddress;
        private System.Windows.Forms.TextBox textBoxEmployeeEmail;
        private System.Windows.Forms.TextBox textBoxEmployeePhone;
        private System.Windows.Forms.TextBox textBoxEmployeeName;
        private System.Windows.Forms.TextBox textBoxEmployeeID;
        private System.Windows.Forms.Label labelEmployeePan;
        private System.Windows.Forms.Label labelEmployeeAadhar;
        private System.Windows.Forms.Label labelEmployeeAddress;
        private System.Windows.Forms.Label labelEmployeeEmail;
        private System.Windows.Forms.Label labelEmployeePhone;
        private System.Windows.Forms.Label labelDesignation;
        private System.Windows.Forms.Label labelEmployeeGender;
        private System.Windows.Forms.Label labelEmployeeDOB;
        private System.Windows.Forms.Label labelEmployeeName;
        private System.Windows.Forms.Label labelEmployeeID;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label labelUserRegistrtionMessage;
        public System.Windows.Forms.ErrorProvider errorProviderUserRegistration;
    }
}