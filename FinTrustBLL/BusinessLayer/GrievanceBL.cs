﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinTrustDTO.DTO;
using FinTrustDLL.DataLayer;
using FinTrustDLL.Helper;
using System.Data;

namespace FinTrustBLL.BusinessLayer
{
    public class GrievanceBL
    {
        public static int InsertGrievanceDetails(Grievance objGrievance)
        {
            int output = 0;
            try
            {
                output = GrievanceDL.InsertGrievanceDetails(objGrievance);
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
                if (lastgrievanceID != null)  //Grievance ID exists
                {
                    newgrievanceID = UtilityHelper.GenerateLoanId(lastgrievanceID);
                }
                else
                {
                    newgrievanceID = "GR1001";
                }
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : GrievanceBL : GetnewgrievanceID() " + ex.Message.ToString());
            }
            return newgrievanceID;
        }

        public static DataSet GetBasicGrievanceDetails()
        {


            DataSet dsGrieve = null;
            try
            {
                dsGrieve = GrievanceDL.GetBasicGrievanceDetails();

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : GrievanceBL:GetBasicGrievanceDetails : " + ex.Message.ToString());
            }


            return dsGrieve;
        }
        public static void InsertStatus(Grievance objectGrievance)
        {
           
            try
            {
                GrievanceDL.InsertStatus(objectGrievance);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : GrievanceBL : InsertStatus()" + ex.Message.ToString());
            }
         
        }
        public static DataSet GetGrievanceLike(string category, string like)
        {
            DataSet dsgrievance = null;
            try
            {
                dsgrievance = GrievanceDL.GetGrievanceLike(category, like);
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(" Error : GrievanceBL : GetGrievanceLike() " + ex.Message.ToString());
            }
            return dsgrievance;
        }


    }
}
