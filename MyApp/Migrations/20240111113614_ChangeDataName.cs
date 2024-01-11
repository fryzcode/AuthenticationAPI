using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyApp.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDataName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39e1ce2f-9e97-4b5f-af5e-d0ccfa2a856e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75bf08e3-d59b-4901-9337-7abee6719cca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d19a6257-da58-4ab9-970d-0e2147c1f7a8");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "39e1ce2f-9e97-4b5f-af5e-d0ccfa2a856e", "1", "Admin", "Admin" },
                    { "75bf08e3-d59b-4901-9337-7abee6719cca", "2", "User", "User" },
                    { "d19a6257-da58-4ab9-970d-0e2147c1f7a8", "3", "HR", "HR" }
                });
        }
    }
}
