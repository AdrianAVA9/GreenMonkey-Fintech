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