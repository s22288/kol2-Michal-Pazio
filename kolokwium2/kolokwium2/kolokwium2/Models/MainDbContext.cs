using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2.Models
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions options) : base(options)
        {

        }

        protected MainDbContext()
        {
        }
        // zamienic zgodnie ze wzorem 

        //public DbSet<FireFighter> FireFighters { get; set; }
        //public DbSet<Action> Actions { get; set; }
        //public DbSet<Firefighter_Action> Firefighter_Actions { get; set; }
        //public DbSet<FireTruck_Action> FireTruck_Actions { get; set; }
        //public DbSet<FireTruck> FireTrucks { get; set; }

        public DbSet<File> Files { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=db-mssql;Initial Catalog=2019SBD;Integrated Security=True");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // zamienic zgodnie ze wzorem
            
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<File>(p =>
            {
                p.HasKey(e => e.FieleID);
                p.HasKey(e => e.TeamID);
                p.HasOne(e => e.Team).WithMany(e => e.Files).HasForeignKey(e => e.TeamID);
                p.Property(e => e.FileName).HasMaxLength(100);
                p.Property(e => e.FileExtension).HasMaxLength(4);
                p.Property(e => e.FileSize);
                
            });
            modelBuilder.Entity<Team>(p =>
            {
                p.HasKey(e => e.TeamID);
                p.HasOne(e => e.Organization).WithMany(e => e.Teams).HasForeignKey(e => e.OrganizationID);
                p.Property(e => e.TeamName).HasMaxLength(50);
                p.Property(e => e.TeamDescription).HasMaxLength(500);
             
     
            });
            modelBuilder.Entity<Organization>(p =>
            {
                p.HasKey(e => e.OrganizationID);
                p.Property(e => e.OrganizationName).HasMaxLength(100);
                p.Property(e => e.OrganizationDomain).HasMaxLength(50);


            });

            modelBuilder.Entity<Member>(p =>
            {
                p.HasKey(e => e.MemberID);
                p.HasOne(e => e.Organization).WithMany(e => e.Members).HasForeignKey(e => e.OrganizationID);
                p.Property(e => e.MemberName).HasMaxLength(20);
                p.Property(e => e.MemberSurname).HasMaxLength(20);
                p.Property(e => e.MemberNickName).HasMaxLength(20);


            });
            modelBuilder.Entity<Membership>(p =>
            {
                p.HasKey(e => e.MemberID);
                p.HasKey(e => e.TeamID);
                p.Property(e => e.MembershipDate);
                p.HasOne(e => e.Team).WithMany(e => e.Memberships).HasForeignKey(e => e.TeamID);
                p.HasOne(e => e.Member).WithMany(e => e.Memberships).HasForeignKey(e => e.MemberID);
                
            });
            
                


            //modelBuilder.Entity<FireFighter>(p =>
            //{
            //    p.HasKey(e => e.IdFirefighter);
            //    p.Property(e => e.FirstName).IsRequired().HasMaxLength(30);
            //    p.Property(e => e.LastName).IsRequired().HasMaxLength(50);
            //    p.HasData(
            //        new FireFighter { IdFirefighter = 1, FirstName = "Jan", LastName = "Kowalski" },
            //        new FireFighter { IdFirefighter = 2, FirstName = "Jacek", LastName = "Nowakowski" }
            //        );

            //});
            //modelBuilder.Entity<Action>(p =>
            //{
            //    p.HasKey(e => e.IdAction);
            //    p.Property(e => e.StartTime).IsRequired();
            //    p.Property(e => e.EndTime).IsRequired();
            //    p.Property(e => e.NeedSecialEquipment).IsRequired();

            //    p.HasData(
            //        new Action { IdAction = 1, StartTime = DateTime.Parse("2000-01-01"), EndTime = DateTime.Parse("2000-01-03"), NeedSecialEquipment = true },
            //        new Action { IdAction = 2, StartTime = DateTime.Parse("2000-03-12"), EndTime = DateTime.Parse("2000-04-20"), NeedSecialEquipment = true }
            //        );

            //});
            //modelBuilder.Entity<Firefighter_Action>(p =>
            //{
            //    p.HasKey(e => e.IdAction);
            //    p.HasKey(e => e.IdFirefighter);
            //    p.HasOne(e => e.FireFighter).WithMany(e => e.Firefighter_Actions).HasForeignKey(e => e.IdFirefighter);
            //    p.HasOne(e => e.Action).WithMany(e => e.Firefighter_Actions).HasForeignKey(e => e.IdAction);
            //    p.HasData(

            //      new Firefighter_Action { IdAction = 1, IdFirefighter = 1 },
            //      new Firefighter_Action { IdAction = 2, IdFirefighter = 2 }

            //       );
            //    modelBuilder.Entity<FireTruck_Action>(p =>
            //    {
            //        p.HasKey(e => e.IdFireturck);
            //        p.HasKey(e => e.IdAction);
            //        p.Property(e => e.AssignmentDate).IsRequired();
            //        p.HasOne(e => e.Action).WithMany(e => e.FireTruck_Action).HasForeignKey(e => e.IdAction);
            //        p.HasOne(e => e.FireTruck).WithMany(e => e.FireTruck_Actions).HasForeignKey(e => e.IdFireturck);
            //        p.HasData(
            //            new FireTruck_Action { IdFireturck = 1, IdAction = 1, AssignmentDate = DateTime.Parse("2000-01-01") },
            //            new FireTruck_Action { IdFireturck = 1, IdAction = 2, AssignmentDate = DateTime.Parse("2000-03-12") }
            //            );
            //    });
            //    modelBuilder.Entity<FireTruck>(p =>
            //    {
            //        p.HasKey(e => e.IdFiretruck);
            //        p.Property(e => e.OperationNumber).IsRequired().HasMaxLength(10);
            //        p.Property(e => e.SpecialEquipment).IsRequired();
            //        p.HasData(
            //            new FireTruck { IdFiretruck = 1, OperationNumber = "123", SpecialEquipment = true },
            //            new FireTruck { IdFiretruck = 2, OperationNumber = "567", SpecialEquipment = true }
            //            );
            //    });

            //});
            //  modelBuilder.Entity<>
        }
    }
}
