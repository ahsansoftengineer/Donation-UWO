using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectName.Infra.Migrations
{
    /// <inheritdoc />
    public partial class DonorGSB : Migration
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
                name: "Branchs",
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
                    table.PrimaryKey("PK_Branchs", x => x.Id);
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
                    Law = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deposit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TopImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TopImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarningImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarningImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FooterImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FooterImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "DonorBasic",
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
                    table.PrimaryKey("PK_DonorBasic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DonorBasic_Citys_CityId",
                        column: x => x.CityId,
                        principalTable: "Citys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonorBasic_DonorTypes_DonorTypeId",
                        column: x => x.DonorTypeId,
                        principalTable: "DonorTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonorBasic_Orgs_OrgId",
                        column: x => x.OrgId,
                        principalTable: "Orgs",
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
                name: "DonorGSB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NearBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubUnitId = table.Column<int>(type: "int", nullable: false),
                    WillingToJoinDI = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    BranchId = table.Column<int>(type: "int", nullable: true),
                    Followup = table.Column<int>(type: "int", nullable: false),
                    FollowupDate = table.Column<int>(type: "int", nullable: true),
                    DonationOption = table.Column<int>(type: "int", nullable: false),
                    DonationOptionData = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonorGSB", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DonorGSB_Branchs_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branchs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DonorGSB_DonorBasic_Id",
                        column: x => x.Id,
                        principalTable: "DonorBasic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonorGSB_Majliss_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Majliss",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DonorGSB_SUs_SubUnitId",
                        column: x => x.SubUnitId,
                        principalTable: "SUs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ApiUserId", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "712bbee9-98ca-46d2-af00-0cdf56b586cb", null, null, "User", "USER" },
                    { "8297c67a-d517-4f2e-b206-86d5110e15fd", null, null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "BGs",
                columns: new[] { "Id", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(1057), "BG 1 Description", "BG 1 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(1057) },
                    { 2, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(1062), "BG 2 Description", "BG 2 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(1062) },
                    { 3, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(1065), "BG 3 Description", "BG 3 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(1065) }
                });

            migrationBuilder.InsertData(
                table: "Branchs",
                columns: new[] { "Id", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2482), "Branch 1 Description", "Branch 1 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2483) },
                    { 2, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2487), "Branch 2 Description", "Branch 2 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2488) },
                    { 3, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2490), "Branch 3 Description", "Branch 3 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2491) }
                });

            migrationBuilder.InsertData(
                table: "COAs",
                columns: new[] { "Id", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2369), "COA 1 Description", "COA 1 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2369) },
                    { 2, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2374), "COA 2 Description", "COA 2 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2374) },
                    { 3, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2377), "COA 3 Description", "COA 3 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2377) }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "Id", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2531), "Country 1 Description", "Country 1 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2532) },
                    { 2, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2536), "Country 2 Description", "Country 2 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2537) },
                    { 3, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2539), "Country 3 Description", "Country 3 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2539) }
                });

            migrationBuilder.InsertData(
                table: "DonationCategorys",
                columns: new[] { "Id", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3894), "DonationCategory 1 Description", "DonationCategory 1 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3894) },
                    { 2, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3899), "DonationCategory 2 Description", "DonationCategory 2 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3899) },
                    { 3, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3901), "DonationCategory 3 Description", "DonationCategory 3 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3902) }
                });

            migrationBuilder.InsertData(
                table: "DonorTypes",
                columns: new[] { "Id", "CreatedAt", "Description", "Status", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(5937), "DonorType 1 Description", 0, "DonorType 1 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(5938) },
                    { 2, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(5945), "DonorType 2 Description", 1, "DonorType 2 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(5945) },
                    { 3, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(5949), "DonorType 3 Description", 2, "DonorType 3 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(5950) }
                });

            migrationBuilder.InsertData(
                table: "Locationzs",
                columns: new[] { "Id", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2285), "Locationz 1 Description", "Locationz 1 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2286) },
                    { 2, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2291), "Locationz 2 Description", "Locationz 2 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2292) },
                    { 3, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2294), "Locationz 3 Description", "Locationz 3 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2295) }
                });

            migrationBuilder.InsertData(
                table: "MadaniBastaEvents",
                columns: new[] { "Id", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3415), "MadaniBastaEvent 1 Description", "MadaniBastaEvent 1 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3416) },
                    { 2, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3421), "MadaniBastaEvent 2 Description", "MadaniBastaEvent 2 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3422) },
                    { 3, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3423), "MadaniBastaEvent 3 Description", "MadaniBastaEvent 3 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3424) }
                });

            migrationBuilder.InsertData(
                table: "MadaniBastaPlaces",
                columns: new[] { "Id", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3456), "MadaniBastaPlace 1 Description", "MadaniBastaPlace 1 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3457) },
                    { 2, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3462), "MadaniBastaPlace 2 Description", "MadaniBastaPlace 2 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3462) },
                    { 3, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3464), "MadaniBastaPlace 3 Description", "MadaniBastaPlace 3 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3465) }
                });

            migrationBuilder.InsertData(
                table: "MadaniBastas",
                columns: new[] { "Id", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3376), "MadaniBasta 1 Description", "MadaniBasta 1 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3377) },
                    { 2, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3382), "MadaniBasta 2 Description", "MadaniBasta 2 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3382) },
                    { 3, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3384), "MadaniBasta 3 Description", "MadaniBasta 3 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3385) }
                });

            migrationBuilder.InsertData(
                table: "Majliss",
                columns: new[] { "Id", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2325), "Majlis 1 Description", "Majlis 1 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2326) },
                    { 2, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2332), "Majlis 2 Description", "Majlis 2 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2332) },
                    { 3, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2335), "Majlis 3 Description", "Majlis 3 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2335) }
                });

            migrationBuilder.InsertData(
                table: "Orgs",
                columns: new[] { "Id", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(520), "Org 1 Description", "Org 1 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(528) },
                    { 2, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(544), "Org 2 Description", "Org 2 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(544) },
                    { 3, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(588), "Org 3 Description", "Org 3 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(589) }
                });

            migrationBuilder.InsertData(
                table: "SysmanAccounts",
                columns: new[] { "Id", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2404), "SysmanAccount 1 Description", "SysmanAccount 1 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2405) },
                    { 2, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2409), "SysmanAccount 2 Description", "SysmanAccount 2 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2409) },
                    { 3, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2411), "SysmanAccount 3 Description", "SysmanAccount 3 Title", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2412) }
                });

            migrationBuilder.InsertData(
                table: "DonationTypes",
                columns: new[] { "Id", "COAId", "CreatedAt", "Description", "DonationCategoryId", "SysmanAccountId", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(4312), "DonationType 1 Description", 1, 1, "DonationType 1", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(4313) },
                    { 2, 2, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(4325), "DonationType Description", 2, 2, "DonationType 2", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(4325) }
                });

            migrationBuilder.InsertData(
                table: "LEs",
                columns: new[] { "Id", "BGId", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(1433), "LE 1 Description", "LE 1", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(1434) },
                    { 2, 2, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(1441), "LE 2 Description", "LE 2", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(1441) }
                });

            migrationBuilder.InsertData(
                table: "MadaniBastaSubCategorys",
                columns: new[] { "Id", "CreatedAt", "Description", "MadaniBastaId", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3821), "MadaniBastaSubCategory 1 Description", 1, "MadaniBastaSubCategory 1", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3822) },
                    { 2, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3830), "MadaniBastaSubCategory 2 Description", 2, "MadaniBastaSubCategory 2", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3830) }
                });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "CountryId", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2924), "State 1 Description", "State 1", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2925) },
                    { 2, 2, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2933), "State 2 Description", "State 2", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2933) }
                });

            migrationBuilder.InsertData(
                table: "Systemzs",
                columns: new[] { "Id", "CreatedAt", "Description", "OrgId", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(993), "SU 1 Description", 1, "SU 1", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(995) },
                    { 2, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(1002), "SU 2 Description", 2, "SU 2", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(1002) }
                });

            migrationBuilder.InsertData(
                table: "Citys",
                columns: new[] { "Id", "CreatedAt", "Description", "StateId", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3315), "City 1 Description", 1, "City 1", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3317) },
                    { 2, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3323), "City 2 Description", 2, "City 2", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(3324) }
                });

            migrationBuilder.InsertData(
                table: "DonationSubTypes",
                columns: new[] { "Id", "CreatedAt", "Description", "DonationTypeId", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(4720), "DonationCellMaster 1 Description", 1, "DonationCellMaster 1", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(4721) },
                    { 2, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(4730), "DonationCellMaster 2 Description", 2, "DonationCellMaster 2", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(4731) }
                });

            migrationBuilder.InsertData(
                table: "OUs",
                columns: new[] { "Id", "Address", "CreatedAt", "Deposit", "Description", "FooterImage", "FooterImg", "LEId", "Law", "LogoImage", "LogoImg", "Title", "TopImage", "TopImg", "UpdatedAt", "WarningImage", "WarningImg" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(1822), null, "OU 1 Description", null, null, 1, null, null, null, "OU 1", null, null, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(1823), null, null },
                    { 2, null, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(1832), null, "OU 2 Description", null, null, 2, null, null, null, "OU 2", null, null, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(1832), null, null }
                });

            migrationBuilder.InsertData(
                table: "DonorBasic",
                columns: new[] { "Id", "Address", "CityId", "CreatedAt", "Description", "DonorTypeId", "Email", "Gender", "Mobile", "OrgId", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "DonorBasic44 Address", 1, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(6344), "DonorBasic 1 Description", 1, "DonorBasic44@gmail.com", 1, "3212824400", 1, "DonorBasic 1", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(6345) },
                    { 2, "DonorBasic55 Address", 2, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(6355), "DonorBasic 2 Description", 2, "DonorBasic55@gmail.com", 1, "3212825500", 2, "DonorBasic 2", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(6356) },
                    { 3, "DonorBasic66 Address", 2, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(6361), "DonorBasic 3 Description", 2, "DonorBasic66@gmail.com", 1, "3212826600", 2, "DonorBasic 3", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(6362) },
                    { 4, "DonorGSB44 Address", 1, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(6765), "DonorGSB 4 Description", 1, "DonorGSB44@gmail.com", 1, "03444444444", 1, "DonorGSB 4", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(6767) },
                    { 5, "DonorGSB55 Address", 2, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(6785), "DonorGSB 5 Description", 2, "DonorGSB55@gmail.com", 0, "03555555555", 2, "DonorGSB 5", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(6786) },
                    { 6, "DonorGSB33 Address", 2, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(6794), "DonorGSB 6 Description", 1, "DonorGSB33@gmail.com", 2, "03666666666", 2, "DonorGSB 6", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(6795) }
                });

            migrationBuilder.InsertData(
                table: "SUs",
                columns: new[] { "Id", "CreatedAt", "Description", "OUId", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2215), "SU 1 Description", 1, "SU 1", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2216) },
                    { 2, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2222), "SU 2 Description", 2, "SU 2", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(2223) }
                });

            migrationBuilder.InsertData(
                table: "DonationCellMasters",
                columns: new[] { "Id", "Address", "CreatedAt", "Description", "LocationzId", "MajlisId", "SUId", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(5126), "DonationCellMaster 1 Description", 1, 1, 1, "DonationCellMaster 1", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(5127) },
                    { 2, "", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(5137), "DonationCellMaster 2 Description", 2, 2, 2, "DonationCellMaster 2", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(5137) }
                });

            migrationBuilder.InsertData(
                table: "DonorGSB",
                columns: new[] { "Id", "Area", "BranchId", "DepartmentId", "DonationOption", "DonationOptionData", "Followup", "FollowupDate", "NearBy", "SubUnitId", "WillingToJoinDI" },
                values: new object[,]
                {
                    { 4, "44 Area", null, null, 0, null, 0, null, "44 Near By", 1, 0 },
                    { 5, "55 Area", 2, 2, 1, "1000", 1, 5, "55 Near By", 2, 1 },
                    { 6, "66 Area", 2, 2, 2, "[{\"name\":\"Nana\",\"amount\":1000},{\"name\":\"Dadi\",\"amount\":500}]", 1, 10, "66 Near By", 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "TargetAssignments",
                columns: new[] { "Id", "CreatedAt", "Description", "IncreasePercentage", "MajlisId", "SUId", "SystemzId", "TargetFor", "TargetFrom", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(5517), "TargetAssignment 1 Description", 20, 1, 1, 1, new DateTime(2023, 7, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(5525), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(5524), "TargetAssignment 1", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(5518) },
                    { 2, new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(5541), "TargetAssignment 2 Description", 20, 2, 2, 2, new DateTime(2023, 7, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(5544), new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(5543), "TargetAssignment 2", new DateTime(2023, 6, 3, 5, 33, 18, 140, DateTimeKind.Utc).AddTicks(5541) }
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
                name: "IX_Citys_StateId",
                table: "Citys",
                column: "StateId");

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
                name: "IX_DonorBasic_CityId",
                table: "DonorBasic",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_DonorBasic_DonorTypeId",
                table: "DonorBasic",
                column: "DonorTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DonorBasic_OrgId",
                table: "DonorBasic",
                column: "OrgId");

            migrationBuilder.CreateIndex(
                name: "IX_DonorGSB_BranchId",
                table: "DonorGSB",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_DonorGSB_DepartmentId",
                table: "DonorGSB",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_DonorGSB_SubUnitId",
                table: "DonorGSB",
                column: "SubUnitId");

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
                name: "IX_States_CountryId",
                table: "States",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_SUs_OUId",
                table: "SUs",
                column: "OUId");

            migrationBuilder.CreateIndex(
                name: "IX_Systemzs_OrgId",
                table: "Systemzs",
                column: "OrgId");

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
                name: "DonorGSB");

            migrationBuilder.DropTable(
                name: "MadaniBastaEvents");

            migrationBuilder.DropTable(
                name: "MadaniBastaPlaces");

            migrationBuilder.DropTable(
                name: "MadaniBastaSubCategorys");

            migrationBuilder.DropTable(
                name: "TargetAssignments");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Locationzs");

            migrationBuilder.DropTable(
                name: "DonationTypes");

            migrationBuilder.DropTable(
                name: "Branchs");

            migrationBuilder.DropTable(
                name: "DonorBasic");

            migrationBuilder.DropTable(
                name: "MadaniBastas");

            migrationBuilder.DropTable(
                name: "Majliss");

            migrationBuilder.DropTable(
                name: "SUs");

            migrationBuilder.DropTable(
                name: "Systemzs");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "COAs");

            migrationBuilder.DropTable(
                name: "DonationCategorys");

            migrationBuilder.DropTable(
                name: "SysmanAccounts");

            migrationBuilder.DropTable(
                name: "Citys");

            migrationBuilder.DropTable(
                name: "DonorTypes");

            migrationBuilder.DropTable(
                name: "OUs");

            migrationBuilder.DropTable(
                name: "Orgs");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "LEs");

            migrationBuilder.DropTable(
                name: "Countrys");

            migrationBuilder.DropTable(
                name: "BGs");
        }
    }
}
