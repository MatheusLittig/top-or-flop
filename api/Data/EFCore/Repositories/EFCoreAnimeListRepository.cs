using System.Collections.Generic;
using System.Threading.Tasks;
using api.Data.EFCore.Intefaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data.EFCore.Repositories
{
  public class EFCoreAnimeListsRepository : EFCoreRepository<AnimeList>, IEFCoreAnimeListsRepository
  {
    public EFCoreAnimeListsRepository(DataContext context) : base (context) {}

    public async Task<AnimeList> GetAnimeListByIdAsync(int id)
    {
      return await GetAll().FirstOrDefaultAsync(animeList => animeList.Id == id);
    }

    public async Task<List<AnimeList>> GetAllAnimeListsAsync()
    {
      return await GetAll().ToListAsync();
    }
  }
}