using System.Collections.Generic;
using System.Threading.Tasks;
using api.Models;
using api.Repositories;

namespace api.Data.EFCore.Intefaces 
{
  public interface IEFCoreAnimeListsRepository : IRepository<AnimeList>
  {
    Task<AnimeList> GetAnimeListByIdAsync(int id);
    Task<List<AnimeList>> GetAllAnimeListsAsync();
  }
}