using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class AddNewRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6973bcf-376c-4287-83aa-0f5d6f79a6fb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2acee0a-3f66-4cbc-9d28-3530ff486c2a");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d6973bcf-376c-4287-83aa-0f5d6f79a6fb", null, "Admin", "ADMIN" },
                    { "e2acee0a-3f66-4cbc-9d28-3530ff486c2a", null, "User", "USER" }
                });
        }
    }
}
