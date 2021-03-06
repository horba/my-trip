using Entities.Interfaces;
using Entities.Models;
using Entities.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Entities
{
  public class RepositoryContext : DbContext, IRepositoryContext
  {
    public DbSet<User> Users { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<TicketRoute> TicketRoutes { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Language> Languages { get; set; }
    public DbSet<Trip> Trips { get; set; }
    public DbSet<ScheduledPlaceToEat> ScheduledPlacesToEat { get; set; }
    public DbSet<AttachmentFileEating> AttachmentFilesEating { get; set; }
    public DbSet<Waypoint> Waypoints { get; set; }
    public DbSet<WaypointFile> WaypointFiles { get; set; }
    public DbSet<Entertainment> Entertainments { get; set; }
    public DbSet<Accommodation> Accommodations { get; set; }

    public RepositoryContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      foreach(var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
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
          },
          new User
          {
            Id = -2,
            Email = "test2@users.com",
            Password = CryptoUtils.HashPassword("test2222"),
            FirstName = "FirstName2",
            LastName = "LastName2",
            Gender = Gender.Female,
          },
          new User
          {
            Id = -3,
            Email = "test3@users.com",
            Password = CryptoUtils.HashPassword("test3333"),
            FirstName = "FFFF3",
            LastName = "LLLL3",
            Gender = Gender.Other,
          },
          new User
          {
            Id = -4,
            Email = "test4@users.com",
            Password = CryptoUtils.HashPassword("test4444"),
            FirstName = "LongFirstName4",
            LastName = "LongLastName4",
            Gender = Gender.Female
          },
          new User
          {
            Id = -5,
            Email = "test5@users.com",
            Password = CryptoUtils.HashPassword("test5555"),
            FirstName = null,
            LastName = "Last5",
            Gender = Gender.NotSpecified
          }
          );

      var moqCountries = new[] {
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

      var moqLanguages = new[] {
               new Language {Id = 1, Name = "English"},
               new Language {Id = 2, Name = "Russian"},
               new Language {Id = 3, Name = "Ukrainian"}
           };

      modelBuilder.Entity<Language>().HasData(moqLanguages);

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

      var moqUpcomingTrips = moqTrips
        .Select((trip, i) =>
        {
          trip.StartDate = DateTime.Now.AddYears(i / 3).AddMonths(i + 3).AddDays(2 * i);
          trip.EndDate = trip.StartDate.AddDays(15);
          trip.Id = i + 1;
          return trip;
        });

      modelBuilder.Entity<Trip>().HasData(moqUpcomingTrips);

      var waypoints = new List<Waypoint>();
      for (int i = 0; i < 10; i++)
      {
        waypoints.Add(new Waypoint
        {
          Id = i + 1,
          Order = i,
          TripId = i < 5 ? 1 : -1,
          City = $"{i}CitY{i}",
          DepartureDate = new DateTime(2021, i + 1, i + 1, i % 3, 3 * i, 0),
          ArrivalDate = new DateTime(2021, i + 1, i + 15, i % 4 + 1, 5 * i, 0),
          Details = "Купить зарядку для телефона",
          IsCompleted = i % 2 == 0,
          IsDetails = i % 3 == 0,
          PathLength = 78 * i + 43,
          PathTime = new TimeSpan(i + 2, i * 14 % 60, 0),
          Transport = (TransportTypes)(i % 5),
          ImageUrl = i % 2 == 0 ? "https://www.eurotourism.az/site/assets/files/1817/5-7_1.jpg" : "https://cdn.vuetifyjs.com/images/cards/plane.jpg"
        });
      }

      modelBuilder.Entity<Waypoint>().HasData(waypoints);


      modelBuilder.Entity<Ticket>()
       .HasOne(t => t.User)
       .WithMany(u => u.Tickets)
       .HasForeignKey("UserId");

      modelBuilder.Entity<Ticket>()
       .HasMany(t => t.Routes)
       .WithOne()
       .HasForeignKey(t => t.TicketId);

      modelBuilder.Entity<Ticket>().HasData(
          new Ticket { Id = -1, UserId = -1, Adults = 5, Children = 0 },
          new Ticket { Id = -2, UserId = -1, Adults = 4, Children = 0 },
          new Ticket { Id = -3, UserId = -1, Adults = 3, Children = 0 },
          new Ticket { Id = -4, UserId = -1, Adults = 2, Children = 0 },
          new Ticket { Id = -5, UserId = -1, Adults = 1, Children = 0 }
      );

      var moqDate = DateTime.Parse("2022-01-01T07:00:00.0000000Z");
      modelBuilder.Entity<TicketRoute>().HasData(
          new TicketRoute
          {
            Id = -1,
            TicketId = -1,
            Price = 1000,
            ArrivalCode = "KBP",
            ArrivalDateTime = moqDate.AddDays(2),
            DepartureCode = "KBK",
            DepartureDateTime = moqDate.AddDays(1)
          },
          new TicketRoute
          {
            Id = -2,
            TicketId = -1,
            Price = 900,
            ArrivalCode = "KBP",
            ArrivalDateTime = moqDate.AddDays(2),
            DepartureCode = "KBK",
            DepartureDateTime = moqDate.AddDays(1)
          },
          new TicketRoute
          {
            Id = -3,
            TicketId = -2,
            Price = 800,
            ArrivalCode = "KBP",
            ArrivalDateTime = moqDate.AddDays(2),
            DepartureCode = "KBK",
            DepartureDateTime = moqDate.AddDays(1)
          },
          new TicketRoute
          {
            Id = -4,
            TicketId = -2,
            Price = 700,
            ArrivalCode = "KBP",
            ArrivalDateTime = moqDate.AddDays(2),
            DepartureCode = "KBK",
            DepartureDateTime = moqDate.AddDays(1)
          },
          new TicketRoute
          {
            Id = -5,
            TicketId = -3,
            Price = 600,
            ArrivalCode = "KBP",
            ArrivalDateTime = moqDate.AddDays(2),
            DepartureCode = "KBK",
            DepartureDateTime = moqDate.AddDays(1)
          },
          new TicketRoute
          {
            Id = -6,
            TicketId = -3,
            Price = 500,
            ArrivalCode = "KBP",
            ArrivalDateTime = moqDate.AddDays(2),
            DepartureCode = "KBK",
            DepartureDateTime = moqDate.AddDays(1)
          },
          new TicketRoute
          {
            Id = -7,
            TicketId = -4,
            Price = 400,
            ArrivalCode = "KBP",
            ArrivalDateTime = moqDate.AddDays(2),
            DepartureCode = "KBK",
            DepartureDateTime = moqDate.AddDays(1)
          },
          new TicketRoute
          {
            Id = -8,
            TicketId = -4,
            Price = 300,
            ArrivalCode = "KBP",
            ArrivalDateTime = moqDate.AddDays(2),
            DepartureCode = "KBK",
            DepartureDateTime = moqDate.AddDays(1)
          },
          new TicketRoute
          {
            Id = -9,
            TicketId = -5,
            Price = 200,
            ArrivalCode = "KBP",
            ArrivalDateTime = moqDate.AddDays(2),
            DepartureCode = "KBK",
            DepartureDateTime = moqDate.AddDays(1)
          },
          new TicketRoute
          {
            Id = -10,
            TicketId = -5,
            Price = 100,
            ArrivalCode = "KBP",
            ArrivalDateTime = moqDate.AddDays(2),
            DepartureCode = "KBK",
            DepartureDateTime = moqDate.AddDays(1)
          }
      );

      modelBuilder.Entity<ScheduledPlaceToEat>().HasData(
        new ScheduledPlaceToEat
        {
          Id = -1,
          UserId = -1,
          DateTime = DateTime.Parse("2022-01-01T12:00:00.0000000Z"),
          NamePlace = "New York City Police Department",
          Notes = "Get as close to the station as possible and pray that the cops don't take you in",
          Link = "http://www.nyc.gov/nypd",
          GooglePlaceId = "ChIJYcHoGyRawokR9rSZ9FTdFMk",
          Lat = 40.71211479999999,
          Lng = -74.00189170000002
        }  
      );
      modelBuilder.Entity<Entertainment>();

      var random = new Random();

      var moqAccommodations = Enumerable.Range(3, 70)
        .Select(i =>
        {
          var randomDateTime = DateTime.Now.AddDays(random.Next(5, 1_000));
          return new Accommodation
          {
            Id = -i,
            Name = $"Moq Hotel #{random.Next(10_000, 100_000)}",
            ArrivalDateTime = randomDateTime,
            DepartureDateTime = randomDateTime.AddDays(random.Next(1, 7)),
            Address = $"Moq address #{random.Next(10_000, 100_000)}",
            GuestCount = random.Next(1, 11),
            RoomsCount = random.Next(1, 5),
            Link = "http://www.grand-hotel-ukraine.dp.ua",
            Price = 50 * random.Next(1, 101),
            Currency = "USD",
            Note = "056 790 1441",
            UserId = -1,
            CountryId = random.Next(1, 9)
          };
        });

      modelBuilder.Entity<Accommodation>().HasData(moqAccommodations);
    }
  }
}
