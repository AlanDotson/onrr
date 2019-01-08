using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QEP.ONRR.Data.DataContracts
{
    public class AgreementDto
    {
        [DisplayName("Agreement ID")]
        public int AgreementID { get; set; }

        [DisplayName("Description")]
        [StringLength(150)]
        public string ONRRAgreementDescription { get; set; }

        [DisplayName("ONRR Agreement ID")]
        [StringLength(50)]
        public string ONRRAgreementID { get; set; }

        [DisplayName("BLM Serial Number")]
        [StringLength(50)]
        public string BLMSerialNumber { get; set; }

        [DisplayName("Formation")]
        [StringLength(150)]
        public string Formation { get; set; }

        [UIHint("AgreementClassificationID")]
        [DisplayName("Agreement Classification ID")]
        [Required]
        public int AgreementClassificationID { get; set; }

        [UIHint("AgreementTypeID")]
        [DisplayName("Agreement Type ID")]
        [Required]
        public int AgreementTypeID { get; set; }

        [DisplayName("Total Acreage")]
        public decimal? TotalAcreage { get; set; }

        [DisplayName("Effective From")]
        [Required]
        public DateTime EffectiveFrom { get; set; }

        [DisplayName("Effective To")]
        [Required]
        public DateTime EffectiveTo { get; set; }

        [UIHint("CompanyID")]
        [DisplayName("Company ID")]
        [Required]
        public int CompanyID { get; set; }

        [DisplayName("Classification")]
        public string AgreementClassification { get; set; }

        [DisplayName("Type")]
        public string AgreementType { get; set; }

        [DisplayName("Company")]
        public string CompanyName { get; set; }

        public List<LeaseAgreementDto> LeaseAgreements { get; set; }

    }
}
