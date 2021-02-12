using System;
using api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api.Data.Mapping
{
  public class AnimeMap : IEntityTypeConfiguration<Anime>
  {
    public void Configure(EntityTypeBuilder<Anime> builder)
    {
      builder.Property(u => u.CreatedDate).HasDefaultValue(DateTime.Now);
    }
  }
}