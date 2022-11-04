﻿// <auto-generated />
using System;
using EntityFramework_Exam.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityFramework_Exam.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221013153417_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EntityFramework_Exam.Model.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ItemTypeId")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ItemTypeId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("EntityFramework_Exam.Model.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PropertyTypeId")
                        .HasColumnType("int");

                    b.Property<int>("TownId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PropertyTypeId");

                    b.HasIndex("TownId");

                    b.HasIndex("UserId");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("EntityFramework_Exam.Model.Town", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Towns");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Kyiv"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Rome"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Athens"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Cairo"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Paris"
                        });
                });

            modelBuilder.Entity("EntityFramework_Exam.Model.Trade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BuyerId")
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int?>("SellerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BuyerId");

                    b.HasIndex("ItemId");

                    b.HasIndex("SellerId");

                    b.ToTable("Trades");
                });

            modelBuilder.Entity("EntityFramework_Exam.Model.Types.ItemType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ItemTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Common"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Uncommon"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Rare"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Epic"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Legendary"
                        });
                });

            modelBuilder.Entity("EntityFramework_Exam.Model.Types.PropertyType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PropertyTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Flat"
                        },
                        new
                        {
                            Id = 2,
                            Name = "House"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Penthouse"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Mansion"
                        });
                });

            modelBuilder.Entity("EntityFramework_Exam.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TownId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("TownId");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ItemUser", b =>
                {
                    b.Property<int>("ItemsId")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("ItemsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("ItemUser");
                });

            modelBuilder.Entity("EntityFramework_Exam.Model.Item", b =>
                {
                    b.HasOne("EntityFramework_Exam.Model.Types.ItemType", "ItemType")
                        .WithMany()
                        .HasForeignKey("ItemTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ItemType");
                });

            modelBuilder.Entity("EntityFramework_Exam.Model.Property", b =>
                {
                    b.HasOne("EntityFramework_Exam.Model.Types.PropertyType", "PropertyType")
                        .WithMany()
                        .HasForeignKey("PropertyTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFramework_Exam.Model.Town", "Town")
                        .WithMany()
                        .HasForeignKey("TownId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFramework_Exam.Model.User", "User")
                        .WithMany("Properties")
                        .HasForeignKey("UserId");

                    b.Navigation("PropertyType");

                    b.Navigation("Town");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EntityFramework_Exam.Model.Trade", b =>
                {
                    b.HasOne("EntityFramework_Exam.Model.User", "Buyer")
                        .WithMany("PurschaseTrades")
                        .HasForeignKey("BuyerId");

                    b.HasOne("EntityFramework_Exam.Model.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFramework_Exam.Model.User", "Seller")
                        .WithMany("SaleTrades")
                        .HasForeignKey("SellerId");

                    b.Navigation("Buyer");

                    b.Navigation("Item");

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("EntityFramework_Exam.Model.User", b =>
                {
                    b.HasOne("EntityFramework_Exam.Model.Town", "Town")
                        .WithMany("Users")
                        .HasForeignKey("TownId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Town");
                });

            modelBuilder.Entity("ItemUser", b =>
                {
                    b.HasOne("EntityFramework_Exam.Model.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFramework_Exam.Model.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EntityFramework_Exam.Model.Town", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("EntityFramework_Exam.Model.User", b =>
                {
                    b.Navigation("Properties");

                    b.Navigation("PurschaseTrades");

                    b.Navigation("SaleTrades");
                });
#pragma warning restore 612, 618
        }
    }
}
