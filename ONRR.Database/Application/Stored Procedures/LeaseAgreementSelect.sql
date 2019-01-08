
CREATE PROCEDURE [Application].[LeaseAgreementSelect] (@LeaseID INT)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT [LeaseAgreementID]
		,la.[LeaseID]
		,l.QEPLeaseName
		,la.[AgreementID]
		,a.[ONRRAgreementDescription]
		,la.[EffectiveFrom]
		,la.[EffectiveTo]
		,[TractFactor]
		,[OverrideTractFactor]
		,[MarketShare]
		,la.[TractAcreage]
		,Formation
	FROM [dbo].[LeaseAgreements] la
	INNER JOIN Agreements a ON a.AgreementID = la.AgreementID
	INNER JOIN Leases l ON l.LeaseID = la.LeaseID
	WHERE la.[LeaseID] = @LeaseID
END



