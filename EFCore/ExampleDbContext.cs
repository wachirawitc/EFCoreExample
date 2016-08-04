using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

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

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.UserTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_User_UserType");
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