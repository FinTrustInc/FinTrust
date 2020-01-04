using FinTrustDTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTrustApp.PresentationLayer
{
    public class Utility
    {
        public static void GetLastPage()
        {
            if (LoginInfo.designation == "Branch Manager")
            {
               
                Branch_Manager BMHomeForm = new Branch_Manager();
                BMHomeForm.Show();
            }
            else if (LoginInfo.designation == "Probationary Officer")
            {

                Probationary_Officer POHomeForm = new Probationary_Officer();
                POHomeForm.Show();
            }
            else if (LoginInfo.designation == "Clerk")
            {
               
                Clerk clerkHomeForm = new Clerk();
                clerkHomeForm.Show();
            }
            else if (LoginInfo.designation == "Cashier")
            {
                
                FinTrust_Cashier cashierHomeForm = new FinTrust_Cashier();
                cashierHomeForm.Show();
            }
        }
    }
}
