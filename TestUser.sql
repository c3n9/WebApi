USE [master]
GO
/****** Object:  Database [TestUser]    Script Date: 28.04.2023 19:10:56 ******/
CREATE DATABASE [TestUser]
 GO
USE [TestUser]
GO
/****** Object:  Table [dbo].[Gender]    Script Date: 28.04.2023 19:10:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gender](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Gender] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 28.04.2023 19:10:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 28.04.2023 19:10:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Age] [int] NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[GenderId] [int] NOT NULL,
	[RoleId] [int] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Gender] ON 

INSERT [dbo].[Gender] ([Id], [Name]) VALUES (1, N'Male')
INSERT [dbo].[Gender] ([Id], [Name]) VALUES (2, N'Female')
SET IDENTITY_INSERT [dbo].[Gender] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([Id], [Name]) VALUES (1, N'Tester')
INSERT [dbo].[Role] ([Id], [Name]) VALUES (2, N'Admin')
INSERT [dbo].[Role] ([Id], [Name]) VALUES (3, N'Seller')
INSERT [dbo].[Role] ([Id], [Name]) VALUES (4, N'Customer')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [Name], [Age], [City], [GenderId], [RoleId]) VALUES (1, N'Askar', 21, N'Kazan', 1, 2)
INSERT [dbo].[User] ([Id], [Name], [Age], [City], [GenderId], [RoleId]) VALUES (2, N'Artur', 16, N'Kazan', 1, 1)
INSERT [dbo].[User] ([Id], [Name], [Age], [City], [GenderId], [RoleId]) VALUES (7, N'lhkfd', 34, N'jkdfsjk', 2, 2)
INSERT [dbo].[User] ([Id], [Name], [Age], [City], [GenderId], [RoleId]) VALUES (8, N'dyt', 54, N'ggjk', 1, 1)
INSERT [dbo].[User] ([Id], [Name], [Age], [City], [GenderId], [RoleId]) VALUES (13, N'gfbd', 0, N'gdfh', 1, 1)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Gender] FOREIGN KEY([GenderId])
REFERENCES [dbo].[Gender] ([Id])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Gender]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Role] ([Id])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role]
GO
USE [master]
GO
ALTER DATABASE [TestUser] SET  READ_WRITE 
GO
