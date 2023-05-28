using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectName.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Donor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00ab7be4-5ab9-4311-9fd2-3062be3d913f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0881f46b-99e7-40f8-806b-018a985be73c");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "OUs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Deposit",
                table: "OUs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FooterImage",
                table: "OUs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FooterImg",
                table: "OUs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Law",
                table: "OUs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LogoImage",
                table: "OUs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LogoImg",
                table: "OUs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TopImage",
                table: "OUs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TopImg",
                table: "OUs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WarningImage",
                table: "OUs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WarningImg",
                table: "OUs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Countrys",
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
                    table.PrimaryKey("PK_Countrys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DonorTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonorTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TargetAssignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TargetFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TargetFor = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IncreasePercentage = table.Column<int>(type: "int", nullable: true),
                    SystemzId = table.Column<int>(type: "int", nullable: false),
                    MajlisId = table.Column<int>(type: "int", nullable: false),
                    SUId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TargetAssignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TargetAssignments_Majliss_MajlisId",
                        column: x => x.MajlisId,
                        principalTable: "Majliss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TargetAssignments_SUs_SUId",
                        column: x => x.SUId,
                        principalTable: "SUs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TargetAssignments_Systemzs_SystemzId",
                        column: x => x.SystemzId,
                        principalTable: "Systemzs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                    table.ForeignKey(
                        name: "FK_States_Countrys_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countrys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Citys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Citys_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DonorBasics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    DonorTypeId = table.Column<int>(type: "int", nullable: false),
                    OrgId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonorBasics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DonorBasics_Citys_CityId",
                        column: x => x.CityId,
                        principalTable: "Citys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonorBasics_DonorTypes_DonorTypeId",
                        column: x => x.DonorTypeId,
                        principalTable: "DonorTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonorBasics_Orgs_OrgId",
                        column: x => x.OrgId,
                        principalTable: "Orgs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ApiUserId", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "51552dfa-6d4a-46cf-8086-5de76498b760", null, null, "User", "USER" },
                    { "6e19f0ef-010c-4626-856b-e9fcbc1e404c", null, null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "BGs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(5840), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "BGs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(5843), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(5843) });

            migrationBuilder.UpdateData(
                table: "BGs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(5844), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(5844) });

            migrationBuilder.UpdateData(
                table: "COAs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(7406), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(7407) });

            migrationBuilder.UpdateData(
                table: "COAs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(7410), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(7411) });

            migrationBuilder.UpdateData(
                table: "COAs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(7412), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(7412) });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "Id", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(7488), "Country 1 Description", "Country 1 Title", new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(7488) },
                    { 2, new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(7491), "Country 2 Description", "Country 2 Title", new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(7491) },
                    { 3, new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(7492), "Country 3 Description", "Country 3 Title", new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(7492) }
                });

            migrationBuilder.UpdateData(
                table: "DonationCategorys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8518), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8518) });

            migrationBuilder.UpdateData(
                table: "DonationCategorys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8520), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8521) });

            migrationBuilder.UpdateData(
                table: "DonationCategorys",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8522), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8522) });

            migrationBuilder.UpdateData(
                table: "DonationCellMasters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(9270), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(9270) });

            migrationBuilder.UpdateData(
                table: "DonationCellMasters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(9276), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(9276) });

            migrationBuilder.UpdateData(
                table: "DonationSubTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8930), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "DonationSubTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8936), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "DonationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8724), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8724) });

            migrationBuilder.UpdateData(
                table: "DonationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8730), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8731) });

            migrationBuilder.InsertData(
                table: "DonorTypes",
                columns: new[] { "Id", "CreatedAt", "Description", "Status", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(9828), "DonorType 1 Description", 0, "DonorType 1 Title", new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(9829) },
                    { 2, new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(9834), "DonorType 2 Description", 1, "DonorType 2 Title", new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(9835) },
                    { 3, new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(9836), "DonorType 3 Description", 2, "DonorType 3 Title", new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(9837) }
                });

            migrationBuilder.UpdateData(
                table: "LEs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(6021), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(6022) });

            migrationBuilder.UpdateData(
                table: "LEs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(6026), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "Locationzs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(7348), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(7348) });

            migrationBuilder.UpdateData(
                table: "Locationzs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(7352), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(7353) });

            migrationBuilder.UpdateData(
                table: "Locationzs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(7354), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(7355) });

            migrationBuilder.UpdateData(
                table: "MadaniBastaEvents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8120), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8121) });

            migrationBuilder.UpdateData(
                table: "MadaniBastaEvents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8126), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8126) });

            migrationBuilder.UpdateData(
                table: "MadaniBastaEvents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8127), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8127) });

            migrationBuilder.UpdateData(
                table: "MadaniBastaPlaces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8145), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "MadaniBastaPlaces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8147), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8148) });

            migrationBuilder.UpdateData(
                table: "MadaniBastaPlaces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8149), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8149) });

            migrationBuilder.UpdateData(
                table: "MadaniBastaSubCategorys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8324), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8325) });

            migrationBuilder.UpdateData(
                table: "MadaniBastaSubCategorys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8329), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8329) });

            migrationBuilder.UpdateData(
                table: "MadaniBastas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8088), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8088) });

            migrationBuilder.UpdateData(
                table: "MadaniBastas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8092), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8092) });

            migrationBuilder.UpdateData(
                table: "MadaniBastas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8093), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8094) });

            migrationBuilder.UpdateData(
                table: "Majliss",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(7381), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(7382) });

            migrationBuilder.UpdateData(
                table: "Majliss",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(7384), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(7385) });

            migrationBuilder.UpdateData(
                table: "Majliss",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(7386), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(7386) });

            migrationBuilder.UpdateData(
                table: "OUs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "CreatedAt", "Deposit", "FooterImage", "FooterImg", "Law", "LogoImage", "LogoImg", "TopImage", "TopImg", "UpdatedAt", "WarningImage", "WarningImg" },
                values: new object[] { null, new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(6208), null, null, null, null, null, null, null, null, new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(6208), null, null });

            migrationBuilder.UpdateData(
                table: "OUs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "CreatedAt", "Deposit", "FooterImage", "FooterImg", "Law", "LogoImage", "LogoImg", "TopImage", "TopImg", "UpdatedAt", "WarningImage", "WarningImg" },
                values: new object[] { null, new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(6212), null, null, null, null, null, null, null, null, new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(6213), null, null });

            migrationBuilder.UpdateData(
                table: "Orgs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(5592), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "Orgs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(5603), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(5604) });

            migrationBuilder.UpdateData(
                table: "Orgs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(5605), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(5606) });

            migrationBuilder.UpdateData(
                table: "SUs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(6398), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(6398) });

            migrationBuilder.UpdateData(
                table: "SUs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(6403), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(6403) });

            migrationBuilder.UpdateData(
                table: "SysmanAccounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(7432), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(7432) });

            migrationBuilder.UpdateData(
                table: "SysmanAccounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(7465), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(7465) });

            migrationBuilder.UpdateData(
                table: "SysmanAccounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(7466), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(7466) });

            migrationBuilder.UpdateData(
                table: "Systemzs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(5802), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(5802) });

            migrationBuilder.UpdateData(
                table: "Systemzs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(5806), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(5807) });

            migrationBuilder.InsertData(
                table: "TargetAssignments",
                columns: new[] { "Id", "CreatedAt", "Description", "IncreasePercentage", "MajlisId", "SUId", "SystemzId", "TargetFor", "TargetFrom", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(9464), "TargetAssignment 1 Description", 20, 1, 1, 1, new DateTime(2023, 6, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(9467), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(9467), "TargetAssignment 1", new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(9464) },
                    { 2, new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(9475), "TargetAssignment 2 Description", 20, 2, 2, 2, new DateTime(2023, 6, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(9477), new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(9477), "TargetAssignment 2", new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(9476) }
                });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "CountryId", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(7841), "SU 1 Description", "SU 1", new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(7841) },
                    { 2, 2, new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(7846), "SU 2 Description", "SU 2", new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(7847) }
                });

            migrationBuilder.InsertData(
                table: "Citys",
                columns: new[] { "Id", "CreatedAt", "Description", "StateId", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8050), "SU 1 Description", 1, "SU 1", new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8051) },
                    { 2, new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8054), "SU 2 Description", 2, "SU 2", new DateTime(2023, 5, 28, 6, 59, 41, 202, DateTimeKind.Utc).AddTicks(8055) }
                });

            migrationBuilder.InsertData(
                table: "DonorBasics",
                columns: new[] { "Id", "Address", "CityId", "CreatedAt", "Description", "DonorTypeId", "Email", "Gender", "Mobile", "OrgId", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, 1, new DateTime(2023, 5, 28, 6, 59, 41, 203, DateTimeKind.Utc).AddTicks(41), "DonorBasic 1 Description", 1, "ahsansoftengineer@gmail.com", 1, "3212827700", 1, "DonorBasic 1", new DateTime(2023, 5, 28, 6, 59, 41, 203, DateTimeKind.Utc).AddTicks(41) },
                    { 2, null, 2, new DateTime(2023, 5, 28, 6, 59, 41, 203, DateTimeKind.Utc).AddTicks(48), "DonorBasic 2 Description", 2, "asdf@gmail.com", 0, "3212825500", 2, "DonorBasic 2", new DateTime(2023, 5, 28, 6, 59, 41, 203, DateTimeKind.Utc).AddTicks(48) },
                    { 3, null, 2, new DateTime(2023, 5, 28, 6, 59, 41, 203, DateTimeKind.Utc).AddTicks(50), "DonorBasic 3 Description", 2, "sumaya@gmail.com", 2, "3212826600", 2, "DonorBasic 3", new DateTime(2023, 5, 28, 6, 59, 41, 203, DateTimeKind.Utc).AddTicks(50) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Citys_StateId",
                table: "Citys",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_DonorBasics_CityId",
                table: "DonorBasics",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_DonorBasics_DonorTypeId",
                table: "DonorBasics",
                column: "DonorTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DonorBasics_OrgId",
                table: "DonorBasics",
                column: "OrgId");

            migrationBuilder.CreateIndex(
                name: "IX_States_CountryId",
                table: "States",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_TargetAssignments_MajlisId",
                table: "TargetAssignments",
                column: "MajlisId");

            migrationBuilder.CreateIndex(
                name: "IX_TargetAssignments_SUId",
                table: "TargetAssignments",
                column: "SUId");

            migrationBuilder.CreateIndex(
                name: "IX_TargetAssignments_SystemzId",
                table: "TargetAssignments",
                column: "SystemzId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DonorBasics");

            migrationBuilder.DropTable(
                name: "TargetAssignments");

            migrationBuilder.DropTable(
                name: "Citys");

            migrationBuilder.DropTable(
                name: "DonorTypes");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "Countrys");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51552dfa-6d4a-46cf-8086-5de76498b760");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e19f0ef-010c-4626-856b-e9fcbc1e404c");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "OUs");

            migrationBuilder.DropColumn(
                name: "Deposit",
                table: "OUs");

            migrationBuilder.DropColumn(
                name: "FooterImage",
                table: "OUs");

            migrationBuilder.DropColumn(
                name: "FooterImg",
                table: "OUs");

            migrationBuilder.DropColumn(
                name: "Law",
                table: "OUs");

            migrationBuilder.DropColumn(
                name: "LogoImage",
                table: "OUs");

            migrationBuilder.DropColumn(
                name: "LogoImg",
                table: "OUs");

            migrationBuilder.DropColumn(
                name: "TopImage",
                table: "OUs");

            migrationBuilder.DropColumn(
                name: "TopImg",
                table: "OUs");

            migrationBuilder.DropColumn(
                name: "WarningImage",
                table: "OUs");

            migrationBuilder.DropColumn(
                name: "WarningImg",
                table: "OUs");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ApiUserId", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "00ab7be4-5ab9-4311-9fd2-3062be3d913f", null, null, "Administrator", "ADMINISTRATOR" },
                    { "0881f46b-99e7-40f8-806b-018a985be73c", null, null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "BGs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(3513), new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(3514) });

            migrationBuilder.UpdateData(
                table: "BGs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(3518), new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(3519) });

            migrationBuilder.UpdateData(
                table: "BGs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "COAs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(7648), new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(7649) });

            migrationBuilder.UpdateData(
                table: "COAs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(7654), new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(7655) });

            migrationBuilder.UpdateData(
                table: "COAs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "DonationCategorys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(5948), new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "DonationCategorys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(5954), new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(5955) });

            migrationBuilder.UpdateData(
                table: "DonationCategorys",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "DonationCellMasters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(7394), new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(7395) });

            migrationBuilder.UpdateData(
                table: "DonationCellMasters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(7429), new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "DonationSubTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(6935), new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(6936) });

            migrationBuilder.UpdateData(
                table: "DonationSubTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(6945), new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(6945) });

            migrationBuilder.UpdateData(
                table: "DonationTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(6451), new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(6453) });

            migrationBuilder.UpdateData(
                table: "DonationTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(6464), new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(6465) });

            migrationBuilder.UpdateData(
                table: "LEs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(3969), new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(3971) });

            migrationBuilder.UpdateData(
                table: "LEs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(3979), new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(3980) });

            migrationBuilder.UpdateData(
                table: "Locationzs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(7556), new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(7557) });

            migrationBuilder.UpdateData(
                table: "Locationzs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(7563), new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(7563) });

            migrationBuilder.UpdateData(
                table: "Locationzs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "MadaniBastaEvents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(5279), new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(5280) });

            migrationBuilder.UpdateData(
                table: "MadaniBastaEvents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(5313), new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(5313) });

            migrationBuilder.UpdateData(
                table: "MadaniBastaEvents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "MadaniBastaPlaces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(5381), new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(5382) });

            migrationBuilder.UpdateData(
                table: "MadaniBastaPlaces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(5387), new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(5388) });

            migrationBuilder.UpdateData(
                table: "MadaniBastaPlaces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "MadaniBastaSubCategorys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(5822), new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "MadaniBastaSubCategorys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(5833), new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "MadaniBastas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(5232), new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(5233) });

            migrationBuilder.UpdateData(
                table: "MadaniBastas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(5241), new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(5242) });

            migrationBuilder.UpdateData(
                table: "MadaniBastas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Majliss",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(7606), new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(7607) });

            migrationBuilder.UpdateData(
                table: "Majliss",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(7612), new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(7612) });

            migrationBuilder.UpdateData(
                table: "Majliss",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "OUs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(4601), new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(4603) });

            migrationBuilder.UpdateData(
                table: "OUs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(4669), new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(4670) });

            migrationBuilder.UpdateData(
                table: "Orgs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(2876), new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(2887) });

            migrationBuilder.UpdateData(
                table: "Orgs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(2902), new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(2903) });

            migrationBuilder.UpdateData(
                table: "Orgs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "SUs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(5151), new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(5153) });

            migrationBuilder.UpdateData(
                table: "SUs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(5161), new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(5162) });

            migrationBuilder.UpdateData(
                table: "SysmanAccounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(7693), new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(7694) });

            migrationBuilder.UpdateData(
                table: "SysmanAccounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(7698), new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(7699) });

            migrationBuilder.UpdateData(
                table: "SysmanAccounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Systemzs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(3437), new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(3438) });

            migrationBuilder.UpdateData(
                table: "Systemzs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(3447), new DateTime(2023, 5, 22, 15, 51, 2, 452, DateTimeKind.Utc).AddTicks(3448) });
        }
    }
}
