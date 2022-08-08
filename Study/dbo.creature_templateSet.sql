CREATE TABLE [dbo].[creature_templateSet] (
    [Entry] INT            IDENTITY (1, 1) NOT NULL,
    [Name]  VARCHAR(50) NULL,
    [Level] INT NOT NULL,
    CONSTRAINT [PK_creature_templateSet] PRIMARY KEY CLUSTERED ([Entry] ASC)
);

