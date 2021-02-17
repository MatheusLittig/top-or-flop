using System;
using api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api.Data.Mapping
{
  public class AnimeListMap : IEntityTypeConfiguration<AnimeList>
  {
    public void Configure(EntityTypeBuilder<AnimeList> builder)
    {
      builder.Property(u => u.CreatedDate).HasDefaultValue(DateTime.UtcNow);
      builder.HasOne(u => u.User).WithMany(a => a.AnimeLists);
    }
  }
}