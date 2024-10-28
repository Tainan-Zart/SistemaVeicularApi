using Microsoft.AspNetCore.Mvc;
using SistemaVeicular.Domain.Dtos.ClienteDtos;
using SistemaVeicular.Domain.Interfaces.ApplicationInterfaces.ClienteInterfaces;

namespace SistemaVeicular.Api.Controllers.Cliente;
[Route("api/[controller]")]
[ApiController]
public class ClienteController : ControllerBase
{
    private readonly IClienteService _clienteService;

    public ClienteController(IClienteService clienteService)
    {
        _clienteService = clienteService;
    }

    [HttpPost]
    [Route("cadastro")]
    public async Task<IActionResult> Cadastro(ClienteDto model)
    {
        var cliente = await _clienteService.Cadastrar(model);
        
        return Ok();
    }
}
