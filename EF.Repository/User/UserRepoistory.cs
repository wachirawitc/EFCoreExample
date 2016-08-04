using EF.DataSource;
using EF.Repository.User.Interface;

namespace EF.Repository.User
{
    public class UserRepoistory : IUserRepository
    {
        public DataSource.User Get(int userId)
        {
            using (var db = new ExampleDbContext())
            {
                return null;
            }
        }
    }
}