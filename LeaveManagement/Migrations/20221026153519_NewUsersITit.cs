using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Migrations
{
    public partial class NewUsersITit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf65ce0b-8c04-4c70-a124-78b4dbd87613",
                column: "ConcurrencyStamp",
                value: "a0aaa05c-545f-4b06-8696-e33cabbb372e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf65ce0b-8c04-4c70-a124-78b4dbd87666",
                column: "ConcurrencyStamp",
                value: "9548363f-6601-440e-b1be-dcf40bc4299f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87311",
                column: "ConcurrencyStamp",
                value: "2a54c7c8-e9f6-4fd0-b492-8b903b2d419f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93fd5a9f - 677a - 4998 - a010 - 16b997082282",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54eebb7a-4cd5-4d49-8ee1-8575faf6bd96", "AQAAAAEAACcQAAAAEG7jBwBZ3J0mfQyJEeGfSEJeGnHWlgsByN2MRnRHvzkaSDSWWTv9hkMjalNZkzjBpg==", "f4b2cb66-9f49-4078-b158-30ee79161d59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf23ce0b - 7c06 - 3c70 - a124 - 78b4dbd87230",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6465151-6a15-4bf7-915d-5d67582beede", "AQAAAAEAACcQAAAAEMrnoG0SH6Y0iXfE+SxGSppOrYtpNigM+QlfORT3Uqu6ZZX3p0XYBywvl6k5BDYldA==", "11d9e9f0-8401-404a-a86b-f54f3f05b41e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87340",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ecc6ebe6-c302-4100-81d1-9f354ccbf2f8", "AQAAAAEAACcQAAAAECDCtI9QqxjoytjmuGxNjIK0O7Mo0Sj6GvnHSSpIX/2L2RQfYU4eqfJO4ilf7C8IBw==", "a976df16-86a1-440c-ab40-f40e3472b417" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                column: "ConcurrencyStamp",
                value: "bbdbe9a5-9a99-4f60-ad44-3e593a46fea4");

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
    }
}
