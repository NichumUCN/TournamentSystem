using TournamentSystem.DataAccess;
using TournamentSystem.Models;

namespace TournamentSystem.Managers {
	public class PersonManager : IPersonManager {
		public List<Person> GetAllPersons() {
			List<Person> listOfPersons = null;
			IPersonDao personDao = DaoFactory.CreatePersonDao();
			try {
				listOfPersons = personDao.GetAllPersons();
			} catch (Exception e) {
				Console.WriteLine(e);
				throw;
			}

			return listOfPersons;
		}

		public Person GetPersonById(int personId) {
			Person person;
			IPersonDao personDao = DaoFactory.CreatePersonDao();
			try {
				person = personDao.GetById(personId);
			} catch (Exception e) {
				Console.WriteLine(e);
				throw;
			}

			return person;
		}

		public bool UpdatePerson(int personId, IFormCollection collection) {
			bool restult;
			IPersonDao personDao = DaoFactory.CreatePersonDao();
			try {
				Person person = personDao.GetById(personId);

				// Hvorfor skal der laves en ny connectionstring?
				// Den er jo static men der er fejl hvis ikke man opretter en ny hver gang der oprettes forbindelese til databasen?
				personDao = DaoFactory.CreatePersonDao();

				person.PersonFirstName = collection["PersonFirstName"];
				person.PersonLastName = collection["PersonLastName"];
				person.PersonNickname = collection["PersonNickname"];
				person.Email = collection["Email"];
				restult = personDao.UpdatePerson(person);
			} catch (Exception e) {
				Console.WriteLine(e);
				throw;
			}
			return restult;
		}

		public bool DeletePerson(int personId) {
			bool result;
			IPersonDao personDao = DaoFactory.CreatePersonDao();
			try {
				result = personDao.DeletePerson(personId);
			} catch (Exception e) {
				Console.WriteLine(e);
				throw;
			}

			return result;
		}

		public bool CreatePerson(IFormCollection collection) {
			bool result = false;
			IPersonDao personDao = DaoFactory.CreatePersonDao();
			string firstname = collection["PersonFirstName"];
			string lastname = collection["PersonLastName"];
			string nickname = collection["PersonNickname"];
			string email = collection["Email"];
			//string birthdate = collection["Birthdate"];
			Person person = new Person(firstname, lastname, nickname, email, new DateTime(1995, 02, 08));
			try {
				result = personDao.CreatePerson(person);
			} catch (Exception e) {
				Console.WriteLine(e);
				throw;
			}
			return result;
		}

	}
}
