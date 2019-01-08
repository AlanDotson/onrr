using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QEP.ONRR.Data.DataContracts
{
    public class WellLeaseAgreementDto
    {
        [DisplayName("Well Lease Agreement ID")]
        [Required]
        public int WellLeaseAgreementID { get; set; }

        [DisplayName("Well Completion ID")]
        [Required]
        public string WellCompletionID { get; set; }

        [DisplayName("Lease Agreement ID")]
        [Required]
        public int LeaseAgreementID { get; set; }

        [DisplayName("Product Code ID")]
        [Required]
        public int ProductCodeID { get; set; }

        [DisplayName("Sales Type ID")]
        [Required]
        public int SalesTypeID { get; set; }

        [Required]
        [DisplayName("Effective From")]
        public DateTime EffectiveFrom { get; set; }

        [Required]
        [DisplayName("Effective To")]
        public DateTime EffectiveTo { get; set; }

        [DisplayName("Sales Type")]
        public string SalesType { get; set; }

        [DisplayName("ONRR Product Code")]
        public string ONRRProductCode { get; set; }

        [DisplayName("QRA Major Product Code")]
        public string QRAMajorProductCode { get; set; }

    }
}
