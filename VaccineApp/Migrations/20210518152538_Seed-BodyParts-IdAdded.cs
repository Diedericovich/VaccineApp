using Microsoft.EntityFrameworkCore.Migrations;

namespace VaccineApp.Migrations
{
    public partial class SeedBodyPartsIdAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vaccines_BodyParts_BodyPartId",
                table: "Vaccines");

            migrationBuilder.AlterColumn<int>(
                name: "BodyPartId",
                table: "Vaccines",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Vaccines",
                columns: new[] { "Id", "BodyPartId", "CompanyId", "Description", "Name" },
                values: new object[] { 1, 3, null, "desctestest", "TestVaxx" });

            migrationBuilder.AddForeignKey(
                name: "FK_Vaccines_BodyParts_BodyPartId",
                table: "Vaccines",
                column: "BodyPartId",
                principalTable: "BodyParts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vaccines_BodyParts_BodyPartId",
                table: "Vaccines");

            migrationBuilder.DeleteData(
                table: "Vaccines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "BodyPartId",
                table: "Vaccines",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Vaccines_BodyParts_BodyPartId",
                table: "Vaccines",
                column: "BodyPartId",
                principalTable: "BodyParts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
