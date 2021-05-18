using Microsoft.EntityFrameworkCore.Migrations;

namespace VaccineApp.Migrations
{
    public partial class SeedBodyParts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BodyParts",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
