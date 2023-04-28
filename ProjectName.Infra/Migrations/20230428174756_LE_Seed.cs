using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectName.Infra.Migrations
{
    /// <inheritdoc />
    public partial class LE_Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "LEs",
                columns: new[] { "Id", "BGId", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 4, 28, 17, 47, 56, 795, DateTimeKind.Utc).AddTicks(7467), "LE 1 Description", "LE 1", new DateTime(2023, 4, 28, 17, 47, 56, 795, DateTimeKind.Utc).AddTicks(7467) },
                    { 2, 2, new DateTime(2023, 4, 28, 17, 47, 56, 795, DateTimeKind.Utc).AddTicks(7469), "LE 2 Description", "LE 2", new DateTime(2023, 4, 28, 17, 47, 56, 795, DateTimeKind.Utc).AddTicks(7469) }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b915e32-c808-4098-b10b-8bfabf34243d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "facdc18a-abcc-40d0-9eda-ad5cf6fe71c6");

            migrationBuilder.DeleteData(
                table: "LEs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LEs",
                keyColumn: "Id",
                keyValue: 2);

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
        }
    }
}
