
CREATE PROCEDURE [Application].[AdjustmentReasonCodesSelect] @AdjustmentReasonCodeID INT
AS
SET NOCOUNT ON

SELECT arc.AdjustmentReasonCodeID
    ,arc.AdjustmentReasonCode
    ,arc.AdjustmentReason
FROM [dbo].[AdjustmentReasonCodes] arc
WHERE arc.AdjustmentReasonCodeID = @AdjustmentReasonCodeID



