using TournamentSystem.Models;
using Dapper;

namespace TournamentSystem.DataAccess {
	public class PersonDao : IPersonDao{
		private readonly DbContext _dbContext;

		public PersonDao(DbContext dbContext)
		{
			_dbContext = dbContext;
		}
		public List<Person> GetAllPersons()
		{
			List<Person> listOfPersons = null;
			string sqlQuery = "SELECT PersonId, PersonFirstName, PersonLastName, PersonNickname, Email, Birthdate FROM Person";

			using (_dbContext.Connection)
			{
				listOfPersons = _dbContext.Connection.Query<Person>(sqlQuery).ToList();
			}

			return listOfPersons;
		}

		public Person GetById(int id)
		{
			Person person = null;
			string sqlQuery =
				"SELECT PersonId, PersonFirstName, PersonLastName, PersonNickname, Email, Birthdate FROM Person WHERE PersonId = @personId";
			var parameters = new {personId = id};
			using (_dbContext.Connection)
			{
				person = _dbContext.Connection.QuerySingle<Person>(sqlQuery, parameters);
			}

			return person;
		}

		public void UpdatePerson(Person person)
		{
			string sqlQuery =
				"UPDATE Person SET @personFirstName, @personLastName, @personNickname, @mail, @birthdate WHERE PersonId = @personId";
			using (_dbContext.Connection)
			{
				_dbContext.Connection.Execute(sqlQuery, new
				{
					personFirstName = person.PersonFirstName,
					personLastName = person.PersonLastName,
					personNickname = person.PersonNickname,
					email = person.Email,
					birthdate = person.Birthdate,
					personId = person.PersonId
				});
			}
		}

		public bool DeletePerson(int id)
		{
			throw new NotImplementedException();
		}
	}
}
