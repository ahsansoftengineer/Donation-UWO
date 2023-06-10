using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectName.Infra.Migrations
{
    /// <inheritdoc />
    public partial class OU_UPLOADING_FILE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "712bbee9-98ca-46d2-af00-0cdf56b586cb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8297c67a-d517-4f2e-b206-86d5110e15fd");

            migrationBuilder.DropColumn(
                name: "FooterImage",
                table: "OUs");

            migrationBuilder.DropColumn(
                name: "LogoImage",
                table: "OUs");

            migrationBuilder.DropColumn(
                name: "TopImage",
                table: "OUs");

            migrationBuilder.DropColumn(
                name: "WarningImage",
                table: "OUs");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ApiUserId", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2aabf41d-7ca2-4199-99f1-6319ff21a73d", null, null, "Administrator", "ADMINISTRATOR" },
                    { "c3360829-2d88-46e6-a9b0-a9e14d109bae", null, null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "BGs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 562, DateTimeKind.Utc).AddTicks(9457), new DateTime(2023, 6, 10, 10, 27, 30, 562, DateTimeKind.Utc).AddTicks(9458) });

            migrationBuilder.UpdateData(
                table: "BGs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 562, DateTimeKind.Utc).AddTicks(9461), new DateTime(2023, 6, 10, 10, 27, 30, 562, DateTimeKind.Utc).AddTicks(9461) });

            migrationBuilder.UpdateData(
                table: "BGs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 562, DateTimeKind.Utc).AddTicks(9463), new DateTime(2023, 6, 10, 10, 27, 30, 562, DateTimeKind.Utc).AddTicks(9464) });

            migrationBuilder.UpdateData(
                table: "Branchs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(684), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(684) });

            migrationBuilder.UpdateData(
                table: "Branchs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(687), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(688) });

            migrationBuilder.UpdateData(
                table: "Branchs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(689), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(690) });

            migrationBuilder.UpdateData(
                table: "COAs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(626), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(627) });

            migrationBuilder.UpdateData(
                table: "COAs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(631), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "COAs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(633), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(633) });

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(1425), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(1426) });

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(1434), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(1435) });

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(718), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(718) });

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(722), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(723) });

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(781), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(781) });

            migrationBuilder.UpdateData(
                table: "DonationCategorys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(1920), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "DonationCategorys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(1925), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(1925) });

            migrationBuilder.UpdateData(
                table: "DonationCategorys",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(1927), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(1927) });

            migrationBuilder.UpdateData(
                table: "DonationCellMasters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(2950), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(2951) });

            migrationBuilder.UpdateData(
                table: "DonationCellMasters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(2962), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(2963) });

            migrationBuilder.UpdateData(
                table: "DonationSubTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(2590), "DonationSubType 1 Description", "DonationSubType 1", new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(2591) });

            migrationBuilder.UpdateData(
                table: "DonationSubTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(2599), "DonationSubType 2 Description", "DonationSubType 2", new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(2599) });

            migrationBuilder.UpdateData(
                table: "DonationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(2267), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(2268) });

            migrationBuilder.UpdateData(
                table: "DonationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(2278), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(2278) });

            migrationBuilder.UpdateData(
                table: "DonorBasic",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(4164), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(4165) });

            migrationBuilder.UpdateData(
                table: "DonorBasic",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(4178), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(4179) });

            migrationBuilder.UpdateData(
                table: "DonorBasic",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(4184), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(4184) });

            migrationBuilder.UpdateData(
                table: "DonorBasic",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(4681), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(4682) });

            migrationBuilder.UpdateData(
                table: "DonorBasic",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(4705), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(4705) });

            migrationBuilder.UpdateData(
                table: "DonorBasic",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(4718), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(4719) });

            migrationBuilder.UpdateData(
                table: "DonorTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(3657), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(3658) });

            migrationBuilder.UpdateData(
                table: "DonorTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(3668), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(3668) });

            migrationBuilder.UpdateData(
                table: "DonorTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(3671), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(3672) });

            migrationBuilder.UpdateData(
                table: "LEs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 562, DateTimeKind.Utc).AddTicks(9801), new DateTime(2023, 6, 10, 10, 27, 30, 562, DateTimeKind.Utc).AddTicks(9802) });

            migrationBuilder.UpdateData(
                table: "LEs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 562, DateTimeKind.Utc).AddTicks(9808), new DateTime(2023, 6, 10, 10, 27, 30, 562, DateTimeKind.Utc).AddTicks(9808) });

            migrationBuilder.UpdateData(
                table: "Locationzs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(551), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "Locationzs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(555), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(556) });

            migrationBuilder.UpdateData(
                table: "Locationzs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(558), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "MadaniBastaEvents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(1508), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(1508) });

            migrationBuilder.UpdateData(
                table: "MadaniBastaEvents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(1512), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(1512) });

            migrationBuilder.UpdateData(
                table: "MadaniBastaEvents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(1514), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(1514) });

            migrationBuilder.UpdateData(
                table: "MadaniBastaPlaces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(1542), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(1543) });

            migrationBuilder.UpdateData(
                table: "MadaniBastaPlaces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(1546), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "MadaniBastaPlaces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(1549), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "MadaniBastaSubCategorys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(1871), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(1872) });

            migrationBuilder.UpdateData(
                table: "MadaniBastaSubCategorys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(1878), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(1879) });

            migrationBuilder.UpdateData(
                table: "MadaniBastas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(1480), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(1480) });

            migrationBuilder.UpdateData(
                table: "MadaniBastas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(1484), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(1484) });

            migrationBuilder.UpdateData(
                table: "MadaniBastas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(1486), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(1487) });

            migrationBuilder.UpdateData(
                table: "Majliss",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(592), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(593) });

            migrationBuilder.UpdateData(
                table: "Majliss",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(597), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Majliss",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(599), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(600) });

            migrationBuilder.UpdateData(
                table: "OUs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(154), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(155) });

            migrationBuilder.UpdateData(
                table: "OUs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(162), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(163) });

            migrationBuilder.UpdateData(
                table: "Orgs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 562, DateTimeKind.Utc).AddTicks(9012), new DateTime(2023, 6, 10, 10, 27, 30, 562, DateTimeKind.Utc).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "Orgs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 562, DateTimeKind.Utc).AddTicks(9029), new DateTime(2023, 6, 10, 10, 27, 30, 562, DateTimeKind.Utc).AddTicks(9029) });

            migrationBuilder.UpdateData(
                table: "Orgs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 562, DateTimeKind.Utc).AddTicks(9031), new DateTime(2023, 6, 10, 10, 27, 30, 562, DateTimeKind.Utc).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "SUs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(490), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(491) });

            migrationBuilder.UpdateData(
                table: "SUs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(496), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(497) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(1101), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(1102) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(1109), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(1110) });

            migrationBuilder.UpdateData(
                table: "SysmanAccounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(653), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(653) });

            migrationBuilder.UpdateData(
                table: "SysmanAccounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(657), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(658) });

            migrationBuilder.UpdateData(
                table: "SysmanAccounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(660), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(660) });

            migrationBuilder.UpdateData(
                table: "Systemzs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 562, DateTimeKind.Utc).AddTicks(9369), "Systemz 1 Description", "Systemz 1", new DateTime(2023, 6, 10, 10, 27, 30, 562, DateTimeKind.Utc).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "Systemzs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 562, DateTimeKind.Utc).AddTicks(9382), "Systemz 2 Description", "Systemz 2", new DateTime(2023, 6, 10, 10, 27, 30, 562, DateTimeKind.Utc).AddTicks(9382) });

            migrationBuilder.UpdateData(
                table: "TargetAssignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "TargetFor", "TargetFrom", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(3294), new DateTime(2023, 7, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(3301), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(3299), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(3295) });

            migrationBuilder.UpdateData(
                table: "TargetAssignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "TargetFor", "TargetFrom", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(3315), new DateTime(2023, 7, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(3318), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(3318), new DateTime(2023, 6, 10, 10, 27, 30, 563, DateTimeKind.Utc).AddTicks(3316) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2aabf41d-7ca2-4199-99f1-6319ff21a73d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3360829-2d88-46e6-a9b0-a9e14d109bae");

            migrationBuilder.AddColumn<string>(
                name: "FooterImage",
                table: "OUs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LogoImage",
                table: "OUs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TopImage",
                table: "OUs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WarningImage",
                table: "OUs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ApiUserId", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "712bbee9-98ca-46d2-af00-0cdf56b586cb", null, null, "User", "USER" },
                    { "8297c67a-d517-4f2e-b206-86d5110e15fd", null, null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "BGs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(1057), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "BGs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(1062), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(1062) });

            migrationBuilder.UpdateData(
                table: "BGs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(1065), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(1065) });

            migrationBuilder.UpdateData(
                table: "Branchs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2482), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2483) });

            migrationBuilder.UpdateData(
                table: "Branchs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2487), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2488) });

            migrationBuilder.UpdateData(
                table: "Branchs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2490), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2491) });

            migrationBuilder.UpdateData(
                table: "COAs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2369), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2369) });

            migrationBuilder.UpdateData(
                table: "COAs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2374), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2374) });

            migrationBuilder.UpdateData(
                table: "COAs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2377), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2377) });

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3315), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3317) });

            migrationBuilder.UpdateData(
                table: "Citys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3323), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3324) });

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2531), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2532) });

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2536), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2537) });

            migrationBuilder.UpdateData(
                table: "Countrys",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2539), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2539) });

            migrationBuilder.UpdateData(
                table: "DonationCategorys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3894), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3894) });

            migrationBuilder.UpdateData(
                table: "DonationCategorys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3899), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3899) });

            migrationBuilder.UpdateData(
                table: "DonationCategorys",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3901), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3902) });

            migrationBuilder.UpdateData(
                table: "DonationCellMasters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(5126), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(5127) });

            migrationBuilder.UpdateData(
                table: "DonationCellMasters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(5137), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(5137) });

            migrationBuilder.UpdateData(
                table: "DonationSubTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(4720), "DonationCellMaster 1 Description", "DonationCellMaster 1", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(4721) });

            migrationBuilder.UpdateData(
                table: "DonationSubTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(4730), "DonationCellMaster 2 Description", "DonationCellMaster 2", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(4731) });

            migrationBuilder.UpdateData(
                table: "DonationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(4312), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(4313) });

            migrationBuilder.UpdateData(
                table: "DonationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(4325), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "DonorBasic",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(6344), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(6345) });

            migrationBuilder.UpdateData(
                table: "DonorBasic",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(6355), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(6356) });

            migrationBuilder.UpdateData(
                table: "DonorBasic",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(6361), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(6362) });

            migrationBuilder.UpdateData(
                table: "DonorBasic",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(6765), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(6767) });

            migrationBuilder.UpdateData(
                table: "DonorBasic",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(6785), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(6786) });

            migrationBuilder.UpdateData(
                table: "DonorBasic",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(6794), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "DonorTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(5937), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "DonorTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(5945), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "DonorTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(5949), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "LEs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(1433), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(1434) });

            migrationBuilder.UpdateData(
                table: "LEs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(1441), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(1441) });

            migrationBuilder.UpdateData(
                table: "Locationzs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2285), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "Locationzs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2291), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2292) });

            migrationBuilder.UpdateData(
                table: "Locationzs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2294), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2295) });

            migrationBuilder.UpdateData(
                table: "MadaniBastaEvents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3415), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3416) });

            migrationBuilder.UpdateData(
                table: "MadaniBastaEvents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3421), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3422) });

            migrationBuilder.UpdateData(
                table: "MadaniBastaEvents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3423), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3424) });

            migrationBuilder.UpdateData(
                table: "MadaniBastaPlaces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3456), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "MadaniBastaPlaces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3462), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3462) });

            migrationBuilder.UpdateData(
                table: "MadaniBastaPlaces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3464), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3465) });

            migrationBuilder.UpdateData(
                table: "MadaniBastaSubCategorys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3821), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3822) });

            migrationBuilder.UpdateData(
                table: "MadaniBastaSubCategorys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3830), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3830) });

            migrationBuilder.UpdateData(
                table: "MadaniBastas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3376), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3377) });

            migrationBuilder.UpdateData(
                table: "MadaniBastas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3382), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3382) });

            migrationBuilder.UpdateData(
                table: "MadaniBastas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3384), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3385) });

            migrationBuilder.UpdateData(
                table: "Majliss",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2325), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2326) });

            migrationBuilder.UpdateData(
                table: "Majliss",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2332), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2332) });

            migrationBuilder.UpdateData(
                table: "Majliss",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2335), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "OUs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "FooterImage", "LogoImage", "TopImage", "UpdatedAt", "WarningImage" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(1822), null, null, null, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(1823), null });

            migrationBuilder.UpdateData(
                table: "OUs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "FooterImage", "LogoImage", "TopImage", "UpdatedAt", "WarningImage" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(1832), null, null, null, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(1832), null });

            migrationBuilder.UpdateData(
                table: "Orgs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(520), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(528) });

            migrationBuilder.UpdateData(
                table: "Orgs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(544), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(544) });

            migrationBuilder.UpdateData(
                table: "Orgs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(588), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(589) });

            migrationBuilder.UpdateData(
                table: "SUs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2215), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2216) });

            migrationBuilder.UpdateData(
                table: "SUs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2222), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2223) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2924), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2933), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2933) });

            migrationBuilder.UpdateData(
                table: "SysmanAccounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2404), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2405) });

            migrationBuilder.UpdateData(
                table: "SysmanAccounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2409), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2409) });

            migrationBuilder.UpdateData(
                table: "SysmanAccounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2411), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2412) });

            migrationBuilder.UpdateData(
                table: "Systemzs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(993), "SU 1 Description", "SU 1", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(995) });

            migrationBuilder.UpdateData(
                table: "Systemzs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(1002), "SU 2 Description", "SU 2", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(1002) });

            migrationBuilder.UpdateData(
                table: "TargetAssignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "TargetFor", "TargetFrom", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(5517), new DateTime(2023, 7, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(5525), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(5524), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(5518) });

            migrationBuilder.UpdateData(
                table: "TargetAssignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "TargetFor", "TargetFrom", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(5541), new DateTime(2023, 7, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(5544), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(5543), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(5541) });
        }
    }
}
