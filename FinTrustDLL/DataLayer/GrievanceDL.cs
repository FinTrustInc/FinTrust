using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinTrustDTO.DTO;
using System.Data.SqlClient;
using FinTrustDLL.Helper;
using System.Data;
using System.Windows.Forms;

namespace FinTrustDLL.DataLayer
{
    public class GrievanceDL
    {
        //-------------------------------------------------------------------------------------
        //---------------------------- Insert Grievance Details -------------------------------

        public static int InsertGrievanceDetails(Grievance objGrievance)
        {
            int output = 0;
            string sql = "";
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                sql = "insert into grievance_table(customerId,grievanceDetail,grievanceID,title,status) values(";
                sql = sql + "'" + objGrievance.CustomerId + "',";
                sql = sql + "'" + objGrievance.GrievanceDetail + "',";
                sql = sql + "'" + objGrievance.GrievanceID + "',";
                sql = sql + "'" + objGrievance.Title + "',";
                sql = sql + "'" + objGrievance.Status + "')";


                con = DBHelper.GetConnection();
                con.Open();
                cmd = new SqlCommand(sql, con);
                output = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : GrievanceDL : InsertGrievanceDetails() " + ex.Message.ToString());
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
            return output;
        }

        //----------------------------------------------------------------------------------------------
        //------------------ Get Grievance Id for genereating New for Grievances -----------------------

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

                if (dsGrievance.Tables[0].Rows.Count > 0) //Grievance ID  is present
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

        //----------------------------------------------------------------------------------------------
        //------------------------ Load Basic grievance Details in datagridView ------------------------

        public static DataSet GetBasicGrievanceDetails()
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            DataSet dsGrieve = null;
            try
            {
                sql = "select customer_table.*,grievance_table.grievanceDetail,grievance_table.grievanceID,grievance_table.title FROM customer_table INNER JOIN grievance_table ON customer_table.customerId = grievance_table.customerId ";
                con = DBHelper.GetConnection();
                con.Open();
                dsGrieve = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsGrieve);
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : GrievanceDL:GetBasicGrievanceDetails : " + ex.Message.ToString());
            }
            finally
            {
                con.Close();
                adapter.Dispose();
            }
            return dsGrieve;
        }
        
        //------------------------------------------------------------------------------------------------
        //------------------ Update Status of the Grievance Applied --------------------------------------

        public static void InsertStatus(Grievance objectGrievane)
        {
            
            string sql = "";
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                sql = "update grievance_table set status=" + objectGrievane.Status + "where grievanceID=" + objectGrievane.GrievanceID;


                con = DBHelper.GetConnection();
                con.Open();
                cmd = new SqlCommand(sql, con);
              
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error : GrievanceDL : InsertStatus() " + ex.Message.ToString());
            }
            finally
            {
                con.Close();
                cmd.Dispose();
                string Title = "Grievance Status";
                MessageBox.Show("Grievance Status is Updated",Title);
            }
        }

        //-------------------------------------------------------------------------------------------
        //------------------ Search for Grievances --------------------------------------------------

        public static DataSet GetGrievanceLike(string category, string like)
        {
            string sql = "";
            SqlConnection con = null;
            SqlDataAdapter adapter = null;
            DataSet dsGrievance = null;
            try
            {
                if (category == "customerId" || category == "accountNumber" || category == "customerName")
                {
                    sql = "SELECT grievance_table.grievanceID,customer_table.customerId,customer_table.customerName,grievance_table.title,customer_table.accountNumber FROM customer_table JOIN grievance_table on customer_table.customerId=grievance_table.customerId WHERE customer_table." + category + " like '" + like + "%'";
                }

                else if (category == "grievanceID")
                {
                    sql = "SELECT grievance_table.grievanceID,customer_table.customerId,customer_table.customerName,grievance_table.title,customer_table.accountNumber FROM customer_table JOIN grievance_table on customer_table.customerId=grievance_table.customerId WHERE grievance_table." + category + " like '" + like + "%'";
                    
                }
                con = DBHelper.GetConnection();
                con.Open();
                dsGrievance = new DataSet();
                adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dsGrievance);
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(" Error : GrievanceDL : GetGrievanceLike() " + ex.Message.ToString());
            }
            finally
            {
                con.Close();
                adapter.Dispose();
            }
            return dsGrievance;
        }

    }
}
