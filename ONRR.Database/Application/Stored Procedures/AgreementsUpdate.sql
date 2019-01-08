
CREATE PROCEDURE [Application].[AgreementsUpdate] @AgreementID INT
    ,@ONRRAgreementID VARCHAR(50)
    ,@BLMSerialNumber VARCHAR(50)
    ,@ONRRAgreementDescription VARCHAR(150)
    ,@Formation VARCHAR(150)
    ,@AgreementClassificationID INT
    ,@AgreementTypeID INT
    ,@TotalAcreage DECIMAL(10,4)
    ,@EffectiveFrom DATE
    ,@EffectiveTo DATE
    ,@CompanyID INT
AS
SET NOCOUNT ON

UPDATE [dbo].[Agreements]
SET ONRRAgreementID = @ONRRAgreementID
    ,BLMSerialNumber = @BLMSerialNumber
    ,ONRRAgreementDescription = @ONRRAgreementDescription
    ,Formation = @Formation
    ,AgreementClassificationID = @AgreementClassificationID
    ,AgreementTypeID = @AgreementTypeID
    ,TotalAcreage = @TotalAcreage
    ,EffectiveFrom = @EffectiveFrom
    ,EffectiveTo = @EffectiveTo
    ,CompanyID = @CompanyID
WHERE AgreementID = @AgreementID



