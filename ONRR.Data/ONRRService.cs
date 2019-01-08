using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Reflection;
using AutoMapper;
using log4net;
using QEP.ONRR.Data.DataContracts;
using QEP.ONRR.Data.Models;

namespace QEP.ONRR.Data
{

    public class OnrrService : IDisposable
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public IEnumerable<LeaseDto> LeasesRead()
        {

            var result = new List<LeaseDto>();

            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    var query = db.LeasesSelectAll();
                    result.AddRange(query.Select(Mapper.Map<LeaseDto>));
                }

                return result;

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public LeaseDto LeaseRead(int ID)
        {
            LeaseDto result;

            using (var db = new ONRRDatabaseEntities())
            {
                var query = db.LeasesSelect(ID);
                result = Mapper.Map<LeaseDto>(query.FirstOrDefault());
            }

            return result;
        }

        public List<LeaseAgreementDto> LeaseAgreementRead(int ID)
        {
            var result = new List<LeaseAgreementDto>();

            using (var db = new ONRRDatabaseEntities())
            {
                var query = db.LeaseAgreementSelect(ID);
                result.AddRange(query.Select(Mapper.Map<LeaseAgreementDto>));

            }

            return result;
        }

        public List<LeaseAgreementDto> AgreementLeaseRead(int ID)
        {
            var result = new List<LeaseAgreementDto>();

            using (var db = new ONRRDatabaseEntities())
            {
                var query = db.AgreementLeaseSelect(ID);
                result.AddRange(query.Select(Mapper.Map<LeaseAgreementDto>));
            }

            return result;
        }

        public List<WellLeaseAgreementDto> WellLeaseAgreementRead(string ID)
        {
            var result = new List<WellLeaseAgreementDto>();

            using (var db = new ONRRDatabaseEntities())
            {
                var query = db.WellLeaseAgreementSelectByWell(ID);
                result.AddRange(query.Select(Mapper.Map<WellLeaseAgreementDto>));
            }

            return result;
        }

        public WellDto WellRead(string ID)
        {

            var result = new WellDto();

            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    var query = db.WellCompletionsSelect(ID);
                    result = Mapper.Map<WellDto>(query.FirstOrDefault());
                }

