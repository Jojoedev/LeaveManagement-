using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Migrations
{
    public partial class NewUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf65ce0b-8c04-4c70-a124-78b4dbd87613",
                column: "ConcurrencyStamp",
                value: "2502556f-c7d7-4fae-9559-3aee76a15940");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf65ce0b-8c04-4c70-a124-78b4dbd87666",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "23684525-98fb-46f8-888b-0767cea47645", "IT" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87311",
                column: "ConcurrencyStamp",
                value: "1cdbc5a1-fb1f-436f-b2fb-96df87e35640");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93fd5a9f - 677a - 4998 - a010 - 16b997082282",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24b6fa9a-34da-4928-81a5-a57d47451d46", "AQAAAAEAACcQAAAAEJ2fKF64c+sXNzBvxp9+NJ4sGFGAIFBuYYLHj/9xBkFdSNfnlJ8dG1kil0gLqfTSPw==", "6c846063-3752-478f-82e3-ae4ea50849bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf23ce0b - 7c06 - 3c70 - a124 - 78b4dbd87230",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b137ea0-ae23-4d42-b812-3303db350f6b", "AQAAAAEAACcQAAAAEGTB0uFGwlLRmDPmqIvskKiFeU+hWwhkLRCGsEb3gIVn4eXD81Me+SImTU4CLHkxNw==", "9ae19a2f-45ba-456d-86e2-0d727bf51769" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87340",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1bdacb3-5b95-427c-9a69-f05ace399778", "AQAAAAEAACcQAAAAEGHmoaDuFb5OZBQds1Jmi49JXQxPYcJsIuffYhwHGU049KYLlILj6TbkhMU4ptMGRA==", "405d71f2-d572-4520-a6fd-e4e1d8f58942" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "9548363f-6601-440e-b1be-dcf40bc4299f", "USER" });

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
    }
}
