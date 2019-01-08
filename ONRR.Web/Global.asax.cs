using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using MvcSiteMapProvider.Loader;
using MvcSiteMapProvider.Web.Mvc;
using MvcSiteMapProvider.Xml;
using QEP.ONRR.Data.DataContracts;
using QEP.ONRR.Data.Models;

namespace QEP.ONRR.Web
{
    public class MvcApplication : HttpApplication
    {
        // private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            log4net.Config.XmlConfigurator.Configure();
            ConfigureAutomapper();

        }


        private void ConfigureAutomapper()
        {
            Mapper.CreateMap<LeasesSelectAll_Result, LeaseDto>();
            Mapper.CreateMap<LeasesSelect_Result, LeaseDto>();

            Mapper.CreateMap<LeaseAgreementSelect_Result, LeaseAgreementDto>();
            Mapper.CreateMap<AgreementLeaseSelect_Result, LeaseAgreementDto>();

            Mapper.CreateMap<AgreementsSelectAll_Result, AgreementDto>();
            Mapper.CreateMap<AgreementsSelect_Result, AgreementDto>();

            Mapper.CreateMap<WellCompletionsSelectAll_Result,WellDto>();
            Mapper.CreateMap<WellCompletionsSelect_Result, WellDto>();

            Mapper.CreateMap<ONRRFilesSelectAll_Result, FileDto>();
            Mapper.CreateMap<ONRRFilesSelect_Result, FileDto>();

            Mapper.CreateMap<ONRRAggregateSelectAll_Result, AggregateDto>();
            Mapper.CreateMap<ONRRAggregateSelect_Result, AggregateDto>();

            Mapper.CreateMap<JTRN_SL_DETAILSelectAll_Result, JtranDto>();
            Mapper.CreateMap<JTRN_SL_DETAILSelect_Result, JtranDto>();

            Mapper.CreateMap<ONRRDetailSelectAll_Result, DetailDto>();
            Mapper.CreateMap<ONRRDetailSelectAll_Result, DetailDto>();
            Mapper.CreateMap<ONRRDetailSelectByAggregate_Result, DetailDto>();
            Mapper.CreateMap<ONRRDetailSelectFiltered_Result, DetailDto>();

            Mapper.CreateMap<WellLeaseAgreementsSelect_Result, WellLeaseAgreementDto>();
            Mapper.CreateMap<WellLeaseAgreementsSelectAll_Result, WellLeaseAgreementDto>();
            Mapper.CreateMap<WellLeaseAgreementSelectByWell_Result, WellLeaseAgreementDto>();

            // Code tables
            Mapper.CreateMap<AdjustmentReasonCodesSelectAll_Result, AdjustmentReasonCodesDto>();
            Mapper.CreateMap<AgreementClassificationsSelectAll_Result, AgreementClassificationsDto>();
            Mapper.CreateMap<AgreementTypesSelectAll_Result, AgreementTypesDto>();
            Mapper.CreateMap<BIAClassificationsSelectAll_Result, BIAClassificationsDto>();
            Mapper.CreateMap<CompanyPayorCodesSelectAll_Result, CompanyPayorCodesDto>();
            Mapper.CreateMap<LeaseClassificationsSelectAll_Result, LeaseClassificationsDto>();
            Mapper.CreateMap<ONRRTransactionCodesSelectAll_Result, ONRRTransactionCodesDto>();
            Mapper.CreateMap<PaymentMethodsSelectAll_Result, PaymentMethodsDto>();
            Mapper.CreateMap<PayorCodesSelectAll_Result, PayorCodesDto>();
            Mapper.CreateMap<ProductCodeCrossReferenceSelectAll_Result, ProductCodeCrossReferenceDto>();
            Mapper.CreateMap<SalesTypesSelectAll_Result, SalesTypeDto>();
            Mapper.CreateMap<StatesSelectAll_Result, StatesDto>();

        }

        //private void Application_Error(object sender, EventArgs e)
        //{
        //    Exception ex = Server.GetLastError();
        //    Response.Clear();

        //    log.Error(ex.ToString());

        //    var httpException = ex as HttpException;
        //    var action = "GeneralError";

        //    if (httpException != null)
        //    {
        //        switch (httpException.GetHttpCode())
        //        {
        //            case 404:
        //                // page not found
        //                action = "HttpError404";
        //                break;
        //            case 500:
        //                // server error
        //                action = "HttpError500";
        //                break;
        //            default:
        //                action = "GeneralError";
        //                break;
        //        }
        //    }

        //    // clear error on server
        //    Server.ClearError();
        //    Response.Redirect($"~/Error/{action}/?message={ex.Message}");

        //}
    }
}
