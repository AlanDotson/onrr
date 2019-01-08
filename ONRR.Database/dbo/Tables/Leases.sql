CREATE TABLE [dbo].[Leases] (
    [LeaseID]               INT             IDENTITY (1, 1) NOT NULL,
    [ONRRLeaseID]           VARCHAR (10)    NOT NULL,
    [BLMSerialNumber]       VARCHAR (50)    NOT NULL,
    [QEPLeaseID]            VARCHAR (50)    NOT NULL,
    [QEPLeaseName]          VARCHAR (150)   NOT NULL,
    [LeaseClassificationID] INT             NOT NULL,
    [BIAClassificationID]   INT             NULL,
    [QEPEffectiveDate]      DATE            NULL,
    [StateCode]             CHAR (2)        NULL,
    [County]                VARCHAR (150)   NULL,
    [RoyaltyRate]           DECIMAL (11, 8) NOT NULL,
    [EffectiveFrom]         DATE            NOT NULL,
    [EffectiveTo]           DATE            NOT NULL,
    [CompanyID]             INT             NOT NULL,
    CONSTRAINT [PK_Leases] PRIMARY KEY CLUSTERED ([LeaseID] ASC),
    CONSTRAINT [FK_Leases_BIAClassifications] FOREIGN KEY ([BIAClassificationID]) REFERENCES [dbo].[BIAClassifications] ([BIAClassificationID]),
    CONSTRAINT [FK_Leases_CompanyPayorCodes] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[CompanyPayorCodes] ([CompanyID]),
    CONSTRAINT [FK_Leases_LeaseClassifications] FOREIGN KEY ([LeaseClassificationID]) REFERENCES [dbo].[LeaseClassifications] ([LeaseClassificationID]),
    CONSTRAINT [FK_Leases_States] FOREIGN KEY ([StateCode]) REFERENCES [dbo].[States] ([StateCode])
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Leases_ONRRLeaseID]
    ON [dbo].[Leases]([LeaseID] ASC);

