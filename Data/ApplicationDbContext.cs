using System;
using Microsoft.EntityFrameworkCore;
using MVCLabb4.Models;

namespace MVCLabb4.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Borrow> Borrows { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Borrow>()
                .HasOne(b => b.Customer)
                .WithMany(c => c.Borrows)
                .HasForeignKey(b => b.CustomerId);

            modelBuilder.Entity<Borrow>()
                .HasOne(b => b.Book)
                .WithMany(bk => bk.Borrows)
                .HasForeignKey(b => b.BookId);

            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, Name = "Anna", LastName = "Axelsson", Email = "anna@example.com", PhoneNumber = "1234567890" },
                new Customer { Id = 2, Name = "Bella", LastName = "Bengtsson", Email = "bella@example.com", PhoneNumber = "0987654321" },
                new Customer { Id = 3, Name = "Cristoffer", LastName = "Carlsson", Email = "christoffer@example.com", PhoneNumber = "1234567890" },
                new Customer { Id = 4, Name = "Daniel", LastName = "Danielsson", Email = "daniel@example.com", PhoneNumber = "0987654321" }
            );

            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "Lord of the Rings", Author = "J. R. R. Tolkien", IsReturned = false },
                new Book { Id = 2, Title = "Eragon", Author = "Christopher Paolini", IsReturned = false },
                new Book { Id = 3, Title = "Twilight", Author = "Stephenie Meyer", IsReturned = true },
                new Book { Id = 4, Title = "Dead Until Dark", Author = "Charlaine Harris", IsReturned = true }
            );

            modelBuilder.Entity<Borrow>().HasData(
                new Borrow { Id = 1, CustomerId = 1, BookId = 1, BorrowDate = DateTime.Now, ReturnDate = null },
                new Borrow { Id = 2, CustomerId = 2, BookId = 2, BorrowDate = DateTime.Now, ReturnDate = null }
            );
        }
    }
}
