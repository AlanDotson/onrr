CREATE PROCEDURE ETL.AccountingMonthCurrentSelect
AS

BEGIN
	SELECT MAX(AccountingMonth) AS AccountingMonth
	FROM dbo.AccountingMonth
	WHERE CloseDate IS NULL

END
