
CREATE PROCEDURE [Application].[ProductCodeCrossReferenceUpdate] @ProductCodeID INT
    ,@ONRRProductCode VARCHAR(15)
    ,@QRAMajorProductCode VARCHAR(5)
AS
SET NOCOUNT ON

UPDATE [dbo].[ProductCodeCrossReference]
SET ONRRProductCode = @ONRRProductCode
    ,QRAMajorProductCode = @QRAMajorProductCode
WHERE ProductCodeID = @ProductCodeID



