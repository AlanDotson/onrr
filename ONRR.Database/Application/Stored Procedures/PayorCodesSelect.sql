
CREATE PROCEDURE [Application].[PayorCodesSelect] @PayorCodeID INT
AS
SET NOCOUNT ON

SELECT pc.PayorCodeID
    ,pc.PayorCode
    ,pc.Payor
FROM [dbo].[PayorCodes] pc
WHERE pc.PayorCodeID = @PayorCodeID



