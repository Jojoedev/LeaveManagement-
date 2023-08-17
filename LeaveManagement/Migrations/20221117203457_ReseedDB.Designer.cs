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
    [Migration("20221117203457_ReseedDB")]
    partial class ReseedDB
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
                            ConcurrencyStamp = "dac80205-f032-4846-8806-1195b5be7bc7",
                            DateJoined = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "doc@yahoo.com",
                            EmailConfirmed = true,
                            FirstName = "DON",
                            LastName = "DOC",
                            LockoutEnabled = false,
                            NormalizedEmail = "DOCS@YAHOO.COM",
                            NormalizedUserName = "DOC@YAHOO.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJhjDr1re7Xx+00uVApgLJkSY+J8fM1QTcE81A/bAmHXkv6a6W6Y9OaHG/uW6lII+Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "bec7ab9e-6445-4572-8e00-5cb7f7ab0bdd",
                            TwoFactorEnabled = false,
                            UserName = "doc@yahoo.com"
                        },
                        new
                        {
                            Id = "bf23ce0b - 7c06 - 3c70 - a124 - 78b4dbd87230",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "677dcf82-3558-4e6c-b3fc-e9aae910be56",
                            DateJoined = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Jojoe@yahoo.com",
                            EmailConfirmed = true,
                            FirstName = "JOE",
                            LastName = "JO",
                            LockoutEnabled = false,
                            NormalizedEmail = "JOJOE@YAHOO.COM",
                            NormalizedUserName = "JOJOE@YAHOO.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJzEQ9hmHZqUMWdNlcjryJlamzpC1QSw8QpDFK/4FcqVQk87axm94nUKJ9EzWomLcQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9c76221d-dd4e-4bc8-988b-734aea302a34",
                            TwoFactorEnabled = false,
                            UserName = "jojoe@YAHOO.COM"
                        },
                        new
                        {
                            Id = "93fd5a9f - 677a - 4998 - a010 - 16b997082282",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ca0038b8-6c72-46b3-a295-7c4871c11c2b",
                            DateJoined = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "yus@yahoo.com",
                            EmailConfirmed = true,
                            FirstName = "BABATUNDE",
                            LastName = "Yusuf",
                            LockoutEnabled = false,
                            NormalizedEmail = "YUS@YAHOO.COM",
                            NormalizedUserName = "YUS@YAHOO.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEGu2i9T3XcgZUVCFHRNwmsuwZpzwwiHuAcLdUG5tx2IuAYfs+qMZj5lCw6Wgjm+0Ag==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "df8a522d-11fc-4009-bb35-8310ac7f2346",
                            TwoFactorEnabled = false,
                            UserName = "yus@YAHOO.COM"
                        },
                        new
                        {
                            Id = "93fd5a9f - 677a - 4998 - a010 - 16b997082241",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "782d71bf-892a-40fd-89eb-9cdaa8034640",
                            DateJoined = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "accts@yahoo.com",
                            EmailConfirmed = true,
                            FirstName = "Friday",
                            LastName = "Onuh",
                            LockoutEnabled = false,
                            NormalizedEmail = "ACCTS@YAHOO.COM",
                            NormalizedUserName = "ACCTS@YAHOO.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEL5/EWQZpVHtrAIycMd8s4BIZPOf6+sLlwf2gi9uXnwDB5Vav/YcCqLvuimehf7ARg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c8b3317d-0486-4fc1-9d6a-62374106d187",
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
                            ConcurrencyStamp = "68356539-286a-4abf-b368-2f7660d3a372",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "bf65ce0b-8c04-4c70-a124-78b4dbd87613",
                            ConcurrencyStamp = "c2deac11-586d-4413-bfa0-afd77fce714f",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "bf65ce0b-8c04-4c70-a124-78b4dbd87666",
                            ConcurrencyStamp = "2128b72f-1180-4d67-a887-1b08c0533db8",
                            Name = "IT",
                            NormalizedName = "IT"
                        },
                        new
                        {
                            Id = "bf65ce0b-8c04-4c70-a124-78b4dbd87667",
                            ConcurrencyStamp = "50d46c2a-af3f-44f3-b3ff-32d4edefed5d",
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