USE [master]
GO
/****** Object:  Database [Mission]    Script Date: 12/11/2017 3:50:59 PM ******/
CREATE DATABASE [Mission]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Mission', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\Mission.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Mission_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\Mission_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Mission] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Mission].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Mission] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Mission] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Mission] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Mission] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Mission] SET ARITHABORT OFF 
GO
ALTER DATABASE [Mission] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Mission] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Mission] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Mission] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Mission] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Mission] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Mission] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Mission] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Mission] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Mission] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Mission] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Mission] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Mission] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Mission] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Mission] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Mission] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Mission] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Mission] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Mission] SET  MULTI_USER 
GO
ALTER DATABASE [Mission] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Mission] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Mission] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Mission] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Mission] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Mission] SET QUERY_STORE = OFF
GO
USE [Mission]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Mission]
GO
/****** Object:  Table [dbo].[MissionQuestions]    Script Date: 12/11/2017 3:50:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MissionQuestions](
	[questionId] [int] NOT NULL,
	[missId] [int] NOT NULL,
	[userId] [int] NOT NULL,
	[question] [varchar](1000) NOT NULL,
	[answer] [varchar](1000) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Missions]    Script Date: 12/11/2017 3:50:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Missions](
	[missId] [int] NOT NULL,
	[missName] [varchar](50) NOT NULL,
	[missPresidentFirstName] [varchar](50) NOT NULL,
	[missPresidentLastName] [varchar](50) NOT NULL,
	[missAddressLine1] [varchar](50) NOT NULL,
	[missAddressLine2] [varchar](50) NULL,
	[missCity] [varchar](50) NOT NULL,
	[missState] [varchar](50) NOT NULL,
	[missZip] [varchar](5) NOT NULL,
	[missLanguage] [varchar](50) NOT NULL,
	[missClimate] [varchar](50) NOT NULL,
	[missDominantReligion] [varchar](50) NOT NULL,
	[missFlag] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 12/11/2017 3:50:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[userId] [int] NOT NULL,
	[userEmail] [varchar](50) NOT NULL,
	[userPassword] [varchar](50) NOT NULL,
	[userFirstName] [varchar](50) NOT NULL,
	[userLastName] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Mission] SET  READ_WRITE 
GO
