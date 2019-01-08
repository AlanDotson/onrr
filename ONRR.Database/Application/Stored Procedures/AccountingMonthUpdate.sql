
CREATE PROCEDURE [Application].[AccountingMonthUpdate] @AccountingMonth DATE
    ,@OpenDate DATETIME
    ,@CloseDate DATETIME
AS
SET NOCOUNT ON

UPDATE [dbo].[AccountingMonth]
SET OpenDate = @OpenDate
    ,CloseDate = @CloseDate
WHERE AccountingMonth = @AccountingMonth



