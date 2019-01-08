CREATE TABLE [dbo].[ReportingGroups] (
    [ReportGroupID]  INT           IDENTITY (1, 1) NOT NULL,
    [ReportGroup]    VARCHAR (150) NOT NULL,
    [GroupSortOrder] INT           NOT NULL,
    CONSTRAINT [PK_ReportingGroups] PRIMARY KEY CLUSTERED ([ReportGroupID] ASC)
);

