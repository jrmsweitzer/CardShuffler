CREATE TABLE [dbo].[Section]
(
	[SectionId] INT				IDENTITY (1, 1) NOT NULL,
	[Title]		NVARCHAR(50)	NULL,
	PRIMARY KEY CLUSTERED ([SectionId] ASC)
)
