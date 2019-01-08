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
    
    public partial class ONRRDetailSelect_Result
    {
        public long SL_DETAIL_NO { get; set; }
        public decimal GrossAmount { get; set; }
        public Nullable<decimal> OverrideGrossAmount { get; set; }
        public decimal GrossQuantity { get; set; }
        public Nullable<decimal> OverrideGrossQuantity { get; set; }
        public decimal TransactionValueAmount { get; set; }
        public Nullable<decimal> OverrideTransactionValueAmount { get; set; }
        public decimal TransactionQuantity { get; set; }
        public Nullable<decimal> OverrideTransactionQuantity { get; set; }
        public Nullable<decimal> Price { get; set; }
        public int LeaseAgreementID { get; set; }
        public int ProductCodeID { get; set; }
        public string StateCode { get; set; }
        public Nullable<decimal> CompanyMarketedVolume { get; set; }
        public Nullable<decimal> OverrideCompanyMarketedVolume { get; set; }
        public Nullable<decimal> CompanyMarketedValue { get; set; }
        public Nullable<decimal> OverrideCompanyMarketedValue { get; set; }
        public Nullable<decimal> SalesVolume { get; set; }
        public Nullable<decimal> OverrideSalesVolume { get; set; }
        public Nullable<decimal> MMBTU { get; set; }
        public Nullable<decimal> OverrideMMBTU { get; set; }
        public Nullable<decimal> SalesValue { get; set; }
        public Nullable<decimal> OverrideSalesValue { get; set; }
        public Nullable<decimal> GrossRoyaltyValue { get; set; }
        public Nullable<decimal> OverrideGrossRoyaltyValue { get; set; }
        public Nullable<decimal> TransportationAllowanceDeduction { get; set; }
        public Nullable<decimal> OverrideTransportationAllowanceDeduction { get; set; }
        public Nullable<decimal> ProcessingAllowanceDeduction { get; set; }
        public Nullable<decimal> OverrideProcessingAllowanceDeduction { get; set; }
        public Nullable<decimal> NetRoyaltyValue { get; set; }
        public Nullable<decimal> OverrideNetRoyaltyValue { get; set; }
        public Nullable<int> AggregateID { get; set; }
        public Nullable<int> ReversalAggregateID { get; set; }
        public System.DateTime AccountingMonth { get; set; }
        public System.DateTime ProductionMonth { get; set; }
        public int TransactionCodeID { get; set; }
        public Nullable<int> AdjustmentReasonCodeID { get; set; }
        public int ProcessingStatusID { get; set; }
        public Nullable<int> SuspendReasonID { get; set; }
        public int ONRRDetailID { get; set; }
        public int SalesTypeID { get; set; }
        public Nullable<int> ReversalDetailID { get; set; }
        public string ONRRProductCode { get; set; }
        public string QRAMajorProductCode { get; set; }
        public string State { get; set; }
        public string DispositionCode { get; set; }
        public string ONRRTransactionCode { get; set; }
        public string ProductCode { get; set; }
        public string AdjustmentReason { get; set; }
        public string SalesType { get; set; }
    }
}
