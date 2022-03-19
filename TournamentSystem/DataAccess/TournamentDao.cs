using Dapper;
using TournamentSystem.Models;

namespace TournamentSystem.DataAccess {
	public class TournamentDao : ITournamentDao {
		private DbContext _dbContext;

		public TournamentDao(DbContext dbContext) {
			_dbContext = dbContext;
		}

		public bool CreateTournament(Tournament tournament) {
			bool result = false;
			string sqlQuery = "INSERT INTO Tournament VALUES ()";
			using (_dbContext.Connection) {
				if (_dbContext.Connection.Execute(sqlQuery) == 1) {
					result = true;
				}
			}
			return result;
		}

		public bool DeleteTournament(Tournament tournament) {
			throw new NotImplementedException();
		}

		public Tournament GetTournamentById(int tournamentId) {
			throw new NotImplementedException();
		}

		public ICollection<Tournament> GetAllTournaments() {
			throw new NotImplementedException();
		}

		public ICollection<Tournament> GetAllActiveTournaments() {
			throw new NotImplementedException();
		}

		public ICollection<Tournament> GetTournamentsWithinTimePeriod(DateTime FirstDate, DateTime SecondDate) {
			throw new NotImplementedException();
		}
	}
}
