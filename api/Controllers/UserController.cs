using System.Collections.Generic;
using System.Threading.Tasks;
using api.Models;
using api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
  [Route("api/[controller]")]
  public class UserController : Controller
  {
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
      _userService = userService;
    }

    [HttpPost]
    public async Task<ActionResult<User>> CreateUser(User user)
    {
      return await _userService.AddUserAsync(user);
    }

    [HttpGet]
    public async Task<ActionResult<List<User>>> GetAllUsers()
    {
      return await _userService.GetAllUsersAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetUserById(int id)
    {
      return await _userService.GetUserByIdAsync(id);
    }

    [HttpPost]
    [Route("login")]
    public async Task<ActionResult<dynamic>> AuthenticateUser(string userName, string password)
    {
      return await _userService.AuthenticateUser(userName, password);
    }
  }
}