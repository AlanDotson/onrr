
CREATE PROCEDURE [Application].[AgreementClassificationsInsert] @AgreementClassification VARCHAR(50)
    ,@NewID INT OUTPUT
AS
SET NOCOUNT ON

INSERT INTO [dbo].[AgreementClassifications] (AgreementClassification)
VALUES (@AgreementClassification)

SET @NewID = @@Identity



