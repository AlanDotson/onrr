
CREATE PROCEDURE [Application].[ONRRTransactionCodesInsert] @ONRRTransactionCode VARCHAR(5)
    ,@ProductCode VARCHAR(5)
    ,@DispositionCode VARCHAR(5)
    ,@NewID INT OUTPUT
AS
SET NOCOUNT ON

INSERT INTO [dbo].[ONRRTransactionCodes] (
    ONRRTransactionCode
    ,ProductCode
    ,DispositionCode
    )
VALUES (
    @ONRRTransactionCode
    ,@ProductCode
    ,@DispositionCode
    )

SET @NewID = @@Identity



