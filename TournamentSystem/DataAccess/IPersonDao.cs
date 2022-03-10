using TournamentSystem.Models;

namespace TournamentSystem.DataAccess {
	public interface IPersonDao {
		List<Person> GetAllPersons();
		Person GetById(int id);
		void UpdatePerson(Person person);
		bool DeletePerson(int id);
	}
}
