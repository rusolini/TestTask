USE [master]
GO

/****** Object:  Database [SimpleDB]    Script Date: 17.12.2018 11:35:21 ******/
CREATE DATABASE [SimpleDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SimpleDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\SimpleDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SimpleDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\SimpleDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

ALTER DATABASE [SimpleDB] SET COMPATIBILITY_LEVEL = 140
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SimpleDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [SimpleDB] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [SimpleDB] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [SimpleDB] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [SimpleDB] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [SimpleDB] SET ARITHABORT OFF 
GO

ALTER DATABASE [SimpleDB] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [SimpleDB] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [SimpleDB] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [SimpleDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [SimpleDB] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [SimpleDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [SimpleDB] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [SimpleDB] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [SimpleDB] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [SimpleDB] SET  ENABLE_BROKER 
GO

ALTER DATABASE [SimpleDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [SimpleDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [SimpleDB] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [SimpleDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [SimpleDB] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [SimpleDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [SimpleDB] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [SimpleDB] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [SimpleDB] SET  MULTI_USER 
GO

ALTER DATABASE [SimpleDB] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [SimpleDB] SET DB_CHAINING OFF 
GO

ALTER DATABASE [SimpleDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [SimpleDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [SimpleDB] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [SimpleDB] SET QUERY_STORE = OFF
GO

ALTER DATABASE [SimpleDB] SET  READ_WRITE 
GO
