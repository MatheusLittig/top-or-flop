using System;
using System.Collections.Generic;
using api.Data.Interfaces;

namespace api.Models
{
  public class AnimeList : IEntity
  {
    public int Id { get; set; }
    public ICollection<Anime> Animes { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedData { get; set; }
  }
}