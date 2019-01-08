
CREATE PROCEDURE [Application].[ONRRFilesUpdate] @FileID INT
    ,@FileStatusID INT
    ,@GenerationDate DATETIME
    ,@AcceptedDate DATE
AS
SET NOCOUNT ON

UPDATE [dbo].[ONRRFiles]
SET FileStatusID = @FileStatusID
    ,GenerationDate = @GenerationDate
    ,AcceptedDate = @AcceptedDate
WHERE FileID = @FileID



