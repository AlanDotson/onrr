
CREATE PROCEDURE [Application].[PayorCodesSelectAll]
AS
SET NOCOUNT ON

SELECT pc.PayorCodeID
    ,pc.PayorCode
    ,pc.Payor
FROM [dbo].[PayorCodes] pc



