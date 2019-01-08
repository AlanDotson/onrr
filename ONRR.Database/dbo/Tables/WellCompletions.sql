CREATE TABLE [dbo].[WellCompletions] (
    [WellCompletionID]      VARCHAR (10)    NOT NULL,
    [PropertyNumber]        VARCHAR (10)    NOT NULL,
    [WellAcreage]           DECIMAL (10, 4) NULL,
    [WellCompletionName]    VARCHAR (60)    NOT NULL,
    [StateCode]             CHAR (2)        NOT NULL,
    [API]                   VARCHAR (14)    NULL,
    [Company]               VARCHAR (4)     NOT NULL,
    [PropertyName]          VARCHAR (250)   NOT NULL,
    [GrossMarketedInterest] DECIMAL (9, 8)  NULL,
    CONSTRAINT [PK_WellCompletions] PRIMARY KEY CLUSTERED ([WellCompletionID] ASC),
    CONSTRAINT [FK_WellCompletions_States] FOREIGN KEY ([StateCode]) REFERENCES [dbo].[States] ([StateCode])
);

