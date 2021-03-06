USE [master]
GO
/****** Object:  Database [InstaScaler]    Script Date: 5/30/2019 8:13:34 AM ******/
CREATE DATABASE [InstaScaler]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'InstaScaler', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\InstaScaler.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'InstaScaler_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\InstaScaler_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [InstaScaler] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [InstaScaler].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [InstaScaler] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [InstaScaler] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [InstaScaler] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [InstaScaler] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [InstaScaler] SET ARITHABORT OFF 
GO
ALTER DATABASE [InstaScaler] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [InstaScaler] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [InstaScaler] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [InstaScaler] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [InstaScaler] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [InstaScaler] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [InstaScaler] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [InstaScaler] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [InstaScaler] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [InstaScaler] SET  DISABLE_BROKER 
GO
ALTER DATABASE [InstaScaler] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [InstaScaler] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [InstaScaler] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [InstaScaler] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [InstaScaler] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [InstaScaler] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [InstaScaler] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [InstaScaler] SET RECOVERY FULL 
GO
ALTER DATABASE [InstaScaler] SET  MULTI_USER 
GO
ALTER DATABASE [InstaScaler] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [InstaScaler] SET DB_CHAINING OFF 
GO
ALTER DATABASE [InstaScaler] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [InstaScaler] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [InstaScaler] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'InstaScaler', N'ON'
GO
ALTER DATABASE [InstaScaler] SET QUERY_STORE = OFF
GO
USE [InstaScaler]
GO
/****** Object:  Table [dbo].[Campaign]    Script Date: 5/30/2019 8:13:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Campaign](
	[campaign_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NOT NULL,
	[country] [nvarchar](20) NOT NULL,
	[budget] [decimal](18, 0) NOT NULL,
	[Goal] [nvarchar](50) NOT NULL,
	[Category] [nvarchar](max) NULL,
	[Date] [date] NULL,
	[URL] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Campaign] PRIMARY KEY CLUSTERED 
(
	[campaign_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Campaign] ON 

INSERT [dbo].[Campaign] ([campaign_id], [name], [country], [budget], [Goal], [Category], [Date], [URL]) VALUES (2, N'n1', N'Egypt', CAST(200 AS Decimal(18, 0)), N'Awareness', N'Technology', NULL, N'www.google.com')
INSERT [dbo].[Campaign] ([campaign_id], [name], [country], [budget], [Goal], [Category], [Date], [URL]) VALUES (3, N'n1', N'Egypt', CAST(250 AS Decimal(18, 0)), N'Awareness', N'Technology', CAST(N'1994-10-10' AS Date), N'www.google.com')
INSERT [dbo].[Campaign] ([campaign_id], [name], [country], [budget], [Goal], [Category], [Date], [URL]) VALUES (4, N'n7', N'USA', CAST(149 AS Decimal(18, 0)), N'Awareness', N'Technology', NULL, N'www.google.com/n1')
INSERT [dbo].[Campaign] ([campaign_id], [name], [country], [budget], [Goal], [Category], [Date], [URL]) VALUES (5, N'n7', N'USA', CAST(149 AS Decimal(18, 0)), N'Awareness', N'Technology', CAST(N'2019-05-05' AS Date), N'www.google.com/n1')
INSERT [dbo].[Campaign] ([campaign_id], [name], [country], [budget], [Goal], [Category], [Date], [URL]) VALUES (6, N'A2', N'EGY', CAST(149 AS Decimal(18, 0)), N'Awarness', N'Food', NULL, N'Test')
INSERT [dbo].[Campaign] ([campaign_id], [name], [country], [budget], [Goal], [Category], [Date], [URL]) VALUES (7, N'A2', N'EGY', CAST(149 AS Decimal(18, 0)), N'Awarness', N'Food', NULL, N'Test')
INSERT [dbo].[Campaign] ([campaign_id], [name], [country], [budget], [Goal], [Category], [Date], [URL]) VALUES (8, N'A4', N'EGY', CAST(149 AS Decimal(18, 0)), N'Awarness', N'', NULL, N'https://www.google.com/')
INSERT [dbo].[Campaign] ([campaign_id], [name], [country], [budget], [Goal], [Category], [Date], [URL]) VALUES (9, N'A5', N'Test', CAST(149 AS Decimal(18, 0)), N'Awarness', N'', NULL, N'https://www.wuzzuf.net')
INSERT [dbo].[Campaign] ([campaign_id], [name], [country], [budget], [Goal], [Category], [Date], [URL]) VALUES (10, N'A5', N'Test', CAST(149 AS Decimal(18, 0)), N'Awarness', N'', NULL, N'https://www.wuzzuf.net')
INSERT [dbo].[Campaign] ([campaign_id], [name], [country], [budget], [Goal], [Category], [Date], [URL]) VALUES (11, N'A6', N'EGY', CAST(149 AS Decimal(18, 0)), N'AA', N'', NULL, N'https://www.google.com')
INSERT [dbo].[Campaign] ([campaign_id], [name], [country], [budget], [Goal], [Category], [Date], [URL]) VALUES (12, N'AA', N'test', CAST(149 AS Decimal(18, 0)), N'AA', N'', NULL, N'https://www.google.com')
INSERT [dbo].[Campaign] ([campaign_id], [name], [country], [budget], [Goal], [Category], [Date], [URL]) VALUES (13, N'aa', N'aa', CAST(149 AS Decimal(18, 0)), N'ss', NULL, NULL, N'https://www.google.com')
INSERT [dbo].[Campaign] ([campaign_id], [name], [country], [budget], [Goal], [Category], [Date], [URL]) VALUES (14, N'aaa', N'X', CAST(149 AS Decimal(18, 0)), N'Q', NULL, NULL, N'https://www.google.com')
SET IDENTITY_INSERT [dbo].[Campaign] OFF
USE [master]
GO
ALTER DATABASE [InstaScaler] SET  READ_WRITE 
GO
