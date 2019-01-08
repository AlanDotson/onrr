
CREATE PROCEDURE [Application].[AgreementTypesUpdate] @AgreementTypeID INT
    ,@AgreementType VARCHAR(50)
AS
SET NOCOUNT ON

UPDATE [dbo].[AgreementTypes]
SET AgreementType = @AgreementType
WHERE AgreementTypeID = @AgreementTypeID



