CREATE TABLE [dbo].[ReportCatalog] (
    [ReportID]      INT           IDENTITY (1, 1) NOT NULL,
    [ReportName]    VARCHAR (150) NOT NULL,
    [ReportPath]    VARCHAR (500) NOT NULL,
    [ParameterSave] BIT           NOT NULL,
    CONSTRAINT [PK_ReportCatalog] PRIMARY KEY CLUSTERED ([ReportID] ASC)
);

