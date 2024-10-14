using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class OrderToConfigurationOneToOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "263860ec-49bb-4cfe-8032-feff0851c0db");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2730c7e3-a404-4171-a2a5-26bfbd2d1f5a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37033e2b-2db5-4053-9884-1f7c8cd15c0c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80d59ce2-0123-4ef6-b384-8fa95c3e34dc");

            migrationBuilder.AddColumn<int>(
                name: "ConfigurationID",
                table: "Order",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Order_ConfigurationID",
                table: "Order",
                column: "ConfigurationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Configuration_ConfigurationID",
                table: "Order",
                column: "ConfigurationID",
                principalTable: "Configuration",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Configuration_ConfigurationID",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_ConfigurationID",
                table: "Order");

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

            migrationBuilder.DropColumn(
                name: "ConfigurationID",
                table: "Order");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "263860ec-49bb-4cfe-8032-feff0851c0db", null, "Technician", "TECHNICIAN" },
                    { "2730c7e3-a404-4171-a2a5-26bfbd2d1f5a", null, "Admin", "ADMIN" },
                    { "37033e2b-2db5-4053-9884-1f7c8cd15c0c", null, "User", "USER" },
                    { "80d59ce2-0123-4ef6-b384-8fa95c3e34dc", null, "SalesStaff", "SALESSTAFF" }
                });
        }
    }
}
