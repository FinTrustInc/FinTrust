using System;
using System.Collections.Generic;
using System.Configuration;
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
            SqlConnection connection = null;

            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["FinTrustApp.Properties.Settings.DataBaseConnection"].ConnectionString;
                connection = new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.Message.ToString());
            }
            return connection;
        }

    }
}
