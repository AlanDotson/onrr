using System.ComponentModel;

namespace QEP.ONRR.Data.DataContracts
{
    public class CodeTableDto
    {
        [DisplayName("Table Name")]
        public int TableID { get; set; }

        [DisplayName("Table Name")]
        public string TableName { get; set; }

    }
}
