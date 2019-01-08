CREATE TABLE [dbo].[ONRRTransactionCodes] (
    [TransactionCodeID]   INT         IDENTITY (1, 1) NOT NULL,
    [ONRRTransactionCode] VARCHAR (5) NOT NULL,
    [ProductCode]         VARCHAR (5) NOT NULL,
    [DispositionCode]     VARCHAR (5) NOT NULL,
    CONSTRAINT [PK_ONRRTransactionCodes] PRIMARY KEY CLUSTERED ([TransactionCodeID] ASC)
);

