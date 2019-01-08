
CREATE PROCEDURE [Application].[StatesSelect] @StateCode CHAR(2)
AS
SET NOCOUNT ON

SELECT s.StateCode
    ,s.[State]
    ,s.PressureBase
FROM [dbo].[States] s
WHERE s.StateCode = @StateCode



