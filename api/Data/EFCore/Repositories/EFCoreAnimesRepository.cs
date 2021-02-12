using api.Models;

namespace api.Data.EFCore.Repositories
{
  public class EfCoreAnimesRepository : EfCoreRepository<Anime, DataContext>
  {
    public EfCoreAnimesRepository(DataContext context) : base(context) {}
  }
}