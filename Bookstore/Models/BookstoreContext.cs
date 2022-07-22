using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Bookstore.Models
{
    public partial class BookstoreContext : DbContext
    {
        public BookstoreContext()
        {
        }

        public BookstoreContext(DbContextOptions<BookstoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AboutBook> AboutBooks { get; set; } = null!;
        public virtual DbSet<AboutCustomer> AboutCustomers { get; set; } = null!;
        public virtual DbSet<AddressСustomer> AddressСustomers { get; set; } = null!;
        public virtual DbSet<Author> Authors { get; set; } = null!;
        public virtual DbSet<Book> Books { get; set; } = null!;
        public virtual DbSet<CostBook> CostBooks { get; set; } = null!;
        public virtual DbSet<CreditCard> CreditCards { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<DescriptionBook> DescriptionBooks { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Language> Languages { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<Provider> Providers { get; set; } = null!;
        public virtual DbSet<Publisher> Publishers { get; set; } = null!;
        public virtual DbSet<Storage> Storages { get; set; } = null!;
        public DbSet<Basket> Basket { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 3, Surname = "Bob", Name = "Anat", Patronymic = "Anat", Phone = "+23423425" },
                new Customer { Id = 4, Surname = "Pah", Name = "Kol", Patronymic = "Anat", Phone = "+37529928292" },
                new Customer { Id = 5, Surname = "Fok", Name = "Gen", Patronymic = "Anat", Phone = "+375333423425" }
            );
            modelBuilder.Entity<AboutBook>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.BookId, "UQ__AboutBoo__3DE0C20636682691")
                    .IsUnique();

                entity.Property(e => e.Cover)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.HasOne(d => d.Book)
                    .WithOne()
                    .HasForeignKey<AboutBook>(d => d.BookId)
                    .HasConstraintName("FK__AboutBook__BookI__571DF1D5");
            });

            modelBuilder.Entity<AboutCustomer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AboutCustomer");

                entity.HasIndex(e => e.CustomerId, "UQ__AboutCus__A4AE64D9EC299A8B")
                    .IsUnique();

                entity.HasOne(d => d.Customer)
                    .WithOne()
                    .HasForeignKey<AboutCustomer>(d => d.CustomerId)
                    .HasConstraintName("FK__AboutCust__Custo__398D8EEE");
            });

            modelBuilder.Entity<AddressСustomer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AddressСustomer");

                entity.HasIndex(e => e.CustomerId, "UQ__AddressС__A4AE64D924A17972")
                    .IsUnique();

                entity.Property(e => e.Apartment)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Home)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Street)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithOne()
                    .HasForeignKey<AddressСustomer>(d => d.CustomerId)
                    .HasConstraintName("FK__AddressСu__Custo__3F466844");
            });

            modelBuilder.Entity<Author>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Patronymic)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Books__AuthorId__4F7CD00D");

                entity.HasOne(d => d.Description)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.DescriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Books__Descripti__4D94879B");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Books__LanguageI__4E88ABD4");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Books__ProviderI__5070F446");

                entity.HasOne(d => d.PublishingOffice)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.PublishingOfficeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Books__Publishin__5165187F");
            });

            modelBuilder.Entity<CostBook>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.BookId, "UQ__CostBook__3DE0C206823EF267")
                    .IsUnique();

                entity.Property(e => e.TimeDelivery)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Book)
                    .WithOne()
                    .HasForeignKey<CostBook>(d => d.BookId)
                    .HasConstraintName("FK__CostBooks__BookI__5441852A");
            });

            modelBuilder.Entity<CreditCard>(entity =>
            {

                entity.ToTable("CreditCard");

                entity.Property(e => e.CvvCvc)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CVV/CVC");

                entity.Property(e => e.Number)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ValidThru)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithOne()
                    .HasForeignKey<CreditCard>(d => d.CustomerId)
                    .HasConstraintName("FK__CreditCar__CVV/C__3C69FB99");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Patronymic)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DescriptionBook>(entity =>
            {
                entity.ToTable("DescriptionBook");

                entity.Property(e => e.Genre)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Patronymic)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.Property(e => e.Language1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Language");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Orders__BookId__5DCAEF64");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Orders__Customer__5CD6CB2B");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Orders__Employee__5EBF139D");
            });

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.Property(e => e.Address)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.Property(e => e.Address)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Storage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Storage");

                entity.HasIndex(e => e.BookId, "UQ__Storage__3DE0C2067EAFF645")
                    .IsUnique();

                entity.HasOne(d => d.Book)
                    .WithOne()
                    .HasForeignKey<Storage>(d => d.BookId)
                    .HasConstraintName("FK__Storage__BookId__59FA5E80");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
