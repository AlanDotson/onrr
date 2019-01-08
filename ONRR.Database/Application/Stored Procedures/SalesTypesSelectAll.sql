
CREATE PROCEDURE [Application].[SalesTypesSelectAll]
AS
SET NOCOUNT ON

SELECT st.SalesTypeID
    ,st.SalesType
FROM [dbo].[SalesTypes] st



