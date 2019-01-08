CREATE TABLE [dbo].[AgreementTypes] (
    [AgreementTypeID] INT          IDENTITY (1, 1) NOT NULL,
    [AgreementType]   VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_AgreementTypes] PRIMARY KEY CLUSTERED ([AgreementTypeID] ASC)
);

