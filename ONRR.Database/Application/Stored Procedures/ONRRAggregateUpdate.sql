
CREATE PROCEDURE [Application].[ONRRAggregateUpdate] @AggregateID INT
    ,@LeaseAgreementID INT
    ,@ProductCodeID INT
    ,@SalesTypeID INT
    ,@ProductionMonth DATE
    ,@TransactionCodeID INT
    ,@AdjustmentReasonCodeID INT
    ,@SalesVolume NUMERIC(13,2)
    ,@GasMMBTU NUMERIC(13,2)
    ,@SalesValue NUMERIC(13,2)
    ,@GrossRoyaltyValue NUMERIC(13,2)
    ,@TransortationAllowanceDeduction NUMERIC(13,2)
    ,@ProcessingAllowanceDeduction NUMERIC(13,2)
    ,@NetRoyaltyValue NUMERIC(13,2)
    ,@FileID INT
    ,@PADNumber VARCHAR(8)
    ,@PayorCodeID INT
    ,@StatusID INT
    ,@PaymentMethodID INT
AS
SET NOCOUNT ON

UPDATE [dbo].[ONRRAggregate]
SET LeaseAgreementID = @LeaseAgreementID
    ,ProductCodeID = @ProductCodeID
    ,SalesTypeID = @SalesTypeID
    ,ProductionMonth = @ProductionMonth
    ,TransactionCodeID = @TransactionCodeID
    ,AdjustmentReasonCodeID = @AdjustmentReasonCodeID
    ,SalesVolume = @SalesVolume
    ,GasMMBTU = @GasMMBTU
    ,SalesValue = @SalesValue
    ,GrossRoyaltyValue = @GrossRoyaltyValue
    ,TransortationAllowanceDeduction = @TransortationAllowanceDeduction
    ,ProcessingAllowanceDeduction = @ProcessingAllowanceDeduction
    ,NetRoyaltyValue = @NetRoyaltyValue
    ,FileID = @FileID
    ,PADNumber = @PADNumber
    ,PayorCodeID = @PayorCodeID
    ,StatusID = @StatusID
    ,PaymentMethodID = @PaymentMethodID
WHERE AggregateID = @AggregateID



