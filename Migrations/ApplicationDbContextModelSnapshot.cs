﻿// <auto-generated />
using System;
using MVCLabb4.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVCLabb4.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MVCLabb4.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsReturned")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "J. R. R. Tolkien",
                            IsReturned = false,
                            Title = "Lord of the Rings"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Christopher Paolini",
                            IsReturned = false,
                            Title = "Eragon"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Stephenie Meyer",
                            IsReturned = true,
                            Title = "Twilight"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Charlaine Harris",
                            IsReturned = true,
                            Title = "Dead Until Dark"
                        });
                });

            modelBuilder.Entity("MVCLabb4.Models.Borrow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<DateTime>("BorrowDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Borrows");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 1,
                            BorrowDate = new DateTime(2024, 6, 8, 14, 34, 59, 264, DateTimeKind.Local).AddTicks(6969),
                            CustomerId = 1
                        },
                        new
                        {
                            Id = 2,
                            BookId = 2,
                            BorrowDate = new DateTime(2024, 6, 8, 14, 34, 59, 264, DateTimeKind.Local).AddTicks(7007),
                            CustomerId = 2
                        });
                });

            modelBuilder.Entity("MVCLabb4.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "anna@example.com",
                            LastName = "Axelsson",
                            Name = "Anna",
                            PhoneNumber = "1234567890"
                        },
                        new
                        {
                            Id = 2,
                            Email = "bella@example.com",
                            LastName = "Bengtsson",
                            Name = "Bella",
                            PhoneNumber = "0987654321"
                        },
                        new
                        {
                            Id = 3,
                            Email = "christoffer@example.com",
                            LastName = "Carlsson",
                            Name = "Cristoffer",
                            PhoneNumber = "1234567890"
                        },
                        new
                        {
                            Id = 4,
                            Email = "daniel@example.com",
                            LastName = "Danielsson",
                            Name = "Daniel",
                            PhoneNumber = "0987654321"
                        });
                });

            modelBuilder.Entity("MVCLabb4.Models.Borrow", b =>
                {
                    b.HasOne("MVCLabb4.Models.Book", "Book")
                        .WithMany("Borrows")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVCLabb4.Models.Customer", "Customer")
                        .WithMany("Borrows")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("MVCLabb4.Models.Book", b =>
                {
                    b.Navigation("Borrows");
                });

            modelBuilder.Entity("MVCLabb4.Models.Customer", b =>
                {
                    b.Navigation("Borrows");
                });
#pragma warning restore 612, 618
        }
    }
}
