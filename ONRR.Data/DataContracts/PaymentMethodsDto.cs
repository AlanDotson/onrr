using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QEP.ONRR.Data.DataContracts
{

    public class PaymentMethodsDto
    {
        [DisplayName("Payment Method ID")]
        public int PaymentMethodID { get; set; }

        [DisplayName("Payment Method")]
        [StringLength(60), Required]
        public string PaymentMethod { get; set; }
    }
}
