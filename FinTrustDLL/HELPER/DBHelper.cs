using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTrustDLL.Helper
{
	public class DBHelper
	{
        public static SqlConnection GetConnection()
        {

            SqlConnection con = null;
            string connectionString = null;

            try
            {
                connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\1028270\\source\\repos\\FinTrust\\FinTrustDLL\\DATA\\FinTrustDB.mdf;Integrated Security=True";
                con = new SqlConnection(connectionString);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("******Error:DBHelper.cs:GetConnection" + ex.Message.ToString());
            }
            return con;

        }

    }
}
