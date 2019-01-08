
CREATE PROCEDURE [Application].[AccountingMonthSelect] @AccountingMonth DATE
AS
SET NOCOUNT ON

SELECT am.AccountingMonth
    ,am.OpenDate
    ,am.CloseDate
FROM [dbo].[AccountingMonth] am
WHERE am.AccountingMonth = @AccountingMonth




