USE [Rhodos]
GO

ALTER TABLE [dbo].[UtilityBill] DROP CONSTRAINT [FK_Table_1_Table_1]
GO

/****** Object:  Table [dbo].[UtilityBill]    Script Date: 1/23/2024 4:37:51 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UtilityBill]') AND type in (N'U'))
DROP TABLE [dbo].[UtilityBill]
GO

/****** Object:  Table [dbo].[UtilityBill]    Script Date: 1/23/2024 4:37:51 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UtilityBill](
	[Id] [bigint] NOT NULL,
	[UserId] [bigint] NULL,
	[BillTypeId] [bigint] NULL,
	[CompanyName] [nvarchar](50) NULL,
	[Year] [int] NULL,
	[Month] [nvarchar](50) NULL,
	[Payed] [decimal](18, 0) NULL,
	[Index] [float] NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[UtilityBill]  WITH CHECK ADD  CONSTRAINT [FK_Table_1_Table_1] FOREIGN KEY([Id])
REFERENCES [dbo].[UtilityBill] ([Id])
GO

ALTER TABLE [dbo].[UtilityBill] CHECK CONSTRAINT [FK_Table_1_Table_1]
GO


