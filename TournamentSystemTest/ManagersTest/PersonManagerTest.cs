using System;
using TournamentSystem.Managers;
using TournamentSystem.Models;
using Xunit;

namespace TournamentSystemTest.ManagersTest {
	public class PersonManagerTest
	{
		private PersonManager personManager;
		private Person p1;

		public PersonManagerTest()
		{
			personManager = new PersonManager();
			p1 = new Person("Jens", "Erik", "Eriksen", "testMail.dk", new DateTime(1973, 10, 25));
		}

		[Fact]
		public void CreatePerson()
		{
			//Arrange

			//Act
			p1 = new Person("Jens", "Erik", "Eriksen", "testMail.dk", new DateTime(1973, 10, 25));
			
		}
	}
}
