using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class AddImageComponentConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0473f66f-b928-4a67-a201-eb0ac0c010a8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c923d23-dc94-4bf0-bc15-e65c910df624");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c6632b9-6813-49d4-9298-11575ed36ae1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8dd35d7-c86f-4f85-8afc-c7321c599139");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Configuration",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Component",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "131753e5-ddd6-4248-bfbc-7cc35babf8d2", null, "Technician", "TECHNICIAN" },
                    { "658de90f-0650-4130-bc9f-d01273814dab", null, "SalesStaff", "SALESSTAFF" },
                    { "808fccb6-71ac-48cf-a94d-1d9192d8ba40", null, "Admin", "ADMIN" },
                    { "e2286239-cb9a-430e-a1a5-7f1dfc65b811", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "131753e5-ddd6-4248-bfbc-7cc35babf8d2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "658de90f-0650-4130-bc9f-d01273814dab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "808fccb6-71ac-48cf-a94d-1d9192d8ba40");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2286239-cb9a-430e-a1a5-7f1dfc65b811");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Configuration");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Component");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0473f66f-b928-4a67-a201-eb0ac0c010a8", null, "Admin", "ADMIN" },
                    { "5c923d23-dc94-4bf0-bc15-e65c910df624", null, "Technician", "TECHNICIAN" },
                    { "6c6632b9-6813-49d4-9298-11575ed36ae1", null, "User", "USER" },
                    { "d8dd35d7-c86f-4f85-8afc-c7321c599139", null, "SalesStaff", "SALESSTAFF" }
                });
        }
    }
}
