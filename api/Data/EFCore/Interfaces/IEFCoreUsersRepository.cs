using System.Collections.Generic;
using System.Threading.Tasks;
using api.Models;
using api.Repositories;

namespace api.Data.EFCore.Intefaces
{
  public interface IEFCoreUsersRepository : IRepository<User>
  {
    Task<User> GetUserByIdAsync(int id);
    Task<List<User>> GetAllUsersAsync();
    Task<dynamic> AuthenticateUser (string userName, string password);
  }
}