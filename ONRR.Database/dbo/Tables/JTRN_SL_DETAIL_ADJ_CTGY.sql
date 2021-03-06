﻿CREATE TABLE [dbo].[JTRN_SL_DETAIL_ADJ_CTGY] (
    [SL_DETAIL_NO] BIGINT          NOT NULL,
    [ADJ_CTGY_CD]  VARCHAR (2)     NOT NULL,
    [NET_AMT]      NUMERIC (13, 2) NOT NULL,
    CONSTRAINT [PK_JTRN_SL_DETAIL_ADJ_CTGY] PRIMARY KEY CLUSTERED ([SL_DETAIL_NO] ASC, [ADJ_CTGY_CD] ASC),
    CONSTRAINT [FK_JTRN_SL_DETAIL_ADJ_CTGY_JTRN_SL_DETAIL] FOREIGN KEY ([SL_DETAIL_NO]) REFERENCES [dbo].[JTRN_SL_DETAIL] ([SL_DETAIL_NO]),
    CONSTRAINT [FK_JTRN_SL_DETAIL_ADJ_CTGY_RevenueDeductions] FOREIGN KEY ([ADJ_CTGY_CD]) REFERENCES [dbo].[RevenueDeductions] ([AdjustmentCategoryCode])
);

