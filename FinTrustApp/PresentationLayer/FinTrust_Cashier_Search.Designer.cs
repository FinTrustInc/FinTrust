namespace FinTrustApp.PresentationLayer
{
	partial class FinTrust_Cashier_Search
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePickerSearch = new System.Windows.Forms.DateTimePicker();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewTransactions = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxBalanceAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTransactionDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTransactionType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAccName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAccNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.labelCashierSearch = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dateTimePickerSearch);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.comboBoxSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(43, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 157);
            this.panel1.TabIndex = 13;
            // 
            // dateTimePickerSearch
            // 
            this.dateTimePickerSearch.Location = new System.Drawing.Point(23, 116);
            this.dateTimePickerSearch.Name = "dateTimePickerSearch";
            this.dateTimePickerSearch.Size = new System.Drawing.Size(321, 20);
            this.dateTimePickerSearch.TabIndex = 4;
            this.dateTimePickerSearch.ValueChanged += new System.EventHandler(this.dateTimePickerSearch_ValueChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(23, 72);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(321, 20);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Location = new System.Drawing.Point(194, 29);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(150, 21);
            this.comboBoxSearch.TabIndex = 2;
            this.comboBoxSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearch_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search By";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.Color.Green;
            this.labelMessage.Location = new System.Drawing.Point(314, 67);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 18);
            this.labelMessage.TabIndex = 14;
            this.labelMessage.Click += new System.EventHandler(this.labelMessage_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.dataGridViewTransactions);
            this.panel3.Location = new System.Drawing.Point(43, 279);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(367, 354);
            this.panel3.TabIndex = 15;
            // 
            // dataGridViewTransactions
            // 
            this.dataGridViewTransactions.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransactions.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewTransactions.Name = "dataGridViewTransactions";
            this.dataGridViewTransactions.Size = new System.Drawing.Size(361, 348);
            this.dataGridViewTransactions.TabIndex = 0;
            this.dataGridViewTransactions.SelectionChanged += new System.EventHandler(this.dataGridViewTransactions_SelectionChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.textBoxBalanceAmount);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.textBoxTransactionDate);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.textBoxAmount);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.textBoxTransactionType);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.textBoxAccName);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.textBoxAccNo);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(471, 107);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(468, 526);
            this.panel4.TabIndex = 16;
            // 
            // textBoxBalanceAmount
            // 
            this.textBoxBalanceAmount.Location = new System.Drawing.Point(206, 447);
            this.textBoxBalanceAmount.Name = "textBoxBalanceAmount";
            this.textBoxBalanceAmount.Size = new System.Drawing.Size(243, 20);
            this.textBoxBalanceAmount.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Balance Amount";
            // 
            // textBoxTransactionDate
            // 
            this.textBoxTransactionDate.Location = new System.Drawing.Point(206, 370);
            this.textBoxTransactionDate.Name = "textBoxTransactionDate";
            this.textBoxTransactionDate.Size = new System.Drawing.Size(243, 20);
            this.textBoxTransactionDate.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Transaction Date";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(206, 289);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(243, 20);
            this.textBoxAmount.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Transaction Amount";
            // 
            // textBoxTransactionType
            // 
            this.textBoxTransactionType.Location = new System.Drawing.Point(206, 213);
            this.textBoxTransactionType.Name = "textBoxTransactionType";
            this.textBoxTransactionType.Size = new System.Drawing.Size(243, 20);
            this.textBoxTransactionType.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Transaction Type";
            // 
            // textBoxAccName
            // 
            this.textBoxAccName.Location = new System.Drawing.Point(206, 137);
            this.textBoxAccName.Name = "textBoxAccName";
            this.textBoxAccName.Size = new System.Drawing.Size(243, 20);
            this.textBoxAccName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Account Holder\'s Name";
            // 
            // textBoxAccNo
            // 
            this.textBoxAccNo.Location = new System.Drawing.Point(206, 60);
            this.textBoxAccNo.Name = "textBoxAccNo";
            this.textBoxAccNo.Size = new System.Drawing.Size(243, 20);
            this.textBoxAccNo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account No.";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.Controls.Add(this.btnBack);
            this.panel5.Controls.Add(this.labelCashierSearch);
            this.panel5.Location = new System.Drawing.Point(1, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(983, 49);
            this.panel5.TabIndex = 21;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(45, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 32);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // labelCashierSearch
            // 
            this.labelCashierSearch.AutoSize = true;
            this.labelCashierSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.labelCashierSearch.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCashierSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCashierSearch.Location = new System.Drawing.Point(309, 4);
            this.labelCashierSearch.Name = "labelCashierSearch";
            this.labelCashierSearch.Size = new System.Drawing.Size(273, 38);
            this.labelCashierSearch.TabIndex = 3;
            this.labelCashierSearch.Text = "ViewTransaction";
            // 
            // FinTrust_Cashier_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FinTrust_Cashier_Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Transaction - FinTrust";
            this.Load += new System.EventHandler(this.FinTrust_Cashier_Search_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.ComboBox comboBoxSearch;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelMessage;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.DataGridView dataGridViewTransactions;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxAccNo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxAccName;
		private System.Windows.Forms.TextBox textBoxTransactionType;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxBalanceAmount;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBoxTransactionDate;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxAmount;
		private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelCashierSearch;
		private System.Windows.Forms.DateTimePicker dateTimePickerSearch;
        private System.Windows.Forms.Button btnBack;
    }
}