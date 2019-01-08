
CREATE PROCEDURE [Application].[RevenueDeductionsSelect] @RevenueDeductionID INT
AS
SET NOCOUNT ON

SELECT rd.RevenueDeductionID
    ,rd.AdjustmentCategoryCode
    ,rd.AdjustmentCategory
    ,rd.LandExemptFlag
    ,rd.MMSTransportationDeductFlag
    ,rd.NMEXTransportationDeductFlag
    ,rd.MMSProcessingAllowanceFlag
    ,rd.NMEXProcessingAllowanceFlag
    ,rd.AllocationOrder
FROM [dbo].[RevenueDeductions] rd
WHERE rd.RevenueDeductionID = @RevenueDeductionID



