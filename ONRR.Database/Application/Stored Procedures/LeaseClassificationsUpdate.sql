
CREATE PROCEDURE [Application].[LeaseClassificationsUpdate] @LeaseClassificationID INT
    ,@QLSClassificationID VARCHAR(10)
    ,@Classification VARCHAR(250)
    ,@Active BIT
AS
SET NOCOUNT ON

UPDATE [dbo].[LeaseClassifications]
SET QLSClassificationID = @QLSClassificationID
    ,Classification = @Classification
    ,Active = @Active
WHERE LeaseClassificationID = @LeaseClassificationID



