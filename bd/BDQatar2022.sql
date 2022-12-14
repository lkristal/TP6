USE [master]
GO
/****** Object:  Database [Qatar2022]    Script Date: 6/27/2022 11:54:45 AM ******/
CREATE DATABASE [Qatar2022]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Qatar2022', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Qatar2022.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Qatar2022_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Qatar2022_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Qatar2022] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Qatar2022].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Qatar2022] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Qatar2022] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Qatar2022] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Qatar2022] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Qatar2022] SET ARITHABORT OFF 
GO
ALTER DATABASE [Qatar2022] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Qatar2022] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Qatar2022] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Qatar2022] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Qatar2022] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Qatar2022] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Qatar2022] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Qatar2022] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Qatar2022] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Qatar2022] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Qatar2022] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Qatar2022] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Qatar2022] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Qatar2022] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Qatar2022] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Qatar2022] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Qatar2022] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Qatar2022] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Qatar2022] SET  MULTI_USER 
GO
ALTER DATABASE [Qatar2022] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Qatar2022] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Qatar2022] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Qatar2022] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Qatar2022] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Qatar2022] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Qatar2022] SET QUERY_STORE = OFF
GO
USE [Qatar2022]
GO
/****** Object:  Table [dbo].[Equipos]    Script Date: 6/27/2022 11:54:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equipos](
	[IdEquipo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Escudo] [varchar](200) NULL,
	[Camiseta] [varchar](200) NULL,
	[Continente] [varchar](50) NULL,
	[CopasGanadas] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Jugadores]    Script Date: 6/27/2022 11:54:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jugadores](
	[IdJugador] [int] IDENTITY(1,1) NOT NULL,
	[IdEquipo] [int] NULL,
	[Nombre] [varchar](100) NULL,
	[FechaNacimiento] [datetime] NULL,
	[Foto] [varchar](200) NULL,
	[EquipoActual] [varchar](50) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Equipos] ON 

INSERT [dbo].[Equipos] ([IdEquipo], [Nombre], [Escudo], [Camiseta], [Continente], [CopasGanadas]) VALUES (2, N'Argentina', N'https://besthqwallpapers.com/Uploads/20-9-2019/104854/thumb2-argentinean-football-team-glass-logo-south-america-conmebol-blue-grunge-background.jpg', N'https://www.afashop.com.ar/ccstore/v1/images/?source=/file/v3593346395731199843/products/FS6568_APP_on-model_detail-1_white.jpg&height=940&width=940', N'America', 2)
INSERT [dbo].[Equipos] ([IdEquipo], [Nombre], [Escudo], [Camiseta], [Continente], [CopasGanadas]) VALUES (3, N'Brasil', N'https://blog.universaldeidiomas.com/wp-content/uploads/2017/02/Sobre-la-selecci%C3%B3n-de-f%C3%BAtbol-de-Brasil.jpg', N'https://www.benditofutbol.com/files/article_main/uploads/2013/11/24/52925aae40152.jpg', N'America', 5)
SET IDENTITY_INSERT [dbo].[Equipos] OFF
GO
SET IDENTITY_INSERT [dbo].[Jugadores] ON 

INSERT [dbo].[Jugadores] ([IdJugador], [IdEquipo], [Nombre], [FechaNacimiento], [Foto], [EquipoActual]) VALUES (3, 2, N'Rodrigo De Paul', CAST(N'1994-06-10T00:00:00.000' AS DateTime), N'DePaul.jpg', N'Atletico de Madrid')
INSERT [dbo].[Jugadores] ([IdJugador], [IdEquipo], [Nombre], [FechaNacimiento], [Foto], [EquipoActual]) VALUES (4, 2, N'Lionel Messi', CAST(N'1987-06-22T00:00:00.000' AS DateTime), N'messi.jpg', N'PSG')
INSERT [dbo].[Jugadores] ([IdJugador], [IdEquipo], [Nombre], [FechaNacimiento], [Foto], [EquipoActual]) VALUES (6, 2, N'Emiliano Martinez', CAST(N'1998-12-28T00:00:00.000' AS DateTime), N'dibu.jpg', N'Aston Villa')
SET IDENTITY_INSERT [dbo].[Jugadores] OFF
GO
USE [master]
GO
ALTER DATABASE [Qatar2022] SET  READ_WRITE 
GO
