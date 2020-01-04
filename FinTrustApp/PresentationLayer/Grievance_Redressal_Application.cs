using FinTrustDTO.DTO;
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


namespace FinTrustApp.PresentationLayer
{
    public partial class Grievance_Redressal_Application : Form
    {
        public Grievance_Redressal_Application()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBoxGrievance_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxGuarantor_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonsubmit_Click(object sender, EventArgs e)
        {
            Grievance objGrievance = null;
            objGrievance = new Grievance();
            int output = 0;
            try
            {
                objGrievance.GrievanceID = textBoxGrievanceID.Text;
                objGrievance.CustomerId = textBoxcustomerid.Text;
                objGrievance.GrievanceDetail = richTextBoxGrievance.Text;
                objGrievance.Title = textBoxTitle.Text;
                objGrievance.Status = "Submitted";


                DateTime today = DateTime.Today;

                output = GrievanceBL.InsertGrievanceDetails(objGrievance);

                if (output > 0)
                {
                    labelMessage.Text = "DATA ADDED SUCCESSFULLY";
                }
                else
                {
                    labelMessage.Text = "INSERTION FAILED";
                }
            }
            catch (Exception ex)
            {
                labelMessage.Text = ex.Message.ToString();
            }
        }

        private void Grievance_Redressal_Application_Load(object sender, EventArgs e)
        {
            textBoxGrievanceID.Text = GrievanceBL.GetNewGrievanceId().ToString();
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Utility.GetLastPage();
        }

        private void textBoxTitle_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxTitle.Text == string.Empty)
            {
                errorProviderGrievanceRegistration.SetError(textBoxTitle, "Title required !");
            }
            else
            {
                errorProviderGrievanceRegistration.SetError(textBoxTitle, string.Empty);
            }

        }

        private void richTextBoxGrievance_Validating(object sender, CancelEventArgs e)
        {
         
         if (richTextBoxGrievance.Text == string.Empty)
            {
                errorProviderGrievanceRegistration.SetError(richTextBoxGrievance, "Grievance description required !");
            }
            else
            {
                errorProviderGrievanceRegistration.SetError(richTextBoxGrievance, string.Empty);
            }
        }

        private void checkBoxDeclerationGrievance_CheckedChanged(object sender, EventArgs e)
        {
           
           if (checkBoxDeclerationGrievance.Checked)
            {
                if (textBoxcustomerid.Text == string.Empty || textBoxTitle.Text == string.Empty || richTextBoxGrievance.Text == string.Empty)
                {
                    checkBoxDeclerationGrievance.Checked = false;
                    buttonsubmit.Enabled = false;
                }
                else
                {
                    buttonsubmit.Enabled = true;
                }
            }
            else
            {
                buttonsubmit.Enabled = false;
            }
        }
    }
}
