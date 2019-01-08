CREATE PROCEDURE [Application].[AccountingMonthInsert] @OpenDate DATETIME
    ,@CloseDate DATETIME
    ,@NewID INT OUTPUT
AS
SET NOCOUNT ON

INSERT INTO [dbo].[AccountingMonth] (
    OpenDate
    ,CloseDate
    )
VALUES (
    @OpenDate
    ,@CloseDate
    )

SET @NewID = @@Identity



