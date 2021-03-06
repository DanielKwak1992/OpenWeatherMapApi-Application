USE [master]
GO
/****** Object:  Database [WeatherDatabase]    Script Date: 6/1/2016 10:11:04 PM ******/
CREATE DATABASE [WeatherDatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WeatherDatabase', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\WeatherDatabase.mdf' , SIZE = 37888KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'WeatherDatabase_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\WeatherDatabase_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [WeatherDatabase] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WeatherDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WeatherDatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WeatherDatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WeatherDatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WeatherDatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WeatherDatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [WeatherDatabase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WeatherDatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WeatherDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WeatherDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WeatherDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WeatherDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WeatherDatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WeatherDatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WeatherDatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WeatherDatabase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [WeatherDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WeatherDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WeatherDatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WeatherDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WeatherDatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WeatherDatabase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WeatherDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WeatherDatabase] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [WeatherDatabase] SET  MULTI_USER 
GO
ALTER DATABASE [WeatherDatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WeatherDatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WeatherDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WeatherDatabase] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [WeatherDatabase] SET DELAYED_DURABILITY = DISABLED 
GO
USE [WeatherDatabase]
GO
/****** Object:  Table [dbo].[City]    Script Date: 6/1/2016 10:11:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[City](
	[Cityid] [int] NOT NULL,
	[Country] [varchar](50) NULL,
	[Lat] [float] NULL,
	[Lon] [float] NULL,
	[Name] [varchar](50) NULL,
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[Cityid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Weather]    Script Date: 6/1/2016 10:11:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Weather](
	[Weatherid] [int] IDENTITY(1,1) NOT NULL,
	[Cityid] [int] NULL,
	[Sunrise] [datetime] NULL,
	[Sunset] [datetime] NULL,
	[Temp] [float] NULL,
	[Tempmax] [float] NULL,
	[Tempmin] [float] NULL,
	[Clouds] [int] NULL,
	[Humidity] [int] NULL,
	[Pressure] [int] NULL,
	[Visibility] [int] NULL,
	[descrip] [varchar](50) NULL,
	[icon] [image] NULL,
	[id] [int] NULL,
	[main] [varchar](50) NULL,
	[Winddeg] [float] NULL,
	[Windspeed] [float] NULL,
	[Updatetime] [datetime] NULL,
 CONSTRAINT [PK_Weather] PRIMARY KEY CLUSTERED 
(
	[Weatherid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Weather]  WITH CHECK ADD  CONSTRAINT [FK_Weather_City] FOREIGN KEY([Cityid])
REFERENCES [dbo].[City] ([Cityid])
GO
ALTER TABLE [dbo].[Weather] CHECK CONSTRAINT [FK_Weather_City]
GO
USE [master]
GO
ALTER DATABASE [WeatherDatabase] SET  READ_WRITE 
GO
