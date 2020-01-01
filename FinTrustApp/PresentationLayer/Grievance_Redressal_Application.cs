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
            int output = 0;
            try
            {
                objGrievance = new Grievance();
                objGrievance.CustomerId = textBoxcustomerid.Text;
                objGrievance.AccountNumber = richTextBoxGrievance.Text;
                objGrievance.GrievanceID = "GRV1001";
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
    }
}
