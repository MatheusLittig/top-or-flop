using System.Collections.Generic;
using System.Threading.Tasks;
using api.Data.EFCore.Intefaces;
using api.Models;
using api.Services.Interfaces;

namespace api.Services.Models
{
  public class UserService : IUserService
  {
    private readonly IEFCoreUsersRepository _usersRepository;

    public UserService(IEFCoreUsersRepository usersRepository)
    {
      _usersRepository = usersRepository;
    }

    public async Task<List<User>> GetAllUsersAsync()
    {
      return await _usersRepository.GetAllUsersAsync(); 
    }

    public async Task<User> GetUserByIdAsync(int id)
    {
      return await _usersRepository.GetUserByIdAsync(id);
    }

    public async Task<User> AddUserAsync(User newUser)
    {
      return await _usersRepository.AddAsync(newUser);
    }

    public async Task<dynamic> AuthenticateUser (string userName, string password)
    {
      return await _usersRepository.AuthenticateUser(userName, password);
    } 
  }
}