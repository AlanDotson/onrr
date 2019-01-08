
CREATE PROCEDURE [Application].[LeaseAgreementsUpdate] @LeaseAgreementID INT
    ,@LeaseID INT
    ,@AgreementID INT
    ,@EffectiveFrom DATE
    ,@EffectiveTo DATE
    ,@TractFactor DECIMAL(9,8)
    ,@OverrideTractFactor DECIMAL(9,8)
    ,@MarketShare DECIMAL(9,8)
    ,@TractAcreage DECIMAL(10,4)
AS
SET NOCOUNT ON

UPDATE [dbo].[LeaseAgreements]
SET LeaseID = @LeaseID
    ,AgreementID = @AgreementID
    ,EffectiveFrom = @EffectiveFrom
    ,EffectiveTo = @EffectiveTo
    ,TractFactor = @TractFactor
    ,OverrideTractFactor = @OverrideTractFactor
    ,MarketShare = @MarketShare
    ,TractAcreage = @TractAcreage
WHERE LeaseAgreementID = @LeaseAgreementID



