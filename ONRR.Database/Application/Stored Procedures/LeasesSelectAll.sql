
CREATE PROCEDURE [Application].[LeasesSelectAll]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT [LeaseID]
		,[ONRRLeaseID]
		,[BLMSerialNumber]
		,[QEPLeaseID]
		,[QEPLeaseName]
		,l.[LeaseClassificationID]
		,l.[BIAClassificationID]
		,[QEPEffectiveDate]
		,l.[StateCode]
		,s.[State]
		,[County]
		,[RoyaltyRate]
		,[EffectiveFrom]
		,[EffectiveTo]
		,l.[CompanyID]
		,bia.BIAClassification
		,lc.Classification
		,cpc.CompanyName

	FROM [dbo].[Leases] l
		LEFT JOIN [dbo].[States] s ON s.StateCode = l.StateCode
		LEFT JOIN [dbo].[LeaseClassifications] lc ON l.LeaseClassificationID = lc.LeaseClassificationID
		LEFT JOIN [dbo].[BIAClassifications] bia ON l.BIAClassificationID = bia.BIAClassificationID
		LEFT JOIN [dbo].[CompanyPayorCodes] cpc ON l.CompanyID = cpc.CompanyID
END



