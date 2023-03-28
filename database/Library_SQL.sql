CREATE DATABASE [Library]

CREATE TABLE [dbo].[Books](
	[BookId] [int] IDENTITY(1,1) NOT NULL primary key,
	[BookName] [varchar](50) NULL,
	[BookAouther] [varchar](50) NULL,
	[NumberPages] [int] NULL
)

CREATE TABLE [dbo].[Lendings](
	[UserId] [int] NULL FOREIGN KEY REFERENCES [dbo].[Users] ([UserId]),
	[BookId] [int] NULL FOREIGN KEY REFERENCES [dbo].[Books] ([BookId]),
	[StartDate] [date] NULL,
	[EndDate] [date] NULL
) 

CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL primary key,
	[UserFirstName] [varchar](50) NULL,
	[UserLastName] [varchar](50) NULL,
)
