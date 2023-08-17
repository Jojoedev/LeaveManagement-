using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Migrations
{
    public partial class AddRequesterDBAdj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf65ce0b-8c04-4c70-a124-78b4dbd87613",
                column: "ConcurrencyStamp",
                value: "ea2c2543-1468-4abb-a91c-2e788c830c37");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf65ce0b-8c04-4c70-a124-78b4dbd87666",
                column: "ConcurrencyStamp",
                value: "0e4373ee-922d-4177-a673-1ac80983c8ec");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf65ce0b-8c04-4c70-a124-78b4dbd87667",
                column: "ConcurrencyStamp",
                value: "67de4e1b-1550-429d-8e65-443fad783ea3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87311",
                column: "ConcurrencyStamp",
                value: "0f9e6aa0-5e3c-4402-ac9a-f0a950a81cdf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93fd5a9f - 677a - 4998 - a010 - 16b997082241",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1586def0-2ff0-4753-bfff-696f1a94c676", "AQAAAAEAACcQAAAAEAvuoRSyjn8GAvG6ZoJE8vCmd1DOFag1GUETcrx+26fmQ2LZQljBT/QxZWuFKU/yJw==", "a492d5df-2132-4258-9637-4a61c2a9b353" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93fd5a9f - 677a - 4998 - a010 - 16b997082282",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f24c93e8-9fdd-4ba3-b08b-82acb62c2c65", "AQAAAAEAACcQAAAAENLxUKYHs2d1a0L+W9NYwnKuUUqugNtYKmcfdm6v4qfkXPwOIXnjCMn6qGfGpqxwBg==", "65ca8dfe-0dac-46f5-8294-c80201561744" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf23ce0b - 7c06 - 3c70 - a124 - 78b4dbd87230",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a1f30e7-de98-4feb-a077-e5ee9837d462", "AQAAAAEAACcQAAAAELYQH0vM6soTecbeOcB0z5qdTW8Eo4nQk155pNQ5AKEZtAqlmXxropqvRpaqrHiOCQ==", "4ab39b4c-d291-4277-b3f6-3fbf873a6baa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87340",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "818a06c6-6a32-436b-bc94-269d80348529", "AQAAAAEAACcQAAAAEKErYXv+AJeBoHrRO5w4/bJJRTp+52fdMlZvLsBoYr6i39VPocWU3gL38r/no/0Rvg==", "288d432f-71a6-4566-9d95-e84a4dec3215" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf65ce0b-8c04-4c70-a124-78b4dbd87613",
                column: "ConcurrencyStamp",
                value: "cf8d99e5-7706-458b-9706-8a9327acf4d9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf65ce0b-8c04-4c70-a124-78b4dbd87666",
                column: "ConcurrencyStamp",
                value: "54ec9707-7d6d-4a89-9f94-2efa0511bd85");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf65ce0b-8c04-4c70-a124-78b4dbd87667",
                column: "ConcurrencyStamp",
                value: "76d7e61e-8411-47bb-aa19-1d401204a16c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87311",
                column: "ConcurrencyStamp",
                value: "eb3a342b-ff37-43f0-a834-66a5550f291d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93fd5a9f - 677a - 4998 - a010 - 16b997082241",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3462d2d-bde5-4260-a4cf-e5394bf92ac4", "AQAAAAEAACcQAAAAEL4zU37ulk1t5BRM3kTEZdw/3IEC6/wK1v0iCKICaIcJ6ecZYO5l3JmFl14zuMlh+Q==", "a7aa80c9-3834-4f42-a9db-3fcfae618dbe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93fd5a9f - 677a - 4998 - a010 - 16b997082282",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d730f69-a167-462c-ab88-d42085be701c", "AQAAAAEAACcQAAAAENsM6zz1hRxXYDEe+iONMcPNbOzhllzAJy0YnCnczoK5yYpm1aW3x48VEhe7X2q2pg==", "71a1682d-6914-42ab-8b81-db376bed7fc6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf23ce0b - 7c06 - 3c70 - a124 - 78b4dbd87230",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f88aebc-2830-485e-8d8e-1970adfdfd05", "AQAAAAEAACcQAAAAEKhGwZH2PVNlWJyyP6AgY7J+shC9Roc1hB+85z2U3I36oJOu99rrD0oPsgsbTd1XrA==", "b9c8edb2-aa5c-4d6e-8694-5413d24116c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87340",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c29bcbf4-e070-428f-a2c4-6f29d04f0373", "AQAAAAEAACcQAAAAECozNVQ5rLwLHmE8XsA9dlXjP69aTPKM0Hpu/LbHQKGcxvWqtSI7pBJai6IlrRlRxg==", "02195891-966d-4fa2-b512-5d1e62f1b5d8" });
        }
    }
}
