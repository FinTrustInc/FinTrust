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

		private void Customer_View_Load(object sender, EventArgs e)
		{
			comboBoxSearch.Items.Add("Customer ID");
			comboBoxSearch.Items.Add("Account No");
			comboBoxSearch.Items.Add("Customer Name");

			comboBoxAccType.Items.Add("Savings");
			comboBoxAccType.Items.Add("Current");
		}

		//--------------------------------------------------------------------------------------------------------------
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
				else
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
		//-------------- Display Customer Details while Clicking on one of the rows of DatagridView-------------------
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
					labelMessage.Text = "DATA UPDATED SUCCESSFULLY";
				}
				else
				{
					labelMessage.Text = "UPDATION FAILED";
				}

			}
			catch (Exception ex)
			{
				labelMessage.Text = ex.Message.ToString();
			}
		}

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Utility.GetLastPage();
        }
    }
}
