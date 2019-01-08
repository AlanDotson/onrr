
CREATE PROCEDURE [Application].[AgreementClassificationsSelectAll]
AS
SET NOCOUNT ON

SELECT ac.AgreementClassificationID
    ,ac.AgreementClassification
FROM [dbo].[AgreementClassifications] ac



