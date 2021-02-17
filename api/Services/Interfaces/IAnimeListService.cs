using System.Collections.Generic;
using System.Threading.Tasks;
using api.Models;

namespace api.Services.Interfaces
{
  public interface IAnimeListService
  {
    Task<List<AnimeList>> GetAllAnimeLists();
    Task<AnimeList> GetAnimeListByIdAsync(int id);
    Task<AnimeList> AddAnimeListAsync(AnimeList newList);
    Task<AnimeList> UpdateAnimeListAsync(AnimeList list);
    Task<AnimeList> RemoveAnimeListAsync(int id);
  }
}