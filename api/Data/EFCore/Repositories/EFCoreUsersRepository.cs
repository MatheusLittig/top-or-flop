using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using api.Data.EFCore.Intefaces;
using api.Models;
using api.Services.Infra;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Data.EFCore.Repositories
{
  public class EFCoreUsersRepository : EFCoreRepository<User>, IEFCoreUsersRepository
  {
    public EFCoreUsersRepository(DataContext context) : base(context) { }

    public Task<User> GetUserByIdAsync(int id)
    {
      return GetAll().FirstOrDefaultAsync(user => user.Id == id);
    }

    public async Task<List<User>> GetAllUsersAsync()
    {
      return await GetAll().ToListAsync();
    }

    public async Task<dynamic> AuthenticateUser(string userName, string password)
    {
      var user =  await GetAll().FirstOrDefaultAsync(user =>
         user.UserName == userName && user.Password == password
      );

      if (user == null)
      {
        throw new Exception("User or password invalid");
      }

      user.Token = TokenService.GenerateToken(user);

      await Context.SaveChangesAsync();

      return user;
    }
  }
}