
CREATE PROCEDURE [Application].[StatesInsert] @State VARCHAR(50)
	,@StateCode CHAR(2)
    ,@PressureBase DECIMAL(10,5)
    ,@NewID INT OUTPUT
AS
SET NOCOUNT ON

INSERT INTO [dbo].[States] (
    [State]
	,StateCode
    ,PressureBase
    )
VALUES (
    @State
	,@StateCode
    ,@PressureBase
    )

SET @NewID = @@Identity



