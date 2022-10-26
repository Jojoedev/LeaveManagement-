using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Migrations
{
    public partial class NewUSeedings : Migration
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
                    { "bf65ce0b-8c04-4c70-a124-78b4dbd87613", "2502556f-c7d7-4fae-9559-3aee76a15940", "User", "USER" },
                    { "bf65ce0b-8c04-4c70-a124-78b4dbd87666", "23684525-98fb-46f8-888b-0767cea47645", "IT", "IT" },
                    { "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87311", "1cdbc5a1-fb1f-436f-b2fb-96df87e35640", "Adminstrator", "ADMINSTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "93fd5a9f - 677a - 4998 - a010 - 16b997082282", 0, "24b6fa9a-34da-4928-81a5-a57d47451d46", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "yus@yahoo.com", true, "BABATUNDE", "Yusuf", false, null, "YUS@YAHOO.COM", "YUS@YAHOO.COM", "AQAAAAEAACcQAAAAEJ2fKF64c+sXNzBvxp9+NJ4sGFGAIFBuYYLHj/9xBkFdSNfnlJ8dG1kil0gLqfTSPw==", null, false, "6c846063-3752-478f-82e3-ae4ea50849bd", null, false, "yus@YAHOO.COM" },
                    { "bf23ce0b - 7c06 - 3c70 - a124 - 78b4dbd87230", 0, "5b137ea0-ae23-4d42-b812-3303db350f6b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jojoe@yahoo.com", true, "JOE", "JO", false, null, "JOJOE@YAHOO.COM", "JOJOE@YAHOO.COM", "AQAAAAEAACcQAAAAEGTB0uFGwlLRmDPmqIvskKiFeU+hWwhkLRCGsEb3gIVn4eXD81Me+SImTU4CLHkxNw==", null, false, "9ae19a2f-45ba-456d-86e2-0d727bf51769", null, false, "jojoe@YAHOO.COM" },
                    { "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87340", 0, "d1bdacb3-5b95-427c-9a69-f05ace399778", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "doc@yahoo.com", true, "DON", "DOC", false, null, "DOCS@YAHOO.COM", "DOC@YAHOO.COM", "AQAAAAEAACcQAAAAEGHmoaDuFb5OZBQds1Jmi49JXQxPYcJsIuffYhwHGU049KYLlILj6TbkhMU4ptMGRA==", null, false, "405d71f2-d572-4520-a6fd-e4e1d8f58942", null, false, "doc@yahoo.com" }
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
