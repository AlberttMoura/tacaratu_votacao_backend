using Microsoft.AspNetCore.Mvc;
using TacaratuBackend.DTOs;
using TacaratuBackend.Models;
using TacaratuBackend.Repositories;
using TacaratuBackend.Services;

namespace TacaratuBackend.Controllers
{
  [Route("[controller]")]
  [ApiController]
  public class VotacaoController(VotacaoService votacaoService) : ControllerBase
  {
    private VotacaoService _votacaoService = votacaoService;

    // [HttpGet("/")]
    // public List<Votacao> VotacaoFindAll()
    // {
    //   List<Votacao> votacoes = this._votacaoRepository.FindAll();
    //   return votacoes;
    // }

    [HttpPost("/")]
    public Votacao? VotacaoSave(VotacaoSaveDTO novaVotacaoDTO)
    {
      Votacao? votacao = this._votacaoService.VotacaoSave(novaVotacaoDTO);
      return votacao;
    }

    [HttpGet("")]
    public List<VotacaoOutputDTO> ResultadosVotacao()
    {
      return this._votacaoService.ListarVotacao();
    }
  }
}