using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTrustDSL.Helper
{
	public class DBHelper
	{
		public static SqlConnection GetConnection()
		{
			SqlConnection connection = null;
			String ConnectionString = null;
			try
			{
				ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\1028258\\Desktop\\FinTrustRepo\\FinTrustDSL\\DataBase\\FinTrustDB.mdf;Integrated Security=True";
				connection = new SqlConnection(ConnectionString);
			}
			catch (Exception ex)
			{
				Console.Out.WriteLine(ex.Message.ToString());
			}
			return connection;
		}

	}
}
