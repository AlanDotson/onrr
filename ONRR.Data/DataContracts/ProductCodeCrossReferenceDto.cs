using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QEP.ONRR.Data.DataContracts
{

    public class ProductCodeCrossReferenceDto
    {
        [DisplayName("Product Code ID")]
        public int ProductCodeID { get; set; }

        [DisplayName("ONRR Product Code")]
        [StringLength(15), Required]
        public string ONRRProductCode { get; set; }

        [DisplayName("QRA Major Product Code")]
        [StringLength(5), Required]
        public string QRAMajorProductCode { get; set; }
    }
}
