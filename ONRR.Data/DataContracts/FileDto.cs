using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QEP.ONRR.Data.DataContracts
{
    public class FileDto
    {
        [DisplayName("File ID")]
        [Required]
        public int FileID { get; set; }

        [UIHint("FileStatusID")]
        [DisplayName("File Status ID")]
        [Required]
        public int FileStatusID { get; set; }

        [DisplayName("File Status")]
        public string FileStatus { get; set; }

        [DisplayName("Generation Date")]
        [Required]
        public DateTime GenerationDate { get; set; }

        [DisplayName("Accepted Date")]
        public DateTime? AcceptedDate { get; set; }

    }
}
