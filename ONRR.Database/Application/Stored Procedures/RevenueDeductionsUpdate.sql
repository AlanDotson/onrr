
CREATE PROCEDURE [Application].[RevenueDeductionsUpdate] @RevenueDeductionID INT
    ,@AdjustmentCategoryCode VARCHAR(2)
    ,@AdjustmentCategory VARCHAR(60)
    ,@LandExemptFlag BIT
    ,@MMSTransportationDeductFlag BIT
    ,@NMEXTransportationDeductFlag BIT
    ,@MMSProcessingAllowanceFlag BIT
    ,@NMEXProcessingAllowanceFlag BIT
    ,@AllocationOrder INT
AS
SET NOCOUNT ON

UPDATE [dbo].[RevenueDeductions]
SET AdjustmentCategoryCode = @AdjustmentCategoryCode
    ,AdjustmentCategory = @AdjustmentCategory
    ,LandExemptFlag = @LandExemptFlag
    ,MMSTransportationDeductFlag = @MMSTransportationDeductFlag
    ,NMEXTransportationDeductFlag = @NMEXTransportationDeductFlag
    ,MMSProcessingAllowanceFlag = @MMSProcessingAllowanceFlag
    ,NMEXProcessingAllowanceFlag = @NMEXProcessingAllowanceFlag
    ,AllocationOrder = @AllocationOrder
WHERE RevenueDeductionID = @RevenueDeductionID



