using ConfigurationManager = System.Configuration.ConfigurationManager;
namespace TournamentSystem.DataAccess {
	public class DaoFactory
	{

		private static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["MainConnectionString"].ToString();
		public static IPersonDao CreatePersonDao()
		{
			return new PersonDao(GetDbContext());
		}

		private static DbContext? GetDbContext()
		{
			return DbContext.Instance(ConnectionString);
		}
	}
}
