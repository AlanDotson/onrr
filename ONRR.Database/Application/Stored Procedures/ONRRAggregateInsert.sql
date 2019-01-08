
CREATE PROCEDURE [Application].[ONRRAggregateInsert] @LeaseAgreementID INT
    ,@ProductCodeID INT
    ,@SalesTypeID INT
    ,@ProductionMonth DATE
    ,@TransactionCodeID INT
    ,@AdjustmentReasonCodeID INT
    ,@SalesVolume NUMERIC(13,2)
    ,@GasMMBTU NUMERIC(13,2)
    ,@SalesValue NUMERIC(13,2)
    ,@GrossRoyaltyValue NUMERIC(13,2)
    ,@TransortationAllowanceDeduction NUMERIC
    ,@ProcessingAllowanceDeduction NUMERIC(13,2)
    ,@NetRoyaltyValue NUMERIC(13,2)
    ,@FileID INT
    ,@PADNumber VARCHAR(8)
    ,@PayorCodeID INT
    ,@StatusID INT
    ,@PaymentMethodID INT
    ,@NewID INT OUTPUT
AS
SET NOCOUNT ON

INSERT INTO [dbo].[ONRRAggregate] (
    LeaseAgreementID
    ,ProductCodeID
    ,SalesTypeID
    ,ProductionMonth
    ,TransactionCodeID
    ,AdjustmentReasonCodeID
    ,SalesVolume
    ,GasMMBTU
    ,SalesValue
    ,GrossRoyaltyValue
    ,TransortationAllowanceDeduction
    ,ProcessingAllowanceDeduction
    ,NetRoyaltyValue
    ,FileID
    ,PADNumber
    ,PayorCodeID
    ,StatusID
    ,PaymentMethodID
    )
VALUES (
    @LeaseAgreementID
    ,@ProductCodeID
    ,@SalesTypeID
    ,@ProductionMonth
    ,@TransactionCodeID
    ,@AdjustmentReasonCodeID
    ,@SalesVolume
    ,@GasMMBTU
    ,@SalesValue
    ,@GrossRoyaltyValue
    ,@TransortationAllowanceDeduction
    ,@ProcessingAllowanceDeduction
    ,@NetRoyaltyValue
    ,@FileID
    ,@PADNumber
    ,@PayorCodeID
    ,@StatusID
    ,@PaymentMethodID
    )

SET @NewID = @@Identity



