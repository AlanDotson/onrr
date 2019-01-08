
CREATE PROCEDURE [Application].[BIAClassificationsUpdate] @BIAClassificationID INT
    ,@BIAClassification VARCHAR(150)
AS
SET NOCOUNT ON

UPDATE [dbo].[BIAClassifications]
SET BIAClassification = @BIAClassification
WHERE BIAClassificationID = @BIAClassificationID



