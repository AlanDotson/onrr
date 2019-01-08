using System;
using System.ComponentModel;

namespace QEP.ONRR.Data.DataContracts
{
    public class DetailDto
    {
        [DisplayName("ONRR Detail ID")]
        public int ONRRDetailID { get; set; }

        [DisplayName("SL Detail Number")]
        public long SL_DETAIL_NO { get; set; }

        [DisplayName("Gross Amount")]
        public decimal GrossAmount { get; set; }

        [DisplayName("Override Gross Amount")]
        public decimal? OverrideGrossAmount { get; set; }

        [DisplayName("Gross Quantity")]
        public decimal GrossQuantity { get; set; }

        [DisplayName("Override Gross Quantity")]
        public decimal? OverrideGrossQuantity { get; set; }

        [DisplayName("Transaction Value Amount")]
        public decimal TransactionValueAmount { get; set; }

        [DisplayName("Override Transaction Value Amount")]
        public decimal? OverrideTransactionValueAmount { get; set; }

        [DisplayName("Transaction Quantity")]
        public decimal TransactionQuantity { get; set; }

        [DisplayName("Override Transaction Quantity")]
        public decimal? OverrideTransactionQuantity { get; set; }

        [DisplayName("Price")]
        public decimal? Price { get; set; }

        [DisplayName("Lease Agreement ID")]
        public int LeaseAgreementID { get; set; }

        [DisplayName("Product Code ID")]
        public int ProductCodeID { get; set; }

        [DisplayName("State Code")]
        public string StateCode { get; set; }

        [DisplayName("Company Marketed Volume")]
        public decimal? CompanyMarketedVolume { get; set; }

        [DisplayName("Override Company Marketed Volume")]
        public decimal? OverrideCompanyMarketedVolume { get; set; }

        [DisplayName("Company Marketed Value")]
        public decimal? CompanyMarketedValue { get; set; }

        [DisplayName("Override Company Marketed Value")]
        public decimal? OverrideCompanyMarketedValue { get; set; }

        [DisplayName("Sales Volume")]
        public decimal? SalesVolume { get; set; }

        [DisplayName("Override Sales Volume")]
        public decimal? OverrideSalesVolume { get; set; }

        [DisplayName("MMBTU")]
        public decimal? MMBTU { get; set; }

        [DisplayName("Override MMBTU")]
        public decimal? OverrideMMBTU { get; set; }

        [DisplayName("Sales Value")]
        public decimal? SalesValue { get; set; }

        [DisplayName("Override Sales Value")]
        public decimal? OverrideSalesValue { get; set; }

        [DisplayName("Gross Royalty Value")]
        public decimal? GrossRoyaltyValue { get; set; }

        [DisplayName("Override Gross Royalty Value")]
        public decimal? OverrideGrossRoyaltyValue { get; set; }

        [DisplayName("Transportation Allowance Deduction")]
        public decimal? TransportationAllowanceDeduction { get; set; }

        [DisplayName("Override Transportation Allowance Deduction")]
        public decimal? OverrideTransportationAllowanceDeduction { get; set; }

        [DisplayName("Processing Allowance Deduction")]
        public decimal? ProcessingAllowanceDeduction { get; set; }

        [DisplayName("Override Processing Allowance Deduction")]
        public decimal? OverrideProcessingAllowanceDeduction { get; set; }

        [DisplayName("Net Royalty Value")]
        public decimal? NetRoyaltyValue { get; set; }

        [DisplayName("Override Net Royalty Value")]
        public decimal? OverrideNetRoyaltyValue { get; set; }

        [DisplayName("Aggregate ID")]
        public int? AggregateID { get; set; }

        [DisplayName("Reversal Aggregate ID")]
        public int? ReversalAggregateID { get; set; }

        [DisplayName("Accounting Month")]
        public DateTime AccountingMonth { get; set; }

        [DisplayName("Production Month")]
        public DateTime ProductionMonth { get; set; }

        [DisplayName("Transaction Code ID")]
        public int TransactionCodeID { get; set; }

        [DisplayName("Adjustment Reason Code ID")]
        public int? AdjustmentReasonCodeID { get; set; }

        [DisplayName("Processing Status ID")]
        public int ProcessingStatusID { get; set; }

        [DisplayName("Suspend Reason ID")]
        public int? SuspendReasonID { get; set; }

        [DisplayName("Sales Type ID")]
        public int SalesTypeID { get; set; }

        [DisplayName("Reversal Detail ID")]
        public int? ReversalDetailID { get; set; }

        [DisplayName("ONRR Product Code")]
        public string ONRRProductCode { get; set; }

        [DisplayName("QRA Major Product Code")]
        public string QRAMajorProductCode { get; set; }

        [DisplayName("State")]
        public string State { get; set; }

        [DisplayName("Disposition Code")]
        public string DispositionCode { get; set; }

        [DisplayName("ONRR Transaction Code")]
        public string ONRRTransactionCode { get; set; }

        [DisplayName("Product Code")]
        public string ProductCode { get; set; }

        [DisplayName("Adjustment Reason")]
        public string AdjustmentReason { get; set; }

        [DisplayName("Sales Type")]
        public string SalesType { get; set; }


    }
}
