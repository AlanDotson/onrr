using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QEP.ONRR.Data.DataContracts
{

    public class PayorCodesDto
    {
        [DisplayName("Payor Code ID")]
        public int PayorCodeID { get; set; }

        [DisplayName("Payor Code")]
        [StringLength(5), Required]
        public string PayorCode { get; set; }

        [DisplayName("Payor")]
        [StringLength(60), Required]
        public string Payor { get; set; }
    }
}
