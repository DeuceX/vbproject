USE [try.db]
go

IF OBJECT_ID('dbo.Card', 'U') IS NOT NULL
DROP TABLE [Card];

CREATE TABLE [Card] (
	Id int primary key identity(1,1),
	CardSetId int not null,
	[Name] nvarchar(50) not null,
	[Description] nvarchar(250),
	ImageUrl nvarchar(250),
	[Type] nvarchar(50)
)

INSERT INTO [Card]
	(CardSetId, [Name], [Description], ImageUrl, [Type])
VALUES 
	(1, 'Name 1', 'Description 1', '~/dist/data/card.png', 'card type'),
	(1, 'Name 2', 'Description 2', '~/dist/data/card.png', 'card type'),
	(1, 'Name 3', 'Description 3', '~/dist/data/card.png', 'card type'),
	(1, 'Name 4', 'Description 4', '~/dist/data/card.png', 'card type')