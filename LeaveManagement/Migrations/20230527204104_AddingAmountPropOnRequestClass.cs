using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Migrations
{
    public partial class AddingAmountPropOnRequestClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Requests",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf65ce0b-8c04-4c70-a124-78b4dbd87613",
                column: "ConcurrencyStamp",
                value: "f8de6b43-a23b-4325-9cf8-c4e41f0f6929");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf65ce0b-8c04-4c70-a124-78b4dbd87666",
                column: "ConcurrencyStamp",
                value: "b46ebada-9f03-4aef-8249-b17ab3881db8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf65ce0b-8c04-4c70-a124-78b4dbd87667",
                column: "ConcurrencyStamp",
                value: "9146224f-421b-4a05-b8e2-a2d8dda044ca");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87311",
                column: "ConcurrencyStamp",
                value: "57025a00-91ef-4666-9192-1920b96e0c5a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93fd5a9f - 677a - 4998 - a010 - 16b997082241",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2aaee488-bb49-4866-a5ea-22db699ac0d6", "AQAAAAEAACcQAAAAEL31nGi0vCIPlE2koeK/L+EQ8r6DKa+Io3bGww6XV/GLPZizJF8iHTIjrH1Q6cjIxg==", "a9c7859f-bf6f-4411-84f7-b17402eba74f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93fd5a9f - 677a - 4998 - a010 - 16b997082282",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a1f55e6-1174-464d-97f3-c377d3be1262", "AQAAAAEAACcQAAAAEDWcVQErEW9nO4AMb8xOMCFnrAvtqJSc8ZyE5jN0yu+jmlhGCIJnWmhtxO86zy00rw==", "ab614685-5066-4f8e-9791-35e1ca3b37ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf23ce0b - 7c06 - 3c70 - a124 - 78b4dbd87230",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc224942-52ef-43f7-a6be-ba218bcbd16e", "AQAAAAEAACcQAAAAEAWkbWnDecBuEjJ6lQCpwb1eIcdsO+slFF4uwlKJ1U4x8iiTt72f0YPdY84aQZLQLw==", "06dd3188-b5f2-476c-be0d-90959804c29e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87340",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "259badcd-baba-4373-a42e-eff0b8ce9e80", "AQAAAAEAACcQAAAAEHHe6j0wSaioHsQneqHELmjugtoC9TuBYGgEem9QFj4RZXcbXjHXNMt/P/rx41eWkQ==", "3bc81db0-e7a7-4b8a-9da9-4c3af0a40500" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Requests");

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
    }
}
