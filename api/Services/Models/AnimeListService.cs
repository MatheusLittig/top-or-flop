using System.Collections.Generic;
using System.Threading.Tasks;
using api.Data.EFCore.Intefaces;
using api.Models;
using api.Services.Interfaces;

namespace api.Services.Models
{
  public class AnimeListService : IAnimeListService
  {
    private readonly IEFCoreAnimeListsRepository _animeListRepository;

    public AnimeListService(IEFCoreAnimeListsRepository animeListRepository)
    {
      _animeListRepository = animeListRepository;
    }

    public async Task<AnimeList> AddAnimeListAsync(AnimeList newList)
    {
      return await _animeListRepository.AddAsync(newList);
    }

    public async Task<List<AnimeList>> GetAllAnimeLists()
    {
      return await _animeListRepository.GetAllAnimeListsAsync();
    }

    public async Task<AnimeList> GetAnimeListByIdAsync(int id)
    {
      return await _animeListRepository.GetAnimeListByIdAsync(id);
    }

    public async Task<AnimeList> RemoveAnimeListAsync(int id)
    {
      return await _animeListRepository.DeleteAsync(id);
    }

    public async Task<AnimeList> UpdateAnimeListAsync(AnimeList list)
    {
      return await _animeListRepository.UpdateAsync(list);
    }
  }
}