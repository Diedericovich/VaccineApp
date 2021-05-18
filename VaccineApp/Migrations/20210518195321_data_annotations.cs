using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VaccineApp.Migrations
{
    public partial class data_annotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 100, 202, 172, 224, 127, 222, 228, 8, 12, 224, 6, 236, 249, 158, 189, 53, 53, 75, 186, 203, 86, 114, 86, 72, 46, 6, 234, 181, 165, 249, 129, 160, 54, 83, 115, 37, 156, 90, 114, 2, 14, 154, 150, 67, 21, 68, 10, 99, 172, 74, 190, 237, 241, 213, 101, 227, 133, 45, 208, 215, 73, 132, 236, 122 }, new byte[] { 152, 216, 177, 71, 181, 117, 223, 176, 48, 149, 134, 106, 182, 100, 0, 162, 6, 215, 133, 217, 209, 40, 96, 111, 152, 81, 9, 95, 234, 242, 134, 51, 164, 47, 159, 4, 38, 250, 0, 214, 67, 63, 150, 47, 7, 6, 152, 95, 68, 121, 165, 63, 181, 238, 121, 43, 225, 96, 174, 113, 177, 255, 225, 241, 247, 122, 106, 155, 234, 88, 201, 9, 51, 128, 27, 223, 249, 124, 252, 117, 121, 242, 70, 164, 34, 6, 184, 192, 194, 195, 79, 186, 41, 159, 96, 156, 225, 120, 201, 71, 5, 225, 124, 232, 135, 163, 9, 91, 215, 122, 164, 14, 119, 114, 51, 131, 185, 252, 15, 39, 69, 157, 134, 128, 160, 4, 33, 253 } });

            migrationBuilder.InsertData(
                table: "VaccinationCenters",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[] { 2, "location", "VaxxCenter" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VaccinationCenters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 225, 180, 33, 211, 247, 127, 135, 104, 3, 50, 63, 89, 86, 74, 164, 246, 167, 78, 7, 29, 197, 111, 231, 116, 225, 31, 100, 97, 36, 111, 117, 134, 11, 143, 240, 158, 98, 65, 162, 168, 92, 191, 179, 230, 73, 173, 33, 147, 255, 179, 52, 102, 16, 154, 74, 231, 240, 87, 222, 231, 150, 57, 250, 18 }, new byte[] { 225, 15, 107, 209, 27, 191, 227, 179, 135, 85, 226, 19, 237, 89, 0, 27, 60, 171, 87, 63, 56, 131, 1, 236, 174, 27, 161, 127, 203, 180, 9, 113, 166, 185, 192, 120, 153, 200, 168, 46, 12, 215, 6, 65, 254, 190, 117, 252, 135, 168, 35, 70, 11, 138, 212, 156, 75, 36, 46, 142, 206, 213, 145, 160, 7, 6, 215, 28, 210, 159, 34, 245, 219, 79, 153, 255, 84, 0, 137, 216, 185, 255, 243, 45, 147, 21, 159, 41, 185, 136, 39, 40, 210, 213, 126, 19, 96, 252, 197, 205, 36, 93, 17, 182, 121, 38, 91, 193, 185, 7, 176, 205, 27, 9, 238, 40, 0, 145, 194, 12, 77, 105, 149, 234, 169, 130, 6, 203 } });
        }
    }
}
