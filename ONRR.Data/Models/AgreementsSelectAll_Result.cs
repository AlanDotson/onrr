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
    
    public partial class AgreementsSelectAll_Result
    {
        public int AgreementID { get; set; }
        public string ONRRAgreementID { get; set; }
        public string BLMSerialNumber { get; set; }
        public string ONRRAgreementDescription { get; set; }
        public string Formation { get; set; }
        public int AgreementClassificationID { get; set; }
        public int AgreementTypeID { get; set; }
        public Nullable<decimal> TotalAcreage { get; set; }
        public System.DateTime EffectiveFrom { get; set; }
        public System.DateTime EffectiveTo { get; set; }
        public int CompanyID { get; set; }
        public string AgreementClassification { get; set; }
        public string AgreementType { get; set; }
        public string CompanyName { get; set; }
    }
}
