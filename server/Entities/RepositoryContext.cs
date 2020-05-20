using Entities.Models;
using Entities.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class RepositoryContext : DbContext
    {

        public DbSet<User> Users { get; set; }

        public RepositoryContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb;Database=my-trip;Trusted_Connection=True;"
                );

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
        }
    }
}