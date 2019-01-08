CREATE TABLE [dbo].[ONRRFiles] (
    [FileID]         INT      IDENTITY (1, 1) NOT NULL,
    [FileStatusID]   INT      NOT NULL,
    [GenerationDate] DATETIME NOT NULL,
    [AcceptedDate]   DATE     NULL,
    CONSTRAINT [PK_ONRRFiles] PRIMARY KEY CLUSTERED ([FileID] ASC)
);

