
CREATE PROCEDURE [Application].[ProductCodeCrossReferenceInsert] @ONRRProductCode VARCHAR(15)
    ,@QRAMajorProductCode VARCHAR(5)
    ,@NewID INT OUTPUT
AS
SET NOCOUNT ON

INSERT INTO [dbo].[ProductCodeCrossReference] (
    ONRRProductCode
    ,QRAMajorProductCode
    )
VALUES (
    @ONRRProductCode
    ,@QRAMajorProductCode
    )

SET @NewID = @@Identity



