using System;
using System.Linq;
using TournamentSystem.Models;
using Xunit;


namespace TournamentSystemTest {
	public class PersonTest {
		private Person p1;
		private Tournament tournament;
		private Team t1;
		public PersonTest() {
			//Arrange
			p1 = new Person("Hans", "Eriksen", "Erik", "PersonEmail.dk", new DateTime(2003, 10, 09));
			tournament = new Tournament(1, "Tournament1", "BeerPong", "Test description",
				new DateTime(2023, 10, 22, 18, 00, 00), 4);
			t1 = new Team("Team one");
		}

		[Fact]
		public void PersonCreated() {
			//Arrange
			string expectedFirstName = "Hans";
			string expectedLastName = "Eriksen";
			string expectedNickname = "Erik";
			string expectedEmail = "PersonEmail.dk";
			DateTime expectedDateTime = new DateTime(2003, 10, 09);

			//Act
			p1 = new Person("Hans", "Eriksen", "Erik", "PersonEmail.dk", new DateTime(2003, 10, 09));

			//Assert FirstName
			Assert.Equal(expectedFirstName, p1.PersonFirstName);
			//Assert LastName
			Assert.Equal(expectedLastName, p1.PersonLastName);
			//Assert Nickname
			Assert.Equal(expectedNickname, p1.PersonNickname);
			//Assert PersonEmail
			Assert.Equal(expectedEmail, p1.PersonEmail);
			//Assert BirthDate
			Assert.Equal(expectedDateTime, p1.PersonBirthdate);
		}

		[Fact]
		public void PersonJoinedTeam() {
			//Arrange
			int expectedNoOfPeoopleInTeam = 1;

			//Act
			p1.JoinTeam(t1);

			//Assert
			Assert.Equal(expectedNoOfPeoopleInTeam, t1.peopleInTeam.Count);
		}

		[Fact]
		public void EnrollTournament() {
			//Arrange
			Person expectedPerson = p1;

			//Act
			p1.EnrollInTournament(tournament);

			//Assert
			Assert.Equal(expectedPerson, tournament.EnrollmentCollection.First());
		}
	}
}
