using TournamentSystem.Models;
using Dapper;

namespace TournamentSystem.DataAccess {
	public class PersonDao : IPersonDao {
		private readonly DbContext? _dbContext;

		public PersonDao(DbContext? dbContext) {
			_dbContext = dbContext;
		}

		public List<Person> GetAllPersons() {
			List<Person>? listOfPersons = null;
			string sqlQuery =
				"SELECT personId, personFirstName, personLastName, personNickname, email, birthdate FROM Person";
			using (_dbContext?.Connection) {
				listOfPersons = _dbContext?.Connection.Query<Person>(sqlQuery).ToList();
			}

			return listOfPersons;
		}

		public Person GetById(int id) {
			Person person = null;
			string sqlQuery =
				"SELECT personId, personFirstName, personLastName, personNickname, email, birthdate FROM Person WHERE personId = @personId";
			var parameters = new { personId = id };
			using (_dbContext?.Connection) {
				person = _dbContext.Connection.QuerySingle<Person>(sqlQuery, parameters);
			}

			return person;
		}

		//public bool UpdatePerson(Person person)
		//{
		//	throw new NotImplementedException();
		//}

		public bool UpdatePerson(Person person) {
			bool restult = false;
			string sqlQuery =
				"UPDATE Person SET personFirstName = @firstName, personLastName = @lastName, personNickname = @nickname, email = @emailIn WHERE personId = @id";
			var param = new {
				firstName = person.PersonFirstName,
				lastName = person.PersonLastName,
				nickname = person.PersonNickname,
				emailIn = person.Email,
				id = person.PersonId
			};
			using (_dbContext.Connection) {
				if (_dbContext.Connection.Execute(sqlQuery, param) == 1) {
					restult = true;
				}
			}

			return restult;
		}

		public bool DeletePerson(int personId) {
			bool result = false;
			string sqlQuery = "DELETE FROM Person WHERE personId = @id";
			using (_dbContext.Connection) {
				var param = new { id = personId };
				if (_dbContext.Connection.Execute(sqlQuery, param) == 1) {
					result = true;
				}
			}

			return result;
		}

		//public bool CreatePersonFromForm(Person person)
		//{
		//	bool result = false;
		//	string sqlQuery = "";
		//	using (_dbContext.Connection)
		//	{
		//		var param = new
		//		{
		//			personFirstName = person.PersonFirstName,
		//			personLastName = person.PersonLastName,
		//			personNickname = person.PersonNickname,
		//			email = person.Email
		//			//birthdate = person.Birthdate
		//		};
		//		if (_dbContext.Connection.Execute(sqlQuery, param) == 1)
		//		{
		//			result = true;
		//		}

		//		return result;
		//	}

		public bool CreatePerson(Person person) {
			bool result = false;
			string sqlQuery =
				"INSERT INTO Person (personFirstName, personLastName, personNickname, email) VALUES (@personFirstName, @personLastName, @personNickname, @email)";
			using (_dbContext.Connection) {
				var param = new {
					personFirstName = person.PersonFirstName,
					personLastName = person.PersonLastName,
					personNickname = person.PersonNickname,
					email = person.Email
					//birthdate = person.Birthdate
				};
				if (_dbContext.Connection.Execute(sqlQuery, param) == 1) {
					result = true;
				}
			}
			return result;
		}
	}

}