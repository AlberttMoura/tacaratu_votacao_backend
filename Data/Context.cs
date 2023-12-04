using Microsoft.EntityFrameworkCore;
using TacaratuBackend.Models;

namespace TacaratuBackend.Data
{
  public class Context(IConfiguration config) : DbContext
  {
    private readonly IConfiguration _config = config;

    public virtual DbSet<AppName> AppNames { get; set; }
    public virtual DbSet<Votacao> Votacoes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        optionsBuilder.UseNpgsql(this._config.GetConnectionString("DefaultConnection"));
      }
    }
  }
}