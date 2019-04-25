CREATE TABLE [dbo].[User]
(
	[UserId]			INT	IDENTITY (1, 1) NOT NULL,
	[Username]			NVARCHAR (50)		NOT NULL,
	[Email]				NVARCHAR (50)		NOT NULL,
	[RegistrationDate]	DATETIME			NOT NULL,
	[LastLoginDate]		DATETIME			NOT NULL,
	[RoleId]			INT					NOT NULL
	PRIMARY KEY CLUSTERED ([UserId] ASC),
	CONSTRAINT [FK_dbo.User_dbo.Role] FOREIGN KEY ([RoleId])
		REFERENCES [dbo].[Role] ([RoleId]) ON DELETE NO ACTION
)
