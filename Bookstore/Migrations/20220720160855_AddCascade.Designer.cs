﻿// <auto-generated />
using System;
using Bookstore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bookstore.Migrations
{
    [DbContext(typeof(BookstoreContext))]
    [Migration("20220720160855_AddCascade")]
    partial class AddCascade
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Bookstore.Models.AboutBook", b =>
                {
                    b.Property<int?>("AgeLimit")
                        .HasColumnType("int");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("Cover")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Description")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int?>("PublicationYear")
                        .HasColumnType("int");

                    b.Property<int?>("Weight")
                        .HasColumnType("int");

                    b.HasIndex(new[] { "BookId" }, "UQ__AboutBoo__3DE0C20636682691")
                        .IsUnique();

                    b.ToTable("AboutBooks");
                });

            modelBuilder.Entity("Bookstore.Models.AboutCustomer", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int?>("Discount")
                        .HasColumnType("int");

                    b.Property<int?>("NumberPurchases")
                        .HasColumnType("int");

                    b.HasIndex(new[] { "CustomerId" }, "UQ__AboutCus__A4AE64D9EC299A8B")
                        .IsUnique();

                    b.ToTable("AboutCustomer", (string)null);
                });

            modelBuilder.Entity("Bookstore.Models.AddressСustomer", b =>
                {
                    b.Property<string>("Apartment")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("City")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Home")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Street")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.HasIndex(new[] { "CustomerId" }, "UQ__AddressС__A4AE64D924A17972")
                        .IsUnique();

                    b.ToTable("AddressСustomer", (string)null);
                });

            modelBuilder.Entity("Bookstore.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Patronymic")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Bookstore.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("DescriptionId")
                        .HasColumnType("int");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.Property<int>("PublishingOfficeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("DescriptionId");

                    b.HasIndex("LanguageId");

                    b.HasIndex("ProviderId");

                    b.HasIndex("PublishingOfficeId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Bookstore.Models.CostBook", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int?>("CostDelivery")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("TimeDelivery")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasIndex(new[] { "BookId" }, "UQ__CostBook__3DE0C206823EF267")
                        .IsUnique();

                    b.ToTable("CostBooks");
                });

            modelBuilder.Entity("Bookstore.Models.CreditCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("CvvCvc")
                        .HasMaxLength(3)
                        .IsUnicode(false)
                        .HasColumnType("varchar(3)")
                        .HasColumnName("CVV/CVC");

                    b.Property<string>("Number")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("ValidThru")
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("CreditCard", (string)null);
                });

            modelBuilder.Entity("Bookstore.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Patronymic")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Phone")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Bookstore.Models.DescriptionBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Genre")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.ToTable("DescriptionBook", (string)null);
                });

            modelBuilder.Entity("Bookstore.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Patronymic")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Bookstore.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Language1")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("Language");

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("Bookstore.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Bookstore.Models.Provider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Providers");
                });

            modelBuilder.Entity("Bookstore.Models.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("Bookstore.Models.Storage", b =>
                {
                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.HasIndex(new[] { "BookId" }, "UQ__Storage__3DE0C2067EAFF645")
                        .IsUnique();

                    b.ToTable("Storage", (string)null);
                });

            modelBuilder.Entity("Bookstore.Models.AboutBook", b =>
                {
                    b.HasOne("Bookstore.Models.Book", "Book")
                        .WithOne()
                        .HasForeignKey("Bookstore.Models.AboutBook", "BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__AboutBook__BookI__571DF1D5");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("Bookstore.Models.AboutCustomer", b =>
                {
                    b.HasOne("Bookstore.Models.Customer", "Customer")
                        .WithOne()
                        .HasForeignKey("Bookstore.Models.AboutCustomer", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__AboutCust__Custo__398D8EEE");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Bookstore.Models.AddressСustomer", b =>
                {
                    b.HasOne("Bookstore.Models.Customer", "Customer")
                        .WithOne()
                        .HasForeignKey("Bookstore.Models.AddressСustomer", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__AddressСu__Custo__3F466844");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Bookstore.Models.Book", b =>
                {
                    b.HasOne("Bookstore.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .IsRequired()
                        .HasConstraintName("FK__Books__AuthorId__4F7CD00D");

                    b.HasOne("Bookstore.Models.DescriptionBook", "Description")
                        .WithMany("Books")
                        .HasForeignKey("DescriptionId")
                        .IsRequired()
                        .HasConstraintName("FK__Books__Descripti__4D94879B");

                    b.HasOne("Bookstore.Models.Language", "Language")
                        .WithMany("Books")
                        .HasForeignKey("LanguageId")
                        .IsRequired()
                        .HasConstraintName("FK__Books__LanguageI__4E88ABD4");

                    b.HasOne("Bookstore.Models.Provider", "Provider")
                        .WithMany("Books")
                        .HasForeignKey("ProviderId")
                        .IsRequired()
                        .HasConstraintName("FK__Books__ProviderI__5070F446");

                    b.HasOne("Bookstore.Models.Publisher", "PublishingOffice")
                        .WithMany("Books")
                        .HasForeignKey("PublishingOfficeId")
                        .IsRequired()
                        .HasConstraintName("FK__Books__Publishin__5165187F");

                    b.Navigation("Author");

                    b.Navigation("Description");

                    b.Navigation("Language");

                    b.Navigation("Provider");

                    b.Navigation("PublishingOffice");
                });

            modelBuilder.Entity("Bookstore.Models.CostBook", b =>
                {
                    b.HasOne("Bookstore.Models.Book", "Book")
                        .WithOne()
                        .HasForeignKey("Bookstore.Models.CostBook", "BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__CostBooks__BookI__5441852A");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("Bookstore.Models.CreditCard", b =>
                {
                    b.HasOne("Bookstore.Models.Customer", "Customer")
                        .WithOne()
                        .HasForeignKey("Bookstore.Models.CreditCard", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__CreditCar__CVV/C__3C69FB99");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Bookstore.Models.Order", b =>
                {
                    b.HasOne("Bookstore.Models.Book", "Book")
                        .WithMany("Orders")
                        .HasForeignKey("BookId")
                        .IsRequired()
                        .HasConstraintName("FK__Orders__BookId__5DCAEF64");

                    b.HasOne("Bookstore.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .IsRequired()
                        .HasConstraintName("FK__Orders__Customer__5CD6CB2B");

                    b.HasOne("Bookstore.Models.Employee", "Employee")
                        .WithMany("Orders")
                        .HasForeignKey("EmployeeId")
                        .IsRequired()
                        .HasConstraintName("FK__Orders__Employee__5EBF139D");

                    b.Navigation("Book");

                    b.Navigation("Customer");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Bookstore.Models.Storage", b =>
                {
                    b.HasOne("Bookstore.Models.Book", "Book")
                        .WithOne()
                        .HasForeignKey("Bookstore.Models.Storage", "BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__Storage__BookId__59FA5E80");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("Bookstore.Models.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Bookstore.Models.Book", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Bookstore.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Bookstore.Models.DescriptionBook", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Bookstore.Models.Employee", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Bookstore.Models.Language", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Bookstore.Models.Provider", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Bookstore.Models.Publisher", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
