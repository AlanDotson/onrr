
CREATE PROCEDURE [Application].[SalesTypesUpdate] @SalesTypeID INT
    ,@SalesType VARCHAR(50)
AS
SET NOCOUNT ON

UPDATE [dbo].[SalesTypes]
SET SalesType = @SalesType
WHERE SalesTypeID = @SalesTypeID



