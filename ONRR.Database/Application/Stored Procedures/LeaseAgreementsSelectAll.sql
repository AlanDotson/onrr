
CREATE PROCEDURE [Application].[LeaseAgreementsSelectAll]
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



