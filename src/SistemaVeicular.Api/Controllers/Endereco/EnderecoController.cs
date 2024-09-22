using Microsoft.AspNetCore.Mvc;
using SistemaVeicular.Domain.Dtos.EnderecoDtos;
using SistemaVeicular.Domain.Interfaces.ApplicationInterfaces.EnderecoInterfaces;

namespace SistemaVeicular.Api.Controllers.Endereco;
[Route("api/[controller]")]
[ApiController]
public class EnderecoController : ControllerBase
{
    private readonly IViaCepIntegracao _viaCepIntegracao;

    public EnderecoController(IViaCepIntegracao viaCepIntegracao)
    {
        _viaCepIntegracao = viaCepIntegracao;
    }

    [HttpGet("{cep}")]
    public async Task<ActionResult<EnderecoViaCepDto>> BuscarCep(string cep)
    {
       var endereco = await _viaCepIntegracao.ObterDadosViaCep(cep);

       return Ok(endereco);
    }
   
}
