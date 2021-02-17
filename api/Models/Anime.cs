using System;
using System.Text.Json.Serialization;
using api.Data.Interfaces;

namespace api.Models
{
  public class Anime : IEntity
  {
    [JsonIgnore]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Studio { get; set; }
    public string PromoPicture { get; set; }
    public Boolean Top { get; set; }
    public Boolean Flop { get; set; }

    [JsonIgnore]
    public DateTime CreatedDate { get; set; }

    [JsonIgnore]
    public DateTime UpdatedData { get; set; }
  }
}