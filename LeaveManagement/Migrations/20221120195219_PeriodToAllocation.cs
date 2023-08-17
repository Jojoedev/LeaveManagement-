using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Migrations
{
    public partial class PeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf65ce0b-8c04-4c70-a124-78b4dbd87613",
                column: "ConcurrencyStamp",
                value: "558ff3a8-c6e1-4ac0-aac9-6076bd462e2b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf65ce0b-8c04-4c70-a124-78b4dbd87666",
                column: "ConcurrencyStamp",
                value: "3f010c8a-f530-4e2b-936b-d02f4f25fa0c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf65ce0b-8c04-4c70-a124-78b4dbd87667",
                column: "ConcurrencyStamp",
                value: "56d0a581-589d-4551-b37b-b21564d9d1a8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87311",
                column: "ConcurrencyStamp",
                value: "6c9ca99e-7150-4c74-8ec7-e3adfc148cf1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93fd5a9f - 677a - 4998 - a010 - 16b997082241",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5165ecf9-bea6-4408-b4a1-5335d3f31b65", "AQAAAAEAACcQAAAAEBHTbes+v/C1reeAk7oRTnC/0+ea8GBEsHD66z7Wg7TYI3UnmhtcxU1mB9eFiIMUKQ==", "465e4f5a-62be-454f-a790-04d9a54b3a1d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93fd5a9f - 677a - 4998 - a010 - 16b997082282",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "748a91a7-ae56-462f-af0f-f52096eb1bf5", "AQAAAAEAACcQAAAAEIsIvCWs+WhY9fHfojGxtqoSz5PATi45bbdWozYxJr30rXIq7rnKBA9reuoLGoTHpw==", "7aa867ab-1692-46eb-a2c3-1be3e2dee485" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf23ce0b - 7c06 - 3c70 - a124 - 78b4dbd87230",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "acb859ec-6294-44fd-9892-a91e23f1f745", "AQAAAAEAACcQAAAAEIX666SPEfl4gaMvXLtXdmXxozlrbixbZRvUTUhzWLgDsUkcm4Ic1JAVoXHOkSEcJQ==", "3bb0c8a2-d9bd-4b83-ba85-b8a70fd6acdf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87340",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de08f42a-424a-4051-bfff-270aa665e034", "AQAAAAEAACcQAAAAEKZwe5syEwe6LcpW8nF8FW1GnYiBVFUsqnLSxITzKzXiJ6SPCn98GF7iuyVMJ1O4RA==", "5bdf82cc-43cd-49a4-8277-5567ec859f6d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf65ce0b-8c04-4c70-a124-78b4dbd87613",
                column: "ConcurrencyStamp",
                value: "c2deac11-586d-4413-bfa0-afd77fce714f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf65ce0b-8c04-4c70-a124-78b4dbd87666",
                column: "ConcurrencyStamp",
                value: "2128b72f-1180-4d67-a887-1b08c0533db8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf65ce0b-8c04-4c70-a124-78b4dbd87667",
                column: "ConcurrencyStamp",
                value: "50d46c2a-af3f-44f3-b3ff-32d4edefed5d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87311",
                column: "ConcurrencyStamp",
                value: "68356539-286a-4abf-b368-2f7660d3a372");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93fd5a9f - 677a - 4998 - a010 - 16b997082241",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "782d71bf-892a-40fd-89eb-9cdaa8034640", "AQAAAAEAACcQAAAAEL5/EWQZpVHtrAIycMd8s4BIZPOf6+sLlwf2gi9uXnwDB5Vav/YcCqLvuimehf7ARg==", "c8b3317d-0486-4fc1-9d6a-62374106d187" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93fd5a9f - 677a - 4998 - a010 - 16b997082282",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca0038b8-6c72-46b3-a295-7c4871c11c2b", "AQAAAAEAACcQAAAAEGu2i9T3XcgZUVCFHRNwmsuwZpzwwiHuAcLdUG5tx2IuAYfs+qMZj5lCw6Wgjm+0Ag==", "df8a522d-11fc-4009-bb35-8310ac7f2346" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf23ce0b - 7c06 - 3c70 - a124 - 78b4dbd87230",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "677dcf82-3558-4e6c-b3fc-e9aae910be56", "AQAAAAEAACcQAAAAEJzEQ9hmHZqUMWdNlcjryJlamzpC1QSw8QpDFK/4FcqVQk87axm94nUKJ9EzWomLcQ==", "9c76221d-dd4e-4bc8-988b-734aea302a34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87340",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dac80205-f032-4846-8806-1195b5be7bc7", "AQAAAAEAACcQAAAAEJhjDr1re7Xx+00uVApgLJkSY+J8fM1QTcE81A/bAmHXkv6a6W6Y9OaHG/uW6lII+Q==", "bec7ab9e-6445-4572-8e00-5cb7f7ab0bdd" });
        }
    }
}
