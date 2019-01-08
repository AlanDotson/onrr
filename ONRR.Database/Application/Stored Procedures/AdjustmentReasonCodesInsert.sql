
CREATE PROCEDURE [Application].[AdjustmentReasonCodesInsert] @AdjustmentReasonCode VARCHAR(2)
    ,@AdjustmentReason VARCHAR(60)
    ,@NewID INT OUTPUT
AS
SET NOCOUNT ON

INSERT INTO [dbo].[AdjustmentReasonCodes] (
    AdjustmentReasonCode
    ,AdjustmentReason
    )
VALUES (
    @AdjustmentReasonCode
    ,@AdjustmentReason
    )

SET @NewID = @@Identity



