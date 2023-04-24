using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectName.Infra.Migrations
{
    /// <inheritdoc />
    public partial class OrgUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8679e4f2-0e9d-4108-932b-d58071e18818");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ccbd2e75-89c1-4402-9fe3-986dbef4587d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ApiUserId", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "10a05c73-ba58-437a-9e32-9df937618fca", null, null, "User", "USER" },
                    { "868bb11d-1007-4a05-9ad5-547b1845d82a", null, null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Orgs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { "Monday, 24 April 2023", "Monday, 24 April 2023" });

            migrationBuilder.UpdateData(
                table: "Orgs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { "Monday, 24 April 2023", "Monday, 24 April 2023" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10a05c73-ba58-437a-9e32-9df937618fca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "868bb11d-1007-4a05-9ad5-547b1845d82a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ApiUserId", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8679e4f2-0e9d-4108-932b-d58071e18818", null, null, "Administrator", "ADMINISTRATOR" },
                    { "ccbd2e75-89c1-4402-9fe3-986dbef4587d", null, null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Orgs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { "Monday, 1 January 0001", "Monday, 1 January 0001" });

            migrationBuilder.UpdateData(
                table: "Orgs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { "Monday, 1 January 0001", "Monday, 1 January 0001" });
        }
    }
}
