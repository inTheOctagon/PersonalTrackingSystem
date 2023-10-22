using Microsoft.EntityFrameworkCore;
using PersonalTrackingSystem.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTrackingSystem.DAL.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<PersonalBasis> personalBases { get; set; }
        public DbSet<PersonalEducation> personalEducations { get; set; }
        public DbSet<PersonalFile> personalFiles { get; set; }
        public DbSet<PersonalLeave> personalLeaves { get; set; }
        public DbSet<PersonalPosition> personalPositions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-F4M3HC0\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Initial Catalog=PersonalTrackingSystem.Db; Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<PersonalBasis>()
                .HasOne(pb => pb.PersonalFile)
                .WithOne(pf => pf.PersonalBasis)
                .HasForeignKey<PersonalFile>(pf => pf.PersonalID);
            mb.Entity<PersonalBasis>()
                .HasOne(pb => pb.PersonalEducation)
                .WithOne(pf => pf.PersonalBasis)
                .HasForeignKey<PersonalEducation>(pf => pf.PersonalID);
            mb.Entity<PersonalBasis>()
                .HasOne(pb => pb.PersonalPosition)
                .WithOne(pf => pf.PersonalBasis)
                .HasForeignKey<PersonalPosition>(pf => pf.PersonalID);
            mb.Entity<PersonalBasis>()
                .HasMany(pb => pb.PersonalLeaves)
                .WithOne(pf => pf.PersonalBasis)
                .HasForeignKey(pf => pf.PersonalID);
        }
    }
}
