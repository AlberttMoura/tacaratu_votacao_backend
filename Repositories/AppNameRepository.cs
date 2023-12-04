using TacaratuBackend.Data;
using TacaratuBackend.Models;

namespace TacaratuBackend.Repositories
{
  public class AppNameRepository(IConfiguration config) : IAppNameRepository
  {
    private readonly Context _context = new(config);

    public List<AppName> FindAll()
    {
      List<AppName> appNames = [.. this._context.AppNames];
      return appNames;
    }
  }
}