
CREATE PROCEDURE [Application].[WellLeaseAgreementsUpdate] @WellLeaseAgreementID INT
    ,@WellCompletionID VARCHAR(10)
    ,@LeaseAgreementID INT
    ,@ProductCodeID INT
    ,@SalesTypeID INT
    ,@EffectiveFrom DATE
    ,@EffectiveTo DATE
AS
SET NOCOUNT ON

UPDATE [dbo].[WellLeaseAgreements]
SET WellCompletionID = @WellCompletionID
    ,LeaseAgreementID = @LeaseAgreementID
    ,ProductCodeID = @ProductCodeID
    ,SalesTypeID = @SalesTypeID
    ,EffectiveFrom = @EffectiveFrom
    ,EffectiveTo = @EffectiveTo
WHERE WellLeaseAgreementID = @WellLeaseAgreementID



