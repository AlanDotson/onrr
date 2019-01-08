
CREATE PROCEDURE [Application].[AgreementsInsert] @ONRRAgreementID VARCHAR(50)
    ,@BLMSerialNumber VARCHAR(50)
    ,@ONRRAgreementDescription VARCHAR(150)
    ,@Formation VARCHAR(150)
    ,@AgreementClassificationID INT
    ,@AgreementTypeID INT
    ,@TotalAcreage DECIMAL(10,4)
    ,@EffectiveFrom DATE
    ,@EffectiveTo DATE
    ,@CompanyID INT
    ,@NewID INT OUTPUT
AS
SET NOCOUNT ON

INSERT INTO [dbo].[Agreements] (
    ONRRAgreementID
    ,BLMSerialNumber
    ,ONRRAgreementDescription
    ,Formation
    ,AgreementClassificationID
    ,AgreementTypeID
    ,TotalAcreage
    ,EffectiveFrom
    ,EffectiveTo
    ,CompanyID
    )
VALUES (
    @ONRRAgreementID
    ,@BLMSerialNumber
    ,@ONRRAgreementDescription
    ,@Formation
    ,@AgreementClassificationID
    ,@AgreementTypeID
    ,@TotalAcreage
    ,@EffectiveFrom
    ,@EffectiveTo
    ,@CompanyID
    )

SET @NewID = @@Identity



