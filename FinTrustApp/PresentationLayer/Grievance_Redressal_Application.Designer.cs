namespace FinTrustApp.PresentationLayer
{
    partial class Grievance_Redressal_Application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grievance_Redressal_Application));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxGrievanceID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labeltitle = new System.Windows.Forms.Label();
            this.richTextBoxGrievance = new System.Windows.Forms.RichTextBox();
            this.checkBoxDeclerationGrievance = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxcustomerid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelcustomerID = new System.Windows.Forms.Label();
            this.buttonsubmit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.errorProviderGrievanceRegistration = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGrievanceRegistration)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(277, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Grievance Registration Form";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 49);
            this.panel2.TabIndex = 21;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(36, 11);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 32);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBoxGrievanceID);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.textBoxTitle);
            this.panel1.Controls.Add(this.labeltitle);
            this.panel1.Controls.Add(this.richTextBoxGrievance);
            this.panel1.Controls.Add(this.checkBoxDeclerationGrievance);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxcustomerid);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.labelcustomerID);
            this.panel1.Location = new System.Drawing.Point(37, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 470);
            this.panel1.TabIndex = 22;
            // 
            // textBoxGrievanceID
            // 
            this.textBoxGrievanceID.Location = new System.Drawing.Point(720, 26);
            this.textBoxGrievanceID.Name = "textBoxGrievanceID";
            this.textBoxGrievanceID.ReadOnly = true;
            this.textBoxGrievanceID.Size = new System.Drawing.Size(165, 20);
            this.textBoxGrievanceID.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(609, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 18);
            this.label11.TabIndex = 26;
            this.label11.Text = "Grievance ID";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(216, 89);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(348, 20);
            this.textBoxTitle.TabIndex = 25;
            this.textBoxTitle.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxTitle_Validating);
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitle.Location = new System.Drawing.Point(32, 88);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(39, 18);
            this.labeltitle.TabIndex = 24;
            this.labeltitle.Text = "Title";
            // 
            // richTextBoxGrievance
            // 
            this.richTextBoxGrievance.Location = new System.Drawing.Point(216, 148);
            this.richTextBoxGrievance.Name = "richTextBoxGrievance";
            this.richTextBoxGrievance.Size = new System.Drawing.Size(348, 145);
            this.richTextBoxGrievance.TabIndex = 20;
            this.richTextBoxGrievance.Text = "";
            this.richTextBoxGrievance.TextChanged += new System.EventHandler(this.richTextBoxGrievance_TextChanged);
            this.richTextBoxGrievance.Validating += new System.ComponentModel.CancelEventHandler(this.richTextBoxGrievance_Validating);
            // 
            // checkBoxDeclerationGrievance
            // 
            this.checkBoxDeclerationGrievance.AutoSize = true;
            this.checkBoxDeclerationGrievance.BackColor = System.Drawing.Color.AliceBlue;
            this.checkBoxDeclerationGrievance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBoxDeclerationGrievance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxDeclerationGrievance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxDeclerationGrievance.Location = new System.Drawing.Point(26, 421);
            this.checkBoxDeclerationGrievance.Name = "checkBoxDeclerationGrievance";
            this.checkBoxDeclerationGrievance.Size = new System.Drawing.Size(13, 12);
            this.checkBoxDeclerationGrievance.TabIndex = 19;
            this.checkBoxDeclerationGrievance.UseVisualStyleBackColor = false;
            this.checkBoxDeclerationGrievance.CheckedChanged += new System.EventHandler(this.checkBoxDeclerationGrievance_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Decleration : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(566, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = " I declare that the above information entered is true to the best of my knowledge" +
    " and belief. ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(868, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "-----------";
            // 
            // textBoxcustomerid
            // 
            this.textBoxcustomerid.Location = new System.Drawing.Point(216, 32);
            this.textBoxcustomerid.Name = "textBoxcustomerid";
            this.textBoxcustomerid.Size = new System.Drawing.Size(348, 20);
            this.textBoxcustomerid.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Grievance Description : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(245, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 18);
            this.label9.TabIndex = 5;
            // 
            // labelcustomerID
            // 
            this.labelcustomerID.AutoSize = true;
            this.labelcustomerID.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcustomerID.Location = new System.Drawing.Point(32, 31);
            this.labelcustomerID.Name = "labelcustomerID";
            this.labelcustomerID.Size = new System.Drawing.Size(91, 18);
            this.labelcustomerID.TabIndex = 4;
            this.labelcustomerID.Text = "Customer ID";
            // 
            // buttonsubmit
            // 
            this.buttonsubmit.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonsubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonsubmit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsubmit.Location = new System.Drawing.Point(849, 599);
            this.buttonsubmit.Name = "buttonsubmit";
            this.buttonsubmit.Size = new System.Drawing.Size(100, 51);
            this.buttonsubmit.TabIndex = 23;
            this.buttonsubmit.Text = "SUBMIT";
            this.buttonsubmit.UseVisualStyleBackColor = false;
            this.buttonsubmit.Click += new System.EventHandler(this.buttonsubmit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 570);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(469, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(383, 68);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(127, 13);
            this.labelMessage.TabIndex = 25;
            this.labelMessage.Text = "____________________";
            // 
            // errorProviderGrievanceRegistration
            // 
            this.errorProviderGrievanceRegistration.ContainerControl = this;
            // 
            // Grievance_Redressal_Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonsubmit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Grievance_Redressal_Application";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grievance Registration Form - FinTrust";
            this.Load += new System.EventHandler(this.Grievance_Redressal_Application_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGrievanceRegistration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxDeclerationGrievance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelcustomerID;
        private System.Windows.Forms.RichTextBox richTextBoxGrievance;
        private System.Windows.Forms.TextBox textBoxcustomerid;
        private System.Windows.Forms.Button buttonsubmit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.TextBox textBoxGrievanceID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ErrorProvider errorProviderGrievanceRegistration;
    }
}