CREATE TABLE [dbo].[AdjustmentReasonCodes] (
    [AdjustmentReasonCodeID] INT          IDENTITY (1, 1) NOT NULL,
    [AdjustmentReasonCode]   VARCHAR (2)  NOT NULL,
    [AdjustmentReason]       VARCHAR (60) NOT NULL,
    CONSTRAINT [PK_AdjustmentReasonCodes] PRIMARY KEY CLUSTERED ([AdjustmentReasonCodeID] ASC)
);

