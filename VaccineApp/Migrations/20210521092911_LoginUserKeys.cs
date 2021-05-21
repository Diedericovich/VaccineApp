﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VaccineApp.Migrations
{
    public partial class LoginUserKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppointmentStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BodyParts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyParts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.Email);
                });

            migrationBuilder.CreateTable(
                name: "VaccinationCenters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccinationCenters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VaccineCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsEmaApproved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccineCompanies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Logins_Email",
                        column: x => x.Email,
                        principalTable: "Logins",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vaccines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    BodyPartId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vaccines_BodyParts_BodyPartId",
                        column: x => x.BodyPartId,
                        principalTable: "BodyParts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vaccines_VaccineCompanies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "VaccineCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    VaccinationId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_AppointmentStatuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "AppointmentStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointments_VaccinationCenters_LocationId",
                        column: x => x.LocationId,
                        principalTable: "VaccinationCenters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointments_Vaccines_VaccinationId",
                        column: x => x.VaccinationId,
                        principalTable: "Vaccines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AppointmentStatuses",
                columns: new[] { "Id", "Status" },
                values: new object[,]
                {
                    { 1, "Scheduled" },
                    { 2, "Canceled" },
                    { 3, "Completed" }
                });

            migrationBuilder.InsertData(
                table: "BodyParts",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 7, "Torso" },
                    { 6, "Right Arm" },
                    { 5, "Left Arm" },
                    { 8, "Legs" },
                    { 3, "Mouth" },
                    { 2, "Nose" },
                    { 1, "Eyes" },
                    { 4, "Ears" }
                });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "Email", "PasswordHash", "PasswordSalt" },
                values: new object[,]
                {
                    { "test1", new byte[] { 30, 2, 148, 20, 115, 149, 11, 131, 144, 235, 13, 69, 226, 115, 101, 148, 47, 113, 2, 186, 102, 189, 147, 75, 10, 190, 223, 70, 225, 49, 250, 216, 182, 220, 244, 173, 49, 16, 32, 142, 112, 122, 12, 133, 9, 202, 33, 117, 105, 115, 4, 32, 114, 162, 103, 118, 21, 181, 118, 113, 108, 108, 251, 142 }, new byte[] { 43, 3, 250, 153, 16, 31, 19, 131, 32, 97, 78, 82, 184, 255, 79, 29, 40, 76, 18, 139, 15, 53, 85, 23, 245, 129, 144, 86, 253, 90, 70, 206, 165, 45, 41, 94, 21, 153, 124, 13, 18, 58, 253, 246, 79, 162, 230, 175, 247, 57, 177, 4, 13, 17, 195, 105, 150, 222, 222, 1, 162, 48, 109, 140, 251, 213, 22, 68, 80, 226, 226, 216, 40, 238, 115, 23, 84, 164, 156, 191, 122, 156, 80, 253, 190, 0, 74, 91, 195, 196, 34, 104, 136, 214, 188, 167, 72, 252, 66, 208, 189, 175, 209, 51, 101, 210, 24, 237, 183, 52, 53, 143, 36, 78, 77, 33, 196, 74, 69, 189, 187, 255, 205, 7, 120, 212, 233, 55 } },
                    { "test2", new byte[] { 30, 2, 148, 20, 115, 149, 11, 131, 144, 235, 13, 69, 226, 115, 101, 148, 47, 113, 2, 186, 102, 189, 147, 75, 10, 190, 223, 70, 225, 49, 250, 216, 182, 220, 244, 173, 49, 16, 32, 142, 112, 122, 12, 133, 9, 202, 33, 117, 105, 115, 4, 32, 114, 162, 103, 118, 21, 181, 118, 113, 108, 108, 251, 142 }, new byte[] { 43, 3, 250, 153, 16, 31, 19, 131, 32, 97, 78, 82, 184, 255, 79, 29, 40, 76, 18, 139, 15, 53, 85, 23, 245, 129, 144, 86, 253, 90, 70, 206, 165, 45, 41, 94, 21, 153, 124, 13, 18, 58, 253, 246, 79, 162, 230, 175, 247, 57, 177, 4, 13, 17, 195, 105, 150, 222, 222, 1, 162, 48, 109, 140, 251, 213, 22, 68, 80, 226, 226, 216, 40, 238, 115, 23, 84, 164, 156, 191, 122, 156, 80, 253, 190, 0, 74, 91, 195, 196, 34, 104, 136, 214, 188, 167, 72, 252, 66, 208, 189, 175, 209, 51, 101, 210, 24, 237, 183, 52, 53, 143, 36, 78, 77, 33, 196, 74, 69, 189, 187, 255, 205, 7, 120, 212, 233, 55 } },
                    { "test3", new byte[] { 30, 2, 148, 20, 115, 149, 11, 131, 144, 235, 13, 69, 226, 115, 101, 148, 47, 113, 2, 186, 102, 189, 147, 75, 10, 190, 223, 70, 225, 49, 250, 216, 182, 220, 244, 173, 49, 16, 32, 142, 112, 122, 12, 133, 9, 202, 33, 117, 105, 115, 4, 32, 114, 162, 103, 118, 21, 181, 118, 113, 108, 108, 251, 142 }, new byte[] { 43, 3, 250, 153, 16, 31, 19, 131, 32, 97, 78, 82, 184, 255, 79, 29, 40, 76, 18, 139, 15, 53, 85, 23, 245, 129, 144, 86, 253, 90, 70, 206, 165, 45, 41, 94, 21, 153, 124, 13, 18, 58, 253, 246, 79, 162, 230, 175, 247, 57, 177, 4, 13, 17, 195, 105, 150, 222, 222, 1, 162, 48, 109, 140, 251, 213, 22, 68, 80, 226, 226, 216, 40, 238, 115, 23, 84, 164, 156, 191, 122, 156, 80, 253, 190, 0, 74, 91, 195, 196, 34, 104, 136, 214, 188, 167, 72, 252, 66, 208, 189, 175, 209, 51, 101, 210, 24, 237, 183, 52, 53, 143, 36, 78, 77, 33, 196, 74, 69, 189, 187, 255, 205, 7, 120, 212, 233, 55 } },
                    { "test4", new byte[] { 30, 2, 148, 20, 115, 149, 11, 131, 144, 235, 13, 69, 226, 115, 101, 148, 47, 113, 2, 186, 102, 189, 147, 75, 10, 190, 223, 70, 225, 49, 250, 216, 182, 220, 244, 173, 49, 16, 32, 142, 112, 122, 12, 133, 9, 202, 33, 117, 105, 115, 4, 32, 114, 162, 103, 118, 21, 181, 118, 113, 108, 108, 251, 142 }, new byte[] { 43, 3, 250, 153, 16, 31, 19, 131, 32, 97, 78, 82, 184, 255, 79, 29, 40, 76, 18, 139, 15, 53, 85, 23, 245, 129, 144, 86, 253, 90, 70, 206, 165, 45, 41, 94, 21, 153, 124, 13, 18, 58, 253, 246, 79, 162, 230, 175, 247, 57, 177, 4, 13, 17, 195, 105, 150, 222, 222, 1, 162, 48, 109, 140, 251, 213, 22, 68, 80, 226, 226, 216, 40, 238, 115, 23, 84, 164, 156, 191, 122, 156, 80, 253, 190, 0, 74, 91, 195, 196, 34, 104, 136, 214, 188, 167, 72, 252, 66, 208, 189, 175, 209, 51, 101, 210, 24, 237, 183, 52, 53, 143, 36, 78, 77, 33, 196, 74, 69, 189, 187, 255, 205, 7, 120, 212, 233, 55 } },
                    { "test5", new byte[] { 30, 2, 148, 20, 115, 149, 11, 131, 144, 235, 13, 69, 226, 115, 101, 148, 47, 113, 2, 186, 102, 189, 147, 75, 10, 190, 223, 70, 225, 49, 250, 216, 182, 220, 244, 173, 49, 16, 32, 142, 112, 122, 12, 133, 9, 202, 33, 117, 105, 115, 4, 32, 114, 162, 103, 118, 21, 181, 118, 113, 108, 108, 251, 142 }, new byte[] { 43, 3, 250, 153, 16, 31, 19, 131, 32, 97, 78, 82, 184, 255, 79, 29, 40, 76, 18, 139, 15, 53, 85, 23, 245, 129, 144, 86, 253, 90, 70, 206, 165, 45, 41, 94, 21, 153, 124, 13, 18, 58, 253, 246, 79, 162, 230, 175, 247, 57, 177, 4, 13, 17, 195, 105, 150, 222, 222, 1, 162, 48, 109, 140, 251, 213, 22, 68, 80, 226, 226, 216, 40, 238, 115, 23, 84, 164, 156, 191, 122, 156, 80, 253, 190, 0, 74, 91, 195, 196, 34, 104, 136, 214, 188, 167, 72, 252, 66, 208, 189, 175, 209, 51, 101, 210, 24, 237, 183, 52, 53, 143, 36, 78, 77, 33, 196, 74, 69, 189, 187, 255, 205, 7, 120, 212, 233, 55 } }
                });

            migrationBuilder.InsertData(
                table: "VaccinationCenters",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[,]
                {
                    { 9, "Zwin, Knokke-Heist", "Zwin Center" },
                    { 13, "Technologielaan 1, 2800 Mechelen", "Technopolis Center" },
                    { 12, "Nieuwelaan 38, 1860 Meise", "Green Meise Garden" },
                    { 11, "Kasteel van Poeke, 9880 Aalter", "Central Castle of Poeke" },
                    { 10, "Mariakerkeplein, 9030 Mariakerke", "OLV Center" },
                    { 8, "Allée Frédéric Chopin, 4020 Liège", "Boverie Castle Center" },
                    { 3, "Schijnpoortweg 119, 2170 Antwerpen", "Sportpalace" },
                    { 6, "Rue Basse Commène, 6940 Barvaux-sur-Ourthe", "Barvaux Labyrint" },
                    { 5, "Kursaal-Oosthelling 12, 8400 Oostende", "Casino Center" },
                    { 4, "Wijnzakstraat 2, 8000 Brugge", "Chocostory Center" },
                    { 2, "Sint-Veerleplein 11, 9000 Gent", "Dukestones Center" },
                    { 1, "1083 Brussel", "Basilik of Koekelmountain" },
                    { 7, "Route Merveilleuse 64, 5000 Namur", "Citadel Center" }
                });

            migrationBuilder.InsertData(
                table: "VaccineCompanies",
                columns: new[] { "Id", "Country", "IsEmaApproved", "Name" },
                values: new object[,]
                {
                    { 7, "Russia", false, "Sputnik" },
                    { 1, "Russia", false, "BigEvilCo" },
                    { 2, "United States of America", true, "Pfizer-BioNTech" },
                    { 3, "Belgium", true, "Janssen Pharmaceutica" },
                    { 4, "United States of America", true, "Johnson & Johnson" },
                    { 5, "United Kingdom", true, "AstraZeneca" },
                    { 6, "United States of America", false, "Moderna" },
                    { 8, "Netherlands", false, "Heineken" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "BirthDate", "Email", "FirstName", "Surname" },
                values: new object[,]
                {
                    { 1, "Koekoekstraat 70, 9090 Melle", new DateTime(1968, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "test1", "Bond", "James" },
                    { 2, "Meir 20, 2000 Antwerpen", new DateTime(1926, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test2", "Monroe", "Marilyn" },
                    { 3, "Joseph Smeetslaan 311, 3630 Maasmechelen", new DateTime(1965, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "test3", "Van Ranst", "Marc" },
                    { 4, "Oudstrijdersstraat 27, 8370 Blankenberge", new DateTime(1963, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "test4", "Pitt", "Brad" },
                    { 5, "Latemstraat 122, 9830 Sint-Martens-Latem", new DateTime(1955, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "test5", "Gates", "Bill" }
                });

            migrationBuilder.InsertData(
                table: "Vaccines",
                columns: new[] { "Id", "BodyPartId", "CompanyId", "Description", "Name" },
                values: new object[,]
                {
                    { 15, 7, 5, "regulates hairgrow", "Clean Skinnex" },
                    { 23, 7, 5, "manipulates various aspects of skin colour", "Rainbow Vaxx" },
                    { 31, 7, 5, "regulates intensity of transpiration and hydration", "NoTrans Scentexx" },
                    { 39, 7, 5, "recalibrates muscle tension and volume for optimal bodysculpture", "Cathedral FX 2.0" },
                    { 3, 3, 6, "increases strength of bite to digest food more and faster", "Bitexx" },
                    { 11, 3, 6, "increases size and strength of tongue; premedical advice required", "Tasteroni XXL" },
                    { 19, 3, 6, "ionizes production of saliva creating a more delicate substance usable for handy to industrial purposes", "Fluo Secretional" },
                    { 27, 3, 6, "strengthens the teethstructure making the teeth razor sharp ", "Teeth Barrier" },
                    { 16, 8, 7, "boosts  energy supply and coordinates physical waste for legmuscles", "Bolt Lightning Vaxx" },
                    { 8, 8, 7, "regulates hairgrow and smoothness", "Shave & Sound Vaxx" },
                    { 7, 7, 5, "absorbes scars, marks and heals wounds", "Tattoo e-Way" },
                    { 24, 8, 7, "manipulates connectivity from nervesystem with brains; link to satellite not yet included", "Smart Geographical Cruiser" },
                    { 32, 8, 7, "modifies blood pressure and veinthickness for concentrated explosions of mass energy boosts", "Silver Trampolympixx" },
                    { 40, 8, 7, "increases production of pheromones and  smoothness skinmodification and auto hairgrowth management", "Golden Lady Vaxx" },
                    { 4, 4, 8, "creates ability to mute sound selectively", "Pluginixx" },
                    { 12, 4, 8, "improves detection of  sound and automatchmaking with sound library; library not included", "Smart Sound ID Vaxx" },
                    { 20, 4, 8, "ionizes earmembrane and earwax to manipulate soundwaves and add soundeffects", "Soundmaxx 5.0" },
                    { 35, 3, 6, "influences jaw interior creating ability to modify the sound, quality, tone… of voice", "Voice Ovexx" },
                    { 34, 2, 4, "increases stimulus transfer from nose to brains saving more scentdata in memory for certain period; period extendable per 25, 50 or 100 years ", "Scentury 2000 Vaxx" },
                    { 18, 2, 4, "manipulates nostrils to lower or increase volume", "Trump Vaxx" },
                    { 28, 4, 8, "influences stimulus transfer from ear to brains improving soundexperience", "Dolby Atmos Vaxx" },
                    { 5, 5, 1, "accumulates body hair and increases vertical strength in left arm", "Scottish Tree Vaxx (L)" },
                    { 13, 5, 1, "increases horizontal strength in left arm including titanium grip", "Truck Trixx (L)" },
                    { 21, 5, 1, "recalibrates muscle tension and joint pressure for optimal wrestling condition in left arm", "WWE Arms (L)" },
                    { 29, 5, 1, "strengthens tip of elbow", "Iron Elbow Vaxx" },
                    { 37, 5, 1, "ionizes the nervesystem into linking and fasten stimulus transfer from left arm to brains", "Write & Wrong Vaxx" },
                    { 1, 1, 2, "eases ability to track traces (cfr. Sniff with eyes)", "Eyetraxx" },
                    { 9, 1, 2, "improves eyesight in distance and sharpness (cfr. Hawkview)", "LaserPixx" },
                    { 17, 1, 2, "muscles of eyeballs soften and become flexible and trainable using eyes seperately (cfr. The Cameleon Effect)", "IO2 Vaxx" },
                    { 25, 1, 2, "stimulates the rapid-eye-movement in order to heal faster and improve transition from short-term to long-term memory", "REMEXX" },
                    { 33, 1, 2, "transforms iris and dark chamber into instant photo memories directly implemented into memory; extendable with HD", "Scan Optixx" },
                    { 6, 6, 3, "accumulates body hair and increases vertical strength in right arm", "Scottish Tree Vaxx (R) " },
                    { 14, 6, 3, "increases horizontal strength in right arm including titanium grip", "Truck Trixx (R)" },
                    { 22, 6, 3, "recalibrates muscle tension and joint pressure for optimal wrestling condition in right arm", "WWE Arms (R)" },
                    { 30, 6, 3, "makes right arm more rigid and sensitive to certain sounds (i.e. words, sentences, songs…); governance admission required", "XXtreme Righteous" },
                    { 38, 6, 3, "recalibrates muscle tension and joint pressure for optimal coffeecup holding; discount for softwaredevelopers", "StarBoxx" },
                    { 2, 2, 4, "improves detection of  smell and automatchmaking with scent library; library not included", "Smell ID Vaxx" }
                });

            migrationBuilder.InsertData(
                table: "Vaccines",
                columns: new[] { "Id", "BodyPartId", "CompanyId", "Description", "Name" },
                values: new object[] { 10, 2, 4, "creates ability to personalize filters in type of smells;  extendable with extern scent library", "Filter Vaxx" });

            migrationBuilder.InsertData(
                table: "Vaccines",
                columns: new[] { "Id", "BodyPartId", "CompanyId", "Description", "Name" },
                values: new object[] { 26, 2, 4, "regulate hydration of nose and nasal cavity; avoid sinusitis, flue and other common diseases", "DeHydra Vaxx" });

            migrationBuilder.InsertData(
                table: "Vaccines",
                columns: new[] { "Id", "BodyPartId", "CompanyId", "Description", "Name" },
                values: new object[] { 36, 4, 8, "improves detection in distance and frequency", "Enigma Pulsar Vaxx" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "Date", "LocationId", "StatusId", "UserId", "VaccinationId" },
                values: new object[] { 1, new DateTime(2021, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_LocationId",
                table: "Appointments",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_StatusId",
                table: "Appointments",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_UserId",
                table: "Appointments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_VaccinationId",
                table: "Appointments",
                column: "VaccinationId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email");

            migrationBuilder.CreateIndex(
                name: "IX_Vaccines_BodyPartId",
                table: "Vaccines",
                column: "BodyPartId");

            migrationBuilder.CreateIndex(
                name: "IX_Vaccines_CompanyId",
                table: "Vaccines",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "AppointmentStatuses");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "VaccinationCenters");

            migrationBuilder.DropTable(
                name: "Vaccines");

            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "BodyParts");

            migrationBuilder.DropTable(
                name: "VaccineCompanies");
        }
    }
}
