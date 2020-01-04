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
    public partial class Grievance__Approval_Form : Form
    {
        public Grievance__Approval_Form()
        {
            InitializeComponent();
      
        }
    
        private void Grievance__Approval_Form_Load(object sender, EventArgs e)
        {
            LoadGrievanceApplications();
            comboBoxAction.Items.Add("Reject");
            comboBoxAction.Items.Add("Resolve");
            comboBoxAction.Items.Add("Processing");
            comboBoxSearchBy.Items.Add("Grievance ID");
            comboBoxSearchBy.Items.Add("Customer ID");
            comboBoxSearchBy.Items.Add("Account Number");
            comboBoxSearchBy.Items.Add("Customer Name");
        }
        private void LoadGrievanceApplications()
        {
            DataSet dsLoans = null;

            try
            {
                dsLoans = GrievanceBL.GetBasicGrievanceDetails();

                if (dsLoans != null)
                {
                    dataGridGriev.DataSource = dsLoans.Tables[0];
                }
                else
                {
                    labelMessage.Text = "No Data Available!";
                }

            }
            catch (Exception ex)
            {
                labelMessage.Text = ex.Message.ToString();
            }
        }

        private void dataGridGriev_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridGriev_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                if (dataGridGriev.SelectedCells.Count > 0)  //contains data in grid
                {
                    int selectedrowindex = dataGridGriev.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedRow = dataGridGriev.Rows[selectedrowindex]; //whole data of that row

                    textBoxGrievanceid.Text = Convert.ToString(selectedRow.Cells["grievanceID"].Value);
                    textBoxcustomerid.Text = Convert.ToString(selectedRow.Cells["customerid"].Value);
                    textBoxAccNumber.Text = Convert.ToString(selectedRow.Cells["accountNumber"].Value);
                    textBoxname.Text = Convert.ToString(selectedRow.Cells["customerName"].Value);
                    richTextBoxGrievance.Text = Convert.ToString(selectedRow.Cells["grievanceDetail"].Value);
                    textBoxAccType.Text = Convert.ToString(selectedRow.Cells["accountType"].Value);
                    textBoxEmail.Text = Convert.ToString(selectedRow.Cells["email"].Value);
                    textBoxPhoneNo.Text = Convert.ToString(selectedRow.Cells["phone"].Value);

                    DateTime today = DateTime.Today;
                    textBoxDate.Text = today.ToString();

                }
            }
            catch(Exception ex)
            {
                Console.Write(ex.Message.ToString());
            }
          
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            Grievance objectGrievance = new Grievance();

            objectGrievance.Status= comboBoxAction.Text;
            objectGrievance.GrievanceID=textBoxGrievanceid.Text;
            
            GrievanceBL.InsertStatus(objectGrievance);
        }

        private void comboBoxSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)//verified checkbox
        {
            if (verified.Checked)
            {
                comboBoxAction.Visible = true;
            }
            else
            {
                comboBoxAction.Visible = false;
            }
        }

        private void searchField_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchBy = "";
                string category = "";
                searchBy = comboBoxSearchBy.Text;
                if (searchBy == "Grievance ID")
                {
                    category = "grievanceID";
                }
                else if (searchBy == "Customer ID")
                {
                    category = "customerId";
                }
                else if (searchBy == "Account Number")
                {
                    category = "accountnumber";
                }
                else if (searchBy == "Customer Name")
                {
                    category = "customerName";
                }

                string like = searchField.Text;
                DataSet dsGrievance;
                dsGrievance = GrievanceBL.GetGrievanceLike(category, like);
                if (dsGrievance != null)
                {
                    dataGridGriev.DataSource = dsGrievance.Tables[0];
                }
                else
                {
                    labelMessage.Text = "No Details Available in Grievance Record";
                }
            }

            catch (Exception ex)
            {
                labelMessage.Text = ex.Message.ToString();
            }


}

        private void comboBoxSearchBy_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxSearchBy.SelectedIndex == -1)
            {
                errorProviderGrievanceApproval.SetError(comboBoxSearchBy, "Select type !");
            }
            else
            {
                errorProviderGrievanceApproval.SetError(comboBoxSearchBy, string.Empty);
            }
        }
    }
}
