CREATE TABLE [dbo].[TBL_Suscriptor](
	[Code] [nvarchar](4) NOT NULL PRIMARY KEY,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](250) NOT NULL,
	[Owner] [nvarchar](50) NOT NULL,
	[BaseUrl] [nvarchar](50) NOT NULL,
	[Active] [char](1) NOT NULL DEFAULT('S'),
)


CREATE TABLE [dbo].[TBL_Suscriptor_Status](
	[Id] [int] IDENTITY(1,1) PRIMARY KEY,
	[Code] [nvarchar](4) NOT NULL,
	[Status] [nvarchar](10) NOT NULL,
	[UpdatedDate] [DateTime] NOT NULL
)


CREATE TABLE [dbo].[TBL_Customer](
	[Id] [nvarchar](15) NOT NULL PRIMARY KEY,
	[Name] [nvarchar](50) NOT NULL,
	[Lastname] [nvarchar](50) NOT NULL,
	[Nickname] [nvarchar](30) NOT NULL,
	[Status] [nvarchar](15) NOT NULL,
	[Birthdate] [Datetime] NOT NULL,
	[Phonenumber] [nvarchar(15)] NOT NULL,
	[Email] [nvarchar(50)] NOT NULL,
	[RegisteredAt] [Datetime] NOT NULL,
	[Active] [char](1) NOT NULL DEFAULT('S'),
)

CREATE TABLE TBL_Coin(
	Code [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Name [nvarchar](50) NOT NULL,
	FintechCode [nvarchar](4) NOT NULL
)


CREATE TABLE TBL_Account(
	Number [nvarchar](14) NOT NULL PRIMARY KEY,
	Consecutive [int] NOT NULL,
	Name [nvarchar](50) NOT NULL,
	Status [nvarchar](15) NOT NULL,
	CustomerId [nvarchar](15) NOT NULL,
	CoinCode [int] NOT NULL,
	RegisteredAt [datetime] NOT NULL
)


CREATE TABLE TBL_Transaction(
	Id [int] IDENTITY(1,1) PRIMARY KEY,
	Amount [decimal] NOT NULL,
	RegisteredAt [datetime] NOT NULL,
	Type [nvarchar](20) NOT NULL,
	AccountNumber [nvarchar](14) NOT NULL
)


ALTER TABLE TBL_Coin ADD FOREIGN KEY (FintechCode) REFERENCES TBL_Suscriptor(Code);
ALTER TABLE TBL_Account ADD FOREIGN KEY (CustomerId) REFERENCES TBL_Customer(Id);
ALTER TABLE TBL_Account ADD FOREIGN KEY (CoinCode) REFERENCES TBL_Coin(Code);
ALTER TABLE TBL_Transaction ADD FOREIGN KEY (AccountNumber) REFERENCES TBL_Account(Number);