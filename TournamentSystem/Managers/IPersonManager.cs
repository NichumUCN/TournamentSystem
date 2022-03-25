using TournamentSystem.Models;

namespace TournamentSystem.Managers {
	public interface IPersonManager
	{
		//void CreatePersonFromForm();
		List<Person> GetAllPersons();
		Person GetPersonById(int personId);
		bool UpdatePerson(int personId, IFormCollection collection);
		bool DeletePerson(int personId);
		bool CreatePersonFromForm(IFormCollection collection);
		bool CreatePerson(string firstName, string lastName, string nickname, string email, DateTime birthdate);
	}
}
