
CREATE PROCEDURE [Application].[PayorCodesUpdate] @PayorCodeID INT
    ,@PayorCode VARCHAR(5)
    ,@Payor VARCHAR(60)
AS
SET NOCOUNT ON

UPDATE [dbo].[PayorCodes]
SET PayorCode = @PayorCode
    ,Payor = @Payor
WHERE PayorCodeID = @PayorCodeID



