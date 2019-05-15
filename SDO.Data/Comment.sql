CREATE TABLE [dbo].[Comment]
(
	[CommentId]			INT IDENTITY(1, 1)	NOT NULL,
	[PostId]			INT					NOT NULL,
	[UserId]			INT					NOT NULL,
	[CommentDateTime]	DATETIME			NOT NULL,
	[Content]			NVARCHAR(300)		NOT NULL,
	[Upvotes]			INT					NOT NULL,
	[Downvotes]			INT					NOT NULL,
	[HasBeenEdited]		BINARY				NOT NULL,
	[LastEditDateTime]	DATETIME			NOT NULL,
	PRIMARY KEY CLUSTERED ([CommentId] ASC),
	CONSTRAINT [FK_dbo.Comment_dbo.Post] FOREIGN KEY ([PostId])
		REFERENCES [dbo].[Post] ([PostId]) ON DELETE NO ACTION,
	CONSTRAINT [FK_dbo.Comment_dbo.User] FOREIGN KEY ([UserId])
		REFERENCES [dbo].[User] ([UserId]) ON DELETE NO ACTION,
)
