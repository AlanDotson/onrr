CREATE TABLE [dbo].[ProductCodeCrossReference] (
    [ProductCodeID]       INT          IDENTITY (1, 1) NOT NULL,
    [ONRRProductCode]     VARCHAR (15) NOT NULL,
    [QRAMajorProductCode] VARCHAR (5)  NOT NULL,
    CONSTRAINT [PK_ProductCodeCrossReference] PRIMARY KEY CLUSTERED ([ProductCodeID] ASC)
);

