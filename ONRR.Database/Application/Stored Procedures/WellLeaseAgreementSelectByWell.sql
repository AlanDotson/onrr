
CREATE PROCEDURE [Application].[WellLeaseAgreementSelectByWell] @WellCompletionID varchar(10)
AS
SET NOCOUNT ON

SELECT wla.WellLeaseAgreementID
    ,wla.WellCompletionID
    ,wla.LeaseAgreementID
    ,wla.ProductCodeID
    ,wla.SalesTypeID
    ,wla.EffectiveFrom
    ,wla.EffectiveTo
	,st.SalesType
	,pc.ONRRProductCode
	,pc.QRAMajorProductCode
FROM [dbo].[WellLeaseAgreements] wla
	LEFT JOIN dbo.SalesTypes st on wla.SalesTypeID = st.SalesTypeID
	LEFT JOIN dbo.ProductCodeCrossReference pc on wla.ProductCodeID = pc.ProductCodeID
WHERE wla.WellCompletionID = @WellCompletionID