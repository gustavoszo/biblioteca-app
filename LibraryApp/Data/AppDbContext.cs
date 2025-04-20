using System;
using LibraryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Data
{
    internal class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }

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
                      .HasDefaultValueSql("CURRENT_TIMESTAMP")
                      .HasColumnName("date_register");
            });
        }

    }
}
