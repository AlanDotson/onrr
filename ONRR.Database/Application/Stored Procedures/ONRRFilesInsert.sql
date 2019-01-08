
CREATE PROCEDURE [Application].[ONRRFilesInsert] @FileStatusID INT
    ,@GenerationDate DATETIME
    ,@AcceptedDate DATE
    ,@NewID INT OUTPUT
AS
SET NOCOUNT ON

INSERT INTO [dbo].[ONRRFiles] (
    FileStatusID
    ,GenerationDate
    ,AcceptedDate
    )
VALUES (
    @FileStatusID
    ,@GenerationDate
    ,@AcceptedDate
    )

SET @NewID = @@Identity



