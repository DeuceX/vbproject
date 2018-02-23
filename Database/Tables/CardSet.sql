USE [try.db]
go

IF OBJECT_ID('dbo.CardSet', 'U') IS NOT NULL
DROP TABLE CardSet;

CREATE TABLE CardSet (
	Id int primary key identity(1,1),
	[Name] nvarchar(50) not null,
	[Description] nvarchar(250),
	Price float not null
)

INSERT INTO CardSet
	([Name], [Description], Price)
VALUES 
	('Card Set Name 1', 'CS Description 1', 0),
	('Card Set Name 2', 'CS Description 2', 9.99)