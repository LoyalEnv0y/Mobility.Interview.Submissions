USE [master]
GO
/****** Object:  Database [Records]    Script Date: 24/01/2024 00:52:18 ******/
CREATE DATABASE [Records]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Records', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Records.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Records_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Records_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Records] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Records].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Records] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Records] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Records] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Records] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Records] SET ARITHABORT OFF 
GO
ALTER DATABASE [Records] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Records] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Records] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Records] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Records] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Records] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Records] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Records] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Records] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Records] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Records] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Records] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Records] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Records] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Records] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Records] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Records] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Records] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Records] SET  MULTI_USER 
GO
ALTER DATABASE [Records] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Records] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Records] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Records] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Records] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Records] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Records] SET QUERY_STORE = ON
GO
ALTER DATABASE [Records] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Records]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 24/01/2024 00:52:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Records]    Script Date: 24/01/2024 00:52:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Records](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[BirthDate] [datetime2](7) NOT NULL,
	[CreatedDateTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Records] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Records] SET  READ_WRITE 
GO
