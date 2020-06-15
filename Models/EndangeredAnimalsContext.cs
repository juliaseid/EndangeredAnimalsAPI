using Microsoft.EntityFrameworkCore;

namespace EndangeredAnimalsAPI.Models
{
  public class EndangeredAnimalsAPIContext : DbContext
  {
    public EndangeredAnimalsAPIContext(DbContextOptions<EndangeredAnimalsAPIContext> options)
        : base(options)
    {
    }

    public DbSet<Animal> Animals { get; set; }
  }
}