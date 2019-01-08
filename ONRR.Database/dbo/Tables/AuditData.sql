CREATE TABLE [dbo].[AuditData] (
    [TableName]  VARCHAR (100) NOT NULL,
    [FieldName]  VARCHAR (100) NOT NULL,
    [PrimaryKey] INT           NOT NULL,
    [OldValue]   VARCHAR (500) NULL,
    [NewValue]   VARCHAR (500) NULL,
    [ChangeDate] DATETIME      NOT NULL,
    [ChangeUser] VARCHAR (25)  NOT NULL
);

