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
   
    [HttpGet]
    [Route("buscar-por-id")]
    public async Task<IActionResult> BuscarPorId([FromBody]BuscaClienteIdDTo model)
    {
        var cliente = await _clienteService.BuscarPorId(model);
        return Ok(cliente);
    }

    [HttpGet]
    [Route("buscar-todos")]

    public async Task<IActionResult> BuscarTodos()
    {
        var clientes = await _clienteService.BuscarTodos();

        return Ok(clientes);
    }
    
}
