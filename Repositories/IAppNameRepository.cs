using TacaratuBackend.Models;

namespace TacaratuBackend.Repositories
{
  public interface IAppNameRepository
  {
    public List<AppName> FindAll();
  }
}