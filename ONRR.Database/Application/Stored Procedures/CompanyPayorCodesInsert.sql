
CREATE PROCEDURE [Application].[CompanyPayorCodesInsert] @QRACompanyCode VARCHAR(10)
    ,@CompanyName VARCHAR(150)
    ,@ONRRPayorCode VARCHAR(15)
    ,@NewID INT OUTPUT
AS
SET NOCOUNT ON

INSERT INTO [dbo].[CompanyPayorCodes] (
    QRACompanyCode
    ,CompanyName
    ,ONRRPayorCode
    )
VALUES (
    @QRACompanyCode
    ,@CompanyName
    ,@ONRRPayorCode
    )

SET @NewID = @@Identity



