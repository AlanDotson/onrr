CREATE TABLE [dbo].[CompanyPayorCodes] (
    [CompanyID]      INT           IDENTITY (1, 1) NOT NULL,
    [QRACompanyCode] VARCHAR (10)  NOT NULL,
    [CompanyName]    VARCHAR (150) NOT NULL,
    [ONRRPayorCode]  VARCHAR (15)  NOT NULL,
    CONSTRAINT [PK_CompanyPayorCodes] PRIMARY KEY CLUSTERED ([CompanyID] ASC)
);

