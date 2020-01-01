using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinTrustDTO.DTO;
using System.Data.SqlClient;
using FinTrustDLL.Helper;
using System.Data;

namespace FinTrustDLL.DataLayer
{
    public class GrievanceDL
    {
        public static int InsertTransactionDetails(Grievance objGrievance)
        {
            int output = 0;
            string sql = "";
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                sql = "insert into grievance_table(customerId,grievanceDetail,grievanceID) values(";
                sql = sql + "'" + objGrievance.CustomerId + "',";
                sql = sql + "'" + objGrievance.GrievanceDetail + "',";
                sql = sql + "'" + objGrievance.GrievanceID + ")";
                

                con = DBHelper.GetConnection();
                con.Open();
                cmd = new SqlCommand(sql, con);
                output = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : GrievanceDL : InsertTransactionDetails() " + ex.Message.ToString());
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
            return output;
        }
        public static string GetlastgrievanceID()
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            DataSet dsGrievance = null;
            string lastgrievanceID = null;
            Object[] Data = null;
            try
            {
                sql = "select grievanceID from grievance_table order by grievanceID desc";
                con = DBHelper.GetConnection();
                con.Open();
                dsGrievance = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsGrievance);

                if (dsGrievance.Tables[0].Rows.Count > 0)
                {
                    Data = dsGrievance.Tables[0].Rows[0].ItemArray;
                    lastgrievanceID = Data[0].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : GrievanceDL : GetlastgrievanceID() " + ex.Message.ToString());
            }
            finally
            {
                con.Close();
                adapter.Dispose();
            }

            return lastgrievanceID;
        }
    }
}
