using TournamentSystem.DataAccess;
using TournamentSystem.Models;

namespace TournamentSystem.Managers {
	public class PersonManager : IPersonManager{
		public List<Person> GetAllPersons()
		{
			List<Person> listOfPersons = null;
			IPersonDao personDao = DaoFactory.CreatePersonDao();
			try
			{
				listOfPersons = personDao.GetAllPersons();
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}

			return listOfPersons;
		}

		public Person GetPersonById(int id)
		{
			Person person = null;
			IPersonDao personDao = DaoFactory.CreatePersonDao();
			try
			{
				person = personDao.GetById(id);
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}

			return person;
		}

		public void UpdatePerson(Person person)
		{

			IPersonDao personDao = DaoFactory.CreatePersonDao();
			try
			{
				personDao.UpdatePerson(person);
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}

		public void DeletePerson(Person person)
		{
			throw new NotImplementedException();
		}
	}
}
