
CREATE PROCEDURE [Application].[ONRRAggregateSelect] @AggregateID INT
AS
SET NOCOUNT ON

SELECT onrra.AggregateID
    ,onrra.LeaseAgreementID
    ,onrra.ProductCodeID
    ,onrra.SalesTypeID
	,st.SalesType
    ,onrra.ProductionMonth
    ,onrra.TransactionCodeID
	,otc.ONRRTransactionCode
	,otc.DispositionCode
	,otc.ProductCode
    ,onrra.AdjustmentReasonCodeID
	,arc.AdjustmentReason
    ,onrra.SalesVolume
    ,onrra.GasMMBTU
    ,onrra.SalesValue
    ,onrra.GrossRoyaltyValue
    ,onrra.TransortationAllowanceDeduction
    ,onrra.ProcessingAllowanceDeduction
    ,onrra.NetRoyaltyValue
    ,onrra.FileID
    ,onrra.PADNumber
    ,onrra.PayorCodeID
	,pc.Payor
    ,onrra.StatusID
    ,onrra.PaymentMethodID
	,pm.PaymentMethod
FROM [dbo].[ONRRAggregate] onrra
	LEFT JOIN [dbo].[ONRRTransactionCodes] otc ON otc.TransactionCodeID = onrra.TransactionCodeID
	LEFT JOIN [dbo].[SalesTypes] st ON st.SalesTypeID = onrra.SalesTypeID
	LEFT JOIN [dbo].[PayorCodes] pc ON pc.PayorCodeID = onrra.PayorCodeID
	LEFT JOIN [dbo].[PaymentMethods] pm ON pm.PaymentMethodID = onrra.PaymentMethodID
	LEFT JOIN [dbo].[AdjustmentReasonCodes] arc ON arc.AdjustmentReasonCodeID = onrra.AdjustmentReasonCodeID

WHERE onrra.AggregateID = @AggregateID



