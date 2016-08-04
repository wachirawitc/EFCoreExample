namespace EF.Repository.User.Interface
{
    public interface IUserRepository
    {
        DataSource.User Get(int userId);
    }
}