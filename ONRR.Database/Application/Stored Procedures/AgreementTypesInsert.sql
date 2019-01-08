
CREATE PROCEDURE [Application].[AgreementTypesInsert] @AgreementType VARCHAR(50)
    ,@NewID INT OUTPUT
AS
SET NOCOUNT ON

INSERT INTO [dbo].[AgreementTypes] (AgreementType)
VALUES (@AgreementType)

SET @NewID = @@Identity



