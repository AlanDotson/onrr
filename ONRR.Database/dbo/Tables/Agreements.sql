CREATE TABLE [dbo].[Agreements] (
    [AgreementID]               INT             IDENTITY (1, 1) NOT NULL,
    [ONRRAgreementID]           VARCHAR (50)    NULL,
    [BLMSerialNumber]           VARCHAR (50)    NULL,
    [ONRRAgreementDescription]  VARCHAR (150)   NULL,
    [Formation]                 VARCHAR (150)   NULL,
    [AgreementClassificationID] INT             NOT NULL,
    [AgreementTypeID]           INT             NOT NULL,
    [TotalAcreage]              DECIMAL (10, 4) NULL,
    [EffectiveFrom]             DATE            NOT NULL,
    [EffectiveTo]               DATE            NOT NULL,
    [CompanyID]                 INT             NOT NULL,
    CONSTRAINT [PK_Agreements] PRIMARY KEY CLUSTERED ([AgreementID] ASC),
    CONSTRAINT [FK_Agreements_AgreementClassifications] FOREIGN KEY ([AgreementClassificationID]) REFERENCES [dbo].[AgreementClassifications] ([AgreementClassificationID]),
    CONSTRAINT [FK_Agreements_AgreementTypes] FOREIGN KEY ([AgreementTypeID]) REFERENCES [dbo].[AgreementTypes] ([AgreementTypeID]),
    CONSTRAINT [FK_Agreements_CompanyPayorCodes] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[CompanyPayorCodes] ([CompanyID])
);

