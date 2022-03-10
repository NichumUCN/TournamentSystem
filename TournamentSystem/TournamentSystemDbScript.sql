USE [TournamentSystem]
GO

/****** Object:  Table [dbo].[Person]    Script Date: 10-03-2022 18:22:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Person](
	[personId] [int] IDENTITY(1,1) NOT NULL,
	[personFirstName] [varchar](255) NULL,
	[personLastName] [varchar](255) NULL,
	[personNickname] [varchar](255) NULL,
	[email] [varchar](255) NULL,
	[birthdate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[personId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


