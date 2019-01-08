CREATE TABLE [dbo].[TransactionInterfaceTracking] (
    [InterfaceRunID]   INT          IDENTITY (1, 1) NOT NULL,
    [AccountingMonth]  DATE         NOT NULL,
    [InterfaceRunDate] DATETIME     NULL,
    [RecordCount]      INT          NULL,
    [RequestUser]      VARCHAR (25) NOT NULL,
    [RequestDate]      DATETIME     NOT NULL,
    CONSTRAINT [PK_TransactionInterfaceTracking] PRIMARY KEY CLUSTERED ([InterfaceRunID] ASC),
    CONSTRAINT [FK_TransactionInterfaceTracking_AccountingMonth] FOREIGN KEY ([AccountingMonth]) REFERENCES [dbo].[AccountingMonth] ([AccountingMonth])
);

