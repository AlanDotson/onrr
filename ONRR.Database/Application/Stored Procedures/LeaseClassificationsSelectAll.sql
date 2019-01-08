
CREATE PROCEDURE [Application].[LeaseClassificationsSelectAll]
AS
SET NOCOUNT ON

SELECT lc.LeaseClassificationID
    ,lc.QLSClassificationID
    ,lc.Classification
    ,lc.Active
FROM [dbo].[LeaseClassifications] lc



