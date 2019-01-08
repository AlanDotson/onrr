using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QEP.ONRR.Data.DataContracts
{

    public class AgreementClassificationsDto
    {
        [DisplayName("Agreement Classification ID")]
        public int AgreementClassificationID { get; set; }

        [DisplayName("Agreement Classification")]
        [StringLength(50), Required]
        public string AgreementClassification { get; set; }
    }
}
