
CREATE PROCEDURE [Application].[LeaseClassificationsInsert] @QLSClassificationID VARCHAR(10)
    ,@Classification VARCHAR(250)
    ,@Active BIT
    ,@NewID INT OUTPUT
AS
SET NOCOUNT ON

INSERT INTO [dbo].[LeaseClassifications] (
    QLSClassificationID
    ,Classification
    ,Active
    )
VALUES (
    @QLSClassificationID
    ,@Classification
    ,@Active
    )

SET @NewID = @@Identity



