﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entities.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20200523082104_Trips")]
    partial class Trips
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameRu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameUa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Albania",
                            NameRu = "Албания",
                            NameUa = "Албанія"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Canada",
                            NameRu = "Канада",
                            NameUa = "Канада"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Colombia",
                            NameRu = "Колумбия",
                            NameUa = "Колумбія"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Cyprus",
                            NameRu = "Кипр",
                            NameUa = "Кіпр"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Dominica",
                            NameRu = "Доминикана",
                            NameUa = "Домінікана"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Egypt",
                            NameRu = "Египет",
                            NameUa = "Єгипет"
                        },
                        new
                        {
                            Id = 7,
                            Name = "France",
                            NameRu = "Франция",
                            NameUa = "Франція"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Ukraine",
                            NameRu = "Украина",
                            NameUa = "Україна"
                        });
                });

            modelBuilder.Entity("Entities.Models.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArrivalCountryId")
                        .HasColumnType("int");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartureCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartureCountryId")
                        .HasColumnType("int");

                    b.Property<string>("DifferenceInTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FlightTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TransplantTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArrivalCountryId");

                    b.HasIndex("DepartureCountryId");

                    b.HasIndex("UserId");

                    b.ToTable("trips");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            ArrivalCountryId = 1,
                            Currency = "$",
                            DepartureCity = "Киев, Одесса с пересадкой в Дубае или Катаре",
                            DepartureCountryId = 8,
                            DifferenceInTime = "1 час",
                            EndDate = new DateTime(2020, 5, 30, 11, 21, 3, 453, DateTimeKind.Local).AddTicks(5132),
                            FlightTime = "0 часов",
                            ImageUrl = "https://www.eurotourism.az/site/assets/files/1817/5-7_1.jpg",
                            StartDate = new DateTime(2020, 5, 23, 11, 21, 3, 453, DateTimeKind.Local).AddTicks(5132),
                            TotalPrice = 100m,
                            TransplantTime = "+ время пересадки",
                            UserId = -1
                        },
                        new
                        {
                            Id = -2,
                            ArrivalCountryId = 2,
                            Currency = "$",
                            DepartureCity = "Киев, Одесса с пересадкой в Дубае или Катаре",
                            DepartureCountryId = 8,
                            DifferenceInTime = "2 час",
                            EndDate = new DateTime(2020, 4, 29, 11, 21, 3, 458, DateTimeKind.Local).AddTicks(315),
                            FlightTime = "2 часов",
                            ImageUrl = "https://cdn.vuetifyjs.com/images/cards/plane.jpg",
                            StartDate = new DateTime(2020, 4, 22, 11, 21, 3, 458, DateTimeKind.Local).AddTicks(315),
                            TotalPrice = 102m,
                            TransplantTime = "- прямой",
                            UserId = -1
                        },
                        new
                        {
                            Id = -3,
                            ArrivalCountryId = 3,
                            Currency = "$",
                            DepartureCity = "Киев, Одесса с пересадкой в Дубае или Катаре",
                            DepartureCountryId = 8,
                            DifferenceInTime = "3 час",
                            EndDate = new DateTime(2018, 3, 28, 11, 21, 3, 458, DateTimeKind.Local).AddTicks(623),
                            FlightTime = "4 часов",
                            ImageUrl = "https://www.eurotourism.az/site/assets/files/1817/5-7_1.jpg",
                            StartDate = new DateTime(2018, 3, 21, 11, 21, 3, 458, DateTimeKind.Local).AddTicks(623),
                            TotalPrice = 106m,
                            TransplantTime = "+ время пересадки",
                            UserId = -1
                        },
                        new
                        {
                            Id = -4,
                            ArrivalCountryId = 4,
                            Currency = "$",
                            DepartureCity = "Киев, Одесса с пересадкой в Дубае или Катаре",
                            DepartureCountryId = 8,
                            DifferenceInTime = "4 час",
                            EndDate = new DateTime(2018, 2, 27, 11, 21, 3, 458, DateTimeKind.Local).AddTicks(655),
                            FlightTime = "6 часов",
                            ImageUrl = "https://cdn.vuetifyjs.com/images/cards/plane.jpg",
                            StartDate = new DateTime(2018, 2, 20, 11, 21, 3, 458, DateTimeKind.Local).AddTicks(655),
                            TotalPrice = 112m,
                            TransplantTime = "- прямой",
                            UserId = -1
                        },
                        new
                        {
                            Id = -5,
                            ArrivalCountryId = 5,
                            Currency = "$",
                            DepartureCity = "Киев, Одесса с пересадкой в Дубае или Катаре",
                            DepartureCountryId = 8,
                            DifferenceInTime = "5 час",
                            EndDate = new DateTime(2016, 1, 26, 11, 21, 3, 458, DateTimeKind.Local).AddTicks(670),
                            FlightTime = "8 часов",
                            ImageUrl = "https://www.eurotourism.az/site/assets/files/1817/5-7_1.jpg",
                            StartDate = new DateTime(2016, 1, 19, 11, 21, 3, 458, DateTimeKind.Local).AddTicks(670),
                            TotalPrice = 120m,
                            TransplantTime = "+ время пересадки",
                            UserId = -1
                        },
                        new
                        {
                            Id = -6,
                            ArrivalCountryId = 6,
                            Currency = "$",
                            DepartureCity = "Киев, Одесса с пересадкой в Дубае или Катаре",
                            DepartureCountryId = 8,
                            DifferenceInTime = "6 час",
                            EndDate = new DateTime(2015, 12, 25, 11, 21, 3, 458, DateTimeKind.Local).AddTicks(691),
                            FlightTime = "10 часов",
                            ImageUrl = "https://cdn.vuetifyjs.com/images/cards/plane.jpg",
                            StartDate = new DateTime(2015, 12, 18, 11, 21, 3, 458, DateTimeKind.Local).AddTicks(691),
                            TotalPrice = 130m,
                            TransplantTime = "- прямой",
                            UserId = -1
                        },
                        new
                        {
                            Id = -7,
                            ArrivalCountryId = 7,
                            Currency = "$",
                            DepartureCity = "Киев, Одесса с пересадкой в Дубае или Катаре",
                            DepartureCountryId = 8,
                            DifferenceInTime = "7 час",
                            EndDate = new DateTime(2013, 11, 24, 11, 21, 3, 458, DateTimeKind.Local).AddTicks(707),
                            FlightTime = "12 часов",
                            ImageUrl = "https://www.eurotourism.az/site/assets/files/1817/5-7_1.jpg",
                            StartDate = new DateTime(2013, 11, 17, 11, 21, 3, 458, DateTimeKind.Local).AddTicks(707),
                            TotalPrice = 142m,
                            TransplantTime = "+ время пересадки",
                            UserId = -1
                        },
                        new
                        {
                            Id = -8,
                            ArrivalCountryId = 8,
                            Currency = "$",
                            DepartureCity = "Киев, Одесса с пересадкой в Дубае или Катаре",
                            DepartureCountryId = 8,
                            DifferenceInTime = "8 час",
                            EndDate = new DateTime(2013, 10, 23, 11, 21, 3, 458, DateTimeKind.Local).AddTicks(721),
                            FlightTime = "14 часов",
                            ImageUrl = "https://cdn.vuetifyjs.com/images/cards/plane.jpg",
                            StartDate = new DateTime(2013, 10, 16, 11, 21, 3, 458, DateTimeKind.Local).AddTicks(721),
                            TotalPrice = 156m,
                            TransplantTime = "- прямой",
                            UserId = -1
                        });
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Email = "test1@users.com",
                            Password = "r5AcRG+U3Yi5olP/rcToFJwKu2KH4PB6NJ99/fPCE8cp6SnyHWbir79TnanNAeVI"
                        },
                        new
                        {
                            Id = -2,
                            Email = "test2@users.com",
                            Password = "7JX8jQHqx1hd4HUMnBKbYO7ihBeVMl8jngm6qVXomOJx2xAlm1IuzXS5nLyGtIe1"
                        },
                        new
                        {
                            Id = -3,
                            Email = "test3@users.com",
                            Password = "9kQ0AnWvFManewW+MD4WpDnYhbhQ3PmWCGBiAbzgSoJLqK0EbGstl5YpWNGO5Pus"
                        },
                        new
                        {
                            Id = -4,
                            Email = "test4@users.com",
                            Password = "h1sk1rNrmMXAf0vXAGf+fU8YPLqop2kOQaRTQ4HWx1+w034u6Gt16nfgWNNArV5f"
                        },
                        new
                        {
                            Id = -5,
                            Email = "test5@users.com",
                            Password = "a8APt+FH76oSxud6xByXF80/9EEw3Md/rZ/Rh9/plZtnRd75zKHPUh1Y0Fmc+Xrg"
                        });
                });

            modelBuilder.Entity("Entities.Models.Trip", b =>
                {
                    b.HasOne("Entities.Models.Country", "ArrivalCountry")
                        .WithMany()
                        .HasForeignKey("ArrivalCountryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Entities.Models.Country", "DepartureCountry")
                        .WithMany()
                        .HasForeignKey("DepartureCountryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Entities.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
