
CREATE PROCEDURE [Application].[AdjustmentReasonCodesSelectAll]
AS
SET NOCOUNT ON

SELECT arc.AdjustmentReasonCodeID
    ,arc.AdjustmentReasonCode
    ,arc.AdjustmentReason
FROM [dbo].[AdjustmentReasonCodes] arc



