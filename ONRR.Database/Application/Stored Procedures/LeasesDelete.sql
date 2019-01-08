
CREATE PROCEDURE [Application].[LeasesDelete] (@LeaseID INT)
AS
SET NOCOUNT ON

DELETE
FROM [dbo].[Leases]
WHERE LeaseID = @LeaseID



