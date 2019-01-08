using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QEP.ONRR.Data.DataContracts
{

    public class AgreementTypesDto
    {
        [DisplayName("Agreement Type ID")]
        public int AgreementTypeID { get; set; }

        [DisplayName("Agreement Type")]
        [StringLength(50), Required]
        public string AgreementType { get; set; }
    }
}
