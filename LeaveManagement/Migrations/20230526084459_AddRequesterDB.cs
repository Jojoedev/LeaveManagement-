using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Migrations
{
    public partial class AddRequesterDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RequesterId",
                table: "Requests",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Requesters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requesters", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Requests_RequesterId",
                table: "Requests",
                column: "RequesterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Requesters_RequesterId",
                table: "Requests",
                column: "RequesterId",
                principalTable: "Requesters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Requesters_RequesterId",
                table: "Requests");

            migrationBuilder.DropTable(
                name: "Requesters");

            migrationBuilder.DropIndex(
                name: "IX_Requests_RequesterId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "RequesterId",
                table: "Requests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf65ce0b-8c04-4c70-a124-78b4dbd87613",
                column: "ConcurrencyStamp",
                value: "76693b88-8183-4543-8080-c8a65f808d00");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf65ce0b-8c04-4c70-a124-78b4dbd87666",
                column: "ConcurrencyStamp",
                value: "520e303b-a83c-450e-b882-1a2c7b5b1d67");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf65ce0b-8c04-4c70-a124-78b4dbd87667",
                column: "ConcurrencyStamp",
                value: "9aebf103-b306-4bd4-b6f7-b5f460c730d1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87311",
                column: "ConcurrencyStamp",
                value: "31ccc3eb-d507-4ebe-a7b9-ede04ef6a07f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93fd5a9f - 677a - 4998 - a010 - 16b997082241",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1efddff4-5376-4f35-8f25-5d26b2445497", "AQAAAAEAACcQAAAAEDsrMMeDX/rKyb+xeP810v3/M+G34jaLQAMWv/MRBcubBCFdWmosVLBjjOtMwMj+Yg==", "ee809351-90e7-44d0-b71a-4d1790005364" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93fd5a9f - 677a - 4998 - a010 - 16b997082282",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "821f37b4-c2ff-4867-bbe2-43e279e68ab5", "AQAAAAEAACcQAAAAEH6QuL4Jz9mTIKmFiPssqzymJ5uJmBWhcyAVu3u2eR1oOPvzbqu5/SVEl/2PO/1vRw==", "891a3ea2-43e8-46fa-8869-3a39c026b732" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf23ce0b - 7c06 - 3c70 - a124 - 78b4dbd87230",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da982bc2-7a87-4d06-9752-08c645089673", "AQAAAAEAACcQAAAAEPpscIjlUt4ttGZx9SMQvZMNvMt6js33W6QTtxByA1OHzR9x1WaNXynSp7kPHExiMw==", "68d7a9f9-793b-4b76-adf9-4c184669d0ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87340",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97c7dc56-d944-4b8c-86e9-d8c5a8d9b94e", "AQAAAAEAACcQAAAAEOoSrDx2E8rXL93wNrAIZMsmmm/eK0cDPunTxNHwCAXS+wY0NFQLZPAHK5P/gufIGw==", "cc439ec4-b06c-4579-805a-560959e8e34c" });
        }
    }
}
