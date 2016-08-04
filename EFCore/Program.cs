using EF.DataSource;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EFCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new ExampleDbContext())
            {
                var xx = db.User
                    .Include(x => x.UserType)
                    .FirstOrDefault(x => x.UserId == 1);
            }
        }
    }
}