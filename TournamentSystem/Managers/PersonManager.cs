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

		public Person GetPersonByEmail(string personEmail) {
			Person person;
			IPersonDao personDao = DaoFactory.CreatePersonDao();
			try {
				person = personDao.GetByEmail(personEmail);
			} catch (Exception e) {
				Console.WriteLine(e);
				throw;
			}

			return person;
		}

		public bool UpdatePerson(string personEmail, IFormCollection collection) {
			bool result;
			IPersonDao personDao = DaoFactory.CreatePersonDao();
			try {
				Person person = personDao.GetByEmail(personEmail);
				
				personDao = DaoFactory.CreatePersonDao();

				person.PersonFirstName = collection["PersonFirstName"];
				person.PersonLastName = collection["PersonLastName"];
				person.PersonNickname = collection["PersonNickname"];
				result = personDao.UpdatePerson(person);
			} catch (Exception e) {
				Console.WriteLine(e);
				throw;
			}
			return result;
		}

		public bool DeletePerson(string personEmail) {
			bool result;
			IPersonDao personDao = DaoFactory.CreatePersonDao();
			try {
				result = personDao.DeletePerson(personEmail);
			} catch (Exception e) {
				Console.WriteLine(e);
				throw;
			}
			return result;
		}

		public bool CreatePersonFromForm(IFormCollection collection) {
			bool result = false;
			IPersonDao personDao = DaoFactory.CreatePersonDao();
			string firstname = collection["PersonFirstName"];
			string lastname = collection["PersonLastName"];
			string nickname = collection["PersonNickname"];
			string email = collection["PersonEmail"];
			//string birthdate = collection["PersonBirthdate"];
			Person person = new Person(firstname, lastname, nickname, email, new DateTime(1995, 02, 08));
			try {
				result = personDao.CreatePerson(person);
			} catch (Exception e) {
				Console.WriteLine(e);
				throw;
			}
			return result;
		}

		public bool CreatePerson(string firstName, string lastName, string nickname, string email, DateTime birthdate) {
			bool result = false;
			IPersonDao personDao = DaoFactory.CreatePersonDao();
			Person person = new Person(firstName, lastName, nickname, email, birthdate);
			try {
				if (personDao.CreatePerson(person)) {
					result = true;
				}
			} catch (Exception e) {
				Console.WriteLine(e);
				throw;
			}
			return result;
		}
	}
}
