
CREATE PROCEDURE [Application].[SalesTypesSelect] @SalesTypeID INT
AS
SET NOCOUNT ON

SELECT st.SalesTypeID
    ,st.SalesType
FROM [dbo].[SalesTypes] st
WHERE st.SalesTypeID = @SalesTypeID



