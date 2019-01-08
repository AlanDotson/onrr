using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using log4net;
using MvcSiteMapProvider.Web.Mvc.Filters;
using QEP.ONRR.Data;
using QEP.ONRR.Data.DataContracts;
using QEP.ONRR.Web.Models;

namespace QEP.ONRR.Web.Controllers
{
    public class MasterDataController : Controller
    {
        private readonly OnrrService _dataService = new OnrrService();
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        // Leases 
        [AuthorizeAD(Groups = "QEP App Devs")]
        public ActionResult Leases_Read([DataSourceRequest] DataSourceRequest request)
        {
            List<LeaseDto> result;
            try
            {
                result = _dataService.LeasesRead().ToList();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Leases_Read",
                    "An error occurred reading the lease records:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
            }
            return Json(result.ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult LeaseCreate([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")] IEnumerable<LeaseDto> rows)
        {
            try
            {
                if (rows != null && ModelState.IsValid)
                {
                    foreach (var dto in rows)
                    {
                        _dataService.LeaseCreate(dto);
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Create",
                    "An error occurred creating the lease record:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult());
            }
            return Json(rows.ToDataSourceResult(request, ModelState));
        }

        [AuthorizeAD(Groups = "QEP App Devs")]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult LeaseUpdate([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")] IEnumerable<LeaseDto> rows)
        {
            try
            {
                if (rows != null && ModelState.IsValid)
                {
                    foreach (var dto in rows)
                    {
                        _dataService.LeaseUpdate(dto);
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("EditingUpdate",
                    "An error occurred updating the lease record:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult());
            }

            return Json(rows.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult LeaseDelete([DataSourceRequest] DataSourceRequest request, LeaseDto dto)
        {
            try
            {
                if (dto != null)
                {
                    _dataService.LeaseDelete(dto);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("EditingDelete",
                    "An error occurred deleting the lease record:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult());
            }

            return Json(new[] {dto}.ToDataSourceResult(request, ModelState));
        }

        public ActionResult Leases()
        {
            var vm = new LeasesViewModel {Title = "Leases"};
            return View(vm);
        }

        public ActionResult LeaseDetail(int? ID)
        {
            var vm = new LeaseDetailViewModel {Title = "Lease Detail"};

            try
            {
                if (ID != null)
                {
                    var result = _dataService.LeaseRead(ID.Value);

                    if (result != null)
                    {
                        var leaseAgreements = _dataService.LeaseAgreementRead(ID.Value).ToList();
                        result.LeaseAgreements = leaseAgreements;

                        var agreements = _dataService.AgreementsRead().ToList();
                        result.Agreements = agreements;
                    }
                    vm.Lease = result;
                }
                else
                {
                    // TODO: Need to show this error, isn't working for HTTP get for some reason
                    ModelState.AddModelError("LeaseDetail", "The lease id cannot be empty");
                    return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                // TODO: Need to show this error, isn't working for HTTP get for some reason
                ModelState.AddModelError("LeaseDetail",
                    "An error occurred reading the lease detail data:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
            }

            return View(vm);
        }

        public ActionResult LeaseAgreementRead(int? ID, [DataSourceRequest] DataSourceRequest request)
        {
            var result = new List<LeaseAgreementDto>();
            if (ID != null)
            {
                result = _dataService.LeaseAgreementRead(ID.Value);
            }
            return Json(result.ToDataSourceResult(request));
        }

        // Lease Agreements
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult LeaseAgreementCreate([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")] IEnumerable<LeaseAgreementDto> rows)
        {
            try
            {
                if (rows != null && ModelState.IsValid)
                {
                    foreach (var dto in rows)
                    {
                        _dataService.LeaseAgreementCreate(dto);
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("LeaseAgreementCreate",
                    "An error occurred creating the lease agreement record:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult());
            }
            return Json(rows.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult LeaseAgreementUpdate([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")] IEnumerable<LeaseAgreementDto> rows)
        {
            try
            {
                if (rows != null && ModelState.IsValid)
                {
                    foreach (var dto in rows)
                    {
                        _dataService.LeaseAgreementUpdate(dto);
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("LeaseAgreementUpdate",
                    "An error occurred updating the lease agreement record:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult());
            }

            return Json(rows.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult LeaseAgreementDelete([DataSourceRequest] DataSourceRequest request, LeaseAgreementDto dto)
        {
            try
            {
                if (dto != null)
                {
                    _dataService.LeaseAgreementDelete(dto);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("LeaseAgreementDelete",
                    "An error occurred deleting the lease agreement record:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult());
            }

            return Json(new[] {dto}.ToDataSourceResult(request, ModelState));
        }


        // Agreements
        public ActionResult Agreements()
        {
            var vm = new AgreementsViewModel {Title = "Agreements"};
            return View(vm);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AgreementCreate([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")] IEnumerable<AgreementDto> rows)
        {
            try
            {
                if (rows != null && ModelState.IsValid)
                {
                    foreach (var dto in rows)
                    {
                        _dataService.AgreementCreate(dto);
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("AgreementCreate",
                    "An error occurred creating the agreement record:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult());
            }
            return Json(rows.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AgreementUpdate([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")] IEnumerable<AgreementDto> rows)
        {
            try
            {
                if (rows != null && ModelState.IsValid)
                {
                    foreach (var dto in rows)
                    {
                        _dataService.AgreementUpdate(dto);
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("AgreementUpdate",
                    "An error occurred updating the agreement record:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult());
            }

            return Json(rows.ToDataSourceResult(request, ModelState));
        }

        public ActionResult AgreementDetail(int? ID)
        {
            var vm = new AgreementDetailViewModel {Title = "Agreement Detail"};

            try
            {
                if (ID != null)
                {
                    var result = _dataService.AgreementRead(ID.Value);

                    if (result != null)
                    {
                        var leaseAgreements = _dataService.AgreementLeaseRead(ID.Value).ToList();
                        result.LeaseAgreements = leaseAgreements;
                    }
                    vm.Agreement = result;
                }
                else
                {
                    ModelState.AddModelError("AgreementDetail", "The lease id cannot be empty");
                    return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("AgreementDetail",
                    "An error occurred reading the lease detail data:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
            }

            return View(vm);
        }

        // Wells
        public ActionResult Wells()
        {
            var vm = new WellsViewModel {Title = "Wells"};
            return View(vm);
        }

        public ActionResult Wells_Read([DataSourceRequest] DataSourceRequest request)
        {
            List<WellDto> result;
            try
            {
                result = _dataService.WellsRead().ToList();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Wells_Read",
                    "An error occurred reading the well records:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
            }
            return Json(result.ToDataSourceResult(request));
        }

        public ActionResult WellDetail(string ID)
        {
            var vm = new WellDetailViewModel {Title = "Well Detail"};

            try
            {
                if (ID != null)
                {
                    var result = _dataService.WellRead(ID);

                    if (result != null)
                    {
                        var wellLeaseAgreements = _dataService.WellLeaseAgreementRead(ID).ToList();
                        result.WellLeaseAgreements = wellLeaseAgreements;
                    }
                    vm.Well = result;
                }
                else
                {
                    ModelState.AddModelError("AgreementDetail", "The lease id cannot be empty");
                    return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("AgreementDetail",
                    "An error occurred reading the lease detail data:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
            }

            return View(vm);
        }


        // Code Tables
        public ActionResult CodeTables()
        {
            var vm = new CodeTablesViewModel {Title = "Code Tables"};
            return View(vm);
        }

        public ActionResult CodeTableDetail(int? ID)
        {
            var vm = new CodeTableDetailViewModel {Title = "Code Table Detail"};

            if (ID != null)
            {
                var result = _dataService.CodeTableRead(ID.Value);
                vm.CurrentTableID = ID.Value;
                vm.CurrentTableName = result.TableName;
            }
            else
            {
                // TODO: Need to show this error, isn't working for HTTP get for some reason
                ModelState.AddModelError("CodeTableDetail", "The name of the table cannot be empty");
                return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
            }

            return View(vm);
        }

        public ActionResult CodeTable_Read([DataSourceRequest] DataSourceRequest request)
        {
            List<CodeTableDto> result;
            try
            {
                result = _dataService.CodeTablesRead().ToList();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("CodeTable_Read",
                    "An error occurred reading the code table records:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
            }
            return Json(result.ToDataSourceResult(request));
        }

        public ActionResult AdjustmentReasons_Read([DataSourceRequest] DataSourceRequest request)
        {
            List<AdjustmentReasonCodesDto> result;
            try
            {
                result = _dataService.AdjustmentReasonRead().ToList();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("AdjustmentReasons_Read",
                    "An error occurred reading the adjustment reason records:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
            }
            return Json(result.ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AdjustmentReasons_Create([DataSourceRequest] DataSourceRequest request,
            AdjustmentReasonCodesDto dto)
        {
            try
            {
                if (dto != null && ModelState.IsValid)
                {
                    _dataService.AdjustmentReasonCreate(dto);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("AdjustmentReasons_Create",
                    "An error occurred creating the adjustment reason record:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult());
            }
            return Json(new[] {dto}.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AdjustmentReasons_Update([DataSourceRequest] DataSourceRequest request,
            AdjustmentReasonCodesDto dto)
        {
            try
            {
                if (dto != null && ModelState.IsValid)
                {
                    _dataService.AdjustmentReasonUpdate(dto);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("AdjustmentReasons_Update",
                    "An error occurred updating the adjustment reason record:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult());
            }

            return Json(new[] {dto}.ToDataSourceResult(request, ModelState));
        }

        public ActionResult AgreementClassifications_Read([DataSourceRequest] DataSourceRequest request)
        {
            List<AgreementClassificationsDto> result;
            try
            {
                result = _dataService.AgreementClassificationsRead().ToList();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("AgreementClassification_Read",
                    "An error occurred reading the agreement classification records:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
            }
            return Json(result.ToDataSourceResult(request));
        }

        public ActionResult AgreementClassifications_ComboRead([DataSourceRequest] DataSourceRequest request)
        {
            List<AgreementClassificationsDto> result;
            try
            {
                result = _dataService.AgreementClassificationsRead().ToList();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("AgreementClassifications_ComboRead",
                    "An error occurred reading the agreement classification records:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AgreementClassifications_Create([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")] IEnumerable<AgreementClassificationsDto> rows)
        {
            var results = new List<AgreementClassificationsDto>();

            try
            {
                if (rows != null && ModelState.IsValid)
                {
                    foreach (var dto in rows)
                    {
                        _dataService.AgreementClassificationCreate(dto);
                        results.Add(dto);
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("AgreementClassifications_Create",
                    "An error occurred creating the agreement classification record:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult());
            }
            return Json(results.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AgreementClassifications_Update([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")] IEnumerable<AgreementClassificationsDto> rows)
        {
            try
            {
                if (rows != null && ModelState.IsValid)
                {
                    foreach (var dto in rows)
                    {
                        _dataService.AgreementClassificationUpdate(dto);
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("AgreementClassifications_Update",
                    "An error occurred updating the agreement classification record:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult());
            }

            return Json(rows.ToDataSourceResult(request, ModelState));
        }

        public ActionResult AgreementTypes_Read([DataSourceRequest] DataSourceRequest request)
        {
            List<AgreementTypesDto> result;
            try
            {
                result = _dataService.AgreementTypesRead().ToList();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("AgreementTypes_Read",
                    "An error occurred reading the agreement types records:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
            }

            return Json(result.ToDataSourceResult(request));
        }

        public ActionResult AgreementTypes_ComboRead([DataSourceRequest] DataSourceRequest request)
        {
            List<AgreementTypesDto> result;
            try
            {
                result = _dataService.AgreementTypesRead().ToList();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("AgreementTypes_ComboRead",
                    "An error occurred reading the agreement types records:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AgreementTypes_Create([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")] IEnumerable<AgreementTypesDto> rows)
        {
            try
            {
                if (rows != null && ModelState.IsValid)
                {
                    foreach (var dto in rows)
                    {
                        _dataService.AgreementTypeCreate(dto);
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("AgreementTypes_Create",
                    "An error occurred creating the agreement type record:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult());
            }
            return Json(rows.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AgreementTypes_Update([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")] IEnumerable<AgreementTypesDto> rows)
        {
            try
            {
                if (rows != null && ModelState.IsValid)
                {
                    foreach (var dto in rows)
                    {
                        _dataService.AgreementTypeUpdate(dto);
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("AgreementTypes_Update",
                    "An error occurred updating the agreement type record:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult());
            }

            return Json(rows.ToDataSourceResult(request, ModelState));
        }

        public ActionResult BIAClassifications_Read([DataSourceRequest] DataSourceRequest request)
        {
            List<BIAClassificationsDto> result;
            try
            {
                result = _dataService.BIAClassificationsRead().ToList();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("BIAClassifications_Read",
                    "An error occurred reading the bia classification records:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
            }
            return Json(result.ToDataSourceResult(request));
        }

        public ActionResult BIAClassifications_ComboRead([DataSourceRequest] DataSourceRequest request)
        {
            List<BIAClassificationsDto> result;
            try
            {
                result = _dataService.BIAClassificationsRead().ToList();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("BIAClassifications_ComboRead",
                    "An error occurred reading the bia classification records:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult BIAClassifications_Create([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")] IEnumerable<BIAClassificationsDto> rows)
        {
            try
            {
                if (rows != null && ModelState.IsValid)
                {
                    foreach (var dto in rows)
                    {
                        _dataService.BIAClassificationCreate(dto);
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("BIAClassifications_Create",
                    "An error occurred creating the BIA classification record:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult());
            }
            return Json(rows.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult BIAClassifications_Update([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")] IEnumerable<BIAClassificationsDto> rows)
        {
            try
            {
                if (rows != null && ModelState.IsValid)
                {
                    foreach (var dto in rows)
                    {
                        _dataService.BIAClassificationUpdate(dto);
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("BIAClassifications_Update",
                    "An error occurred updating the BIA classification record:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult());
            }

            return Json(rows.ToDataSourceResult(request, ModelState));
        }

        public ActionResult CompanyPayorCodes_Read([DataSourceRequest] DataSourceRequest request)
        {
            List<CompanyPayorCodesDto> result;
            try
            {
                result = _dataService.CompanyPayorCodesRead().ToList();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("CompanyPayorCodes_Read",
                    "An error occurred reading the company payor code records:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
            }

            return Json(result.ToDataSourceResult(request));
        }

        public ActionResult CompanyPayorCodes_ComboRead([DataSourceRequest] DataSourceRequest request)
        {
            List<CompanyPayorCodesDto> result;
            try
            {
                result = _dataService.CompanyPayorCodesRead().ToList();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("CompanyPayorCodes_ComboRead",
                    "An error occurred reading the company payor code records:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult CompanyPayorCodes_Create([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")] IEnumerable<CompanyPayorCodesDto> rows)
        {
            try
            {
                if (rows != null && ModelState.IsValid)
                {
                    foreach (var dto in rows)
                    {
                        _dataService.CompanyPayorCreate(dto);
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("CompanyPayorCodes_Create",
                    "An error occurred creating the company payor code record:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult());
            }
            return Json(rows.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult CompanyPayorCodes_Update([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")] IEnumerable<CompanyPayorCodesDto> rows)
        {
            try
            {
                if (rows != null && ModelState.IsValid)
                {
                    foreach (var dto in rows)
                    {
                        _dataService.CompanyPayorUpdate(dto);
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("CompanyPayorCodes_Update",
                    "An error occurred updating the company payor code record:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult());
            }

            return Json(rows.ToDataSourceResult(request, ModelState));
        }

        public ActionResult ProductCodeCrossReference_Read([DataSourceRequest] DataSourceRequest request)
        {
            List<ProductCodeCrossReferenceDto> result;
            try
            {
                result = _dataService.ProductCodeCrossReferenceRead().ToList();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("ProductCodeCrossReference_Read",
                    "An error occurred reading the product code cross reference records:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
            }
            return Json(result.ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ProductCodeCrossReference_Create([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")] IEnumerable<ProductCodeCrossReferenceDto> rows)
        {
            try
            {
                if (rows != null && ModelState.IsValid)
                {
                    foreach (var dto in rows)
                    {
                        _dataService.ProductCodeCrossReferenceCreate(dto);
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("ProductCodeCrossReference_Create",
                    "An error occurred creating the product code cross reference record:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult());
            }
            return Json(rows.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ProductCodeCrossReference_Update([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")] IEnumerable<ProductCodeCrossReferenceDto> rows)
        {
            try
            {
                if (rows != null && ModelState.IsValid)
                {
                    foreach (var dto in rows)
                    {
                        _dataService.ProductCodeCrossReferenceUpdate(dto);
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("ProductCodeCrossReference_Update",
                    "An error occurred updating the product code cross reference record:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult());
            }

            return Json(rows.ToDataSourceResult(request, ModelState));
        }

        public ActionResult SalesTypes_Read([DataSourceRequest] DataSourceRequest request)
        {
            List<SalesTypeDto> result;
            try
            {
                result = _dataService.SalesTypesRead().ToList();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("SalesTypes_Read",
                    "An error occurred reading the sales type records:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
            }
            return Json(result.ToDataSourceResult(request));
        }

        public ActionResult SalesTypes_ComboRead([DataSourceRequest] DataSourceRequest request)
        {
            List<SalesTypeDto> result;
            try
            {
                result = _dataService.SalesTypesRead().ToList();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("SalesTypes_Read",
                    "An error occurred reading the sales type records:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult SalesTypes_Create([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")] IEnumerable<SalesTypeDto> rows)
        {
            try
            {
                if (rows != null && ModelState.IsValid)
                {
                    foreach (var dto in rows)
                    {
                        _dataService.SalesTypeCreate(dto);
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("SalesTypes_Create",
                    "An error occurred creating the sales type record:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult());
            }
            return Json(rows.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult SalesTypes_Update([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")] IEnumerable<SalesTypeDto> rows)
        {
            try
            {
                if (rows != null && ModelState.IsValid)
                {
                    foreach (var dto in rows)
                    {
                        _dataService.SalesTypeUpdate(dto);
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("SalesTypes_Update",
                    "An error occurred updating the sales type record:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult());
            }

            return Json(rows.ToDataSourceResult(request, ModelState));
        }

        public ActionResult LeaseClassifications_Read([DataSourceRequest] DataSourceRequest request)
        {
            List<LeaseClassificationsDto> result;
            try
            {
                result = _dataService.LeaseClassificationsRead().ToList();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("LeaseClassifications_Read",
                    "An error occurred reading the lease classification records:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
            }
            return Json(result.ToDataSourceResult(request));
        }

        public ActionResult LeaseClassifications_ComboRead([DataSourceRequest] DataSourceRequest request)
        {
            List<LeaseClassificationsDto> result;
            try
            {
                result = _dataService.LeaseClassificationsRead().ToList();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("LeaseClassifications_ComboRead",
                    "An error occurred reading the lease classification records:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult LeaseClassifications_Create([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")] IEnumerable<LeaseClassificationsDto> rows)
        {
            try
            {
                if (rows != null && ModelState.IsValid)
                {
                    foreach (var dto in rows)
                    {
                        _dataService.LeaseClassificationCreate(dto);
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("LeaseClassifications_Create",
                    "An error occurred creating the lease classification record:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult());
            }
            return Json(rows.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult LeaseClassifications_Update([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")] IEnumerable<LeaseClassificationsDto> rows)
        {
            try
            {
                if (rows != null && ModelState.IsValid)
                {
                    foreach (var dto in rows)
                    {
                        _dataService.LeaseClassificationUpdate(dto);
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("LeaseClassifications_Update",
                    "An error occurred updating the lease classification record:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult());
            }

            return Json(rows.ToDataSourceResult(request, ModelState));
        }

        public ActionResult ONRRTransactionCodes_Read([DataSourceRequest] DataSourceRequest request)
        {
            List<ONRRTransactionCodesDto> result;
            try
            {
                result = _dataService.ONRRTransactionCodesRead().ToList();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("ONRRTransactionCodes_Read",
                    "An error occurred reading the ONRR transaction code records:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
            }
            return Json(result.ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ONRRTransactionCodes_Create([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")] IEnumerable<ONRRTransactionCodesDto> rows)
        {
            try
            {
                if (rows != null && ModelState.IsValid)
                {
                    foreach (var dto in rows)
                    {
                        _dataService.ONRRTransactionCodeCreate(dto);
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("ONRRTransactionCodes_Create",
                    "An error occurred creating the ONRR transaction code record:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult());
            }
            return Json(rows.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ONRRTransactionCodes_Update([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")] IEnumerable<ONRRTransactionCodesDto> rows)
        {
            try
            {
                if (rows != null && ModelState.IsValid)
                {
                    foreach (var dto in rows)
                    {
                        _dataService.ONRRTransactionCodeUpdate(dto);
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("ONRRTransactionCodes_Update",
                    "An error occurred updating the ONRR transaction code record:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult());
            }

            return Json(rows.ToDataSourceResult(request, ModelState));
        }

        public ActionResult PaymentMethods_Read([DataSourceRequest] DataSourceRequest request)
        {
            List<PaymentMethodsDto> result;
            try
            {
                result = _dataService.PaymentMethodsRead().ToList();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("PaymentMethods_Read",
                    "An error occurred reading the payment method records:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
            }
            return Json(result.ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult PaymentMethods_Create([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")] IEnumerable<PaymentMethodsDto> rows)
        {
            try
            {
                if (rows != null && ModelState.IsValid)
                {
                    foreach (var dto in rows)
                    {
                        _dataService.PaymentMethodCreate(dto);
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("PaymentMethods_Create",
                    "An error occurred creating the payment method record:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult());
            }
            return Json(rows.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult PaymentMethods_Update([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")] IEnumerable<PaymentMethodsDto> rows)
        {
            try
            {
                if (rows != null && ModelState.IsValid)
                {
                    foreach (var dto in rows)
                    {
                        _dataService.PaymentMethodUpdate(dto);
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("PaymentMethods_Update",
                    "An error occurred updating the payment method record:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult());
            }

            return Json(rows.ToDataSourceResult(request, ModelState));
        }

        public ActionResult PayorCodes_Read([DataSourceRequest] DataSourceRequest request)
        {
            List<PayorCodesDto> result;
            try
            {
                result = _dataService.PayorCodesRead().ToList();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("PayorCodes_Read",
                    "An error occurred reading the payor code records:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
            }
            return Json(result.ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult PayorCodes_Create([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")] IEnumerable<PayorCodesDto> rows)
        {
            try
            {
                if (rows != null && ModelState.IsValid)
                {
                    foreach (var dto in rows)
                    {
                        _dataService.PayorCodeCreate(dto);
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("PayorCodes_Create",
                    "An error occurred creating the payor code record:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult());
            }
            return Json(rows.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult PayorCodes_Update([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")] IEnumerable<PayorCodesDto> rows)
        {
            try
            {
                if (rows != null && ModelState.IsValid)
                {
                    foreach (var dto in rows)
                    {
                        _dataService.PayorCodeUpdate(dto);
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("PayorCodes_Update",
                    "An error occurred updating the payor code record:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult());
            }

            return Json(rows.ToDataSourceResult(request, ModelState));
        }

        // Admin
        public ActionResult Admin()
        {
            var vm = new AdminViewModel {Title = "Admin"};
            return View(vm);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult PullJtran()
        {
            try
            {
                _dataService.AgreementsRead();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("PullJtran",
                    "An error occurred pulling jtran records:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult());
            }

            return Json("", JsonRequestBehavior.AllowGet);
        }


        public ActionResult HierarchyExample()
        {
            var vm = new LeasesViewModel {Title = "Hierarchy Example"};
            return View(vm);
        }

        // JTRAN
        public ActionResult JTRAN()
        {
            var vm = new JTranViewModel {Title = "JTRAN Records"};
            return View(vm);
        }

        public ActionResult JTRANs_Read([DataSourceRequest] DataSourceRequest request)
        {
            List<JtranDto> result;
            try
            {
                result = _dataService.JTRANsRead().ToList();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("JTRAN_Read",
                    "An error occurred reading the JTRN records:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
            }
            return Json(result.ToDataSourceResult(request));
        }

        // Detail
        public ActionResult Detail()
        {
            var vm = new DetailViewModel {Title = "Detail"};
            return View(vm);
        }

        public ActionResult Details_Read([DataSourceRequest] DataSourceRequest request, string StateCode)
        {
            List<DetailDto> result;
            try
            {
                result = _dataService.DetailsRead(StateCode).ToList();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Details_Read",
                    "An error occurred reading the detail records:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
            }
            return Json(result.ToDataSourceResult(request));
        }

        // Recoupments
        public ActionResult Recoupments()
        {
            var vm = new DetailViewModel {Title = "Recoupments"};
            return View(vm);
        }


        // Aggregate
        public ActionResult Aggregate()
        {
            var vm = new AggregateViewModel {Title = "Aggregate"};
            return View(vm);
        }

        public ActionResult Aggregate_Read([DataSourceRequest] DataSourceRequest request)
        {
            List<AggregateDto> result;
            try
            {
                result = _dataService.AggregatesRead().ToList();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Aggregate_Read",
                    "An error occurred reading the aggregate records:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
            }
            return Json(result.ToDataSourceResult(request));
        }

        public ActionResult AggregateDetail(int? ID)
        {
            var vm = new AggregateDetailViewModel {Title = "Aggregate Detail"};

            try
            {
                if (ID != null)
                {
                    var result = _dataService.AggregateRead(ID.Value);

                    if (result != null)
                    {
                        var details = _dataService.DetailsReadForAggregate(ID.Value).ToList();
                        result.Details = details;
                    }
                    vm.Aggregate = result;
                }
                else
                {
                    ModelState.AddModelError("AgreementDetail", "The lease id cannot be empty");
                    return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("AgreementDetail",
                    "An error occurred reading the lease detail data:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
            }

            return View(vm);
        }


        // Files
        public ActionResult Files()
        {
            var vm = new FilesViewModel {Title = "Files"};
            return View(vm);
        }

        public ActionResult Files_Read([DataSourceRequest] DataSourceRequest request)
        {
            List<FileDto> result;
            try
            {
                result = _dataService.FilesRead().ToList();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Files_Read",
                    "An error occurred reading the file records:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
            }
            return Json(result.ToDataSourceResult(request));
        }

        // SAP
        public ActionResult SAP()
        {
            var vm = new SAPViewModel {Title = "SAP"};
            return View(vm);
        }

        // Reports
        public ActionResult Reports()
        {
            var vm = new ReportsViewModel {Title = "Reports"};
            return View(vm);
        }

        #region Domain Methods for combo boxes

        public JsonResult AgreementsRead([DataSourceRequest] DataSourceRequest request)
        {
            var result = _dataService.AgreementsRead().ToList();
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Agreements_Read([DataSourceRequest] DataSourceRequest request)
        {
            List<AgreementDto> result;
            try
            {
                result = _dataService.AgreementsRead().ToList();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Agreements_Read",
                    "An error occurred reading the agreement records:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
            }
            return Json(result.ToDataSourceResult(request));
        }

        public ActionResult States_Read([DataSourceRequest] DataSourceRequest request)
        {
            List<StatesDto> result;
            try
            {
                result = _dataService.StatesRead().ToList();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("States_Read",
                    "An error occurred reading the state records:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
            }
            return Json(result.ToDataSourceResult(request));
        }

        public JsonResult States_ComboRead([DataSourceRequest] DataSourceRequest request)
        {
            var result = _dataService.StatesRead().ToList();
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult States_Create([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")] IEnumerable<StatesDto> rows)
        {
            try
            {
                if (rows != null && ModelState.IsValid)
                {
                    foreach (var dto in rows)
                    {
                        _dataService.StateCreate(dto);
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("States_Create",
                    "An error occurred creating the state record:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult());
            }
            return Json(rows.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult States_Update([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")] IEnumerable<StatesDto> rows)
        {
            try
            {
                if (rows != null && ModelState.IsValid)
                {
                    foreach (var dto in rows)
                    {
                        _dataService.StateUpdate(dto);
                    }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("States_Update",
                    "An error occurred updating the state record:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult());
            }

            return Json(rows.ToDataSourceResult(request, ModelState));
        }

        public JsonResult LeasesRead([DataSourceRequest] DataSourceRequest request)
        {
            var result = _dataService.LeasesRead().ToList();
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        #endregion

        [HttpPost]
        public ActionResult Excel_Export_Save(string contentType, string base64, string fileName)
        {
            var fileContents = Convert.FromBase64String(base64);

            return File(fileContents, contentType, fileName);
        }
    }
}