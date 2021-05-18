using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Cryptography;
using System.Text;
using VaccineApp.Entities;

namespace VaccineApp
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            BuildAppointmentStatus(modelBuilder);
            BuildBodyParts(modelBuilder);
            BuildVaccineCompanies(modelBuilder);
            BuildVaccines(modelBuilder);
            BuildUsers(modelBuilder);
            BuildVaccinationCenters(modelBuilder);
            BuildLogins(modelBuilder);
            BuildAppointments(modelBuilder);
        }

        private static void BuildAppointments(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>().HasData(
                new Appointment { Id = 1, Date = new DateTime(2021, 07, 10), StatusId = 1, UserId = 1, LocationId = 1, VaccinationId = 1 }
                );
        }

        private static void BuildLogins(ModelBuilder modelBuilder)
        {
            var hmac = new HMACSHA512();
            modelBuilder.Entity<Login>().HasData(
                new Login { Id = 1, PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("test")), PasswordSalt = hmac.Key, Email = "test" }
                );
        }

        private static void BuildVaccinationCenters(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VaccinationCenter>().HasData(
                new VaccinationCenter { Id = 1, Name = "testCentre", Location = "location" }
                );
        }

        private static void BuildUsers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, FirstName = "test", Surname = "test", LoginId = 1, Address = "test", BirthDate = new DateTime(1990, 01, 20) }
                );
        }

        private static void BuildVaccines(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vaccine>().HasData(
                new Vaccine { Id = 1, Name = "TestVaxx", BodyPartId = 3, Description = "desctestest", CompanyId = 1 }
                );
        }

        private static void BuildVaccineCompanies(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VaccineCompany>().HasData(
                new VaccineCompany { Id = 1, Name = "BigEvilCo", IsEmaApproved = false, Country = "Russia" },
                new VaccineCompany { Id = 2, Name = "test", Country = "test" }
                );
        }

        private static void BuildBodyParts(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BodyPart>().HasData(
                new BodyPart { Id = 1, Name = "Eyes" },
                new BodyPart { Id = 2, Name = "Nose" },
                new BodyPart { Id = 3, Name = "Mouth" },
                new BodyPart { Id = 4, Name = "Ears" },
                new BodyPart { Id = 5, Name = "Left Arm" },
                new BodyPart { Id = 6, Name = "Right Arm" },
                new BodyPart { Id = 7, Name = "Torso" },
                new BodyPart { Id = 8, Name = "Legs" }
                );
        }

        private static void BuildAppointmentStatus(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppointmentStatus>().HasData(
                new AppointmentStatus { Id = 1, Status = "Approved" },
                new AppointmentStatus { Id = 2, Status = "Canceled" },
                new AppointmentStatus { Id = 3, Status = "Administered" }
                );
        }
    }
}