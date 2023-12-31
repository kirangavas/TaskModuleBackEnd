USE [TaskModule]
GO
/****** Object:  Table [dbo].[TaskTable]    Script Date: 13/12/2023 5:36:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaskTable](
	[taskid] [int] IDENTITY(1,1) NOT NULL,
	[taskname] [nvarchar](255) NULL,
	[taskdescription] [nvarchar](max) NULL,
	[assignto] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[taskid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TaskTable] ON 

INSERT [dbo].[TaskTable] ([taskid], [taskname], [taskdescription], [assignto]) VALUES (1, N'Develop Feature X', N'Implement new functionality for Feature X module', 3)
INSERT [dbo].[TaskTable] ([taskid], [taskname], [taskdescription], [assignto]) VALUES (2, N'Fix Bug in Module Y', N'Resolve issue reported in Module Y', 7)
INSERT [dbo].[TaskTable] ([taskid], [taskname], [taskdescription], [assignto]) VALUES (3, N'Client Meeting Preparation', N'Prepare presentation and documents for client meeting', 1)
INSERT [dbo].[TaskTable] ([taskid], [taskname], [taskdescription], [assignto]) VALUES (4, N'Optimize Database Queries', N'Improve performance of critical database queries', 9)
INSERT [dbo].[TaskTable] ([taskid], [taskname], [taskdescription], [assignto]) VALUES (5, N'UI Design for Dashboard', N'Create user interface design for the new dashboard', 5)
INSERT [dbo].[TaskTable] ([taskid], [taskname], [taskdescription], [assignto]) VALUES (6, N'Code Review for Teammate A', N'Review and provide feedback on code written by Teammate A', 2)
INSERT [dbo].[TaskTable] ([taskid], [taskname], [taskdescription], [assignto]) VALUES (7, N'Project Status Report', N'Compile and send project status report to stakeholders', 8)
INSERT [dbo].[TaskTable] ([taskid], [taskname], [taskdescription], [assignto]) VALUES (8, N'Integration Testing', N'Conduct integration testing for Module Z', 4)
INSERT [dbo].[TaskTable] ([taskid], [taskname], [taskdescription], [assignto]) VALUES (9, N'Client Support Tickets', N'Address and resolve support tickets raised by clients', 10)
INSERT [dbo].[TaskTable] ([taskid], [taskname], [taskdescription], [assignto]) VALUES (10, N'Documentation Update', N'Update project documentation based on recent changes', 6)
SET IDENTITY_INSERT [dbo].[TaskTable] OFF
GO
