using api.Data.EFCore.Repositories;
using api.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UserController : ApiBaseController<User, EfCoreUsersRepository>
  {
    public UserController(EfCoreUsersRepository repository) : base(repository) { }
  }
}