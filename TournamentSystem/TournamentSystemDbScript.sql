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



