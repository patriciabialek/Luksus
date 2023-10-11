CREATE TABLE [dbo].[Perfume] (
    [Id]              INT             IDENTITY (1, 1) NOT NULL,
    [Name]            NVARCHAR (MAX)  NULL,
    [Brand]           NVARCHAR (MAX)  NULL,
    [Price]           DECIMAL (18, 2) NULL,
    [FragranceFamily] NVARCHAR (MAX)  NULL,
    [Volume]          NVARCHAR (MAX)  NULL,
    [Concentration]   NVARCHAR (MAX)  NULL,
    [Rating]          NVARCHAR (MAX)  NULL,
    CONSTRAINT [PK_Perfume] PRIMARY KEY CLUSTERED ([Id] ASC)
);

