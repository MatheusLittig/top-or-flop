using System;
using System.Collections.Generic;
using api.Data.Interfaces;

namespace api.Models
{
  public class User : IEntity
  {
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Token { get; set; }
    public List<AnimeList> AnimeLists { get; set; }
    public int Wins { get; set; }
    public int Loses { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedData { get; set; }
  }
}