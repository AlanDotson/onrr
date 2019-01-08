
CREATE PROCEDURE [Application].[BIAClassificationsSelect] @BIAClassificationID INT
AS
SET NOCOUNT ON

SELECT biac.BIAClassificationID
    ,biac.BIAClassification
FROM [dbo].[BIAClassifications] biac
WHERE biac.BIAClassificationID = @BIAClassificationID



