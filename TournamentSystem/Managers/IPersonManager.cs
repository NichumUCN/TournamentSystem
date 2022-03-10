using TournamentSystem.Models;

namespace TournamentSystem.Managers {
	public interface IPersonManager
	{
		//void CreatePerson();
		List<Person> GetAllPersons();
		Person GetPersonById(int id);
		void UpdatePerson(Person person);
		void DeletePerson(Person person);
	}
}
