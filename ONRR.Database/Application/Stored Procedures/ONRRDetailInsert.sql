
CREATE PROCEDURE [Application].[ONRRDetailInsert] 
     @ONRRDetailID INT
	,@GrossAmount NUMERIC(13,2)
    ,@OverrideGrossAmount NUMERIC(13,2)
    ,@GrossQuantity NUMERIC(13,2)
    ,@OverrideGrossQuantity NUMERIC(13,2)
    ,@TransactionValueAmount NUMERIC(13,2)
    ,@OverrideTransactionValueAmount NUMERIC(13,2)
    ,@TransactionQuantity NUMERIC(13,2)
    ,@OverrideTransactionQuantity NUMERIC(13,2)
    ,@Price NUMERIC(13,2)
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
    ,@NewID INT OUTPUT
AS
SET NOCOUNT ON

INSERT INTO [dbo].[ONRRDetail] (
     GrossAmount
    ,OverrideGrossAmount
    ,GrossQuantity
    ,OverrideGrossQuantity
    ,TransactionValueAmount
    ,OverrideTransactionValueAmount
    ,TransactionQuantity
    ,OverrideTransactionQuantity
    ,Price
    ,LeaseAgreementID
    ,ProductCodeID
    ,StateCode
    ,CompanyMarketedVolume
    ,OverrideCompanyMarketedVolume
    ,CompanyMarketedValue
    ,OverrideCompanyMarketedValue
    ,SalesVolume
    ,OverrideSalesVolume
    ,MMBTU
    ,OverrideMMBTU
    ,SalesValue
    ,OverrideSalesValue
    ,GrossRoyaltyValue
    ,OverrideGrossRoyaltyValue
    ,TransportationAllowanceDeduction
    ,OverrideTransportationAllowanceDeduction
    ,ProcessingAllowanceDeduction
    ,OverrideProcessingAllowanceDeduction
    ,NetRoyaltyValue
    ,OverrideNetRoyaltyValue
    ,AggregateID
    ,ReversalAggregateID
    ,AccountingMonth
    ,ProductionMonth
    ,TransactionCodeID
    ,AdjustmentReasonCodeID
    ,ProcessingStatusID
    ,SuspendReasonID
    ,ONRRDetailID
    ,SalesTypeID
    ,ReversalDetailID
    )
VALUES (
     @GrossAmount
    ,@OverrideGrossAmount
    ,@GrossQuantity
    ,@OverrideGrossQuantity
    ,@TransactionValueAmount
    ,@OverrideTransactionValueAmount
    ,@TransactionQuantity
    ,@OverrideTransactionQuantity
    ,@Price
    ,@LeaseAgreementID
    ,@ProductCodeID
    ,@StateCode
    ,@CompanyMarketedVolume
    ,@OverrideCompanyMarketedVolume
    ,@CompanyMarketedValue
    ,@OverrideCompanyMarketedValue
    ,@SalesVolume
    ,@OverrideSalesVolume
    ,@MMBTU
    ,@OverrideMMBTU
    ,@SalesValue
    ,@OverrideSalesValue
    ,@GrossRoyaltyValue
    ,@OverrideGrossRoyaltyValue
    ,@TransportationAllowanceDeduction
    ,@OverrideTransportationAllowanceDeduction
    ,@ProcessingAllowanceDeduction
    ,@OverrideProcessingAllowanceDeduction
    ,@NetRoyaltyValue
    ,@OverrideNetRoyaltyValue
    ,@AggregateID
    ,@ReversalAggregateID
    ,@AccountingMonth
    ,@ProductionMonth
    ,@TransactionCodeID
    ,@AdjustmentReasonCodeID
    ,@ProcessingStatusID
    ,@SuspendReasonID
    ,@ONRRDetailID
    ,@SalesTypeID
    ,@ReversalDetailID
    )

SET @NewID = @@Identity



