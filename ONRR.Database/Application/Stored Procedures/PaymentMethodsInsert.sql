
CREATE PROCEDURE [Application].[PaymentMethodsInsert] @PaymentMethod VARCHAR(60)
    ,@NewID INT OUTPUT
AS
SET NOCOUNT ON

INSERT INTO [dbo].[PaymentMethods] (PaymentMethod)
VALUES (@PaymentMethod)

SET @NewID = @@Identity



