CREATE TABLE [dbo].[States] (
    [StateCode]    CHAR (2)        NOT NULL,
    [State]        VARCHAR (50)    NOT NULL,
    [PressureBase] DECIMAL (10, 5) NOT NULL,
    CONSTRAINT [PK_States] PRIMARY KEY CLUSTERED ([StateCode] ASC)
);

