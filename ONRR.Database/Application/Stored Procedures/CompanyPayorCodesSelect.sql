
CREATE PROCEDURE [Application].[CompanyPayorCodesSelect] @CompanyID INT
AS
SET NOCOUNT ON

SELECT cpc.CompanyID
    ,cpc.QRACompanyCode
    ,cpc.CompanyName
    ,cpc.ONRRPayorCode
FROM [dbo].[CompanyPayorCodes] cpc
WHERE cpc.CompanyID = @CompanyID



