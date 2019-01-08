using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QEP.ONRR.Data.DataContracts
{

    public class LeaseClassificationsDto
    {
        [DisplayName("Lease Classification ID")]
        public int LeaseClassificationID { get; set; }

        [DisplayName("QLS Classification ID")]
        [StringLength(10), Required]
        public string QLSClassificationID { get; set; }

        [DisplayName("Classification")]
        [StringLength(250), Required]
        public string Classification { get; set; }

        [DisplayName("Active")]
        public bool Active { get; set; }
    }
}
