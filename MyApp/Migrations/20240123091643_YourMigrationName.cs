using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyApp.Migrations
{
    /// <inheritdoc />
    public partial class YourMigrationName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad9649cc-a37b-48b7-8c0e-5854068122d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da5397ea-0b79-4116-9627-e65bbce995f7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f418ed57-d270-4a45-9980-506bfc26b1f0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "016ff510-0b58-409d-9732-d73cbfcaad29", "1", "Admin", "Admin" },
                    { "50b324fe-0414-4a3a-9712-3a5c45f3ed5c", "2", "User", "User" },
                    { "c52730b2-9659-4bdd-997a-b32b6ff1ad72", "3", "HR", "HR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "016ff510-0b58-409d-9732-d73cbfcaad29");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50b324fe-0414-4a3a-9712-3a5c45f3ed5c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c52730b2-9659-4bdd-997a-b32b6ff1ad72");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad9649cc-a37b-48b7-8c0e-5854068122d9", "1", "Admin", "Admin" },
                    { "da5397ea-0b79-4116-9627-e65bbce995f7", "3", "HR", "HR" },
                    { "f418ed57-d270-4a45-9980-506bfc26b1f0", "2", "User", "User" }
                });
        }
    }
}
