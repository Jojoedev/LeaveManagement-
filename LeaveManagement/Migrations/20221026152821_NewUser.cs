using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Migrations
{
    public partial class NewUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf65ce0b-8c04-4c70-a124-78b4dbd87613",
                column: "ConcurrencyStamp",
                value: "b3485b35-0693-4c24-b404-a15ebc2f3c2e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87311",
                column: "ConcurrencyStamp",
                value: "8dd951e1-8ba2-4545-a8f4-d2c9fc0c217a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bf65ce0b-8c04-4c70-a124-78b4dbd87666", "27b96559-c3c6-4892-b537-9b8d62b4ddd7", "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf23ce0b - 7c06 - 3c70 - a124 - 78b4dbd87230",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4168901c-d599-43b5-83c9-4524dab3abc0", "AQAAAAEAACcQAAAAEIkAAPMcBbN1pEUZbAtJeIl/Tj5xaPoD25eFOc/6WWj1O7fVZw0hJmzqGCR/lz/ZKA==", "37f4cca4-15a5-4bbf-9a53-839aaa0df8fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87340",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43cb3df8-5f17-434c-a504-593305541a27", "AQAAAAEAACcQAAAAEIoIsVI5MBX1/v9g4+1Huepq7KzyWbDL9sdqaPVAcGMw+ezDpLN12SfyVBXvEUVy9Q==", "4991c369-7814-4205-81c8-b157ebcc327d" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "93fd5a9f - 677a - 4998 - a010 - 16b997082282", 0, "0be081f7-bce1-450f-8266-dfa5a12d8e8e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "yus@yahoo.com", true, "BABATUNDE", "Yusuf", false, null, "YUS@YAHOO.COM", "YUS@YAHOO.COM", "AQAAAAEAACcQAAAAEPSJ7Pq7LE51iPOI0QgnLk/yGcQitZmmzzWQ8zGKjEgL+PC+0K8HA0f7XYDNGjPVTQ==", null, false, "f456d7df-cc13-42fa-babc-bf4ce7a5ad87", null, false, "yus@YAHOO.COM" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bf65ce0b-8c04-4c70-a124-78b4dbd87666", "93fd5a9f - 677a - 4998 - a010 - 16b997082282" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bf65ce0b-8c04-4c70-a124-78b4dbd87666", "93fd5a9f - 677a - 4998 - a010 - 16b997082282" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf65ce0b-8c04-4c70-a124-78b4dbd87666");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93fd5a9f - 677a - 4998 - a010 - 16b997082282");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf65ce0b-8c04-4c70-a124-78b4dbd87613",
                column: "ConcurrencyStamp",
                value: "c375bb7a-c7c3-4e0a-968c-c6654bfdd927");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87311",
                column: "ConcurrencyStamp",
                value: "1e81f28b-aeae-425c-b6f9-e8befcd6773c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf23ce0b - 7c06 - 3c70 - a124 - 78b4dbd87230",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1bffb53-e5d4-4475-a6ac-186025a1820e", "AQAAAAEAACcQAAAAEB3qgL7bD2ZnZrxU4+x1hxvLZ9ixIpnYVRBYDspeJp5Tqtl/eoLCDH2fl9a0IgCxAQ==", "a17fa92c-4f9a-4dd3-9566-579e46d6d220" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87340",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57f6315c-1e0e-41cc-bd0d-9668a0fa4757", "AQAAAAEAACcQAAAAEDUAm6TDr0XRID6Ko7jNnzqBDZX3U7eORlj4kjLWEfYvGh84ZnnNzQihFyv6Im9tfw==", "7af21904-1753-4860-8e1a-bfbedc12411f" });
        }
    }
}
