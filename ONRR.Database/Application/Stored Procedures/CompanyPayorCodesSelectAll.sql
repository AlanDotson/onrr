
CREATE PROCEDURE [Application].[CompanyPayorCodesSelectAll]
AS
SET NOCOUNT ON

SELECT cpc.CompanyID
    ,cpc.QRACompanyCode
    ,cpc.CompanyName
    ,cpc.ONRRPayorCode
FROM [dbo].[CompanyPayorCodes] cpc



