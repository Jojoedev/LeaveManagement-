﻿// <auto-generated />
using System;
using LeaveManagement.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LeaveManagement.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230526084459_AddRequesterDB")]
    partial class AddRequesterDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LeaveManagement.Data.Employee", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateJoined")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

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

                    b.Property<string>("TaxId")
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

                    b.HasData(
                        new
                        {
                            Id = "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87340",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c29bcbf4-e070-428f-a2c4-6f29d04f0373",
                            DateJoined = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "doc@yahoo.com",
                            EmailConfirmed = true,
                            FirstName = "DON",
                            LastName = "DOC",
                            LockoutEnabled = false,
                            NormalizedEmail = "DOCS@YAHOO.COM",
                            NormalizedUserName = "DOC@YAHOO.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAECozNVQ5rLwLHmE8XsA9dlXjP69aTPKM0Hpu/LbHQKGcxvWqtSI7pBJai6IlrRlRxg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "02195891-966d-4fa2-b512-5d1e62f1b5d8",
                            TwoFactorEnabled = false,
                            UserName = "doc@yahoo.com"
                        },
                        new
                        {
                            Id = "bf23ce0b - 7c06 - 3c70 - a124 - 78b4dbd87230",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1f88aebc-2830-485e-8d8e-1970adfdfd05",
                            DateJoined = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Jojoe@yahoo.com",
                            EmailConfirmed = true,
                            FirstName = "JOE",
                            LastName = "JO",
                            LockoutEnabled = false,
                            NormalizedEmail = "JOJOE@YAHOO.COM",
                            NormalizedUserName = "JOJOE@YAHOO.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEKhGwZH2PVNlWJyyP6AgY7J+shC9Roc1hB+85z2U3I36oJOu99rrD0oPsgsbTd1XrA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b9c8edb2-aa5c-4d6e-8694-5413d24116c3",
                            TwoFactorEnabled = false,
                            UserName = "jojoe@YAHOO.COM"
                        },
                        new
                        {
                            Id = "93fd5a9f - 677a - 4998 - a010 - 16b997082282",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6d730f69-a167-462c-ab88-d42085be701c",
                            DateJoined = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "yus@yahoo.com",
                            EmailConfirmed = true,
                            FirstName = "BABATUNDE",
                            LastName = "Yusuf",
                            LockoutEnabled = false,
                            NormalizedEmail = "YUS@YAHOO.COM",
                            NormalizedUserName = "YUS@YAHOO.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENsM6zz1hRxXYDEe+iONMcPNbOzhllzAJy0YnCnczoK5yYpm1aW3x48VEhe7X2q2pg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "71a1682d-6914-42ab-8b81-db376bed7fc6",
                            TwoFactorEnabled = false,
                            UserName = "yus@YAHOO.COM"
                        },
                        new
                        {
                            Id = "93fd5a9f - 677a - 4998 - a010 - 16b997082241",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b3462d2d-bde5-4260-a4cf-e5394bf92ac4",
                            DateJoined = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "accts@yahoo.com",
                            EmailConfirmed = true,
                            FirstName = "Friday",
                            LastName = "Onuh",
                            LockoutEnabled = false,
                            NormalizedEmail = "ACCTS@YAHOO.COM",
                            NormalizedUserName = "ACCTS@YAHOO.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEL4zU37ulk1t5BRM3kTEZdw/3IEC6/wK1v0iCKICaIcJ6ecZYO5l3JmFl14zuMlh+Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a7aa80c9-3834-4f42-a9db-3fcfae618dbe",
                            TwoFactorEnabled = false,
                            UserName = "ACCTS@YAHOO.COM"
                        });
                });

            modelBuilder.Entity("LeaveManagement.Data.LeaveAllocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LeaveTypeId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfDays")
                        .HasColumnType("int");

                    b.Property<int>("Period")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LeaveTypeId");

                    b.ToTable("LeaveAllocations");
                });

            modelBuilder.Entity("LeaveManagement.Data.LeaveType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("DefaultDays")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Period")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("LeaveTypes");
                });

            modelBuilder.Entity("LeaveManagement.Data.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RequesterId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RequesterId");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("LeaveManagement.Data.Requester", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Requesters");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
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

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87311",
                            ConcurrencyStamp = "eb3a342b-ff37-43f0-a834-66a5550f291d",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "bf65ce0b-8c04-4c70-a124-78b4dbd87613",
                            ConcurrencyStamp = "cf8d99e5-7706-458b-9706-8a9327acf4d9",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "bf65ce0b-8c04-4c70-a124-78b4dbd87666",
                            ConcurrencyStamp = "54ec9707-7d6d-4a89-9f94-2efa0511bd85",
                            Name = "IT",
                            NormalizedName = "IT"
                        },
                        new
                        {
                            Id = "bf65ce0b-8c04-4c70-a124-78b4dbd87667",
                            ConcurrencyStamp = "76d7e61e-8411-47bb-aa19-1d401204a16c",
                            Name = "Accounts",
                            NormalizedName = "ACCOUNTS"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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

                    b.HasData(
                        new
                        {
                            UserId = "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87340",
                            RoleId = "bf88ce0b - 8c06 - 4c70 - a124 - 78b4dbd87311"
                        },
                        new
                        {
                            UserId = "bf23ce0b - 7c06 - 3c70 - a124 - 78b4dbd87230",
                            RoleId = "bf65ce0b-8c04-4c70-a124-78b4dbd87613"
                        },
                        new
                        {
                            UserId = "93fd5a9f - 677a - 4998 - a010 - 16b997082282",
                            RoleId = "bf65ce0b-8c04-4c70-a124-78b4dbd87666"
                        },
                        new
                        {
                            UserId = "93fd5a9f - 677a - 4998 - a010 - 16b997082241",
                            RoleId = "bf65ce0b-8c04-4c70-a124-78b4dbd87667"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("LeaveManagement.Data.LeaveAllocation", b =>
                {
                    b.HasOne("LeaveManagement.Data.LeaveType", "LeaveType")
                        .WithMany()
                        .HasForeignKey("LeaveTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LeaveType");
                });

            modelBuilder.Entity("LeaveManagement.Data.Request", b =>
                {
                    b.HasOne("LeaveManagement.Data.Requester", "Requester")
                        .WithMany()
                        .HasForeignKey("RequesterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Requester");
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
                    b.HasOne("LeaveManagement.Data.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("LeaveManagement.Data.Employee", null)
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

                    b.HasOne("LeaveManagement.Data.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("LeaveManagement.Data.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
