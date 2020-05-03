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
                "Server=192.168.1.128,51528\\SQLEXPRESS;Database=master;User Id=sa;Password=server;"
                );

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User{Id = -1, Email = "test1@users.com", Password = "test1"},
                new User{Id = -2, Email = "test2@users.com", Password = "test2"},
                new User{Id = -3, Email = "test3@users.com", Password = "test3"},
                new User{Id = -4, Email = "test4@users.com", Password = "test4"},
                new User{Id = -5, Email = "test5@users.com", Password = "test5"}
                );
        }
    }
}