﻿// <auto-generated />
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entities.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20200515172822_IncreaseLengthMockPasswords")]
    partial class IncreaseLengthMockPasswords
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                            Password = "0cy6qRLzxD3QlIuWRAgJglhK4naCwK1khtMXYUrocy4R7A98IFvyJgGS0u0rQuU2"
                        },
                        new
                        {
                            Id = -2,
                            Email = "test2@users.com",
                            Password = "pRpBVq2mZq/sFyneP5hfP9IfXdLxwcWqFddpI3Mksa30Qv5+l76BsbLoPyTsYJsr"
                        },
                        new
                        {
                            Id = -3,
                            Email = "test3@users.com",
                            Password = "MFUC0Wjm2iYvRI/rNJRBzQb+8/AHsN3GqLTkXj3UbPKxUwLgn3IsdNX3SplbVFHu"
                        },
                        new
                        {
                            Id = -4,
                            Email = "test4@users.com",
                            Password = "nFIQsPpOx+YiLz/v0KfbDG4VSsmAiPZyf5nvpfyztO9EZqAyXfkv421amL9TymAE"
                        },
                        new
                        {
                            Id = -5,
                            Email = "test5@users.com",
                            Password = "QGHv9Ph5Zs4Wamckp35z1tCgyknOdWwKzslA85YfJCPvONI994pAhF12LX4gdAbt"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
