CREATE TABLE [dbo].[AccountingMonth] (
    [AccountingMonth] DATE     NOT NULL,
    [OpenDate]        DATETIME NOT NULL,
    [CloseDate]       DATETIME NULL,
    CONSTRAINT [PK_AccountingMonth] PRIMARY KEY CLUSTERED ([AccountingMonth] ASC)
);

