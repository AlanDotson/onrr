
CREATE PROCEDURE [Application].[BIAClassificationsInsert] @BIAClassification VARCHAR(150)
    ,@NewID INT OUTPUT
AS
SET NOCOUNT ON

INSERT INTO [dbo].[BIAClassifications] (BIAClassification)
VALUES (@BIAClassification)

SET @NewID = @@Identity



