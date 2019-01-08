CREATE PROCEDURE [Application].[WellCompletionsInsert] 
	 @PropertyNumber VARCHAR(10)
    ,@WellAcreage DECIMAL(10,4)
    ,@WellCompletionName VARCHAR(60)
    ,@StateCode CHAR(2)
    ,@API VARCHAR(14)
    ,@Company VARCHAR(4)
    ,@PropertyName VARCHAR(250)
    ,@GrossMarketedInterest DECIMAL(9,8)
    ,@NewID INT OUTPUT
AS
SET NOCOUNT ON

INSERT INTO [dbo].[WellCompletions] (
    PropertyNumber
    ,WellAcreage
    ,WellCompletionName
    ,StateCode
    ,API
    ,Company
    ,PropertyName
    ,GrossMarketedInterest
    )
VALUES (
    @PropertyNumber
    ,@WellAcreage
    ,@WellCompletionName
    ,@StateCode
    ,@API
    ,@Company
    ,@PropertyName
    ,@GrossMarketedInterest
    )

SET @NewID = @@Identity



