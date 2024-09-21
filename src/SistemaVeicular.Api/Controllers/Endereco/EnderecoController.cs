using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaVeicular.Domain.Dtos.EnderecoDtos;
using SistemaVeicular.Domain.Interfaces.ApplicationInterfaces;
using System.Reflection.Metadata.Ecma335;

namespace SistemaVeicular.Api.Controllers.Endereco;
[Route("api/[controller]")]
[ApiController]
public class EnderecoController : ControllerBase
{
    private IEnderecoService _enderecoService;

    public EnderecoController(IEnderecoService enderecoService)
    {
        _enderecoService = enderecoService;
    }

    [HttpPost]
    public async Task<IActionResult> Create(EnderecoDto model)
    {
        var endereco = await _enderecoService.Creted(model);

        return Ok(endereco);
    }
   
}
