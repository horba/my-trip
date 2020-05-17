using Entities.Models;
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
                "Server=DELLVOSTRO3560;Database=master;Integrated Security=True;"
                );

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = -1, Email = "test1@users.com", Password = CryptoUtils.HashPassword("test1111") },
                new User { Id = -2, Email = "test2@users.com", Password = CryptoUtils.HashPassword("test2222") },
                new User { Id = -3, Email = "test3@users.com", Password = CryptoUtils.HashPassword("test3333") },
                new User { Id = -4, Email = "test4@users.com", Password = CryptoUtils.HashPassword("test4444") },
                new User { Id = -5, Email = "test5@users.com", Password = CryptoUtils.HashPassword("test5555") }
                );
        }
    }
}