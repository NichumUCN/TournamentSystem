namespace TournamentSystem.Models {
	public class Tournament {

		public int TournamentId { get; set; }
		public string TournamentName { get; set; }
		public string TournamentGame { get; set; }
		public string TournamentDescription { get; set; }
		public DateTime TimeOfEvent { get; set; }
		public int MaxNoParticipants { get; set; }
		public readonly HashSet<IEnrollable> EnrollmentCollection;


		public Tournament(int tournamentId, string tournamentName, string tournamentGame, string tournamentDescription, DateTime timeOfEvent, int maxNoParticipants)
		{
			TournamentId = tournamentId;
			TournamentName = tournamentName;
			TournamentGame = tournamentGame;
			TournamentDescription = tournamentDescription;
			TimeOfEvent = timeOfEvent;
			MaxNoParticipants = maxNoParticipants;
			EnrollmentCollection = new HashSet<IEnrollable>();
		}

		public bool Enroll(IEnrollable enrollable)
		{
			bool result = false;
			if (EnrollmentCollection.Count < MaxNoParticipants)
			{
				EnrollmentCollection.Add(enrollable);
				result = true;
			}

			return result;
		}
	}
}
