
CREATE PROCEDURE [Application].[LeasesUpdate] @LeaseID INT
	,@ONRRLeaseID VARCHAR(10)
	,@BLMSerialNumber VARCHAR(50)
	,@QEPLeaseID VARCHAR(50)
	,@QEPLeaseName VARCHAR(150)
	,@LeaseClassificationID INT
	,@BIAClassificationID INT
	,@QEPEffectiveDate DATE
	,@StateCode CHAR(2)
	,@County VARCHAR(150)
	,@RoyaltyRate DECIMAL(11,8)
	,@EffectiveFrom DATE
	,@EffectiveTo DATE
	,@CompanyID INT
AS
SET NOCOUNT ON

UPDATE [dbo].[Leases]
SET ONRRLeaseID = @ONRRLeaseID
	,BLMSerialNumber = @BLMSerialNumber
	,QEPLeaseID = @QEPLeaseID
	,QEPLeaseName = @QEPLeaseName
	,LeaseClassificationID = @LeaseClassificationID
	,BIAClassificationID = @BIAClassificationID
	,QEPEffectiveDate = @QEPEffectiveDate
	,StateCode = @StateCode
	,County = @County
	,RoyaltyRate = @RoyaltyRate
	,EffectiveFrom = @EffectiveFrom
	,EffectiveTo = @EffectiveTo
	,CompanyID = @CompanyID
WHERE LeaseID = @LeaseID



