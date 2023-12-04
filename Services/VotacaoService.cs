using TacaratuBackend.DTOs;
using TacaratuBackend.Models;
using TacaratuBackend.Repositories;

namespace TacaratuBackend.Services
{
  public class VotacaoService(IVotacaoRepository votacaoRepository, IAppNameRepository appNameRepository)
  {
    private readonly IVotacaoRepository _votacaoRepository = votacaoRepository;
    private readonly IAppNameRepository _appNameRepository = appNameRepository;
    public List<VotacaoOutputDTO> ListarVotacao()
    {
      List<Votacao> votacoes = this._votacaoRepository.FindAll();
      List<AppName> appNames = this._appNameRepository.FindAll();

      List<VotacaoOutputDTO> resultados = appNames.Select(appName =>
      {
        return new VotacaoOutputDTO
        {
          AppNameId = appName.Id,
          AppName = appName.Nome,
          NumVotos = votacoes.Where(votacao => votacao.AppId == appName.Id).Select(votacao =>
          {
            return 1;
          }).Sum()
        };
      }).ToList();

      return resultados;
    }

    public Votacao? VotacaoSave(VotacaoSaveDTO novaVotacaoDTO)
    {
      Votacao? votacao = this._votacaoRepository.Save(new Votacao { AppId = novaVotacaoDTO.AppNameId });
      return votacao;
    }
  }
}