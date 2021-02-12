using api.Data.Mapping;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options)
      : base(options) { }

    public DbSet<Anime> Animes { get; set; }
    public DbSet<AnimeList> AnimeLists { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfiguration(new UserMap());
      modelBuilder.ApplyConfiguration(new AnimeMap());
      modelBuilder.ApplyConfiguration(new AnimeListMap());
    }
  }
}