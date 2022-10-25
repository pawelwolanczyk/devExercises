CREATE TABLE [dbo].[Deski](
	[DeskiID] [int] IDENTITY(1,1) NOT NULL,
	[Producent] [nvarchar](20) NULL,
	[Model] [nvarchar](60) NULL,
	[Waga] [tinyint] NULL,
	[Cena] [float] NULL,
	[Opinie] [varchar](50) NULL,
 CONSTRAINT [pk_Deski_DeskiID] PRIMARY KEY (DeskiID)
 )
GO


CREATE TABLE [dbo].[Okladziny](
	[OkladzinyID] [int] IDENTITY(1,1) NOT NULL,
	[Producent] [nvarchar](max) NULL,
	[Model] [nvarchar](max) NULL,
	[Grubosc] [float] NULL,
	[Waga] [decimal](18, 0) NULL,
	[Cena] [float] NULL,
	[Kolor] [nvarchar](max) NULL,
 CONSTRAINT [pk_Okladziny_OkladzinyID] PRIMARY KEY (OkladzinyID) 
)
GO


CREATE TABLE [dbo].[Pileczki](
	[Rodzaj] [varchar](20) NULL,
	[Producent] [varchar](20) NULL,
	[Model] [varchar](20) NULL,
	[Cena] [varchar](10) NULL
) 
GO


CREATE TABLE [dbo].[Zestawy](
	[ZestawyID] [int] IDENTITY(1,1) NOT NULL,
	[Nazwa] [nvarchar](30) NULL,
	[Opis] [nvarchar](100) NULL,
	[Okladzina1ID] [int] NULL,
	[Okladzina2ID] [int] NULL,
	[DeskaID] [int] NULL,
 CONSTRAINT [pk_Zestawy_ZestawyID] PRIMARY KEY (ZestawyID) 
)