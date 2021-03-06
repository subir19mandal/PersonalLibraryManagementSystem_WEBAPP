USE [master]
GO
/****** Object:  Database [LibraryManagementDB]    Script Date: 25/01/2015 19:26:54 ******/
CREATE DATABASE [LibraryManagementDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LibraryManagementDB', FILENAME = N'D:\FTFL Projects\Week # 08\25.01.2015\LibraryManagementSystem\DB\LibraryManagementDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'LibraryManagementDB_log', FILENAME = N'D:\FTFL Projects\Week # 08\25.01.2015\LibraryManagementSystem\DB\LibraryManagementDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [LibraryManagementDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LibraryManagementDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LibraryManagementDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LibraryManagementDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LibraryManagementDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LibraryManagementDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LibraryManagementDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [LibraryManagementDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LibraryManagementDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [LibraryManagementDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LibraryManagementDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LibraryManagementDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LibraryManagementDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LibraryManagementDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LibraryManagementDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LibraryManagementDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LibraryManagementDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LibraryManagementDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LibraryManagementDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LibraryManagementDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LibraryManagementDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LibraryManagementDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LibraryManagementDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LibraryManagementDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LibraryManagementDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LibraryManagementDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LibraryManagementDB] SET  MULTI_USER 
GO
ALTER DATABASE [LibraryManagementDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LibraryManagementDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LibraryManagementDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LibraryManagementDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [LibraryManagementDB]
GO
/****** Object:  Table [dbo].[tbl_book]    Script Date: 25/01/2015 19:26:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_book](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](100) NOT NULL,
	[author] [varchar](100) NOT NULL,
	[publisher] [varchar](100) NOT NULL,
 CONSTRAINT [PK_tbl_book] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_borrow]    Script Date: 25/01/2015 19:26:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_borrow](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[member_id] [int] NOT NULL,
	[book_id] [int] NOT NULL,
	[is_returned] [bit] NOT NULL,
 CONSTRAINT [PK_tbl_borrow] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_member]    Script Date: 25/01/2015 19:26:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_member](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[number] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_member] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_book] ON 

INSERT [dbo].[tbl_book] ([id], [title], [author], [publisher]) VALUES (1, N'How to Learn C#', N'Haward', N'Prothoma')
INSERT [dbo].[tbl_book] ([id], [title], [author], [publisher]) VALUES (2, N'Teach your child', N'Debono', N'Somoy')
INSERT [dbo].[tbl_book] ([id], [title], [author], [publisher]) VALUES (3, N'Himu', N'Humayun Ahmed', N'Onnoprokash')
SET IDENTITY_INSERT [dbo].[tbl_book] OFF
SET IDENTITY_INSERT [dbo].[tbl_borrow] ON 

INSERT [dbo].[tbl_borrow] ([id], [member_id], [book_id], [is_returned]) VALUES (1, 1, 2, 0)
INSERT [dbo].[tbl_borrow] ([id], [member_id], [book_id], [is_returned]) VALUES (2, 1, 1, 0)
INSERT [dbo].[tbl_borrow] ([id], [member_id], [book_id], [is_returned]) VALUES (3, 1, 3, 0)
INSERT [dbo].[tbl_borrow] ([id], [member_id], [book_id], [is_returned]) VALUES (4, 2, 1, 0)
INSERT [dbo].[tbl_borrow] ([id], [member_id], [book_id], [is_returned]) VALUES (5, 2, 3, 1)
INSERT [dbo].[tbl_borrow] ([id], [member_id], [book_id], [is_returned]) VALUES (6, 2, 2, 0)
INSERT [dbo].[tbl_borrow] ([id], [member_id], [book_id], [is_returned]) VALUES (7, 4, 2, 0)
SET IDENTITY_INSERT [dbo].[tbl_borrow] OFF
SET IDENTITY_INSERT [dbo].[tbl_member] ON 

INSERT [dbo].[tbl_member] ([id], [number]) VALUES (1, N'0001')
INSERT [dbo].[tbl_member] ([id], [number]) VALUES (2, N'0002')
INSERT [dbo].[tbl_member] ([id], [number]) VALUES (3, N'0003')
INSERT [dbo].[tbl_member] ([id], [number]) VALUES (4, N'0004')
INSERT [dbo].[tbl_member] ([id], [number]) VALUES (5, N'0005')
INSERT [dbo].[tbl_member] ([id], [number]) VALUES (6, N'1234')
SET IDENTITY_INSERT [dbo].[tbl_member] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_tbl_member]    Script Date: 25/01/2015 19:26:54 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_tbl_member] ON [dbo].[tbl_member]
(
	[number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_borrow]  WITH CHECK ADD  CONSTRAINT [FK_tbl_borrow_tbl_book] FOREIGN KEY([book_id])
REFERENCES [dbo].[tbl_book] ([id])
GO
ALTER TABLE [dbo].[tbl_borrow] CHECK CONSTRAINT [FK_tbl_borrow_tbl_book]
GO
ALTER TABLE [dbo].[tbl_borrow]  WITH CHECK ADD  CONSTRAINT [FK_tbl_borrow_tbl_member] FOREIGN KEY([member_id])
REFERENCES [dbo].[tbl_member] ([id])
GO
ALTER TABLE [dbo].[tbl_borrow] CHECK CONSTRAINT [FK_tbl_borrow_tbl_member]
GO
USE [master]
GO
ALTER DATABASE [LibraryManagementDB] SET  READ_WRITE 
GO
