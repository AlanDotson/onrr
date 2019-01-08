using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QEP.ONRR.Data.DataContracts
{

    public class BIAClassificationsDto
    {
        [DisplayName("BIA Classification ID")]
        public int BIAClassificationID { get; set; }

        [DisplayName("BIA Classification")]
        [StringLength(150), Required]
        public string BIAClassification { get; set; }
    }
}
