
CREATE PROCEDURE [Application].[ProductCodeCrossReferenceSelect] @ProductCodeID INT
AS
SET NOCOUNT ON

SELECT pccr.ProductCodeID
    ,pccr.ONRRProductCode
    ,pccr.QRAMajorProductCode
FROM [dbo].[ProductCodeCrossReference] pccr
WHERE pccr.ProductCodeID = @ProductCodeID



