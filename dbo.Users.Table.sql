USE [TaskModule]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 13/12/2023 5:36:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] NOT NULL,
	[UserFirstName] [varchar](255) NULL,
	[UserLastName] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Users] ([UserID], [UserFirstName], [UserLastName]) VALUES (1, N'John', N'Doe')
INSERT [dbo].[Users] ([UserID], [UserFirstName], [UserLastName]) VALUES (2, N'Jane', N'Smith')
INSERT [dbo].[Users] ([UserID], [UserFirstName], [UserLastName]) VALUES (3, N'Alice', N'Johnson')
INSERT [dbo].[Users] ([UserID], [UserFirstName], [UserLastName]) VALUES (4, N'Bob', N'Williams')
INSERT [dbo].[Users] ([UserID], [UserFirstName], [UserLastName]) VALUES (5, N'Eva', N'Brown')
INSERT [dbo].[Users] ([UserID], [UserFirstName], [UserLastName]) VALUES (6, N'Michael', N'Davis')
INSERT [dbo].[Users] ([UserID], [UserFirstName], [UserLastName]) VALUES (7, N'Olivia', N'Clark')
INSERT [dbo].[Users] ([UserID], [UserFirstName], [UserLastName]) VALUES (8, N'Daniel', N'Taylor')
INSERT [dbo].[Users] ([UserID], [UserFirstName], [UserLastName]) VALUES (9, N'Sophia', N'Moore')
INSERT [dbo].[Users] ([UserID], [UserFirstName], [UserLastName]) VALUES (10, N'William', N'Anderson')
GO
