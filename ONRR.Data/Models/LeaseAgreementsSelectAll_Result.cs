//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QEP.ONRR.Data.Models
{
    using System;
    
    public partial class LeaseAgreementsSelectAll_Result
    {
        public int LeaseAgreementID { get; set; }
        public int LeaseID { get; set; }
        public Nullable<int> AgreementID { get; set; }
        public System.DateTime EffectiveFrom { get; set; }
        public System.DateTime EffectiveTo { get; set; }
        public Nullable<decimal> TractFactor { get; set; }
        public Nullable<decimal> OverrideTractFactor { get; set; }
        public Nullable<decimal> MarketShare { get; set; }
        public Nullable<decimal> TractAcreage { get; set; }
    }
}
