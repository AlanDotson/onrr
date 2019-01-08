
CREATE PROCEDURE [Application].[RevenueDeductionsInsert] @AdjustmentCategoryCode VARCHAR(2)
    ,@AdjustmentCategory VARCHAR(60)
    ,@LandExemptFlag BIT
    ,@MMSTransportationDeductFlag BIT
    ,@NMEXTransportationDeductFlag BIT
    ,@MMSProcessingAllowanceFlag BIT
    ,@NMEXProcessingAllowanceFlag BIT
    ,@AllocationOrder INT
    ,@NewID INT OUTPUT
AS
SET NOCOUNT ON

INSERT INTO [dbo].[RevenueDeductions] (
    AdjustmentCategoryCode
    ,AdjustmentCategory
    ,LandExemptFlag
    ,MMSTransportationDeductFlag
    ,NMEXTransportationDeductFlag
    ,MMSProcessingAllowanceFlag
    ,NMEXProcessingAllowanceFlag
    ,AllocationOrder
    )
VALUES (
    @AdjustmentCategoryCode
    ,@AdjustmentCategory
    ,@LandExemptFlag
    ,@MMSTransportationDeductFlag
    ,@NMEXTransportationDeductFlag
    ,@MMSProcessingAllowanceFlag
    ,@NMEXProcessingAllowanceFlag
    ,@AllocationOrder
    )

SET @NewID = @@Identity



