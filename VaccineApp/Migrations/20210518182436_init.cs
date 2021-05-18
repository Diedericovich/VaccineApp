using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VaccineApp.Migrations
{
    public partial class init : Migration
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.Id);
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
                    LoginId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Logins_LoginId",
                        column: x => x.LoginId,
                        principalTable: "Logins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    { 1, "Approved" },
                    { 2, "Canceled" },
                    { 3, "Administered" }
                });

            migrationBuilder.InsertData(
                table: "BodyParts",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Eyes" },
                    { 2, "Nose" },
                    { 3, "Mouth" },
                    { 4, "Ears" },
                    { 5, "Left Arm" },
                    { 6, "Right Arm" },
                    { 7, "Torso" },
                    { 8, "Legs" }
                });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "Id", "Email", "PasswordHash", "PasswordSalt" },
                values: new object[] { 1, "test", new byte[] { 225, 180, 33, 211, 247, 127, 135, 104, 3, 50, 63, 89, 86, 74, 164, 246, 167, 78, 7, 29, 197, 111, 231, 116, 225, 31, 100, 97, 36, 111, 117, 134, 11, 143, 240, 158, 98, 65, 162, 168, 92, 191, 179, 230, 73, 173, 33, 147, 255, 179, 52, 102, 16, 154, 74, 231, 240, 87, 222, 231, 150, 57, 250, 18 }, new byte[] { 225, 15, 107, 209, 27, 191, 227, 179, 135, 85, 226, 19, 237, 89, 0, 27, 60, 171, 87, 63, 56, 131, 1, 236, 174, 27, 161, 127, 203, 180, 9, 113, 166, 185, 192, 120, 153, 200, 168, 46, 12, 215, 6, 65, 254, 190, 117, 252, 135, 168, 35, 70, 11, 138, 212, 156, 75, 36, 46, 142, 206, 213, 145, 160, 7, 6, 215, 28, 210, 159, 34, 245, 219, 79, 153, 255, 84, 0, 137, 216, 185, 255, 243, 45, 147, 21, 159, 41, 185, 136, 39, 40, 210, 213, 126, 19, 96, 252, 197, 205, 36, 93, 17, 182, 121, 38, 91, 193, 185, 7, 176, 205, 27, 9, 238, 40, 0, 145, 194, 12, 77, 105, 149, 234, 169, 130, 6, 203 } });

            migrationBuilder.InsertData(
                table: "VaccinationCenters",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[] { 1, "location", "testCentre" });

            migrationBuilder.InsertData(
                table: "VaccineCompanies",
                columns: new[] { "Id", "Country", "IsEmaApproved", "Name" },
                values: new object[,]
                {
                    { 1, "Russia", false, "BigEvilCo" },
                    { 2, "test", false, "test" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "BirthDate", "FirstName", "LoginId", "Surname" },
                values: new object[] { 1, "test", new DateTime(1990, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "test", 1, "test" });

            migrationBuilder.InsertData(
                table: "Vaccines",
                columns: new[] { "Id", "BodyPartId", "CompanyId", "Description", "Name" },
                values: new object[] { 1, 3, 1, "desctestest", "TestVaxx" });

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
                name: "IX_Users_LoginId",
                table: "Users",
                column: "LoginId");

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
