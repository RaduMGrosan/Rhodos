USE [Rhodos]
GO

INSERT INTO [dbo].[UtilityBill]
           ([Id]
           ,[UserId]
           ,[BillTypeId]
           ,[CompanyName]
           ,[Year]
           ,[Month]
           ,[Payed]
           ,[Index])
     VALUES
           (1,1,1,'Eon', 2023, 'June', 140, 123),
		   (2,1,1,'Eon', 2023, 'July', 140, 123),
		   (3,1,6,'Primarie', 2023, 'June', 140, 123),
		   (4,1,5,'Primarie', 2023, 'June', 140, 123),
		   (5,1,4,'Bloc', 2023, 'June', 140, 123),
		   (6,1,3,'Digi', 2023, 'June', 140, 123),
		   (7,2,2,'Hidro Elctrica', 2023, 'June', 140, 123),
		   (8,2,2,'Hidro Elctrica', 2023, 'July', 140, 123),
		   (9,2,2,'Hidro Elctrica', 2023, 'August', 140, 123);
GO


