using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VaccineApp.Migrations
{
    public partial class extraLocationSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Email",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "VaccineCompanies",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "VaccineCompanies",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Users",
                type: "nvarchar(55)",
                maxLength: 55,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(55)",
                oldMaxLength: 55,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "PasswordSalt",
                table: "Logins",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "PasswordHash",
                table: "Logins",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "BodyParts",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "AppointmentStatuses",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "LocationId", "StatusId", "VaccinationId" },
                values: new object[] { new DateTime(2021, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, 39 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "Date", "LocationId", "StatusId", "UserId", "VaccinationId" },
                values: new object[,]
                {
                    { 2, new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, 1, 1 },
                    { 3, new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 1, 8 },
                    { 4, new DateTime(2021, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, 1, 28 },
                    { 5, new DateTime(2021, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1, 12 }
                });

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 60, 212, 219, 2, 175, 195, 62, 71, 76, 153, 80, 237, 199, 31, 202, 92, 204, 47, 89, 53, 53, 115, 75, 33, 174, 11, 123, 222, 168, 239, 30, 166, 46, 125, 137, 30, 229, 24, 159, 164, 62, 191, 252, 238, 122, 150, 34, 106, 185, 230, 20, 128, 38, 128, 244, 225, 1, 176, 32, 95, 221, 206, 8, 61 }, new byte[] { 36, 26, 66, 56, 160, 152, 75, 14, 166, 169, 173, 87, 66, 41, 227, 52, 66, 146, 33, 250, 23, 86, 12, 217, 251, 171, 25, 222, 242, 61, 147, 122, 191, 48, 209, 149, 15, 164, 42, 200, 170, 41, 204, 162, 229, 218, 183, 86, 63, 25, 61, 7, 236, 142, 152, 129, 22, 64, 238, 242, 190, 91, 168, 240, 211, 40, 220, 116, 32, 42, 190, 84, 116, 240, 162, 34, 134, 185, 95, 155, 19, 150, 76, 115, 45, 136, 229, 173, 64, 14, 143, 46, 223, 191, 28, 30, 181, 175, 114, 76, 102, 86, 228, 233, 171, 38, 63, 98, 4, 218, 196, 234, 10, 254, 185, 249, 70, 199, 228, 190, 240, 125, 71, 171, 54, 57, 30, 168 } });

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 60, 212, 219, 2, 175, 195, 62, 71, 76, 153, 80, 237, 199, 31, 202, 92, 204, 47, 89, 53, 53, 115, 75, 33, 174, 11, 123, 222, 168, 239, 30, 166, 46, 125, 137, 30, 229, 24, 159, 164, 62, 191, 252, 238, 122, 150, 34, 106, 185, 230, 20, 128, 38, 128, 244, 225, 1, 176, 32, 95, 221, 206, 8, 61 }, new byte[] { 36, 26, 66, 56, 160, 152, 75, 14, 166, 169, 173, 87, 66, 41, 227, 52, 66, 146, 33, 250, 23, 86, 12, 217, 251, 171, 25, 222, 242, 61, 147, 122, 191, 48, 209, 149, 15, 164, 42, 200, 170, 41, 204, 162, 229, 218, 183, 86, 63, 25, 61, 7, 236, 142, 152, 129, 22, 64, 238, 242, 190, 91, 168, 240, 211, 40, 220, 116, 32, 42, 190, 84, 116, 240, 162, 34, 134, 185, 95, 155, 19, 150, 76, 115, 45, 136, 229, 173, 64, 14, 143, 46, 223, 191, 28, 30, 181, 175, 114, 76, 102, 86, 228, 233, 171, 38, 63, 98, 4, 218, 196, 234, 10, 254, 185, 249, 70, 199, 228, 190, 240, 125, 71, 171, 54, 57, 30, 168 } });

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 60, 212, 219, 2, 175, 195, 62, 71, 76, 153, 80, 237, 199, 31, 202, 92, 204, 47, 89, 53, 53, 115, 75, 33, 174, 11, 123, 222, 168, 239, 30, 166, 46, 125, 137, 30, 229, 24, 159, 164, 62, 191, 252, 238, 122, 150, 34, 106, 185, 230, 20, 128, 38, 128, 244, 225, 1, 176, 32, 95, 221, 206, 8, 61 }, new byte[] { 36, 26, 66, 56, 160, 152, 75, 14, 166, 169, 173, 87, 66, 41, 227, 52, 66, 146, 33, 250, 23, 86, 12, 217, 251, 171, 25, 222, 242, 61, 147, 122, 191, 48, 209, 149, 15, 164, 42, 200, 170, 41, 204, 162, 229, 218, 183, 86, 63, 25, 61, 7, 236, 142, 152, 129, 22, 64, 238, 242, 190, 91, 168, 240, 211, 40, 220, 116, 32, 42, 190, 84, 116, 240, 162, 34, 134, 185, 95, 155, 19, 150, 76, 115, 45, 136, 229, 173, 64, 14, 143, 46, 223, 191, 28, 30, 181, 175, 114, 76, 102, 86, 228, 233, 171, 38, 63, 98, 4, 218, 196, 234, 10, 254, 185, 249, 70, 199, 228, 190, 240, 125, 71, 171, 54, 57, 30, 168 } });

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 60, 212, 219, 2, 175, 195, 62, 71, 76, 153, 80, 237, 199, 31, 202, 92, 204, 47, 89, 53, 53, 115, 75, 33, 174, 11, 123, 222, 168, 239, 30, 166, 46, 125, 137, 30, 229, 24, 159, 164, 62, 191, 252, 238, 122, 150, 34, 106, 185, 230, 20, 128, 38, 128, 244, 225, 1, 176, 32, 95, 221, 206, 8, 61 }, new byte[] { 36, 26, 66, 56, 160, 152, 75, 14, 166, 169, 173, 87, 66, 41, 227, 52, 66, 146, 33, 250, 23, 86, 12, 217, 251, 171, 25, 222, 242, 61, 147, 122, 191, 48, 209, 149, 15, 164, 42, 200, 170, 41, 204, 162, 229, 218, 183, 86, 63, 25, 61, 7, 236, 142, 152, 129, 22, 64, 238, 242, 190, 91, 168, 240, 211, 40, 220, 116, 32, 42, 190, 84, 116, 240, 162, 34, 134, 185, 95, 155, 19, 150, 76, 115, 45, 136, 229, 173, 64, 14, 143, 46, 223, 191, 28, 30, 181, 175, 114, 76, 102, 86, 228, 233, 171, 38, 63, 98, 4, 218, 196, 234, 10, 254, 185, 249, 70, 199, 228, 190, 240, 125, 71, 171, 54, 57, 30, 168 } });

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 60, 212, 219, 2, 175, 195, 62, 71, 76, 153, 80, 237, 199, 31, 202, 92, 204, 47, 89, 53, 53, 115, 75, 33, 174, 11, 123, 222, 168, 239, 30, 166, 46, 125, 137, 30, 229, 24, 159, 164, 62, 191, 252, 238, 122, 150, 34, 106, 185, 230, 20, 128, 38, 128, 244, 225, 1, 176, 32, 95, 221, 206, 8, 61 }, new byte[] { 36, 26, 66, 56, 160, 152, 75, 14, 166, 169, 173, 87, 66, 41, 227, 52, 66, 146, 33, 250, 23, 86, 12, 217, 251, 171, 25, 222, 242, 61, 147, 122, 191, 48, 209, 149, 15, 164, 42, 200, 170, 41, 204, 162, 229, 218, 183, 86, 63, 25, 61, 7, 236, 142, 152, 129, 22, 64, 238, 242, 190, 91, 168, 240, 211, 40, 220, 116, 32, 42, 190, 84, 116, 240, 162, 34, 134, 185, 95, 155, 19, 150, 76, 115, 45, 136, 229, 173, 64, 14, 143, 46, 223, 191, 28, 30, 181, 175, 114, 76, 102, 86, 228, 233, 171, 38, 63, 98, 4, 218, 196, 234, 10, 254, 185, 249, 70, 199, 228, 190, 240, 125, 71, 171, 54, 57, 30, 168 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstName", "Surname" },
                values: new object[] { "James", "Bond" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FirstName", "Surname" },
                values: new object[] { "Marilyn", "Monroe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FirstName", "Surname" },
                values: new object[] { "Marc", "Van Ranst" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FirstName", "Surname" },
                values: new object[] { "Brad", "Pitt" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FirstName", "Surname" },
                values: new object[] { "Bill", "Gates" });

            migrationBuilder.UpdateData(
                table: "VaccinationCenters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Location", "Name" },
                values: new object[] { "Elisabeth Park, 1083 Brussel", "National Basilica of the Sacred Heart" });

            migrationBuilder.UpdateData(
                table: "VaccinationCenters",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Lotto Arena");

            migrationBuilder.UpdateData(
                table: "VaccinationCenters",
                keyColumn: "Id",
                keyValue: 9,
                column: "Location",
                value: "Expo 'Vogels in het Zwin', Knokke-Heist");

            migrationBuilder.UpdateData(
                table: "VaccinationCenters",
                keyColumn: "Id",
                keyValue: 11,
                column: "Location",
                value: "Poeke Castle, 9880 Aalter");

            migrationBuilder.InsertData(
                table: "VaccinationCenters",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[,]
                {
                    { 16, "Witte Nonnenstraat 19, 3500 Hasselt", "National Jenevermuseum" },
                    { 15, "Standonckstraat 4, 3000 Leuven", "Thomas Stapleton, Irish Pub" },
                    { 14, "Brouwerij Haacht, 3150 Haacht", "Primus Brewery" },
                    { 17, "Steenpoort 2, 8500 Kortrijk", "K in Kortrijk" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Email",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VaccinationCenters",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "VaccinationCenters",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "VaccinationCenters",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "VaccinationCenters",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "VaccineCompanies",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "VaccineCompanies",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Users",
                type: "nvarchar(55)",
                maxLength: 55,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(55)",
                oldMaxLength: 55);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<byte[]>(
                name: "PasswordSalt",
                table: "Logins",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.AlterColumn<byte[]>(
                name: "PasswordHash",
                table: "Logins",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "BodyParts",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "AppointmentStatuses",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "LocationId", "StatusId", "VaccinationId" },
                values: new object[] { new DateTime(2021, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 107, 219, 18, 217, 114, 181, 39, 143, 172, 131, 128, 126, 19, 197, 82, 234, 7, 217, 91, 119, 213, 177, 6, 164, 63, 74, 145, 199, 181, 247, 60, 202, 27, 13, 161, 27, 63, 88, 48, 173, 218, 203, 152, 183, 202, 190, 64, 105, 233, 163, 101, 36, 248, 182, 191, 189, 232, 117, 97, 145, 78, 197, 87, 74 }, new byte[] { 244, 241, 7, 54, 151, 197, 238, 73, 236, 72, 226, 238, 62, 202, 141, 152, 12, 96, 30, 169, 241, 230, 248, 72, 167, 235, 5, 111, 164, 55, 231, 81, 221, 217, 52, 209, 63, 40, 22, 154, 244, 31, 65, 33, 215, 151, 190, 179, 179, 211, 243, 56, 22, 241, 230, 113, 198, 17, 25, 41, 98, 89, 143, 36, 136, 69, 107, 58, 253, 65, 19, 18, 46, 145, 206, 80, 178, 233, 151, 170, 37, 29, 5, 16, 237, 245, 144, 146, 184, 166, 169, 87, 11, 56, 236, 61, 155, 138, 95, 230, 38, 190, 30, 214, 247, 7, 72, 36, 162, 235, 154, 37, 200, 197, 121, 248, 25, 213, 128, 49, 107, 224, 213, 181, 37, 150, 130, 49 } });

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 107, 219, 18, 217, 114, 181, 39, 143, 172, 131, 128, 126, 19, 197, 82, 234, 7, 217, 91, 119, 213, 177, 6, 164, 63, 74, 145, 199, 181, 247, 60, 202, 27, 13, 161, 27, 63, 88, 48, 173, 218, 203, 152, 183, 202, 190, 64, 105, 233, 163, 101, 36, 248, 182, 191, 189, 232, 117, 97, 145, 78, 197, 87, 74 }, new byte[] { 244, 241, 7, 54, 151, 197, 238, 73, 236, 72, 226, 238, 62, 202, 141, 152, 12, 96, 30, 169, 241, 230, 248, 72, 167, 235, 5, 111, 164, 55, 231, 81, 221, 217, 52, 209, 63, 40, 22, 154, 244, 31, 65, 33, 215, 151, 190, 179, 179, 211, 243, 56, 22, 241, 230, 113, 198, 17, 25, 41, 98, 89, 143, 36, 136, 69, 107, 58, 253, 65, 19, 18, 46, 145, 206, 80, 178, 233, 151, 170, 37, 29, 5, 16, 237, 245, 144, 146, 184, 166, 169, 87, 11, 56, 236, 61, 155, 138, 95, 230, 38, 190, 30, 214, 247, 7, 72, 36, 162, 235, 154, 37, 200, 197, 121, 248, 25, 213, 128, 49, 107, 224, 213, 181, 37, 150, 130, 49 } });

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 107, 219, 18, 217, 114, 181, 39, 143, 172, 131, 128, 126, 19, 197, 82, 234, 7, 217, 91, 119, 213, 177, 6, 164, 63, 74, 145, 199, 181, 247, 60, 202, 27, 13, 161, 27, 63, 88, 48, 173, 218, 203, 152, 183, 202, 190, 64, 105, 233, 163, 101, 36, 248, 182, 191, 189, 232, 117, 97, 145, 78, 197, 87, 74 }, new byte[] { 244, 241, 7, 54, 151, 197, 238, 73, 236, 72, 226, 238, 62, 202, 141, 152, 12, 96, 30, 169, 241, 230, 248, 72, 167, 235, 5, 111, 164, 55, 231, 81, 221, 217, 52, 209, 63, 40, 22, 154, 244, 31, 65, 33, 215, 151, 190, 179, 179, 211, 243, 56, 22, 241, 230, 113, 198, 17, 25, 41, 98, 89, 143, 36, 136, 69, 107, 58, 253, 65, 19, 18, 46, 145, 206, 80, 178, 233, 151, 170, 37, 29, 5, 16, 237, 245, 144, 146, 184, 166, 169, 87, 11, 56, 236, 61, 155, 138, 95, 230, 38, 190, 30, 214, 247, 7, 72, 36, 162, 235, 154, 37, 200, 197, 121, 248, 25, 213, 128, 49, 107, 224, 213, 181, 37, 150, 130, 49 } });

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 107, 219, 18, 217, 114, 181, 39, 143, 172, 131, 128, 126, 19, 197, 82, 234, 7, 217, 91, 119, 213, 177, 6, 164, 63, 74, 145, 199, 181, 247, 60, 202, 27, 13, 161, 27, 63, 88, 48, 173, 218, 203, 152, 183, 202, 190, 64, 105, 233, 163, 101, 36, 248, 182, 191, 189, 232, 117, 97, 145, 78, 197, 87, 74 }, new byte[] { 244, 241, 7, 54, 151, 197, 238, 73, 236, 72, 226, 238, 62, 202, 141, 152, 12, 96, 30, 169, 241, 230, 248, 72, 167, 235, 5, 111, 164, 55, 231, 81, 221, 217, 52, 209, 63, 40, 22, 154, 244, 31, 65, 33, 215, 151, 190, 179, 179, 211, 243, 56, 22, 241, 230, 113, 198, 17, 25, 41, 98, 89, 143, 36, 136, 69, 107, 58, 253, 65, 19, 18, 46, 145, 206, 80, 178, 233, 151, 170, 37, 29, 5, 16, 237, 245, 144, 146, 184, 166, 169, 87, 11, 56, 236, 61, 155, 138, 95, 230, 38, 190, 30, 214, 247, 7, 72, 36, 162, 235, 154, 37, 200, 197, 121, 248, 25, 213, 128, 49, 107, 224, 213, 181, 37, 150, 130, 49 } });

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 107, 219, 18, 217, 114, 181, 39, 143, 172, 131, 128, 126, 19, 197, 82, 234, 7, 217, 91, 119, 213, 177, 6, 164, 63, 74, 145, 199, 181, 247, 60, 202, 27, 13, 161, 27, 63, 88, 48, 173, 218, 203, 152, 183, 202, 190, 64, 105, 233, 163, 101, 36, 248, 182, 191, 189, 232, 117, 97, 145, 78, 197, 87, 74 }, new byte[] { 244, 241, 7, 54, 151, 197, 238, 73, 236, 72, 226, 238, 62, 202, 141, 152, 12, 96, 30, 169, 241, 230, 248, 72, 167, 235, 5, 111, 164, 55, 231, 81, 221, 217, 52, 209, 63, 40, 22, 154, 244, 31, 65, 33, 215, 151, 190, 179, 179, 211, 243, 56, 22, 241, 230, 113, 198, 17, 25, 41, 98, 89, 143, 36, 136, 69, 107, 58, 253, 65, 19, 18, 46, 145, 206, 80, 178, 233, 151, 170, 37, 29, 5, 16, 237, 245, 144, 146, 184, 166, 169, 87, 11, 56, 236, 61, 155, 138, 95, 230, 38, 190, 30, 214, 247, 7, 72, 36, 162, 235, 154, 37, 200, 197, 121, 248, 25, 213, 128, 49, 107, 224, 213, 181, 37, 150, 130, 49 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstName", "Surname" },
                values: new object[] { "Bond", "James" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FirstName", "Surname" },
                values: new object[] { "Monroe", "Marilyn" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FirstName", "Surname" },
                values: new object[] { "Van Ranst", "Marc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FirstName", "Surname" },
                values: new object[] { "Pitt", "Brad" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FirstName", "Surname" },
                values: new object[] { "Gates", "Bill" });

            migrationBuilder.UpdateData(
                table: "VaccinationCenters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Location", "Name" },
                values: new object[] { "1083 Brussel", "Basilik of Koekelmountain" });

            migrationBuilder.UpdateData(
                table: "VaccinationCenters",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Sportpalace");

            migrationBuilder.UpdateData(
                table: "VaccinationCenters",
                keyColumn: "Id",
                keyValue: 9,
                column: "Location",
                value: "Zwin, Knokke-Heist");

            migrationBuilder.UpdateData(
                table: "VaccinationCenters",
                keyColumn: "Id",
                keyValue: 11,
                column: "Location",
                value: "Kasteel van Poeke, 9880 Aalter");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");
        }
    }
}
