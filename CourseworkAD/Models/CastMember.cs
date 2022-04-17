using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CourseworkAD.Models
{
    public class CastMember
    {
        [Key]
        public int DVDNumber { get; set; }

        public int ActorNumber { get; set; }

        [ForeignKey("DVDNumber")] public DVDTitle DVDTitles { get; set; }

        [ForeignKey("ActorNumber")] public Actor Actors { get; set; }
    }
}
