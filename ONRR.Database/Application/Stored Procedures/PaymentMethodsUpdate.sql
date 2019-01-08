
CREATE PROCEDURE [Application].[PaymentMethodsUpdate] @PaymentMethodID INT
    ,@PaymentMethod VARCHAR(60)
AS
SET NOCOUNT ON

UPDATE [dbo].[PaymentMethods]
SET PaymentMethod = @PaymentMethod
WHERE PaymentMethodID = @PaymentMethodID



