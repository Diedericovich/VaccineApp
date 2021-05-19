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
                //data aanvullen

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
                new VaccinationCenter { Id = 1, Name = "Basilik of Koekelmountain", Location = "1083 Brussel" },
                new VaccinationCenter { Id = 2, Name = "Dukestones Center", Location = "Sint-Veerleplein 11, 9000 Gent" },
                new VaccinationCenter { Id = 3, Name = "Sportpalace", Location = "Schijnpoortweg 119, 2170 Antwerpen" },
                new VaccinationCenter { Id = 4, Name = "Chocostory Center", Location = "Wijnzakstraat 2, 8000 Brugge" },
                new VaccinationCenter { Id = 5, Name = "Casino Center", Location = "Kursaal-Oosthelling 12, 8400 Oostende" },
                new VaccinationCenter { Id = 6, Name = "Barvaux Labyrint", Location = "Rue Basse Commène, 6940 Barvaux-sur-Ourthe" },
                new VaccinationCenter { Id = 7, Name = "Citadel Center", Location = "Route Merveilleuse 64, 5000 Namur" },
                new VaccinationCenter { Id = 8, Name = "Boverie Castle Center", Location = "Allée Frédéric Chopin, 4020 Liège" },
                new VaccinationCenter { Id = 9, Name = "Zwin Center", Location = "Zwin, Knokke-Heist" },
                new VaccinationCenter { Id = 10, Name = "OLV Center", Location = "Mariakerkeplein, 9030 Mariakerke" },
                new VaccinationCenter { Id = 11, Name = "Central Castle of Poeke", Location = "Kasteel van Poeke, 9880 Aalter" },
                new VaccinationCenter { Id = 12, Name = "Green Meise Garden", Location = "Nieuwelaan 38, 1860 Meise" },
                new VaccinationCenter { Id = 13, Name = "Technopolis Center", Location = "Technologielaan 1, 2800 Mechelen" }
                );
        }

        private static void BuildUsers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, FirstName = "Bond", Surname = "James", LoginId = 1, Address = "Koekoekstraat 70, 9090 Melle", BirthDate = new DateTime(1940, 01, 20) }
                );
        }

        private static void BuildVaccines(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vaccine>().HasData(
                new Vaccine { Id = 1, Name = "Eyetraxx", BodyPartId = 1, Description = "eases ability to track traces (cfr. Sniff with eyes)", CompanyId = 2 },
                new Vaccine { Id = 2, Name = "Smell ID Vaxx", BodyPartId = 2, Description = "improves detection of  smell and automatchmaking with scent library; library not included", CompanyId = 4 },
                new Vaccine { Id = 3, Name = "Bitexx", BodyPartId = 3, Description = "increases strength of bite to digest food more and faster", CompanyId = 6 },
                new Vaccine { Id = 4, Name = "Pluginixx", BodyPartId = 4, Description = "creates ability to mute sound selectively", CompanyId = 8 },
                new Vaccine { Id = 5, Name = "Scottish Tree Vaxx (L)", BodyPartId = 5, Description = "accumulates body hair and increases vertical strength in left arm", CompanyId = 1 },
                new Vaccine { Id = 6, Name = "Scottish Tree Vaxx (R) ", BodyPartId = 6, Description = "accumulates body hair and increases vertical strength in right arm", CompanyId = 3 },
                new Vaccine { Id = 7, Name = "Tattoo e-Way", BodyPartId = 7, Description = "absorbes scars, marks and heals wounds", CompanyId = 5 },
                new Vaccine { Id = 8, Name = "Shave & Sound Vaxx", BodyPartId = 8, Description = "regulates hairgrow and smoothness", CompanyId = 7 },

                new Vaccine { Id = 9, Name = "LaserPixx", BodyPartId = 1, Description = "improves eyesight in distance and sharpness (cfr. Hawkview)", CompanyId = 2 },
                new Vaccine { Id = 10, Name = "Filter Vaxx", BodyPartId = 2, Description = "creates ability to personalize filters in type of smells;  extendable with extern scent library", CompanyId = 4 },
                new Vaccine { Id = 11, Name = "Tasteroni XXL", BodyPartId = 3, Description = "increases size and strength of tongue; premedical advice required", CompanyId = 6 },
                new Vaccine { Id = 12, Name = "Smart Sound ID Vaxx", BodyPartId = 4, Description = "improves detection of  sound and automatchmaking with sound library; library not included", CompanyId = 8 },
                new Vaccine { Id = 13, Name = "Truck Trixx (L)", BodyPartId = 5, Description = "increases horizontal strength in left arm including titanium grip", CompanyId = 1 },
                new Vaccine { Id = 14, Name = "Truck Trixx (R)", BodyPartId = 6, Description = "increases horizontal strength in right arm including titanium grip", CompanyId = 3 },
                new Vaccine { Id = 15, Name = "Clean Skinnex", BodyPartId = 7, Description = "regulates hairgrow", CompanyId = 5 },
                new Vaccine { Id = 16, Name = "Bolt Lightning Vaxx", BodyPartId = 8, Description = "boosts  energy supply and coordinates physical waste for legmuscles", CompanyId = 7 },

                new Vaccine { Id = 17, Name = "IO2 Vaxx", BodyPartId = 1, Description = "muscles of eyeballs soften and become flexible and trainable using eyes seperately (cfr. The Cameleon Effect)", CompanyId = 2 },
                new Vaccine { Id = 18, Name = "Trump Vaxx", BodyPartId = 2, Description = "manipulates nostrils to lower or increase volume", CompanyId = 4 },
                new Vaccine { Id = 19, Name = "Fluo Secretional", BodyPartId = 3, Description = "ionizes production of saliva creating a more delicate substance usable for handy to industrial purposes", CompanyId = 6 },
                new Vaccine { Id = 20, Name = "Soundmaxx 5.0", BodyPartId = 4, Description = "ionizes earmembrane and earwax to manipulate soundwaves and add soundeffects", CompanyId = 8 },
                new Vaccine { Id = 21, Name = "WWE Arms (L)", BodyPartId = 5, Description = "recalibrates muscle tension and joint pressure for optimal wrestling condition in left arm", CompanyId = 1 },
                new Vaccine { Id = 22, Name = "WWE Arms (R)", BodyPartId = 6, Description = "recalibrates muscle tension and joint pressure for optimal wrestling condition in right arm", CompanyId = 3 },
                new Vaccine { Id = 23, Name = "Rainbow Vaxx", BodyPartId = 7, Description = "manipulates various aspects of skin colour", CompanyId = 5 },
                new Vaccine { Id = 24, Name = "Smart Geographical Cruiser", BodyPartId = 8, Description = "manipulates connectivity from nervesystem with brains; link to satellite not yet included", CompanyId = 7 },

                new Vaccine { Id = 25, Name = "REMEXX", BodyPartId = 1, Description = "stimulates the rapid-eye-movement in order to heal faster and improve transition from short-term to long-term memory", CompanyId = 2 },
                new Vaccine { Id = 26, Name = "DeHydra Vaxx", BodyPartId = 2, Description = "regulate hydration of nose and nasal cavity; avoid sinusitis, flue and other common diseases", CompanyId = 4 },
                new Vaccine { Id = 27, Name = "Teeth Barrier", BodyPartId = 3, Description = "strengthens the teethstructure making the teeth razor sharp ", CompanyId = 6 },
                new Vaccine { Id = 28, Name = "Dolby Atmos Vaxx", BodyPartId = 4, Description = "influences stimulus transfer from ear to brains improving soundexperience", CompanyId = 8 },
                new Vaccine { Id = 29, Name = "Iron Elbow Vaxx", BodyPartId = 5, Description = "strengthens tip of elbow", CompanyId = 1 },
                new Vaccine { Id = 30, Name = "XXtreme Righteous", BodyPartId = 6, Description = "makes right arm more rigid and sensitive to certain sounds (i.e. words, sentences, songs…); governance admission required", CompanyId = 3 },
                new Vaccine { Id = 31, Name = "NoTrans Scentexx", BodyPartId = 7, Description = "regulates intensity of transpiration and hydration", CompanyId = 5 },
                new Vaccine { Id = 32, Name = "Silver Trampolympixx", BodyPartId = 8, Description = "modifies blood pressure and veinthickness for concentrated explosions of mass energy boosts", CompanyId = 7 },

                new Vaccine { Id = 33, Name = "Scan Optixx", BodyPartId = 1, Description = "transforms iris and dark chamber into instant photo memories directly implemented into memory; extendable with HD", CompanyId = 2 },
                new Vaccine { Id = 34, Name = "Scentury 2000 Vaxx", BodyPartId = 2, Description = "increases stimulus transfer from nose to brains saving more scentdata in memory for certain period; period extendable per 25, 50 or 100 years ", CompanyId = 4 },
                new Vaccine { Id = 35, Name = "Voice Ovexx", BodyPartId = 3, Description = "influences jaw interior creating ability to modify the sound, quality, tone… of voice", CompanyId = 6 },
                new Vaccine { Id = 36, Name = "Enigma Pulsar Vaxx", BodyPartId = 4, Description = "improves detection in distance and frequency", CompanyId = 8 },
                new Vaccine { Id = 37, Name = "Write & Wrong Vaxx", BodyPartId = 5, Description = "ionizes the nervesystem into linking and fasten stimulus transfer from left arm to brains", CompanyId = 1 },
                new Vaccine { Id = 38, Name = "StarBoxx", BodyPartId = 6, Description = "recalibrates muscle tension and joint pressure for optimal coffeecup holding; discount for softwaredevelopers", CompanyId = 3 },
                new Vaccine { Id = 39, Name = "Cathedral FX 2.0", BodyPartId = 7, Description = "recalibrates muscle tension and volume for optimal bodysculpture", CompanyId = 5 },
                new Vaccine { Id = 40, Name = "Golden Lady Vaxx", BodyPartId = 8, Description = "increases production of pheromones and  smoothness skinmodification and auto hairgrowth management", CompanyId = 7 }
                );
        }

        private static void BuildVaccineCompanies(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VaccineCompany>().HasData(
                new VaccineCompany { Id = 1, Name = "BigEvilCo", IsEmaApproved = false, Country = "Russia" },
                new VaccineCompany { Id = 2, Name = "Pfizer-BioNTech", IsEmaApproved = true, Country = "United States of America" },
                new VaccineCompany { Id = 3, Name = "Janssen Pharmaceutica", IsEmaApproved = true, Country = "Belgium" },
                new VaccineCompany { Id = 4, Name = "Johnson & Johnson", IsEmaApproved = true, Country = "United States of America" },
                new VaccineCompany { Id = 5, Name = "AstraZeneca", IsEmaApproved = true, Country = "United Kingdom" },
                new VaccineCompany { Id = 6, Name = "Moderna", IsEmaApproved = false, Country = "United States of America" },
                new VaccineCompany { Id = 7, Name = "Sputnik", IsEmaApproved = false, Country = "Russia" },
                new VaccineCompany { Id = 8, Name = "Heineken", IsEmaApproved = false, Country = "Netherlands" }
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