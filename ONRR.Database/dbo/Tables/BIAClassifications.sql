CREATE TABLE [dbo].[BIAClassifications] (
    [BIAClassificationID] INT           IDENTITY (1, 1) NOT NULL,
    [BIAClassification]   VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_BIAClassifications] PRIMARY KEY CLUSTERED ([BIAClassificationID] ASC)
);

