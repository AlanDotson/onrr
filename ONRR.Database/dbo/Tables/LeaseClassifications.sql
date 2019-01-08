CREATE TABLE [dbo].[LeaseClassifications] (
    [LeaseClassificationID] INT           IDENTITY (1, 1) NOT NULL,
    [QLSClassificationID]   VARCHAR (10)  NOT NULL,
    [Classification]        VARCHAR (250) NOT NULL,
    [Active]                BIT           NOT NULL,
    CONSTRAINT [PK_LeaseClassifications] PRIMARY KEY CLUSTERED ([LeaseClassificationID] ASC)
);

