
CREATE PROCEDURE [Application].[ONRRFilesSelectAll]
AS
SET NOCOUNT ON

SELECT onrrf.FileID
    ,onrrf.FileStatusID
    ,onrrf.GenerationDate
    ,onrrf.AcceptedDate
FROM [dbo].[ONRRFiles] onrrf



