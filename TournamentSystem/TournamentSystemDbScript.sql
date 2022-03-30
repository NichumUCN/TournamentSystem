USE [TournamentSystem]
GO

/****** Object:  Table [dbo].[Person]    Script Date: 10-03-2022 18:22:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


ALTER TABLE [dbo].[AspNetUsers] ADD Unique (NormalizedEmail)

CREATE TABLE [dbo].[Person](
	[PersonFirstName] [varchar](255) NULL,
	[PersonLastName] [varchar](255) NULL,
	[PersonNickname] [varchar](255) NULL,
	[PersonEmail] [nvarchar](256) PRIMARY KEY,
	[PersonBirthdate] [datetime] NULL,
	FOREIGN KEY (PersonEmail) REFERENCES AspNetUsers(NormalizedEmail)
	)

CREATE TABLE Tournament (
TournamentId INT PRIMARY KEY IDENTITY NOT NULL, 
TournamentName varchar(255) NOT NULL, 
TournamentDiscipline varchar(255) NOT NULL, 
TournamentDescription varchar(255) NULL, 
TimeOfEvent DATE NOT NULL, 
LatestTimeOfEnrollment DATE NOT NULL, 
MaxNoOfParticipants INT NULL
)

CREATE TABLE Team (
TeamId INT PRIMARY KEY IDENTITY NOT NULL, 
TeamName varchar(255) NOT NULL
)

CREATE TABLE EnrolledInTournament (
EnrollementId INT PRIMARY KEY IDENTITY NOT NULL,
TournamentId INT NOT NULL,
PersonId nvarchar(256),
TeamId INT,
FOREIGN KEY (TournamentId) REFERENCES Tournament(TournamentId),
FOREIGN KEY (TeamId) REFERENCES Team(TeamId),
FOREIGN KEY (PersonId) REFERENCES Person(PersonEmail)
)

