namespace FinTrustApp.PresentationLayer
{
	partial class FinTrust_Cashier_View
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinTrust_Cashier_View));
			this.panel2 = new System.Windows.Forms.Panel();
			this.buttonBack = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Black;
			this.panel2.Controls.Add(this.buttonBack);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Location = new System.Drawing.Point(1, 1);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(988, 47);
			this.panel2.TabIndex = 12;
			// 
			// buttonBack
			// 
			this.buttonBack.BackColor = System.Drawing.Color.Black;
			this.buttonBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBack.BackgroundImage")));
			this.buttonBack.Location = new System.Drawing.Point(12, 9);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(31, 27);
			this.buttonBack.TabIndex = 1;
			this.buttonBack.UseVisualStyleBackColor = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(78, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(211, 21);
			this.label5.TabIndex = 0;
			this.label5.Text = "View Transaction History";
			// 
			// FinTrust_Cashier_View
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(984, 661);
			this.Controls.Add(this.panel2);
			this.Name = "FinTrust_Cashier_View";
			this.Text = "Cashier/View";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button buttonBack;
		private System.Windows.Forms.Label label5;
	}
}