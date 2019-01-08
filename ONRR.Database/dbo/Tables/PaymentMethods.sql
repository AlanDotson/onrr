CREATE TABLE [dbo].[PaymentMethods] (
    [PaymentMethodID] INT          IDENTITY (1, 1) NOT NULL,
    [PaymentMethod]   VARCHAR (60) NOT NULL,
    CONSTRAINT [PK_PaymentMethods] PRIMARY KEY CLUSTERED ([PaymentMethodID] ASC)
);

