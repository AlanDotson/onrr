CREATE TABLE [dbo].[WellLeaseAgreements] (
    [WellLeaseAgreementID] INT          IDENTITY (1, 1) NOT NULL,
    [WellCompletionID]     VARCHAR (10) NOT NULL,
    [LeaseAgreementID]     INT          NOT NULL,
    [ProductCodeID]        INT          NOT NULL,
    [SalesTypeID]          INT          NOT NULL,
    [EffectiveFrom]        DATE         NOT NULL,
    [EffectiveTo]          DATE         NOT NULL,
    CONSTRAINT [PK_WellLeaseAgreements] PRIMARY KEY CLUSTERED ([WellLeaseAgreementID] ASC),
    CONSTRAINT [FK_WellLeaseAgreements_LeaseAgreements] FOREIGN KEY ([LeaseAgreementID]) REFERENCES [dbo].[LeaseAgreements] ([LeaseAgreementID]),
    CONSTRAINT [FK_WellLeaseAgreements_ProductCodeCrossReference] FOREIGN KEY ([ProductCodeID]) REFERENCES [dbo].[ProductCodeCrossReference] ([ProductCodeID]),
    CONSTRAINT [FK_WellLeaseAgreements_SalesTypes] FOREIGN KEY ([SalesTypeID]) REFERENCES [dbo].[SalesTypes] ([SalesTypeID]),
    CONSTRAINT [FK_WellLeaseAgreements_WellCompletions] FOREIGN KEY ([WellCompletionID]) REFERENCES [dbo].[WellCompletions] ([WellCompletionID])
);

