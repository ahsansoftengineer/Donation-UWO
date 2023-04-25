using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectName.Infra.Migrations
{
    /// <inheritdoc />
    public partial class BG_CRUD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91bfb847-70e6-44f2-9ea2-f30e85384399");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e85883a9-4fe5-413f-a4d3-ff09f3e5b992");

            migrationBuilder.CreateTable(
                name: "BGs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BGs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ApiUserId", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b795e050-bd09-4989-bc2a-507945bf2c2a", null, null, "User", "USER" },
                    { "c92c50e4-a7f4-4aaf-bd6e-4f5da1faa576", null, null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "BGs",
                columns: new[] { "Id", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 25, 18, 54, 54, 487, DateTimeKind.Utc).AddTicks(1590), "BG 1 Description", "BG 1", new DateTime(2023, 4, 25, 18, 54, 54, 487, DateTimeKind.Utc).AddTicks(1591) },
                    { 2, new DateTime(2023, 4, 25, 18, 54, 54, 487, DateTimeKind.Utc).AddTicks(1613), "BG 2 Description", "BG 2", new DateTime(2023, 4, 25, 18, 54, 54, 487, DateTimeKind.Utc).AddTicks(1614) }
                });

            migrationBuilder.UpdateData(
                table: "Orgs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 25, 18, 54, 54, 487, DateTimeKind.Utc).AddTicks(1153), new DateTime(2023, 4, 25, 18, 54, 54, 487, DateTimeKind.Utc).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "Orgs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 25, 18, 54, 54, 487, DateTimeKind.Utc).AddTicks(1162), new DateTime(2023, 4, 25, 18, 54, 54, 487, DateTimeKind.Utc).AddTicks(1163) });

            migrationBuilder.UpdateData(
                table: "Systemzs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 25, 18, 54, 54, 487, DateTimeKind.Utc).AddTicks(1390), new DateTime(2023, 4, 25, 18, 54, 54, 487, DateTimeKind.Utc).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "Systemzs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 25, 18, 54, 54, 487, DateTimeKind.Utc).AddTicks(1393), new DateTime(2023, 4, 25, 18, 54, 54, 487, DateTimeKind.Utc).AddTicks(1393) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BGs");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b795e050-bd09-4989-bc2a-507945bf2c2a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c92c50e4-a7f4-4aaf-bd6e-4f5da1faa576");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ApiUserId", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "91bfb847-70e6-44f2-9ea2-f30e85384399", null, null, "User", "USER" },
                    { "e85883a9-4fe5-413f-a4d3-ff09f3e5b992", null, null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Orgs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 25, 17, 27, 10, 184, DateTimeKind.Utc).AddTicks(7918), new DateTime(2023, 4, 25, 17, 27, 10, 184, DateTimeKind.Utc).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "Orgs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 25, 17, 27, 10, 184, DateTimeKind.Utc).AddTicks(7925), new DateTime(2023, 4, 25, 17, 27, 10, 184, DateTimeKind.Utc).AddTicks(7926) });

            migrationBuilder.UpdateData(
                table: "Systemzs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 25, 17, 27, 10, 184, DateTimeKind.Utc).AddTicks(8184), new DateTime(2023, 4, 25, 17, 27, 10, 184, DateTimeKind.Utc).AddTicks(8184) });

            migrationBuilder.UpdateData(
                table: "Systemzs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 25, 17, 27, 10, 184, DateTimeKind.Utc).AddTicks(8187), new DateTime(2023, 4, 25, 17, 27, 10, 184, DateTimeKind.Utc).AddTicks(8187) });
        }
    }
}
