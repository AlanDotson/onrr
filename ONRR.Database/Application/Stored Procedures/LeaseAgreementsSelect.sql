
CREATE PROCEDURE [Application].[LeaseAgreementsSelect] @LeaseAgreementID INT
AS
SET NOCOUNT ON

SELECT la.LeaseAgreementID
    ,la.LeaseID
    ,la.AgreementID
    ,la.EffectiveFrom
    ,la.EffectiveTo
    ,la.TractFactor
    ,la.OverrideTractFactor
    ,la.MarketShare
    ,la.TractAcreage
FROM [dbo].[LeaseAgreements] la
WHERE la.LeaseAgreementID = @LeaseAgreementID



