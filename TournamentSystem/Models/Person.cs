using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace TournamentSystem.Models {
	public class Person : IEnrollable{
	public int PersonId;
	public string PersonFirstName;
	public string PersonLastName;
	public string PersonNickname;
	public string Email;
	public DateTime Birthdate;
		

	public Person(int personId, string personFirstName, string personLastName, string personNickname, string email,
		DateTime birthdate)
	{
		PersonId = personId;
		PersonFirstName = personFirstName;
		PersonLastName = personLastName;
		PersonNickname = personNickname;
		Email = email;
		Birthdate = birthdate;
	}

	public Person(string personFirstName, string personLastName, string personNickname, string email,
		DateTime birthdate)
	{
		PersonFirstName = personFirstName;
		PersonLastName = personLastName;
		PersonNickname = personNickname;
		Email = email;
		Birthdate = birthdate;
	}

	public Person(int personId, string personFirstName, string personLastName, string personNickname, string email)
	{
		PersonId = personId;
		PersonFirstName = personFirstName;
		PersonLastName = personLastName;
		PersonNickname = personNickname;
		Email = email;
		//Email = email;
		//Birthdate = birthdate;
	}

	public bool EnrollInTournament(Tournament tournament)
	{
		return tournament.Enroll(this);
	}

	public bool JoinTeam(Team team)
	{
		return team.JoinTeam(this);
	}
	}
}
