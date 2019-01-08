
CREATE PROCEDURE [Application].[WellCompletionsSelectAll]
AS
SET NOCOUNT ON

SELECT wc.WellCompletionID
    ,wc.PropertyNumber
    ,wc.WellAcreage
    ,wc.WellCompletionName
    ,wc.StateCode
	,s.State
    ,wc.API
    ,wc.Company
    ,wc.PropertyName
    ,wc.GrossMarketedInterest
FROM [dbo].[WellCompletions] wc
	LEFT JOIN States s ON s.StateCode = wc.StateCode



