using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf65ce0b-8c04-4c70-a124-78b4dbd87613",
                column: "ConcurrencyStamp",
                value: "db3957f6-7146-4a1f-a755-da8373d65b9d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf65ce0b-8c04-4c70-a124-78b4dbd87666",
                column: "ConcurrencyStamp",
                value: "5d2679ea-b4bb-4517-a986-81a599efd60e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf65ce0b-8c04-4c70-a124-78b4dbd87667",
                column: "ConcurrencyStamp",
                value: "eb6a4fc5-7e61-490f-9dde-937eae03c718");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87311",
                column: "ConcurrencyStamp",
                value: "3fbc936f-8a52-4fe8-b200-fa5c9bf40a88");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93fd5a9f - 677a - 4998 - a010 - 16b997082241",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8989194-a270-48c6-95fc-2175383d6f9c", "AQAAAAEAACcQAAAAEAgAALTH1t3INIiJKnjwGfAKyyp25vP9AQVH9Sv+58iu3rHtZwPqin4EYtOfBsTmiA==", "8cd3379c-38ce-424a-94c8-74eae3224588" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93fd5a9f - 677a - 4998 - a010 - 16b997082282",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cdc7cd01-59d9-4ba6-a7eb-508a6602ef15", "AQAAAAEAACcQAAAAEKLBAdrcDTuR67S1AEtox5CUC7PqD1g+ROF4HddyeQJlODtd+Qj0vFG8qeuCsmB8XQ==", "7eab04a5-fb1f-4486-a15f-106276db7218" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf23ce0b - 7c06 - 3c70 - a124 - 78b4dbd87230",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2963c53a-43a5-433d-986b-626fabb4ffc9", "AQAAAAEAACcQAAAAEEIJigrVE9Rq7J+4beWTaAdptvycVsnblPZKRto+V37okzzRMVh3NDrV+mET91LByg==", "ab7c281d-c3ab-4b45-8d16-e5363f6b5869" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87340",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a7108b1-e9f8-4ddb-9e19-a0ee4818ed3a", "AQAAAAEAACcQAAAAEJVp/wEnXECxa4gEcR4ngaowfIJH9diuL+mS7CCid6O90yiWmpieZdCpKXRXzmtKZQ==", "612ed85a-0734-41b2-8fb0-d52edcf57aa6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
