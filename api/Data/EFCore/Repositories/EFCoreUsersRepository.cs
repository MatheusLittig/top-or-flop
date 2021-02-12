using api.Models;

namespace api.Data.EFCore.Repositories
{
  public class EfCoreUsersRepository : EfCoreRepository<User, DataContext>
  {
    public EfCoreUsersRepository(DataContext context) : base(context) {}
  }
}