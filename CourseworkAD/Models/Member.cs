using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CourseworkAD.Models
{
    public class Member
    {
        [Key]
        public int? MemberNumber { get; set; }

        public string? MemberLastName { get; set; }

        public string? MemberFirstName { get; set; }

        public string? MemberAddress { get; set; }

        public string? MemberDateOfBirth { get; set; }

        public int? MembershipCategoryNumber { get; set; }


        [ForeignKey("MembershipCategoryNumber")] public MembershipCategory MembershipCategories { get; set; }
    }
}

