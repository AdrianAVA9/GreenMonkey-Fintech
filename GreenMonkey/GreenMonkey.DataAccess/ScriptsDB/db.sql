CREATE TABLE [dbo].[TBL_Suscriptor](
	[Code] [nvarchar](4) NOT NULL PRIMARY KEY,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](250) NOT NULL,
	[Owner] [nvarchar](50) NOT NULL,
	[BaseUrl] [nvarchar](50) NOT NULL
)