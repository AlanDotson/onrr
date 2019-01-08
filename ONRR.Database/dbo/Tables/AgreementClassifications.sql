CREATE TABLE [dbo].[AgreementClassifications] (
    [AgreementClassificationID] INT          IDENTITY (1, 1) NOT NULL,
    [AgreementClassification]   VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_AgreementClassifications] PRIMARY KEY CLUSTERED ([AgreementClassificationID] ASC)
);

