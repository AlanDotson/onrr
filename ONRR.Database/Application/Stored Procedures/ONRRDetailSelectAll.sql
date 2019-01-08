
CREATE PROCEDURE [Application].[ONRRDetailSelectAll]
AS
SET NOCOUNT ON

SELECT onrrd.SL_DETAIL_NO
    ,onrrd.GrossAmount
    ,onrrd.OverrideGrossAmount
    ,onrrd.GrossQuantity
    ,onrrd.OverrideGrossQuantity
    ,onrrd.TransactionValueAmount
    ,onrrd.OverrideTransactionValueAmount
    ,onrrd.TransactionQuantity
    ,onrrd.OverrideTransactionQuantity
    ,onrrd.Price
    ,onrrd.LeaseAgreementID
    ,onrrd.ProductCodeID
	,pccr.ONRRProductCode
	,pccr.QRAMajorProductCode
    ,onrrd.StateCode
	,s.State
    ,onrrd.CompanyMarketedVolume
    ,onrrd.OverrideCompanyMarketedVolume
    ,onrrd.CompanyMarketedValue
    ,onrrd.OverrideCompanyMarketedValue
    ,onrrd.SalesVolume
    ,onrrd.OverrideSalesVolume
    ,onrrd.MMBTU
    ,onrrd.OverrideMMBTU
    ,onrrd.SalesValue
    ,onrrd.OverrideSalesValue
    ,onrrd.GrossRoyaltyValue
    ,onrrd.OverrideGrossRoyaltyValue
    ,onrrd.TransportationAllowanceDeduction
    ,onrrd.OverrideTransportationAllowanceDeduction
    ,onrrd.ProcessingAllowanceDeduction
    ,onrrd.OverrideProcessingAllowanceDeduction
    ,onrrd.NetRoyaltyValue
    ,onrrd.OverrideNetRoyaltyValue
    ,onrrd.AggregateID
    ,onrrd.ReversalAggregateID
    ,onrrd.AccountingMonth
    ,onrrd.ProductionMonth
    ,onrrd.TransactionCodeID
	,otc.DispositionCode
	,otc.ONRRTransactionCode
	,otc.ProductCode
    ,onrrd.AdjustmentReasonCodeID
	,arc.AdjustmentReason
    ,onrrd.ProcessingStatusID
    ,onrrd.SuspendReasonID
    ,onrrd.ONRRDetailID
    ,onrrd.SalesTypeID
	,st.SalesType
    ,onrrd.ReversalDetailID

FROM [dbo].[ONRRDetail] onrrd
	LEFT JOIN States s ON s.StateCode = onrrd.StateCode
	LEFT JOIN ProductCodeCrossReference pccr ON pccr.ProductCodeID = onrrd.ProductCodeID
	LEFT JOIN ONRRTransactionCodes otc ON otc.TransactionCodeID = onrrd.TransactionCodeID
	LEFT JOIN AdjustmentReasonCodes arc ON arc.AdjustmentReasonCodeID = onrrd.AdjustmentReasonCodeID
	LEFT JOIN SalesTypes st ON st.SalesTypeID = onrrd.SalesTypeID



