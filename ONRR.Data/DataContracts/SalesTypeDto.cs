using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QEP.ONRR.Data.DataContracts
{
    public class SalesTypeDto
    {

        [DisplayName("Sales Type ID")]
        public int SalesTypeID { get; set; }

        [DisplayName("Sales Type")]
        [StringLength(50), Required]
        public string SalesType { get; set; }

    }
}
