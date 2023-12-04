using Microsoft.AspNetCore.Mvc;
using TacaratuBackend.Models;
using TacaratuBackend.Repositories;

namespace TacaratuBackend.Controllers
{
  [Route("[Controller]")]
  [ApiController]
  public class AppNameController(IAppNameRepository appNameRepository) : ControllerBase
  {
    private readonly IAppNameRepository _appNameRepository = appNameRepository;

    [HttpGet]
    public List<AppName> AppNameFindAll()
    {
      return this._appNameRepository.FindAll();
    }
  }
}