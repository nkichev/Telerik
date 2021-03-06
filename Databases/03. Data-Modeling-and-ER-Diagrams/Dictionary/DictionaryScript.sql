USE [master]
GO
/****** Object:  Database [Dictionary]    Script Date: 24.8.2014 г. 17:20:42 ******/
CREATE DATABASE [Dictionary]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Dictionary', FILENAME = N'E:\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Dictionary.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Dictionary_log', FILENAME = N'E:\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Dictionary_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Dictionary] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Dictionary].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Dictionary] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Dictionary] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Dictionary] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Dictionary] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Dictionary] SET ARITHABORT OFF 
GO
ALTER DATABASE [Dictionary] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Dictionary] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Dictionary] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Dictionary] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Dictionary] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Dictionary] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Dictionary] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Dictionary] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Dictionary] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Dictionary] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Dictionary] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Dictionary] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Dictionary] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Dictionary] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Dictionary] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Dictionary] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Dictionary] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Dictionary] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Dictionary] SET  MULTI_USER 
GO
ALTER DATABASE [Dictionary] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Dictionary] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Dictionary] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Dictionary] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Dictionary] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Dictionary]
GO
/****** Object:  Table [dbo].[Alternatives]    Script Date: 24.8.2014 г. 17:20:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alternatives](
	[AlternativeID] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Alternatives] PRIMARY KEY CLUSTERED 
(
	[AlternativeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Languages]    Script Date: 24.8.2014 г. 17:20:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Languages](
	[LanguageID] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Languages] PRIMARY KEY CLUSTERED 
(
	[LanguageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PartOfSpeech]    Script Date: 24.8.2014 г. 17:20:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PartOfSpeech](
	[PartOfSpeechId] [int] IDENTITY(1,1) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PartOfSpeech] PRIMARY KEY CLUSTERED 
(
	[PartOfSpeechId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Word_Alternatives]    Script Date: 24.8.2014 г. 17:20:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Word_Alternatives](
	[WordID] [uniqueidentifier] NOT NULL,
	[AlternativeID] [uniqueidentifier] NOT NULL,
	[TypeOfAlternativeWord] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Word_Alternatives] PRIMARY KEY CLUSTERED 
(
	[WordID] ASC,
	[AlternativeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Words]    Script Date: 24.8.2014 г. 17:20:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Words](
	[WordID] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[Name] [uniqueidentifier] NOT NULL,
	[Explanation] [nvarchar](50) NOT NULL,
	[LanguageID] [uniqueidentifier] NOT NULL,
	[AntonymID] [int] NOT NULL,
	[PartOfSpeechID] [int] NOT NULL,
 CONSTRAINT [PK_Words] PRIMARY KEY CLUSTERED 
(
	[WordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Alternatives] ADD  CONSTRAINT [DF_Alternatives_AlternativeID]  DEFAULT (newid()) FOR [AlternativeID]
GO
ALTER TABLE [dbo].[Languages] ADD  CONSTRAINT [DF_Languages_LanguageID]  DEFAULT (newid()) FOR [LanguageID]
GO
ALTER TABLE [dbo].[Words] ADD  CONSTRAINT [DF_Words_WordID]  DEFAULT (newid()) FOR [WordID]
GO
ALTER TABLE [dbo].[Word_Alternatives]  WITH CHECK ADD  CONSTRAINT [FK_Word_Alternatives_Alternatives] FOREIGN KEY([AlternativeID])
REFERENCES [dbo].[Alternatives] ([AlternativeID])
GO
ALTER TABLE [dbo].[Word_Alternatives] CHECK CONSTRAINT [FK_Word_Alternatives_Alternatives]
GO
ALTER TABLE [dbo].[Word_Alternatives]  WITH CHECK ADD  CONSTRAINT [FK_Word_Alternatives_Words] FOREIGN KEY([WordID])
REFERENCES [dbo].[Words] ([WordID])
GO
ALTER TABLE [dbo].[Word_Alternatives] CHECK CONSTRAINT [FK_Word_Alternatives_Words]
GO
ALTER TABLE [dbo].[Word_Alternatives]  WITH CHECK ADD  CONSTRAINT [FK_Word_Alternatives_Words1] FOREIGN KEY([TypeOfAlternativeWord])
REFERENCES [dbo].[Words] ([WordID])
GO
ALTER TABLE [dbo].[Word_Alternatives] CHECK CONSTRAINT [FK_Word_Alternatives_Words1]
GO
ALTER TABLE [dbo].[Words]  WITH CHECK ADD  CONSTRAINT [FK_Words_Languages] FOREIGN KEY([LanguageID])
REFERENCES [dbo].[Languages] ([LanguageID])
GO
ALTER TABLE [dbo].[Words] CHECK CONSTRAINT [FK_Words_Languages]
GO
ALTER TABLE [dbo].[Words]  WITH CHECK ADD  CONSTRAINT [FK_Words_PartOfSpeech] FOREIGN KEY([PartOfSpeechID])
REFERENCES [dbo].[PartOfSpeech] ([PartOfSpeechId])
GO
ALTER TABLE [dbo].[Words] CHECK CONSTRAINT [FK_Words_PartOfSpeech]
GO
ALTER TABLE [dbo].[Words]  WITH CHECK ADD  CONSTRAINT [FK_Words_Words] FOREIGN KEY([Name])
REFERENCES [dbo].[Words] ([WordID])
GO
ALTER TABLE [dbo].[Words] CHECK CONSTRAINT [FK_Words_Words]
GO
USE [master]
GO
ALTER DATABASE [Dictionary] SET  READ_WRITE 
GO
