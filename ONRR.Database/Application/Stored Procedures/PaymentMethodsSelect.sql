
CREATE PROCEDURE [Application].[PaymentMethodsSelect] @PaymentMethodID INT
AS
SET NOCOUNT ON

SELECT pm.PaymentMethodID
    ,pm.PaymentMethod
FROM [dbo].[PaymentMethods] pm
WHERE pm.PaymentMethodID = @PaymentMethodID



