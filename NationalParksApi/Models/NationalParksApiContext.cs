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
      .HasData(new Park { ParkId = 1, Name = "Alagnak Wild River", Location = "Alaska", AreaKmSquared = 124, Description = "The Alagnak River flows from Kukaklek Lake in Katmai National Preserve and offers 67 miles of outstanding whitewater floating, scenery, recreation, historic, cultural and natural values. The river is also noted for abundant wildlife and sport fishing for five species of salmon. Established Dec. 2, 1980. Length: 67 miles." });


    }
  }
}