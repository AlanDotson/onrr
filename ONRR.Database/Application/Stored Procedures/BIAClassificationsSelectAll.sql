
CREATE PROCEDURE [Application].[BIAClassificationsSelectAll]
AS
SET NOCOUNT ON

SELECT biac.BIAClassificationID
    ,biac.BIAClassification
FROM [dbo].[BIAClassifications] biac



