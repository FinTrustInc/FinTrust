using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinTrustDTO.DTO;
using FinTrustDLL.DataLayer;
using FinTrustDLL.Helper;

namespace FinTrustBLL.BusinessLayer
{
    public class GrievanceBL
    {
        public static int InsertGrievanceDetails(Grievance objGrievance)
        {
            int output = 0;
            try
            {
                output = GrievanceDL.InsertTransactionDetails(objGrievance);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : GrievanceBL : InsertGrievanceDetails()" + ex.Message.ToString());
            }
            return output;
        }

        public static string GetNewGrievanceId() //generate gri id
        {
            string lastgrievanceID = null;
            string newgrievanceID = null;
            try
            {
                lastgrievanceID = GrievanceDL.GetlastgrievanceID();
                if (lastgrievanceID != null)
                {
                    newgrievanceID = UtilityHelper.GenerateTransactionId(lastgrievanceID);
                }
                else
                {
                    newgrievanceID = "TRA1001";
                }
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : GrievanceBL : GetnewgrievanceID() " + ex.Message.ToString());
            }
            return newgrievanceID;
        }
    }
}
