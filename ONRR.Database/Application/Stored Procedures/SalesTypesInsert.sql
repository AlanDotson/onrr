
CREATE PROCEDURE [Application].[SalesTypesInsert] @SalesType VARCHAR(50)
    ,@NewID INT OUTPUT
AS
SET NOCOUNT ON

INSERT INTO [dbo].[SalesTypes] (SalesType)
VALUES (@SalesType)

SET @NewID = @@Identity



