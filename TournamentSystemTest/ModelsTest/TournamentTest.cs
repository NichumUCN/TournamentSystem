using System;
using TournamentSystem.Models;
using Xunit;

namespace TournamentSystemTest {
	public class TournamentTest {
		private Tournament tournament;
		private Person p1;
		private Person p2;
		private Team t1;
		public TournamentTest() {
			//Arrange
			tournament = new Tournament(1, "Tournament1", "BeerPong", "Test description",
				new DateTime(2023, 10, 22, 18, 00, 00), 4);
			p1 = new Person("Hans", "Eriksen", "Erik", "Email.dk", new DateTime(2003, 10, 09));
			p2 = new Person("Jens", "Jensen", "Jenner", "nyEmail.dk", new DateTime(2000, 09, 12));
			t1 = new Team("First team");
		}

		[Fact]
		public void EnrolledInTournament() {
			//Arrange
			int expectedParticipantAmount = 2;

			//Act
			tournament.Enroll(p1);
			tournament.Enroll(t1);

			//Assert
			Assert.Equal(expectedParticipantAmount, tournament.EnrollmentCollection.Count);
		}

		[Fact]
		public void TournamentCreated() {
			//Arrange
			int expectedId = 1;
			string expectedName = "Tournament1";
			string expectedGame = "BeerPong";
			string expectedDescription = "Test description";
			DateTime expectedDateOfEvent = new DateTime(2023, 10, 22, 18, 00, 00);
			int expectedMaxNoOfParticipants = 8;

			//Act
			Tournament t = new Tournament(1, "Tournament1", "BeerPong", "Test description",
				new DateTime(2023, 10, 22, 18, 00, 00), 8);

			//Assert ID
			Assert.Equal(expectedId, t.TournamentId);
			//Assert Name
			Assert.Equal(expectedName, t.TournamentName);
			//Assert Game
			Assert.Equal(expectedGame, t.TournamentGame);
			//Assert Description
			Assert.Equal(expectedDescription, t.TournamentDescription);
			//Assert Time of event
			Assert.Equal(expectedDateOfEvent, t.TimeOfEvent);
			//Assert Max participants
			Assert.Equal(expectedMaxNoOfParticipants, t.MaxNoParticipants);
		}

		[Fact]
		public void EnrolledNotExceedMax() {
			//Arrange
			int maxNoOfParticipants = 4;
			int expectedParticipants = 4;
			int insertedParticipants = 5;
			tournament = new Tournament(1, "Tournament1", "BeerPong", "Test description",
				new DateTime(2023, 10, 22, 18, 00, 00), maxNoOfParticipants);

			//Act
			for (int i = 0; i < insertedParticipants; i++) {
				Team t = new Team("Team" + i);
				tournament.Enroll(t);
			}

			//Assert not more
			Assert.NotEqual(insertedParticipants, tournament.EnrollmentCollection.Count);
			//Assert excact
			Assert.Equal(expectedParticipants, tournament.EnrollmentCollection.Count);
		}
	}
}
