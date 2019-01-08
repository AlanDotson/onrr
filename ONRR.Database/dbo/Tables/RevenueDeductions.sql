CREATE TABLE [dbo].[RevenueDeductions] (
    [RevenueDeductionID]           INT          IDENTITY (1, 1) NOT NULL,
    [AdjustmentCategoryCode]       VARCHAR (2)  NOT NULL,
    [AdjustmentCategory]           VARCHAR (60) NOT NULL,
    [LandExemptFlag]               BIT          NULL,
    [MMSTransportationDeductFlag]  BIT          NOT NULL,
    [NMEXTransportationDeductFlag] BIT          NOT NULL,
    [MMSProcessingAllowanceFlag]   BIT          NOT NULL,
    [NMEXProcessingAllowanceFlag]  BIT          NOT NULL,
    [AllocationOrder]              INT          NULL,
    CONSTRAINT [PK_RevenueDeductions] PRIMARY KEY CLUSTERED ([RevenueDeductionID] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_RevenueDeductions]
    ON [dbo].[RevenueDeductions]([AdjustmentCategoryCode] ASC);

