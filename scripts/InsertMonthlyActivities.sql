USE [Rhodos]
GO

INSERT INTO [dbo].[MonthlyActivities]
           ([Id]
           ,[Name]
           ,[UserId])
VALUES
    (1, 'Desfundare țevi cu granule/lichid', 1),
    (2, 'Trimis index hidroelectrica', 1),
    (3, 'Intretinere cabina dus', 1),
    (4, 'Curatat masina spalat rufe', 2),
    (5, 'Auto Spalare masina spalat rufe', 2),
    (6, 'Auto Spalare masina spalat vase', 2),
    (7, 'Verificare resurse', 2),
    (8, 'Verificare instrumente financiare', 2);
GO

select * from dbo.MonthlyActivities;