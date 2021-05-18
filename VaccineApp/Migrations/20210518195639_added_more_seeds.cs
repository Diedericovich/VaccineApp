using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VaccineApp.Migrations
{
    public partial class added_more_seeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 246, 24, 224, 205, 163, 187, 102, 109, 172, 154, 84, 221, 153, 89, 100, 102, 134, 86, 202, 216, 113, 212, 40, 3, 219, 100, 80, 238, 131, 145, 235, 242, 16, 147, 123, 166, 156, 7, 211, 55, 125, 136, 9, 247, 135, 6, 37, 91, 72, 40, 9, 188, 162, 133, 47, 127, 241, 100, 238, 180, 175, 26, 64, 3 }, new byte[] { 29, 120, 11, 5, 91, 104, 171, 209, 56, 79, 69, 227, 126, 131, 2, 244, 186, 140, 81, 144, 183, 96, 20, 10, 116, 192, 139, 89, 138, 201, 20, 63, 133, 208, 52, 37, 132, 253, 11, 53, 6, 221, 221, 88, 124, 161, 140, 233, 245, 24, 41, 74, 200, 74, 13, 47, 135, 13, 242, 189, 138, 250, 47, 213, 73, 24, 102, 164, 109, 150, 58, 11, 29, 136, 41, 90, 183, 160, 169, 180, 196, 233, 132, 244, 85, 63, 51, 57, 0, 235, 44, 226, 33, 245, 227, 221, 68, 169, 175, 148, 84, 176, 226, 57, 14, 231, 160, 128, 180, 45, 52, 15, 79, 215, 251, 193, 109, 15, 63, 27, 104, 123, 53, 100, 95, 13, 53, 236 } });

            migrationBuilder.InsertData(
                table: "VaccinationCenters",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[,]
                {
                    { 3, "location", "PokeCenter" },
                    { 4, "location", "Cent er" },
                    { 5, "location", "Help" },
                    { 6, "location", "IkKanGeenLeukeNaamMeerVinden" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VaccinationCenters",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VaccinationCenters",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VaccinationCenters",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VaccinationCenters",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 100, 202, 172, 224, 127, 222, 228, 8, 12, 224, 6, 236, 249, 158, 189, 53, 53, 75, 186, 203, 86, 114, 86, 72, 46, 6, 234, 181, 165, 249, 129, 160, 54, 83, 115, 37, 156, 90, 114, 2, 14, 154, 150, 67, 21, 68, 10, 99, 172, 74, 190, 237, 241, 213, 101, 227, 133, 45, 208, 215, 73, 132, 236, 122 }, new byte[] { 152, 216, 177, 71, 181, 117, 223, 176, 48, 149, 134, 106, 182, 100, 0, 162, 6, 215, 133, 217, 209, 40, 96, 111, 152, 81, 9, 95, 234, 242, 134, 51, 164, 47, 159, 4, 38, 250, 0, 214, 67, 63, 150, 47, 7, 6, 152, 95, 68, 121, 165, 63, 181, 238, 121, 43, 225, 96, 174, 113, 177, 255, 225, 241, 247, 122, 106, 155, 234, 88, 201, 9, 51, 128, 27, 223, 249, 124, 252, 117, 121, 242, 70, 164, 34, 6, 184, 192, 194, 195, 79, 186, 41, 159, 96, 156, 225, 120, 201, 71, 5, 225, 124, 232, 135, 163, 9, 91, 215, 122, 164, 14, 119, 114, 51, 131, 185, 252, 15, 39, 69, 157, 134, 128, 160, 4, 33, 253 } });
        }
    }
}
