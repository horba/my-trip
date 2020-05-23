using Entities.Models;
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
                new User { Id = -1, Email = "test1@users.com", Password = CryptoUtils.HashPassword("test1111") },
                new User { Id = -2, Email = "test2@users.com", Password = CryptoUtils.HashPassword("test2222") },
                new User { Id = -3, Email = "test3@users.com", Password = CryptoUtils.HashPassword("test3333") },
                new User { Id = -4, Email = "test4@users.com", Password = CryptoUtils.HashPassword("test4444") },
                new User { Id = -5, Email = "test5@users.com", Password = CryptoUtils.HashPassword("test5555") }
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