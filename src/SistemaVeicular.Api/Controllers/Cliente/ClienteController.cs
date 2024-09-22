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

    public async Task<IActionResult> Created(ClienteDto model)
    {
        var cliente = await _clienteService.Created(model);



        return Ok();
    }
}
