﻿using Microsoft.EntityFrameworkCore;

namespace EFCore
{
    public partial class ExampleDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=GENESIS;Database=ExampleDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Password).HasColumnType("varchar(200)");

                entity.Property(e => e.UserName).HasColumnType("varchar(200)");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.Property(e => e.UserTypeId).ValueGeneratedNever();

                entity.Property(e => e.TypeName).HasColumnType("varchar(50)");
            });
        }

        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }
    }
}