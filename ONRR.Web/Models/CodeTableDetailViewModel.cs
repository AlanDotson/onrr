using System.Collections.Generic;
using QEP.ONRR.Data.DataContracts;

namespace QEP.ONRR.Web.Models
{
    public class CodeTableDetailViewModel : BaseViewModel
    {

        public int CurrentTableID { get; set; }
        public string CurrentTableName { get; set; }

        public List<AdjustmentReasonCodesDto> AdjustmentReasonCodes { get; set; }
        public List<AgreementClassificationsDto> AgreementClassifications { get; set; }
        public List<AgreementTypesDto> AgreementTypes { get; set; }
        public List<BIAClassificationsDto> BIAClassifications { get; set; }
        public List<CompanyPayorCodesDto> CompanyPayorCodes { get; set; }
        public List<LeaseClassificationsDto> LeaseClassifications { get; set; }
        public List<ONRRTransactionCodesDto> ONRRTransactionCodes { get; set; }
        public List<PaymentMethodsDto> PaymentMethods { get; set; }
        public List<PayorCodesDto> PayorCodes { get; set; }
        public List<ProductCodeCrossReferenceDto> ProductCodeCrossReference { get; set; }
        public List<SalesTypeDto> SalesTypes { get; set; }
        public List<StatesDto> States { get; set; }

    }
}