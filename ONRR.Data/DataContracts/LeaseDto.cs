using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QEP.ONRR.Data.DataContracts
{
    public class LeaseDto
    {
        [DisplayName("Lease ID")]
        public int LeaseID { get; set; }

        [DisplayName("ONRR Lease ID")]
        [StringLength(10), Required]
        public string ONRRLeaseID { get; set; }

        [DisplayName("BLM Serial Number")]
        [StringLength(50), Required]
        public string BLMSerialNumber { get; set; }

        [DisplayName("QEP Lease ID")]
        [StringLength(50), Required]
        public string QEPLeaseID { get; set; }

        [DisplayName("Name")]
        [StringLength(150), Required]
        public string QEPLeaseName { get; set; }

        [DisplayName("Lease Classification ID")]
        [Required]
        public int LeaseClassificationID { get; set; }

        [UIHint("BIAClassificationID")]
        [DisplayName("BIA Classification ID")]
        public int? BIAClassificationID { get; set; }

        [DisplayName("QEP Effective Date")]
        public DateTime? QEPEffectiveDate { get; set; }

        [UIHint("StateCode")]
        [DisplayName("State Code")]
        [StringLength(2)]
        public string StateCode { get; set; }

        [DisplayName("State")]
        public string State { get; set; }

        [DisplayName("County")]
        [StringLength(150)]
        public string County { get; set; }

        [DisplayName("Royalty Rate")]
        [Required]
        public decimal RoyaltyRate { get; set; }

        [DisplayName("Effective From")]
        [Required]
        public DateTime EffectiveFrom { get; set; }

        [DisplayName("Effective To")]
        [Required]
        public DateTime EffectiveTo { get; set; }

        [DisplayName("Company ID")]
        [Required]
        public int CompanyID { get; set; }

        [DisplayName("BIA Classification")]
        public string BIAClassification { get; set; }

        [DisplayName("Classification")]
        public string Classification { get; set; }

        [DisplayName("Company")]
        public string CompanyName { get; set; }

        public List<LeaseAgreementDto> LeaseAgreements { get; set; }

        public List<AgreementDto> Agreements { get; set; }

    }
}
