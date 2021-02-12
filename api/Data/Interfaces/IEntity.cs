using System;

namespace api.Data.Interfaces
{
  public interface IEntity
  {
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedData { get; set; }
  }
}