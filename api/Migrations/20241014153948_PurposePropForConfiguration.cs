using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class PurposePropForConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "23e04ffb-323d-46db-9dbd-2053e6d63633");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b56600ea-1038-4aef-b64f-48fb0783d78a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca180df1-076d-485f-bcbe-a99e80ab006a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f590b185-71ac-4a2e-9eb2-d0b88876b589");

            migrationBuilder.AddColumn<string>(
                name: "Purpose",
                table: "Configuration",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Purpose",
                table: "Configuration");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "23e04ffb-323d-46db-9dbd-2053e6d63633", null, "User", "USER" },
                    { "b56600ea-1038-4aef-b64f-48fb0783d78a", null, "SalesStaff", "SALESSTAFF" },
                    { "ca180df1-076d-485f-bcbe-a99e80ab006a", null, "Admin", "ADMIN" },
                    { "f590b185-71ac-4a2e-9eb2-d0b88876b589", null, "Technician", "TECHNICIAN" }
                });
        }
    }
}
