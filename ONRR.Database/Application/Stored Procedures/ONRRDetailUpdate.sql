
CREATE PROCEDURE [Application].[ONRRDetailUpdate] 
     @ONRRDetailID INT
	,@SL_DETAIL_NO BIGINT
    ,@GrossAmount NUMERIC(13,2)
    ,@OverrideGrossAmount NUMERIC(13,2)
    ,@GrossQuantity NUMERIC(13,2)
    ,@OverrideGrossQuantity NUMERIC(13,2)
    ,@TransactionValueAmount NUMERIC(13,2)
    ,@OverrideTransactionValueAmount NUMERIC(13,2)
    ,@TransactionQuantity NUMERIC(13,2)
    ,@OverrideTransactionQuantity NUMERIC(13,2)
    ,@Price NUMERIC(6,2)
    ,@LeaseAgreementID INT
    ,@ProductCodeID INT
    ,@StateCode CHAR(2)
    ,@CompanyMarketedVolume NUMERIC(13,2)
    ,@OverrideCompanyMarketedVolume NUMERIC(13,2)
    ,@CompanyMarketedValue NUMERIC(13,2)
    ,@OverrideCompanyMarketedValue NUMERIC(13,2)
    ,@SalesVolume NUMERIC(13,2)
    ,@OverrideSalesVolume NUMERIC(13,2)
    ,@MMBTU NUMERIC(13,2)
    ,@OverrideMMBTU NUMERIC(13,2)
    ,@SalesValue NUMERIC(13,2)
    ,@OverrideSalesValue NUMERIC(13,2)
    ,@GrossRoyaltyValue NUMERIC(13,2)
    ,@OverrideGrossRoyaltyValue NUMERIC(13,2)
    ,@TransportationAllowanceDeduction NUMERIC(13,2)
    ,@OverrideTransportationAllowanceDeduction NUMERIC(13,2)
    ,@ProcessingAllowanceDeduction NUMERIC(13,2)
    ,@OverrideProcessingAllowanceDeduction NUMERIC(13,2)
    ,@NetRoyaltyValue NUMERIC(13,2)
    ,@OverrideNetRoyaltyValue NUMERIC(13,2)
    ,@AggregateID INT
    ,@ReversalAggregateID INT
    ,@AccountingMonth DATE
    ,@ProductionMonth DATE
    ,@TransactionCodeID INT
    ,@AdjustmentReasonCodeID INT
    ,@ProcessingStatusID INT
    ,@SuspendReasonID INT
    ,@SalesTypeID INT
    ,@ReversalDetailID INT
AS
SET NOCOUNT ON

UPDATE [dbo].[ONRRDetail]
SET GrossAmount = @GrossAmount
    ,OverrideGrossAmount = @OverrideGrossAmount
    ,GrossQuantity = @GrossQuantity
    ,OverrideGrossQuantity = @OverrideGrossQuantity
    ,TransactionValueAmount = @TransactionValueAmount
    ,OverrideTransactionValueAmount = @OverrideTransactionValueAmount
    ,TransactionQuantity = @TransactionQuantity
    ,OverrideTransactionQuantity = @OverrideTransactionQuantity
    ,Price = @Price
    ,LeaseAgreementID = @LeaseAgreementID
    ,ProductCodeID = @ProductCodeID
    ,StateCode = @StateCode
    ,CompanyMarketedVolume = @CompanyMarketedVolume
    ,OverrideCompanyMarketedVolume = @OverrideCompanyMarketedVolume
    ,CompanyMarketedValue = @CompanyMarketedValue
    ,OverrideCompanyMarketedValue = @OverrideCompanyMarketedValue
    ,SalesVolume = @SalesVolume
    ,OverrideSalesVolume = @OverrideSalesVolume
    ,MMBTU = @MMBTU
    ,OverrideMMBTU = @OverrideMMBTU
    ,SalesValue = @SalesValue
    ,OverrideSalesValue = @OverrideSalesValue
    ,GrossRoyaltyValue = @GrossRoyaltyValue
    ,OverrideGrossRoyaltyValue = @OverrideGrossRoyaltyValue
    ,TransportationAllowanceDeduction = @TransportationAllowanceDeduction
    ,OverrideTransportationAllowanceDeduction = @OverrideTransportationAllowanceDeduction
    ,ProcessingAllowanceDeduction = @ProcessingAllowanceDeduction
    ,OverrideProcessingAllowanceDeduction = @OverrideProcessingAllowanceDeduction
    ,NetRoyaltyValue = @NetRoyaltyValue
    ,OverrideNetRoyaltyValue = @OverrideNetRoyaltyValue
    ,AggregateID = @AggregateID
    ,ReversalAggregateID = @ReversalAggregateID
    ,AccountingMonth = @AccountingMonth
    ,ProductionMonth = @ProductionMonth
    ,TransactionCodeID = @TransactionCodeID
    ,AdjustmentReasonCodeID = @AdjustmentReasonCodeID
    ,ProcessingStatusID = @ProcessingStatusID
    ,SuspendReasonID = @SuspendReasonID
    ,SalesTypeID = @SalesTypeID
	,SL_DETAIL_NO = @SL_DETAIL_NO
    ,ReversalDetailID = @ReversalDetailID
WHERE ONRRDetailID = @ONRRDetailID



