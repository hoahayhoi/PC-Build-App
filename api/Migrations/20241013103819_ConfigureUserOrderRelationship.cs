using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class ConfigureUserOrderRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d322a40d-17ff-4062-8314-7291f752eb93");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd65fdc4-cb86-4d25-b887-4f95e635149a");

            migrationBuilder.AddColumn<string>(
                name: "SalesStaffID",
                table: "Order",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TechnicianID",
                table: "Order",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d6973bcf-376c-4287-83aa-0f5d6f79a6fb", null, "Admin", "ADMIN" },
                    { "e2acee0a-3f66-4cbc-9d28-3530ff486c2a", null, "User", "USER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_SalesStaffID",
                table: "Order",
                column: "SalesStaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_TechnicianID",
                table: "Order",
                column: "TechnicianID");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_AspNetUsers_SalesStaffID",
                table: "Order",
                column: "SalesStaffID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_AspNetUsers_TechnicianID",
                table: "Order",
                column: "TechnicianID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_AspNetUsers_SalesStaffID",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_AspNetUsers_TechnicianID",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_SalesStaffID",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_TechnicianID",
                table: "Order");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6973bcf-376c-4287-83aa-0f5d6f79a6fb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2acee0a-3f66-4cbc-9d28-3530ff486c2a");

            migrationBuilder.DropColumn(
                name: "SalesStaffID",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "TechnicianID",
                table: "Order");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d322a40d-17ff-4062-8314-7291f752eb93", null, "Admin", "ADMIN" },
                    { "dd65fdc4-cb86-4d25-b887-4f95e635149a", null, "User", "USER" }
                });
        }
    }
}
