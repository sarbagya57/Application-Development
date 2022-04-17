
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CourseworkAD.Models
{
    public class Loan
    {
        [Key]
        public int? LoanNumber { get; set; }

        public string? DateOut { get; set; }

        public string? DateDue { get; set; }

        public string? DateReturned { get; set; }

        public string? LoanTypeNumber { get; set; }

        public string? MemberNumber { get; set; }

        public string? CopyNumber { get; set; }

        [ForeignKey("LoanTypeNumber")] public LoanType LoanType { get; set; }

        [ForeignKey("MemberNumber")] public Member Member { get; set; }

        [ForeignKey("CopyNumber")] public DVDCopy DVDCopy { get; set; }

    }
}
