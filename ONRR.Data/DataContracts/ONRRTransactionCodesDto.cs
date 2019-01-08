using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QEP.ONRR.Data.DataContracts
{

    public class ONRRTransactionCodesDto
    {
        [DisplayName("Transaction Code ID")]
        public int TransactionCodeID { get; set; }

        [DisplayName("ONRR Transaction Code")]
        [StringLength(5), Required]
        public string ONRRTransactionCode { get; set; }

        [DisplayName("Product Code")]
        [StringLength(5), Required]
        public string ProductCode { get; set; }

        [DisplayName("Disposition Code")]
        [StringLength(5), Required]
        public string DispositionCode { get; set; }
    }
}
