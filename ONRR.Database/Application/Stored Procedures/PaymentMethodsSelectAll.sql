
CREATE PROCEDURE [Application].[PaymentMethodsSelectAll]
AS
SET NOCOUNT ON

SELECT pm.PaymentMethodID
    ,pm.PaymentMethod
FROM [dbo].[PaymentMethods] pm



