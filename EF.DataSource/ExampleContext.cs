using Microsoft.EntityFrameworkCore;

namespace EF.DataSource
{
    public class ExampleContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=GENESIS;Database=ExampleDb;Trusted_Connection=True;");
        }
    }
}