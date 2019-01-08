
CREATE PROCEDURE [Application].[AgreementClassificationsUpdate] @AgreementClassificationID INT
    ,@AgreementClassification VARCHAR(50)
AS
SET NOCOUNT ON

UPDATE [dbo].[AgreementClassifications]
SET AgreementClassification = @AgreementClassification
WHERE AgreementClassificationID = @AgreementClassificationID



