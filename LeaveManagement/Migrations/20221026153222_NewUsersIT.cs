using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Migrations
{
    public partial class NewUsersIT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf65ce0b-8c04-4c70-a124-78b4dbd87613",
                column: "ConcurrencyStamp",
                value: "b414f399-7b9d-4291-855e-558e4f34e45c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf65ce0b-8c04-4c70-a124-78b4dbd87666",
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "bbdbe9a5-9a99-4f60-ad44-3e593a46fea4", "IT" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87311",
                column: "ConcurrencyStamp",
                value: "ad3d2eb9-e1ea-45b9-9bec-95305804f044");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93fd5a9f - 677a - 4998 - a010 - 16b997082282",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd510972-a61b-4608-a849-8ec4091c8320", "AQAAAAEAACcQAAAAECyvT/AQ9ivtPyjoCeihKCZDHP12UqzudvHjlxQzcyaUArImBsJyyppOEJj1Dm3lsg==", "0d6d0109-ac2c-4ec0-8c62-ddc030d55fc2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf23ce0b - 7c06 - 3c70 - a124 - 78b4dbd87230",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6bb6fa42-6aae-4358-9942-97d241dbc990", "AQAAAAEAACcQAAAAEHc7L1HukV7w2kCmQbXsom7JD9taMI4jpCmvlpNifq+N4kiasLCY2cK/Ll4m0VeB7Q==", "ad7b977d-759c-4ad5-a413-0141d1567948" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87340",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a7293a2-14df-496c-9d59-0738617e9cac", "AQAAAAEAACcQAAAAENV0EMZ6E7bery//9L/e5EVUcM9U0Ih3+0PCf5Bo2nGLZVksYYtHwj6m8L5KrPF07Q==", "e5822d37-1cb6-451d-97b3-f07589d12375" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: "bf65ce0b-8c04-4c70-a124-78b4dbd87666",
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "27b96559-c3c6-4892-b537-9b8d62b4ddd7", "User" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87311",
                column: "ConcurrencyStamp",
                value: "8dd951e1-8ba2-4545-a8f4-d2c9fc0c217a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93fd5a9f - 677a - 4998 - a010 - 16b997082282",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0be081f7-bce1-450f-8266-dfa5a12d8e8e", "AQAAAAEAACcQAAAAEPSJ7Pq7LE51iPOI0QgnLk/yGcQitZmmzzWQ8zGKjEgL+PC+0K8HA0f7XYDNGjPVTQ==", "f456d7df-cc13-42fa-babc-bf4ce7a5ad87" });

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
        }
    }
}
