
CREATE PROCEDURE [Application].[LeaseAgreementsInsert] @LeaseID INT
    ,@AgreementID INT
    ,@EffectiveFrom DATE
    ,@EffectiveTo DATE
    ,@TractFactor DECIMAL(9,8)
    ,@OverrideTractFactor DECIMAL(9,8)
    ,@MarketShare DECIMAL(9,8)
    ,@TractAcreage DECIMAL(10,4)
    ,@NewID INT OUTPUT
AS
SET NOCOUNT ON

INSERT INTO [dbo].[LeaseAgreements] (
    LeaseID
    ,AgreementID
    ,EffectiveFrom
    ,EffectiveTo
    ,TractFactor
    ,OverrideTractFactor
    ,MarketShare
    ,TractAcreage
    )
VALUES (
    @LeaseID
    ,@AgreementID
    ,@EffectiveFrom
    ,@EffectiveTo
    ,@TractFactor
    ,@OverrideTractFactor
    ,@MarketShare
    ,@TractAcreage
    )

SET @NewID = @@Identity



