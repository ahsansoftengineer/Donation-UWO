using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectName.Infra.Migrations
{
    /// <inheritdoc />
    public partial class OU : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b915e32-c808-4098-b10b-8bfabf34243d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "facdc18a-abcc-40d0-9eda-ad5cf6fe71c6");

            migrationBuilder.CreateTable(
                name: "OU",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LEId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OU", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OU_LEs_LEId",
                        column: x => x.LEId,
                        principalTable: "LEs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ApiUserId", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "71d45a2d-e26d-4d5d-941c-f218f5bb9784", null, null, "User", "USER" },
                    { "9117cd17-0745-4c01-a05a-9ee31851345c", null, null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "BGs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 29, 3, 6, 10, 276, DateTimeKind.Utc).AddTicks(3732), new DateTime(2023, 4, 29, 3, 6, 10, 276, DateTimeKind.Utc).AddTicks(3733) });

            migrationBuilder.UpdateData(
                table: "BGs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 29, 3, 6, 10, 276, DateTimeKind.Utc).AddTicks(3739), new DateTime(2023, 4, 29, 3, 6, 10, 276, DateTimeKind.Utc).AddTicks(3740) });

            migrationBuilder.UpdateData(
                table: "LEs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 29, 3, 6, 10, 276, DateTimeKind.Utc).AddTicks(4205), new DateTime(2023, 4, 29, 3, 6, 10, 276, DateTimeKind.Utc).AddTicks(4206) });

            migrationBuilder.UpdateData(
                table: "LEs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 29, 3, 6, 10, 276, DateTimeKind.Utc).AddTicks(4274), new DateTime(2023, 4, 29, 3, 6, 10, 276, DateTimeKind.Utc).AddTicks(4275) });

            migrationBuilder.InsertData(
                table: "OU",
                columns: new[] { "Id", "CreatedAt", "Description", "LEId", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 29, 3, 6, 10, 280, DateTimeKind.Utc).AddTicks(5179), "OU 1 Description", 1, "OU 1", new DateTime(2023, 4, 29, 3, 6, 10, 280, DateTimeKind.Utc).AddTicks(5184) },
                    { 2, new DateTime(2023, 4, 29, 3, 6, 10, 280, DateTimeKind.Utc).AddTicks(5198), "OU 2 Description", 2, "OU 2", new DateTime(2023, 4, 29, 3, 6, 10, 280, DateTimeKind.Utc).AddTicks(5199) }
                });

            migrationBuilder.UpdateData(
                table: "Orgs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 29, 3, 6, 10, 276, DateTimeKind.Utc).AddTicks(2558), new DateTime(2023, 4, 29, 3, 6, 10, 276, DateTimeKind.Utc).AddTicks(2564) });

            migrationBuilder.UpdateData(
                table: "Orgs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 29, 3, 6, 10, 276, DateTimeKind.Utc).AddTicks(2573), new DateTime(2023, 4, 29, 3, 6, 10, 276, DateTimeKind.Utc).AddTicks(2574) });

            migrationBuilder.UpdateData(
                table: "Systemzs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 29, 3, 6, 10, 276, DateTimeKind.Utc).AddTicks(3203), new DateTime(2023, 4, 29, 3, 6, 10, 276, DateTimeKind.Utc).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "Systemzs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 29, 3, 6, 10, 276, DateTimeKind.Utc).AddTicks(3212), new DateTime(2023, 4, 29, 3, 6, 10, 276, DateTimeKind.Utc).AddTicks(3212) });

            migrationBuilder.CreateIndex(
                name: "IX_OU_LEId",
                table: "OU",
                column: "LEId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OU");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71d45a2d-e26d-4d5d-941c-f218f5bb9784");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9117cd17-0745-4c01-a05a-9ee31851345c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ApiUserId", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3b915e32-c808-4098-b10b-8bfabf34243d", null, null, "User", "USER" },
                    { "facdc18a-abcc-40d0-9eda-ad5cf6fe71c6", null, null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "BGs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 28, 17, 47, 56, 795, DateTimeKind.Utc).AddTicks(7309), new DateTime(2023, 4, 28, 17, 47, 56, 795, DateTimeKind.Utc).AddTicks(7309) });

            migrationBuilder.UpdateData(
                table: "BGs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 28, 17, 47, 56, 795, DateTimeKind.Utc).AddTicks(7311), new DateTime(2023, 4, 28, 17, 47, 56, 795, DateTimeKind.Utc).AddTicks(7311) });

            migrationBuilder.UpdateData(
                table: "LEs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 28, 17, 47, 56, 795, DateTimeKind.Utc).AddTicks(7467), new DateTime(2023, 4, 28, 17, 47, 56, 795, DateTimeKind.Utc).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "LEs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 28, 17, 47, 56, 795, DateTimeKind.Utc).AddTicks(7469), new DateTime(2023, 4, 28, 17, 47, 56, 795, DateTimeKind.Utc).AddTicks(7469) });

            migrationBuilder.UpdateData(
                table: "Orgs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 28, 17, 47, 56, 795, DateTimeKind.Utc).AddTicks(6980), new DateTime(2023, 4, 28, 17, 47, 56, 795, DateTimeKind.Utc).AddTicks(6983) });

            migrationBuilder.UpdateData(
                table: "Orgs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 28, 17, 47, 56, 795, DateTimeKind.Utc).AddTicks(6986), new DateTime(2023, 4, 28, 17, 47, 56, 795, DateTimeKind.Utc).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "Systemzs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 28, 17, 47, 56, 795, DateTimeKind.Utc).AddTicks(7148), new DateTime(2023, 4, 28, 17, 47, 56, 795, DateTimeKind.Utc).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "Systemzs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 28, 17, 47, 56, 795, DateTimeKind.Utc).AddTicks(7151), new DateTime(2023, 4, 28, 17, 47, 56, 795, DateTimeKind.Utc).AddTicks(7151) });
        }
    }
}
