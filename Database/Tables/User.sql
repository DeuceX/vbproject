USE [try.db]
go

IF OBJECT_ID('dbo.User', 'U') IS NOT NULL
DROP TABLE [User];

CREATE TABLE [User] (
	Id int primary key identity(1,1),
	[UserName] nvarchar(50) not null,
	[FirstName] nvarchar(50),
	[LastNmae] nvarchar(50),
	[PersonalInfo] nvarchar(250),
	AvatarUrl nvarchar(250),
	Birthday date
)

INSERT INTO [User]
	([UserName], [FirstName], [LastNmae], [PersonalInfo], AvatarUrl, Birthday)
VALUES 
	('nickname', 'Vasiliy', 'Pupkin', 'This is my page and here is info about me', 'avar_url', '1992-10-10')