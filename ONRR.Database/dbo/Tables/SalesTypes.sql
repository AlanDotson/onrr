CREATE TABLE [dbo].[SalesTypes] (
    [SalesTypeID] INT          IDENTITY (1, 1) NOT NULL,
    [SalesType]   VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_SalesTypes] PRIMARY KEY CLUSTERED ([SalesTypeID] ASC)
);

