using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectName.Infra.Migrations
{
    /// <inheritdoc />
    public partial class SU : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OU_LEs_LEId",
                table: "OU");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OU",
                table: "OU");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71d45a2d-e26d-4d5d-941c-f218f5bb9784");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9117cd17-0745-4c01-a05a-9ee31851345c");

            migrationBuilder.RenameTable(
                name: "OU",
                newName: "OUs");

            migrationBuilder.RenameIndex(
                name: "IX_OU_LEId",
                table: "OUs",
                newName: "IX_OUs_LEId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OUs",
                table: "OUs",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "SUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OUId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SUs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SUs_OUs_OUId",
                        column: x => x.OUId,
                        principalTable: "OUs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ApiUserId", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "56cad2c0-8f29-464e-b16e-646cf896dd59", null, null, "User", "USER" },
                    { "a4a1abaf-b966-4a6d-8a00-9f002586b169", null, null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "BGs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 29, 3, 32, 22, 620, DateTimeKind.Utc).AddTicks(9924), new DateTime(2023, 4, 29, 3, 32, 22, 620, DateTimeKind.Utc).AddTicks(9926) });

            migrationBuilder.UpdateData(
                table: "BGs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 29, 3, 32, 22, 620, DateTimeKind.Utc).AddTicks(9930), new DateTime(2023, 4, 29, 3, 32, 22, 620, DateTimeKind.Utc).AddTicks(9931) });

            migrationBuilder.UpdateData(
                table: "LEs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 29, 3, 32, 22, 621, DateTimeKind.Utc).AddTicks(303), new DateTime(2023, 4, 29, 3, 32, 22, 621, DateTimeKind.Utc).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "LEs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 29, 3, 32, 22, 621, DateTimeKind.Utc).AddTicks(312), new DateTime(2023, 4, 29, 3, 32, 22, 621, DateTimeKind.Utc).AddTicks(312) });

            migrationBuilder.UpdateData(
                table: "OUs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 29, 3, 32, 22, 621, DateTimeKind.Utc).AddTicks(684), new DateTime(2023, 4, 29, 3, 32, 22, 621, DateTimeKind.Utc).AddTicks(685) });

            migrationBuilder.UpdateData(
                table: "OUs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 29, 3, 32, 22, 621, DateTimeKind.Utc).AddTicks(690), new DateTime(2023, 4, 29, 3, 32, 22, 621, DateTimeKind.Utc).AddTicks(691) });

            migrationBuilder.UpdateData(
                table: "Orgs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 29, 3, 32, 22, 620, DateTimeKind.Utc).AddTicks(9121), new DateTime(2023, 4, 29, 3, 32, 22, 620, DateTimeKind.Utc).AddTicks(9131) });

            migrationBuilder.UpdateData(
                table: "Orgs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 29, 3, 32, 22, 620, DateTimeKind.Utc).AddTicks(9138), new DateTime(2023, 4, 29, 3, 32, 22, 620, DateTimeKind.Utc).AddTicks(9139) });

            migrationBuilder.InsertData(
                table: "SUs",
                columns: new[] { "Id", "CreatedAt", "Description", "OUId", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 29, 3, 32, 22, 621, DateTimeKind.Utc).AddTicks(1188), "SU 1 Description", 1, "SU 1", new DateTime(2023, 4, 29, 3, 32, 22, 621, DateTimeKind.Utc).AddTicks(1189) },
                    { 2, new DateTime(2023, 4, 29, 3, 32, 22, 621, DateTimeKind.Utc).AddTicks(1193), "SU 2 Description", 2, "SU 2", new DateTime(2023, 4, 29, 3, 32, 22, 621, DateTimeKind.Utc).AddTicks(1194) }
                });

            migrationBuilder.UpdateData(
                table: "Systemzs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 29, 3, 32, 22, 620, DateTimeKind.Utc).AddTicks(9527), new DateTime(2023, 4, 29, 3, 32, 22, 620, DateTimeKind.Utc).AddTicks(9528) });

            migrationBuilder.UpdateData(
                table: "Systemzs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 29, 3, 32, 22, 620, DateTimeKind.Utc).AddTicks(9534), new DateTime(2023, 4, 29, 3, 32, 22, 620, DateTimeKind.Utc).AddTicks(9535) });

            migrationBuilder.CreateIndex(
                name: "IX_SUs_OUId",
                table: "SUs",
                column: "OUId");

            migrationBuilder.AddForeignKey(
                name: "FK_OUs_LEs_LEId",
                table: "OUs",
                column: "LEId",
                principalTable: "LEs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OUs_LEs_LEId",
                table: "OUs");

            migrationBuilder.DropTable(
                name: "SUs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OUs",
                table: "OUs");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56cad2c0-8f29-464e-b16e-646cf896dd59");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4a1abaf-b966-4a6d-8a00-9f002586b169");

            migrationBuilder.RenameTable(
                name: "OUs",
                newName: "OU");

            migrationBuilder.RenameIndex(
                name: "IX_OUs_LEId",
                table: "OU",
                newName: "IX_OU_LEId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OU",
                table: "OU",
                column: "Id");

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

            migrationBuilder.UpdateData(
                table: "OU",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 29, 3, 6, 10, 280, DateTimeKind.Utc).AddTicks(5179), new DateTime(2023, 4, 29, 3, 6, 10, 280, DateTimeKind.Utc).AddTicks(5184) });

            migrationBuilder.UpdateData(
                table: "OU",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 4, 29, 3, 6, 10, 280, DateTimeKind.Utc).AddTicks(5198), new DateTime(2023, 4, 29, 3, 6, 10, 280, DateTimeKind.Utc).AddTicks(5199) });

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

            migrationBuilder.AddForeignKey(
                name: "FK_OU_LEs_LEId",
                table: "OU",
                column: "LEId",
                principalTable: "LEs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
