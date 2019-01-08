using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QEP.ONRR.Data.DataContracts
{

    public class CompanyPayorCodesDto
    {
        [DisplayName("Company ID")]
        public int CompanyID { get; set; }

        [DisplayName("QRA Company Code")]
        [StringLength(10), Required]
        public string QRACompanyCode { get; set; }

        [DisplayName("Company Name")]
        [StringLength(150), Required]
        public string CompanyName { get; set; }

        [DisplayName("ONRR Payor Code")]
        [StringLength(15), Required]
        public string ONRRPayorCode { get; set; }
    }
}
