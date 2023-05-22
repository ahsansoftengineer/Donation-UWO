using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectName.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Hierarchy_MadaniBasta_Donation_Extra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "COAs",
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
                    table.PrimaryKey("PK_COAs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DonationCategorys",
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
                    table.PrimaryKey("PK_DonationCategorys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locationzs",
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
                    table.PrimaryKey("PK_Locationzs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MadaniBastaEvents",
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
                    table.PrimaryKey("PK_MadaniBastaEvents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MadaniBastaPlaces",
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
                    table.PrimaryKey("PK_MadaniBastaPlaces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MadaniBastas",
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
                    table.PrimaryKey("PK_MadaniBastas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Majliss",
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
                    table.PrimaryKey("PK_Majliss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orgs",
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
                    table.PrimaryKey("PK_Orgs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysmanAccounts",
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
                    table.PrimaryKey("PK_SysmanAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ApiUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoles_AspNetUsers_ApiUserId",
                        column: x => x.ApiUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "MadaniBastaSubCategorys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MadaniBastaId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MadaniBastaSubCategorys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MadaniBastaSubCategorys_MadaniBastas_MadaniBastaId",
                        column: x => x.MadaniBastaId,
                        principalTable: "MadaniBastas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Systemzs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrgId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Systemzs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Systemzs_Orgs_OrgId",
                        column: x => x.OrgId,
                        principalTable: "Orgs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DonationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SysmanAccountId = table.Column<int>(type: "int", nullable: false),
                    COAId = table.Column<int>(type: "int", nullable: false),
                    DonationCategoryId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonationTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DonationTypes_COAs_COAId",
                        column: x => x.COAId,
                        principalTable: "COAs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonationTypes_DonationCategorys_DonationCategoryId",
                        column: x => x.DonationCategoryId,
                        principalTable: "DonationCategorys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonationTypes_SysmanAccounts_SysmanAccountId",
                        column: x => x.SysmanAccountId,
                        principalTable: "SysmanAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OUs",
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
                    table.PrimaryKey("PK_OUs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OUs_LEs_LEId",
                        column: x => x.LEId,
                        principalTable: "LEs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DonationSubTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DonationTypeId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonationSubTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DonationSubTypes_DonationTypes_DonationTypeId",
                        column: x => x.DonationTypeId,
                        principalTable: "DonationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "DonationCellMasters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationzId = table.Column<int>(type: "int", nullable: false),
                    MajlisId = table.Column<int>(type: "int", nullable: false),
                    SUId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonationCellMasters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DonationCellMasters_Locationzs_LocationzId",
                        column: x => x.LocationzId,
                        principalTable: "Locationzs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonationCellMasters_Majliss_MajlisId",
                        column: x => x.MajlisId,
                        principalTable: "Majliss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonationCellMasters_SUs_SUId",
                        column: x => x.SUId,
                        principalTable: "SUs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ApiUserId", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "142aa898-85b4-4e2d-895e-11385ffa8a53", null, null, "Administrator", "ADMINISTRATOR" },
                    { "446e7434-f889-4ff4-bb1c-20abbaa353b9", null, null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "BGs",
                columns: new[] { "Id", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, "BG 1 Description", "BG 1 Title", null },
                    { 2, null, "BG 2 Description", "BG 2 Title", null },
                    { 3, null, "BG 3 Description", "BG 3 Title", null }
                });

            migrationBuilder.InsertData(
                table: "COAs",
                columns: new[] { "Id", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, "COA 1 Description", "COA 1 Title", null },
                    { 2, null, "COA 2 Description", "COA 2 Title", null },
                    { 3, null, "COA 3 Description", "COA 3 Title", null }
                });

            migrationBuilder.InsertData(
                table: "DonationCategorys",
                columns: new[] { "Id", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, "DonationCategory 1 Description", "DonationCategory 1 Title", null },
                    { 2, null, "DonationCategory 2 Description", "DonationCategory 2 Title", null },
                    { 3, null, "DonationCategory 3 Description", "DonationCategory 3 Title", null }
                });

            migrationBuilder.InsertData(
                table: "Locationzs",
                columns: new[] { "Id", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, "Locationz 1 Description", "Locationz 1 Title", null },
                    { 2, null, "Locationz 2 Description", "Locationz 2 Title", null },
                    { 3, null, "Locationz 3 Description", "Locationz 3 Title", null }
                });

            migrationBuilder.InsertData(
                table: "MadaniBastaEvents",
                columns: new[] { "Id", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, "MadaniBastaEvent 1 Description", "MadaniBastaEvent 1 Title", null },
                    { 2, null, "MadaniBastaEvent 2 Description", "MadaniBastaEvent 2 Title", null },
                    { 3, null, "MadaniBastaEvent 3 Description", "MadaniBastaEvent 3 Title", null }
                });

            migrationBuilder.InsertData(
                table: "MadaniBastaPlaces",
                columns: new[] { "Id", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, "MadaniBastaPlace 1 Description", "MadaniBastaPlace 1 Title", null },
                    { 2, null, "MadaniBastaPlace 2 Description", "MadaniBastaPlace 2 Title", null },
                    { 3, null, "MadaniBastaPlace 3 Description", "MadaniBastaPlace 3 Title", null }
                });

            migrationBuilder.InsertData(
                table: "MadaniBastas",
                columns: new[] { "Id", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, "MadaniBasta 1 Description", "MadaniBasta 1 Title", null },
                    { 2, null, "MadaniBasta 2 Description", "MadaniBasta 2 Title", null },
                    { 3, null, "MadaniBasta 3 Description", "MadaniBasta 3 Title", null }
                });

            migrationBuilder.InsertData(
                table: "Majliss",
                columns: new[] { "Id", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, "Majlis 1 Description", "Majlis 1 Title", null },
                    { 2, null, "Majlis 2 Description", "Majlis 2 Title", null },
                    { 3, null, "Majlis 3 Description", "Majlis 3 Title", null }
                });

            migrationBuilder.InsertData(
                table: "Orgs",
                columns: new[] { "Id", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, "Org 1 Description", "Org 1 Title", null },
                    { 2, null, "Org 2 Description", "Org 2 Title", null },
                    { 3, null, "Org 3 Description", "Org 3 Title", null }
                });

            migrationBuilder.InsertData(
                table: "SysmanAccounts",
                columns: new[] { "Id", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, "SysmanAccount 1 Description", "SysmanAccount 1 Title", null },
                    { 2, null, "SysmanAccount 2 Description", "SysmanAccount 2 Title", null },
                    { 3, null, "SysmanAccount 3 Description", "SysmanAccount 3 Title", null }
                });

            migrationBuilder.InsertData(
                table: "DonationTypes",
                columns: new[] { "Id", "COAId", "CreatedAt", "Description", "DonationCategoryId", "SysmanAccountId", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 5, 22, 1, 52, 0, 34, DateTimeKind.Utc).AddTicks(3754), "DonationType 1 Description", 1, 1, "DonationType 1", new DateTime(2023, 5, 22, 1, 52, 0, 34, DateTimeKind.Utc).AddTicks(3755) },
                    { 2, 2, new DateTime(2023, 5, 22, 1, 52, 0, 34, DateTimeKind.Utc).AddTicks(3761), "DonationType 2 Description", 2, 2, "DonationType 2", new DateTime(2023, 5, 22, 1, 52, 0, 34, DateTimeKind.Utc).AddTicks(3761) }
                });

            migrationBuilder.InsertData(
                table: "LEs",
                columns: new[] { "Id", "BGId", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 5, 22, 1, 52, 0, 34, DateTimeKind.Utc).AddTicks(2936), "LE 1 Description", "LE 1", new DateTime(2023, 5, 22, 1, 52, 0, 34, DateTimeKind.Utc).AddTicks(2937) },
                    { 2, 2, new DateTime(2023, 5, 22, 1, 52, 0, 34, DateTimeKind.Utc).AddTicks(2940), "LE 2 Description", "LE 2", new DateTime(2023, 5, 22, 1, 52, 0, 34, DateTimeKind.Utc).AddTicks(2940) }
                });

            migrationBuilder.InsertData(
                table: "MadaniBastaSubCategorys",
                columns: new[] { "Id", "CreatedAt", "Description", "MadaniBastaId", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 22, 1, 52, 0, 34, DateTimeKind.Utc).AddTicks(3540), "Madani Basta Sub Category 1 Description", 1, "Madani Basta Sub Category 1", new DateTime(2023, 5, 22, 1, 52, 0, 34, DateTimeKind.Utc).AddTicks(3540) },
                    { 2, new DateTime(2023, 5, 22, 1, 52, 0, 34, DateTimeKind.Utc).AddTicks(3542), "Madani Basta Sub Category 2 Description", 2, "Madani Basta Sub Category 2", new DateTime(2023, 5, 22, 1, 52, 0, 34, DateTimeKind.Utc).AddTicks(3543) }
                });

            migrationBuilder.InsertData(
                table: "Systemzs",
                columns: new[] { "Id", "CreatedAt", "Description", "OrgId", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 22, 1, 52, 0, 34, DateTimeKind.Utc).AddTicks(2726), "Systemz 1 Description", 1, "Systemz 1", new DateTime(2023, 5, 22, 1, 52, 0, 34, DateTimeKind.Utc).AddTicks(2729) },
                    { 2, new DateTime(2023, 5, 22, 1, 52, 0, 34, DateTimeKind.Utc).AddTicks(2733), "Systemz 2 Description", 2, "Systemz 2", new DateTime(2023, 5, 22, 1, 52, 0, 34, DateTimeKind.Utc).AddTicks(2734) }
                });

            migrationBuilder.InsertData(
                table: "DonationSubTypes",
                columns: new[] { "Id", "CreatedAt", "Description", "DonationTypeId", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 22, 1, 52, 0, 34, DateTimeKind.Utc).AddTicks(3937), "DonationSubType 1 Description", 1, "DonationSubType 1", new DateTime(2023, 5, 22, 1, 52, 0, 34, DateTimeKind.Utc).AddTicks(3938) },
                    { 2, new DateTime(2023, 5, 22, 1, 52, 0, 34, DateTimeKind.Utc).AddTicks(3939), "DonationSubType 2 Description", 2, "DonationSubType 2", new DateTime(2023, 5, 22, 1, 52, 0, 34, DateTimeKind.Utc).AddTicks(3940) }
                });

            migrationBuilder.InsertData(
                table: "OUs",
                columns: new[] { "Id", "CreatedAt", "Description", "LEId", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 22, 1, 52, 0, 34, DateTimeKind.Utc).AddTicks(3115), "OU 1 Description", 1, "OU 1", new DateTime(2023, 5, 22, 1, 52, 0, 34, DateTimeKind.Utc).AddTicks(3116) },
                    { 2, new DateTime(2023, 5, 22, 1, 52, 0, 34, DateTimeKind.Utc).AddTicks(3119), "OU 2 Description", 2, "OU 2", new DateTime(2023, 5, 22, 1, 52, 0, 34, DateTimeKind.Utc).AddTicks(3119) }
                });

            migrationBuilder.InsertData(
                table: "SUs",
                columns: new[] { "Id", "CreatedAt", "Description", "OUId", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 22, 1, 52, 0, 34, DateTimeKind.Utc).AddTicks(3301), "SU 1 Description", 1, "SU 1", new DateTime(2023, 5, 22, 1, 52, 0, 34, DateTimeKind.Utc).AddTicks(3301) },
                    { 2, new DateTime(2023, 5, 22, 1, 52, 0, 34, DateTimeKind.Utc).AddTicks(3303), "SU 2 Description", 2, "SU 2", new DateTime(2023, 5, 22, 1, 52, 0, 34, DateTimeKind.Utc).AddTicks(3304) }
                });

            migrationBuilder.InsertData(
                table: "DonationCellMasters",
                columns: new[] { "Id", "Address", "CreatedAt", "Description", "LocationzId", "MajlisId", "SUId", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2023, 5, 22, 1, 52, 0, 34, DateTimeKind.Utc).AddTicks(4115), "DonationCellMaster 1 Description", 1, 1, 1, "DonationCellMaster 1", new DateTime(2023, 5, 22, 1, 52, 0, 34, DateTimeKind.Utc).AddTicks(4116) },
                    { 2, "", new DateTime(2023, 5, 22, 1, 52, 0, 34, DateTimeKind.Utc).AddTicks(4119), "DonationCellMaster 2 Description", 2, 2, 2, "DonationCellMaster 2", new DateTime(2023, 5, 22, 1, 52, 0, 34, DateTimeKind.Utc).AddTicks(4120) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_ApiUserId",
                table: "AspNetRoles",
                column: "ApiUserId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DonationCellMasters_LocationzId",
                table: "DonationCellMasters",
                column: "LocationzId");

            migrationBuilder.CreateIndex(
                name: "IX_DonationCellMasters_MajlisId",
                table: "DonationCellMasters",
                column: "MajlisId");

            migrationBuilder.CreateIndex(
                name: "IX_DonationCellMasters_SUId",
                table: "DonationCellMasters",
                column: "SUId");

            migrationBuilder.CreateIndex(
                name: "IX_DonationSubTypes_DonationTypeId",
                table: "DonationSubTypes",
                column: "DonationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DonationTypes_COAId",
                table: "DonationTypes",
                column: "COAId");

            migrationBuilder.CreateIndex(
                name: "IX_DonationTypes_DonationCategoryId",
                table: "DonationTypes",
                column: "DonationCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_DonationTypes_SysmanAccountId",
                table: "DonationTypes",
                column: "SysmanAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_LEs_BGId",
                table: "LEs",
                column: "BGId");

            migrationBuilder.CreateIndex(
                name: "IX_MadaniBastaSubCategorys_MadaniBastaId",
                table: "MadaniBastaSubCategorys",
                column: "MadaniBastaId");

            migrationBuilder.CreateIndex(
                name: "IX_OUs_LEId",
                table: "OUs",
                column: "LEId");

            migrationBuilder.CreateIndex(
                name: "IX_SUs_OUId",
                table: "SUs",
                column: "OUId");

            migrationBuilder.CreateIndex(
                name: "IX_Systemzs_OrgId",
                table: "Systemzs",
                column: "OrgId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DonationCellMasters");

            migrationBuilder.DropTable(
                name: "DonationSubTypes");

            migrationBuilder.DropTable(
                name: "MadaniBastaEvents");

            migrationBuilder.DropTable(
                name: "MadaniBastaPlaces");

            migrationBuilder.DropTable(
                name: "MadaniBastaSubCategorys");

            migrationBuilder.DropTable(
                name: "Systemzs");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Locationzs");

            migrationBuilder.DropTable(
                name: "Majliss");

            migrationBuilder.DropTable(
                name: "SUs");

            migrationBuilder.DropTable(
                name: "DonationTypes");

            migrationBuilder.DropTable(
                name: "MadaniBastas");

            migrationBuilder.DropTable(
                name: "Orgs");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "OUs");

            migrationBuilder.DropTable(
                name: "COAs");

            migrationBuilder.DropTable(
                name: "DonationCategorys");

            migrationBuilder.DropTable(
                name: "SysmanAccounts");

            migrationBuilder.DropTable(
                name: "LEs");

            migrationBuilder.DropTable(
                name: "BGs");
        }
    }
}
