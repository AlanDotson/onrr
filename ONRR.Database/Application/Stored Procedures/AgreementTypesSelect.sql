
CREATE PROCEDURE [Application].[AgreementTypesSelect] @AgreementTypeID INT
AS
SET NOCOUNT ON

SELECT at.AgreementTypeID
    ,at.AgreementType
FROM [dbo].[AgreementTypes] at
WHERE at.AgreementTypeID = @AgreementTypeID