                return result;

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public void LeaseCreate(LeaseDto dto)
        {
            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    var newId = new ObjectParameter("newId", 0);

                    var id = db.LeasesInsert(dto.ONRRLeaseID, dto.BLMSerialNumber,
                        dto.QEPLeaseID, dto.QEPLeaseName, dto.LeaseClassificationID,
                        dto.BIAClassificationID, dto.QEPEffectiveDate, dto.StateCode, dto.County,
                        dto.RoyaltyRate, dto.EffectiveFrom, dto.EffectiveTo, dto.CompanyID, newId);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
                throw;
            }
        }

        public void LeaseUpdate(LeaseDto dto)
        {
            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    db.LeasesUpdate(dto.LeaseID, dto.ONRRLeaseID, dto.BLMSerialNumber,
                                dto.QEPLeaseID, dto.QEPLeaseName, dto.LeaseClassificationID,
                                dto.BIAClassificationID, dto.QEPEffectiveDate, dto.StateCode, dto.County,
                                dto.RoyaltyRate, dto.EffectiveFrom, dto.EffectiveTo, dto.CompanyID);
                }

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public void LeaseDelete(LeaseDto dto)
        {
            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    db.LeasesDelete(dto.LeaseID);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public void LeaseAgreementCreate(LeaseAgreementDto dto)
        {
            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    var newId = new ObjectParameter("newId", 0);

                    var id = db.LeaseAgreementsInsert(dto.LeaseID, dto.AgreementID, dto.EffectiveFrom,
                        dto.EffectiveFrom, dto.TractFactor, dto.OverrideTractFactor, dto.MarketShare, dto.TractAcreage, newId);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
                throw;
            }
        }

        public void LeaseAgreementUpdate(LeaseAgreementDto dto)
        {
            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    db.LeaseAgreementsUpdate(dto.LeaseAgreementID, dto.LeaseID, dto.AgreementID, dto.EffectiveFrom,
                        dto.EffectiveFrom, dto.TractFactor, dto.OverrideTractFactor, dto.MarketShare, dto.TractAcreage);
                }

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public void LeaseAgreementDelete(LeaseAgreementDto dto)
        {
            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    db.LeaseAgreementsDelete(dto.LeaseAgreementID);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public IEnumerable<AgreementDto> AgreementsRead()
        {

            var result = new List<AgreementDto>();

            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    var query = db.AgreementsSelectAll();
                    result.AddRange(query.Select(Mapper.Map<AgreementDto>));
                }

                return result;

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public AgreementDto AgreementRead(int ID)
        {

            var result = new AgreementDto();

            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    var query = db.AgreementsSelect(ID);
                    result = Mapper.Map<AgreementDto>(query.FirstOrDefault());
                }

                return result;

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public void AgreementCreate(AgreementDto dto)
        {
            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    var newId = new ObjectParameter("newId", 0);

                    var id = db.AgreementsInsert(dto.ONRRAgreementID, dto.BLMSerialNumber, dto.ONRRAgreementDescription, 
                        dto.Formation, dto.AgreementClassificationID, dto.AgreementTypeID, dto.TotalAcreage, 
                        dto.EffectiveFrom, dto.EffectiveTo, dto.CompanyID, newId);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
                throw;
            }
        }

        public void AgreementUpdate(AgreementDto dto)
        {
            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    db.AgreementsUpdate(dto.AgreementID, dto.ONRRAgreementID, dto.BLMSerialNumber, dto.ONRRAgreementDescription,
                        dto.Formation, dto.AgreementClassificationID, dto.AgreementTypeID, dto.TotalAcreage,
                        dto.EffectiveFrom, dto.EffectiveTo, dto.CompanyID);
                }

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public IEnumerable<AgreementTypesDto> AgreementTypesRead()
        {
            try
            {
                var result = new List<AgreementTypesDto>();

                using (var db = new ONRRDatabaseEntities())
                {
                    var query = db.AgreementTypesSelectAll();
                    result.AddRange(query.Select(Mapper.Map<AgreementTypesDto>));
                }

                return result;

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public void AgreementTypeCreate(AgreementTypesDto dto)
        {
            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    var newId = new ObjectParameter("newId", 0);

                    var id = db.AgreementTypesInsert(dto.AgreementType, newId);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
                throw;
            }
        }

        public void AgreementTypeUpdate(AgreementTypesDto dto)
        {
            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    db.AgreementTypesUpdate(dto.AgreementTypeID, dto.AgreementType);
                }

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        //public IEnumerable<AgreementClassificationsSelectAll_Result> AgreementClassificationsRead()
        //{
        //    try
        //    {
        //        List<AgreementClassificationsSelectAll_Result> result;

        //        using (var db = new ONRRDatabaseEntities())
        //        {
        //            result = db.AgreementClassificationsSelectAll().ToList();
        //        }

        //        return result;

        //    }
        //    catch (Exception ex)
        //    {
        //        log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
        //        throw;
        //    }
        //}

        //public IEnumerable<BIAClassificationsSelectAll_Result> BIAClassificationsRead()
        //{
        //    try
        //    {
        //        List<BIAClassificationsSelectAll_Result> result;

        //        using (var db = new ONRRDatabaseEntities())
        //        {
        //            result = db.BIAClassificationsSelectAll().ToList();
        //        }

        //        return result;

        //    }
        //    catch (Exception ex)
        //    {
        //        log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
        //        throw;
        //    }
        //}

        public IEnumerable<FileDto> FilesRead()
        {

            var result = new List<FileDto>();

            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    var query = db.ONRRFilesSelectAll();
                    result.AddRange(query.Select(Mapper.Map<FileDto>));
                }

                return result;

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public IEnumerable<WellDto> WellsRead()
        {

            var result = new List<WellDto>();

            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    var query = db.WellCompletionsSelectAll();
                    result.AddRange(query.Select(Mapper.Map<WellDto>));
                }

                return result;

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public IEnumerable<AdjustmentReasonCodesDto> AdjustmentReasonRead()
        {

            var result = new List<AdjustmentReasonCodesDto>();

            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    var query = db.AdjustmentReasonCodesSelectAll();
                    result.AddRange(query.Select(Mapper.Map<AdjustmentReasonCodesDto>));
                }

                return result;

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public void AdjustmentReasonCreate(AdjustmentReasonCodesDto dto)
        {
            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    var newId = new ObjectParameter("newId", 0);
                    var id = db.AdjustmentReasonCodesInsert(dto.AdjustmentReasonCode, dto.AdjustmentReason, newId);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
                throw;
            }
        }

        public void AdjustmentReasonUpdate(AdjustmentReasonCodesDto dto)
        {
            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    db.AdjustmentReasonCodesUpdate(dto.AdjustmentReasonCodeID, dto.AdjustmentReasonCode, dto.AdjustmentReason);
                }

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public IEnumerable<AgreementClassificationsDto> AgreementClassificationsRead()
        {

            var result = new List<AgreementClassificationsDto>();

            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    var query = db.AgreementClassificationsSelectAll();
                    result.AddRange(query.Select(Mapper.Map<AgreementClassificationsDto>));
                }

                return result;

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public void AgreementClassificationCreate(AgreementClassificationsDto dto)
        {
            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    var newId = new ObjectParameter("newId", 0);
                    var id = db.AgreementClassificationsInsert(dto.AgreementClassification, newId);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
                throw;
            }
        }

        public void AgreementClassificationUpdate(AgreementClassificationsDto dto)
        {
            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    db.AgreementClassificationsUpdate(dto.AgreementClassificationID, dto.AgreementClassification);
                }

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public IEnumerable<BIAClassificationsDto> BIAClassificationsRead()
        {

            var result = new List<BIAClassificationsDto>();

            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    var query = db.BIAClassificationsSelectAll();
                    result.AddRange(query.Select(Mapper.Map<BIAClassificationsDto>));
                }

                return result;

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public void BIAClassificationCreate(BIAClassificationsDto dto)
        {
            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    var newId = new ObjectParameter("newId", 0);
                    var id = db.BIAClassificationsInsert(dto.BIAClassification, newId);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
                throw;
            }
        }

        public void BIAClassificationUpdate(BIAClassificationsDto dto)
        {
            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    db.BIAClassificationsUpdate(dto.BIAClassificationID, dto.BIAClassification);
                }

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public IEnumerable<CompanyPayorCodesDto> CompanyPayorCodesRead()
        {

            var result = new List<CompanyPayorCodesDto>();

            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    var query = db.CompanyPayorCodesSelectAll();
                    result.AddRange(query.Select(Mapper.Map<CompanyPayorCodesDto>));
                }

                return result;

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public void CompanyPayorCreate(CompanyPayorCodesDto dto)
        {
            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    var newId = new ObjectParameter("newId", 0);
                    var id = db.CompanyPayorCodesInsert(dto.QRACompanyCode, dto.CompanyName, dto.ONRRPayorCode, newId);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
                throw;
            }
        }

        public void CompanyPayorUpdate(CompanyPayorCodesDto dto)
        {
            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    db.CompanyPayorCodesUpdate(dto.CompanyID, dto.QRACompanyCode, dto.CompanyName, dto.ONRRPayorCode);
                }

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public IEnumerable<LeaseClassificationsDto> LeaseClassificationsRead()
        {

            var result = new List<LeaseClassificationsDto>();

            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    var query = db.LeaseClassificationsSelectAll();
                    result.AddRange(query.Select(Mapper.Map<LeaseClassificationsDto>));
                }

                return result;

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public void LeaseClassificationCreate(LeaseClassificationsDto dto)
        {
            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    var newId = new ObjectParameter("newId", 0);
                    var id = db.LeaseClassificationsInsert(dto.QLSClassificationID, dto.Classification, dto.Active, newId);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
                throw;
            }
        }

        public void LeaseClassificationUpdate(LeaseClassificationsDto dto)
        {
            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    db.LeaseClassificationsUpdate(dto.LeaseClassificationID, dto.QLSClassificationID, dto.Classification, dto.Active);
                }

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public IEnumerable<ONRRTransactionCodesDto> ONRRTransactionCodesRead()
        {

            var result = new List<ONRRTransactionCodesDto>();

            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    var query = db.ONRRTransactionCodesSelectAll();
                    result.AddRange(query.Select(Mapper.Map<ONRRTransactionCodesDto>));
                }

                return result;

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public void ONRRTransactionCodeCreate(ONRRTransactionCodesDto dto)
        {
            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    var newId = new ObjectParameter("newId", 0);
                    var id = db.ONRRTransactionCodesInsert(dto.ONRRTransactionCode, dto.ProductCode, dto.DispositionCode, newId);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
                throw;
            }
        }

        public void ONRRTransactionCodeUpdate(ONRRTransactionCodesDto dto)
        {
            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    db.ONRRTransactionCodesUpdate(dto.TransactionCodeID, dto.ONRRTransactionCode, dto.ProductCode, dto.DispositionCode);
                }

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public IEnumerable<PaymentMethodsDto> PaymentMethodsRead()
        {

            var result = new List<PaymentMethodsDto>();

            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    var query = db.PaymentMethodsSelectAll();
                    result.AddRange(query.Select(Mapper.Map<PaymentMethodsDto>));
                }

                return result;

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public void PaymentMethodCreate(PaymentMethodsDto dto)
        {
            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    var newId = new ObjectParameter("newId", 0);
                    var id = db.PaymentMethodsInsert(dto.PaymentMethod, newId);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
                throw;
            }
        }

        public void PaymentMethodUpdate(PaymentMethodsDto dto)
        {
            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    db.PaymentMethodsUpdate(dto.PaymentMethodID, dto.PaymentMethod);
                }

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public IEnumerable<PayorCodesDto> PayorCodesRead()
        {

            var result = new List<PayorCodesDto>();

            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    var query = db.PayorCodesSelectAll();
                    result.AddRange(query.Select(Mapper.Map<PayorCodesDto>));
                }

                return result;

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public void PayorCodeCreate(PayorCodesDto dto)
        {
            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    var newId = new ObjectParameter("newId", 0);
                    var id = db.PayorCodesInsert(dto.PayorCode, dto.Payor, newId);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
                throw;
            }
        }

        public void PayorCodeUpdate(PayorCodesDto dto)
        {
            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    db.PayorCodesUpdate(dto.PayorCodeID, dto.PayorCode, dto.Payor);
                }

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public IEnumerable<ProductCodeCrossReferenceDto> ProductCodeCrossReferenceRead()
        {

            var result = new List<ProductCodeCrossReferenceDto>();

            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    var query = db.ProductCodeCrossReferenceSelectAll();
                    result.AddRange(query.Select(Mapper.Map<ProductCodeCrossReferenceDto>));
                }

                return result;

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public void ProductCodeCrossReferenceCreate(ProductCodeCrossReferenceDto dto)
        {
            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    var newId = new ObjectParameter("newId", 0);
                    var id = db.ProductCodeCrossReferenceInsert(dto.ONRRProductCode, dto.QRAMajorProductCode, newId);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
                throw;
            }
        }

        public void ProductCodeCrossReferenceUpdate(ProductCodeCrossReferenceDto dto)
        {
            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    db.ProductCodeCrossReferenceUpdate(dto.ProductCodeID, dto.ONRRProductCode, dto.QRAMajorProductCode);
                }

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public IEnumerable<SalesTypeDto> SalesTypesRead()
        {

            var result = new List<SalesTypeDto>();

            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    var query = db.SalesTypesSelectAll();
                    result.AddRange(query.Select(Mapper.Map<SalesTypeDto>));
                }

                return result;

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public void SalesTypeCreate(SalesTypeDto dto)
        {
            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    var newId = new ObjectParameter("newId", 0);
                    var id = db.SalesTypesInsert(dto.SalesType, newId);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
                throw;
            }
        }

        public void SalesTypeUpdate(SalesTypeDto dto)
        {
            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    db.SalesTypesUpdate(dto.SalesTypeID, dto.SalesType);
                }

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public IEnumerable<StatesDto> StatesRead()
        {

            var result = new List<StatesDto>();

            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    var query = db.StatesSelectAll();
                    result.AddRange(query.Select(Mapper.Map<StatesDto>));
                }

                return result;

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public void StateCreate(StatesDto dto)
        {
            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    var newId = new ObjectParameter("newId", 0);
                    var id = db.StatesInsert(dto.State, dto.StateCode, dto.PressureBase, newId);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
                throw;
            }
        }

        public void StateUpdate(StatesDto dto)
        {
            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    db.StatesUpdate(dto.StateCode, dto.State, dto.PressureBase);
                }

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public IEnumerable<CodeTableDto> CodeTablesRead()
        {

            var result = new List<CodeTableDto>();

            try
            {
                var dto = new CodeTableDto { TableID = 1, TableName = "Adjustment Reason Codes" };
                result.Add(dto);

                dto = new CodeTableDto { TableID = 2, TableName = "Agreement Classifications" };
                result.Add(dto);

                dto = new CodeTableDto { TableID = 3, TableName = "Agreement Types" };
                result.Add(dto);

                dto = new CodeTableDto { TableID = 4, TableName = "BIA Classifications" };
                result.Add(dto);

                dto = new CodeTableDto { TableID = 5, TableName = "Company Payor Codes" };
                result.Add(dto);

                dto = new CodeTableDto { TableID = 6, TableName = "Lease Classifications" };
                result.Add(dto);

                dto = new CodeTableDto { TableID = 7, TableName = "ONRR Transaction Codes" };
                result.Add(dto);

                dto = new CodeTableDto { TableID = 8, TableName = "Payment Methods" };
                result.Add(dto);

                dto = new CodeTableDto { TableID = 9, TableName = "Payor Codes" };
                result.Add(dto);

                dto = new CodeTableDto { TableID = 10, TableName = "Product Code Cross Reference" };
                result.Add(dto);

                dto = new CodeTableDto { TableID = 11, TableName = "Sales Types" };
                result.Add(dto);

                dto = new CodeTableDto { TableID = 12, TableName = "States" };
                result.Add(dto);

                return result;

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public CodeTableDto CodeTableRead(int ID)
        {

            try
            {
                var result = CodeTablesRead();
                return result.First(x => x.TableID == ID);
            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public IEnumerable<AggregateDto> AggregatesRead()
        {

            var result = new List<AggregateDto>();

            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    var query = db.ONRRAggregateSelectAll();
                    result.AddRange(query.Select(Mapper.Map<AggregateDto>));
                }

                return result;

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public AggregateDto AggregateRead(int ID)
        {

            var result = new AggregateDto();

            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    var query = db.ONRRAggregateSelect(ID);
                    result = Mapper.Map<AggregateDto>(query.FirstOrDefault());

                }

                return result;

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public IEnumerable<JtranDto> JTRANsRead()
        {

            var result = new List<JtranDto>();

            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    var query = db.JTRN_SL_DETAILSelectAll();
                    result.AddRange(query.Select(Mapper.Map<JtranDto>));
                }

                return result;

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public IEnumerable<DetailDto> DetailsRead(string stateCode)
        {

            var result = new List<DetailDto>();

            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    var query = db.ONRRDetailSelectFiltered(stateCode);
                    result.AddRange(query.Select(Mapper.Map<DetailDto>));
                }

                return result;

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public IEnumerable<DetailDto> DetailsReadForAggregate(int aggregateID)
        {

            var result = new List<DetailDto>();

            try
            {
                using (var db = new ONRRDatabaseEntities())
                {
                    var query = db.ONRRDetailSelectByAggregate(aggregateID);
                    result.AddRange(query.Select(Mapper.Map<DetailDto>));
                }

                return result;

            }
            catch (Exception ex)
            {
                log.Error(ex.Message + Environment.NewLine + ex.StackTrace);
                throw;
            }
        }

        public void Dispose()
        {
        }
    }
}
