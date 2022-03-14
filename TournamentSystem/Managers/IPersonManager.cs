using TournamentSystem.Models;

namespace TournamentSystem.Managers {
	public interface IPersonManager
	{
		//void CreatePerson();
		List<Person> GetAllPersons();
		Person GetPersonById(int personId);
		bool UpdatePerson(int personId, IFormCollection collection);
		bool DeletePerson(int personId);
		bool CreatePerson(IFormCollection collection);
	}
}
