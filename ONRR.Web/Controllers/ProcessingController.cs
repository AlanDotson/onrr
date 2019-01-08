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
    public class ProcessingController : Controller
    {
        private readonly OnrrService _dataService = new OnrrService();
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        // Admin
        public ActionResult Admin()
        {
            var vm = new AdminViewModel { Title = "Admin" };
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
                ModelState.AddModelError("PullJtran", "An error occurred pulling jtran records:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult());
            }

            return Json("", JsonRequestBehavior.AllowGet);
        }


        public ActionResult HierarchyExample()
        {
            var vm = new LeasesViewModel { Title = "Hierarchy Example" };
            return View(vm);
        }

        // JTRAN
        public ActionResult JTRAN()
        {
            var vm = new JTranViewModel { Title = "JTRAN Records" };
            return View(vm);
        }

        public ActionResult JTRANs_Read([DataSourceRequest]DataSourceRequest request)
        {
            List<JtranDto> result;
            try
            {
                result = _dataService.JTRANsRead().ToList();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("JTRAN_Read", "An error occurred reading the JTRN records:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
            }
            return Json(result.ToDataSourceResult(request));

        }

        // Detail
        public ActionResult Detail()
        {
            var vm = new DetailViewModel { Title = "Detail" };
            return View(vm);
        }

        public ActionResult Details_Read([DataSourceRequest]DataSourceRequest request, string StateCode)
        {
            List<DetailDto> result;
            try
            {
                result = _dataService.DetailsRead(StateCode).ToList();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Details_Read", "An error occurred reading the detail records:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
            }
            return Json(result.ToDataSourceResult(request));

        }

        // Recoupments
        public ActionResult Recoupments()
        {
            var vm = new DetailViewModel { Title = "Recoupments" };
            return View(vm);
        }


        // Aggregate
        public ActionResult Aggregate()
        {
            var vm = new AggregateViewModel { Title = "Aggregate" };
            return View(vm);
        }

        public ActionResult Aggregate_Read([DataSourceRequest]DataSourceRequest request)
        {
            List<AggregateDto> result;
            try
            {
                result = _dataService.AggregatesRead().ToList();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Aggregate_Read", "An error occurred reading the aggregate records:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
            }
            return Json(result.ToDataSourceResult(request));

        }

        public ActionResult AggregateDetail(int? ID)
        {
            var vm = new AggregateDetailViewModel { Title = "Aggregate Detail" };

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
                ModelState.AddModelError("AgreementDetail", "An error occurred reading the lease detail data:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
            }

            return View(vm);
        }

        // Files
        public ActionResult Files()
        {
            var vm = new FilesViewModel { Title = "Files" };
            return View(vm);
        }

        public ActionResult Files_Read([DataSourceRequest]DataSourceRequest request)
        {
            List<FileDto> result;
            try
            {
                result = _dataService.FilesRead().ToList();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Files_Read", "An error occurred reading the file records:" + Environment.NewLine + ex);
                log.Error(ex.ToString());
                return Json(ModelState.ToDataSourceResult(), JsonRequestBehavior.AllowGet);
            }
            return Json(result.ToDataSourceResult(request));

        }

        // SAP
        public ActionResult SAP()
        {
            var vm = new SAPViewModel { Title = "SAP" };
            return View(vm);
        }

        // Reports
        public ActionResult Reports()
        {
            var vm = new ReportsViewModel { Title = "Reports" };
            return View(vm);
        }

    }
}