namespace FinTrustApp.PresentationLayer
{
    partial class FinTrust_BranchManager_HomePage
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
            this.panelClerk = new System.Windows.Forms.Panel();
            this.textBoxSearchAccountNo = new System.Windows.Forms.TextBox();
            this.textBoxSearchTransactionID = new System.Windows.Forms.TextBox();
            this.textBoxSearchClerkID = new System.Windows.Forms.TextBox();
            this.labelSearchAccuntNo = new System.Windows.Forms.Label();
            this.labelSearchTransactionID = new System.Windows.Forms.Label();
            this.labelSearchID = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelClerk.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClerk
            // 
            this.panelClerk.Controls.Add(this.comboBox1);
            this.panelClerk.Controls.Add(this.textBoxSearchAccountNo);
            this.panelClerk.Controls.Add(this.textBoxSearchTransactionID);
            this.panelClerk.Controls.Add(this.textBoxSearchClerkID);
            this.panelClerk.Controls.Add(this.labelSearchAccuntNo);
            this.panelClerk.Controls.Add(this.labelSearchTransactionID);
            this.panelClerk.Controls.Add(this.labelSearchID);
            this.panelClerk.Location = new System.Drawing.Point(104, 59);
            this.panelClerk.Name = "panelClerk";
            this.panelClerk.Size = new System.Drawing.Size(740, 533);
            this.panelClerk.TabIndex = 3;
            // 
            // textBoxSearchAccountNo
            // 
            this.textBoxSearchAccountNo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchAccountNo.Location = new System.Drawing.Point(414, 250);
            this.textBoxSearchAccountNo.Name = "textBoxSearchAccountNo";
            this.textBoxSearchAccountNo.Size = new System.Drawing.Size(239, 25);
            this.textBoxSearchAccountNo.TabIndex = 5;
            // 
            // textBoxSearchTransactionID
            // 
            this.textBoxSearchTransactionID.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchTransactionID.Location = new System.Drawing.Point(414, 173);
            this.textBoxSearchTransactionID.Name = "textBoxSearchTransactionID";
            this.textBoxSearchTransactionID.Size = new System.Drawing.Size(239, 25);
            this.textBoxSearchTransactionID.TabIndex = 4;
            // 
            // textBoxSearchClerkID
            // 
            this.textBoxSearchClerkID.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchClerkID.Location = new System.Drawing.Point(414, 99);
            this.textBoxSearchClerkID.Name = "textBoxSearchClerkID";
            this.textBoxSearchClerkID.Size = new System.Drawing.Size(239, 25);
            this.textBoxSearchClerkID.TabIndex = 3;
            // 
            // labelSearchAccuntNo
            // 
            this.labelSearchAccuntNo.AutoSize = true;
            this.labelSearchAccuntNo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchAccuntNo.Location = new System.Drawing.Point(122, 249);
            this.labelSearchAccuntNo.Name = "labelSearchAccuntNo";
            this.labelSearchAccuntNo.Size = new System.Drawing.Size(150, 18);
            this.labelSearchAccuntNo.TabIndex = 2;
            this.labelSearchAccuntNo.Text = "Search by Account No";
            // 
            // labelSearchTransactionID
            // 
            this.labelSearchTransactionID.AutoSize = true;
            this.labelSearchTransactionID.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchTransactionID.Location = new System.Drawing.Point(122, 175);
            this.labelSearchTransactionID.Name = "labelSearchTransactionID";
            this.labelSearchTransactionID.Size = new System.Drawing.Size(176, 18);
            this.labelSearchTransactionID.TabIndex = 1;
            this.labelSearchTransactionID.Text = "Search by Transaction ID";
            // 
            // labelSearchID
            // 
            this.labelSearchID.AutoSize = true;
            this.labelSearchID.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchID.Location = new System.Drawing.Point(37, 50);
            this.labelSearchID.Name = "labelSearchID";
            this.labelSearchID.Size = new System.Drawing.Size(94, 18);
            this.labelSearchID.TabIndex = 0;
            this.labelSearchID.Text = "Serach by ID";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // FinTrust_BranchManager_HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panelClerk);
            this.Name = "FinTrust_BranchManager_HomePage";
            this.Text = "FinTrust_BranchManager_HomePage";
            this.panelClerk.ResumeLayout(false);
            this.panelClerk.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelClerk;
        private System.Windows.Forms.TextBox textBoxSearchAccountNo;
        private System.Windows.Forms.TextBox textBoxSearchTransactionID;
        private System.Windows.Forms.TextBox textBoxSearchClerkID;
        private System.Windows.Forms.Label labelSearchAccuntNo;
        private System.Windows.Forms.Label labelSearchTransactionID;
        private System.Windows.Forms.Label labelSearchID;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}