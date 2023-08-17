using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Migrations
{
    public partial class ReseedDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoleModel");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bf65ce0b-8c04-4c70-a124-78b4dbd87613", "c2deac11-586d-4413-bfa0-afd77fce714f", "User", "USER" },
                    { "bf65ce0b-8c04-4c70-a124-78b4dbd87666", "2128b72f-1180-4d67-a887-1b08c0533db8", "IT", "IT" },
                    { "bf65ce0b-8c04-4c70-a124-78b4dbd87667", "50d46c2a-af3f-44f3-b3ff-32d4edefed5d", "Accounts", "ACCOUNTS" },
                    { "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87311", "68356539-286a-4abf-b368-2f7660d3a372", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "93fd5a9f - 677a - 4998 - a010 - 16b997082241", 0, "782d71bf-892a-40fd-89eb-9cdaa8034640", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "accts@yahoo.com", true, "Friday", "Onuh", false, null, "ACCTS@YAHOO.COM", "ACCTS@YAHOO.COM", "AQAAAAEAACcQAAAAEL5/EWQZpVHtrAIycMd8s4BIZPOf6+sLlwf2gi9uXnwDB5Vav/YcCqLvuimehf7ARg==", null, false, "c8b3317d-0486-4fc1-9d6a-62374106d187", null, false, "ACCTS@YAHOO.COM" },
                    { "93fd5a9f - 677a - 4998 - a010 - 16b997082282", 0, "ca0038b8-6c72-46b3-a295-7c4871c11c2b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "yus@yahoo.com", true, "BABATUNDE", "Yusuf", false, null, "YUS@YAHOO.COM", "YUS@YAHOO.COM", "AQAAAAEAACcQAAAAEGu2i9T3XcgZUVCFHRNwmsuwZpzwwiHuAcLdUG5tx2IuAYfs+qMZj5lCw6Wgjm+0Ag==", null, false, "df8a522d-11fc-4009-bb35-8310ac7f2346", null, false, "yus@YAHOO.COM" },
                    { "bf23ce0b - 7c06 - 3c70 - a124 - 78b4dbd87230", 0, "677dcf82-3558-4e6c-b3fc-e9aae910be56", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jojoe@yahoo.com", true, "JOE", "JO", false, null, "JOJOE@YAHOO.COM", "JOJOE@YAHOO.COM", "AQAAAAEAACcQAAAAEJzEQ9hmHZqUMWdNlcjryJlamzpC1QSw8QpDFK/4FcqVQk87axm94nUKJ9EzWomLcQ==", null, false, "9c76221d-dd4e-4bc8-988b-734aea302a34", null, false, "jojoe@YAHOO.COM" },
                    { "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87340", 0, "dac80205-f032-4846-8806-1195b5be7bc7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "doc@yahoo.com", true, "DON", "DOC", false, null, "DOCS@YAHOO.COM", "DOC@YAHOO.COM", "AQAAAAEAACcQAAAAEJhjDr1re7Xx+00uVApgLJkSY+J8fM1QTcE81A/bAmHXkv6a6W6Y9OaHG/uW6lII+Q==", null, false, "bec7ab9e-6445-4572-8e00-5cb7f7ab0bdd", null, false, "doc@yahoo.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "bf65ce0b-8c04-4c70-a124-78b4dbd87667", "93fd5a9f - 677a - 4998 - a010 - 16b997082241" },
                    { "bf65ce0b-8c04-4c70-a124-78b4dbd87666", "93fd5a9f - 677a - 4998 - a010 - 16b997082282" },
                    { "bf65ce0b-8c04-4c70-a124-78b4dbd87613", "bf23ce0b - 7c06 - 3c70 - a124 - 78b4dbd87230" },
                    { "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87311", "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87340" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bf65ce0b-8c04-4c70-a124-78b4dbd87667", "93fd5a9f - 677a - 4998 - a010 - 16b997082241" });

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
                keyValue: "bf65ce0b-8c04-4c70-a124-78b4dbd87667");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87311");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93fd5a9f - 677a - 4998 - a010 - 16b997082241");

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

            migrationBuilder.CreateTable(
                name: "RoleModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleModel", x => x.Id);
                });
        }
    }
}
