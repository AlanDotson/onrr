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
    
    public partial class ONRRAggregateSelectAll_Result
    {
        public int AggregateID { get; set; }
        public int LeaseAgreementID { get; set; }
        public int ProductCodeID { get; set; }
        public int SalesTypeID { get; set; }
        public System.DateTime ProductionMonth { get; set; }
        public int TransactionCodeID { get; set; }
        public Nullable<int> AdjustmentReasonCodeID { get; set; }
        public decimal SalesVolume { get; set; }
        public decimal GasMMBTU { get; set; }
        public decimal SalesValue { get; set; }
        public decimal GrossRoyaltyValue { get; set; }
        public decimal TransortationAllowanceDeduction { get; set; }
        public decimal ProcessingAllowanceDeduction { get; set; }
        public decimal NetRoyaltyValue { get; set; }
        public int FileID { get; set; }
        public string PADNumber { get; set; }
        public Nullable<int> PayorCodeID { get; set; }
        public int StatusID { get; set; }
        public Nullable<int> PaymentMethodID { get; set; }
        public string SalesType { get; set; }
        public string ONRRTransactionCode { get; set; }
        public string DispositionCode { get; set; }
        public string ProductCode { get; set; }
        public string Payor { get; set; }
        public string PaymentMethod { get; set; }
        public string AdjustmentReason { get; set; }
    }
}
