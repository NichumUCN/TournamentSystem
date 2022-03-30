using TournamentSystem.Models;

namespace TournamentSystem.DataAccess {
	public interface IPersonDao {
		List<Person> GetAllPersons();
		Person GetByEmail(string personEmail);
		bool UpdatePerson(Person person);
		bool DeletePerson(string personEmail);
		bool CreatePerson(Person person);
	}
}
