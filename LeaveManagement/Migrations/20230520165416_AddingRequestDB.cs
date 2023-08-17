using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Migrations
{
    public partial class AddingRequestDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Requests");

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
    }
}
