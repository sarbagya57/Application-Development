using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CourseworkAD.Models
{
    public class DVDCopy
    {
        [Key]
        public int? CopyNumber { get; set; }
        public string? DVDNumber { get; set; }
        public string? DatePurchased { get; set; }

        public int? DVDNumber { get; set; }


        [ForeignKey("DVDNumber")] 
        public Producer Producers { get; set; }
    }
}
