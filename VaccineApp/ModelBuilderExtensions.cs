using Microsoft.EntityFrameworkCore;
using VaccineApp.Entities;

namespace VaccineApp
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppointmentStatus>().HasData(
                new AppointmentStatus { Id = 1, Status = "Approved" },
                new AppointmentStatus { Id = 2, Status = "Canceled" },
                new AppointmentStatus { Id = 3, Status = "Administered" }
                );
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
            modelBuilder.Entity<Vaccine>().HasData(
                new Vaccine { Id = 1, Name = "TestVaxx", BodyPartId = 3, Description = "desctestest" });
        }
    }
}