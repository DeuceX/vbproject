USE [try.db]
go

/* Delete previously created tables */

IF OBJECT_ID('dbo.CardSet', 'U') IS NOT NULL
DROP TABLE CardSet;

IF OBJECT_ID('dbo.Card', 'U') IS NOT NULL
DROP TABLE [Card];

/* Add and populate CardSet table */

CREATE TABLE CardSet (
	Id int primary key identity(1,1),
	[Name] nvarchar(50) not null,
	[Description] nvarchar(250),
	Price float not null,
	ImageUrl varchar(250)
)

INSERT INTO CardSet
	([Name], [Description], Price)
VALUES 
	('Card Set Name 1', 'CS Description 1', 0),
	('Card Set Name 2', 'CS Description 2', 9.99)

/* Add and populate Card table */

CREATE TABLE [Card] (
	Id int primary key identity(1,1),
	CardSetId int not null,
	foreign key (CardSetId) references CardSet(Id),
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