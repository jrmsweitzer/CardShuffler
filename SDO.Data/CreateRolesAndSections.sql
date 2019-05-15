MERGE INTO Role AS Target
USING (VALUES
		(1, 'WebMaster'),
		(2, 'Admin'),
		(3, 'User')
)
AS Source (RoleId, Title)
ON Target.RoleId = Source.RoleId
WHEN NOT MATCHED BY Target THEN
INSERT (Title)
VALUES (Title);

MERGE INTO Section AS Target
USING (VALUES
		(1, 'Trades & Stores'),
		(2, 'Online Tournaments'),
		(3, 'Set Discussions'),
		(4, 'Card Discussions'),
		(5, 'Deck Discussions')
)
AS Source (SectionId, Title)
ON Target.SectionId = Source.SectionId
WHEN NOT MATCHED BY TARGET THEN
INSERT (Title)
VALUES (Title);