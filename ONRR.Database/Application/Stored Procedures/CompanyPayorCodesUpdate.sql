
CREATE PROCEDURE [Application].[CompanyPayorCodesUpdate] @CompanyID INT
    ,@QRACompanyCode VARCHAR(10)
    ,@CompanyName VARCHAR(150)
    ,@ONRRPayorCode VARCHAR(15)
AS
SET NOCOUNT ON

UPDATE [dbo].[CompanyPayorCodes]
SET QRACompanyCode = @QRACompanyCode
    ,CompanyName = @CompanyName
    ,ONRRPayorCode = @ONRRPayorCode
WHERE CompanyID = @CompanyID



