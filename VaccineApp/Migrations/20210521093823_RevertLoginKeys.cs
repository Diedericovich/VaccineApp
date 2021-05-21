using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VaccineApp.Migrations
{
    public partial class RevertLoginKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Logins_Email",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_Email",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Logins",
                table: "Logins");

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "Email",
                keyValue: "test1");

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "Email",
                keyValue: "test2");

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "Email",
                keyValue: "test3");

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "Email",
                keyValue: "test4");

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "Email",
                keyValue: "test5");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "LoginId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Logins",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Logins",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Logins",
                table: "Logins",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "Id", "Email", "PasswordHash", "PasswordSalt" },
                values: new object[,]
                {
                    { 1, "test1", new byte[] { 198, 247, 146, 190, 166, 126, 16, 25, 226, 28, 147, 11, 193, 94, 134, 184, 224, 19, 6, 85, 18, 248, 48, 27, 67, 2, 77, 171, 243, 236, 70, 102, 18, 28, 59, 115, 133, 58, 110, 16, 12, 255, 197, 5, 179, 48, 66, 109, 159, 58, 17, 243, 177, 149, 50, 251, 83, 187, 116, 207, 30, 220, 126, 202 }, new byte[] { 61, 165, 176, 240, 178, 95, 33, 85, 195, 34, 186, 136, 140, 16, 78, 61, 172, 134, 237, 156, 194, 220, 165, 108, 75, 190, 113, 130, 50, 84, 20, 8, 73, 150, 1, 125, 146, 183, 84, 109, 160, 233, 59, 50, 220, 87, 174, 100, 144, 54, 107, 98, 83, 209, 82, 217, 73, 50, 49, 177, 104, 54, 86, 228, 176, 2, 182, 16, 66, 18, 1, 193, 2, 15, 32, 35, 13, 85, 132, 192, 35, 22, 116, 234, 93, 57, 158, 11, 254, 150, 77, 196, 4, 41, 87, 146, 67, 87, 30, 53, 237, 35, 148, 233, 240, 202, 33, 252, 90, 11, 221, 20, 28, 171, 17, 225, 106, 80, 96, 221, 80, 35, 240, 253, 16, 86, 54, 148 } },
                    { 2, "test2", new byte[] { 198, 247, 146, 190, 166, 126, 16, 25, 226, 28, 147, 11, 193, 94, 134, 184, 224, 19, 6, 85, 18, 248, 48, 27, 67, 2, 77, 171, 243, 236, 70, 102, 18, 28, 59, 115, 133, 58, 110, 16, 12, 255, 197, 5, 179, 48, 66, 109, 159, 58, 17, 243, 177, 149, 50, 251, 83, 187, 116, 207, 30, 220, 126, 202 }, new byte[] { 61, 165, 176, 240, 178, 95, 33, 85, 195, 34, 186, 136, 140, 16, 78, 61, 172, 134, 237, 156, 194, 220, 165, 108, 75, 190, 113, 130, 50, 84, 20, 8, 73, 150, 1, 125, 146, 183, 84, 109, 160, 233, 59, 50, 220, 87, 174, 100, 144, 54, 107, 98, 83, 209, 82, 217, 73, 50, 49, 177, 104, 54, 86, 228, 176, 2, 182, 16, 66, 18, 1, 193, 2, 15, 32, 35, 13, 85, 132, 192, 35, 22, 116, 234, 93, 57, 158, 11, 254, 150, 77, 196, 4, 41, 87, 146, 67, 87, 30, 53, 237, 35, 148, 233, 240, 202, 33, 252, 90, 11, 221, 20, 28, 171, 17, 225, 106, 80, 96, 221, 80, 35, 240, 253, 16, 86, 54, 148 } },
                    { 3, "test3", new byte[] { 198, 247, 146, 190, 166, 126, 16, 25, 226, 28, 147, 11, 193, 94, 134, 184, 224, 19, 6, 85, 18, 248, 48, 27, 67, 2, 77, 171, 243, 236, 70, 102, 18, 28, 59, 115, 133, 58, 110, 16, 12, 255, 197, 5, 179, 48, 66, 109, 159, 58, 17, 243, 177, 149, 50, 251, 83, 187, 116, 207, 30, 220, 126, 202 }, new byte[] { 61, 165, 176, 240, 178, 95, 33, 85, 195, 34, 186, 136, 140, 16, 78, 61, 172, 134, 237, 156, 194, 220, 165, 108, 75, 190, 113, 130, 50, 84, 20, 8, 73, 150, 1, 125, 146, 183, 84, 109, 160, 233, 59, 50, 220, 87, 174, 100, 144, 54, 107, 98, 83, 209, 82, 217, 73, 50, 49, 177, 104, 54, 86, 228, 176, 2, 182, 16, 66, 18, 1, 193, 2, 15, 32, 35, 13, 85, 132, 192, 35, 22, 116, 234, 93, 57, 158, 11, 254, 150, 77, 196, 4, 41, 87, 146, 67, 87, 30, 53, 237, 35, 148, 233, 240, 202, 33, 252, 90, 11, 221, 20, 28, 171, 17, 225, 106, 80, 96, 221, 80, 35, 240, 253, 16, 86, 54, 148 } },
                    { 4, "test4", new byte[] { 198, 247, 146, 190, 166, 126, 16, 25, 226, 28, 147, 11, 193, 94, 134, 184, 224, 19, 6, 85, 18, 248, 48, 27, 67, 2, 77, 171, 243, 236, 70, 102, 18, 28, 59, 115, 133, 58, 110, 16, 12, 255, 197, 5, 179, 48, 66, 109, 159, 58, 17, 243, 177, 149, 50, 251, 83, 187, 116, 207, 30, 220, 126, 202 }, new byte[] { 61, 165, 176, 240, 178, 95, 33, 85, 195, 34, 186, 136, 140, 16, 78, 61, 172, 134, 237, 156, 194, 220, 165, 108, 75, 190, 113, 130, 50, 84, 20, 8, 73, 150, 1, 125, 146, 183, 84, 109, 160, 233, 59, 50, 220, 87, 174, 100, 144, 54, 107, 98, 83, 209, 82, 217, 73, 50, 49, 177, 104, 54, 86, 228, 176, 2, 182, 16, 66, 18, 1, 193, 2, 15, 32, 35, 13, 85, 132, 192, 35, 22, 116, 234, 93, 57, 158, 11, 254, 150, 77, 196, 4, 41, 87, 146, 67, 87, 30, 53, 237, 35, 148, 233, 240, 202, 33, 252, 90, 11, 221, 20, 28, 171, 17, 225, 106, 80, 96, 221, 80, 35, 240, 253, 16, 86, 54, 148 } },
                    { 5, "test5", new byte[] { 198, 247, 146, 190, 166, 126, 16, 25, 226, 28, 147, 11, 193, 94, 134, 184, 224, 19, 6, 85, 18, 248, 48, 27, 67, 2, 77, 171, 243, 236, 70, 102, 18, 28, 59, 115, 133, 58, 110, 16, 12, 255, 197, 5, 179, 48, 66, 109, 159, 58, 17, 243, 177, 149, 50, 251, 83, 187, 116, 207, 30, 220, 126, 202 }, new byte[] { 61, 165, 176, 240, 178, 95, 33, 85, 195, 34, 186, 136, 140, 16, 78, 61, 172, 134, 237, 156, 194, 220, 165, 108, 75, 190, 113, 130, 50, 84, 20, 8, 73, 150, 1, 125, 146, 183, 84, 109, 160, 233, 59, 50, 220, 87, 174, 100, 144, 54, 107, 98, 83, 209, 82, 217, 73, 50, 49, 177, 104, 54, 86, 228, 176, 2, 182, 16, 66, 18, 1, 193, 2, 15, 32, 35, 13, 85, 132, 192, 35, 22, 116, 234, 93, 57, 158, 11, 254, 150, 77, 196, 4, 41, 87, 146, 67, 87, 30, 53, 237, 35, 148, 233, 240, 202, 33, 252, 90, 11, 221, 20, 28, 171, 17, 225, 106, 80, 96, 221, 80, 35, 240, 253, 16, 86, 54, 148 } }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "LoginId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "LoginId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "LoginId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "LoginId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "LoginId",
                value: 5);

            migrationBuilder.CreateIndex(
                name: "IX_Users_LoginId",
                table: "Users",
                column: "LoginId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Logins_LoginId",
                table: "Users",
                column: "LoginId",
                principalTable: "Logins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Logins_LoginId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_LoginId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Logins",
                table: "Logins");

            migrationBuilder.DropColumn(
                name: "LoginId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Logins");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Logins",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Logins",
                table: "Logins",
                column: "Email");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "Email",
                keyValue: "test1",
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 30, 2, 148, 20, 115, 149, 11, 131, 144, 235, 13, 69, 226, 115, 101, 148, 47, 113, 2, 186, 102, 189, 147, 75, 10, 190, 223, 70, 225, 49, 250, 216, 182, 220, 244, 173, 49, 16, 32, 142, 112, 122, 12, 133, 9, 202, 33, 117, 105, 115, 4, 32, 114, 162, 103, 118, 21, 181, 118, 113, 108, 108, 251, 142 }, new byte[] { 43, 3, 250, 153, 16, 31, 19, 131, 32, 97, 78, 82, 184, 255, 79, 29, 40, 76, 18, 139, 15, 53, 85, 23, 245, 129, 144, 86, 253, 90, 70, 206, 165, 45, 41, 94, 21, 153, 124, 13, 18, 58, 253, 246, 79, 162, 230, 175, 247, 57, 177, 4, 13, 17, 195, 105, 150, 222, 222, 1, 162, 48, 109, 140, 251, 213, 22, 68, 80, 226, 226, 216, 40, 238, 115, 23, 84, 164, 156, 191, 122, 156, 80, 253, 190, 0, 74, 91, 195, 196, 34, 104, 136, 214, 188, 167, 72, 252, 66, 208, 189, 175, 209, 51, 101, 210, 24, 237, 183, 52, 53, 143, 36, 78, 77, 33, 196, 74, 69, 189, 187, 255, 205, 7, 120, 212, 233, 55 } });

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "Email",
                keyValue: "test2",
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 30, 2, 148, 20, 115, 149, 11, 131, 144, 235, 13, 69, 226, 115, 101, 148, 47, 113, 2, 186, 102, 189, 147, 75, 10, 190, 223, 70, 225, 49, 250, 216, 182, 220, 244, 173, 49, 16, 32, 142, 112, 122, 12, 133, 9, 202, 33, 117, 105, 115, 4, 32, 114, 162, 103, 118, 21, 181, 118, 113, 108, 108, 251, 142 }, new byte[] { 43, 3, 250, 153, 16, 31, 19, 131, 32, 97, 78, 82, 184, 255, 79, 29, 40, 76, 18, 139, 15, 53, 85, 23, 245, 129, 144, 86, 253, 90, 70, 206, 165, 45, 41, 94, 21, 153, 124, 13, 18, 58, 253, 246, 79, 162, 230, 175, 247, 57, 177, 4, 13, 17, 195, 105, 150, 222, 222, 1, 162, 48, 109, 140, 251, 213, 22, 68, 80, 226, 226, 216, 40, 238, 115, 23, 84, 164, 156, 191, 122, 156, 80, 253, 190, 0, 74, 91, 195, 196, 34, 104, 136, 214, 188, 167, 72, 252, 66, 208, 189, 175, 209, 51, 101, 210, 24, 237, 183, 52, 53, 143, 36, 78, 77, 33, 196, 74, 69, 189, 187, 255, 205, 7, 120, 212, 233, 55 } });

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "Email",
                keyValue: "test3",
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 30, 2, 148, 20, 115, 149, 11, 131, 144, 235, 13, 69, 226, 115, 101, 148, 47, 113, 2, 186, 102, 189, 147, 75, 10, 190, 223, 70, 225, 49, 250, 216, 182, 220, 244, 173, 49, 16, 32, 142, 112, 122, 12, 133, 9, 202, 33, 117, 105, 115, 4, 32, 114, 162, 103, 118, 21, 181, 118, 113, 108, 108, 251, 142 }, new byte[] { 43, 3, 250, 153, 16, 31, 19, 131, 32, 97, 78, 82, 184, 255, 79, 29, 40, 76, 18, 139, 15, 53, 85, 23, 245, 129, 144, 86, 253, 90, 70, 206, 165, 45, 41, 94, 21, 153, 124, 13, 18, 58, 253, 246, 79, 162, 230, 175, 247, 57, 177, 4, 13, 17, 195, 105, 150, 222, 222, 1, 162, 48, 109, 140, 251, 213, 22, 68, 80, 226, 226, 216, 40, 238, 115, 23, 84, 164, 156, 191, 122, 156, 80, 253, 190, 0, 74, 91, 195, 196, 34, 104, 136, 214, 188, 167, 72, 252, 66, 208, 189, 175, 209, 51, 101, 210, 24, 237, 183, 52, 53, 143, 36, 78, 77, 33, 196, 74, 69, 189, 187, 255, 205, 7, 120, 212, 233, 55 } });

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "Email",
                keyValue: "test4",
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 30, 2, 148, 20, 115, 149, 11, 131, 144, 235, 13, 69, 226, 115, 101, 148, 47, 113, 2, 186, 102, 189, 147, 75, 10, 190, 223, 70, 225, 49, 250, 216, 182, 220, 244, 173, 49, 16, 32, 142, 112, 122, 12, 133, 9, 202, 33, 117, 105, 115, 4, 32, 114, 162, 103, 118, 21, 181, 118, 113, 108, 108, 251, 142 }, new byte[] { 43, 3, 250, 153, 16, 31, 19, 131, 32, 97, 78, 82, 184, 255, 79, 29, 40, 76, 18, 139, 15, 53, 85, 23, 245, 129, 144, 86, 253, 90, 70, 206, 165, 45, 41, 94, 21, 153, 124, 13, 18, 58, 253, 246, 79, 162, 230, 175, 247, 57, 177, 4, 13, 17, 195, 105, 150, 222, 222, 1, 162, 48, 109, 140, 251, 213, 22, 68, 80, 226, 226, 216, 40, 238, 115, 23, 84, 164, 156, 191, 122, 156, 80, 253, 190, 0, 74, 91, 195, 196, 34, 104, 136, 214, 188, 167, 72, 252, 66, 208, 189, 175, 209, 51, 101, 210, 24, 237, 183, 52, 53, 143, 36, 78, 77, 33, 196, 74, 69, 189, 187, 255, 205, 7, 120, 212, 233, 55 } });

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "Email",
                keyValue: "test5",
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 30, 2, 148, 20, 115, 149, 11, 131, 144, 235, 13, 69, 226, 115, 101, 148, 47, 113, 2, 186, 102, 189, 147, 75, 10, 190, 223, 70, 225, 49, 250, 216, 182, 220, 244, 173, 49, 16, 32, 142, 112, 122, 12, 133, 9, 202, 33, 117, 105, 115, 4, 32, 114, 162, 103, 118, 21, 181, 118, 113, 108, 108, 251, 142 }, new byte[] { 43, 3, 250, 153, 16, 31, 19, 131, 32, 97, 78, 82, 184, 255, 79, 29, 40, 76, 18, 139, 15, 53, 85, 23, 245, 129, 144, 86, 253, 90, 70, 206, 165, 45, 41, 94, 21, 153, 124, 13, 18, 58, 253, 246, 79, 162, 230, 175, 247, 57, 177, 4, 13, 17, 195, 105, 150, 222, 222, 1, 162, 48, 109, 140, 251, 213, 22, 68, 80, 226, 226, 216, 40, 238, 115, 23, 84, 164, 156, 191, 122, 156, 80, 253, 190, 0, 74, 91, 195, 196, 34, 104, 136, 214, 188, 167, 72, 252, 66, 208, 189, 175, 209, 51, 101, 210, 24, 237, 183, 52, 53, 143, 36, 78, 77, 33, 196, 74, 69, 189, 187, 255, 205, 7, 120, 212, 233, 55 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Email",
                value: "test1");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Email",
                value: "test2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Email",
                value: "test3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Email",
                value: "test4");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Email",
                value: "test5");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Logins_Email",
                table: "Users",
                column: "Email",
                principalTable: "Logins",
                principalColumn: "Email",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
