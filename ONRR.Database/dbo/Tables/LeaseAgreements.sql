CREATE TABLE [dbo].[LeaseAgreements] (
    [LeaseAgreementID]    INT             IDENTITY (1, 1) NOT NULL,
    [LeaseID]             INT             NOT NULL,
    [AgreementID]         INT             NULL,
    [EffectiveFrom]       DATE            NOT NULL,
    [EffectiveTo]         DATE            NOT NULL,
    [TractFactor]         DECIMAL (9, 8)  NULL,
    [OverrideTractFactor] DECIMAL (9, 8)  NULL,
    [MarketShare]         DECIMAL (9, 8)  NULL,
    [TractAcreage]        DECIMAL (10, 4) NULL,
    CONSTRAINT [PK_LeaseAgreements] PRIMARY KEY CLUSTERED ([LeaseAgreementID] ASC),
    CONSTRAINT [FK_LeaseAgreements_Agreements] FOREIGN KEY ([AgreementID]) REFERENCES [dbo].[Agreements] ([AgreementID]),
    CONSTRAINT [FK_LeaseAgreements_Leases] FOREIGN KEY ([LeaseID]) REFERENCES [dbo].[Leases] ([LeaseID])
);

