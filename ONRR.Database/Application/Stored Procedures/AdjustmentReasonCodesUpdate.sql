
CREATE PROCEDURE [Application].[AdjustmentReasonCodesUpdate] @AdjustmentReasonCodeID INT
    ,@AdjustmentReasonCode VARCHAR(2)
    ,@AdjustmentReason VARCHAR(60)
AS
SET NOCOUNT ON

UPDATE [dbo].[AdjustmentReasonCodes]
SET AdjustmentReasonCode = @AdjustmentReasonCode
    ,AdjustmentReason = @AdjustmentReason
WHERE AdjustmentReasonCodeID = @AdjustmentReasonCodeID



