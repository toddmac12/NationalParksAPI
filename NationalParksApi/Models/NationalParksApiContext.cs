using Microsoft.EntityFrameworkCore;
using System;

namespace NationalParksApi.Models
{
  public class NationalParksApiContext : DbContext
  {
    public NationalParksApiContext(DbContextOptions<NationalParksApiContext> options)
        : base(options)
    {
    }

    public DbSet<Park> Parks { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
      .HasData(new Park { ParkId = 1, Name = "Park Name", Location = "Park Location", AreaKmSquared = 500, Description = "Park Description" });


    }
  }
}