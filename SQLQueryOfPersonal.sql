USE [PersonalDB]
GO

/****** Object:  Table [dbo].[Personal]    Script Date: 2/1/2020 2:04:54 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Personal](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentId] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[Lastname] [nvarchar](50) NULL,
	[Age] [nvarchar](50) NULL,
	[Salary] [nvarchar](50) NULL,
	[DateOfBrith] [date] NULL,
	[Gender] [nvarchar](50) NULL,
	[Marriage] [nvarchar](50) NULL,
 CONSTRAINT [PK__Personal__3214EC271F9AAABC] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


