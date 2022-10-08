using System;
using Bookstore.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Model
{
    public class BookstoreContext: DbContext
    {
        public BookstoreContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<AboutBook> AboutBooks { get; set; } = null!;
        public DbSet<Author> Authors { get; set; } = null!;
        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<CostBook> CostBooks { get; set; } = null!;
        public DbSet<CreditCard> CreditCards { get; set; } = null!;
        public DbSet<Provider> Providers { get; set; } = null!;
        public DbSet<PublishingOffice> PublishingOffices { get; set; } = null!;
        public DbSet<Basket> Basket { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=BookStore;User Id=sa;Password=Valuetech@123;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasMany(a => a.Books)
                .WithOne(b => b.Author)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Book>()
                .HasOne(b => b.AboutBook)
                .WithOne(ab => ab.Book)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Book>()
                .HasOne(b => b.CostBook)
                .WithOne(c => c.Book)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

