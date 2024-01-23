USE [Rhodos]
GO

INSERT INTO dbo.BillType (Id, Name, Value)
VALUES
    (1, 'All Types', '0'),
    (2, 'Heat', '1'),
    (3, 'Electricity', '2'),
	(4, 'CableNet', '3'),
	(5, 'Maintenance', '4'),
	(6, 'Water', '5'),
	(7, 'Garbage', '6');
GO
