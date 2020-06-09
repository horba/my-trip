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
    [Migration("20200608142953_GoogleOauth")]
    partial class GoogleOauth
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

            modelBuilder.Entity("Entities.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("languages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "English"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Russian"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Ukrainian"
                        });
                });

            modelBuilder.Entity("Entities.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Adults")
                        .HasColumnType("int");

                    b.Property<int>("Children")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Adults = 5,
                            Children = 0,
                            UserId = -1
                        },
                        new
                        {
                            Id = -2,
                            Adults = 4,
                            Children = 0,
                            UserId = -1
                        },
                        new
                        {
                            Id = -3,
                            Adults = 3,
                            Children = 0,
                            UserId = -1
                        },
                        new
                        {
                            Id = -4,
                            Adults = 2,
                            Children = 0,
                            UserId = -1
                        },
                        new
                        {
                            Id = -5,
                            Adults = 1,
                            Children = 0,
                            UserId = -1
                        });
                });

            modelBuilder.Entity("Entities.Models.TicketRoute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArrivalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ArrivalDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartureCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DepartureDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("TicketId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TicketId");

                    b.ToTable("TicketRoutes");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            ArrivalCode = "KBP",
                            ArrivalDateTime = new DateTime(2022, 1, 3, 9, 0, 0, 0, DateTimeKind.Local),
                            DepartureCode = "KBK",
                            DepartureDateTime = new DateTime(2022, 1, 2, 9, 0, 0, 0, DateTimeKind.Local),
                            Price = 1000,
                            TicketId = -1
                        },
                        new
                        {
                            Id = -2,
                            ArrivalCode = "KBP",
                            ArrivalDateTime = new DateTime(2022, 1, 3, 9, 0, 0, 0, DateTimeKind.Local),
                            DepartureCode = "KBK",
                            DepartureDateTime = new DateTime(2022, 1, 2, 9, 0, 0, 0, DateTimeKind.Local),
                            Price = 900,
                            TicketId = -1
                        },
                        new
                        {
                            Id = -3,
                            ArrivalCode = "KBP",
                            ArrivalDateTime = new DateTime(2022, 1, 3, 9, 0, 0, 0, DateTimeKind.Local),
                            DepartureCode = "KBK",
                            DepartureDateTime = new DateTime(2022, 1, 2, 9, 0, 0, 0, DateTimeKind.Local),
                            Price = 800,
                            TicketId = -2
                        },
                        new
                        {
                            Id = -4,
                            ArrivalCode = "KBP",
                            ArrivalDateTime = new DateTime(2022, 1, 3, 9, 0, 0, 0, DateTimeKind.Local),
                            DepartureCode = "KBK",
                            DepartureDateTime = new DateTime(2022, 1, 2, 9, 0, 0, 0, DateTimeKind.Local),
                            Price = 700,
                            TicketId = -2
                        },
                        new
                        {
                            Id = -5,
                            ArrivalCode = "KBP",
                            ArrivalDateTime = new DateTime(2022, 1, 3, 9, 0, 0, 0, DateTimeKind.Local),
                            DepartureCode = "KBK",
                            DepartureDateTime = new DateTime(2022, 1, 2, 9, 0, 0, 0, DateTimeKind.Local),
                            Price = 600,
                            TicketId = -3
                        },
                        new
                        {
                            Id = -6,
                            ArrivalCode = "KBP",
                            ArrivalDateTime = new DateTime(2022, 1, 3, 9, 0, 0, 0, DateTimeKind.Local),
                            DepartureCode = "KBK",
                            DepartureDateTime = new DateTime(2022, 1, 2, 9, 0, 0, 0, DateTimeKind.Local),
                            Price = 500,
                            TicketId = -3
                        },
                        new
                        {
                            Id = -7,
                            ArrivalCode = "KBP",
                            ArrivalDateTime = new DateTime(2022, 1, 3, 9, 0, 0, 0, DateTimeKind.Local),
                            DepartureCode = "KBK",
                            DepartureDateTime = new DateTime(2022, 1, 2, 9, 0, 0, 0, DateTimeKind.Local),
                            Price = 400,
                            TicketId = -4
                        },
                        new
                        {
                            Id = -8,
                            ArrivalCode = "KBP",
                            ArrivalDateTime = new DateTime(2022, 1, 3, 9, 0, 0, 0, DateTimeKind.Local),
                            DepartureCode = "KBK",
                            DepartureDateTime = new DateTime(2022, 1, 2, 9, 0, 0, 0, DateTimeKind.Local),
                            Price = 300,
                            TicketId = -4
                        },
                        new
                        {
                            Id = -9,
                            ArrivalCode = "KBP",
                            ArrivalDateTime = new DateTime(2022, 1, 3, 9, 0, 0, 0, DateTimeKind.Local),
                            DepartureCode = "KBK",
                            DepartureDateTime = new DateTime(2022, 1, 2, 9, 0, 0, 0, DateTimeKind.Local),
                            Price = 200,
                            TicketId = -5
                        },
                        new
                        {
                            Id = -10,
                            ArrivalCode = "KBP",
                            ArrivalDateTime = new DateTime(2022, 1, 3, 9, 0, 0, 0, DateTimeKind.Local),
                            DepartureCode = "KBK",
                            DepartureDateTime = new DateTime(2022, 1, 2, 9, 0, 0, 0, DateTimeKind.Local),
                            Price = 100,
                            TicketId = -5
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
                            EndDate = new DateTime(2020, 6, 15, 17, 29, 53, 533, DateTimeKind.Local).AddTicks(4943),
                            FlightTime = "0 часов",
                            ImageUrl = "https://www.eurotourism.az/site/assets/files/1817/5-7_1.jpg",
                            StartDate = new DateTime(2020, 6, 8, 17, 29, 53, 533, DateTimeKind.Local).AddTicks(4943),
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
                            EndDate = new DateTime(2020, 5, 14, 17, 29, 53, 535, DateTimeKind.Local).AddTicks(7470),
                            FlightTime = "2 часов",
                            ImageUrl = "https://cdn.vuetifyjs.com/images/cards/plane.jpg",
                            StartDate = new DateTime(2020, 5, 7, 17, 29, 53, 535, DateTimeKind.Local).AddTicks(7470),
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
                            EndDate = new DateTime(2018, 4, 13, 17, 29, 53, 535, DateTimeKind.Local).AddTicks(7626),
                            FlightTime = "4 часов",
                            ImageUrl = "https://www.eurotourism.az/site/assets/files/1817/5-7_1.jpg",
                            StartDate = new DateTime(2018, 4, 6, 17, 29, 53, 535, DateTimeKind.Local).AddTicks(7626),
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
                            EndDate = new DateTime(2018, 3, 12, 17, 29, 53, 535, DateTimeKind.Local).AddTicks(7640),
                            FlightTime = "6 часов",
                            ImageUrl = "https://cdn.vuetifyjs.com/images/cards/plane.jpg",
                            StartDate = new DateTime(2018, 3, 5, 17, 29, 53, 535, DateTimeKind.Local).AddTicks(7640),
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
                            EndDate = new DateTime(2016, 2, 11, 17, 29, 53, 535, DateTimeKind.Local).AddTicks(7647),
                            FlightTime = "8 часов",
                            ImageUrl = "https://www.eurotourism.az/site/assets/files/1817/5-7_1.jpg",
                            StartDate = new DateTime(2016, 2, 4, 17, 29, 53, 535, DateTimeKind.Local).AddTicks(7647),
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
                            EndDate = new DateTime(2016, 1, 10, 17, 29, 53, 535, DateTimeKind.Local).AddTicks(7656),
                            FlightTime = "10 часов",
                            ImageUrl = "https://cdn.vuetifyjs.com/images/cards/plane.jpg",
                            StartDate = new DateTime(2016, 1, 3, 17, 29, 53, 535, DateTimeKind.Local).AddTicks(7656),
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
                            EndDate = new DateTime(2013, 12, 9, 17, 29, 53, 535, DateTimeKind.Local).AddTicks(7662),
                            FlightTime = "12 часов",
                            ImageUrl = "https://www.eurotourism.az/site/assets/files/1817/5-7_1.jpg",
                            StartDate = new DateTime(2013, 12, 2, 17, 29, 53, 535, DateTimeKind.Local).AddTicks(7662),
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
                            EndDate = new DateTime(2013, 11, 8, 17, 29, 53, 535, DateTimeKind.Local).AddTicks(7669),
                            FlightTime = "14 часов",
                            ImageUrl = "https://cdn.vuetifyjs.com/images/cards/plane.jpg",
                            StartDate = new DateTime(2013, 11, 1, 17, 29, 53, 535, DateTimeKind.Local).AddTicks(7669),
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

                    b.Property<string>("AvatarFileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("GoogleId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResetPasswordToken")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("LanguageId");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Email = "test1@users.com",
                            FirstName = "Fn1",
                            Gender = 0,
                            LastName = "Ln1",
                            Password = "HeW8o1gi5/HRxNuimINBK0exhgcgueMp9gNYP9as992yG1CYCM0fwDxHKe4ZLnPA"
                        },
                        new
                        {
                            Id = -2,
                            Email = "test2@users.com",
                            FirstName = "FirstName2",
                            Gender = 2,
                            LastName = "LastName2",
                            Password = "fZGtHLkKTSW+hAtXYZ6+1cUBMZUlHd0OR0pxoK2z493heGLrHtO8qTPw4iBae/T+"
                        },
                        new
                        {
                            Id = -3,
                            Email = "test3@users.com",
                            FirstName = "FFFF3",
                            Gender = 3,
                            LastName = "LLLL3",
                            Password = "ThMK2O3QoEUPtMjY0Q77ajQFUowh/97a4vNNGWJkyidHr1Cp3jkbDHJsNpIcGTgw"
                        },
                        new
                        {
                            Id = -4,
                            Email = "test4@users.com",
                            FirstName = "LongFirstName4",
                            Gender = 2,
                            LastName = "LongLastName4",
                            Password = "tJnHvgpNpyyyC5uhfi0qmGSFycW6VIcpQYtOtiThMs3ntJ0MEolHeOiQ63uFuV5f"
                        },
                        new
                        {
                            Id = -5,
                            Email = "test5@users.com",
                            Gender = 0,
                            LastName = "Last5",
                            Password = "hSwRBu0TlyHi+eMDGMW2YM6kN6OTjsRfJ+8CBSmo8gB7utkb25zxGMmwUbA8RMUn"
                        });
                });

            modelBuilder.Entity("Entities.Models.Ticket", b =>
                {
                    b.HasOne("Entities.Models.User", "User")
                        .WithMany("Tickets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.TicketRoute", b =>
                {
                    b.HasOne("Entities.Models.Ticket", null)
                        .WithMany("Routes")
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
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

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.HasOne("Entities.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Entities.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
