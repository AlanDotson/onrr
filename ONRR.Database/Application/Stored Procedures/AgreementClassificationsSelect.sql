
CREATE PROCEDURE [Application].[AgreementClassificationsSelect] @AgreementClassificationID INT
AS
SET NOCOUNT ON

SELECT ac.AgreementClassificationID
    ,ac.AgreementClassification
FROM [dbo].[AgreementClassifications] ac
WHERE ac.AgreementClassificationID = @AgreementClassificationID



