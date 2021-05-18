using Microsoft.EntityFrameworkCore.Migrations;

namespace VaccineApp.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppointmentStatuses",
                columns: new[] { "Id", "Status" },
                values: new object[] { 1, "Approved" });

            migrationBuilder.InsertData(
                table: "AppointmentStatuses",
                columns: new[] { "Id", "Status" },
                values: new object[] { 2, "Canceled" });

            migrationBuilder.InsertData(
                table: "AppointmentStatuses",
                columns: new[] { "Id", "Status" },
                values: new object[] { 3, "Administered" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AppointmentStatuses",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
