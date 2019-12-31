using FinTrustBLL.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinTrustApp.PresentationLayer
{
    public partial class Pending_Loan_Applications : Form
    {
        public Pending_Loan_Applications()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelloanpage_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxloanamount_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pending_Loan_Applications_Load(object sender, EventArgs e)
        {
            LoadLoanApplications();
        }

        private void LoadLoanApplications()
        {
            DataSet dsLoans = null;
            try
            {
                dsLoans = LoanBL.GetLoanDetails();
                if (dsLoans != null)
                {
                    dgvLoanApplications.DataSource = dsLoans.Tables[0];
                }
                else
                {
                    //lblMessage.Text = "No Students Available!";
                }
            }
            catch (Exception ex)
            {
                //lblMessage.Text = ex.Message.ToString();
            }
        }

    }

}
