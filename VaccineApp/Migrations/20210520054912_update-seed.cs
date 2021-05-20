using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VaccineApp.Migrations
{
    public partial class updateseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 98, 237, 55, 191, 198, 115, 79, 209, 128, 53, 215, 212, 160, 48, 183, 82, 200, 215, 153, 145, 163, 25, 100, 98, 118, 125, 240, 230, 100, 99, 216, 245, 106, 169, 187, 53, 189, 212, 205, 65, 107, 123, 236, 92, 21, 27, 130, 186, 191, 198, 255, 162, 160, 49, 127, 96, 186, 216, 17, 144, 16, 200, 73, 46 }, new byte[] { 20, 96, 59, 5, 93, 61, 15, 214, 207, 117, 33, 98, 157, 168, 17, 45, 210, 4, 50, 81, 50, 222, 25, 154, 69, 196, 161, 118, 175, 103, 83, 228, 191, 147, 131, 106, 219, 110, 80, 54, 225, 242, 126, 254, 194, 216, 216, 172, 175, 6, 73, 54, 174, 95, 235, 224, 217, 208, 194, 193, 66, 199, 165, 100, 201, 159, 246, 160, 85, 234, 123, 84, 177, 82, 242, 163, 89, 19, 129, 148, 40, 163, 112, 120, 225, 185, 218, 92, 37, 181, 7, 253, 64, 186, 111, 224, 10, 230, 126, 45, 40, 2, 189, 42, 247, 32, 238, 203, 249, 144, 249, 154, 57, 203, 140, 214, 122, 50, 178, 135, 10, 174, 53, 94, 41, 108, 51, 143 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "BirthDate", "FirstName", "Surname" },
                values: new object[] { "Koekoekstraat 70, 9090 Melle", new DateTime(1940, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bond", "James" });

            migrationBuilder.UpdateData(
                table: "VaccinationCenters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Location", "Name" },
                values: new object[] { "1083 Brussel", "Basilik of Koekelmountain" });

            migrationBuilder.UpdateData(
                table: "VaccinationCenters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Sint-Veerleplein 11, 9000 Gent", "Dukestones Center" });

            migrationBuilder.UpdateData(
                table: "VaccinationCenters",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Schijnpoortweg 119, 2170 Antwerpen", "Sportpalace" });

            migrationBuilder.UpdateData(
                table: "VaccinationCenters",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Wijnzakstraat 2, 8000 Brugge", "Chocostory Center" });

            migrationBuilder.UpdateData(
                table: "VaccinationCenters",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Kursaal-Oosthelling 12, 8400 Oostende", "Casino Center" });

            migrationBuilder.UpdateData(
                table: "VaccinationCenters",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Rue Basse Commène, 6940 Barvaux-sur-Ourthe", "Barvaux Labyrint" });

            migrationBuilder.InsertData(
                table: "VaccinationCenters",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[,]
                {
                    { 7, "Route Merveilleuse 64, 5000 Namur", "Citadel Center" },
                    { 8, "Allée Frédéric Chopin, 4020 Liège", "Boverie Castle Center" },
                    { 9, "Zwin, Knokke-Heist", "Zwin Center" },
                    { 10, "Mariakerkeplein, 9030 Mariakerke", "OLV Center" },
                    { 11, "Kasteel van Poeke, 9880 Aalter", "Central Castle of Poeke" },
                    { 12, "Nieuwelaan 38, 1860 Meise", "Green Meise Garden" },
                    { 13, "Technologielaan 1, 2800 Mechelen", "Technopolis Center" }
                });

            migrationBuilder.UpdateData(
                table: "VaccineCompanies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Country", "IsEmaApproved", "Name" },
                values: new object[] { "United States of America", true, "Pfizer-BioNTech" });

            migrationBuilder.InsertData(
                table: "VaccineCompanies",
                columns: new[] { "Id", "Country", "IsEmaApproved", "Name" },
                values: new object[,]
                {
                    { 5, "United Kingdom", true, "AstraZeneca" },
                    { 6, "United States of America", false, "Moderna" },
                    { 7, "Russia", false, "Sputnik" },
                    { 8, "Netherlands", false, "Heineken" },
                    { 3, "Belgium", true, "Janssen Pharmaceutica" },
                    { 4, "United States of America", true, "Johnson & Johnson" }
                });

            migrationBuilder.UpdateData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BodyPartId", "CompanyId", "Description", "Name" },
                values: new object[] { 1, 2, "eases ability to track traces (cfr. Sniff with eyes)", "Eyetraxx" });

            migrationBuilder.UpdateData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Name" },
                values: new object[] { "accumulates body hair and increases vertical strength in left arm", "Scottish Tree Vaxx (L)" });

            migrationBuilder.UpdateData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BodyPartId", "CompanyId", "Description", "Name" },
                values: new object[] { 1, 2, "improves eyesight in distance and sharpness (cfr. Hawkview)", "LaserPixx" });

            migrationBuilder.InsertData(
                table: "Vaccines",
                columns: new[] { "Id", "BodyPartId", "CompanyId", "Description", "Name" },
                values: new object[,]
                {
                    { 37, 5, 1, "ionizes the nervesystem into linking and fasten stimulus transfer from left arm to brains", "Write & Wrong Vaxx" },
                    { 33, 1, 2, "transforms iris and dark chamber into instant photo memories directly implemented into memory; extendable with HD", "Scan Optixx" },
                    { 29, 5, 1, "strengthens tip of elbow", "Iron Elbow Vaxx" },
                    { 25, 1, 2, "stimulates the rapid-eye-movement in order to heal faster and improve transition from short-term to long-term memory", "REMEXX" },
                    { 21, 5, 1, "recalibrates muscle tension and joint pressure for optimal wrestling condition in left arm", "WWE Arms (L)" },
                    { 17, 1, 2, "muscles of eyeballs soften and become flexible and trainable using eyes seperately (cfr. The Cameleon Effect)", "IO2 Vaxx" },
                    { 13, 5, 1, "increases horizontal strength in left arm including titanium grip", "Truck Trixx (L)" }
                });

            migrationBuilder.UpdateData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BodyPartId", "CompanyId", "Description", "Name" },
                values: new object[] { 2, 4, "improves detection of  smell and automatchmaking with scent library; library not included", "Smell ID Vaxx" });

            migrationBuilder.UpdateData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BodyPartId", "CompanyId", "Description", "Name" },
                values: new object[] { 3, 6, "increases strength of bite to digest food more and faster", "Bitexx" });

            migrationBuilder.UpdateData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BodyPartId", "CompanyId", "Description", "Name" },
                values: new object[] { 4, 8, "creates ability to mute sound selectively", "Pluginixx" });

            migrationBuilder.UpdateData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BodyPartId", "CompanyId", "Description", "Name" },
                values: new object[] { 6, 3, "accumulates body hair and increases vertical strength in right arm", "Scottish Tree Vaxx (R) " });

            migrationBuilder.UpdateData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BodyPartId", "CompanyId", "Description", "Name" },
                values: new object[] { 7, 5, "absorbes scars, marks and heals wounds", "Tattoo e-Way" });

            migrationBuilder.UpdateData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BodyPartId", "CompanyId", "Description", "Name" },
                values: new object[] { 8, 7, "regulates hairgrow and smoothness", "Shave & Sound Vaxx" });

            migrationBuilder.InsertData(
                table: "Vaccines",
                columns: new[] { "Id", "BodyPartId", "CompanyId", "Description", "Name" },
                values: new object[,]
                {
                    { 10, 2, 4, "creates ability to personalize filters in type of smells;  extendable with extern scent library", "Filter Vaxx" },
                    { 28, 4, 8, "influences stimulus transfer from ear to brains improving soundexperience", "Dolby Atmos Vaxx" },
                    { 20, 4, 8, "ionizes earmembrane and earwax to manipulate soundwaves and add soundeffects", "Soundmaxx 5.0" },
                    { 12, 4, 8, "improves detection of  sound and automatchmaking with sound library; library not included", "Smart Sound ID Vaxx" },
                    { 40, 8, 7, "increases production of pheromones and  smoothness skinmodification and auto hairgrowth management", "Golden Lady Vaxx" },
                    { 32, 8, 7, "modifies blood pressure and veinthickness for concentrated explosions of mass energy boosts", "Silver Trampolympixx" },
                    { 24, 8, 7, "manipulates connectivity from nervesystem with brains; link to satellite not yet included", "Smart Geographical Cruiser" },
                    { 16, 8, 7, "boosts  energy supply and coordinates physical waste for legmuscles", "Bolt Lightning Vaxx" },
                    { 22, 6, 3, "recalibrates muscle tension and joint pressure for optimal wrestling condition in right arm", "WWE Arms (R)" },
                    { 35, 3, 6, "influences jaw interior creating ability to modify the sound, quality, tone… of voice", "Voice Ovexx" },
                    { 38, 6, 3, "recalibrates muscle tension and joint pressure for optimal coffeecup holding; discount for softwaredevelopers", "StarBoxx" },
                    { 27, 3, 6, "strengthens the teethstructure making the teeth razor sharp ", "Teeth Barrier" },
                    { 11, 3, 6, "increases size and strength of tongue; premedical advice required", "Tasteroni XXL" },
                    { 36, 4, 8, "improves detection in distance and frequency", "Enigma Pulsar Vaxx" },
                    { 39, 7, 5, "recalibrates muscle tension and volume for optimal bodysculpture", "Cathedral FX 2.0" },
                    { 31, 7, 5, "regulates intensity of transpiration and hydration", "NoTrans Scentexx" },
                    { 23, 7, 5, "manipulates various aspects of skin colour", "Rainbow Vaxx" },
                    { 15, 7, 5, "regulates hairgrow", "Clean Skinnex" },
                    { 30, 6, 3, "makes right arm more rigid and sensitive to certain sounds (i.e. words, sentences, songs…); governance admission required", "XXtreme Righteous" },
                    { 34, 2, 4, "increases stimulus transfer from nose to brains saving more scentdata in memory for certain period; period extendable per 25, 50 or 100 years ", "Scentury 2000 Vaxx" },
                    { 26, 2, 4, "regulate hydration of nose and nasal cavity; avoid sinusitis, flue and other common diseases", "DeHydra Vaxx" },
                    { 18, 2, 4, "manipulates nostrils to lower or increase volume", "Trump Vaxx" },
                    { 19, 3, 6, "ionizes production of saliva creating a more delicate substance usable for handy to industrial purposes", "Fluo Secretional" },
                    { 14, 6, 3, "increases horizontal strength in right arm including titanium grip", "Truck Trixx (R)" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VaccinationCenters",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "VaccinationCenters",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "VaccinationCenters",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "VaccinationCenters",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "VaccinationCenters",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "VaccinationCenters",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "VaccinationCenters",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "VaccineCompanies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VaccineCompanies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VaccineCompanies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VaccineCompanies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "VaccineCompanies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "VaccineCompanies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 213, 22, 126, 29, 188, 65, 215, 80, 90, 18, 66, 248, 39, 16, 176, 146, 253, 12, 58, 85, 85, 63, 253, 253, 106, 148, 32, 194, 110, 140, 25, 25, 25, 74, 145, 96, 212, 135, 216, 212, 55, 197, 234, 223, 195, 188, 211, 89, 9, 100, 33, 35, 221, 146, 89, 92, 249, 255, 88, 122, 233, 165, 166, 124 }, new byte[] { 28, 183, 40, 177, 249, 199, 52, 38, 134, 69, 58, 49, 157, 22, 2, 149, 90, 18, 71, 139, 112, 142, 64, 164, 191, 218, 227, 58, 193, 14, 161, 90, 109, 38, 170, 145, 66, 213, 130, 44, 84, 84, 237, 166, 116, 169, 0, 216, 71, 27, 209, 228, 121, 247, 242, 213, 58, 178, 240, 82, 130, 131, 190, 18, 160, 90, 131, 236, 218, 114, 101, 23, 161, 32, 99, 60, 34, 190, 109, 165, 40, 189, 214, 194, 129, 138, 0, 168, 239, 7, 210, 214, 111, 167, 43, 33, 25, 245, 49, 131, 0, 236, 33, 206, 158, 37, 46, 47, 30, 59, 102, 18, 87, 200, 146, 42, 166, 68, 151, 198, 28, 51, 165, 72, 190, 88, 35, 147 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "BirthDate", "FirstName", "Surname" },
                values: new object[] { "test", new DateTime(1990, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "test", "test" });

            migrationBuilder.UpdateData(
                table: "VaccinationCenters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Location", "Name" },
                values: new object[] { "location", "testCentre" });

            migrationBuilder.UpdateData(
                table: "VaccinationCenters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Location", "Name" },
                values: new object[] { "location", "VaxxCenter" });

            migrationBuilder.UpdateData(
                table: "VaccinationCenters",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Location", "Name" },
                values: new object[] { "location", "PokeCenter" });

            migrationBuilder.UpdateData(
                table: "VaccinationCenters",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Location", "Name" },
                values: new object[] { "location", "Cent er" });

            migrationBuilder.UpdateData(
                table: "VaccinationCenters",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Location", "Name" },
                values: new object[] { "location", "Help" });

            migrationBuilder.UpdateData(
                table: "VaccinationCenters",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Location", "Name" },
                values: new object[] { "location", "IkKanGeenLeukeNaamMeerVinden" });

            migrationBuilder.UpdateData(
                table: "VaccineCompanies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Country", "IsEmaApproved", "Name" },
                values: new object[] { "test", false, "test" });

            migrationBuilder.UpdateData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BodyPartId", "CompanyId", "Description", "Name" },
                values: new object[] { 3, 1, "desctestest", "TestVaxx" });

            migrationBuilder.UpdateData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BodyPartId", "CompanyId", "Description", "Name" },
                values: new object[] { 1, 1, "desctestest", "EyeVax" });

            migrationBuilder.UpdateData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BodyPartId", "CompanyId", "Description", "Name" },
                values: new object[] { 2, 1, "desctestest", "NoseVax" });

            migrationBuilder.UpdateData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BodyPartId", "CompanyId", "Description", "Name" },
                values: new object[] { 5, 1, "desctestest", "LeftArmVax" });

            migrationBuilder.UpdateData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Name" },
                values: new object[] { "desctestest", "LeftArmVax2" });

            migrationBuilder.UpdateData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BodyPartId", "CompanyId", "Description", "Name" },
                values: new object[] { 7, 1, "desctestest", "TorsoVax" });

            migrationBuilder.UpdateData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BodyPartId", "CompanyId", "Description", "Name" },
                values: new object[] { 8, 1, "desctestest", "LegsVax" });

            migrationBuilder.UpdateData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BodyPartId", "CompanyId", "Description", "Name" },
                values: new object[] { 6, 1, "desctestest", "RightArmVax" });

            migrationBuilder.UpdateData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BodyPartId", "CompanyId", "Description", "Name" },
                values: new object[] { 6, 1, "desctestest", "RightArmVax2" });
        }
    }
}
