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
                    { 8, "Legs" },
                    { 6, "Right Arm" },
                    { 5, "Left Arm" },
                    { 7, "Torso" },
                    { 3, "Mouth" },
                    { 2, "Nose" },
                    { 1, "Eyes" },
                    { 4, "Ears" }
                });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "Id", "Email", "PasswordHash", "PasswordSalt" },
                values: new object[] { 1, "test", new byte[] { 213, 22, 126, 29, 188, 65, 215, 80, 90, 18, 66, 248, 39, 16, 176, 146, 253, 12, 58, 85, 85, 63, 253, 253, 106, 148, 32, 194, 110, 140, 25, 25, 25, 74, 145, 96, 212, 135, 216, 212, 55, 197, 234, 223, 195, 188, 211, 89, 9, 100, 33, 35, 221, 146, 89, 92, 249, 255, 88, 122, 233, 165, 166, 124 }, new byte[] { 28, 183, 40, 177, 249, 199, 52, 38, 134, 69, 58, 49, 157, 22, 2, 149, 90, 18, 71, 139, 112, 142, 64, 164, 191, 218, 227, 58, 193, 14, 161, 90, 109, 38, 170, 145, 66, 213, 130, 44, 84, 84, 237, 166, 116, 169, 0, 216, 71, 27, 209, 228, 121, 247, 242, 213, 58, 178, 240, 82, 130, 131, 190, 18, 160, 90, 131, 236, 218, 114, 101, 23, 161, 32, 99, 60, 34, 190, 109, 165, 40, 189, 214, 194, 129, 138, 0, 168, 239, 7, 210, 214, 111, 167, 43, 33, 25, 245, 49, 131, 0, 236, 33, 206, 158, 37, 46, 47, 30, 59, 102, 18, 87, 200, 146, 42, 166, 68, 151, 198, 28, 51, 165, 72, 190, 88, 35, 147 } });

            migrationBuilder.InsertData(
                table: "VaccinationCenters",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "location", "testCentre" },
                    { 2, "location", "VaxxCenter" },
                    { 3, "location", "PokeCenter" },
                    { 4, "location", "Cent er" },
                    { 5, "location", "Help" },
                    { 6, "location", "IkKanGeenLeukeNaamMeerVinden" }
                });

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
                values: new object[,]
                {
                    { 1, 3, 1, "desctestest", "TestVaxx" },
                    { 2, 1, 1, "desctestest", "EyeVax" },
                    { 3, 2, 1, "desctestest", "NoseVax" },
                    { 4, 5, 1, "desctestest", "LeftArmVax" },
                    { 5, 5, 1, "desctestest", "LeftArmVax2" },
                    { 6, 7, 1, "desctestest", "TorsoVax" },
                    { 7, 8, 1, "desctestest", "LegsVax" },
                    { 8, 6, 1, "desctestest", "RightArmVax" },
                    { 9, 6, 1, "desctestest", "RightArmVax2" }
                });

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
