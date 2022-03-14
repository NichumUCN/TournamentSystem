using TournamentSystem.Models;

namespace TournamentSystem.DataAccess {
	public interface IPersonDao {
		List<Person> GetAllPersons();
		Person GetById(int id);
		bool UpdatePerson(Person person);
		bool DeletePerson(int id);
		bool CreatePerson(Person person);
	}
}
