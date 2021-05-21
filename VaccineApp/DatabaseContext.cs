namespace VaccineApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Entities;
    using Microsoft.EntityFrameworkCore;

    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Login> Logins { get; set; }

        public DbSet<Appointment> Appointments { get; set; }

        public DbSet<AppointmentStatus> AppointmentStatuses { get; set; }
        public DbSet<VaccineCompany> VaccineCompanies { get; set; }

        public DbSet<BodyPart> BodyParts { get; set; }

        public DbSet<VaccinationCenter> VaccinationCenters { get; set; }

        public DbSet<Vaccine> Vaccines { get; set; }

        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            modelBuilder.Entity<User>(x => { x.HasIndex(y => y.Email).IsUnique(); });
        }
    }
}