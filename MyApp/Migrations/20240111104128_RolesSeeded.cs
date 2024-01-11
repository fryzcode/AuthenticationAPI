using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyApp.Migrations
{
    /// <inheritdoc />
    public partial class RolesSeeded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
