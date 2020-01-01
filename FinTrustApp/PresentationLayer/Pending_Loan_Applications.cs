﻿using FinTrustBLL.BusinessLayer;
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
            this.loan_tableTableAdapter.Fill(this.FinTrustDBDataSet.student_mark);
            LoadLoanApplications();
        }

        private void LoadLoanApplications()
        {
            DataSet dsLoans = null;
            
            try
            {
                dsLoans = LoanBL.GetBasicLoanDetails();
    
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

        private void dgvLoanApplications_SelectionChanged(object sender, EventArgs e)
        {
            string loanId;
            DataSet dsLoanDetails = null;
            if (dgvLoanApplications.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvLoanApplications.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvLoanApplications.Rows[selectedrowindex];

                loanId = Convert.ToString(selectedRow.Cells["loanId"].Value);

                Object[] Data = null;
                dsLoanDetails = LoanBL.GetLoanDetails(loanId);
                if (dsLoanDetails.Tables[0].Rows.Count > 0)
                {
                    Data = dsLoanDetails.Tables[0].Rows[0].ItemArray;

                    textBoxCustomerId.Text = Data[0].ToString();
                    textBoxAccountNumber.Text = Data[1].ToString();
                    textBoxName.Text = Data[2].ToString();
                    textBoxAddress.Text = Data[9].ToString();
                    textBoxLoanAmount.Text = Data[15].ToString();
                    textBoxLoanType.Text = Data[14].ToString();
                    textBoxLoanId.Text = Data[12].ToString();
                    textBoxGuarantor.Text = Data[20].ToString();
                    txtTerm.Text = Data[18].ToString();
                    textBoxRateofInterest.Text = Data[17].ToString();
                    textBoxDate.Text = Data[22].ToString();
                    comboBoxStatus.Text = Data[21].ToString();
                }
            }
        }
    }

}
