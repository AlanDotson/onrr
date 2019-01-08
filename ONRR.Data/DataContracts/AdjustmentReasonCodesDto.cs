using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QEP.ONRR.Data.DataContracts
{
    public class AdjustmentReasonCodesDto
    {
        [DisplayName("Adjustment Reason Code ID")]
        public int AdjustmentReasonCodeID { get; set; }

        [DisplayName("Adjustment Reason Code")]
        [StringLength(2), Required]
        public string AdjustmentReasonCode { get; set; }

        [DisplayName("Adjustment Reason")]
        [StringLength(60), Required]
        public string AdjustmentReason { get; set; }
    }
}
