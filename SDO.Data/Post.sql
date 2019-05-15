CREATE TABLE [dbo].[Post]
(
	[PostId]		INT IDENTITY	NOT NULL,
	[SectionId]		INT				NOT NULL,
	[UserId]		INT				NOT NULL,
	[PostDateTime]	DATETIME		NOT NULL,
	[Title]			NVARCHAR(50)	NOT NULL,
	[Content]		NVARCHAR(300)	NOT NULL,
	[Upvotes]		INT				NOT NULL,
	[Downvotes]		INT				NOT NULL,
	[HasBeenEdited]	BINARY			NOT NULL,
	PRIMARY KEY CLUSTERED ([PostId] ASC),
	CONSTRAINT [FK_dbo.Post_dbo.User_UserId] FOREIGN KEY (UserId)
		REFERENCES [dbo].[User] ([UserId]) ON DELETE NO ACTION,
	CONSTRAINT [FK.dbo_Post_dbo.Section] FOREIGN KEY (SectionId)
		REFERENCES [dbo].[Section] ([SectionId]) ON DELETE NO ACTION
)
