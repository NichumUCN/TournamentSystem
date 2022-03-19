using ConfigurationManager = System.Configuration.ConfigurationManager;
namespace TournamentSystem.DataAccess {
	public class DaoFactory
	{

		private static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["MainConnectionString"].ToString();
		public static IPersonDao CreatePersonDao()
		{
			return new PersonDao(GetDbContext());
		}

		public static ITournamentDao CreateTournamentDao()
		{
			return new TournamentDao(GetDbContext());
		}

		private static DbContext? GetDbContext()
		{
			return DbContext.Instance(ConnectionString);
		}
	}
}
