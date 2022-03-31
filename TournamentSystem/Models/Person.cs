using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace TournamentSystem.Models {
	public class Person : IEnrollable{
	public string PersonFirstName;
	public string PersonLastName;
	public string PersonNickname;
	public readonly string PersonEmail;
	public DateTime PersonBirthdate;
		

	public Person(string personFirstName, string personLastName, string personNickname, string personEmail,
		DateTime personBirthdate)
	{
		PersonFirstName = personFirstName;
		PersonLastName = personLastName;
		PersonNickname = personNickname;
		PersonEmail = personEmail;
		PersonBirthdate = personBirthdate;
	}



	//public Person(string personFirstName, string personLastName, string personNickname, string personEmail)
	//{
	//	PersonFirstName = personFirstName;
	//	PersonLastName = personLastName;
	//	PersonNickname = personNickname;
	//	PersonEmail = personEmail;
	//	//PersonBirthdate = personBirthdate;
	//}

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
