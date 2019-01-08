
CREATE PROCEDURE [Application].[WellLeaseAgreementsInsert] @WellCompletionID VARCHAR(10)
    ,@LeaseAgreementID INT
    ,@ProductCodeID INT
    ,@SalesTypeID INT
    ,@EffectiveFrom DATE
    ,@EffectiveTo DATE
    ,@NewID INT OUTPUT
AS
SET NOCOUNT ON

INSERT INTO [dbo].[WellLeaseAgreements] (
    WellCompletionID
    ,LeaseAgreementID
    ,ProductCodeID
    ,SalesTypeID
    ,EffectiveFrom
    ,EffectiveTo
    )
VALUES (
    @WellCompletionID
    ,@LeaseAgreementID
    ,@ProductCodeID
    ,@SalesTypeID
    ,@EffectiveFrom
    ,@EffectiveTo
    )

SET @NewID = @@Identity



