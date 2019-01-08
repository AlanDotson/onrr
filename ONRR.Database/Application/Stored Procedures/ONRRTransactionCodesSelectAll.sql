
CREATE PROCEDURE [Application].[ONRRTransactionCodesSelectAll]
AS
SET NOCOUNT ON

SELECT onrrtc.TransactionCodeID
    ,onrrtc.ONRRTransactionCode
    ,onrrtc.ProductCode
    ,onrrtc.DispositionCode
FROM [dbo].[ONRRTransactionCodes] onrrtc



