namespace FinTrustApp.PresentationLayer
{
	partial class FinTrust_Cashier_Transaction
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinTrust_Cashier_Transaction));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxTransactionId = new System.Windows.Forms.TextBox();
			this.textBoxAmount = new System.Windows.Forms.TextBox();
			this.radioButtonDebit = new System.Windows.Forms.RadioButton();
			this.radioButtonCredit = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxAccName = new System.Windows.Forms.TextBox();
			this.textBoxAccNo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonPay = new System.Windows.Forms.Button();
			this.buttonBack = new System.Windows.Forms.Button();
			this.labelMessage = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.labelNewTransaction = new System.Windows.Forms.Label();
			this.pictureBoxTransaction = new System.Windows.Forms.PictureBox();
			this.pictureBoxMoney = new System.Windows.Forms.PictureBox();
			this.errorProviderTransaction = new System.Windows.Forms.ErrorProvider(this.components);
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxTransaction)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoney)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderTransaction)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.textBoxTransactionId);
			this.panel1.Controls.Add(this.textBoxAmount);
			this.panel1.Controls.Add(this.radioButtonDebit);
			this.panel1.Controls.Add(this.radioButtonCredit);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.textBoxAccName);
			this.panel1.Controls.Add(this.textBoxAccNo);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(76, 104);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(769, 427);
			this.panel1.TabIndex = 0;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(121, 76);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(105, 18);
			this.label6.TabIndex = 10;
			this.label6.Text = "Transaction Id";
			// 
			// textBoxTransactionId
			// 
			this.textBoxTransactionId.Location = new System.Drawing.Point(379, 74);
			this.textBoxTransactionId.Name = "textBoxTransactionId";
			this.textBoxTransactionId.ReadOnly = true;
			this.textBoxTransactionId.Size = new System.Drawing.Size(243, 20);
			this.textBoxTransactionId.TabIndex = 9;
			this.textBoxTransactionId.TextChanged += new System.EventHandler(this.textBoxTransactionId_TextChanged);
			this.textBoxTransactionId.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxTransactionId_Validating);
			// 
			// textBoxAmount
			// 
			this.textBoxAmount.Location = new System.Drawing.Point(379, 341);
			this.textBoxAmount.Name = "textBoxAmount";
			this.textBoxAmount.Size = new System.Drawing.Size(243, 20);
			this.textBoxAmount.TabIndex = 8;
			// 
			// radioButtonDebit
			// 
			this.radioButtonDebit.AutoSize = true;
			this.radioButtonDebit.BackColor = System.Drawing.SystemColors.Control;
			this.radioButtonDebit.CausesValidation = false;
			this.radioButtonDebit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButtonDebit.Location = new System.Drawing.Point(538, 275);
			this.radioButtonDebit.Name = "radioButtonDebit";
			this.radioButtonDebit.Size = new System.Drawing.Size(62, 22);
			this.radioButtonDebit.TabIndex = 7;
			this.radioButtonDebit.TabStop = true;
			this.radioButtonDebit.Text = "Debit";
			this.radioButtonDebit.UseVisualStyleBackColor = false;
			// 
			// radioButtonCredit
			// 
			this.radioButtonCredit.AutoSize = true;
			this.radioButtonCredit.BackColor = System.Drawing.SystemColors.Control;
			this.radioButtonCredit.CausesValidation = false;
			this.radioButtonCredit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButtonCredit.Location = new System.Drawing.Point(396, 275);
			this.radioButtonCredit.Name = "radioButtonCredit";
			this.radioButtonCredit.Size = new System.Drawing.Size(65, 22);
			this.radioButtonCredit.TabIndex = 6;
			this.radioButtonCredit.TabStop = true;
			this.radioButtonCredit.Text = "Credit";
			this.radioButtonCredit.UseVisualStyleBackColor = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(121, 343);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(142, 18);
			this.label4.TabIndex = 5;
			this.label4.Text = "Transaction Amount";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(121, 279);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(121, 18);
			this.label3.TabIndex = 4;
			this.label3.Text = "Transaction Type";
			// 
			// textBoxAccName
			// 
			this.textBoxAccName.Location = new System.Drawing.Point(379, 202);
			this.textBoxAccName.Name = "textBoxAccName";
			this.textBoxAccName.ReadOnly = true;
			this.textBoxAccName.Size = new System.Drawing.Size(243, 20);
			this.textBoxAccName.TabIndex = 3;
			// 
			// textBoxAccNo
			// 
			this.textBoxAccNo.Location = new System.Drawing.Point(379, 141);
			this.textBoxAccNo.Name = "textBoxAccNo";
			this.textBoxAccNo.Size = new System.Drawing.Size(243, 20);
			this.textBoxAccNo.TabIndex = 2;
			this.textBoxAccNo.TextChanged += new System.EventHandler(this.textBoxAccNo_TextChanged);
			this.textBoxAccNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxAccNo_KeyUp);
			this.textBoxAccNo.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAccNo_Validating);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(121, 204);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(161, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Account Holder\'s Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(121, 143);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Account No.";
			// 
			// buttonPay
			// 
			this.buttonPay.BackColor = System.Drawing.Color.SteelBlue;
			this.buttonPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.buttonPay.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonPay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonPay.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonPay.Location = new System.Drawing.Point(850, 598);
			this.buttonPay.Name = "buttonPay";
			this.buttonPay.Size = new System.Drawing.Size(100, 51);
			this.buttonPay.TabIndex = 10;
			this.buttonPay.Text = "PAY";
			this.buttonPay.UseVisualStyleBackColor = false;
			this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
			// 
			// buttonBack
			// 
			this.buttonBack.BackColor = System.Drawing.Color.Black;
			this.buttonBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBack.BackgroundImage")));
			this.buttonBack.Location = new System.Drawing.Point(19, 10);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(31, 27);
			this.buttonBack.TabIndex = 1;
			this.buttonBack.UseVisualStyleBackColor = false;
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// labelMessage
			// 
			this.labelMessage.AutoSize = true;
			this.labelMessage.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.labelMessage.Location = new System.Drawing.Point(189, 62);
			this.labelMessage.Name = "labelMessage";
			this.labelMessage.Size = new System.Drawing.Size(28, 18);
			this.labelMessage.TabIndex = 9;
			this.labelMessage.Text = ".....";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.SteelBlue;
			this.panel3.Controls.Add(this.buttonBack);
			this.panel3.Controls.Add(this.labelNewTransaction);
			this.panel3.Location = new System.Drawing.Point(2, 1);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(983, 49);
			this.panel3.TabIndex = 21;
			// 
			// labelNewTransaction
			// 
			this.labelNewTransaction.AutoSize = true;
			this.labelNewTransaction.BackColor = System.Drawing.Color.SteelBlue;
			this.labelNewTransaction.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNewTransaction.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.labelNewTransaction.Location = new System.Drawing.Point(325, 10);
			this.labelNewTransaction.Name = "labelNewTransaction";
			this.labelNewTransaction.Size = new System.Drawing.Size(273, 38);
			this.labelNewTransaction.TabIndex = 3;
			this.labelNewTransaction.Text = "New Transaction";
			// 
			// pictureBoxTransaction
			// 
			this.pictureBoxTransaction.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTransaction.Image")));
			this.pictureBoxTransaction.Location = new System.Drawing.Point(76, 546);
			this.pictureBoxTransaction.Name = "pictureBoxTransaction";
			this.pictureBoxTransaction.Size = new System.Drawing.Size(220, 112);
			this.pictureBoxTransaction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxTransaction.TabIndex = 22;
			this.pictureBoxTransaction.TabStop = false;
			// 
			// pictureBoxMoney
			// 
			this.pictureBoxMoney.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMoney.Image")));
			this.pictureBoxMoney.Location = new System.Drawing.Point(296, 546);
			this.pictureBoxMoney.Name = "pictureBoxMoney";
			this.pictureBoxMoney.Size = new System.Drawing.Size(249, 112);
			this.pictureBoxMoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxMoney.TabIndex = 23;
			this.pictureBoxMoney.TabStop = false;
			// 
			// errorProviderTransaction
			// 
			this.errorProviderTransaction.ContainerControl = this;
			// 
			// FinTrust_Cashier_Transaction
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(984, 661);
			this.Controls.Add(this.pictureBoxMoney);
			this.Controls.Add(this.pictureBoxTransaction);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.labelMessage);
			this.Controls.Add(this.buttonPay);
			this.Controls.Add(this.panel1);
			this.Name = "FinTrust_Cashier_Transaction";
			this.Load += new System.EventHandler(this.FinTrust_Cashier_Transaction_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxTransaction)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoney)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderTransaction)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBoxAmount;
		private System.Windows.Forms.RadioButton radioButtonDebit;
		private System.Windows.Forms.RadioButton radioButtonCredit;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxAccName;
		private System.Windows.Forms.TextBox textBoxAccNo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonPay;
		private System.Windows.Forms.Label labelMessage;
		private System.Windows.Forms.Button buttonBack;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxTransactionId;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelNewTransaction;
        private System.Windows.Forms.PictureBox pictureBoxTransaction;
        private System.Windows.Forms.PictureBox pictureBoxMoney;
		private System.Windows.Forms.ErrorProvider errorProviderTransaction;
	}
}