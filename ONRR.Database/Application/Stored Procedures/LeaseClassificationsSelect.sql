
CREATE PROCEDURE [Application].[LeaseClassificationsSelect] @LeaseClassificationID INT
AS
SET NOCOUNT ON

SELECT lc.LeaseClassificationID
    ,lc.QLSClassificationID
    ,lc.Classification
    ,lc.Active
FROM [dbo].[LeaseClassifications] lc
WHERE lc.LeaseClassificationID = @LeaseClassificationID



