using TournamentSystem.Models;

namespace TournamentSystem.DataAccess {
	public interface ITournamentDao
	{

		bool CreateTournament(Tournament tournament);
		bool DeleteTournament(Tournament tournament);
		Tournament GetTournamentById(int tournamentId);
		ICollection<Tournament> GetAllTournaments();
		ICollection<Tournament> GetAllActiveTournaments();
		ICollection<Tournament> GetTournamentsWithinTimePeriod(DateTime FirstDate, DateTime SecondDate);
	}
}
