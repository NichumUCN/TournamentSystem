namespace TournamentSystem.Models {
	public class Person {
		public int PersonId;
		public string PersonFirstName;
		public string PersonLastName;
		public string PersonNickname;
		public string Email;
		public DateTime Birthdate;

		public Person(int personId, string personFirstName, string personLastName, string personNickname, string email, DateTime birthdate) {
			PersonId = personId;
			PersonFirstName = personFirstName;
			PersonLastName = personLastName;
			PersonNickname = personNickname;
			Email = email;
			Birthdate = birthdate;
		}

		public Person(string personFirstName, string personLastName, string personNickname, string email, DateTime birthdate) {
			PersonFirstName = personFirstName;
			PersonLastName = personLastName;
			PersonNickname = personNickname;
			Email = email;
			Birthdate = birthdate;
		}
	}
}
