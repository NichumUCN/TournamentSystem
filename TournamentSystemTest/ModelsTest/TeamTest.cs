using System;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using Xunit;
using TournamentSystem.Models;

namespace TournamentSystemTest {
	public class TeamTest {
		private Team t1;
		private Team t2;
		private Person p1;
		private Person p2;
		private Person p3;
		private Tournament tournament;
		public TeamTest() {
			//Arrange
			t1 = new Team("Team 1");
			t2 = new Team("Team 2");
			p1 = new Person("Hans", "Eriksen", "Erik", "Email.dk", new DateTime(2003, 10, 09));
			p2 = new Person("Jens", "Jensen", "Jenner", "nyEmail.dk", new DateTime(2000, 09, 12));
			p3 = new Person("Agnes", "Agnesen", "Anger", "test@mail.com", new DateTime(1999, 09, 01));
			tournament = new Tournament(1, "Tournament one", "BeerPong", "Test description",
				new DateTime(2023, 10, 21, 12, 00, 00), 4);
		}

		[Fact]
		public void TeamCreated() {
			//Arrange
			string expedtedName = "Team 1";

			//Act
			t1.TeamName = "Team 1";

			//Assert
			Assert.Equal(expedtedName, t1.TeamName);
		}

		[Fact]
		public void EnrollTeam() {
			//Arrange
			Team expectedTeam = t1;
			
			//Act
			t1.EnrollInTournament(tournament);

			//Assert
			Assert.Equal(expectedTeam, tournament.EnrollmentCollection.First());
		}

		[Fact]
		public void JoinedTeam() {
			//Arrange
			int expectedPeopleJoined = 1;
			//Act
			t1.JoinTeam(p1);

			//Assert
			Assert.Equal(expectedPeopleJoined, t1.peopleInTeam.Count);
		}
	}
}
