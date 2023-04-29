﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectName.Infra.Context;

#nullable disable

namespace ProjectName.Infra.Migrations
{
    [DbContext(typeof(DBCntxt))]
    partial class DBCntxtModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ApiUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("ApiUserId");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "56cad2c0-8f29-464e-b16e-646cf896dd59",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "a4a1abaf-b966-4a6d-8a00-9f002586b169",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ProjectName.Infra.Entity.ApiUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("ProjectName.Infra.Entity.Hierarchy.BG", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("BGs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 4, 29, 3, 32, 22, 620, DateTimeKind.Utc).AddTicks(9924),
                            Description = "BG 1 Description",
                            Title = "BG 1",
                            UpdatedAt = new DateTime(2023, 4, 29, 3, 32, 22, 620, DateTimeKind.Utc).AddTicks(9926)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 4, 29, 3, 32, 22, 620, DateTimeKind.Utc).AddTicks(9930),
                            Description = "BG 2 Description",
                            Title = "BG 2",
                            UpdatedAt = new DateTime(2023, 4, 29, 3, 32, 22, 620, DateTimeKind.Utc).AddTicks(9931)
                        });
                });

            modelBuilder.Entity("ProjectName.Infra.Entity.Hierarchy.LE", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<int>("BGId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BGId");

                    b.ToTable("LEs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BGId = 1,
                            CreatedAt = new DateTime(2023, 4, 29, 3, 32, 22, 621, DateTimeKind.Utc).AddTicks(303),
                            Description = "LE 1 Description",
                            Title = "LE 1",
                            UpdatedAt = new DateTime(2023, 4, 29, 3, 32, 22, 621, DateTimeKind.Utc).AddTicks(304)
                        },
                        new
                        {
                            Id = 2,
                            BGId = 2,
                            CreatedAt = new DateTime(2023, 4, 29, 3, 32, 22, 621, DateTimeKind.Utc).AddTicks(312),
                            Description = "LE 2 Description",
                            Title = "LE 2",
                            UpdatedAt = new DateTime(2023, 4, 29, 3, 32, 22, 621, DateTimeKind.Utc).AddTicks(312)
                        });
                });

            modelBuilder.Entity("ProjectName.Infra.Entity.Hierarchy.OU", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LEId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("LEId");

                    b.ToTable("OUs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 4, 29, 3, 32, 22, 621, DateTimeKind.Utc).AddTicks(684),
                            Description = "OU 1 Description",
                            LEId = 1,
                            Title = "OU 1",
                            UpdatedAt = new DateTime(2023, 4, 29, 3, 32, 22, 621, DateTimeKind.Utc).AddTicks(685)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 4, 29, 3, 32, 22, 621, DateTimeKind.Utc).AddTicks(690),
                            Description = "OU 2 Description",
                            LEId = 2,
                            Title = "OU 2",
                            UpdatedAt = new DateTime(2023, 4, 29, 3, 32, 22, 621, DateTimeKind.Utc).AddTicks(691)
                        });
                });

            modelBuilder.Entity("ProjectName.Infra.Entity.Hierarchy.Org", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Orgs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 4, 29, 3, 32, 22, 620, DateTimeKind.Utc).AddTicks(9121),
                            Description = "Org 1 Description",
                            Title = "Org 1",
                            UpdatedAt = new DateTime(2023, 4, 29, 3, 32, 22, 620, DateTimeKind.Utc).AddTicks(9131)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 4, 29, 3, 32, 22, 620, DateTimeKind.Utc).AddTicks(9138),
                            Description = "Org 2 Description",
                            Title = "Org 2",
                            UpdatedAt = new DateTime(2023, 4, 29, 3, 32, 22, 620, DateTimeKind.Utc).AddTicks(9139)
                        });
                });

            modelBuilder.Entity("ProjectName.Infra.Entity.Hierarchy.SU", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OUId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("OUId");

                    b.ToTable("SUs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 4, 29, 3, 32, 22, 621, DateTimeKind.Utc).AddTicks(1188),
                            Description = "SU 1 Description",
                            OUId = 1,
                            Title = "SU 1",
                            UpdatedAt = new DateTime(2023, 4, 29, 3, 32, 22, 621, DateTimeKind.Utc).AddTicks(1189)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 4, 29, 3, 32, 22, 621, DateTimeKind.Utc).AddTicks(1193),
                            Description = "SU 2 Description",
                            OUId = 2,
                            Title = "SU 2",
                            UpdatedAt = new DateTime(2023, 4, 29, 3, 32, 22, 621, DateTimeKind.Utc).AddTicks(1194)
                        });
                });

            modelBuilder.Entity("ProjectName.Infra.Entity.Hierarchy.Systemz", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrgId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("OrgId");

                    b.ToTable("Systemzs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 4, 29, 3, 32, 22, 620, DateTimeKind.Utc).AddTicks(9527),
                            Description = "Systemz 1 Description",
                            OrgId = 1,
                            Title = "Systemz 1",
                            UpdatedAt = new DateTime(2023, 4, 29, 3, 32, 22, 620, DateTimeKind.Utc).AddTicks(9528)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 4, 29, 3, 32, 22, 620, DateTimeKind.Utc).AddTicks(9534),
                            Description = "Systemz 2 Description",
                            OrgId = 2,
                            Title = "Systemz 2",
                            UpdatedAt = new DateTime(2023, 4, 29, 3, 32, 22, 620, DateTimeKind.Utc).AddTicks(9535)
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.HasOne("ProjectName.Infra.Entity.ApiUser", null)
                        .WithMany("Roles")
                        .HasForeignKey("ApiUserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ProjectName.Infra.Entity.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ProjectName.Infra.Entity.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectName.Infra.Entity.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ProjectName.Infra.Entity.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjectName.Infra.Entity.Hierarchy.LE", b =>
                {
                    b.HasOne("ProjectName.Infra.Entity.Hierarchy.BG", "BG")
                        .WithMany("LEs")
                        .HasForeignKey("BGId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BG");
                });

            modelBuilder.Entity("ProjectName.Infra.Entity.Hierarchy.OU", b =>
                {
                    b.HasOne("ProjectName.Infra.Entity.Hierarchy.LE", "LE")
                        .WithMany()
                        .HasForeignKey("LEId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LE");
                });

            modelBuilder.Entity("ProjectName.Infra.Entity.Hierarchy.SU", b =>
                {
                    b.HasOne("ProjectName.Infra.Entity.Hierarchy.OU", "OU")
                        .WithMany()
                        .HasForeignKey("OUId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OU");
                });

            modelBuilder.Entity("ProjectName.Infra.Entity.Hierarchy.Systemz", b =>
                {
                    b.HasOne("ProjectName.Infra.Entity.Hierarchy.Org", "Org")
                        .WithMany("Systemzs")
                        .HasForeignKey("OrgId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Org");
                });

            modelBuilder.Entity("ProjectName.Infra.Entity.ApiUser", b =>
                {
                    b.Navigation("Roles");
                });

            modelBuilder.Entity("ProjectName.Infra.Entity.Hierarchy.BG", b =>
                {
                    b.Navigation("LEs");
                });

            modelBuilder.Entity("ProjectName.Infra.Entity.Hierarchy.Org", b =>
                {
                    b.Navigation("Systemzs");
                });
#pragma warning restore 612, 618
        }
    }
}
