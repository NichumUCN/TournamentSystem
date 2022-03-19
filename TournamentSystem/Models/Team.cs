namespace TournamentSystem.Models {
	public class Team : IEnrollable{
		public int TeamId { get; set; }
		public string TeamName { get; set; }
		public HashSet<Person> peopleInTeam;

		public Team(string teamName)
		{
			TeamName = teamName;
			peopleInTeam = new HashSet<Person>();
		}

		public bool JoinTeam(Person person)
		{
			bool result = false;
			if (!peopleInTeam.Contains(person))
			{
				peopleInTeam.Add(person);
				result = true;
			}
			return result;
		}

		public bool EnrollInTournament(Tournament tournament)
		{
			return tournament.Enroll(this);
		}
	}
}
