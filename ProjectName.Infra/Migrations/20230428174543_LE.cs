using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectName.Infra.Migrations
{
    /// <inheritdoc />
    public partial class LE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b795e050-bd09-4989-bc2a-507945bf2c2a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c92c50e4-a7f4-4aaf-bd6e-4f5da1faa576");

            migrationBuilder.CreateTable(
                name: "LEs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BGId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LEs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LEs_BGs_BGId",
                        column: x => x.BGId,
                        principalTable: "BGs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ApiUserId", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bc98e928-4364-4aba-8187-3f9ee26a16b8", null, null, "Administrator", "ADMINISTRATOR" },
                    { "e3ce2138-6cef-4be0-a279-a3acc0798a34", null, null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "BGs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 28, 17, 45, 43, 575, DateTimeKind.Utc).AddTicks(1213), new DateTime(2023, 4, 28, 17, 45, 43, 575, DateTimeKind.Utc).AddTicks(1213) });

            migrationBuilder.UpdateData(
                table: "BGs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 28, 17, 45, 43, 575, DateTimeKind.Utc).AddTicks(1215), new DateTime(2023, 4, 28, 17, 45, 43, 575, DateTimeKind.Utc).AddTicks(1215) });

            migrationBuilder.UpdateData(
                table: "Orgs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 28, 17, 45, 43, 575, DateTimeKind.Utc).AddTicks(829), new DateTime(2023, 4, 28, 17, 45, 43, 575, DateTimeKind.Utc).AddTicks(832) });

            migrationBuilder.UpdateData(
                table: "Orgs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 28, 17, 45, 43, 575, DateTimeKind.Utc).AddTicks(835), new DateTime(2023, 4, 28, 17, 45, 43, 575, DateTimeKind.Utc).AddTicks(836) });

            migrationBuilder.UpdateData(
                table: "Systemzs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 28, 17, 45, 43, 575, DateTimeKind.Utc).AddTicks(1028), new DateTime(2023, 4, 28, 17, 45, 43, 575, DateTimeKind.Utc).AddTicks(1029) });

            migrationBuilder.UpdateData(
                table: "Systemzs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 28, 17, 45, 43, 575, DateTimeKind.Utc).AddTicks(1032), new DateTime(2023, 4, 28, 17, 45, 43, 575, DateTimeKind.Utc).AddTicks(1032) });

            migrationBuilder.CreateIndex(
                name: "IX_LEs_BGId",
                table: "LEs",
                column: "BGId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LEs");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc98e928-4364-4aba-8187-3f9ee26a16b8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3ce2138-6cef-4be0-a279-a3acc0798a34");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ApiUserId", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b795e050-bd09-4989-bc2a-507945bf2c2a", null, null, "User", "USER" },
                    { "c92c50e4-a7f4-4aaf-bd6e-4f5da1faa576", null, null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "BGs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 25, 18, 54, 54, 487, DateTimeKind.Utc).AddTicks(1590), new DateTime(2023, 4, 25, 18, 54, 54, 487, DateTimeKind.Utc).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "BGs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 25, 18, 54, 54, 487, DateTimeKind.Utc).AddTicks(1613), new DateTime(2023, 4, 25, 18, 54, 54, 487, DateTimeKind.Utc).AddTicks(1614) });

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
    }
}
