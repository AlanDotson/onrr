using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QEP.ONRR.Data.DataContracts
{
    public class AggregateDto
    {
        [DisplayName("Aggregate ID")]
        public int AggregateID { get; set; }

        [DisplayName("Lease Agreement ID")]
        public int LeaseAgreementID { get; set; }

        [DisplayName("Product Code ID")]
        public int ProductCodeID { get; set; }

        [DisplayName("Sales Type ID")]
        public int SalesTypeID { get; set; }

        [DisplayName("Production Month")]
        public DateTime ProductionMonth { get; set; }

        [DisplayName("Transaction Code ID")]
        public int TransactionCodeID { get; set; }

        [DisplayName("Adjustment Reason Code ID")]
        public int? AdjustmentReasonCodeID { get; set; }

        [DisplayName("Sales Volume")]
        public decimal SalesVolume { get; set; }

        [DisplayName("Gas MMBTU")]
        public decimal GasMMBTU { get; set; }

        [DisplayName("Sales Value")]
        public decimal SalesValue { get; set; }

        [DisplayName("Gross Royalty Value")]
        public decimal GrossRoyaltyValue { get; set; }

        [DisplayName("Transortation Allowance Deduction")]
        public decimal TransortationAllowanceDeduction { get; set; }

        [DisplayName("Processing Allowance Deduction")]
        public decimal ProcessingAllowanceDeduction { get; set; }

        [DisplayName("Net Royalty Value")]
        public decimal NetRoyaltyValue { get; set; }

        [DisplayName("File ID")]
        public int FileID { get; set; }

        [DisplayName("PAD Number")]
        public string PADNumber { get; set; }

        [DisplayName("Payor Code ID")]
        public int? PayorCodeID { get; set; }

        [DisplayName("Status ID")]
        public int StatusID { get; set; }

        [DisplayName("Payment Method ID")]
        public int? PaymentMethodID { get; set; }

        [DisplayName("Sales Type")]
        public string SalesType { get; set; }

        [DisplayName("ONRR Transaction Code")]
        public string ONRRTransactionCode { get; set; }

        [DisplayName("Disposition Code")]
        public string DispositionCode { get; set; }

        [DisplayName("Product Code")]
        public string ProductCode { get; set; }

        [DisplayName("Payor")]
        public string Payor { get; set; }

        [DisplayName("Payment Method")]
        public string PaymentMethod { get; set; }

        [DisplayName("Adjustment Reason")]
        public string AdjustmentReason { get; set; }

        public List<DetailDto> Details { get; set; }

    }
}
