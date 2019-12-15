﻿CREATE TABLE [dbo].[Item]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Date] DATE NOT NULL, 
    [QualityId] INT NOT NULL, 
    [StockId] VARCHAR(50) NOT NULL, 
    [EstimatedPrice] MONEY NULL 
)
