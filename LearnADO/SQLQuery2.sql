USE master
GO

CREATE DATABASE [HospitalDB]
GO

USE [HospitalDB]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Patients] 
(
    [Id]	INT	IDENTITY (1, 1) NOT NULL,
    [Name]	NVARCHAR (50)	NOT NULL
);


INSERT INTO [dbo].[Patients] (Name) VALUES ('Ram');

INSERT INTO [dbo].[Patients] (Name) VALUES ('Sam');

INSERT INTO [dbo].[Patients] (Name) VALUES ('Ted');