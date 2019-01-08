
CREATE PROCEDURE [Application].[PayorCodesInsert] @PayorCode VARCHAR(5)
    ,@Payor VARCHAR(60)
    ,@NewID INT OUTPUT
AS
SET NOCOUNT ON

INSERT INTO [dbo].[PayorCodes] (
    PayorCode
    ,Payor
    )
VALUES (
    @PayorCode
    ,@Payor
    )

SET @NewID = @@Identity



