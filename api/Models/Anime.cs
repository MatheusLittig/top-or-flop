using System;
using api.Data.Interfaces;

namespace api.Models
{
  public class Anime : IEntity
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Studio { get; set; }
    public string PromoPicture { get; set; }
    public Boolean Top { get; set; }
    public Boolean Flop { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedData { get; set; }
  }
}