using TournamentSystem.Models;

namespace TournamentSystem.Managers {
	public interface IPersonManager
	{
		//void CreatePersonFromForm();
		List<Person> GetAllPersons();
		Person GetPersonByEmail(string personEmail);
		bool UpdatePerson(string personEmail, IFormCollection collection);
		bool DeletePerson(string personEmail);
		bool CreatePersonFromForm(IFormCollection collection);
		bool CreatePerson(string firstName, string lastName, string nickname, string email, DateTime birthdate);
	}
}
