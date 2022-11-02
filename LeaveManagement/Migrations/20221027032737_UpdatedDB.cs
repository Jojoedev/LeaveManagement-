using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Migrations
{
    public partial class UpdatedDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bf65ce0b-8c04-4c70-a124-78b4dbd87666", "93fd5a9f - 677a - 4998 - a010 - 16b997082282" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bf65ce0b-8c04-4c70-a124-78b4dbd87613", "bf23ce0b - 7c06 - 3c70 - a124 - 78b4dbd87230" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87311", "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87340" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf65ce0b-8c04-4c70-a124-78b4dbd87613");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf65ce0b-8c04-4c70-a124-78b4dbd87666");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87311");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93fd5a9f - 677a - 4998 - a010 - 16b997082282");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf23ce0b - 7c06 - 3c70 - a124 - 78b4dbd87230");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87340");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bf65ce0b-8c04-4c70-a124-78b4dbd87613", "93e02120-37eb-434f-a066-2feee03c6689", "User", "USER" },
                    { "bf65ce0b-8c04-4c70-a124-78b4dbd87666", "bb42a584-a52f-4cef-a289-8d8b290b4979", "IT", "IT" },
                    { "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87311", "b4972f8f-58ba-4435-91f1-901d570faace", "Adminstrator", "ADMINSTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "93fd5a9f - 677a - 4998 - a010 - 16b997082282", 0, "d141208d-1b5a-44d7-b548-10ebf8c16617", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "yus@yahoo.com", true, "BABATUNDE", "Yusuf", false, null, "YUS@YAHOO.COM", "YUS@YAHOO.COM", "AQAAAAEAACcQAAAAEB0YferQoSOApg65Xa3SsbV3A1w/0TldYV1dlgif/7B/FHJcnKoHhZ/yI7cYPnDA+w==", null, false, "66be1e84-3539-4dc8-b10f-8f857d4521b1", null, false, "yus@YAHOO.COM" },
                    { "bf23ce0b - 7c06 - 3c70 - a124 - 78b4dbd87230", 0, "4f555b21-dde6-4cd0-825e-ca3cce650f4f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jojoe@yahoo.com", true, "JOE", "JO", false, null, "JOJOE@YAHOO.COM", "JOJOE@YAHOO.COM", "AQAAAAEAACcQAAAAEHG1nj4Iw1pvPjQSNywTSuPt5JdP7isswe5dq/NJoMfovfT7g+t7I6yhB+y+uhqpXw==", null, false, "2dc31e01-9e28-47c9-b2df-3464d02119f4", null, false, "jojoe@YAHOO.COM" },
                    { "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87340", 0, "7d53a5bf-1308-4854-8df7-eff79c84fbe2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "doc@yahoo.com", true, "DON", "DOC", false, null, "DOCS@YAHOO.COM", "DOC@YAHOO.COM", "AQAAAAEAACcQAAAAEA+EV2UC+ZzAfPrPf+nRpaFx9A96G3nCepYYS99btSsngNDl1gkCMVuY7Bw9ZG/z7w==", null, false, "6f66b7a6-d0f4-4d64-bdb8-bbaa4fe89527", null, false, "doc@yahoo.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bf65ce0b-8c04-4c70-a124-78b4dbd87666", "93fd5a9f - 677a - 4998 - a010 - 16b997082282" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bf65ce0b-8c04-4c70-a124-78b4dbd87613", "bf23ce0b - 7c06 - 3c70 - a124 - 78b4dbd87230" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87311", "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87340" });
        }
    }
}
