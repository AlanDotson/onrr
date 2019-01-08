
CREATE PROCEDURE [Application].[StatesUpdate] @StateCode CHAR(2)
    ,@State VARCHAR(50)
    ,@PressureBase DECIMAL(10,5)
AS
SET NOCOUNT ON

UPDATE [dbo].[States]
SET [State] = @State
    ,PressureBase = @PressureBase
WHERE StateCode = @StateCode



