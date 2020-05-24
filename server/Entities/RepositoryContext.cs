using Entities.Models;
using Entities.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Entities
{
    public class RepositoryContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Trip> Trips { get; set; }

        public RepositoryContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = -1,
                    Email = "test1@users.com",
                    Password = CryptoUtils.HashPassword("test1111"),
                    FirstName = "Fn1",
                    LastName = "Ln1",
                    Gender = Gender.NotSpecified,
                    Language = Language.German,
                    Country = Country.Germany
                },
                new User
                {
                    Id = -2,
                    Email = "test2@users.com",
                    Password = CryptoUtils.HashPassword("test2222"),
                    FirstName = "FirstName2",
                    LastName = "LastName2",
                    Gender = Gender.Female,
                    Language = Language.English,
                    Country = Country.Ukraine
                },
                new User
                {
                    Id = -3,
                    Email = "test3@users.com",
                    Password = CryptoUtils.HashPassword("test3333"),
                    FirstName = "FFFF3",
                    LastName = "LLLL3",
                    Gender = Gender.Other,
                    Language = Language.Russian,
                    Country = Country.Poland
                },
                new User
                {
                    Id = -4,
                    Email = "test4@users.com",
                    Password = CryptoUtils.HashPassword("test4444"),
                    FirstName = "LongFirstName4",
                    LastName = "LongLastName4",
                    Language = Language.English,
                    Country = Country.Poland,
                    Gender = Gender.Female
                },
                new User
                {
                    Id = -5,
                    Email = "test5@users.com",
                    Password = CryptoUtils.HashPassword("test5555"),
                    FirstName = null,
                    LastName = "Last5",
                    Language = Language.Ukrainian,
                    Country = Country.NotSpecified,
                    Gender = Gender.NotSpecified
                }
                );

            var moqCountries = new [] {
                new Country { Id = 1, Name = "Albania", NameRu = "Албания", NameUa = "Албанія" },
                new Country { Id = 2, Name = "Canada", NameRu = "Канада", NameUa = "Канада" },
                new Country { Id = 3, Name = "Colombia", NameRu = "Колумбия", NameUa = "Колумбія" },
                new Country { Id = 4, Name = "Cyprus", NameRu = "Кипр", NameUa = "Кіпр" },
                new Country { Id = 5, Name = "Dominica", NameRu = "Доминикана", NameUa = "Домінікана" },
                new Country { Id = 6, Name = "Egypt", NameRu = "Египет", NameUa = "Єгипет" },
                new Country { Id = 7, Name = "France", NameRu = "Франция", NameUa = "Франція" },
                new Country { Id = 8, Name = "Ukraine", NameRu = "Украина", NameUa = "Україна" }
             };

           modelBuilder.Entity<Country>().HasData(moqCountries);

           var moqTrips = moqCountries
                        .Select((country, i) =>
                        {
                          var date = DateTime.Now.AddYears(i % 2 - i).AddMonths(-i).AddDays(-i);

                          return new Trip
                          {
                            Id = -country.Id,
                            UserId = -1,
                            DepartureCountryId = 8,
                            DepartureCity = "Киев, Одесса с пересадкой в Дубае или Катаре",
                            ArrivalCountryId = country.Id,
                            StartDate = date,
                            EndDate = date.AddDays(7),
                            TotalPrice = 100 + i * country.Id,
                            Currency = "$",
                            FlightTime = $"{i + i} часов",
                            TransplantTime = i % 2 == 0 ? "+ время пересадки" : "- прямой",
                            DifferenceInTime = $"{i + 1} час",
                            ImageUrl = i % 2 == 0 ? "https://www.eurotourism.az/site/assets/files/1817/5-7_1.jpg" : "https://cdn.vuetifyjs.com/images/cards/plane.jpg"
                          };
                        });

           modelBuilder.Entity<Trip>().HasData(moqTrips);
        }
    }
}