using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinTrustBLL.BusinessLayer;
using FinTrustDTO.DTO;

namespace FinTrustApp.PresentationLayer
{
	public partial class Customer_View : Form
	{
		public Customer_View()
		{
			InitializeComponent();
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		//---------------------------------------------------------------------------------------------------------
		//------------------------------------- Load data from combobox -------------------------------------------

		private void Customer_View_Load(object sender, EventArgs e)
		{
			comboBoxSearch.Items.Add("Customer ID");
			comboBoxSearch.Items.Add("Account No");
			comboBoxSearch.Items.Add("Customer Name");

			comboBoxAccType.Items.Add("SAVINGS");
			comboBoxAccType.Items.Add("CURRENT");
		}

		//-----------------------------------------------------------------------------------------------------------
		//----------------------------- Search for a Customer -------------------------------------------------------

		private void textBoxViewSearch_TextChanged(object sender, EventArgs e)
		{
			DataSet dsCustomers = null;
			string category = null;
			try
			{
				if (comboBoxSearch.Text == "Customer ID")
				{
					category = "customerId";
				}
				else if (comboBoxSearch.Text == "Account No")
				{
					category = "accountNumber";
				}
				else if (comboBoxSearch.Text == "Customer Name")
				{
					category = "customerName";
				}
				
				string like = textBoxViewSearch.Text;
				dsCustomers = TransactionBL.GetCustomersLike(category, like);
				if (dsCustomers != null)
				{
					dataGridViewCustomers.DataSource = dsCustomers.Tables[0];
				}
				if(dsCustomers.Tables[0].Rows.Count < 1)
				{
					labelMessage.Text = "No Customers available";
				}
			}
			catch (Exception ex)
			{
				Console.Out.WriteLine(ex.Message.ToString());
			}
		}

		//---------------------------------------------------------------------------------------------------------------------
		//-------------- Display Customer Details while Clicking on one of the rows of DatagridView----------------------------

		private void dataGridViewTransactions_SelectionChanged(object sender, EventArgs e)
		{
			
			if (dataGridViewCustomers.SelectedCells.Count > 0)
			{
				int selectedrowindex = dataGridViewCustomers.SelectedCells[0].RowIndex;

				DataGridViewRow selectedRow = dataGridViewCustomers.Rows[selectedrowindex];

				textBoxCustomerId.Text = Convert.ToString(selectedRow.Cells["customerId"].Value);
				textBoxAccNo.Text = Convert.ToString(selectedRow.Cells["accountNumber"].Value);
				textBoxAccName.Text = Convert.ToString(selectedRow.Cells["customerName"].Value);
				textBoxAccDate.Text = Convert.ToString(selectedRow.Cells["dateOfAccount"].Value);
				comboBoxAccType.Text = Convert.ToString(selectedRow.Cells["accountType"].Value);
				textBoxDOB.Text = Convert.ToString(selectedRow.Cells["dateOfBirth"].Value);
				textBoxGender.Text = Convert.ToString(selectedRow.Cells["gender"].Value);
				textBoxEmail.Text = Convert.ToString(selectedRow.Cells["email"].Value);
				richTextBoxAddress.Text = Convert.ToString(selectedRow.Cells["address"].Value);
				textBoxAadhar.Text = Convert.ToString(selectedRow.Cells["aadharNumber"].Value);
				textBoxPan.Text = Convert.ToString(selectedRow.Cells["panNumber"].Value);
				textBoxPhone.Text = Convert.ToDouble(selectedRow.Cells["phone"].Value).ToString();
				textBoxBalance.Text = Convert.ToDouble(selectedRow.Cells["balanceAmount"].Value).ToString();

			}
		}

		//---------------------------------------------------------------------------------------------------------
		//-------------------------------------- Update customer details ------------------------------------------

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			Customer objCustomer = null;
			int output = 0;
			try
			{
				objCustomer = new Customer();
				objCustomer.AccountNumber = textBoxAccNo.Text;
				objCustomer.CustomerName = textBoxAccName.Text;
				objCustomer.AccountType = comboBoxAccType.Text;
				objCustomer.Phone = Convert.ToInt64(textBoxPhone.Text);
				objCustomer.Email = textBoxEmail.Text;
				objCustomer.Address = richTextBoxAddress.Text;

				output = TransactionBL.UpdateCustomerDetails(objCustomer);
				if (output > 0)
				{
					string title = "Customer View";
					string message = "Updation Successful";
					MessageBoxButtons buttons = MessageBoxButtons.OK;
					DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
					DataSet dsCustomers = null;
					string category = null;
					if (comboBoxSearch.Text == "Customer ID")
					{
						category = "customerId";
					}
					else if (comboBoxSearch.Text == "Account No")
					{
						category = "accountNumber";
					}
					else if (comboBoxSearch.Text == "Customer Name")
					{
						category = "customerName";
					}

					string like = textBoxViewSearch.Text;
					dsCustomers = TransactionBL.GetCustomersLike(category, like);
					if (dsCustomers != null)
					{
						dataGridViewCustomers.DataSource = dsCustomers.Tables[0];
					}
					else
					{
						labelMessage.Text = "No Customers available";
					}

				}
				else
				{
					string title = "Customer View";
					string message = "Updation Failed";
					MessageBoxButtons buttons = MessageBoxButtons.RetryCancel;
					DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
					if (result == DialogResult.Retry)
					{
						textBoxAccName.Clear();
						textBoxPhone.Clear();
						textBoxEmail.Clear();
						richTextBoxAddress.Clear();
					}
				}

			}
			catch (Exception ex)
			{
				labelMessage.Text = ex.Message.ToString();
			}
		}
	}
}
