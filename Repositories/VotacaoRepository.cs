using TacaratuBackend.Data;
using TacaratuBackend.Models;

namespace TacaratuBackend.Repositories
{
  public class VotacaoRepository(IConfiguration config) : IVotacaoRepository
  {
    private readonly Context _context = new(config);

    public List<Votacao> FindAll()
    {
      List<Votacao> votacoes = [.. this._context.Votacoes];
      return votacoes;
    }

    public Votacao? Save(Votacao novaVotacao)
    {
      Votacao? votacao = this._context.Votacoes.Add(novaVotacao).Entity;
      int rows = this._context.SaveChanges();
      if (votacao != null || rows > 0)
        return votacao;
      return null;
    }
  }
}