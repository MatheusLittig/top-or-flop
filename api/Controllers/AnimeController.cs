using api.Data.EFCore.Repositories;
using api.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimeController : ApiBaseController<Anime, EfCoreAnimesRepository>
  {
    public AnimeController(EfCoreAnimesRepository repository) : base(repository) { }
  }
}