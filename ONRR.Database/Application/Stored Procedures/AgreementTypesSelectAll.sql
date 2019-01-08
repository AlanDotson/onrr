
CREATE PROCEDURE [Application].[AgreementTypesSelectAll]
AS
SET NOCOUNT ON

SELECT at.AgreementTypeID
    ,at.AgreementType
FROM [dbo].[AgreementTypes] at



