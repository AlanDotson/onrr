using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QEP.ONRR.Data.DataContracts
{
    public class LeaseAgreementDto
    {
        [DisplayName("Lease Agreement ID")]
        public int LeaseAgreementID { get; set; }

        [UIHint("LeaseID")]
        [DisplayName("Lease ID")]
        public int LeaseID { get; set; }

        [DisplayName("Lease Name")]
        public string QEPLeaseName { get; set; }

        [UIHint("AgreementID")]
        [DisplayName("Agreement ID")]
        public int AgreementID { get; set; }

        [DisplayName("Agreement Name")]
        public string ONRRAgreementDescription { get; set; }

        [DisplayName("Effective From")]
        public DateTime EffectiveFrom { get; set; }

        [DisplayName("Effective To")]
        public DateTime EffectiveTo { get; set; }

        [DisplayName("Tract Factor")]
        public decimal TractFactor { get; set; }

        [DisplayName("Override Tract Factor")]
        public decimal OverrideTractFactor { get; set; }

        [DisplayName("Market Share")]
        public decimal MarketShare { get; set; }

        [DisplayName("Tract Acreage")]
        public decimal TractAcreage { get; set; }

    }
}
