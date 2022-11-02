using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Migrations
{
    public partial class UpdatedDBNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bf65ce0b-8c04-4c70-a124-78b4dbd87613", "b8d2288c-8c1c-4346-89ea-ca281193bfbf", "User", "USER" },
                    { "bf65ce0b-8c04-4c70-a124-78b4dbd87666", "14fa5589-dec1-4a0a-8c2b-6f6511a30e87", "IT", "IT" },
                    { "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87311", "ad975088-5635-425d-b586-158f28dc00ed", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "93fd5a9f - 677a - 4998 - a010 - 16b997082282", 0, "10d97b23-bb4f-4e25-8f5d-2e8c56ce55bb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "yus@yahoo.com", true, "BABATUNDE", "Yusuf", false, null, "YUS@YAHOO.COM", "YUS@YAHOO.COM", "AQAAAAEAACcQAAAAEK+CgsXvYo6WmGAFB8A4fXNYccPy07hI52m/Fyu4ACj56zWv59DZhcjf2UNumoVoGA==", null, false, "dbf88d7b-a418-4dbf-b925-5bddd8bec0d1", null, false, "yus@YAHOO.COM" },
                    { "bf23ce0b - 7c06 - 3c70 - a124 - 78b4dbd87230", 0, "0c93e995-f13b-44d3-b592-6157553352b4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jojoe@yahoo.com", true, "JOE", "JO", false, null, "JOJOE@YAHOO.COM", "JOJOE@YAHOO.COM", "AQAAAAEAACcQAAAAEJvtAqO3Ha9gY8gt6gclvJ1vJ/bKTH1n+XnJ5gCgfCXImxc2goFa7Az23mPqS+Pitw==", null, false, "7dfde4ee-867e-434a-99f4-54d493296591", null, false, "jojoe@YAHOO.COM" },
                    { "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87340", 0, "e859cac4-110a-4170-87db-9cd4f64e2028", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "doc@yahoo.com", true, "DON", "DOC", false, null, "DOCS@YAHOO.COM", "DOC@YAHOO.COM", "AQAAAAEAACcQAAAAEHFVGjGXXakQ6iBnKL+Qff9U39WvIqWigfbTTrVn4fqPkncGkK+uydghczCFjyXdsQ==", null, false, "801e53a2-c7c9-4b65-980f-9e8f08472f77", null, false, "doc@yahoo.com" }
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
