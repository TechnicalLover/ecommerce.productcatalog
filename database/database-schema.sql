USE master
GO

USE master
GO
-- Create the new database if it does not exist already
IF NOT EXISTS (
    SELECT name
FROM [sys].[databases]
WHERE name = N'ecommerce_productcatalog_database'
)
CREATE DATABASE ecommerce_productcatalog_database
GO

USE [ecommerce_productcatalog_database]
GO

-- Drop the table if it already exists
IF OBJECT_ID('dbo.product', 'U') IS NOT NULL
DROP TABLE [dbo].[product]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[product]
(
    [ID] INT IDENTITY(1,1) PRIMARY KEY,
    -- primary key column
    [ProductName] NVARCHAR(400) NOT NULL,
    [DivisionCode] INT NOT NULL,
    [DivisionName] NVARCHAR(100) NOT NULL,
    [CategoryCode] INT NOT NULL,
    [CategoryName] NVARCHAR(100) NOT NULL,
    [Description] NVARCHAR(500) NOT NULL,
    [ImageUrl] NVARCHAR(500) NOT NULL
    -- specify more columns here
);
GO

-- Drop the table if it already exists
IF OBJECT_ID('dbo.event_store', 'U') IS NOT NULL
DROP TABLE [dbo].[event_store]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[event_store]
(
    [ID] INT IDENTITY(1,1) PRIMARY KEY,
    -- primary key column
    [Name] [NVARCHAR](100) NOT NULL,
    [OccurredAt] DATETIMEOFFSET NOT NULL,
    [Content] NVARCHAR(MAX) NOT NULL
    -- specify more columns here
);
GO


