using System;
using LibraryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Data
{
    internal class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<LoanBook> Loans_Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(b => b.Id);
                entity.Property(b => b.Id).HasColumnName("id");

                entity.Property(b => b.Title)
                      .IsRequired()
                      .HasMaxLength(200)
                      .HasColumnName("title");

                entity.Property(b => b.Author)
                      .HasMaxLength(100)
                      .HasColumnName("author");

                entity.Property(b => b.Publisher)
                      .HasMaxLength(100)
                      .HasColumnName("publisher");

                entity.Property(b => b.PublishYear)
                      .HasMaxLength(4)
                      .HasColumnName("publish_year");

                entity.Property(b => b.ISBN)
                      .IsRequired()
                      .HasMaxLength(20)
                      .HasColumnName("isbn");

                entity.Property(b => b.Genre)
                      .HasMaxLength(50)
                      .HasColumnName("genre");

                entity.Property(b => b.Total)
                      .IsRequired()
                      .HasColumnName("total");

                entity.Property(b => b.QuantityAvailable)
                      .IsRequired()
                      .HasColumnName("quantity_available");

                entity.Property(b => b.DateRegister)
                      .IsRequired()
                      .HasColumnName("date_register");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(c => c.Document);

                entity.Property(c => c.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(c => c.Document)
                    .IsRequired()
                    .HasColumnName("document");

                entity.Property(c => c.Phone)
                    .IsRequired()
                    .HasColumnName("phone");

                entity.Property(c => c.Email)
                    .HasColumnName("email");

                entity.Property(b => b.DateRegister)
                     .IsRequired()
                     .HasColumnName("date_register");
            });

            modelBuilder.Entity<Loan>(entity =>
            {
                entity.HasKey(l => l.Id);
                entity.Property(l => l.Id)
                    .HasColumnName("id");

                entity.Property(l => l.DocumentClient)
                    .IsRequired()
                    .HasColumnName("document_client");

                entity.Property(l => l.DateLoan)
                    .IsRequired()
                    .HasColumnName("date_loan");

                entity.HasOne(l => l.Client)
                .WithMany(c => c.Loans)
                .HasForeignKey(l => l.DocumentClient);
            });

            modelBuilder.Entity<LoanBook>(entity =>
            {
                entity.HasKey(lb => new { lb.LoanId, lb.BookId });

                entity.Property(lb => lb.LoanId)
                    .HasColumnName("loan_id");

                entity.Property(lb => lb.BookId)
                    .HasColumnName("book_id");

                entity.Property(lb => lb.Quantity)
                    .IsRequired()
                    .HasColumnName("quantity");

                entity.HasOne(lb => lb.Book)
                    .WithMany(b => b.LoanBooks)
                    .HasForeignKey(lb => lb.BookId);

                entity.HasOne(lb => lb.Loan)
                    .WithMany(l => l.LoanBooks)
                    .HasForeignKey(lb => lb.LoanId);
            });
        }

    }
}
