
CREATE PROCEDURE [Application].[AccountingMonthSelectAll]
AS
SET NOCOUNT ON

SELECT am.AccountingMonth
    ,am.OpenDate
    ,am.CloseDate
FROM [dbo].[AccountingMonth] am



