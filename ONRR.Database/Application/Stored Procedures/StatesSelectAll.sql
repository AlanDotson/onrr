
CREATE PROCEDURE [Application].[StatesSelectAll]
AS
SET NOCOUNT ON

SELECT s.StateCode
    ,s.[State]
    ,s.PressureBase
FROM [dbo].[States] s



