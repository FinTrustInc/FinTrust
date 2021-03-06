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
        string searchOption = "";
        public Pending_Loan_Applications()
        {
            InitializeComponent();
        }
        private void Pending_Loan_Applications_Load(object sender, EventArgs e)
        {

            LoadLoanApplications();
        }

        //---------------- Load Loan Details form ---------------------------

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
                   lblLoanMessage.ForeColor = Color.Red;
                   lblLoanMessage.Text = "No Students Available!";
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message.ToString());
            }
        }

        //---------------- Action performed when grid view selection changed ---------------------------

        private void dgvLoanApplications_SelectionChanged(object sender, EventArgs e)
        {
            string loanId, status;
            DataSet dsLoanDetails = null;

            if (dgvLoanApplications.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvLoanApplications.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvLoanApplications.Rows[selectedrowindex];       
                loanId = Convert.ToString(selectedRow.Cells["loanId"].Value);
                dsLoanDetails = LoanBL.GetLoanDetails(loanId);
                if (dsLoanDetails.Tables[0].Rows.Count > 0)
                {
                    try
                    {
                        Object[] Data = null;
                        Data = dsLoanDetails.Tables[0].Rows[0].ItemArray;

                        textBoxCustomerId.Text = Data[0].ToString();
                        textBoxAccountNumber.Text = Data[1].ToString();
                        textBoxName.Text = Data[2].ToString();
                        textBoxAddress.Text = Data[9].ToString();
                        textBoxLoanAmount.Text = Data[16].ToString();
                        textBoxLoanType.Text = Data[15].ToString();
                        textBoxLoanId.Text = Data[13].ToString();
                        textBoxGuarantor.Text = Data[20].ToString();
                        txtTerm.Text = Data[18].ToString();
                        textBoxRateofInterest.Text = Data[17].ToString();
                        textBoxDate.Text = Data[22].ToString().Substring(0, 9);
                        status=Data[21].ToString();
                        comboBoxStatus.Text = status;
                        if (status=="Submitted")
                        {
                            comboBoxStatus.Items.Clear();
                         
                            comboBoxStatus.Items.Add("Approved");
                            comboBoxStatus.Items.Add("Rejected"); 
                        }                
                        else
                        {
                            comboBoxStatus.Items.Clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());
                    }
                }
            }
        }

        //---------------- Action for Status Combo Box selection change ---------------------------

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            int output = 0;
            ComboBox comboBox = (ComboBox)sender;
            string loanId=textBoxLoanId.Text;
            string status = (string)comboBox.SelectedItem;
            output = LoanBL.UpdateLoanStatus(loanId, status);

            if (output > 0)
            {
                LoadLoanApplications();
                lblLoanMessage.ForeColor = Color.Green;
                lblLoanMessage.Text = "Status Updated Successfully.";

            }
            else
            {
                lblLoanMessage.ForeColor = Color.Red;
                lblLoanMessage.Text = "Failed! Please Try Again.";
            }

        }

        //---------------- Action for Search By Combo Box selection change ---------------------------

        private void comboBoxSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchOption = comboBoxSearchBy.Text;
        }

        //---------------- Action for Search TextBox text change ---------------------------

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            
            DataSet dsLoans = null;
            try
            {
                string nameLike = textBoxSearch.Text;
                dsLoans = LoanBL.GetLoansLike(nameLike, searchOption);
                if (dsLoans != null)
                {                  
                    dgvLoanApplications.DataSource = dsLoans.Tables[0];                   
                }
                else
                {               
                    lblLoanMessage.ForeColor = Color.Red;
                    lblLoanMessage.Text = "No History Available!";                   
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        //---------------- Action for Back Button ---------------------------

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Utility.GetLastPage();
        }

        //---------------- Action for Collaterals selection ---------------------------

        private void checkBoxCollaterals_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCollaterals.Checked)
            {
                lblStatus.Visible = true;
                comboBoxStatus.Visible = true;
            }
            else
            {
                lblStatus.Visible = false;
                comboBoxStatus.Visible = false;
            }
               
        }
    }

}
