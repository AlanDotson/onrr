CREATE TABLE [dbo].[PayorCodes] (
    [PayorCodeID] INT          IDENTITY (1, 1) NOT NULL,
    [PayorCode]   VARCHAR (5)  NOT NULL,
    [Payor]       VARCHAR (60) NOT NULL,
    CONSTRAINT [PK_PayorCodes] PRIMARY KEY CLUSTERED ([PayorCodeID] ASC)
);

