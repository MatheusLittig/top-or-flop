using System.Collections.Generic;
using System.Threading.Tasks;
using api.Models;

namespace api.Services.Interfaces
{
  public interface IUserService
  {
    Task<List<User>> GetAllUsersAsync();
    Task<User> GetUserByIdAsync(int id);
    Task<User> AddUserAsync(User newUser);
    Task<dynamic> AuthenticateUser (string userName, string password);
  }
}