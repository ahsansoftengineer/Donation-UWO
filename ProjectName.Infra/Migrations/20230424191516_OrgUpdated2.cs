using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectName.Infra.Migrations
{
    /// <inheritdoc />
    public partial class OrgUpdated2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a989162-29e1-4622-9f66-faa130bfe2a1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff4da87a-2fb6-4a9e-9abf-94eeb4343734");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ApiUserId", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3df04e5e-222c-4c60-9bcd-c8031b30c863", null, null, "User", "USER" },
                    { "e34dffea-d6c2-4f93-af8d-a5ff688bb994", null, null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Orgs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 24, 19, 15, 16, 81, DateTimeKind.Utc).AddTicks(7708), new DateTime(2023, 4, 24, 19, 15, 16, 81, DateTimeKind.Utc).AddTicks(7713) });

            migrationBuilder.UpdateData(
                table: "Orgs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 24, 19, 15, 16, 81, DateTimeKind.Utc).AddTicks(7715), new DateTime(2023, 4, 24, 19, 15, 16, 81, DateTimeKind.Utc).AddTicks(7716) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3df04e5e-222c-4c60-9bcd-c8031b30c863");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e34dffea-d6c2-4f93-af8d-a5ff688bb994");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ApiUserId", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3a989162-29e1-4622-9f66-faa130bfe2a1", null, null, "User", "USER" },
                    { "ff4da87a-2fb6-4a9e-9abf-94eeb4343734", null, null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Orgs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 24, 18, 15, 45, 586, DateTimeKind.Utc).AddTicks(2310), new DateTime(2023, 4, 24, 18, 15, 45, 586, DateTimeKind.Utc).AddTicks(2357) });

            migrationBuilder.UpdateData(
                table: "Orgs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 24, 18, 15, 45, 586, DateTimeKind.Utc).AddTicks(2359), new DateTime(2023, 4, 24, 18, 15, 45, 586, DateTimeKind.Utc).AddTicks(2359) });
        }
    }
}
