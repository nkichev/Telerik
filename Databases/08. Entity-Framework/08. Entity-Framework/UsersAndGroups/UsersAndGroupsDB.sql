USE [master]
GO
/****** Object:  Database [UsersAndGroups]    Script Date: 30.8.2014 г. 17:56:39 ******/
CREATE DATABASE [UsersAndGroups]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'UsersAndGroups', FILENAME = N'E:\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\UsersAndGroups.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'UsersAndGroups_log', FILENAME = N'E:\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\UsersAndGroups_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [UsersAndGroups] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [UsersAndGroups].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [UsersAndGroups] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [UsersAndGroups] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [UsersAndGroups] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [UsersAndGroups] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [UsersAndGroups] SET ARITHABORT OFF 
GO
ALTER DATABASE [UsersAndGroups] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [UsersAndGroups] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [UsersAndGroups] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [UsersAndGroups] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [UsersAndGroups] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [UsersAndGroups] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [UsersAndGroups] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [UsersAndGroups] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [UsersAndGroups] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [UsersAndGroups] SET  DISABLE_BROKER 
GO
ALTER DATABASE [UsersAndGroups] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [UsersAndGroups] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [UsersAndGroups] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [UsersAndGroups] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [UsersAndGroups] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [UsersAndGroups] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [UsersAndGroups] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [UsersAndGroups] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [UsersAndGroups] SET  MULTI_USER 
GO
ALTER DATABASE [UsersAndGroups] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [UsersAndGroups] SET DB_CHAINING OFF 
GO
ALTER DATABASE [UsersAndGroups] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [UsersAndGroups] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [UsersAndGroups] SET DELAYED_DURABILITY = DISABLED 
GO
USE [UsersAndGroups]
GO
/****** Object:  Table [dbo].[Groups]    Script Date: 30.8.2014 г. 17:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Groups](
	[GroupID] [int] IDENTITY(1,1) NOT NULL,
	[GroupName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Groups] PRIMARY KEY CLUSTERED 
(
	[GroupID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 30.8.2014 г. 17:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[GroupID] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Groups] FOREIGN KEY([GroupID])
REFERENCES [dbo].[Groups] ([GroupID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Groups]
GO
USE [master]
GO
ALTER DATABASE [UsersAndGroups] SET  READ_WRITE 
GO
