USE [Rhodos]
GO

/****** Object:  Table [dbo].[MonthlyActivities]    Script Date: 1/23/2024 4:35:52 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MonthlyActivities]') AND type in (N'U'))
DROP TABLE [dbo].[MonthlyActivities]
GO

/****** Object:  Table [dbo].[MonthlyActivities]    Script Date: 1/23/2024 4:35:52 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MonthlyActivities](
	[Id] [bigint] NULL,
	[Name] [nvarchar](max) NULL,
	[UserId] [bigint] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


