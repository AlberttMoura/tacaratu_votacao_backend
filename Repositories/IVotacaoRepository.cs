using TacaratuBackend.Models;

namespace TacaratuBackend.Repositories
{
  public interface IVotacaoRepository
  {
    public List<Votacao> FindAll();
    public Votacao? Save(Votacao novaVotacao);
  }
}