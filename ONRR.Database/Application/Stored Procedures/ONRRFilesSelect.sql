
CREATE PROCEDURE [Application].[ONRRFilesSelect] @FileID INT
AS
SET NOCOUNT ON

SELECT onrrf.FileID
    ,onrrf.FileStatusID
    ,onrrf.GenerationDate
    ,onrrf.AcceptedDate
FROM [dbo].[ONRRFiles] onrrf
WHERE onrrf.FileID = @FileID



