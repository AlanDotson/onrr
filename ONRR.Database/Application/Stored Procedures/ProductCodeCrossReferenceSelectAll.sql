
CREATE PROCEDURE [Application].[ProductCodeCrossReferenceSelectAll]
AS
SET NOCOUNT ON

SELECT pccr.ProductCodeID
    ,pccr.ONRRProductCode
    ,pccr.QRAMajorProductCode
FROM [dbo].[ProductCodeCrossReference] pccr



