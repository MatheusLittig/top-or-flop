using System.Threading.Tasks;
using api.Models;
using api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
  [Route("api/[controller]")]
  public class AnimeListController : Controller
  {
    private readonly IAnimeListService _animeListService;

    public AnimeListController(IAnimeListService animeListService)
    {
      _animeListService = animeListService;
    }

    [HttpPost]
    public async Task<ActionResult<AnimeList>> CreateAnimeList([FromBody]AnimeList newList)
    {
      return await _animeListService.AddAnimeListAsync(newList);
    }

    [HttpPut]
    public async Task<ActionResult<AnimeList>> UpdateAnimeList(AnimeList list)
    {
      return await _animeListService.UpdateAnimeListAsync(list);
    }


    [HttpGet("{id}")]
    public async Task<ActionResult<AnimeList>> GetAnimeListById(int id)
    {
      return await _animeListService.GetAnimeListByIdAsync(id);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<AnimeList>> RemoveAnimeList(int id)
    {
      return await _animeListService.RemoveAnimeListAsync(id);
    }
  }
}