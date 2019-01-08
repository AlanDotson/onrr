using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QEP.ONRR.Data.DataContracts
{
    public class WellDto
    {
        [DisplayName("Well Completion ID")]
        [Required]
        public string WellCompletionID { get; set; }

        [DisplayName("Property Number")]
        [StringLength(10), Required]
        public string PropertyNumber { get; set; }

        [DisplayName("Well Acreage")]
        [Required]
        public decimal? WellAcreage { get; set; }

        [DisplayName("Well Completion Name")]
        [StringLength(60), Required]
        public string WellCompletionName { get; set; }

        [UIHint("StateCode")]
        [DisplayName("State Code")]
        [StringLength(2), Required]
        public string StateCode { get; set; }

        [DisplayName("State")]
        public string State { get; set; }

        [DisplayName("API")]
        [StringLength(14)]
        public string API { get; set; }

        [DisplayName("Company")]
        [StringLength(4), Required]
        public string Company { get; set; }

        [DisplayName("Property Name")]
        [StringLength(250), Required]
        public string PropertyName { get; set; }

        [DisplayName("Gross Marketed Interest")]
        public decimal? GrossMarketedInterest { get; set; }

        public List<WellLeaseAgreementDto> WellLeaseAgreements { get; set; }

    }
}
