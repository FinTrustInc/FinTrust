﻿using System;
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
    public partial class Probationary_Officer : Form
    {
        public Probationary_Officer()
        {
            InitializeComponent();
        }

        private void validateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void loanApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Pending_Loan_Applications objectname = new Pending_Loan_Applications();
            objectname.Show();
            
        }

        private void textBoxname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxGuarantor_TextChanged(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Loan_ApplicationForm loanApplicationForm = new Loan_ApplicationForm();
            loanApplicationForm.Show();
            
        }

        private void helpToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Help helpForm = new Help();
            helpForm.Show();
        }

        private void greivanceRedressalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            Grievance__Approval_Form grievanceApprovalForm = new Grievance__Approval_Form();
            grievanceApprovalForm.Show();
            
        }

        private void accountHandlingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Probationary_Officer_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
