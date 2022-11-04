using EntityFramework_Exam.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework_Exam.Service.Configs;
using EntityFramework_Exam.Model.Types;

namespace EntityFramework_Exam.Service
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<Trade> Trades { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<PropertyType> PropertyTypes { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            switch (ProviderConfig.Provider)
            {
                case Provider.MSSQL:
                    optionsBuilder.UseSqlServer(ProviderConfig.MSSQL);
                    break;
                case Provider.SQLite:
                    optionsBuilder.UseSqlite(ProviderConfig.SQLite);
                    break;
                default:
                    throw new NotImplementedException("Provider!");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

            modelBuilder.Entity<Trade>()
                .HasOne(x => x.Seller)
                .WithMany(x => x.SaleTrades)
                .HasForeignKey(x => x.SellerId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Trade>()
                .HasOne(x => x.Buyer)
                .WithMany(x => x.PurschaseTrades)
                .HasForeignKey(x => x.BuyerId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<User>()
                .HasMany<Item>(u => u.Items)
                .WithMany(I => I.Users);

            modelBuilder.Entity<ItemType>()
                .HasData(
                new ItemType()
                {
                    Id = 1,
                    Name = "Common"
                },
                new ItemType()
                {
                    Id = 2,
                    Name = "Uncommon"
                },
                new ItemType()
                {
                    Id = 3,
                    Name = "Rare"
                },
                new ItemType()
                {
                    Id = 4,
                    Name = "Epic"
                },
                new ItemType()
                {
                    Id = 5,
                    Name = "Legendary"
                }
                );

            modelBuilder.Entity<PropertyType>()
                .HasData(
                new PropertyType()
                {
                    Id = 1,
                    Name = "Flat"
                },
                new PropertyType()
                {
                    Id = 2,
                    Name = "House"
                },
                new PropertyType()
                {
                    Id = 3,
                    Name = "Penthouse"
                },
                new PropertyType()
                {
                    Id = 4,
                    Name = "Mansion"
                }
                );

            modelBuilder.Entity<Town>()
                .HasData(
                new Town()
                {
                    Id = 1,
                    Name = "Kyiv"
                },
                new Town()
                {
                    Id = 2,
                    Name = "Rome"
                },
                new Town()
                {
                    Id = 3,
                    Name = "Athens"
                },
                new Town()
                {
                    Id = 4,
                    Name = "Cairo"
                },
                new Town()
                {
                    Id = 5,
                    Name = "Paris"
                }
                );
        }
    }
}
