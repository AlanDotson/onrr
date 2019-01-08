
CREATE PROCEDURE [Application].[AgreementsSelect] @AgreementID INT
AS
SET NOCOUNT ON

SELECT a.AgreementID
    ,a.ONRRAgreementID
    ,a.BLMSerialNumber
    ,a.ONRRAgreementDescription
    ,a.Formation
    ,a.AgreementClassificationID
    ,a.AgreementTypeID
    ,a.TotalAcreage
    ,a.EffectiveFrom
    ,a.EffectiveTo
    ,a.CompanyID
	,ac.AgreementClassification
	,at.AgreementType
	,cpc.CompanyName
FROM [dbo].[Agreements] a
	LEFT JOIN [dbo].[AgreementClassifications] ac ON a.AgreementClassificationID = ac.AgreementClassificationID
	LEFT JOIN [dbo].[AgreementTypes] at ON a.AgreementTypeID = at.AgreementTypeID
	LEFT JOIN [dbo].[CompanyPayorCodes] cpc ON a.CompanyID = cpc.CompanyID
WHERE a.AgreementID = @AgreementID



