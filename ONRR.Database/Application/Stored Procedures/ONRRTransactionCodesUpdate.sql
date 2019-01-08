
CREATE PROCEDURE [Application].[ONRRTransactionCodesUpdate] @TransactionCodeID INT
    ,@ONRRTransactionCode VARCHAR(5)
    ,@ProductCode VARCHAR(5)
    ,@DispositionCode VARCHAR(5)
AS
SET NOCOUNT ON

UPDATE [dbo].[ONRRTransactionCodes]
SET ONRRTransactionCode = @ONRRTransactionCode
    ,ProductCode = @ProductCode
    ,DispositionCode = @DispositionCode
WHERE TransactionCodeID = @TransactionCodeID



