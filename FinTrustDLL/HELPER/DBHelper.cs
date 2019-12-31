﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace FinTrustDSL.Helper
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
