using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LearningVersion6.Models
{
    public class Year3DbContext : DbContext
    {
        public DbSet<Actor> Actors { get; set; }
        public DbSet<DVDCategory> DVDCategories { get; set; }
        public DbSet<DVDTitle> DVDTitles { get; set; }
        public DbSet<DVDCopy> DVDCopies { get; set; }
        public DbSet<LoanType> LoanTypes { get; set; }
        public DbSet<MembershipCategory> MembershipCategories { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Studio> Studios { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<CastMember> CastMembers { get; set; }


        public Year3DbContext(DbContextOptions<Year3DbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}