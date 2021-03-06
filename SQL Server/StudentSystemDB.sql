/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2016 (13.0.4001)
    Source Database Engine Edition : Microsoft SQL Server Express Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [master]
GO
/****** Object:  Database [StudentSystemDB]    Script Date: 5/6/2018 1:00:14 AM ******/
CREATE DATABASE [StudentSystemDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StudentSystemDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\StudentSystemDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'StudentSystemDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\StudentSystemDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [StudentSystemDB] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StudentSystemDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StudentSystemDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StudentSystemDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StudentSystemDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StudentSystemDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StudentSystemDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [StudentSystemDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StudentSystemDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StudentSystemDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StudentSystemDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StudentSystemDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StudentSystemDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StudentSystemDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StudentSystemDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StudentSystemDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StudentSystemDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StudentSystemDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StudentSystemDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StudentSystemDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StudentSystemDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StudentSystemDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StudentSystemDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StudentSystemDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StudentSystemDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [StudentSystemDB] SET  MULTI_USER 
GO
ALTER DATABASE [StudentSystemDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StudentSystemDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StudentSystemDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StudentSystemDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StudentSystemDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [StudentSystemDB] SET QUERY_STORE = OFF
GO
USE [StudentSystemDB]
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
USE [StudentSystemDB]
GO
/****** Object:  Table [dbo].[City]    Script Date: 5/6/2018 1:00:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[City](
	[CityID] [int] IDENTITY(1,1) NOT NULL,
	[CityName] [varchar](30) NOT NULL,
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[CityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Interest]    Script Date: 5/6/2018 1:00:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Interest](
	[InterestID] [int] IDENTITY(1,1) NOT NULL,
	[InterestedLanguage] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Interest] PRIMARY KEY CLUSTERED 
(
	[InterestID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListData]    Script Date: 5/6/2018 1:00:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListData](
	[ListID] [int] IDENTITY(1,1) NOT NULL,
	[ListItem] [varchar](30) NOT NULL,
	[ListTypeID] [int] NOT NULL,
 CONSTRAINT [PK_ListData] PRIMARY KEY CLUSTERED 
(
	[ListID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListType]    Script Date: 5/6/2018 1:00:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListType](
	[ListTypeID] [int] IDENTITY(1,1) NOT NULL,
	[ListTypeTitle] [varchar](20) NOT NULL,
 CONSTRAINT [PK_ListType] PRIMARY KEY CLUSTERED 
(
	[ListTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Locality]    Script Date: 5/6/2018 1:00:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Locality](
	[LocalityID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](30) NOT NULL,
	[CityID] [int] NOT NULL,
 CONSTRAINT [PK_Locality] PRIMARY KEY CLUSTERED 
(
	[LocalityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 5/6/2018 1:00:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](25) NULL,
	[FatherName] [varchar](25) NULL,
	[Email] [varchar](35) NULL,
	[Gender] [bit] NULL,
	[DOB] [date] NULL,
	[CityID] [int] NULL,
	[LocalityID] [int] NULL,
	[PostCode] [nchar](10) NULL,
	[Address] [varchar](50) NULL,
	[Comment] [varchar](50) NULL,
	[FundType] [int] NULL,
	[FeeType] [int] NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_Student] UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student_Interest]    Script Date: 5/6/2018 1:00:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student_Interest](
	[StudentID] [int] NOT NULL,
	[InterestID] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ListData]  WITH CHECK ADD  CONSTRAINT [FK_ListData_ListType] FOREIGN KEY([ListTypeID])
REFERENCES [dbo].[ListType] ([ListTypeID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ListData] CHECK CONSTRAINT [FK_ListData_ListType]
GO
ALTER TABLE [dbo].[Locality]  WITH CHECK ADD  CONSTRAINT [FK_Locality_City] FOREIGN KEY([CityID])
REFERENCES [dbo].[City] ([CityID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Locality] CHECK CONSTRAINT [FK_Locality_City]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_City] FOREIGN KEY([CityID])
REFERENCES [dbo].[City] ([CityID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_City]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_ListData] FOREIGN KEY([FundType])
REFERENCES [dbo].[ListData] ([ListID])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_ListData]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_ListData1] FOREIGN KEY([FeeType])
REFERENCES [dbo].[ListData] ([ListID])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_ListData1]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Locality] FOREIGN KEY([LocalityID])
REFERENCES [dbo].[Locality] ([LocalityID])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Locality]
GO
ALTER TABLE [dbo].[Student_Interest]  WITH CHECK ADD  CONSTRAINT [FK_Student_Interest_Interest] FOREIGN KEY([InterestID])
REFERENCES [dbo].[Interest] ([InterestID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Student_Interest] CHECK CONSTRAINT [FK_Student_Interest_Interest]
GO
ALTER TABLE [dbo].[Student_Interest]  WITH CHECK ADD  CONSTRAINT [FK_Student_Interest_Student] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Student] ([StudentID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Student_Interest] CHECK CONSTRAINT [FK_Student_Interest_Student]
GO
/****** Object:  StoredProcedure [dbo].[AddStudent]    Script Date: 5/6/2018 1:00:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ================================================
-- Add new Student
-- ================================================
CREATE PROCEDURE [dbo].[AddStudent]
(
	@Name varchar(25),
	@FatherName varchar(25),
	@Gender bit,
	@Email varchar(35),
	@DOB date,
	@CityID int,
	@LocalityID int,
	@Address varchar(50),
	@PostCode nchar(10),
	@Comment varchar(50),
	@FundType int,
	@FeeType int
)
AS
BEGIN
	INSERT INTO dbo.Student 
	([Name], [FatherName], [Gender], [Email], [DOB], [CityID], [LocalityID], [PostCode], [Address], [Comment], [FundType], [FeeType])
	VALUES 
	(@Name, @FatherName, @Gender, @Email, @DOB, @CityID, @LocalityID, @PostCode, @Address, @Comment, @FundType, @FeeType)
END
GO
/****** Object:  StoredProcedure [dbo].[EditStudent]    Script Date: 5/6/2018 1:00:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ================================================
-- Edit Student by StudentID
-- ================================================
CREATE PROCEDURE [dbo].[EditStudent] 
(
	@StudentID int,
	@Name varchar(25),
	@FatherName varchar(25),
	@Gender bit,
	@Email varchar(35),
	@DOB date,
	@CityID int,
	@LocalityID int,
	@Address varchar(50),
	@PostCode nchar(10),
	@Comment varchar(50),
	@FundType int,
	@FeeType int
)
AS
BEGIN
	UPDATE dbo.Student 
	SET
	[Name] = @Name, 
	[FatherName] = @FatherName, 
	[Gender] = @Gender, 
	[Email] = @Email, 
	[DOB] = @DOB, 
	[CityID] = @CityID, 
	[LocalityID] = @LocalityID, 
	[PostCode] = @PostCode, 
	[Address] = @Address, 
	[Comment] = @Comment, 
	[FundType] = @FundType, 
	[FeeType] = @FeeType
	WHERE
	[StudentID] = @StudentID
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllStudents]    Script Date: 5/6/2018 1:00:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ================================================
-- Fetch Students
-- ================================================

CREATE PROCEDURE [dbo].[GetAllStudents] 

AS
BEGIN
	SELECT 
	[StudentID] AS [Student ID],
	[Name],
	[FatherName] AS [Father Name],  
	[Email], 
	[Gender] = CASE [Gender]
		WHEN 1 THEN 'Male'
		WHEN 0 THEN 'Female'
	END,
	[DOB],
	[Address]
	FROM dbo.Student
END
GO
/****** Object:  StoredProcedure [dbo].[GetCities]    Script Date: 5/6/2018 1:00:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ================================================
-- Get City
-- ================================================

CREATE PROCEDURE [dbo].[GetCities]
	
AS
BEGIN
	SELECT * FROM dbo.City
END
GO
/****** Object:  StoredProcedure [dbo].[GetFeeType]    Script Date: 5/6/2018 1:00:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ================================================
-- Get Fee Type
-- ================================================

CREATE PROCEDURE [dbo].[GetFeeType]

AS
BEGIN
	SELECT * FROM dbo.ListData WHERE [ListTypeID] = 2
END
GO
/****** Object:  StoredProcedure [dbo].[GetFundType]    Script Date: 5/6/2018 1:00:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ================================================
-- Get Fund Type
-- ================================================

CREATE PROCEDURE [dbo].[GetFundType]

AS
BEGIN
	SELECT * FROM dbo.ListData WHERE [ListTypeID] = 1
END
GO
/****** Object:  StoredProcedure [dbo].[GetLocalitiesByCityID]    Script Date: 5/6/2018 1:00:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ================================================
-- Get Locality
-- ================================================

CREATE PROCEDURE [dbo].[GetLocalitiesByCityID]
(
	@CityID int
)
AS
BEGIN
	SELECT * FROM dbo.Locality WHERE [CityID] = @CityID
END
GO
/****** Object:  StoredProcedure [dbo].[GetStudentByID]    Script Date: 5/6/2018 1:00:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ================================================
-- Get Student by StudentID
-- ================================================
CREATE PROCEDURE [dbo].[GetStudentByID] 
(
	@StudentID int
)
AS
BEGIN
	SELECT * FROM Student WHERE [StudentID] = @StudentID
END
GO
USE [master]
GO
ALTER DATABASE [StudentSystemDB] SET  READ_WRITE 
GO
