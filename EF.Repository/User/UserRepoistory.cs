using EF.DataSource;
using EF.Repository.User.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EF.Repository.User
{
    public class UserRepoistory : IUserRepository
    {
        public DataSource.User Get(int userId)
        {
            using (var db = new ExampleDbContext())
            {
                return db.User
                    .Include(x => x.UserType)
                    .FirstOrDefault(x => x.UserId == userId);
            }
        }
    }
}