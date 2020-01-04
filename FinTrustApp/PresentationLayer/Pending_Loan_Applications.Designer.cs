namespace FinTrustApp.PresentationLayer
{
    partial class Pending_Loan_Applications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pending_Loan_Applications));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.labelloanpage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.customerDetailsPanel = new System.Windows.Forms.Panel();
            this.textBoxLoanType = new System.Windows.Forms.TextBox();
            this.textBoxAccountNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxRateofInterest = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelname = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxLoanId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.textBoxTerm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxGuarantor = new System.Windows.Forms.TextBox();
            this.textBoxLoanAmount = new System.Windows.Forms.TextBox();
            this.textBoxCustomerId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelcustomerID = new System.Windows.Forms.Label();
            this.labelloantype = new System.Windows.Forms.Label();
            this.checkBoxCollaterals = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.dgvLoanApplications = new System.Windows.Forms.DataGridView();
            this.lblLoanHeading = new System.Windows.Forms.Label();
            this.lblLoanMessage = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.customerDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanApplications)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.labelloanpage);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 46);
            this.panel2.TabIndex = 21;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(30, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 32);
            this.btnBack.TabIndex = 33;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // labelloanpage
            // 
            this.labelloanpage.AutoSize = true;
            this.labelloanpage.BackColor = System.Drawing.Color.SteelBlue;
            this.labelloanpage.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelloanpage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelloanpage.Location = new System.Drawing.Point(379, 5);
            this.labelloanpage.Name = "labelloanpage";
            this.labelloanpage.Size = new System.Drawing.Size(231, 31);
            this.labelloanpage.TabIndex = 3;
            this.labelloanpage.Text = "Loan Applications";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Search By";
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.FormattingEnabled = true;
            this.comboBoxSearchBy.Items.AddRange(new object[] {
            "Loan ID",
            "Loan Type",
            "Customer ID",
            "Status"});
            this.comboBoxSearchBy.Location = new System.Drawing.Point(152, 13);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(287, 21);
            this.comboBoxSearchBy.TabIndex = 23;
            this.comboBoxSearchBy.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchBy_SelectedIndexChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(152, 63);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(287, 20);
            this.textBoxSearch.TabIndex = 24;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.comboBoxSearchBy);
            this.panel1.Location = new System.Drawing.Point(31, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 94);
            this.panel1.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.customerDetailsPanel);
            this.panel3.Location = new System.Drawing.Point(522, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(436, 437);
            this.panel3.TabIndex = 25;
            // 
            // customerDetailsPanel
            // 
            this.customerDetailsPanel.BackColor = System.Drawing.Color.White;
            this.customerDetailsPanel.Controls.Add(this.textBoxLoanType);
            this.customerDetailsPanel.Controls.Add(this.textBoxAccountNumber);
            this.customerDetailsPanel.Controls.Add(this.label11);
            this.customerDetailsPanel.Controls.Add(this.textBoxAddress);
            this.customerDetailsPanel.Controls.Add(this.label9);
            this.customerDetailsPanel.Controls.Add(this.textBoxDate);
            this.customerDetailsPanel.Controls.Add(this.label8);
            this.customerDetailsPanel.Controls.Add(this.textBoxRateofInterest);
            this.customerDetailsPanel.Controls.Add(this.textBoxName);
            this.customerDetailsPanel.Controls.Add(this.labelname);
            this.customerDetailsPanel.Controls.Add(this.label7);
            this.customerDetailsPanel.Controls.Add(this.textBoxLoanId);
            this.customerDetailsPanel.Controls.Add(this.label6);
            this.customerDetailsPanel.Controls.Add(this.txtTerm);
            this.customerDetailsPanel.Controls.Add(this.textBoxTerm);
            this.customerDetailsPanel.Controls.Add(this.label4);
            this.customerDetailsPanel.Controls.Add(this.textBoxGuarantor);
            this.customerDetailsPanel.Controls.Add(this.textBoxLoanAmount);
            this.customerDetailsPanel.Controls.Add(this.textBoxCustomerId);
            this.customerDetailsPanel.Controls.Add(this.label3);
            this.customerDetailsPanel.Controls.Add(this.label1);
            this.customerDetailsPanel.Controls.Add(this.label5);
            this.customerDetailsPanel.Controls.Add(this.labelcustomerID);
            this.customerDetailsPanel.Controls.Add(this.labelloantype);
            this.customerDetailsPanel.Location = new System.Drawing.Point(3, 3);
            this.customerDetailsPanel.Name = "customerDetailsPanel";
            this.customerDetailsPanel.Size = new System.Drawing.Size(433, 434);
            this.customerDetailsPanel.TabIndex = 27;
            // 
            // textBoxLoanType
            // 
            this.textBoxLoanType.Location = new System.Drawing.Point(80, 117);
            this.textBoxLoanType.Name = "textBoxLoanType";
            this.textBoxLoanType.Size = new System.Drawing.Size(128, 20);
            this.textBoxLoanType.TabIndex = 31;
            // 
            // textBoxAccountNumber
            // 
            this.textBoxAccountNumber.Location = new System.Drawing.Point(99, 294);
            this.textBoxAccountNumber.Name = "textBoxAccountNumber";
            this.textBoxAccountNumber.Size = new System.Drawing.Size(320, 20);
            this.textBoxAccountNumber.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 252);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 18);
            this.label11.TabIndex = 29;
            this.label11.Text = "Date";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(80, 343);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(339, 75);
            this.textBoxAddress.TabIndex = 28;
            this.textBoxAddress.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 18);
            this.label9.TabIndex = 27;
            this.label9.Text = "Address";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(99, 253);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(320, 20);
            this.textBoxDate.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = "Acc No";
            // 
            // textBoxRateofInterest
            // 
            this.textBoxRateofInterest.Location = new System.Drawing.Point(319, 213);
            this.textBoxRateofInterest.Name = "textBoxRateofInterest";
            this.textBoxRateofInterest.Size = new System.Drawing.Size(100, 20);
            this.textBoxRateofInterest.TabIndex = 24;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(291, 15);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(128, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.Location = new System.Drawing.Point(223, 13);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(44, 18);
            this.labelname.TabIndex = 0;
            this.labelname.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(195, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Rate Of Interest";
            // 
            // textBoxLoanId
            // 
            this.textBoxLoanId.Location = new System.Drawing.Point(332, 118);
            this.textBoxLoanId.Name = "textBoxLoanId";
            this.textBoxLoanId.Size = new System.Drawing.Size(87, 20);
            this.textBoxLoanId.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(245, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Loan ID";
            // 
            // txtTerm
            // 
            this.txtTerm.Location = new System.Drawing.Point(137, 212);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(45, 20);
            this.txtTerm.TabIndex = 20;
            // 
            // textBoxTerm
            // 
            this.textBoxTerm.Location = new System.Drawing.Point(490, 135);
            this.textBoxTerm.Name = "textBoxTerm";
            this.textBoxTerm.Size = new System.Drawing.Size(82, 20);
            this.textBoxTerm.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Term (months)";
            // 
            // textBoxGuarantor
            // 
            this.textBoxGuarantor.Location = new System.Drawing.Point(137, 163);
            this.textBoxGuarantor.Name = "textBoxGuarantor";
            this.textBoxGuarantor.Size = new System.Drawing.Size(282, 20);
            this.textBoxGuarantor.TabIndex = 13;
            // 
            // textBoxLoanAmount
            // 
            this.textBoxLoanAmount.Location = new System.Drawing.Point(147, 61);
            this.textBoxLoanAmount.Name = "textBoxLoanAmount";
            this.textBoxLoanAmount.Size = new System.Drawing.Size(237, 20);
            this.textBoxLoanAmount.TabIndex = 12;
            // 
            // textBoxCustomerId
            // 
            this.textBoxCustomerId.Location = new System.Drawing.Point(109, 15);
            this.textBoxCustomerId.Name = "textBoxCustomerId";
            this.textBoxCustomerId.Size = new System.Drawing.Size(103, 20);
            this.textBoxCustomerId.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Guarantor Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Requested Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(245, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 5;
            // 
            // labelcustomerID
            // 
            this.labelcustomerID.AutoSize = true;
            this.labelcustomerID.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcustomerID.Location = new System.Drawing.Point(12, 14);
            this.labelcustomerID.Name = "labelcustomerID";
            this.labelcustomerID.Size = new System.Drawing.Size(91, 18);
            this.labelcustomerID.TabIndex = 4;
            this.labelcustomerID.Text = "Customer ID";
            // 
            // labelloantype
            // 
            this.labelloantype.AutoSize = true;
            this.labelloantype.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelloantype.Location = new System.Drawing.Point(12, 116);
            this.labelloantype.Name = "labelloantype";
            this.labelloantype.Size = new System.Drawing.Size(44, 18);
            this.labelloantype.TabIndex = 1;
            this.labelloantype.Text = " Type";
            // 
            // checkBoxCollaterals
            // 
            this.checkBoxCollaterals.AutoSize = true;
            this.checkBoxCollaterals.BackColor = System.Drawing.Color.AliceBlue;
            this.checkBoxCollaterals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBoxCollaterals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxCollaterals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxCollaterals.Location = new System.Drawing.Point(945, 558);
            this.checkBoxCollaterals.Name = "checkBoxCollaterals";
            this.checkBoxCollaterals.Size = new System.Drawing.Size(13, 12);
            this.checkBoxCollaterals.TabIndex = 19;
            this.checkBoxCollaterals.UseVisualStyleBackColor = false;
            this.checkBoxCollaterals.CheckedChanged += new System.EventHandler(this.checkBoxCollaterals_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(522, 552);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 18);
            this.label10.TabIndex = 29;
            this.label10.Text = "Collaterals Verified";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(522, 610);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(192, 18);
            this.lblStatus.TabIndex = 30;
            this.lblStatus.Text = "Application Approval Status";
            this.lblStatus.Visible = false;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(745, 611);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(213, 21);
            this.comboBoxStatus.TabIndex = 31;
            this.comboBoxStatus.Visible = false;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            // 
            // dgvLoanApplications
            // 
            this.dgvLoanApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoanApplications.Location = new System.Drawing.Point(31, 228);
            this.dgvLoanApplications.Name = "dgvLoanApplications";
            this.dgvLoanApplications.Size = new System.Drawing.Size(463, 377);
            this.dgvLoanApplications.TabIndex = 32;
            this.dgvLoanApplications.SelectionChanged += new System.EventHandler(this.dgvLoanApplications_SelectionChanged);
            // 
            // lblLoanHeading
            // 
            this.lblLoanHeading.AutoSize = true;
            this.lblLoanHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanHeading.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblLoanHeading.Location = new System.Drawing.Point(125, 196);
            this.lblLoanHeading.Name = "lblLoanHeading";
            this.lblLoanHeading.Size = new System.Drawing.Size(270, 24);
            this.lblLoanHeading.TabIndex = 33;
            this.lblLoanHeading.Text = "Received Loan Applications";
            // 
            // lblLoanMessage
            // 
            this.lblLoanMessage.AutoSize = true;
            this.lblLoanMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanMessage.ForeColor = System.Drawing.Color.Green;
            this.lblLoanMessage.Location = new System.Drawing.Point(180, 171);
            this.lblLoanMessage.Name = "lblLoanMessage";
            this.lblLoanMessage.Size = new System.Drawing.Size(0, 18);
            this.lblLoanMessage.TabIndex = 34;
            // 
            // Pending_Loan_Applications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.lblLoanMessage);
            this.Controls.Add(this.lblLoanHeading);
            this.Controls.Add(this.dgvLoanApplications);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.checkBoxCollaterals);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Pending_Loan_Applications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Applications - FinTrust";
            this.Load += new System.EventHandler(this.Pending_Loan_Applications_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.customerDetailsPanel.ResumeLayout(false);
            this.customerDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanApplications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelloanpage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel customerDetailsPanel;
        private System.Windows.Forms.CheckBox checkBoxCollaterals;
        private System.Windows.Forms.TextBox textBoxTerm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxGuarantor;
        private System.Windows.Forms.TextBox textBoxLoanAmount;
        private System.Windows.Forms.TextBox textBoxCustomerId;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelcustomerID;
        private System.Windows.Forms.Label labelloantype;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.TextBox textBoxRateofInterest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxLoanId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLoanType;
        private System.Windows.Forms.TextBox textBoxAccountNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox textBoxAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.DataGridView dgvLoanApplications;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblLoanHeading;
        private System.Windows.Forms.Label lblLoanMessage;
    }
}