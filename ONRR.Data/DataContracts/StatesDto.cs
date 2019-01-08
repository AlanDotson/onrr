using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QEP.ONRR.Data.DataContracts
{

    public class StatesDto
    {
        [DisplayName("State Code")]
        [StringLength(2, MinimumLength = 2), Required]
        public string StateCode { get; set; }

        [DisplayName("State")]
        [StringLength(50), Required]
        public string State { get; set; }

        [DisplayName("Pressure Base")]
        [Required]
        public decimal PressureBase { get; set; }

    }
}
