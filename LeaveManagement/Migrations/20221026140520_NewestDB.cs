using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Migrations
{
    public partial class NewestDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bf65ce0b-8c04-4c70-a124-78b4dbd87613", "c375bb7a-c7c3-4e0a-968c-c6654bfdd927", "User", "USER" },
                    { "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87311", "1e81f28b-aeae-425c-b6f9-e8befcd6773c", "Adminstrator", "ADMINSTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "bf23ce0b - 7c06 - 3c70 - a124 - 78b4dbd87230", 0, "a1bffb53-e5d4-4475-a6ac-186025a1820e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jojoe@yahoo.com", true, "JOE", "JO", false, null, "JOJOE@YAHOO.COM", "JOJOE@YAHOO.COM", "AQAAAAEAACcQAAAAEB3qgL7bD2ZnZrxU4+x1hxvLZ9ixIpnYVRBYDspeJp5Tqtl/eoLCDH2fl9a0IgCxAQ==", null, false, "a17fa92c-4f9a-4dd3-9566-579e46d6d220", null, false, "jojoe@YAHOO.COM" },
                    { "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87340", 0, "57f6315c-1e0e-41cc-bd0d-9668a0fa4757", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "doc@yahoo.com", true, "DON", "DOC", false, null, "DOCS@YAHOO.COM", "DOC@YAHOO.COM", "AQAAAAEAACcQAAAAEDUAm6TDr0XRID6Ko7jNnzqBDZX3U7eORlj4kjLWEfYvGh84ZnnNzQihFyv6Im9tfw==", null, false, "7af21904-1753-4860-8e1a-bfbedc12411f", null, false, "doc@yahoo.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bf65ce0b-8c04-4c70-a124-78b4dbd87613", "bf23ce0b - 7c06 - 3c70 - a124 - 78b4dbd87230" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87311", "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87340" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValue: "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87311");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf23ce0b - 7c06 - 3c70 - a124 - 78b4dbd87230");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87340");
        }
    }
}
