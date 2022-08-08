
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/08/2022 12:53:32
-- Generated from EDMX file: C:\Users\151\Desktop\Skillbox\MyLearning\Study\war_world.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [war_world];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[creature_abilitiesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[creature_abilitiesSet];
GO
IF OBJECT_ID(N'[dbo].[creature_templateSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[creature_templateSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'creature_abilitiesSet'
CREATE TABLE [dbo].[creature_abilitiesSet] (
    [AbilityID] nvarchar(max)  NOT NULL,
    [RangeCast] nvarchar(max)  NOT NULL,
    [TargetCast] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'creature_templateSet'
CREATE TABLE [dbo].[creature_templateSet] (
    [Entry] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NULL,
    [Level] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [AbilityID] in table 'creature_abilitiesSet'
ALTER TABLE [dbo].[creature_abilitiesSet]
ADD CONSTRAINT [PK_creature_abilitiesSet]
    PRIMARY KEY CLUSTERED ([AbilityID] ASC);
GO

-- Creating primary key on [Entry] in table 'creature_templateSet'
ALTER TABLE [dbo].[creature_templateSet]
ADD CONSTRAINT [PK_creature_templateSet]
    PRIMARY KEY CLUSTERED ([Entry] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------