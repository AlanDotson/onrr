
CREATE PROCEDURE [Application].[LeasesInsert] @ONRRLeaseID VARCHAR(10)
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
	,@NewID INT OUTPUT
AS
SET NOCOUNT ON

INSERT INTO [dbo].[Leases] (
	ONRRLeaseID
	,BLMSerialNumber
	,QEPLeaseID
	,QEPLeaseName
	,LeaseClassificationID
	,BIAClassificationID
	,QEPEffectiveDate
	,StateCode
	,County
	,RoyaltyRate
	,EffectiveFrom
	,EffectiveTo
	,CompanyID
	)
VALUES (
	@ONRRLeaseID
	,@BLMSerialNumber
	,@QEPLeaseID
	,@QEPLeaseName
	,@LeaseClassificationID
	,@BIAClassificationID
	,@QEPEffectiveDate
	,@StateCode
	,@County
	,@RoyaltyRate
	,@EffectiveFrom
	,@EffectiveTo
	,@CompanyID
	)

SET @NewID = @@Identity



