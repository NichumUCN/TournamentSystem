using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using ConfigurationManager = System.Configuration.ConfigurationManager;

namespace TournamentSystem.DataAccess {
	public class DbContext
	{

		private static DbContext _instance = null;

		public SqlConnection Connection = null;
		//private static string ConnectionString = ConfigurationManager.ConnectionStrings["MainConnectionString"].ToString();

		private DbContext()
		{
		}

		public static DbContext? Instance(string connectionString) 
		{
			
			if (_instance == null)
			{
				_instance = new DbContext();
			}
			_instance.Connection = new SqlConnection(connectionString);
			return _instance;
		}
	}
}
