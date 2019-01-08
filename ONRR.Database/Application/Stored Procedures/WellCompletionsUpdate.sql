
CREATE PROCEDURE [Application].[WellCompletionsUpdate] @WellCompletionID VARCHAR(10)
    ,@PropertyNumber VARCHAR(10)
    ,@WellAcreage DECIMAL(10,4)
    ,@WellCompletionName VARCHAR(60)
    ,@StateCode CHAR(2)
    ,@API VARCHAR(14)
    ,@Company VARCHAR(4)
    ,@PropertyName VARCHAR(250)
    ,@GrossMarketedInterest DECIMAL(9,8)
AS
SET NOCOUNT ON

UPDATE [dbo].[WellCompletions]
SET PropertyNumber = @PropertyNumber
    ,WellAcreage = @WellAcreage
    ,WellCompletionName = @WellCompletionName
    ,StateCode = @StateCode
    ,API = @API
    ,Company = @Company
    ,PropertyName = @PropertyName
    ,GrossMarketedInterest = @GrossMarketedInterest
WHERE WellCompletionID = @WellCompletionID



