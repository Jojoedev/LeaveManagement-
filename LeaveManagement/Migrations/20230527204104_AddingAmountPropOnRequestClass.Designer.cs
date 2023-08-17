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
    [Migration("20230527204104_AddingAmountPropOnRequestClass")]
    partial class AddingAmountPropOnRequestClass
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
                            ConcurrencyStamp = "259badcd-baba-4373-a42e-eff0b8ce9e80",
                            DateJoined = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "doc@yahoo.com",
                            EmailConfirmed = true,
                            FirstName = "DON",
                            LastName = "DOC",
                            LockoutEnabled = false,
                            NormalizedEmail = "DOCS@YAHOO.COM",
                            NormalizedUserName = "DOC@YAHOO.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEHHe6j0wSaioHsQneqHELmjugtoC9TuBYGgEem9QFj4RZXcbXjHXNMt/P/rx41eWkQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3bc81db0-e7a7-4b8a-9da9-4c3af0a40500",
                            TwoFactorEnabled = false,
                            UserName = "doc@yahoo.com"
                        },
                        new
                        {
                            Id = "bf23ce0b - 7c06 - 3c70 - a124 - 78b4dbd87230",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fc224942-52ef-43f7-a6be-ba218bcbd16e",
                            DateJoined = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Jojoe@yahoo.com",
                            EmailConfirmed = true,
                            FirstName = "JOE",
                            LastName = "JO",
                            LockoutEnabled = false,
                            NormalizedEmail = "JOJOE@YAHOO.COM",
                            NormalizedUserName = "JOJOE@YAHOO.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEAWkbWnDecBuEjJ6lQCpwb1eIcdsO+slFF4uwlKJ1U4x8iiTt72f0YPdY84aQZLQLw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "06dd3188-b5f2-476c-be0d-90959804c29e",
                            TwoFactorEnabled = false,
                            UserName = "jojoe@YAHOO.COM"
                        },
                        new
                        {
                            Id = "93fd5a9f - 677a - 4998 - a010 - 16b997082282",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5a1f55e6-1174-464d-97f3-c377d3be1262",
                            DateJoined = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "yus@yahoo.com",
                            EmailConfirmed = true,
                            FirstName = "BABATUNDE",
                            LastName = "Yusuf",
                            LockoutEnabled = false,
                            NormalizedEmail = "YUS@YAHOO.COM",
                            NormalizedUserName = "YUS@YAHOO.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEDWcVQErEW9nO4AMb8xOMCFnrAvtqJSc8ZyE5jN0yu+jmlhGCIJnWmhtxO86zy00rw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ab614685-5066-4f8e-9791-35e1ca3b37ec",
                            TwoFactorEnabled = false,
                            UserName = "yus@YAHOO.COM"
                        },
                        new
                        {
                            Id = "93fd5a9f - 677a - 4998 - a010 - 16b997082241",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2aaee488-bb49-4866-a5ea-22db699ac0d6",
                            DateJoined = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "accts@yahoo.com",
                            EmailConfirmed = true,
                            FirstName = "Friday",
                            LastName = "Onuh",
                            LockoutEnabled = false,
                            NormalizedEmail = "ACCTS@YAHOO.COM",
                            NormalizedUserName = "ACCTS@YAHOO.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEL31nGi0vCIPlE2koeK/L+EQ8r6DKa+Io3bGww6XV/GLPZizJF8iHTIjrH1Q6cjIxg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a9c7859f-bf6f-4411-84f7-b17402eba74f",
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

                    b.Property<int?>("Amount")
                        .HasColumnType("int");

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
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

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
                            ConcurrencyStamp = "57025a00-91ef-4666-9192-1920b96e0c5a",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "bf65ce0b-8c04-4c70-a124-78b4dbd87613",
                            ConcurrencyStamp = "f8de6b43-a23b-4325-9cf8-c4e41f0f6929",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "bf65ce0b-8c04-4c70-a124-78b4dbd87666",
                            ConcurrencyStamp = "b46ebada-9f03-4aef-8249-b17ab3881db8",
                            Name = "IT",
                            NormalizedName = "IT"
                        },
                        new
                        {
                            Id = "bf65ce0b-8c04-4c70-a124-78b4dbd87667",
                            ConcurrencyStamp = "9146224f-421b-4a05-b8e2-a2d8dda044ca",
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
