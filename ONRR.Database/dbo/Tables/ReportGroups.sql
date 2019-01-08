CREATE TABLE [dbo].[ReportGroups] (
    [ReportID]      INT NOT NULL,
    [ReportGroupID] INT NOT NULL,
    [SortOrder]     INT NOT NULL,
    CONSTRAINT [PK_ReportGroups] PRIMARY KEY CLUSTERED ([ReportID] ASC, [ReportGroupID] ASC),
    CONSTRAINT [FK_ReportGroups_ReportCatalog] FOREIGN KEY ([ReportID]) REFERENCES [dbo].[ReportCatalog] ([ReportID]),
    CONSTRAINT [FK_ReportGroups_ReportingGroups] FOREIGN KEY ([ReportID]) REFERENCES [dbo].[ReportingGroups] ([ReportGroupID])
);

