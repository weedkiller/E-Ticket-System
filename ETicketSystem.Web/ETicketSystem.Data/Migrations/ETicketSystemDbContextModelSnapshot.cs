﻿// <auto-generated />
using ETicketSystem.Data;
using ETicketSystem.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace ETicketSystem.Data.Migrations
{
    [DbContext(typeof(ETicketSystemDbContext))]
    partial class ETicketSystemDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ETicketSystem.Data.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CompanyId");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("PublishDate");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("ETicketSystem.Data.Models.Route", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BusType");

                    b.Property<string>("CompanyId");

                    b.Property<TimeSpan>("DepartureTime");

                    b.Property<TimeSpan>("Duration");

                    b.Property<int>("EndStationId");

                    b.Property<bool>("IsActive");

                    b.Property<decimal>("Price");

                    b.Property<int>("StartStationId");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("EndStationId");

                    b.HasIndex("StartStationId");

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("ETicketSystem.Data.Models.Station", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .HasMaxLength(15);

                    b.Property<int>("TownId");

                    b.HasKey("Id");

                    b.HasIndex("TownId");

                    b.ToTable("Stations");
                });

            modelBuilder.Entity("ETicketSystem.Data.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DepartureTime");

                    b.Property<bool>("IsCancelled");

                    b.Property<int>("RouteId");

                    b.Property<int>("SeatNumber");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RouteId");

                    b.HasIndex("UserId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("ETicketSystem.Data.Models.Town", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Towns");
                });

            modelBuilder.Entity("ETicketSystem.Data.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<DateTime?>("RegistrationDate");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ETicketSystem.Data.Models.Company", b =>
                {
                    b.HasBaseType("ETicketSystem.Data.Models.User");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(95);

                    b.Property<string>("ChiefFirstName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("ChiefLastName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(3000);

                    b.Property<int>("DownVotes");

                    b.Property<bool>("IsApproved");

                    b.Property<bool>("IsBlocked");

                    b.Property<byte[]>("Logo")
                        .HasMaxLength(512000);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("TownId");

                    b.Property<string>("UniqueReferenceNumber")
                        .IsRequired()
                        .HasMaxLength(13);

                    b.Property<int>("UpVotes");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.HasIndex("PhoneNumber")
                        .IsUnique()
                        .HasFilter("[PhoneNumber] IS NOT NULL");

                    b.HasIndex("TownId");

                    b.HasIndex("UniqueReferenceNumber")
                        .IsUnique()
                        .HasFilter("[UniqueReferenceNumber] IS NOT NULL");

                    b.ToTable("Company");

                    b.HasDiscriminator().HasValue("Company");
                });

            modelBuilder.Entity("ETicketSystem.Data.Models.RegularUser", b =>
                {
                    b.HasBaseType("ETicketSystem.Data.Models.User");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(35);

                    b.Property<int>("Gender");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(35);

                    b.ToTable("RegularUser");

                    b.HasDiscriminator().HasValue("RegularUser");
                });

            modelBuilder.Entity("ETicketSystem.Data.Models.Review", b =>
                {
                    b.HasOne("ETicketSystem.Data.Models.Company", "Company")
                        .WithMany("Reviews")
                        .HasForeignKey("CompanyId");

                    b.HasOne("ETicketSystem.Data.Models.RegularUser", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ETicketSystem.Data.Models.Route", b =>
                {
                    b.HasOne("ETicketSystem.Data.Models.Company", "Company")
                        .WithMany("Routes")
                        .HasForeignKey("CompanyId");

                    b.HasOne("ETicketSystem.Data.Models.Station", "EndStation")
                        .WithMany("ArrivalRoutes")
                        .HasForeignKey("EndStationId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ETicketSystem.Data.Models.Station", "StartStation")
                        .WithMany("DepartureRoutes")
                        .HasForeignKey("StartStationId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ETicketSystem.Data.Models.Station", b =>
                {
                    b.HasOne("ETicketSystem.Data.Models.Town", "Town")
                        .WithMany("Stations")
                        .HasForeignKey("TownId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ETicketSystem.Data.Models.Ticket", b =>
                {
                    b.HasOne("ETicketSystem.Data.Models.Route", "Route")
                        .WithMany("Tickets")
                        .HasForeignKey("RouteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ETicketSystem.Data.Models.RegularUser", "User")
                        .WithMany("Tickets")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ETicketSystem.Data.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ETicketSystem.Data.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ETicketSystem.Data.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ETicketSystem.Data.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ETicketSystem.Data.Models.Company", b =>
                {
                    b.HasOne("ETicketSystem.Data.Models.Town", "Town")
                        .WithMany("Companies")
                        .HasForeignKey("TownId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
