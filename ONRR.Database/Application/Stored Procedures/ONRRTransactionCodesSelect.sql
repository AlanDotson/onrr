
CREATE PROCEDURE [Application].[ONRRTransactionCodesSelect] @TransactionCodeID INT
AS
SET NOCOUNT ON

SELECT onrrtc.TransactionCodeID
    ,onrrtc.ONRRTransactionCode
    ,onrrtc.ProductCode
    ,onrrtc.DispositionCode
FROM [dbo].[ONRRTransactionCodes] onrrtc
WHERE onrrtc.TransactionCodeID = @TransactionCodeID



